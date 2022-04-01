using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class Article
    {
        private String RefArticle;
        private String Description;
        private SousFamille RefSousFamille;
        private Marque RefMarque;
        private int PrixHT;
        private int Quantite;

        public Article (String RefArticle, String Description, SousFamille RefSousFamille, Marque RefMarque, int PrixHT, int Quantite)
        {
            this.RefArticle = RefArticle;
            this.Description = Description;
            this.RefSousFamille = RefSousFamille;
            this.RefMarque = RefMarque;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
        }
    }
}
