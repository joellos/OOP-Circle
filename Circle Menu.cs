using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Circle
{
    class Circle_Menu
    {
        public void CircleMenyn()
        {
            bool körProgram = true;

            while (körProgram)
            {
                double radius = 0;
                bool validNumber = false;

                // Loopa tills en giltig radie har matats in
                while (!validNumber)
                {
                    Console.Write("Ange radie för cirkeln: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out radius) && radius > 0)
                    {
                        validNumber = true; // Giltig radie, avsluta loopen
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ogiltig inmatning. Vänligen ange ett positivt heltal.");
                    }
                }

                // Skapa Circle-objektet efter att vi fått en giltig radie
                Circle circle = new Circle(radius);

                // Nu visa menyn och bearbeta användarens val
                bool menuChoiceValid = false;
                while (!menuChoiceValid)
                {
                    // Visa menyn
                    Console.WriteLine("\nVänligen välj ett alternativ från menyn:");
                    Console.WriteLine("1. Beräkna Area.");
                    Console.WriteLine("2. Beräkna Omkrets.");
                    Console.WriteLine("3. Beräkna Volym.");
                    Console.WriteLine("4. Gå tillbaka till huvudmenyn.");
                    Console.WriteLine("5. Avsluta program.");

                    // Läs in användarens val
                    string menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"Arean för cirkeln är: {circle.GetArea()}");
                            menuChoiceValid = true;
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine($"Omkretsen för cirkeln är: {circle.GetPerimeter()}");
                            menuChoiceValid = true;
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine($"Volymen är: {circle.GetVolume()}");
                            menuChoiceValid = true;
                            break;

                        case "4":
                            Console.Clear();
                            MainMenu showMainMenu = new MainMenu();
                            showMainMenu.ShowMainMenu();
                            menuChoiceValid = true;
                            break;

                        case "5":
                            Console.WriteLine("Avslutar programmet.");
                            körProgram = false; // Avsluta hela programmet
                            menuChoiceValid = true;
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