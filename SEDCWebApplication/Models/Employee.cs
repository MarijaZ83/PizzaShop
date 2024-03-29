﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; internal set; }
    }
}
