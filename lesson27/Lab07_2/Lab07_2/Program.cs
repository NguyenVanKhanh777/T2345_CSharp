namespace Lab07_2
{
    class Program
    {
        public void Main(string[] args)
        {
            // tạo đối tượng House trong namespace Business
            // bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.House house = new Business.House();
            // gán thông tin
            house.HouseNo = "D294AA";
            house.Price = 365456;
            // in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No" + house.HouseNo);
            Console.WriteLine("\t Price" + house.Price);
            // tạo đối tượng Car trong namespace Business.Dealership
            // bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0777";
            c.Price = 38425.50M;
            // in thông tin
            Console.WriteLine("Car Detail");
            Console.WriteLine("\t Car No: " + house.HouseNo);
            Console.WriteLine("\t Price: " + house.Price);
        }
    }
}