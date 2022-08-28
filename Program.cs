namespace autoService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("Audi", "RS7", "r8", 5.2, "AWT");

            car.Print();

            Vehicle lorry = new Lorry("MAN", "TG - L", "v12", 5.9, "4*4");

            lorry.Print();
        }
    }
}
