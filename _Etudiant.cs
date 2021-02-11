using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE
{
    public class _Etudiant : Personne
    {
        private string filiere;
        private string CNE;
        public _Etudiant() : base()
        {
            this.filiere = "";
            this.CNE = "";
        }
        public _Etudiant(string cin, string a, string b, DateTime t, string c, string d, string e, string f, string filiere, string CNE)
            : base(cin, a, b, t, c, d, e, f)
        {
            this.filiere = filiere;
            this.CNE = CNE;
        }
        public string gsFiliere
        {
            set { this.filiere = value; }
            get { return this.filiere; }
        }
        public string gsCNE
        {
            set { this.CNE = value; }
            get { return this.CNE; }
        }
    }
}

