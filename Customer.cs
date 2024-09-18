using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Customer(string name,string lastName,int age)//Constructor with 3 Params that initalizes the getter Setter Properties
        {
            Name = name;
            LastName = lastName;
            Age = age;
            
        }

        public Customer(string name) {//Constructor with same Name 1 Param
            Name = name;
        }

        public void SetDetails(string name, string lastName, int age) {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        

    }
}
