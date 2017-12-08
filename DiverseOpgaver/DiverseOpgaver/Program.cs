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
            Person person = new Person();
            Produkt produkt = new Produkt();
            Ansat ansat = new Ansat();
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
                case "8":
                    opgaver.Opgave8();
                    break;
                case "9":
                    opgaver.Opgave9();
                    break;
                case "10":
                    opgaver.Opgave10();
                    break;
                case "11":
                    opgaver.Opgave11();
                    break;
                case "12":
                    opgaver.Opgave12();
                    break;
                case "13":
                    opgaver.Opgave13();
                    break;
                case "14":
                    opgaver.Opgave14();
                    break;
                //opgave 33
                case "33":
                    Person abraham = new Person("Abraham", "Lincoln");
                    Person gilbert = new Person("Gilbert", "Skysovs");
                    Person flomme = new Person("Flomme");
                    Person blomme = new Person("Blomme");
                    Person alexandre = new Person("Alexandre");
                    
                    
                    break;
                case "37":
                    Produkt produkt1 = new Produkt(25.00, 10.00, 5.00);
                    produkt.Moms(produkt1);
                    break;
                case "38":
                    produkt.UdskrivPerson(produkt.OpretPerson(213.23,23123.242,123213.23)); 
                    break;
                case "40":
                    foreach (Person item in person.MakeAPerson())
                    {
                        Console.WriteLine("fornavn: {0}, efternavn: {1}, adresse: {2}, telefonnummer: {3}", item.fornavn, item.efternavn, item.adresse, item.tlfNr);
                    }
                    Console.WriteLine("Tryk på en vilkårlig tast for at forsætte");
                    Console.ReadKey();
                    break;
                case "44":
                    Ansat ansat1 = new Ansat("test1", "test2", "test3", "test4", 23213, 0.20);
                    Console.WriteLine(ansat.ProvisionCalculator(ansat1, 25000.00));
                    Console.WriteLine("Tryk på en vilkårlig tast for at forsætte");
                    Console.ReadKey();
                    break;
                case "45":
                    Ansat ansat2 = new Ansat("test1", "test2", "test3", "test4", 23213, 0.20);
                    Console.WriteLine(ansat.LoenCalculator(ansat2, 100000.00));
                    Console.WriteLine("Tryk på en vilkårlig tast for at forsætte");
                    Console.ReadKey();
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
        public void Continue()
        {
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Opgave1()
        {
            Console.WriteLine("Niels Rosenberg");
            Continue();
        }
        public void Opgave2()
        {
            int tal = 5;
            Console.WriteLine(tal);
            Continue();
        }

        public void Opgave3()
        {
            int tal = 3;
            string navn = "niels";
            char tegn = '|';
            Console.WriteLine("{0}, {1}, {2}", tal, navn, tegn);
            Continue();
        }
        public void Opgave4()
        {
            Console.WriteLine("\u00E6");
            Console.WriteLine("\u00C6");
            Continue();
        }
        public void Opgave5()
        {
            int tal = 1;
            Console.WriteLine("{0} Hej med dig", tal);
            Continue();
        }
        public void Opgave6()
        {
            string number = "4";
            int tal = int.Parse(number);
            Console.WriteLine("{0}", tal);
            Continue();
        }
        public void Opgave7()
        {
            int tal;
            double number = 4.43;
            tal = Convert.ToInt32(number);
            Console.WriteLine(tal);
            Continue();
        }
        public void Opgave8()
        {
            string fornavn;
            string efternavn;
            Console.WriteLine("Indtast fornavn");
            fornavn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn");
            efternavn = Console.ReadLine();

            Console.WriteLine("Dit navn er {0} {1}", fornavn, efternavn);
            Continue();
        }
        public void Opgave9()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Jeg er så god til at programmere");
            }
            Continue();
        }
        public void Opgave10()
        {
            string input;
            Console.WriteLine("Hvor mange gange vil du have programmet kører?");
            input = Console.ReadLine();
            if (int.TryParse(input,out int inputNumber))
            {
                for (int i = 0; i < inputNumber; i++)
                {
                    Console.WriteLine("Nu er jeg klart blevet bedre til det her");
                }

            }else
            {
                Console.WriteLine("Invalid input");
            }
            Continue();

        }
        public void Opgave11()
        {
            int tal = 5;
            int tal1 = 10;
            Console.WriteLine("{0} + {1} = {2}", tal, tal1, tal + tal1);
            Continue();
        }
        public void Opgave12()
        {
            string input;
            Console.WriteLine("Indtast navn");
            input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("Hej med dig {0}", input);
            }
          
            Continue();
        }
        public void Opgave13()
        {
            string input;
            Console.WriteLine("indtast alder");
            input = Console.ReadLine();
            if (int.TryParse(input, out int inputNumber))
            {
                if (inputNumber >= 5 && inputNumber <= 10)
                {
                    Console.WriteLine("Du er ung");
                }else if (inputNumber >= 11 && inputNumber <= 18)
                {
                    Console.WriteLine("Du er teenager");
                }else if (inputNumber >= 19 && inputNumber <= 40)
                {
                    Console.WriteLine("Du er middelaldrene");
                }else
                {
                    Console.WriteLine("Du er enten et barn eller ved at være gammel");
                }
            }else
            {
                Console.WriteLine("Invalid input");
            }
            Continue();
        }
        public void Opgave14()
        {
            string password = "Hansen";
            string username = "glas";
            string inputPassword;
            string inputUsername;

            Console.WriteLine("Indtast brugernavn");
            inputUsername = Console.ReadLine();
            Console.WriteLine("Indtast kodeord");
            inputPassword = Console.ReadLine();

            if (inputPassword == password && inputUsername == username)
            {
                Console.WriteLine("Velkommen til programmet");
            }else
            {
                Console.WriteLine("invalid username/password");
            }
        }
    }
    //opgave 31
    class Person
    {
        //opgave 32
        public string fornavn;
        public string efternavn;
        public string adresse;
        public string tlfNr;

        //opgave 32A
        public Person()
        {

        }
        public Person(string fnavn)
        {
            fornavn = fnavn;
        }
        public Person(string fnavn, string enavn)
        {
            fornavn = fnavn;
            efternavn = enavn;
        }
        public Person (string fnavn, string enavn, string adr, string tlf)
        {
            fornavn = fnavn;
            efternavn = enavn;
            adresse = adr;
            tlfNr = tlf;
        }

      
        //opgave 39
        public List<Person> MakeAPerson()
        {
            List<Person> list = new List<Person>();
            Person person1 = new Person("niels", "rosenberg", "Kettegård allé", "12345678");
            Person person2 = new Person("joakim", "jokke", "ugabuga vej", "12345678");
            Person person3 = new Person("test", "test2", "test3", "test4");
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            return list;
        }

  

        
    }
    //opgave 35 & 36
    class Produkt
    {
        public double pris;
        public double kilo;
        public double stoerrelse;

        public Produkt()
        {

        }
        public Produkt(double p, double k, double s)
        {
            pris = p;
            kilo = k;
            stoerrelse = s;
        }
        public void Continue()
        {
            Console.WriteLine("Tryk en vilkårlig tast for at forsætte");
            Console.ReadKey();
        }
        public void Moms(Produkt produkt)
        {
            Console.WriteLine("Prisen er {0}, Momsen er {1}", produkt.pris, produkt.pris * 0.25);
            Continue();
        }
        //opgave 38
        public Produkt OpretPerson(double p, double k, double s)
        {
            Produkt test = new Produkt(p, k, s);
            return test;
        }
        public void UdskrivPerson(Produkt produkt)
        {
            Console.WriteLine("pris: {0}, Kilo: {1}, Størrelse: {2}", produkt.pris, produkt.kilo, produkt.stoerrelse);
            Continue();
        }
 
      
    }
    class Ansat
    {
        public string fornavn;
        public string efternavn;
        public string adresse;
        public string tlfNr;
        private double loen;
        private double provision;

        public Ansat()
        {
 
        }

        public Ansat(string fnavn, string enavn, string adr, string tlf, double l, double p)
        {
            fornavn = fnavn;
            efternavn = enavn;
            adresse = adr;
            tlfNr = tlf;
            loen = l;
            provision = p;
        }
        public void SetLoen(double l)
        {
            loen = l;
        }
        public double GetLoen()
        {
            return loen;
        }
        public void SetProvision(double p)
        {
            provision = p;
        }
        public double GetProvision()
        {
            return provision;
        }

        public double ProvisionCalculator(Ansat ansat, double Totalsalg)
        {
            double ansatprovision = ansat.GetProvision() * Totalsalg;
            return ansatprovision;
        }
        public double LoenCalculator(Ansat ansat, double Totalsalg)
        {
            double ansatLoen = (ansat.GetProvision() * Totalsalg) + ansat.GetLoen();
            return ansatLoen;
        }
    }
    class Kunde
    {
        public string fornavn;
        private string efternavn;
        private string adresse;
        private string tlfNr;
        private string email;
        private double rabat;
        private double totalinkoeb;

        public Kunde(string fnavn, string enavn, string adr, string tlf, string e, double r, double total)
        {
            fornavn = fnavn;
            efternavn = enavn;
            adresse = adr;
            tlfNr = tlf;
            email = e;
            rabat = r;
            totalinkoeb = total;
        }

        public void SetEfternavn(string e)
        {
            efternavn = e;
        }
        public string GetEfternavn()
        {
            return efternavn;
        }
        public void SetAdresse(string adr)
        {
            adresse = adr;
        }
        public string GetAdresse()
        {
            return adresse;
        }
        public void SetTlfNr(string tlf)
        {
            tlfNr = tlf;
        }
        public string GetTlfNr()
        {
            return tlfNr;
        }
        public void SetEmail(string e)
        {
            email = e;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetRabat(double r)
        {
            rabat = r;
        }
        public double GetRabat()
        {
            return rabat;
        }
        public void SetTotalInkoeb(double t)
        {
            totalinkoeb = t;
        }
        public double GetTotalIndkoeb()
        {
            return totalinkoeb;
        }
    }
}
