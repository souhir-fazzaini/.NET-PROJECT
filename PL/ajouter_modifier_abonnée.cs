using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_BIBLIOTHEQUES.PL
{
    public partial class ajouter_modifier_abonnée : Form
    {

        private gestion_bibliothequeEntities3 db;
        private liste_abonnée abonnée;

        public ajouter_modifier_abonnée()
        {
            InitializeComponent();
        }

        private void ajouer_modifier_abonnée_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Ajouter abonnée")
            {
                BL.CLS_abonnée clabonnée = new BL.CLS_abonnée();
                if (clabonnée.ajouter_abonnée(textBox1.Text,textBox3.Text,dateTimePicker1.Value,textBox5.Text) == true)
                {
                    MessageBox.Show("abonnée ajouté avec succes");
                    liste_abonnée ab = new liste_abonnée();
                    ab.ShowDialog();

                }
                
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment e modifier?", "modifiaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {


                    BL.CLS_abonnée clabonnée = new BL.CLS_abonnée();
                    db = new gestion_bibliothequeEntities3();
                    liste_abonnée ld = new liste_abonnée();
                    var listeabonnée = db.abonnée.ToList();
                    var id = Convert.ToInt32(textBox2.Text);




                    if (clabonnée.modifier_abonnée(id, textBox1.Text, textBox3.Text,dateTimePicker1.Value,textBox5.Text) == true)
                    {
                        MessageBox.Show("modification avec succes");
                        liste_abonnée ab = new liste_abonnée();
                        ab.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("non modifié");
                    }



                }
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private  void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
