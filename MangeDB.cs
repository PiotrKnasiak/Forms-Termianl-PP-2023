using Microsoft.Data.SqlClient;
using System.Data;

namespace DBManagement
{
    public class ManageDB
    {
        string connectionString;
        SqlConnection conn;
        public bool establishedConnection = false;

        public ManageDB(string server = "153.19.227.34, 1433", string DB = "ProjektPP2023", string UserName = "projekt2023", string password = "Projekt2023", int timeout = 5)
        {
            this.connectionString = $@"Server={server};Database={DB};User Id={UserName}; Password={password}; Encrypt=False; Connect Timeout={timeout}";
            this.conn = new SqlConnection(connectionString);

            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                establishedConnection = true;
            }
            catch (Exception e)
            {
                establishedConnection = false;
            }
        }

        public DataTable TakeDataFromTable(string table, string dataToSelect = "*", string? condition = null)
        {
            DataTable dt = new DataTable();
            if (condition == null || condition == "")
                condition = "1=1";

            string querry = $@"SELECT {dataToSelect} FROM {table} WHERE {condition}";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, this.conn);
            adapter.Fill(dt);

            return dt;
        }

        /// <summary>
        /// wspierane typy danych to : int, string, DateTime
        /// dataStructure ma formę : (NazwaZmiennej1, NazwaZmiennej2)
        /// </summary>
        /// <param name="table"></param>
        /// <param name="dataStructure"></param>
        /// <param name="dataToInput"></param>
        /// <returns></returns>
        public void PutDataIntoTable(string table, object[] dataToInput, string dataStructure = "")
        {
            
            string injectable = "";
            string dTFormat = "yyyy-MM-dd HH:mm";

            for (int i = 0; i < dataToInput.Length; i++)
            {
                if (dataToInput[i].GetType() == typeof(string))
                {

                    injectable += $"'{dataToInput[i]}'";
                }
                else if (dataToInput[i].GetType() == typeof(int))
                {

                    injectable += $"{dataToInput[i].ToString()}";
                }
                else if (dataToInput[i].GetType() == typeof(DateTime))
                {
                    DateTime temp = (DateTime)dataToInput[i];
                    injectable += $"'{temp.ToString(dTFormat)}'";
                }

                if (i != dataToInput.Length - 1) injectable += ", ";
            }

            if (dataStructure.Length > 2)
            {
                if (dataStructure[0] != '(')
                    dataStructure = "(" + dataStructure;

                if (dataStructure[dataStructure.Length - 1] != ')')
                    dataStructure = dataStructure + ")";
            }

            string querry = $@"INSERT INTO {table} {dataStructure} VALUES ({injectable})";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
            }
            
        }

        public void ModifyDataInTable(string table, object[] dataToModify, string[] dataStructure, string condition)
        {
            
            string injectable = "";
            string dTFormat = "yyyy-MM-dd HH:mm";

            for (int i = 0; i < dataToModify.Length && i < dataStructure.Length; i++)
            {
                dataStructure[i] = dataStructure[i].Replace("[","").Replace("]","");

                if (dataToModify[i].GetType() == typeof(string))
                {
                    injectable += $"[{dataStructure[i]}] = '{dataToModify[i].ToString()}'\n";
                }
                else if (dataToModify[i].GetType() == typeof(int))
                {
                    injectable += $"[{dataStructure[i]}] = {dataToModify[i].ToString()}\n";
                }
                else if (dataToModify[i].GetType() == typeof(DateTime))
                {
                    DateTime temp = (DateTime)dataToModify[i];
                    injectable += $"[{dataStructure[i]}] = '{temp.ToString(dTFormat)}'\n";
                }

                if (i != dataToModify.Length - 1) injectable += ", ";
            }

            string querry = $"UPDATE [dbo].[{table}] SET {injectable} WHERE {condition}";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
            }
            
        }

        public void DeleteDataFromTable(string table, string condition)
        {
            
            string querry = $@"DELETE FROM [dbo].[{table}] WHERE {condition}";

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
            }
            
        }

        public void CreateEventTable(string tableName = "User(ID)Events")
        {
            
            string querry = $"SET ANSI_NULLS ON" +
                $"\nSET QUOTED_IDENTIFIER ON" +
                $"\nCREATE TABLE [dbo].[{tableName}]" +
                $"(\n[EventID] [int] IDENTITY(1,1) NOT NULL," +
                $"\n[Name] [nvarchar](76) NOT NULL," +
                $"\n[Description] [nvarchar](151) NULL," +
                $"\n[DateStart] [datetime2](0) NOT NULL," +
                $"\n[DateEnd] [datetime2](0) NOT NULL," +
                $"\n CONSTRAINT [PK_{tableName}] PRIMARY KEY CLUSTERED \n(\n[EventID] ASC\n)" +
                $"WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\n) ON [PRIMARY]";

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
            }
            

        }

        public void CreateUserTable(string tableName = "LoginData")
        {
            
            string querry = $"SET ANSI_NULLS ON" +
                $"\nSET QUOTED_IDENTIFIER ON" +
                $"\nCREATE TABLE [dbo].[{tableName}](" +
                $"\n[UserID] [int] IDENTITY(1,1) NOT NULL," +
                $"\n[Name] [varchar](50) NOT NULL," +
                $"\n[Login] [varchar](50) NOT NULL," +
                $"\n[Password] [varchar](50) NOT NULL," +
                $"\n CONSTRAINT [PK_{tableName}] PRIMARY KEY CLUSTERED ([UserID] ASC)" +
                $"\n WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY])\nON [PRIMARY]" +
                $"\nALTER TABLE [dbo].[{tableName}] ADD  CONSTRAINT [DF_{tableName}_Login]  DEFAULT ('') FOR [Login]";

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
            }
            

        }

        public void DropTable(string table)
        {
            

            string querry = $"DROP TABLE [dbo].[{table}]";

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
            }
            
        }

    }
}
