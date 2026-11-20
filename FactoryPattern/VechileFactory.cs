using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VechileFactory
    {

        public static IVechicle GetVechicle(string objType)
        {
            IVechicle objectType=null;
            if (objType.ToLower()==("bike"))
            {
                objectType = new Bike();
            }
            else if (objType.ToLower() == ("car"))
            {
                objectType = new Car();
            }

            return objectType;
        }
    }
}
