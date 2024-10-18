using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class StudentModel
    {
        // khai bao tap hop chua cac sinh vien
        List<Student> liststudent;
        //phuong thuc khoi tao
        public StudentModel()
        {
            // khoi tao list sinh vien
            this.liststudent = new List<Student> 
            {
                new Student(){Id=1,Name="Khanh",Age="21"},
                new Student(){Id=2,Name="Tuan",Age="19"},
                new Student(){Id=3,Name="My",Age="18"},
                new Student(){Id=4,Name="Anh",Age="20"},
                new Student(){Id=5,Name="me",Age="21"},
            };
        
        }
        #region cac phuong thuc overloading
        //phuong thuc tai ve list students
        public List<Student> GetStudent()
        {
            return liststudent;
        }
        //phuong thuc tra ve sinh vien theo Id
        public Student GetStudent (int id)
        {
            Student st = null;
            foreach (var item in liststudent) 
            {
                if (item.Id == id) 
                    st = item;
            }
            return st;
        }
        //phuong thuc tra ve sinh vien co Age x to y
        public List<Student> GetStudents(int x, int y) 
        { 
            List<Student> result = new List<Student>();
            foreach (var item in liststudent) 
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
