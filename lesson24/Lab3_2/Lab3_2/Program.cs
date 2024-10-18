namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tao doi tuong contact voi contructor khong tham so
            Contact ct1 = new Contact();
            //gan gia tri ct1
            ct1.Id = 6;
            ct1.Firstname = "Nguyen Van";
            ct1.Lastname = "Khanh";
            ct1.Address = "Ha Noi";
            ct1.Phone = "1234567890";
            ct1.Email = "123@gmail.com";
            // tao doi tuong contact voi contructor co tham so
            Contact ct2 = new Contact(5, "Tran Thi", "My", "Ha noi", "0123456789","my@gmail.com");
            //hien thi thong tin
            ct1.Display();
            ct2.Display(); 

        }
    }
}