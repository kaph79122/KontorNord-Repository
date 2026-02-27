namespace KontorNord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramKøre = true;
            string LogudSvar = "";
            bool login = false;


            // SKRIV DIT LOGIN HER NEEGA 
            static void Login(bool login)
            {
                while (!login)
                { 
                    
                    
                }






                login = true;
            }


           

            while (ProgramKøre = true && login = true)
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

                switch(brugerinput)
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
                        Logud(ref LogudSvar);
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

                static bool Logud(ref string LogudSvar)
                {
                    Console.WriteLine("Ønsker du at logge ud? (JA / NEJ)");
                    LogudSvar = Console.ReadLine().ToLower();

                    if (LogudSvar == "ja")
                    {
                        return false;

                    }

                    else if (LogudSvar == "nej")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }


















            }
        }
    }
}
