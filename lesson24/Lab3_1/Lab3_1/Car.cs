using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Car
    {
        // khai báo các trường hợp vi phạm
        public string make;
        public string model;
        public string color;
        public int year;
        // định nghĩa phương thức start
        public void Start()
        {
            System.Console.WriteLine(model + "Khoi dong");
        }
        // định nghĩa phương thức stop
        public void Stop()
        {
            System.Console.WriteLine(model + "dung");
        }
    }
}
