namespace FormsTermianlPP2023
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();

            if(ConnectionInfo.TimeTableTest)
                Application.Run(new Timetable());     // by testowac bepośrednio trzeba ustawić TimeTableTest na true w ConnectionInfo !
            else    
                Application.Run(new Logowanie());
        }
    }
}