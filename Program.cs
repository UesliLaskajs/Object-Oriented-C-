namespace ClassApp //The Namespace for all Class
{
    internal class Program //Internal Class of this Program
    {
        static void Main(string[] args)// The Main Class wich Everything will be instantiated
        {
           
            Car audi=new Car("Q7","Audi",true);//An instance of the Car Class
            Car benz = new Car("Cls", "Mercedez-Benz",false);

            Console.WriteLine("Enter Car Brand ");
            benz.CarBrand = Console.ReadLine(); //Setting Value at CarBrand Property
            benz.Drive();
            Console.WriteLine($"{audi.CarBrand}");//Getting Value at CarBrand Property of instance audi of Class Car


            Customer customer = new Customer("Uesli", "Laska", 20);//Initialized an instance object of class Customer
            Customer customer1 = new Customer("Bruno", "Laska", 13);
            customer.GetCustomerDetail();
            customer1.GetCustomerDetail();
            customer.SetDetails("Bruno", "Laska", 13);//Set the Details of the Class From a Method Created in the class and called from the object



            Rectangle rectangle=new Rectangle();
            rectangle.width = 5;
            rectangle.height = 5;
            rectangle.Area();

            Customer.Greet();//This is a Static Method wich is no need to instantiate an object ,It Works on the class itself
            

            Console.WriteLine($"{customer.Name}");
            Console.ReadKey();
        }
    }
}
    