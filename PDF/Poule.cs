using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PDF.Taille;


namespace PDF
{
    public class Poulailler
    {
        string nom;
        int Capacite;
        int NbPoulesDansPoulailler ;
        List<Poule> ListePoulesDansPoulailler;


        /// <summary>
        /// Création d'une nouvelle instance d'un objet poulailler
        /// </summary>
        /// <param name="nomPoulailler">Nom du poulailler</param>
        /// <param name="CapaciteMax">Capacité du poulailler</param>
        public Poulailler(string nomPoulailler, int CapaciteMax)
        {
            nom = nomPoulailler;
            Capacite = CapaciteMax;
            ListePoulesDansPoulailler = new List<Poule>();
            
        }

        public void AjouterPoule(Poule pouleAAjouter)
        {
            ListePoulesDansPoulailler.Add(pouleAAjouter);
        }

        public void affichePoulesDuPoulailler()
        {
            NbPoulesDansPoulailler = ListePoulesDansPoulailler.Count();
            for (int indicePoule = 0; indicePoule < NbPoulesDansPoulailler; indicePoule++)
            {
                Console.WriteLine("Numéro d'affichage de la poule : {0}", indicePoule);
                Console.WriteLine("Nom de la poule : {0}", ListePoulesDansPoulailler[indicePoule].nom);
            }
            Console.WriteLine("Il y a exactement {0} poules dans le poullailler {1}", NbPoulesDansPoulailler, this.nom);
        }

        
        public void supprimerUnePoule(int numeroAffichage) {

            ListePoulesDansPoulailler.RemoveAt(numeroAffichage);
        }

        public void intensitePontePoulailler()
        {
            double sommeIntensitePonte = 0;
            double moyenneIntensitePonte;
            for (int indicePoule = 0; indicePoule < NbPoulesDansPoulailler; indicePoule++)
            {
                sommeIntensitePonte = sommeIntensitePonte + ListePoulesDansPoulailler[indicePoule].intensitePonte;
            }

            moyenneIntensitePonte = sommeIntensitePonte / NbPoulesDansPoulailler;


            Console.WriteLine("L'intensité de ponte moyenne de {0} est de {1} ", nom, moyenneIntensitePonte);
        }

    }


    /// <summary>
    /// Modélise une poule
    /// </summary>
    public class Poule
    {
        /// <summary>
        /// Nom de la poule
        /// </summary>
        /// <example>Germaine, Roussette, Ginger, Raymonde</example>
        public string nom;
        /// <summary>
        /// Race de la poule
        /// </summary>
        /// <example>Sussex, Marans, Gatinaise, Gauloise</example>
        string race;
        /// <summary>
        /// Nb moyen d'oeufs pondus par jour
        /// </summary>
        public double intensitePonte;
        /// <summary>
        /// Taille de la poule
        /// </summary>
        /// <remarks>S jusque XXL</remarks>
        Taille taille;

        /// <summary>
        /// Création d'une nouvelle instance d'un objet Poule
        /// </summary>
        /// <param name="nomP">Nom</param>
        /// <param name="raceP">Race</param>
        /// <param name="intensiteP">Intensite de ponte</param>
        /// <param name="tailleP">Taille</param>
        public Poule(string nomP, string raceP, double intensiteP, Taille tailleP)
        {
            nom = nomP;
            race = raceP;
            intensitePonte = intensiteP;
            taille = tailleP;
        }

        /// <summary>
        /// Affiche le nom et la race
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine($"{nom} ({race})");
        }


        }
   
  
}
