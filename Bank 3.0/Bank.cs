using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3._0
{
    internal partial class MyBank // Single class into multiple files and all these files are combined into a single class file when the application is compiled.
                                  //  A partial class is created by using a partial keyword.
    {
        public void start() 
        {

            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("|   Välj ett av altenativen     |");
                Console.WriteLine("|  1. Logga in som Admin        |");
                Console.WriteLine("|  2. Logga in som Privat kund  |");
                Console.WriteLine("|  3. Logga ut                  |");
                Console.WriteLine("|                               |");
                Console.WriteLine(DateTime.Now.ToString("|   dddd, dd MMMM yyyy    |"));
                Console.WriteLine("---------------------------------");
                Console.Write("Knappa in ditt val : ");
                int input = checkNr();
                Console.Clear(); 

                switch (input)
                {
                    case 1:
                        adminInlogg();
                        break;
                    case 2:
                        customerinlog();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tack för idag");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Fel val av siffra, tryck Enter för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        public int checkNr() 
        {
            int nr;
            while (!int.TryParse(Console.ReadLine(), out nr))
            {
                Console.WriteLine("inmatnings fel");
            }

            return nr;
        }
    }
}
