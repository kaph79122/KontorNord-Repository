using Microsoft.Win32;
using System;
using System.Security.Cryptography;

namespace KontorNord
{
    internal class Program
    {
        static string booketLokale = "";
        static string booketDag = "";
        static string booketTid = "";

        


		//2D arrays til skema i LokaleStatus
		static bool[,] lokaleA = new bool[5, 3]; 
        static bool[,] lokaleB = new bool[5, 3];
        static bool[,] lokaleC = new bool[5, 3];

        static void Main(string[] args)
        {



            // Datatyper
            bool ProgramStart = true;
            string Brugerinput = "";
            string LogudSvar = "";
            bool login = false; 
            string Brugernavn = "";
            string Password = "";
            bool BrugerRegistret = false;



            /// Selve programmet

            while (ProgramStart == true)
            {
                INTROTEKST();
                Console.ReadKey();
                Console.Clear();

                LOGINTEKST();
                LoginMENU(ref login, ref Brugerinput, ref Brugernavn, ref Password, ref BrugerRegistret);
               
                while (login == true)
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
                    Login(ref login);
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


        // Skriv dit login her, Neega
        static void Login(ref bool login)
        {


            login = true; // login skal ende med og være true før programmet fortsætter
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




        // Skriv dit lokale status her, marie

        static void LokaleStatus()
        {

            string[] tider = { "Morgen", "Middag", "Eftermiddag" };
            string[] dage = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag" };


            for (int dag = 0; dag < 5; dag++)
            {


                Console.WriteLine($"=== {dage[dag]} ===");
                Console.WriteLine("========================================================================".PadLeft(50));
                Console.WriteLine("             |      Lokale A     |     Lokale B     |     Lokale C     |".PadLeft(50));
                Console.WriteLine("========================================================================".PadLeft(50));

				for (int tid = 0; tid < 3; tid++)
				{
					string statusA;
					if (lokaleA[dag, tid])
					{
						statusA = "Reserveret";
					}
					else
					{
						statusA = "Ledig";
					}

					string statusB;
					if (lokaleB[dag, tid])
					{
						statusB = "Reserveret";
					}
					else
					{
						statusB = "Ledig";
					}

					string statusC;
					if (lokaleC[dag, tid])
					{
						statusC = "Reserveret";
					}
					else
					{
						statusC = "Ledig";
					}

					Console.WriteLine(tider[tid].PadRight(19)  +	statusA.PadRight(19)  +	statusB.PadRight(19) +	statusC);
				}

                Console.WriteLine();


            }

            Console.WriteLine("Tryk på en tast for at gå tilbage til Hovedmenu");
			Console.ReadKey();

		}
		// Skriv dit lokale info her, Katrine

		static void LokaleInfo()    
        {
            

        }



        // Skriv dit lokale booking her, Rafael
        static void LokaleBook()
        {
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                 BOOK LOKALE                   ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));

            // Lokale fremviser

            Console.WriteLine("Vælg et lokale:");
            Console.WriteLine("1) Lokale A");
            Console.WriteLine("2) Lokale B");
            Console.WriteLine("3) Lokale C");

            string valg = Console.ReadLine();
            int lokaleParse = int.Parse(valg) - 1;
            string lokale = "";

            if (valg == "1")
                lokale = "A";
            else if (valg == "2")
                lokale = "B";
            else if (valg == "3")
                lokale = "C";
            else
            {
                Console.WriteLine("Ugyldigt valg, prøv igen.");
                Console.ReadKey();
                return;
            }
            //Vælger dag for booking
            Console.Clear();
            Console.WriteLine("Vælg dag:");
            Console.WriteLine("1) Mandag");
            Console.WriteLine("2) Tirsdag");
            Console.WriteLine("3) Onsdag");
            Console.WriteLine("4) Torsdag");
            Console.WriteLine("5) Fredag");

            string ValgDag = Console.ReadLine();
            int dagParse = int.Parse(ValgDag) - 1; //string til int
            string dag;


            switch (ValgDag)
            {
                case "1":
                    dag = "Mandag";
                    break;

                case "2":
                    dag = "Tirsdag";
                    break;

                case "3":
                    dag = "Onsdag";
                    break;

                case "4":
                    dag = "Torsdag";
                    break;

                case "5":
                    dag = "Fredag";
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    Console.ReadKey();
                    return;


            }
            //Vælger Tidspunkt for booking

            Console.Clear();
            Console.WriteLine("Vælg Tidspunkt:");
            Console.WriteLine("1) Morgen");
            Console.WriteLine("2) Middag");
            Console.WriteLine("3) Eftermiddag");

            string valgTid = Console.ReadLine();
            int valgTidParse = int.Parse(valgTid) - 1;
            string tid = "";

            switch (valgTid)
            {
                case "1":
                    tid = "Morgen";
                    break;

                case "2":
                    tid = "Middag";
                    break;
                case "3":
                    tid = "Eftermiddag";
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen");
                    Console.ReadKey();
                    return;
            }

            //Booking bekræftigelse

            Console.Clear();
            Console.WriteLine("Bekræft din bookiing:");
            Console.WriteLine("Lokale: " + lokale);
            Console.WriteLine("Dag: " + dag);
            Console.WriteLine("Tidspunkt: " + tid);

            Console.WriteLine("\n1) Bekræft");
            Console.WriteLine("2) Annuller");

            string svar = Console.ReadLine();

            if (svar == "1")
            {
                // Sender det til bools i toppen så lokaleStatus() kan lave skema
                if (lokale == "A")
                    lokaleA[dagParse, valgTidParse] = true;
                else if (lokale == "B")
                    lokaleB[dagParse, valgTidParse] = true;
                else if (lokale == "C")
                    lokaleC[dagParse, valgTidParse] = true;

                Console.WriteLine("Lokalet er nu booket");
            }

            else
            {
                Console.WriteLine("Din booking er annulleret.");
            }


            Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage.");
            Console.ReadKey();


        }


        static void Logud(ref string LogudSvar, ref bool login)
        {   
            Console.WriteLine("Ønsker du at logge ud? ");
            Console.WriteLine(" 1) Ja ");
            Console.WriteLine(" 2) Nej ");
            LogudSvar = Console.ReadLine().ToLower();

            switch (LogudSvar)
            {
                case "1":
                    Console.Clear();
                    login = false;
                    break;

                case "2":
                    Console.Clear();
                    login = true;
                    break;      
            }
        }    
    }
}
