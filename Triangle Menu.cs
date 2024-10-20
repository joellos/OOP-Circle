using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Circle
{
    class Triangle_Menu : Triangle
    {
        
        public void TriangleMenyn()
        {
            bool runProgram = true;

            while (runProgram)
            {

                Triangle triangle = new Triangle();

                bool validNumber = false;
                while (!validNumber) // Loopa menyn tills giltigt val görs
                {
                    // Visa menyn
                    Console.WriteLine("\nVänligen välj ett alternativ från menyn:");
                    Console.WriteLine("1. Beräkna Area.");
                    Console.WriteLine("2. Beräkna Omkrets.");
                    Console.WriteLine("3. Gå tillbaka till huvud menyn.");
                    Console.WriteLine("4. Avsluta program.");

                    // Läs in användarens val
                    string menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":

                            Console.Clear();
                            Console.WriteLine($"Arean för triangeln är: {triangle.GetArea()}");

                            validNumber = true; 
                            break;

                        case "2":

                            Console.Clear();
                            
                            Console.WriteLine($"Omkretsen för triangeln är: {triangle.GetPerimeter()}");
                            validNumber = true;
                            break;

                        case "3":
                            Console.Clear();
                            MainMenu showMainMenu = new MainMenu();
                            showMainMenu.ShowMainMenu();


                            validNumber = true;
                            break;

                        case "4":
                            Console.WriteLine("Avslutar programmet.");
                            runProgram = false; // Avsluta hela programmet
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                            break;
                    }
                }
            }
        }
    }
}
