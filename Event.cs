﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsyTest2
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
