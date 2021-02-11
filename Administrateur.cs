using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE
{
    public class Administrateur : Personne
    {
        //private string filiere;
        public Administrateur() : base()
        {
            //this.filiere = "";
        }
        public Administrateur(string cin, string a, string b, DateTime t, string c, string d, string e, string f, string filiere)
            : base(cin, a, b, t, c, d, e, f)
        {
            //this.filiere = filiere;
        }
        /*public string gsFiliere
        {
            set { this.filiere = value; }
            get { return this.filiere; }
        }*/
    }
}
