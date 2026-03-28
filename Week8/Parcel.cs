using System.Globalization;

public class Parcel : DeliveryItem
{
    
    public string Dimensions { get; private set;  }
    
    public Parcel(string TrackingNumber, double Weight, string Dimensions) : base(TrackingNumber, Weight)
    {
        Dimensions = Dimensions;
    }

    public override double CalculateCost()
    {
        double Cost = 50 + Weight * 25;
        Console.WriteLine($"Ціна - {Cost}");

        return Cost;
    }


    public override void PrintInfo()
    {   
        base.PrintInfo();
        Console.WriteLine(Dimensions);
        Console.WriteLine($"Ціна доставки - {15 + Weight * 10}");
    }
}
