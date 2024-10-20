using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Circle
{
    public class MainMenu
    {
        
        
        public void ShowMainMenu()
        {
            bool körProgram = true;

            while (körProgram)
            {

                

                bool validNumber = false;
                while (!validNumber) // Loopa menyn tills giltigt val görs
                {
                    // Visa menyn
                    Console.WriteLine("\nVänligen välj ett alternativ från mönster menyn:");
                    Console.WriteLine("1. Cirkel menyn.");
                    Console.WriteLine("2. Triangel menyn.");
                    Console.WriteLine("3. Avsluta program.");

                    // Läs in användarens val
                    string menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":
                            Circle_Menu meny = new Circle_Menu();
                            Console.Clear();
                            meny.CircleMenyn();
                            validNumber = true; // Återgå till radieinmatningen efter detta
                            break;

                        case "2":
                            Triangle_Menu meny2 = new Triangle_Menu();
                            Console.Clear();
                            meny2.TriangleMenyn();

                            validNumber = true;
                            break;

                        case "3":
                            Console.WriteLine("Avslutar programmet.");
                            körProgram = false; // Avsluta hela programmet
                            validNumber = true;
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
