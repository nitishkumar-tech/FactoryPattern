using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Bike : IVechicle
    {

        private readonly int _Wheels;

        public Bike()
        {
            this._Wheels = 2;
        }
        int IVechicle.NumberOfwheels()
        {
            return this._Wheels;
        }

        string IVechicle.VechicleType()
        {
          return  "Bike";
        }
    }
}
