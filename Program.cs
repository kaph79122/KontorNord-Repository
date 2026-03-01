namespace KontorNord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Brugernavn;
            int Password;

            do
            {
                Console.Write("Indtast brugernavn: ");
                Brugernavn = Console.ReadLine().ToLower();

                Console.Write("Indtast kode: ");
                Password = int.Parse(Console.ReadLine());

                if (Brugernavn != "louise" || Password != 1234)
                {
                    Console.WriteLine("Forkert login, prøv igen");
                }

            } while (Brugernavn != "louise" || Password != 1234);

            Console.WriteLine("Adgang godkendt!");
        }
    }

}
