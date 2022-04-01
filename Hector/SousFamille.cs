using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class SousFamille
    {
        private int RefSousFamille;
        private Famille RefFamille;
        private String Nom;

        public SousFamille(int RefSousFamille, Famille RefFamille, String Nom)
        {
            this.RefSousFamille = RefSousFamille;
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }
    }
}
