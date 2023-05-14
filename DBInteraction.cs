using DBManagement;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsTermianlPP2023
{
    internal class DBInteraction
    {
        private ManageDB connection;
        public bool connected = true;
        public DBInteraction(string server = "153.19.227.34, 1433", string DB = "ProjektPP2023", string UserName = "projekt2023", string password = "Projekt2023", int timeout = 5)
        {
            this.connection = new ManageDB(server, DB, UserName, password);
            if (!this.connection.establishedConnection)
            {
                connected = false;
                this.failure = "Failed to connect to DB with specified variables";
            }
        }

        public string failure = "";

        /// <summary>
        /// Konwersja inta i stringów w User
        /// </summary>
        /// <returns>Objekt User</returns>
        private User UserBuilder(int id, string name, string login, string password)
        {
            User convertedU = new User();
            convertedU.ID = id;
            convertedU.name = name;
            convertedU.login = login;
            convertedU.password = password;

            return convertedU;
        }

        private Event EventBuilder(int eventID, string name, string description, DateTime dateStart, DateTime dateEnd)
        {
            Event convertedE = new Event();
            convertedE.EventID = eventID;
            convertedE.name = name;
            convertedE.description = description;
            try
            {
                convertedE.dateStart = dateStart;
                convertedE.dateEnd = dateEnd;
            }
            catch
            {
                failure = "Failure at converting dates form DB into an Event";
            }
            return convertedE;
        }

        //public Event testEvFormater()
        //{
        //    return this.EventBuilder(1, "tituł", "nicważnego", "1893-11-23 15:44", "1894-10-25 16:42");
        //}

        #region FunkcjeDlaUser
        public User LoadUser(int userID)
        {
            User user = new User();
            DataTable loaded = new DataTable();
            try
            {
                loaded = connection.TakeDataFromTable("LoginData", "*", $"UserID = {userID}");
            }
            catch
            {
                failure = "Failure to load a specific user found by ID";
                return UserBuilder(0, "error", "error", "error");
            }

            if (loaded.Select().Length == 0)
            {
                user.ID = -1;
                return user;
            }
            DataRow row = loaded.Select()[0];
            user = this.UserBuilder((int)row["UserID"], (string)row["Name"], (string)row["Login"], (string)row["Password"]);

            return user;
        }

        public User LoadUser(string login, string password)
        {
            User user = new User();
            DataTable loaded = new DataTable();

            try
            {
                loaded = connection.TakeDataFromTable("LoginData", "*", $"Login = '{login}' AND Password = '{password}'");

                if (loaded.Select().Length == 0) throw new Exception();
            }
            catch
            {
                failure = "Failure to load a specific user found by login and password";
                return UserBuilder(0, "error", "error", "error");
            }

            DataRow row = loaded.Select()[0];
            user = this.UserBuilder((int)row["UserID"], (string)row["Name"], (string)row["Login"], (string)row["Password"]);

            return user;
        }

        private User LoadUser(string login)
        {
            User user = new User();
            DataTable loaded = new DataTable();

            try
            {
                loaded = connection.TakeDataFromTable("LoginData", "*", $"Login = '{login}'");
                if (loaded.Select().Length == 0) throw new Exception();
            }
            catch
            {
                failure = "Failure to load a specific user found by login";
                return UserBuilder(0, "error", "error", "error");
            }

            DataRow row = loaded.Select()[0];
            user = this.UserBuilder((int)row["UserID"], (string)row["Name"], (string)row["Login"], (string)row["Password"]);

            return user;
        }

        public User[] LoadAllUsers()
        {
            User[] users = new User[0];
            DataTable loaded = new DataTable();

            try
            {
                loaded = connection.TakeDataFromTable("LoginData", "*");
            }
            catch (Exception e)
            {
                failure = "Failure to load all users";
                return null;
            }

            DataRow[] rows = loaded.Select();
            users = new User[rows.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                users[i] = this.UserBuilder((int)rows[i]["UserID"], (string)rows[i]["Name"], (string)rows[i]["Login"], (string)rows[i]["Password"]);
            }
            return users;
        }

        /// <summary>
        /// W whatToModify używać nazw z bazy danych
        /// <para>Nazwy zmiennych to : Name, Login (uwaga, nie może się powtażać), Password</para>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="whatToModify"></param>
        /// <param name="newValues"></param>
        /// <returns></returns>
        public bool ModifyUser(int userID, string[] whatToModify, string[] newValues)
        {
            int i;
            for (i = 0; i < whatToModify.Length; i++)
            {
                if (whatToModify[i] == "Login")
                {
                    DataTable checkResult = this.connection.TakeDataFromTable("LoginData", "*", $"Login = '{newValues[i]}' AND NOT UserID = {userID}");
                    if (checkResult.Select().Length != 0)
                    {
                        this.failure = "Login Is Already Taken, cannot change";
                        return false;
                    }
                    break;
                }
            }

            this.connection.ModifyDataInTable("LoginData", newValues, whatToModify, $"UserID = {userID}");
            return true;
        }

        /// <summary>
        /// Tworzy użytkownika i jego tabelę eventów (podanie już istniejącego loginu zwróci 0, czyli błąd)
        /// </summary>
        /// <param name="userData"></param>
        /// <returns>ID dodanego użytkownika lub 0 jeśli błąd</returns>
        public int AddUser(User userData)   // zwraca przypisane UserID
        {
            if(userData.login==null || userData.password==null || userData.name == null)
            {
                failure = "Adding user failed, provided user data is incomplete (has nulls)";
                return 0;
            }

            DataTable checkResult = this.connection.TakeDataFromTable("LoginData", "*", $"Login = '{userData.login}' AND NOT UserID = {userData.ID}");

            if (checkResult.Select().Length != 0)
            {
                this.failure = "Login Is Already Taken (from AddUser)";
                return 0;
            }

            this.connection.PutDataIntoTable("LoginData", new object[] { userData.name, userData.login, userData.password }, "[Name], [Login], [Password]");

            try
            {
                userData = (User)LoadUser(userData.login);
                if (userData == null) { throw new ArgumentException(); }
            }
            catch
            {
                failure = "AddUser has failed after uploading to DB";
                return 0;
            }

            try
            {
                this.connection.CreateEventTable($"User{userData.ID}Events");
            }
            catch
            {
                failure = $"Failed to create User {userData.ID}s Event table";
            }

            return userData.ID;
        }

        /// <summary>
        /// Usówa użytkownika o podanym ID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Określa czy operacja się powiodła</returns>
        public bool DeleteUser(int userID)
        {
            // usówanie użytkownika z listy użytkowników
            try
            {
                this.connection.DeleteDataFromTable("LoginData", $"UserID = {userID}");
            }
            catch
            {
                failure = $"Failed to delete user {userID}";
                return false;
            }
            // usówanie listy wydarzeń użytkownika
            try
            {
                this.connection.DropTable($"User{userID}Table");
            }
            catch
            {
                failure = $"Failed to delete user {userID}s event table";
                return false;
            }
            return true;
        }
        #endregion

        #region FunkcjeDlaEvent
        public Event LoadEvent(int userID, int eventID)
        {
            Event loadedEvent = EventBuilder(0, "error", "error", DateTime.Parse("997-11-20 13:37"), DateTime.Parse("1968-9-11 21:37"));
            DataTable dt = connection.TakeDataFromTable($"User{userID}Events", "*", $"EventID = {eventID}");

            try
            {
                DataRow dr = dt.Select()[0];
                loadedEvent = EventBuilder((int)dr["EventID"], (string)dr["Name"], (string)dr["Description"], (DateTime)dr["DateStart"], (DateTime)dr["DateEnd"]);
            }
            catch
            {
                failure = $"Failed to load event {eventID} of user with ID {userID}";
            }

            return loadedEvent;
        }

        /// <summary>
        /// Ładuje eventy z konkretnej daty
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Event[] LoadEventsOnDate(int userID, string date)
        {
            Event[] loadedEventList = new Event[0];
            DataTable dt = connection.TakeDataFromTable($"User{userID}Events", "*", $"DateStart <= '{date}' AND DateEnd >= '{date}'");

            try
            {
                DataRow[] drs = dt.Select();
                loadedEventList = new Event[drs.Length];

                for (int i = 0; i < drs.Length; i++)
                {
                    loadedEventList[i] = EventBuilder((int)drs[i]["EventID"], (string)drs[i]["Name"],
                        (string)drs[i]["Description"], (DateTime)drs[i]["DateStart"], (DateTime)drs[i]["DateEnd"]);
                }
                
            }
            catch
            {
                failure = $"Failed to load event on date : {date}, of user with ID {userID}";
            }

            return loadedEventList;
        }

        /// <summary>
        /// Ładuje eventy z konkretnego miesiąca
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="monthStartDate"></param>
        /// <returns></returns>
        public Event[] LoadEventsOnMonth(int userID, string monthStartDate)
        {

            DateTime nextMonth = DateTime.Parse(monthStartDate).AddMonths(1);

            Event[] loadedEventList = new Event[0];

            DataTable dt = connection.TakeDataFromTable($"User{userID}Events",
                "*", $"DateStart < '{nextMonth.ToString("yyyy-MM-dd")}' AND DateEnd >= '{monthStartDate}'");

            try
            {
                DataRow[] drs = dt.Select();
                loadedEventList = new Event[drs.Length];

                for (int i = 0; i < drs.Length; i++)
                {
                    loadedEventList[i] = EventBuilder((int)drs[i]["EventID"], (string)drs[i]["Name"],
                        (string)drs[i]["Description"], (DateTime)drs[i]["DateStart"], (DateTime)drs[i]["DateEnd"]);
                }

            }
            catch
            {
                failure += $"Failed to load events on month : {monthStartDate}, of user with ID {userID}\n";
                MessageBox.Show(failure);
            }

            return loadedEventList;
        }

        private Event LoadEventPriv(int userID, string name)
        {
            Event loadedEvent = EventBuilder(0, "error", "error", DateTime.Parse("997-11-20 13:37"), DateTime.Parse("1968-9-11 21:37"));
            DataTable dt = connection.TakeDataFromTable($"User{userID}Events", "*", $"Name = '{name}'");

            try
            {
                DataRow dr = dt.Select()[dt.Select().Length - 1];
                loadedEvent = EventBuilder((int)dr["EventID"], (string)dr["Name"], (string)dr["Description"], (DateTime)dr["DateStart"], (DateTime)dr["DateEnd"]);
            }
            catch
            {
                failure = $"Failed to load event with name {name}, of user with ID {userID}";
            }

            return loadedEvent;
        }

        public Event[] LoadAllEvents(int userID)
        {
            Event[] loadedEvents = null;
            DataTable dt = connection.TakeDataFromTable($"User{userID}Events", "*");

            try
            {
                DataRow[] drs = dt.Select();
                loadedEvents = new Event[drs.Length];

                for (int i = 0; i < drs.Length; i++)
                {
                    loadedEvents[i] = EventBuilder((int)drs[i]["EventID"], (string)drs[i]["Name"], (string)drs[i]["Description"], (DateTime)drs[i]["DateStart"], (DateTime)drs[i]["DateEnd"]);
                }
            }
            catch
            {
                failure = $"Failed to load events of user with ID {userID}";
            }

            return loadedEvents;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="eventID"></param>
        /// <param name="toModify"></param>
        /// <param name="newValue"></param>
        /// <returns>Określa czy operacja się powiodła</returns>
        public bool ModifyEvent(int userID, int eventID, Event modifiedEvent)
        {
            try
            {
                Event moddedEvent = LoadEvent(userID, eventID);
                if (moddedEvent == null) throw new ArgumentNullException();
            }
            catch
            {
                failure = $"Failed to modify an Event with ID {eventID}, belonging to user with ID {userID}, it cannot be loaded. (might not exist) ";
                return false;
            }

            object[] eventObj = new object[] { modifiedEvent.name, modifiedEvent.description, modifiedEvent.dateStart, modifiedEvent.dateEnd };
            string[] dataStructure = new string[] { "Name", "Description", "DateStart", "DateEnd" };

            try
            {
                connection.ModifyDataInTable($"User{userID}Events", eventObj, dataStructure, $"EventID = {eventID}");
            }
            catch (Exception ex)
            {
                failure = $"Failed to modify event {eventID} of user with ID {userID} \n {ex.Message}";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Dodaje do bazy danych Event dla wyspecyfikowanego urzytkownika
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="eventData"></param>
        /// <returns>Przypisane EventID (DODANIE WIĘCEJ NIŻ 1 EVENTU NA RAZ MOŻE SKUTKOWAĆ ZŁYM ID)</returns>
        public int AddEvent(int userID, Event eventData)
        {
            object[] eventObj = new object[] { eventData.name, eventData.description, eventData.dateStart, eventData.dateEnd };
            int assignedID = 0;

            try
            {
                connection.PutDataIntoTable($"User{userID}Events", eventObj, "[Name], [Description], [DateStart], [DateEnd]");
            }
            catch
            {
                failure = $"Failed to add an event for userID {userID}";
                return assignedID;
            }

            try
            {
                Event lastSimilar = LoadEventPriv(userID, eventData.name);
                assignedID = lastSimilar.EventID;
            }
            catch
            {
                failure = "Failed to fetch newly uploaded Events ID";
            }

            return assignedID;
        }

        /// <summary>
        /// Usówa event specyficznego użytkownika
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="eventID"></param>
        /// <returns>Określa czy operacja się powiodła</returns>
        public bool DeleteEvent(int userID, int eventID)
        {
            try
            {
                connection.DeleteDataFromTable($"User{userID}Events", $"EventID = {eventID}");
            }
            catch
            {
                failure = $"Failed to Delete an Event {eventID} of user with ID {eventID}";
                return false;
            }
            return true;
        }
        #endregion

    }
}
