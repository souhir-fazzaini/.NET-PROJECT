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
    public partial class liste_employé : Form
    {
        private gestion_bibliothequeEntities3 db;
        public liste_employé()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();
        }
        public void Actualisedatagrid()
        {
            dataGridView1.Rows.Clear();
            if (db.employé.Count() == 0)
            {
                MessageBox.Show("vide");
            }
            foreach (var s in db.employé)
            {
                dataGridView1.Rows.Add(false, s.id_employé, s.nom, s.prenom, s.date_naissance, s.nationnalité,s.motdepasse);
            }





        }
        private void liste_employé_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
          PL.ajouter_modifier_employé ae = new ajouter_modifier_employé();
            ae.id.Visible = false;
            ae.id_employé.Visible = false;
            ae.ShowDialog();
        }
        public String selectverif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool Cell = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                if (Cell == true)
                {
                    nombreligneselect++;
                }


            }

            if (nombreligneselect == 0)
            {
                return "selecioner l'employé  que vous voulez modifier ";
            }
            if (nombreligneselect > 1)
            {
                return nombreligneselect + "selecioner seulement un seule zmployé ";
            }
            return null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PL.ajouter_modifier_employé ad = new ajouter_modifier_employé();

            if (selectverif() == null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    bool Cell = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                    if (Cell == true)
                    {
                        ad.id_employé.Text= dataGridView1.Rows[i].Cells[1].ToString();
                        ad.nom_employé.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ad.prenom_employé.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        ad.id_employé.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        ad.dateTimePicker1.Value = (DateTime)dataGridView1.Rows[i].Cells[4].Value;
                        ad.nationnalité.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        ad.motdepasse.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();






                    }

                }
                ad.label1.Text = "modifier employé";


                ad.ShowDialog();


            }
            else
            {
                MessageBox.Show(selectverif(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.CLS_employée cls_employé = new BL.CLS_employée();
            int nombreligneselect = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool Cell = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                if (Cell == true)
                {
                    nombreligneselect++;
                }


            }

            if (nombreligneselect == 0)
            {
                MessageBox.Show("selecioner employé que vous voulez supprimer");
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez vous le supprimer?", "suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        bool Cell = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                        if (Cell == true)
                        {
                            MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                            cls_employé.supprimer_employé(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                        }



                       
                    }
                    MessageBox.Show("suupresion avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    liste_employé ae = new liste_employé();
                    ae.ShowDialog();

                }
                else
                {
                    MessageBox.Show("supresion est annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
    }
}
