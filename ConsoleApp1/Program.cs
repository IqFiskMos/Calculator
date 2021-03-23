using System;

namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar Menyn
            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Välj ett val:");
                Console.WriteLine(" 0) Avsluta programmet");
                Console.WriteLine(" 1) Räkna ut något");
                Console.Write("\r\n Välj en siffra och tryck på ENTER: ");

                switch (Console.ReadLine())
                {
                    case "0":
                        return false;
                    case "1":
                        O1();
                        return true;
                    default:
                        return true;
                }
            }

            void O1()
            {
                // ´Strings som vi kommer använda under programmets gång
                int num1 = 0;
                int num2 = 0;

                //Introdution av programmet
                Console.WriteLine("Cennys kalkylator\r");
                Console.WriteLine("-----------------\n");

                //Insamling av talen vi vill använda
                Console.WriteLine("Skriv första siffran och tryck ENTER\r");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------\n");
                Console.WriteLine("Skriv andra siffran och tryck ENTER\r");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------\n");

                //Nu ber vi om vad som skall göras med dessa tal
                Console.WriteLine("Välj vad du vill göra\r");
                Console.WriteLine("\t+");
                Console.WriteLine("\t-");
                Console.WriteLine("\t*");
                Console.WriteLine("\t/");
                Console.Write("och tryck ENTER\n");

                //Visar oss resultatet beroende på vårat val
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine("-----------------\n");
                        Console.WriteLine($"Ditt resultat: {num1} + {num2} = " + (num1 + num2));
                        Console.WriteLine("-----------------\n");
                        break;
                    case "-":
                        Console.WriteLine("-----------------\n");
                        Console.WriteLine($"Ditt resultat: {num1} - {num2} = " + (num1 - num2));
                        Console.WriteLine("-----------------\n");
                        break;
                    case "*":
                        Console.WriteLine("-----------------\n");
                        Console.WriteLine($"Ditt resultat: {num1} * {num2} = " + (num1 * num2));
                        Console.WriteLine("-----------------\n");
                        break;
                    case "/":
                        Console.WriteLine("-----------------\n");
                        Console.WriteLine($"Ditt resultat: {num1} / {num2} = " + (num1 / num2));
                        Console.WriteLine("-----------------\n");
                        break;
                }

                //Ta mig tillbaka till huvudmenyn
                Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
        }
    }
}
