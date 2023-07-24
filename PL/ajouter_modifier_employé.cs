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
    public partial class ajouter_modifier_employé : Form
    {

        private gestion_bibliothequeEntities3 db;
        private liste_employé employé;

        public ajouter_modifier_employé()
        {
            InitializeComponent();
        }

        private void ajouter_modifier_employé_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Ajouter employé")
            {
                BL.CLS_employée clemployé = new BL.CLS_employée();
                if (clemployé.ajouter_employé(nom_employé.Text,prenom_employé.Text,dateTimePicker1.Value,nationnalité.Text,motdepasse.Text) == true)
                {
                    MessageBox.Show("employée ajouté avec succes");
                    liste_employé ae = new liste_employé();
                    ae.ShowDialog();

                }

            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment e modifier?", "modifiaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {


                    BL.CLS_employée clemployé = new BL.CLS_employée();
                    db = new gestion_bibliothequeEntities3();
                    employé = new liste_employé();
                    var listeabonnée = db.abonnée.ToList();
                    var id = Convert.ToInt32(id_employé.Text);




                    if (clemployé.modifier_employé(id, nom_employé.Text, prenom_employé.Text, dateTimePicker1.Value,nationnalité.Text,motdepasse.Text) == true)
                    {
                        MessageBox.Show("modification avec succes");
                        liste_employé ae = new liste_employé();
                        ae.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("non modifié");
                    }



                }
            }

        }

        private void id_employé_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }
    }
}
