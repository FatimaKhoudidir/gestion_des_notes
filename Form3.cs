using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestionDesNotes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=gestion;Uid=root;Pwd= ;");
        private float Rechercher_Note_Etudiant(int numins, int nummod) //fonction qui permet de retourner la note d'un étudiant donné dans un module donné
        {
            float note = -1;
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Note from Notes where Num_Etu=" + numins + " and Num_Mod=" + nummod;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                note = float.Parse(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            return note;
        }

        private int num_module(string nom) //fonction qui permet de retourner le numéro d'un module à partir de son nom
        {
            int num = -1;
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Num_Mod from Module where Nom_Mod='" + nom + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                num = int.Parse(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            return num;

        }
        //Source : www.exelib.net

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numero_SelectedIndexChanged(object sender, EventArgs e)
        {

            noteForm.Text = "";
            if (numero.SelectedIndex != -1) //chargement du nom et prénom de l'étudiant selectionné
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Nom_Etu,Prenom_Etu from Etudiant where Num_Etu=" + int.Parse(numero.SelectedItem.ToString());
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    nom.Text = dr[0] + " " + dr[1];
                }
                dr.Close();
                con.Close();


                if (combomodule.SelectedIndex != -1)    // chargement de la note de l'étudiant selectionné dans le module selectionné
                {
                    int nummod = num_module(combomodule.SelectedItem.ToString());
                    float note = Rechercher_Note_Etudiant(int.Parse(numero.SelectedItem.ToString()), nummod);
                    if (note != -1)
                    {
                        noteForm.Text = note.ToString();
                    }


                }
            }

        }

        private void combomodule_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteForm.Text = "";  //  chargement de la note de l'étudiant selectionné dans le module selectionné
            if (combomodule.SelectedIndex != -1)
            {

                if (numero.SelectedIndex != -1)
                {
                    int nummod = num_module(combomodule.SelectedItem.ToString());
                    float note = Rechercher_Note_Etudiant(int.Parse(numero.SelectedItem.ToString()), nummod);
                    if (note != -1)
                    {
                        noteForm.Text = note.ToString();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float note;
            if (nom.Text == "" || noteForm.Text == "" || numero.Text == "" || combomodule.Text == "") // contrôle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numero.SelectedIndex == -1)
            {
                MessageBox.Show("Numéro d'inscription invalide!!", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (combomodule.SelectedIndex == -1)
            {
                MessageBox.Show("Numéro Module invalide!!", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (float.TryParse(noteForm.Text, out note) == false)
                MessageBox.Show("Champ Note invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (note < 0 || note > 20)
                MessageBox.Show("Champ Note invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (Rechercher_Note_Etudiant(int.Parse(numero.SelectedItem.ToString()), num_module(combomodule.SelectedItem.ToString())) != -1) //vérification de l'existence de la note
            {

                MessageBox.Show("Note déja attribuée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else   // traitement de l'ajout d'une note
            {
                int nummod = num_module(combomodule.SelectedItem.ToString());
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("insert into Notes values({0},{1},{2})", int.Parse(numero.SelectedItem.ToString()), nummod, note);
                int r = cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                if (r != 0)
                {
                    MessageBox.Show("Note bien attribuée", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float note;
            if (nom.Text == "" || noteForm.Text == "" || numero.Text == "" || combomodule.Text == "") // contrôle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numero.SelectedIndex == -1)
            {
                MessageBox.Show("Numéro d'inscription invalide!!", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (combomodule.SelectedIndex == -1)
            {
                MessageBox.Show("Numéro Module invalide!!", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (float.TryParse(noteForm.Text, out note) == false)
                MessageBox.Show("Champ Note invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (note < 0 || note > 20)
                MessageBox.Show("Champ Note invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (Rechercher_Note_Etudiant(int.Parse(numero.SelectedItem.ToString()), num_module(combomodule.SelectedItem.ToString())) == -1)  //vérification de l'existence de la note
            {

                MessageBox.Show("Note non attribuée, Enregistrer la note d'abord", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else   //traitement de la modification
            {   
                int nummod = num_module(combomodule.SelectedItem.ToString());
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("Update Notes set Note={0} where Num_Etu={1} and Num_Mod={2}",note, int.Parse(numero.SelectedItem.ToString()), nummod);
                int r = cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                if (r != 0)
                {
                    MessageBox.Show("Note bien modifiée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    //rafraichir la liste

                }

            }

//Source : www.exelib.net
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
