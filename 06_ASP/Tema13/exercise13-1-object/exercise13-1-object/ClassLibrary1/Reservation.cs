﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Reservation
    {
        public string DNI { get; set; }
        public string serialNum { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
