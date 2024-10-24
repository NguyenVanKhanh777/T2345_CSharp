using System;

namespace DongVat
{
    // Main program to test all classes
    class Program
    {
        static void Main(string[] args)
        {
            AnCo.Bo bo = new AnCo.Bo(1, "Bo", 500);
            AnThit.CaSau caSau = new AnThit.CaSau(2, "Ca Sau", 300);

            Console.WriteLine($"{bo.Name}: ID = {bo.ID}, Weight = {bo.Weight}");
            Console.WriteLine($"{caSau.Name}: ID = {caSau.ID}, Weight = {caSau.Weight}");
        }
    }
}

namespace AnCo
{
    class Bo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public Bo(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }

    class Trau
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public Trau(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }

    class De
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public De(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }
}

namespace AnThit
{
    class CaSau
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public CaSau(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }

    class Ho
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public Ho(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }

    class SuTu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public SuTu(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }
}