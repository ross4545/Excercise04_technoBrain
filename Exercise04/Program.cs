using Exercise04.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string pathFile = @"D:\test\shapes.txt";

            var listOfShapes = new List<Shape>
            {
        new Circle
        {
            Color="Red",Radius=20.5,

        },

                new Rectangle
            {
                Color="Blue",Height=45.0,Width=18.0
            }
            };



            SerializeToXml(listOfShapes, pathFile);



            var loadShapesXml =  DeserializeToObject<List<Shape>>(pathFile);

            foreach(Shape item in loadShapesXml)
            {
                Console.WriteLine("{0} is {1} and has area of {2:N2}", item.GetType(),item.Color,item.Area());
            }
        }


        public static void SerializeToXml<T>(T anyobject, string xmlFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());

            using (StreamWriter writer = new StreamWriter(xmlFilePath))
            {
                xmlSerializer.Serialize(writer, anyobject);
            }
        }

        public static T DeserializeToObject<T>(string filepath) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StreamReader sr = new StreamReader(filepath))
            {
                return (T)ser.Deserialize(sr);
            }
        }

    }
}
    