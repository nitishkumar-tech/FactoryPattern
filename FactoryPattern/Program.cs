using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args) /// factory is calss with method.that method will create and return objects based on the received input parameters

        {

            Console.WriteLine("enter Vehcile Type");
            string userInput = Console.ReadLine();

           IVechicle Type= VechileFactory.GetVechicle(userInput);

            Console.WriteLine("Vehcile Type is " + Type.VechicleType());
            Console.WriteLine("Number Of Wheels " + Type.NumberOfwheels());
        }
    }
}
