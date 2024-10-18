using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Contact
    {
        // khai báo
        private int id;
        private string firstname;
        private string lastname;
        private string address;
        private string phone;
        private string email;
        // tạo constructor ko tham so
        public Contact()
        {

        }
        // tạo constructor voi cac tham so
        public Contact(int id, string firstname, string lastname,
        string address, string phone, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
        //tao thuoc tinh cho cac truong
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        // Dinh nghia phuong thuc Display
        public void Display()
        {
            Console.WriteLine("ma so:" + id);
            Console.WriteLine("Ho va ten:{0} {1}", firstname, lastname);
            Console.WriteLine("Dia chi:" + address);
            Console.WriteLine("Dien thoai:" + phone);
            Console.WriteLine("Email" + email);
        }
    }
}
