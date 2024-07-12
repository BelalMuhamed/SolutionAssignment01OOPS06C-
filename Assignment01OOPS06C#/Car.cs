using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    internal class Car
    {
        private int id;
        private int speed;
        private string model;
        

        public Car(int id, int speed, string model):this(id, speed)
        {
            //this .id = id;  
            //this .speed = speed;
            this .model = model;
        }
       public Car (int id,int speed):this(id)
        {
            //this.id = id;   
            this .speed = speed;
        }
        public Car(int id)
        {
            this.id = id;
        }
        public override string ToString()
        {
            return $"{id} : {speed} : {model}";
        }
    }
}
