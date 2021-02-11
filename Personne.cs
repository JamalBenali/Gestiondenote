using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE
{
    public class Personne
    {
        private string CIN;
        private string nom;
        private string prenom;
        private DateTime dateDenaissance;
        private string lieuDenaissance;
        private string Sexe;
        private string Tel;
        private string Email;
        public Personne()
        {
            this.CIN = "";
            this.nom = "";
            this.prenom = "";
            this.dateDenaissance = new DateTime();
            this.lieuDenaissance = "";
            this.Sexe = "";
            this.Tel = "";
            this.Email = "";
        }
        public Personne(string cin, string a, string b, DateTime t, string c, string d, string e, string f)
        {
            this.CIN = cin;
            this.nom = a;
            this.prenom = b;
            this.dateDenaissance = t;
            this.lieuDenaissance = c;
            this.Sexe = d;
            this.Tel = e;
            this.Email = f;
        }
        public string gsCin
        {
            set { this.CIN = value; }
            get { return this.CIN; }
        }
        public string gsNom
        {
            set { this.nom = value; }
            get { return this.nom; }
        }
        public string gsPrenom
        {
            set { this.prenom = value; }
            get { return this.prenom; }
        }
        public DateTime gsDateNaissance
        {
            set { this.dateDenaissance = value; }
            get { return this.dateDenaissance; }
        }
        public string gsLieuNaissance
        {
            set { this.lieuDenaissance = value; }
            get { return this.lieuDenaissance; }
        }
        public string gsSexe
        {
            set { this.Sexe = value; }
            get { return this.Sexe; }
        }
        public string gsTel
        {
            set { this.Tel = value; }
            get { return this.Tel; }
        }
        public string gsEmail
        {
            set { this.Email = value; }
            get { return this.Email; }
        }
        public string toString()
        {
            return "Nom :" + this.nom + "Prenom :" + this.prenom + "Date de Naissance :" + this.dateDenaissance + "Lieu de Naissance :" + this.lieuDenaissance +
                "Sexe :" + this.Sexe + "Tel :" + this.Tel + "Email :" + this.Email;
        }
    }
}
