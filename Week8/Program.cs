using wwwww;

Letter fff = new Letter("123", 55);
Letter ggg = new Letter("222", 20);

Parcel aa = new Parcel("9", 300, "5x33x15");
Parcel bb = new Parcel("456787", 90, "10x6x44");

fff.PrintInfo();
bb.PrintInfo();

CargoContainer <DeliveryItem> myFff = new CargoContainer<DeliveryItem>();
myFff.AddItem(fff);
myFff.AddItem(ggg);
myFff.AddItem(aa);
myFff.AddItem(bb);

Console.WriteLine($"Сумарна ціна - {myFff.GetTotalCost()}");
