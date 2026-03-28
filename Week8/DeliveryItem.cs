namespace wwwww
{
    public abstract class DeliveryItem
    {
        public string TrackingNumber { get; }
        public double Weight { get; protected set; }

        public DeliveryItem(string name, double weight)
        {
            TrackingNumber = name;
            Weight = weight;
        }

        public abstract double CalculateCost();

        public virtual void PrintInfo()
        {
            Console.WriteLine($" Delivery : {TrackingNumber} | weight : {Weight}");
        }
    }
}
