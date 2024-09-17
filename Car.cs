using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Car
    {

        private string _carName;
        private string _carBrand;

        public string CarName { get => _carName; set => _carName = value; }
        public string CarBrand { get => _carBrand; set => _carBrand = value; }

        public Car(string carname,string carBrand) {
            CarBrand = carBrand;
            CarName = carname;
            

            Console.WriteLine($"This is a {carname} of the {carBrand} Brand ");
        }

       
    }
}
