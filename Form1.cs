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
using MySql.Data.MySqlClient;

namespace gestionDesNotes
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void gestionDesNotesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gestionEtudiant_Click(object sender, EventArgs e)
        {
            GestionEtudiant form = new GestionEtudiant();
            form.Show();
            this.Hide();

        }

        private void gestionNote_Click(object sender, EventArgs e)
        {
            Form3 from = new Form3();
            this.Hide();

            from.Show();
        }

        private void consultation_Click(object sender, EventArgs e)
        {

        }
    }
}
