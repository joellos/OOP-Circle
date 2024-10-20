using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Circle
{
    public class Circle : IShapes
    {
        public double Radius {  get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public virtual double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public virtual double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
    