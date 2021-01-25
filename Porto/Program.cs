using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {

            double vægt;
            bool udland = false;
            bool quik = false;
            double pris;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("McTonnies porto regner");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hvor meget vejer dit brev");
                vægt = Taltjek.doubletjek();
                Console.WriteLine();
                Console.WriteLine("Vil du sende brev til udlandet"); //Spørg hvor brevet skal sendet hen 
                Console.WriteLine("1) Ja");
                Console.WriteLine("2) Nej");

                if (Taltjek.integertjek() == 1)
                {
                    udland = true;
                }
                else
                {
                    udland = false;
                }

                if (udland == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("skal brevet sendet som quikbrev");
                    Console.WriteLine("1) Ja");
                    Console.WriteLine("2) Nej");

                    if (Taltjek.integertjek() == 1)
                    {
                        quik = true;
                    }
                }
                if (quik == false)
                {
                    if (udland == false)
                    {
                        if (vægt <= 50)
                            pris = Priser.h50;
                        else if (vægt <= 100)
                            pris = Priser.h100;
                        else if (vægt <= 250)
                            vægt = Priser.h250;
                        else 
                            vægt = Priser.h2000;
                    }
                    else
                    {
                        if (vægt <= 50)
                            pris = Priser.h50u;
                        else if (vægt <= 100)
                            pris = Priser.h100u;
                        else if (vægt <= 250)
                            vægt = Priser.h250u;
                        else 
                            vægt = Priser.h2000u;
                    }
                }











            } while (Console.ReadKey().Key == ConsoleKey.R);









        }
    }
}
