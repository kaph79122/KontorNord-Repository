namespace KontorNord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramKøre = true;
            string LogudSvar = "";
            bool login = false;

            while (ProgramKøre == true)
            {
                Console.WriteLine("===============================================".PadLeft(50));
                Console.WriteLine("                BOOK ET MØDELOKALE             ".PadLeft(50));
                Console.WriteLine("===============================================".PadLeft(50));
                Console.WriteLine("");
                Console.WriteLine("    tryk på en vilkårlist tast for at forsætte...");
                Console.ReadKey();


                Console.Clear();


                Login(ref login);

                // SKRIV DIT LOGIN HER NEEGA 
                static void Login(ref bool login)
                {



                   
                   
                    // login skal ende med og være true før programmet fortsætter
                }
                while (login == true)
                {
                    Console.Clear();
                    Console.WriteLine("===============================================".PadLeft(50));
                    Console.WriteLine("                   HOVEDMENU                   ".PadLeft(50));
                    Console.WriteLine("===============================================".PadLeft(50));

                    Console.WriteLine("1)  Status på lokaler".PadLeft(37));
                    Console.WriteLine("2)  Lokale information".PadLeft(38));
                    Console.WriteLine("3)  Book et lokale".PadLeft(34));
                    Console.WriteLine("4)  Log ud".PadLeft(26));


                    string brugerinput = Console.ReadLine().ToLower();

                    switch (brugerinput)
                    {
                        case "1":
                            Console.Clear();
                            LokaleStatus();
                            break;

                        case "2":
                            Console.Clear();
                            LokaleInfo();
                            break;

                        case "3":
                            Console.Clear();
                            LokaleBook();
                            break;

                        case "4":
                            Logud(ref LogudSvar, ref login);
                            Console.Clear();
                            break;


                    }

                    // SKRIV DIT STATUS KODE HER MARIE 
                    static void LokaleStatus()
                    {

                    }

                    // SKRIV DIT LOKALE INFO HER KATRINE 
                    static void LokaleInfo()
                    {

                    }

                    // SKRIV DIT LOKALE book her RAFAEL 
                    static void LokaleBook()
                    {

                    }

                    static void Logud(ref string LogudSvar, ref bool login)
                    {
                        Console.WriteLine("Ønsker du at logge ud? (JA / NEJ)");
                        LogudSvar = Console.ReadLine().ToLower();

                        if (LogudSvar == "ja")
                        {
                            login = false;
                        }

                        else if (LogudSvar == "nej")
                        {
                            login =  true;
                        }
                        else
                        {
                            login = false;
                        }

                    }



                    



                     

























                }
           


           

          


















            }
        }
    }
}
