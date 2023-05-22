namespace FormsTermianlPP2023
{
    public partial class UserControlDays : UserControl
    {
        public int assignedDay = 0;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numDay)
        {
            lbdays.Text = numDay + "";
            assignedDay = numDay;
        }
    }
}
