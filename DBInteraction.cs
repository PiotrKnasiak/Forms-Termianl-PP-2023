using kurwaaaaaaaaaaqaaaaaaaaaaaa;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormsyTest2
{
    internal class DBInteraction
    {
        private ManageDB connection;
        public DBInteraction(string server = "153.19.227.34, 1433", string DB = "ProjektPP2023", string UserName = "projekt2023", string password = "Projekt2023")
        {
            this.connection = new ManageDB(server, DB, UserName, password);
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
        private Event EventBuilder(int eventID, string name, string description, string dateStart, string dateEnd)
        {
            Event convertedE = new Event();
            convertedE.EventID = eventID;
            convertedE.name = name;
            convertedE.description = description;
            try
            {
                convertedE.dateStart = DateTime.Parse(dateStart);
                convertedE.dateEnd = DateTime.Parse(dateEnd);
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
            catch (Exception e)
            {
                failure = "Failure to load a specific user found by ID";
                return null;
            }
            if(loaded.Select().Length == 0) { user.ID = -1; return user; }
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
            catch (Exception e)
            {
                failure = "Failure to load a specific user found by login";
                return null;
            }
            DataRow row = loaded.Select()[0];
            user = this.UserBuilder((int)row["UserID"], (string)row["Name"], (string)row["Login"], (string)row["Password"]);
            return user;
        }
        public User[] LoadAllUsers()
        {
            User[] users = null;
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
            for(i = 0; i < whatToModify.Length; i++)
            {
                if (whatToModify[i] == "Login")
                {
                    DataTable checkResult = this.connection.TakeDataFromTable("LoginData", "*", $"Login = '{newValues[i]}' AND NOT UserID = {userID}");
                    if(checkResult.Select().Length != 0)
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
        public int AddUser(User userData)   // zwraca przypisane UserID
        {
            try
            {
                DataTable checkResult = this.connection.TakeDataFromTable("LoginData", "*", $"Login = '{userData.login}' AND NOT UserID = {userData.ID}");
                if (checkResult.Select().Length != 0)
                {
                    this.failure = "Login Is Already Taken (from AddUser)";
                    return 0;
                }
            }
            catch { }

            this.connection.PutDataIntoTable("LoginData", new object[] { userData.name, userData.login, userData.password }, "([Name], [Login], [Password])");

            try
            {
                userData = (User)LoadUser(userData.login);
                if(userData == null) { throw new ArgumentException(); }
            }
            catch (Exception e)
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
                failure = "";
            }

            return userData.ID;
        }
        public bool DeleteUser(int userID)
        {
            // usówanie użytkownika z listy użytkowników
            try
            {
                this.connection.DeleteDataFromTable("LoginData", $"UserID = {userID}");
            }
            catch (Exception e)
            {
                failure = $"Failed to delete user {userID}";
                return false;
            }
            // usówanie listy wydarzeń użytkownika
            try
            {
                this.connection.DropTable($"User{userID}Table");
            }
            catch (Exception e)
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
            DataTable dt = connection.TakeDataFromTable($"User{userID}Events","*","")
            return null;
        }
        public Event[] LoadAllEvents(int userID)
        {
            return null;
        }
        public bool ModifyEvent(int userID, int eventID, string toModoify, string newValue)
        {
            return true;
        }
        public int AddEvent(int userID, Event eventData)   // zwraca EventID
        {
            return 1;
        }
        public bool DeleteEvent(int userID, int eventID)
        {
            return true;
        }
        #endregion

    }
}
