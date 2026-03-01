namespace KontorNord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brugernavn;
            int kode;

            do
            {
                Console.Write("Indtast brugernavn: ");
                brugernavn = Console.ReadLine().ToLower();

                Console.Write("Indtast kode: ");
                kode = int.Parse(Console.ReadLine());

                if (brugernavn != "louise" || kode != 1234)
                {
                    Console.WriteLine("Forkert login, prøv igen");
                }

            } while (brugernavn != "louise" || kode != 1234);

            Console.WriteLine("Adgang godkendt!");
        }
    }

}
