using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Exercise04.Models
{
    [XmlInclude(typeof(Shape))]
    [Serializable]
    public class Circle:Shape
    {

        public double area()
        {
            double pi = 3.14;
            var myarea = pi * this.Radius * this.Radius;
            return myarea;
        }
    }
}
