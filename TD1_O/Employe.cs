using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_O
{
    public enum services
    {
        Sales, Management, Comptabilite
    }
    internal class Employe
    {
        private int code;
        private string nom;
        private string fonction;
        private services service;
        private int poste;
        private int numTel;

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Fonction { get => fonction; set => fonction = value; }
        public services Service { get => service; set => service = value; }
        public int Poste { get => poste; set => poste = value; }
        public int NumTel { get => numTel; set => numTel = value; }

        public Employe(int code, string nom, string fonction, services service, int numTel)
        {
            this.code = code;
            this.nom = nom;
            this.numTel = numTel;
            this.fonction = fonction;
            this.service = service;
            if (this.service.Equals("Sales")) { this.poste = 1010; }
            else if (this.service.Equals("Comptabilite")) { this.poste = 1040; }
            else { this.poste = 1020; }

        }
        public Employe()
        {

        }
        public override string ToString()
        {
            return this.Code + " " + this.Nom + " " + this.Fonction + " " + this.Service + " " + this.Poste + " " + this.NumTel;
        }
        public void Saisir()
        {
            do
            {
                Console.WriteLine("Donner code : ");
            } while (!int.TryParse(Console.ReadLine(), out this.code));
            do
            {
                Console.WriteLine("Donner nom: ");
                this.nom = Console.ReadLine();
            } while (!(this.nom.Length < 30));
            do
            {
                Console.WriteLine("Donner num Tel: ");
                int.TryParse(Console.ReadLine(), out this.numTel);

            } while (!(this.numTel > 0) || !(this.numTel.ToString().Length == 8));

            do
            {
                Console.WriteLine("Donner fonction Commercial, Directeur Commercial ou Directeur. ");
                this.fonction = Console.ReadLine();
            } while (  ! ((this.fonction.Equals("Commercial")) || (this.fonction.Equals("Directeur Commercial")) || (this.fonction.Equals("Directeur")) ) )  ; 
            do {
                Console.WriteLine("Donner service : Sales | Management | Comptabilite ");
                
            } while (!Enum.TryParse(Console.ReadLine() , out this.service));


            if (this.service.Equals(services.Sales)) { this.poste = 1010; } // checking enum values lezem taady enum.value fil west l equals to check the value, this.service.equals("Sales") ghalta | don't check the string values cause shtraja3 false hata lawkent s'hiha 
            else if (this.service.Equals( services.Comptabilite )) { this.poste = 1040; }
            else { this.poste = 1020; }

            


        }
    }
}
