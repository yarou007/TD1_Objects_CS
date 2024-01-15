using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_O
{
    internal class Annuaire
    {
        List<Employe> employes;

        public Annuaire()
        {
            this.employes = new List<Employe>();
        }

        public bool existEmploye(Employe emp) { return employes.Contains(emp); }
        public void ajouterEmploye(Employe e)
        {
            if (existEmploye(e)) { Console.WriteLine("Employe existe deja"); }
            else
            {
                Console.WriteLine("Ajout avec succes");
                employes.Add(e);
            }
            
        }
        public void modifierEmploye(int codeEmp) {
            bool changed = false;
            foreach (Employe e in employes) {
                if (e.Code == codeEmp)
                {
                    e.Saisir(); // on va changer toutes les attributs , suiii 
                    changed = true;
                    break;
                 }
            }
            if (changed) { Console.WriteLine("Modification avec succés"); }
            else { Console.WriteLine("Employe n'existe pas , mafamesh ye walid"); }
        
        }


        public void EffaceEmp(string nomEmp)
        {
            int i = 0;
            bool sup = false;
            foreach (Employe e in employes)
            {
                if (e.Nom.Equals(nomEmp))
                {
                    employes.RemoveAt(i);
                    sup = true;
                    break;
                }
                i++;
            }
            if (sup)
            {
                Console.WriteLine("Suppression avec succés");
            }
            else
            {
                Console.WriteLine("n'existe pas ");

            }
        }

        public void AfficherListeEmpService(services service) {

            foreach (Employe e in employes) {
                if (e.Service.Equals(service)) { 
                     Console.WriteLine(e.ToString());
                }
            }
        }
        public void AfficherListeEmp(int code)
        {
            bool trouve = false;
            foreach (Employe e in employes)
            {
                if (e.Code== code)
                {
                    Console.WriteLine(e.ToString());
                    trouve = true;
                }
            }
            if (!trouve) { Console.WriteLine("Employe n'existe pas"); }

        }
        public void AfficherListeEmpT()
        {
            foreach (Employe e in employes)
            {
                    Console.WriteLine(e.ToString());
            }
        }












    }
    }

