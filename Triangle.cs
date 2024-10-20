using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Circle
{
    public class Triangle : IShapes
    {
        // Omkretsberäkning med felhantering
        public double GetPerimeter()
        {
            double a = ExceptionHandling("Ange sidan a: ");
            double b = ExceptionHandling("Ange sidan b: ");
            double c = ExceptionHandling("Ange sidan c: ");

            double perimeter = a + b + c;
            
            return perimeter;
        }

        // Areaberäkning med felhantering
        public double GetArea()
        {
            double trianglebase = ExceptionHandling("Ange basen: ");
            double height = ExceptionHandling("Ange höjden: ");

            double area = (trianglebase * height) / 2;
            
            return area;
        }

        // Felhantering metod som används i beräkningsmetoderna.
        private double ExceptionHandling(string message)
        {
            bool validNumber = false;
            double value = 0;
            // While-loop för att fortsätta tills det validNumber blir true. 
            while (!validNumber)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out value) && value > 0)
                {
                    validNumber = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ogiltig inmatning. Vänligen ange ett positivt heltal.");
                }
            }

            return value;
        }
    }
}
