namespace KontorNord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramKøre = true;
            string LogudSvar = "";


            while (ProgramKøre = true)
            {

                Console.WriteLine("===============================================");
                Console.WriteLine("===================HOVEDMENU===================");
                Console.WriteLine("===============================================");

                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");

                string brugerinput = Console.ReadLine().ToLower();

                switch(brugerinput)
                {
                   case "1":
                   break;
                   
                   case "2":
                   break;

                   case "3":
                   break;
                    
                   case "4":
                   break;
                    
                   case "5":
                   break;
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
