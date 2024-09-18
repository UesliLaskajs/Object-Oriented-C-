using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Car //Internal Class of This
    {

        private string _carName;//Member Value Of Class Car that are instantiated on the main Class
        private string _carBrand;

        public string CarName { get => _carName; set => _carName = value; }//Properties Getter and Setter That access Private Fields
        public string CarBrand { get => _carBrand;
            set { if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine("Input is Empty");
                    _carBrand = "Default_val";
                }
                else
                {
                    _carBrand = value;
                }
            }
        }

        public Car(string carname,string carBrand) {//Constructor Class of Car that initalised the Parameters of Car Class
            CarBrand = carBrand;
            CarName = carname;
            

            Console.WriteLine($"This is a {carname} of the {carBrand} Brand ");
        }

       
    }
}
