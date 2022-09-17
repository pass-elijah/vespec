namespace Domain.Entities;

public class Vehicle : Entity<int>
{
    public string Name { get; set; }

    public VehicleType Type { get; set; }
}