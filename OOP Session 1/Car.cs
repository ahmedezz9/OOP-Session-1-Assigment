using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_1
{
    internal class Car
    {
        private int id;
        private int speed;
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Id 
        { get { return id; }
            set { id = value; }
        }
        public Car()
        {
            Id = default;
            Model = default;
            Speed = default;   
        }

        public Car(int id,int speed, string model) : this(id, speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        public Car(int id, int speed)
        {
            Id = id;
            Speed = speed;
        }
        public override string ToString()
        {
            return $"Id: {Id}  Model: {Model}  Speed{Speed}";
        }
    }
}
