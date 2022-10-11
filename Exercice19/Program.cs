using System;


namespace Exercice19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool saisieCorrecte = false;
            float montant = 0f;
            do
            {
                try
                {
                    Console.Write("Entrez un montant = ");
                    montant = float.Parse(Console.ReadLine());
                    saisieCorrecte = true;
                }
                catch
                {
                    Console.WriteLine("Entrez une valeur numérique");
                }
            } while (saisieCorrecte == false);
            float taux = 0
            if (montant > 40)
            {
                taux = 10f;
            }
            else
            {
                if (montant >= 20)
                {
                    taux = 5f;
                }
            }
            montant -= montant * taux / 100;
            Console.WriteLine("Montant = " + montant + " avec une remise de " + taux + "%");
            Console.ReadLine();
        }
    }
}
