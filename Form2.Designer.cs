namespace gestionDesNotes
{
    partial class GestionEtudiant
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.normalPanel = new System.Windows.Forms.Panel();
            this.moyennePanel = new System.Windows.Forms.Panel();
            this.ok = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dernier = new System.Windows.Forms.Button();
            this.premier = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.suivant = new System.Windows.Forms.Button();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.prenome = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.moyenne = new System.Windows.Forms.TextBox();
            this.normalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(455, 396);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 3;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Chercher";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // normalPanel
            // 
            this.normalPanel.Controls.Add(this.moyennePanel);
            this.normalPanel.Controls.Add(this.moyenne);
            this.normalPanel.Controls.Add(this.prenome);
            this.normalPanel.Controls.Add(this.ok);
            this.normalPanel.Controls.Add(this.annuler);
            this.normalPanel.Controls.Add(this.quitter);
            this.normalPanel.Controls.Add(this.valider);
            this.normalPanel.Controls.Add(this.button10);
            this.normalPanel.Controls.Add(this.dernier);
            this.normalPanel.Controls.Add(this.premier);
            this.normalPanel.Controls.Add(this.precedent);
            this.normalPanel.Controls.Add(this.suivant);
            this.normalPanel.Controls.Add(this.dateNaissance);
            this.normalPanel.Controls.Add(this.nom);
            this.normalPanel.Controls.Add(this.numero);
            this.normalPanel.Controls.Add(this.label4);
            this.normalPanel.Controls.Add(this.label3);
            this.normalPanel.Controls.Add(this.label2);
            this.normalPanel.Controls.Add(this.num1);
            this.normalPanel.Location = new System.Drawing.Point(131, 45);
            this.normalPanel.Name = "normalPanel";
            this.normalPanel.Size = new System.Drawing.Size(581, 578);
            this.normalPanel.TabIndex = 5;
            // 
            // moyennePanel
            // 
            this.moyennePanel.Location = new System.Drawing.Point(490, 3);
            this.moyennePanel.Name = "moyennePanel";
            this.moyennePanel.Size = new System.Drawing.Size(91, 100);
            this.moyennePanel.TabIndex = 18;
            this.moyennePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.moyennePanel_Paint);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(385, 64);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 16;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(306, 280);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 15;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(166, 280);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 14;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(503, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Moyenne";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dernier
            // 
            this.dernier.Location = new System.Drawing.Point(455, 319);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(75, 23);
            this.dernier.TabIndex = 11;
            this.dernier.Text = "Dernier";
            this.dernier.UseVisualStyleBackColor = true;
            this.dernier.Click += new System.EventHandler(this.dernier_Click);
            // 
            // premier
            // 
            this.premier.Location = new System.Drawing.Point(25, 329);
            this.premier.Name = "premier";
            this.premier.Size = new System.Drawing.Size(75, 23);
            this.premier.TabIndex = 10;
            this.premier.Text = "Premier";
            this.premier.UseVisualStyleBackColor = true;
            this.premier.Click += new System.EventHandler(this.button8_Click);
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(166, 329);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(75, 23);
            this.precedent.TabIndex = 9;
            this.precedent.Text = "Precedent";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.precedent_Click);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(306, 329);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(75, 23);
            this.suivant.TabIndex = 8;
            this.suivant.Text = "Suivant";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(166, 218);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(174, 20);
            this.dateNaissance.TabIndex = 7;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(169, 116);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(174, 20);
            this.nom.TabIndex = 5;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(169, 66);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(174, 20);
            this.numero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateNaissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(20, 69);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(44, 13);
            this.num1.TabIndex = 0;
            this.num1.Text = "Numero";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prenome
            // 
            this.prenome.Location = new System.Drawing.Point(169, 159);
            this.prenome.Name = "prenome";
            this.prenome.Size = new System.Drawing.Size(174, 20);
            this.prenome.TabIndex = 0;
            this.prenome.TextChanged += new System.EventHandler(this.prenome_TextChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(131, 137);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(581, 282);
            this.searchPanel.TabIndex = 17;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // moyenne
            // 
            this.moyenne.Location = new System.Drawing.Point(503, 69);
            this.moyenne.Name = "moyenne";
            this.moyenne.Size = new System.Drawing.Size(75, 20);
            this.moyenne.TabIndex = 0;
            // 
            // GestionEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.normalPanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GestionEtudiant";
            this.Text = "Gestion Etudiant";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.normalPanel.ResumeLayout(false);
            this.normalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel normalPanel;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Button premier;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button dernier;
        private System.Windows.Forms.Panel moyennePanel;
        private System.Windows.Forms.TextBox prenome;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox moyenne;
    }
}