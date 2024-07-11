using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Enacapsulation
{
    internal class Car
    {
        // private int id;
        //private string Model;
        // private double speed;
        public Car()
        {
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed{ get; set; }
        public override string ToString()
        {
            return $" Id is{Id}: \n Model is {Model} \n speed is{Speed}";
        }
    }

}
