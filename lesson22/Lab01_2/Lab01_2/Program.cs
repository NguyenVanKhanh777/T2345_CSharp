namespace Lab01_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao bien
            int id = 1;
            string name = "Khanh";
            byte age = 21;
            char gender = 'M';
            // khai bao hang so
            const float percent = 75.05F;

            // hien thi gia tri
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Percentage: {0}", percent);


        }
    }
}