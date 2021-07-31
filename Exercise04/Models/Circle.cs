using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Exercise04.Models
{
    
    [Serializable]
    public class Circle:Shape
    {
        static double pi = 3.14;
        override
        public double Area()
        {
           
            var myarea = pi * this.Radius * this.Radius;
            return myarea;
        }
     //   override
        //public double Area { get; set; } = pi * this.Radius * this.Radius;
    }
}
