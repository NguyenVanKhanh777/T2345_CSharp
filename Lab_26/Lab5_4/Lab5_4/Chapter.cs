using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    // cài đặt lớp chương 
    internal class Chapter
    {
        private string name;
        private string content;
        // constructor khong tham so
        public Chapter()
        {
            name = "";
            content = "";
        }
        // Constructor co tham so
        public Chapter(string name, string content)
        {
            this.name = name;
            this.content = content;
        }
        // dinh nghia cac thuoc tinh
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        // ghi đè phương thức tostring
        public override string ToString() 
        {
            return name+ "\n" +content ;
        }
    }
}
