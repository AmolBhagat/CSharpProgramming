using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public int  Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Student id cannot be negative");
                }
                this._id = value; 
            }
            get
            {
                return this._id;
            }
        } 
       
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be set null or empty");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }
       
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
        public string Email { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Id = 101;
            stud.Name="Amol";
            stud.Email = "amol.dhanaji.bhagat@gmail.com";
            stud.City = "Pune";
            Console.WriteLine("Student Id = {0}", stud.Id);
            Console.WriteLine("Student Name = {0}", stud.Name);
            Console.WriteLine("PassMark = {0}", stud.PassMark);
            Console.WriteLine("Email = {0}", stud.Email);
            Console.WriteLine("City = {0}", stud.City);
            Console.ReadKey();
        }
    }
}
