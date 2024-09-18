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

            customer.SetDetails("Bruno", "Laska", 13);//

            Console.WriteLine($"{customer.Name}");
            Console.ReadKey();
        }
    }
}
    