using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {

        private static int Id_Customer=0;//Private Static Id belongs to class itself no matter of instantiation

        private readonly int IdCustomer; //Readonly Id so it creates immutable object that can only be assigned a value once

        public string Name { get; set; }//Getter Setter Properties to be Build in Constructor
        public string LastName { get; set; }
        public int Age { get; set; }

        public int _IdCustomer { get
            {
                return IdCustomer;
            } }


        private string password;//Private Backing Field

        public string _Password { set {  password = value; } }//Write-Only Set Property



        public Customer(string name, string lastName, int age)//Constructor with 3 Params that initalizes the getter Setter Properties
        {
            IdCustomer = Id_Customer++;//Increments The Id for every customer Object
            Name = name;
            LastName = lastName;
            Age = age;

        }

        public Customer(string name) {//Constructor with same Name 1 Param
            Name = name;
            IdCustomer = Id_Customer++;
        }

        public void SetDetails(string name, string lastName, int age) {
            Name = name;
            LastName = lastName;
            Age = age;
        }


        
        public void GetCustomerDetail()
        {
            Console.WriteLine($"Customer id {IdCustomer} Name:{Name} Lastname:{LastName} Age:{Age} ");
        }

        public static void Greet()//Static Method to Greet Customer Class once Called
        {
            Console.WriteLine("Hello");
        }

    }
}
