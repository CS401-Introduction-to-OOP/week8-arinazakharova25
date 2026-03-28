namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; set; }
    public bool Weight { get; set; }
    public DeliveryItem(string trackingNumber, bool weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{TrackingNumber}: {Weight}kg");
    }
}