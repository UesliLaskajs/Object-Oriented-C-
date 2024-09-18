namespace ClassApp //The Namespace for all Class
{
    internal class Program //Internal Class of this Program
    {
        static void Main(string[] args)// The Main Class wich Everything will be instantiated
        {
           
            Car audi=new Car("Q7","Audi");//An instance of the Car Class
            Car benz = new Car("Cls", "Mercedez-Benz");

            Console.WriteLine("Enter Car Brand ");
            benz.CarBrand = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
