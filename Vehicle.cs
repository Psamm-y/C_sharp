namespace Csharp_projects.Tasks;

public class Vehicle
{
    //Class attributes
    private String vehicleId;
    private String brand;
    private String model;
    private bool isAvailable;
    
    //Methods
    public Vehicle(String vehicleId, String brand, String model)
    {
        this.vehicleId = vehicleId;
        this.brand = brand;
        this.model = model;
        isAvailable = true; //Car is available initially
    }
    //Getters and Setters
    public String VehicleId { get; set; }
    public String Brand { get; set; }
    public String Model { get; set; }
    public bool IsAvailable { get; set; }

    //rent method
    public void RentVehicle()
    {
        if (isAvailable)
        {
            Console.WriteLine("Renting vehicle...");
            isAvailable = false;
            Console.WriteLine("Vehicle has been rented successfully.");
        }
        else
        {
            Console.WriteLine("Vehicle is not available at the moment.");
        }
        
    }

    //return method
    public void ReturnVehicle()
    {
        isAvailable = true;
        Console.WriteLine("Vehicle has been returned successfully.");
    }
    
    
    
}
