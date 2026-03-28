namespace wwwww
{
    public class Letter : DeliveryItem
    {

        public Letter(string TrackingNumber, double Weight) : base(TrackingNumber, Weight)
        {

        }

        public override double CalculateCost()
        {
            double Cost = 15 + Weight * 10;

            return Cost;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($" Ціна доставки - {15 + Weight * 10}");
            Console.WriteLine();
        }
    }

}
