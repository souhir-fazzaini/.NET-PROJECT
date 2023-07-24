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
    public partial class ajouter_modifier_domaine : Form
    {
        private gestion_bibliothequeEntities3 db;
        private liste_domaine domaine;

        public ajouter_modifier_domaine()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Ajouter domaine")
            {
                BL.CLS_domaine cldomaine = new BL.CLS_domaine();
                if (cldomaine.ajouter_domaine(textBox1.Text) == true)
                {
                    MessageBox.Show("domaine ajouté avec succes");
                    liste_domaine ad = new liste_domaine();
                    ad.ShowDialog();

                }
                else
                { MessageBox.Show("domaine existe deja"); }
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment e modifier?","modifiaction",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {


                    BL.CLS_domaine cldomaine = new BL.CLS_domaine();
                    liste_domaine ld = new liste_domaine();
                   var listedomaine = db.domaine.ToList();
                    var id = Convert.ToInt32(textBox2.Text);
                
                
                   
                    
                        if (cldomaine.modifier_domaine(id, textBox1.Text, ld.IDselect)==true)
                    {
                        MessageBox.Show("modification avec succes");
                        liste_domaine ad = new liste_domaine();
                        ad.ShowDialog();
                    }
                       else
                    {
                        MessageBox.Show("non modifer");
                    }
                   

                    
                }
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_modifier_domaine_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
