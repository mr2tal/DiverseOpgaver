using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.PrintMenu();
        }
    }
    class Menu
    {
        public void PrintMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Indtast valg");
                Console.WriteLine("1. Opgave");

                string inputmenu = Console.ReadLine();
                MenuChoose(inputmenu);
            }
        }
        public void MenuChoose(string input)
        {
            Opgaver opgaver = new Opgaver();
            
                switch (input.ToLower())
                {
                case "1":
                    opgaver.Opgave1();
                    break;
                case "2":
                opgaver.Opgave2();
                    break;
                case "3":
                    opgaver.Opgave3();
                    break;
                case "4":
                    opgaver.Opgave4();
                    break;
                case "5":
                    opgaver.Opgave5();
                    break;
                case "6":
                    opgaver.Opgave6();
                    break;
                case "7":
                    opgaver.Opgave7();
                    break;
                case "exit":
                    System.Environment.Exit(0);
                    break;
                default:
                        Console.WriteLine("indtast et gyldigt nummer");
                        break;
                }
        }
    }

    class Opgaver
    {
        public void Opgave1()
        {
            Console.WriteLine("Niels Rosenberg");
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Opgave2()
        {
            int tal = 5;
            Console.WriteLine(tal);
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }

        public void Opgave3()
        {
            int tal = 3;
            string navn = "niels";
            char tegn = '|';
            Console.WriteLine("{0}, {1}, {2}", tal, navn, tegn);
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Opgave4()
        {
            Console.WriteLine("\u00E6");
            Console.WriteLine("\u00C6");
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Opgave5()
        {
            int tal = 1;
            Console.WriteLine("{0} Hej med dig", tal);
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Opgave6()
        {
            string number = "4";
            int tal = int.Parse(number);
            Console.WriteLine("{0}", tal);
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Opgave7()
        {
            int tal;
            double number = 4.43;
            tal = Convert.ToInt32(number);
            Console.WriteLine(tal);
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
    }
}
