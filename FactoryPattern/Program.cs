namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires for your vehicle.");

            int userInput = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(userInput);

            vehicle.Drive();
        }
    }
}
