using System;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // määritellään muuttuja
            string nimi = "Matti Mainio";
            // tulostetaan muuttujan arvo konsolille
            Console.WriteLine("Nimi on " + nimi);
            // pidetään sovelluksen ajoikkuna näytöllä. Sulkeutuu, kun enter-painiketta on painettu
            Console.ReadLine();
        }
    }
}