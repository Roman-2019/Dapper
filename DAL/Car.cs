﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
        public Car()
        {
            Details = new List<Detail>();
        }

    }
}
