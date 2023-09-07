using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestionDesNotes
{
    public partial class GestionEtudiant : Form
    {
       
        public GestionEtudiant()
        {
            InitializeComponent();

            normalPanel.Visible =false;
            moyennePanel.Visible = false;
            searchPanel.Visible = false;
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=gestion;Uid=root;Pwd= ;");
        private void button3_Click(object sender, EventArgs e)
        {   normalPanel.Visible = true;
            int ns;
            if (numero.Text == "") // contrôle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (int.TryParse(numero.Text, out ns) == false)
                MessageBox.Show("Champ Numéro d'inscription invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (searchbyname() == false) //vérification de l'existence
            {

                MessageBox.Show("Etudiant inexistant", "inexistant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numero.Focus();
                numero.SelectAll();
            }
            else  //traitement de la suppression
            {
                // confirmation
                DialogResult d = MessageBox.Show("Voulez vraiment supprimer l'étudiant numéro: " + ns, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("delete from Etudiant where Numero={0}", ns);
                    int r = cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                    if (r != 0)
                    {
                        MessageBox.Show("Etudiant bien supprimé", "supression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        vider();

                        con.Close();

                    }
                }
                }

            }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Etudiant", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) //pointer sur le prmier Etudiant s'il existe
            {
               numero.Text = dr[0].ToString();
                nom.Text = dr[1].ToString();
               prenome.Text = dr[2].ToString();
                dateNaissance.Value = DateTime.Parse(dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moyenne_Click(object sender, EventArgs e)
        {

        }
        private void vider()
        {
            numero.Text = "";
            nom.Text = "";
            prenome.Text = "";
            dateNaissance.Value = DateTime.Today;
        }
        private bool searchbyname()
        {
            bool p = false;
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Etudiant where Numero=" + int.Parse(numero.Text);


            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                p = true;

            dr.Close();
            con.Close();
            return p;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
            normalPanel.Visible = true;
          
            moyennePanel.Visible = true;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normalPanel.Visible = true;
            searchPanel.Visible=false;
             

          
        }

        private void ok_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
            normalPanel.Visible = true;
            moyennePanel.Visible = false;
            int ns;
            if (numero.Text == "") //controle de saisie sur le champ Numéro Ins
                MessageBox.Show("Champ Numéro d'inscription vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (int.TryParse(numero.Text, out ns) == false)
                MessageBox.Show("Champ Numéro d'inscription invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (searchbyname() == false) //vérification de l'existence 
            {

                nom.Text = ""; // vider les champs 
                prenome.Text = "";
                dateNaissance.Value = DateTime.Now;
                MessageBox.Show("Etudiant introuvable", "introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numero.Focus();
                numero.SelectAll();
            }
            else
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Etudiant where Numero=" + ns;
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read(); // un seul Etudiant
                nom.Text = dr[1].ToString();
                prenome.Text = dr[2].ToString();
                dateNaissance.Value = DateTime.Parse(dr[3].ToString());
                dr.Close();
                con.Close();
            }

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            numero.Text = "";
            nom.Text = "";
            prenome.Text = "";
            dateNaissance.Value = DateTime.Today;
            
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            int ns;
            if (numero.Text == "" || nom.Text == "" || prenome.Text == "") // contrôle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (int.TryParse(numero.Text, out ns) == false)
                MessageBox.Show("Champ Numéro d'inscription invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (searchbyname() == true) //vérification de l'existence
            {

                MessageBox.Show("Etudiant existe déja", "existant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numero.Focus();
                numero.SelectAll();
            }
            else   //traitement de la modification
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("update Etudiant set Nom='{0}',Prenom='{1}',DateDeNaissance='{2}' where Numero={3}", nom.Text, prenome.Text, dateNaissance.Value.ToShortDateString(), ns);
                int r = cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                if (r != 0)
                {
                    MessageBox.Show("Etudiant bien modifié", "modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        { normalPanel.Visible = true;
        }

        private void moyennePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            int ns;
            if (numero.Text == "" || nom.Text == "" || prenome.Text == "") // contrôle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (int.TryParse(numero.Text, out ns) == false)
                MessageBox.Show("Champ Numéro d'inscription invalide!!", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (searchbyname() == true) //vérification de l'existence
            {

                MessageBox.Show("Etudiant existe déja", "existant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numero.Focus();
                numero.SelectAll();
            }
            else   //traitement de l'ajout
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("insert into Etudiant values({0},'{1}','{2}','{3}')", ns, nom.Text, prenome.Text, dateNaissance.Value.ToShortDateString());
                int r = cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                if (r != 0)
                {
                    MessageBox.Show("Etudiant bien ajouté", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }

            }
        }

        private void precedent_Click(object sender, EventArgs e)
        {
            if (numero.Text != "")
            {

                con.Open();
                string c = numero.Text; //parceque le Numéro s'écrase au fur et à mesure du parcours
                MySqlCommand cmd = new MySqlCommand("select * from Etudiant", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) //parcourir la table
                {
                    if (dr[0].ToString() != c) // écraser tous le étudiants différents de l'étudiant chargé
                    {
                        numero.Text = dr[0].ToString();
                      nom.Text = dr[1].ToString();
                        prenome.Text = dr[2].ToString();
                        dateNaissance.Value = DateTime.Parse(dr[3].ToString());

                    }
                    else
                        break; //arreter le parcours donc les zones de texte restent contenir les infos de l'étudiant précédent de l'étudiant déja chargé.



                }

                dr.Close();
                con.Close();
            }
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Etudiant", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) //parcourir la table
            {

                if (dr[0].ToString() == numero.Text) //trouver l'étudiant chargé
                {

                    if (dr.Read()) //pointer sur l'étudiant suivant
                    {

                        numero.Text = dr[0].ToString();
                        nom.Text = dr[1].ToString();
                        prenome.Text = dr[2].ToString();
                        dateNaissance.Value = DateTime.Parse(dr[3].ToString());
                    }
                    break;

                }
            }
            con.Close();
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Etudiant", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) //parcourir tous les étudiants jusqu'à le dernier
            {
                numero.Text = dr[0].ToString();
                nom.Text = dr[1].ToString();
                prenome.Text = dr[2].ToString();
                dateNaissance.Value = DateTime.Parse(dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " SELECT AVG(note) AS MOYENNE FROM module, note,etudiant WHERE module.Numero = note.Module AND etudiant.Numero =note.Num_etudiant AND etudiant.Numero= '" + numero.Text + "' GROUP BY etudiant.Numero";
            float moy = float.Parse(cmd.ExecuteScalar().ToString());
           moyenne.Text = moy.ToString(); ;


            con.Close();
        }
    }
}
