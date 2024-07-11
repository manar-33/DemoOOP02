using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Enacapsulation
{
    internal struct Employee
    {
        // //attributes
        // public int Id;
        // public string Name;
        // public decimal salary;

        // //constructor
        // public Employee(int id, string name, decimal salary)
        // {
        //     Id = id;
        //     Name = name;
        //     this.salary = salary;
        // }

        ////////////////
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value < 3000 ? 3000 : value; }
        }
        public int Age { get; set; }


        //public override string ToString() {
        //     return $"Id is {Id} \n Name is {Name}";}
        /////////////////////////
        //Encapsulation
        //private attributes
        // private int Id;
        // private string Name;
        // private decimal salary;
        //public string? GetName()
        //{ return Name; }
        //public void SetName(string _name) 
        //{
        //    Name = _name.Length > 5 ? _name.Substring(0,5) : _name;
        //}


    }
}
