using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Exercise04.Models
{
     [Serializable]
    [XmlRoot(ElementName = "Shape")]
    public abstract class Shape
    {
       public string Color { get; set; }
       public double  Height { get; set; }
       public double Width { get; set; }
       public double Radius { get; set; }

        public virtual double Area ()
        {
            return 0;
        }
       
    }
}
