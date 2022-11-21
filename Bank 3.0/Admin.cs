namespace Bank_3._0
{
    internal partial class MyBank
    {
        public void adminInlogg() 
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false) 
            {
                Console.Write("Användarnamn Admin : ");
                Inlogg = Console.ReadLine().ToLower();
                Console.Write("Password Admin : ");
                Pass = Console.ReadLine().ToLower();
                num++;
                if (Inlogg == "admin" && Pass == "admin")
                {
                    admin(); 
                    return; 
                }
                else
                {
                    if (num < 2)
                    {
                        Console.WriteLine("Fel inmatning, försök igen!");
                        
                    }
                    else if (num == 2)
                    {
                        
                        Console.WriteLine("Nu har du ett försök kvar!!");
                    }
                    else
                    {
                      
                        Console.WriteLine("Va fan, jag sa ju till dig!!. Nu loggas du ut!");
                        break;
                    }
                }
            }
        }
        public void admin() 
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
                    addUser(); 
                }
                else if (adminInput == 2)
                {
                    checkUser();
                }
                else if (adminInput == 3)
                {
                    Console.Clear();
                    
                    break;
                }
            }
            
        }
        public void addUser() 
        {
            try
            {
                Console.Write("Skriv användarnamn : ");
                string userAdd = Console.ReadLine();
                userList.Add(userAdd);
                Console.WriteLine("-------------------------------");

                Console.Write("Skriv in lösenord: ");
                string userPass = Console.ReadLine();
                passList.Add(userPass);
                Console.WriteLine("-------------------------------");

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
