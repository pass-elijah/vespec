namespace Domain.Entities;

public class Inspection 
{
    public List<InspectionGroup> InspectionGroups { get; set; }
    public List<InspectionPoint> InspectionPoints { get; set; }
    public Vehicle Vehicle { get; set; }
}