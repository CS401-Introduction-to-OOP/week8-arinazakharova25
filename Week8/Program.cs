namespace Week8;

class Program
{
    static void Main(string[] args)
    { 
        Letter letter1 = new Letter("12", 0.20);
        Letter letter2 = new Letter("13", 0.55);

        Parcel parcel1 = new Parcel("17", 12, "30x20x15");
        Parcel parcel2 = new Parcel("67", 16, "50x40x20");
    
        letter1.PrintInfo();
        parcel1.PrintInfo();
        Console.WriteLine();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        
        double totalSum = myCargo.GetTotalCost();
        Console.WriteLine($"Total Shipping Cost: {totalSum} UAH");
     
    }
}

