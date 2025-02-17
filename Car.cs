namespace Csharp_projects.Tasks;

public class Car : Vehicle
{
    private int seatingCapacity;
    
    //constructor to initialize all inherited attributes and seating_capacity
    public Car(String vehicleId, String brand, String model, int seatingCapacity)
        : base(vehicleId, brand, model)
    {
        this.seatingCapacity = seatingCapacity;
    }
    
    //Rental cost method
    public void calculateRentalCost(int days)
    {
        double cost= 1000.0 * days +seatingCapacity*50;
        Console.WriteLine($"Rental cost for {days} days: ${cost}");
    }
    
    //Execution method / Program
    public static void Mains()
    {
        //instance of Car class
        Car car = new Car("V320","Ford", "Mustang", 6);
        //renting vehicle
        car.RentVehicle();
        //returning rented vehicle
        car.ReturnVehicle();
        //calculating rental cost
        car.calculateRentalCost(5);
    }
}