using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class Famille
    {
        private int RefFamille;
        private String Nom;

        public Famille (int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }
    }
}
