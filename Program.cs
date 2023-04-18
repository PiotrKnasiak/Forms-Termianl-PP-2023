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
            Application.Run(new Timetable());
            //Application.Run(new Logowanie());
        }
    }
}