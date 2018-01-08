using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Demo
{
    public struct Customer
    {
        //Private Fields
        private int _id;
        private string _name;

        //Public Properties
        public int Id
        {
            get { return _id; }
            set {_id = value; }
        }

        public string Name
        {
            get{ return _name;}
            set{ _name = value; }
        }
        //Constructor
        public Customer(int Id,string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        //Method
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Amol");
            C1.PrintDetails();

            Customer C2 = new Customer();
            C2.Id = 102;
            C2.Name = "Mark";
            C2.PrintDetails();

            Customer C3 = new Customer   //Object Initializer syntax
            {
                Id = 103,
                Name ="John"
            };
            C3.PrintDetails();
            Console.ReadKey();

        }
    }
}
