using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            int tal = 0;
            bool i = true;
            Console.WriteLine("Skriv in ett heltal");
            int svar = int.Parse(Console.ReadLine());
            while (i = true)
            {
                Console.WriteLine(""); 
                Console.WriteLine("Vill du skriva in ett heltal till?");
                string svar2 = Console.ReadLine().ToLower();
                if (svar2 == "nej" || svar2 == "no" || svar2 == "jaa")
                {
                    i = true;
                    break;
                }
                else if (svar2 == "ja" || svar2 == "j" || svar2 == "yes" || svar2 == "y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Skriv in ett heltal");
                    svar = int.Parse(Console.ReadLine());
                    if (svar > tal)
                    {
                        tal = svar;
                    }
                    else
                    {
                        // Do nothing
                    }
                }
                else
                {

                    if (limit == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("DIN JÄVLA IDIOT, FUCK YOU!");
                        break;
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Skriv in Ja eller nej, tack.");
                    Console.WriteLine("");
                    Console.ForegroundColor= ConsoleColor.White;
                    Task.Delay(1000).Wait();
                    Console.Clear();

                    limit++;
                }

            }
            Console.WriteLine("");
            if (limit == 3)
            {
                Console.WriteLine("Ditt största tal är : din mammas vikt... (aka 2.3 ton.. bitch)");
            }
            else
            Console.WriteLine("Ditt största tal du skrev in var : " + tal);
            

        }
    }
}