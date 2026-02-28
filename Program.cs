using Microsoft.Win32;
using System;

namespace KontorNord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datatyper
            bool ProgramStart = true;
            string Brugerinput = "";
            string LogudSvar = "";
            bool login = false; 
      
            string Brugernavn = "";
            string Password = "";
            bool BrugerRegistret = false;



            /// VORES PROGRAM

            while (ProgramStart == true)
            {
                INTROTEKST();
                Console.ReadKey();
                Console.Clear();

                LOGINTEKST();
                LoginMENU(ref login, ref Brugerinput, ref Brugernavn, ref Password, ref BrugerRegistret);
               
                
                if (login == true)
                {
                    HOVEDMENUTEKST();
                    Hovedmenu(ref login, ref Brugerinput, ref LogudSvar);
                }
                
            }   
        }

        // Alle metoder til programmet
        static void INTROTEKST()
        {
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                BOOK ET MØDELOKALE             ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("");
            Console.WriteLine("    tryk på en vilkårlist tast for at forsætte...");
        }

        static void LOGINTEKST()
        {
            Console.Clear();
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                     LOGIN                     ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("1)  Fortsæt til login".PadLeft(37));
            Console.WriteLine("2)  Opret bruger".PadLeft(38));
            Console.WriteLine("3)  Tilbage til start".PadLeft(34));
            Console.WriteLine("");
        }


        static void LoginMENU(ref bool login, ref string Brugerinput, ref string Brugernavn, ref string Password, ref bool BrugerRegistret)
        {
           
            Brugerinput = Console.ReadLine().ToLower();


            switch (Brugerinput)
            {
                case "1":
                    Console.Clear();
                    Login();
                    break;

                case "2":
                    Console.Clear();
                    Register(ref Brugernavn, ref Password, ref BrugerRegistret);
                    break;

                case "3":
                    Console.Clear();

                    break;
                    
            }
        }


        // SKRIV DIT LOGIN HER NEEGA
        static bool Login()
        {

            return true; // login skal ende med og være true før programmet fortsætter
        }


        static void Register(ref string Brugernavn, ref string Password, ref bool BrugerRegistret)
        {
            Console.WriteLine("Indtast Dit brugernavn");
            Brugernavn = Console.ReadLine().ToLower();

            Console.WriteLine("Indtast Dit adgangkode");
            Password = Console.ReadLine().ToLower();

            BrugerRegistret = true;
        }


        static void HOVEDMENUTEKST()
        {
            Console.Clear();
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                   HOVEDMENU                   ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("1)  Status på lokaler".PadLeft(37));
            Console.WriteLine("2)  Lokale information".PadLeft(38));
            Console.WriteLine("3)  Book et lokale".PadLeft(34));
            Console.WriteLine("4)  Log ud".PadLeft(26));
        }



        static void Hovedmenu(ref bool login, ref string Brugerinput, ref string LogudSvar)
        {
                Brugerinput = Console.ReadLine().ToLower();

            switch (Brugerinput)
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
                    Console.Clear();
                    Logud(ref LogudSvar, ref login);
                    break;
            }
        }


           

     // SKRIV DIT LOKALE INFO HER MARIE
            
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
                login = true;   
            }
            else
            {
                login = false;   
            }
        }    
    }
}
