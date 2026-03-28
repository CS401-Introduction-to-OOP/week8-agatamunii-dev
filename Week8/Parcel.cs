namespace wwwww
{
    using System.Globalization;

    public class Parcel : DeliveryItem
    {

        public string Dimensions { get; private set; }

        public Parcel(string TrackingNumber, double Weight, string dimensions) : base(TrackingNumber, Weight)
        {
            Dimensions = dimensions;
        }

        public override double CalculateCost()
        {
            double Cost = 50 + Weight * 25;
            return Cost;
        }


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($" Об'єм - {Dimensions}");
            Console.WriteLine($" Ціна доставки - {15 + Weight * 10}");
        }
    }
}
