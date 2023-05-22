using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
    internal class Poulailler
    {
            string nom;
            int Capacite;
            int NbPoulesDansPoulailler;
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

            /// <summary>
            /// Méthode qui ajoute des poules dans le poulailler
            /// </summary>
            /// <param name="pouleAAjouter"> Poule a ajouter dans le poulailler</param>
            public void AjouterPoule(Poule pouleAAjouter)
            {
                ListePoulesDansPoulailler.Add(pouleAAjouter);
            }

            /// <summary>
            /// Méthode qui affiche toutes les poules présentes dans le poulailler + leur num d'affichage + le nb poules 
            /// dans le poulailler
            /// </summary>
            public void affichePoulesDuPoulailler()
            {
                NbPoulesDansPoulailler = ListePoulesDansPoulailler.Count();
                for (int indicePoule = 0; indicePoule < NbPoulesDansPoulailler; indicePoule++)
                {
                    Console.WriteLine("Numéro d'affichage de la poule : {0}", indicePoule);
                    Console.WriteLine("Nom de la poule : {0}", ListePoulesDansPoulailler[indicePoule].nom);
                }
                Console.WriteLine("Il y a exactement {0} poules dans le poullailler {1}", NbPoulesDansPoulailler, this.nom);
                Console.WriteLine();
            }


            /// <summary>
            /// Supprimer la poule demandée par l'utilisateur grâce à son numéro d'affichage
            /// </summary>
            /// <param name="numeroAffichage">Numéro affiché à côté de la poule lors de l'affichage</param>
            public void supprimerUnePoule(int numeroAffichage)
            {
                ListePoulesDansPoulailler.RemoveAt(numeroAffichage);
            }

            /// <summary>
            /// Méthode qui calcule et affiche l'intensité moyenne de la ponte dans le poulailler 
            /// </summary>
            public void intensitePontePoulailler()
            {
                double sommeIntensitePonte = 0;
                double moyenneIntensitePonte;

                // Boucle sur le poulailler en faisant la somme des intensites de pontes de chaque poule
                for (int indicePoule = 0; indicePoule < NbPoulesDansPoulailler; indicePoule++)
                {
                    sommeIntensitePonte = sommeIntensitePonte + ListePoulesDansPoulailler[indicePoule].intensitePonte;
                }

                //Divise par le nombre de poules pour avoir l'intensité moyenne
                moyenneIntensitePonte = sommeIntensitePonte / NbPoulesDansPoulailler;


                Console.WriteLine("L'intensité de ponte moyenne de {0} est de {1} ", nom, moyenneIntensitePonte);
                Console.WriteLine();
            }

        }
    }

