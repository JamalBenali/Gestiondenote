using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE
{
    public class _Enseignant : Personne
    {
        private List<string> Element;
        public _Enseignant() : base()
        {
            this.Element = new List<string>();
        }
        public _Enseignant(string cin, string a, string b, DateTime t, string c, string d, string e, string f, List<string> elmnt)
            : base(cin, a, b, t, c, d, e, f)
        {
            this.Element = elmnt;
        }
        public List<string> gsElement
        {
            set { this.Element = value; }
            get { return this.Element; }
        }
    }
}
