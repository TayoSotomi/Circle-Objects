using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    public class Circle
    {
        //properties
        public double Radius {get; set;}
        public double Area { get; set;}
        public double Circumference { get; set; }



        //Methods
        public static int count = 0;

        public Circle (double radius)
        {
            Radius = radius;
            count++;

        }

        public double CalculateCircumference()
        {       
            double Circumference = 2 * Math.PI * Radius;
            return Circumference;
            

        }

        public string CalculateFormatedCircumference()
        {
            double Value = CalculateCircumference();
            return $"Circumference:  {FormatNumber(Value)}";
            

        }

        public double CalculateArea()
        {
            Area = Math.PI * (Radius * Radius);

            return Area;
            

        }

        public string CalculateFormattedArea()
        {
            double Value = CalculateArea();
            return $"Area:  {FormatNumber(Value)}";
            

        }


        private string FormatNumber(double Value)
        {
            return (Math.Round(Value, 2)).ToString();
            

        }

        public static int getCount()
        {
            return count;
        }


    }
}
