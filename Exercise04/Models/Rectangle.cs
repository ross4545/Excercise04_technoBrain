using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Exercise04.Models
{

    [XmlInclude(typeof(Shape))]
    [Serializable]

  
   
    public class Rectangle : Shape
    {

        public double area()
        { 
            var myarea =  this.Height * this.Width;
            return myarea;
        }
    }
}
