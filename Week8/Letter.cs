public class Letter : DeliveryItem
{
    public int Brightness { get; private set; }

    public Letter(string TrackingNumber, double Weight) : base(TrackingNumber, Weight)
    {

        Brightness = 100;
    }

    public override double CalculateCost()
    {
        double Cost = 15 + Weight * 10;
        Console.WriteLine($"Ціна - {Cost}");

        return Cost;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Ціна доставки - {15 + Weight * 10}");
    }
}
