using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Hector
{
    public partial class MenuImporter : Form
    {
        public MenuImporter()
        {
            InitializeComponent();
        }

        private void MenuImporter_Load(object sender, EventArgs e)
        {

        }

        private void BoutonEcrasement_Click(object sender, EventArgs e)
        {
            String Version = "SELECT SQLITE_VERSION()";
            System.Data.SQLite.SQLiteConnection Connection =   new SQLiteConnection();
        }

        private void BoutonImporter_Click(object sender, EventArgs e)
        {
            String TotalPath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "selection fichier CSV";
            ofd.Filter = "Fichiers CSV |*.csv";
            DialogResult Result = ofd.ShowDialog();
            if(Result == DialogResult.OK && ofd.FileName != null)
            {
                TotalPath = ofd.FileName;
                LabelNomDuFichier.Text = System.IO.Path.GetFileName(TotalPath); 
            }
        }

        private void BoutonAjout_Click(object sender, EventArgs e)
        {

        }
    }
}
