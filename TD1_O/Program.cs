using System;

namespace TD1_O{

    public class Program {
        public static void Main(string[] args)
        {
            Annuaire a = new Annuaire();
          
            int rep;

            do
            {
                Console.WriteLine(" – 0 : Quitter" +
                                  "\n– 1 : Ajouter un nouvel employé à la liste des employés de l’entreprise" +
                                  "\n– 2 : Supprimer un employé sélectionné" +
                                  "\n– 3 : Modifier un employé sélectionné" +
                                  "\n– 4 : Afficher un employé sélectionné" +
                                  "\n– 5 : Afficher l’ensemble des employés d’un service donné "+
                                   "\n– 6 : Afficher tous les employes "); // zedt'ha men aandi
                 rep = int.Parse(Console.ReadLine());
                switch (rep)
                {
                    case 1:
                        Employe e = new Employe();
                        e.Saisir();
                        a.ajouterEmploye(e);
                        a.AfficherListeEmpT();
                        break;
                    case 2:
                        Console.WriteLine("Donner nom employe a supprimer: ");
                        string nom = Console.ReadLine();
                        a.EffaceEmp(nom);
                        a.AfficherListeEmpT();
                        break;
                    case 3:
                        Console.WriteLine("Donner matricule employe pour modifier ");
                        int mat = int.Parse(Console.ReadLine());
                        a.modifierEmploye(mat);
                        a.AfficherListeEmpT();
                        break;
                    case 4:
                        Console.WriteLine("Donner matricule employe pour afficher ");
                        int mat2 = int.Parse(Console.ReadLine());
                        a.AfficherListeEmp(mat2);
                        break;
                    case 5:
                        Console.WriteLine("Donner service pour afficher: ");
                        services ser;
                        // we should pass the service value fil method to check , not a string , bizou
                        Enum.TryParse(Console.ReadLine(), out ser);
                        a.AfficherListeEmpService(ser);
                        break;
                    case 6: a.AfficherListeEmpT();
                        break;
                    case 0: break;
                    default: Console.WriteLine("mauvais choix"); break;

                }
            }while ( !(rep== 0));


        }
    
    }
}