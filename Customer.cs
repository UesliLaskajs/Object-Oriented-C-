using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {

        private static int Id_Customer=0;

        private readonly int IdCustomer; 

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Customer(string name, string lastName, int age)//Constructor with 3 Params that initalizes the getter Setter Properties
        {
            IdCustomer = Id_Customer++;
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

        public static void Greet()
        {
            Console.WriteLine("Hello");
        }

    }
}
