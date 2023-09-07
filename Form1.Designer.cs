namespace gestionDesNotes
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiant = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionNote = new System.Windows.Forms.ToolStripMenuItem();
            this.consultation = new System.Windows.Forms.ToolStripMenuItem();
            this.quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestion,
            this.consultation,
            this.quitter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestion
            // 
            this.gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEtudiant,
            this.gestionNote});
            this.gestion.Name = "gestion";
            this.gestion.Size = new System.Drawing.Size(59, 20);
            this.gestion.Text = "Gestion";
            this.gestion.Click += new System.EventHandler(this.gestionDesNotesToolStripMenuItem_Click);
            // 
            // gestionEtudiant
            // 
            this.gestionEtudiant.Name = "gestionEtudiant";
            this.gestionEtudiant.Size = new System.Drawing.Size(186, 22);
            this.gestionEtudiant.Text = "gestion des etudiants";
            this.gestionEtudiant.Click += new System.EventHandler(this.gestionEtudiant_Click);
            // 
            // gestionNote
            // 
            this.gestionNote.Name = "gestionNote";
            this.gestionNote.Size = new System.Drawing.Size(186, 22);
            this.gestionNote.Text = "gestion des notes";
            this.gestionNote.Click += new System.EventHandler(this.gestionNote_Click);
            // 
            // consultation
            // 
            this.consultation.Name = "consultation";
            this.consultation.Size = new System.Drawing.Size(87, 20);
            this.consultation.Text = "Consultation";
            this.consultation.Click += new System.EventHandler(this.consultation_Click);
            // 
            // quitter
            // 
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(56, 20);
            this.quitter.Text = "Quitter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GESTION DES NOTES";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestion;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiant;
        private System.Windows.Forms.ToolStripMenuItem gestionNote;
        private System.Windows.Forms.ToolStripMenuItem consultation;
        private System.Windows.Forms.ToolStripMenuItem quitter;
    }
}