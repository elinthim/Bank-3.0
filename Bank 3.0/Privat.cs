namespace Bank_3._0
{
    internal partial class MyBank
    {
        string inlogg;
        string pass;

        Random randomAc = new Random();
        public int number3;

        // TODO Strongly consider making a User class with username and password property.
        public List<string> userList = new List<string>();
        public List<string> passList = new List<string>();
        public List<int> bankList = new List<int>();

        public string Pass
        {
            get => pass;
            set => pass = value;
        }
        public string Inlogg
        {
            get => inlogg;
            set => inlogg = value;
        }

        // OK! no recursive calls left.
        public void customerinlog() // Entry point from nMenu in Admin
        {
            bool check = false;
            int num = 0;
            while (check == false)
            {
                Console.Write("Användarnamn privatperson : ");
                Inlogg = Console.ReadLine();
                Console.Write("Password privatkund : ");
                Pass = Console.ReadLine();
                num++;

                var userfound = userList.Find(i => i.Equals(Inlogg));
                var userfound1 = passList.Find(i => i.Equals(Pass));

                if (userfound == Inlogg && userfound1 == Pass)
                {
                    usermeny();
                    return; // Return to nMenu
                }
                else if (userfound != Inlogg && userfound1 != Pass)
                {
                    Console.WriteLine("Fel inmatning, försök igen!");
                    Console.Clear();
                }

                if (num < 3)
                {
                    Console.WriteLine("Fel inmatning igen, skärp dig!");
                }
                else if (num == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Nu har du ett försök kvar!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Va fan, jag sa ju till dig!!. Nu loggas du ut!");
                    check = true;
                }
            }
            // return to nMenu in Admin.
        }
        public void usermeny()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till din användarmenyn");
                Console.WriteLine("1. Skapa nytt bankkonto");
                Console.WriteLine("2. Valuta ");
                Console.WriteLine("3. Se mina bankkonton");
                Console.WriteLine("4. Logga ut");
                int adminInput = checkNr();
                if (adminInput == 1)
                {
                    addAccount(); 
                }
                else if (adminInput == 2)
                {
                    valuta();
                }
                else if (adminInput == 3)
                {
                    banksaldo();
                }
                else if (adminInput == 4)
                {
                    Console.Clear();
                    break;

                }
            }

            // OK! no recursive calls left.


        }
        public void banksaldo()
        {
            Random random = new Random();

            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Lista över dina kontonummer");
            Console.WriteLine("-----------------------------------------------");
            foreach (var item1 in bankList)
            {

                Console.WriteLine("Kontonummer:" + item1 + ",  Banksaldo:" + (random.Next(0, 1000000)) + "kr");
                Console.WriteLine("-----------------------------------------------");
            }

            Console.ReadKey();
            return;
        }
        public void valuta()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Euro : 10.82 skr\n" +
                              "USD : 10.43 skr\n" +
                              "GBP : 12.41 skr\n" +
                              "NOK : 1.05 skr\n" +
                              "JPY : 7.49 skr");
            Console.WriteLine("----------------------------");

        }

        public void addAccount()
        {
            Console.Clear();
            number3 = randomAc.Next(1111111, 9999999);

            Console.WriteLine("Vill du skapa ett nytt bankkonto tryck enter.\nAnnars vänta kvar så skickas du automatsikt tillbaka till huvudmenyn");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Ditt nya kontonummer är : " + number3);
            bankList.Add(number3);

            Console.ReadKey();
        }
    }
}
