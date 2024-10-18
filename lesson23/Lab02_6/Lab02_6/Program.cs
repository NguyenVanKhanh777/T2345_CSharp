namespace Lab02_6 {
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "thang", "long", "hoa", "dao" };
            Console.WriteLine("Danh sach sinh vien:\n");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}