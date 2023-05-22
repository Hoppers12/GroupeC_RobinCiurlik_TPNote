using PDF;

// Instanciation d'un poule Ginger
Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);

// Affichage de cette poule
ginger.Afficher();


Console.WriteLine("cc");
Poule poule1 = new Poule("Robin", "race1", 3, Taille.S);
Poule poule2 = new Poule("Lea", "race1", 1, Taille.S);
Poule poule3 = new Poule("Bastien", "race5", 5, Taille.M);
Poule poule4 = new Poule("Isabelle", "race4", 3, Taille.XL);

Poulailler poulailler1 = new Poulailler("Poulailler1", 5);

poulailler1.AjouterPoule(poule1);
poulailler1.AjouterPoule(poule2);
poulailler1.AjouterPoule(poule3);
poulailler1.AjouterPoule(poule4);

poulailler1.affichePoulesDuPoulailler();