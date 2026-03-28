namespace wwwww
{

    public class CargoContainer<T> where T : DeliveryItem
    {
        private List<T> _devices = new List<T>();

        public void AddItem(T item)
        {
            _devices.Add(item);
            Console.WriteLine($"Added: {item.TrackingNumber} (Type:{typeof(T).Name})");
        }

        public double GetTotalCost()
        {
            double allMoney = 0;
            foreach (T item in _devices) 
            {
                allMoney = +item.CalculateCost();
            }
            return allMoney;
        }
    }

}
