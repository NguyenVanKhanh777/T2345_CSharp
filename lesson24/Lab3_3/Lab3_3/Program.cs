namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // tao doi tuong
            StudentModel action = new StudentModel();
            //goi phuong thuc lay tat ca sinh vien
            List<Student> listall = action.GetStudent();
            // hien thi
            foreach (var item in listall)
            {
                item.Display();
            }
            // goi phuong thuc lay student theo id
            Student st = action.GetStudent(2);
            // hien thi
            st.Display();
            // goi phuong thuc lay student age 20, 21
            List<Student> listage = action.GetStudent(20,21);
            // hien thi
            foreach (var item in listage)
            {
                item.Display();
            }
        }

    }
}