using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Vehicle
    {
        public string plate { get; }

        public Vehicle(string plate)
        {
            this.plate = plate;
        }
    }
}