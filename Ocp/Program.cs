using Ocp.Vehicles;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Roxo", 2025, 2.0, 7, 4);
            }
            else
            {
                Motorcycle vehicle = new Motorcycle("Branca", 2025, 750);
            }
        }
    }
}
