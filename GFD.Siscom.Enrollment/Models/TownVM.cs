﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFD.Siscom.Enrollment.Models
{
    public class TownVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public StatesVM States { get; set; }
    }
}
