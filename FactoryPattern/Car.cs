using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVechicle
    {

        private readonly int _Wheels;

        public Car()
        {
            this._Wheels = 4;
        }
        int IVechicle.NumberOfwheels()
        {
            return this._Wheels;
        }

        string IVechicle.VechicleType()
        {
            return "Car";
        }
    }
}
