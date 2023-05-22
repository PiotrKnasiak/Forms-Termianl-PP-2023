namespace FormsTermianlPP2023
{
    public class Event
    {
        public string? name { get; set; }
        public string description { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public int EventID = 0;             // liczone od 1, 0 oznacza nieprzypisanie
    }
}
