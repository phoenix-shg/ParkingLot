﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
