namespace Hector
{
    partial class MenuImporter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoutonImporter = new System.Windows.Forms.Button();
            this.LabelNomDuFichier = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BoutonEcrasement = new System.Windows.Forms.Button();
            this.BoutonAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoutonImporter
            // 
            this.BoutonImporter.Location = new System.Drawing.Point(100, 108);
            this.BoutonImporter.Name = "BoutonImporter";
            this.BoutonImporter.Size = new System.Drawing.Size(185, 23);
            this.BoutonImporter.TabIndex = 0;
            this.BoutonImporter.Text = "Importer CSV";
            this.BoutonImporter.UseVisualStyleBackColor = true;
            this.BoutonImporter.Click += new System.EventHandler(this.BoutonImporter_Click);
            // 
            // LabelNomDuFichier
            // 
            this.LabelNomDuFichier.AutoSize = true;
            this.LabelNomDuFichier.Location = new System.Drawing.Point(156, 139);
            this.LabelNomDuFichier.Name = "LabelNomDuFichier";
            this.LabelNomDuFichier.Size = new System.Drawing.Size(73, 13);
            this.LabelNomDuFichier.TabIndex = 1;
            this.LabelNomDuFichier.Text = "nom du fichier";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // BoutonEcrasement
            // 
            this.BoutonEcrasement.Location = new System.Drawing.Point(103, 155);
            this.BoutonEcrasement.Name = "BoutonEcrasement";
            this.BoutonEcrasement.Size = new System.Drawing.Size(75, 23);
            this.BoutonEcrasement.TabIndex = 3;
            this.BoutonEcrasement.Text = "Ecrasement";
            this.BoutonEcrasement.UseVisualStyleBackColor = true;
            this.BoutonEcrasement.Click += new System.EventHandler(this.BoutonEcrasement_Click);
            // 
            // BoutonAjout
            // 
            this.BoutonAjout.Location = new System.Drawing.Point(210, 155);
            this.BoutonAjout.Name = "BoutonAjout";
            this.BoutonAjout.Size = new System.Drawing.Size(75, 23);
            this.BoutonAjout.TabIndex = 4;
            this.BoutonAjout.Text = "Ajout";
            this.BoutonAjout.UseVisualStyleBackColor = true;
            // 
            // MenuImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BoutonAjout);
            this.Controls.Add(this.BoutonEcrasement);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LabelNomDuFichier);
            this.Controls.Add(this.BoutonImporter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuImporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Importer";
            this.Load += new System.EventHandler(this.MenuImporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BoutonImporter;
        private System.Windows.Forms.Label LabelNomDuFichier;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BoutonEcrasement;
        private System.Windows.Forms.Button BoutonAjout;
    }
}