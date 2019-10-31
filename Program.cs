using System;

namespace TypeCasting
{
    class Program
    {

        public static class Rapport
        {
            public  static void Imprimer(Personne personne)
            {
                if (personne is PersonnePhysique)
                    Console.WriteLine($"{personne.Nom} est une personne physique avec " +
                        $"{(personne as PersonnePhysique).NumeroIdentite} comme numero d'identité");

                if (personne is PersoneJuridique)
                    Console.WriteLine($"{personne} est une personne juridique avec le numero de l'entreprise " +
                        $"{(personne as PersoneJuridique).NumeroEntreprise}");
            }
        }

        public class Personne
        {
            public string Nom { get; set; }
        }

        public class PersoneJuridique : Personne
        {
            public string NumeroEntreprise { get; set; }
        }

        public class PersonnePhysique : Personne
        {
            public string NumeroIdentite { get; set; }
        }

        static void Main(string[] args)
        {
            var personnePhysique = new PersonnePhysique
            {
                Nom = "Grazy Tamires",
                NumeroIdentite = "123456"
            };

            var personneJuridique = new PersoneJuridique
            {
                Nom = "Billy Tukija",
                NumeroEntreprise = "beapps123456"
            };

            Rapport.Imprimer(personnePhysique);
            Rapport.Imprimer(personneJuridique);
        }
    }
}
