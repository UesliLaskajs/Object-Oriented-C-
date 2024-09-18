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
        private bool _isLuxury;


        public string CarName { get => _carName; set => _carName = value; }//Properties Getter and Setter That access Private Fields
        public string CarBrand { get//used The Private Field _isLuxury on another getter Property
            {
                if (_isLuxury)
                {
                    return _carBrand += " Luxury Edition " ;
                }
                else
                {
                    return _carBrand;
                }
            }

            set { if (string.IsNullOrEmpty(value)) {//Set Properties To Modify Other Parameters that come from initaliztion of main Class
                    Console.WriteLine("Input is Empty");
                    _carBrand = "Default_val";
                }
                else
                {
                    _carBrand = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public void  Drive()
        {
             Console.WriteLine("Driving");
        }

        public Car(string carname,string carBrand,bool isLuxury) {//Constructor Class of Car that initalised the Parameters of Car Class
            CarBrand = carBrand;
            CarName = carname;
            IsLuxury= isLuxury;
            Console.WriteLine($"This is a {carname} of the {carBrand} ");
        }

        

       
    }
}
