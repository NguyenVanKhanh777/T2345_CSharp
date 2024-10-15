namespace Lab02_1
{
    static void Main( string[] args )
    {
        // khai bao bien
        string name;
        int number;
        double money = 0;
        //nhap thong tin
        Console.Write("Nhap ten thue bao:");
        name = Console.ReadLine();
        Console.Write("Nhap so diem su dung:");
        number = Convert.ToInt32(Console.ReadLine());
        // tinh toan so tien
        if (number <= 30)
            money = 30;
        else if (number > 30 && number <= 50)
            money = 30 + (number - 30) * 1.2;
        else if (number > 50)
            money = 30 + 20 * 1.2 + (number - 50) * 1.5;
        // in thong tin
        Console.WriteLine("\n Thong tin tien dien");
        Console.WriteLine("Ho va ten: {0}", name);
        Console.WriteLine("So dien su dung:{0:C}", money);
    }
}
