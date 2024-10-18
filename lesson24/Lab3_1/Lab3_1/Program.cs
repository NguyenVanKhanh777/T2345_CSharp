namespace Lab3_1
{
    internal class Program
    {
        /// <summary>
        /// minh họa khởi tọa đối tượng, truy cập các trường và phương thức
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args) {
            // khởi tạo car
            Car myCar = new Car();
            // gán giá trị cho các trường đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "red";
            myCar.year = 1918;

            // hiển thị thông tin về đối tượng 
            System.Console.WriteLine("Thong tin chi tiet: ");
            System.Console.WriteLine("Make" + myCar.make);
            System.Console.WriteLine("Model" + myCar.model);
            System.Console.WriteLine("Color" + myCar.color);
            System.Console.WriteLine("Year relase" + myCar.year);
            // gọi các phương thức
            myCar.Start();
            myCar.Stop();
        }
    }
}