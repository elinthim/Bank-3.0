namespace Bank_3._0
{
    internal partial class MyBank
    {
        public void adminInlogg() // Renamed from inlogg. Entry-point from nMenu() in this file.
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false) // Hallå hålla
            {
                Console.Write("Användarnamn Admin : ");
                Inlogg = Console.ReadLine().ToLower();
                Console.Write("Password Admin : ");
                Pass = Console.ReadLine().ToLower();
                num++;
                if (Inlogg == "admin" && Pass == "admin")
                {
                    admin(); // off to admin in this file.
                    return; // return early
                }
                else
                {
                    if (num < 3)
                    {
                        Console.WriteLine("Fel inmatning, försök igen!");
                        //gameOver = false;
                        //Console.Clear();
                    }
                    else if (num == 3)
                    {
                        //Console.Clear();
                        Console.WriteLine("Nu har du ett försök kvar!!");
                    }
                    else
                    {
                        //gameOver = true;
                        //Console.Clear();
                        Console.WriteLine("Va fan, jag sa ju till dig!!. Nu loggas du ut!");
                        break;
                    }
                }
            }
        }
        public void admin() // entry point from adminInlogg in this file.
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till inloggningen för Admin !!");
                Console.WriteLine("1. Lägga till användare");
                Console.WriteLine("2. Användare ");
                Console.WriteLine("3. Logga ut");
                int adminInput = checkNr();
                if (adminInput == 1)
                {
                    addUser(); // of to addUser in this file.
                }
                else if (adminInput == 2)
                {
                    checkUser();
                }
                else if (adminInput == 3)
                {
                    Console.Clear();
                    // nMenu(); a dream within a dream
                    break;
                }
            }
            // returns to adminInlogg in this file.
        }
        public void addUser() // entry point from admin() in this file.
        {
            int total;
            int num = 1;
            Console.Clear();
            try
            {
                Console.Write("Hur många vill du lägga till : ");
                total = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                for (int i = 0; i < total; i++)
                {
                    Console.Write($"Användarnamn {i + 1} : ");
                    string input;
                    do
                    {
                        input = Console.ReadLine();
                        if (input.Length < 5)
                        {
                            Console.WriteLine("Minst 5 tecken TACK");
                        }
                    } while (input.Length < 5);
                    userList.Add(input);
                }

                Console.WriteLine("-----------------------------------------");
                for (int i = 0; i < total; i++)
                {
                    Console.Write($"PassWord {i + 1} : ");
                    string input;
                    do
                    {
                        input = Console.ReadLine();
                        if (input.Length < 5)
                        {
                            Console.WriteLine("Minst 5 tecken TACK");
                        }
                    } while (input.Length < 5);
                    passList.Add(input);
                }
                Console.Clear();

            }
            catch
            {
                Console.WriteLine("Fel typ av inmatning använd siffror\nTryck enter");
                Console.ReadKey();
            }
            
        }
        public void checkUser()
        {
            Console.Clear();
            Console.WriteLine("Här kommer alla användare");
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Tryck Enter för att återvända till start");
            Console.ReadKey();
        }

    }
}
