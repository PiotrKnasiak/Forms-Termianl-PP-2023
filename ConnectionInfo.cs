namespace FormsTermianlPP2023
{
    public static class ConnectionInfo
    {
        public static int connTimeout = 2;

        public static void revertToDefault()
        {
            server = "153.19.227.34, 1433";
            DB = "ProjektPP2023";
            UserName = "projekt2023";
            password = "Projekt2023";
        }

        public static string server = "153.19.227.34, 1433"/*"DESKTOP-N1TTNKL"*/,
            DB = "ProjektPP2023",
            UserName = "projekt2023",
            password = "Projekt2023";

        public static object tempObj;
        public static int tempInt=3;
        public static string tempString;
        public static User loggedUser;
        public static bool TimeTableTest = false;
    }
}
