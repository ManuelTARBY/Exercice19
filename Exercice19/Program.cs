using System;


namespace Exercice19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un montant = ");
            float montant = float.Parse(Console.ReadLine());
            float taux = 0;
            if (montant > 40)
            {
                taux = 0.1f;
            }
            else
            {
                if (montant >= 20)
                {
                    taux = 0.05f;
                }
            }
            montant -= montant * taux;
            Console.WriteLine("montant = " + montant + " avec une remise de " + (taux * 100) + "%");
            Console.ReadLine();
        }
    }
}
