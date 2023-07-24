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
    public partial class ajouter_modifier_livre : Form
    {
        private gestion_bibliothequeEntities3 db;
        public ajouter_modifier_livre()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();
        }

        private void ajouter_modifier_livre_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre_page = Convert.ToInt32(textBox4.Text);
            var prix = Convert.ToInt32(textBox2.Text);
            if (label1.Text == "Ajouter livre")
            {
                BL.CLS_livre cllivre = new BL.CLS_livre();
                if (cllivre.ajouter_livre(textBox1.Text,textBox3.Text,textBox5.Text,nombre_page,prix,comboBox1.SelectedItem.ToString(), dateTimePicker1.Value) == true)
                {
                    MessageBox.Show("livre ajouté avec succes");
                    liste_livre al = new liste_livre();
                    al.ShowDialog();


                }

            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment e modifier?", "modifiaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {


                    BL.CLS_livre cllivre = new BL.CLS_livre();
                    db = new gestion_bibliothequeEntities3();
                    liste_livre ld = new liste_livre();
                    var listeabonnée = db.abonnée.ToList();
                    var id = Convert.ToInt32(textBox6.Text);
                     var prix1 = Convert.ToInt32(textBox2.Text);
                    var nbre_page = Convert.ToInt32(textBox4.Text);


                    if (cllivre.modifier_livre(id,textBox1.Text,textBox3.Text,textBox5.Text,nbre_page,prix,comboBox1.SelectedIndex.ToString(),dateTimePicker1.Value,textBox7.Text,comboBox2.SelectedItem.ToString()) == true)
                    {
                        MessageBox.Show("modification avec succes");
                        liste_livre al = new liste_livre();
                        al.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("non modifié");
                    }




                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
