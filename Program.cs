namespace Console_app_with_Class_in_focus_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Name = "Volvo";
            car1.FuelConsumption = 5;


            Motorcycle moto1 = new Motorcycle();
            moto1.Name = "Yamaha";
            moto1.FuelConsumption = 3;

            car1.CalculateEfficiency();
            moto1.CalculateEfficiency();

            Console.ReadKey();
        }
    }
}
