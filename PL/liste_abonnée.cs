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
    public partial class liste_abonnée : Form
    {
        private gestion_bibliothequeEntities3 db;
        public liste_abonnée()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();
        }
        public void Actualisedatagrid()
        {
            dgvabonnée.Rows.Clear();
            if (db.abonnée.Count() == 0)
            {
                MessageBox.Show("vide");
            }
            foreach (var s in db.abonnée)          {
                dgvabonnée.Rows.Add(false,s.id_abonnée, s.nom,s.prenom,s.date_naissance,s.nationnalité);
            }





        }

        private void dgvdomaine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.CLS_abonnée cls_abonnée = new BL.CLS_abonnée();
            int nombreligneselect = 0;
            for (int i = 0; i < dgvabonnée.Rows.Count; i++)
            {
                bool Cell = Convert.ToBoolean(dgvabonnée.Rows[i].Cells[0].Value);
                if (Cell == true)
                {
                    nombreligneselect++;
                }


            }

            if (nombreligneselect == 0)
            {
                MessageBox.Show("selecioner l'abonnée que vous voulez supprimer");
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez vous le supprimer?", "suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvabonnée.Rows.Count; i++)
                    {
                        bool Cell = Convert.ToBoolean(dgvabonnée.Rows[i].Cells[0].Value);
                        if (Cell == true)
                        {
                            MessageBox.Show(dgvabonnée.Rows[i].Cells[0].Value.ToString());
                            cls_abonnée.supprimer_abonnée(int.Parse(dgvabonnée.Rows[i].Cells[1].Value.ToString()));
                        }



                    }

                    MessageBox.Show("suupresion avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    liste_abonnée ab = new liste_abonnée();
                    ab.ShowDialog();

                }
                else
                {
                    MessageBox.Show("supresion est annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
        public String selectverif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dgvabonnée.Rows.Count; i++)
            {
                bool Cell = Convert.ToBoolean(dgvabonnée.Rows[i].Cells[0].Value);
                if (Cell == true)
                {
                    nombreligneselect++;
                }


            }

            if (nombreligneselect == 0)
            {
                return "selecioner l'abonnée que vous voulez modifier ";
            }
            if (nombreligneselect > 1)
            {
                return nombreligneselect + "selecioner seulement un seule abonnée ";
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.ajouter_modifier_abonnée ad = new ajouter_modifier_abonnée();

            if (selectverif() == null)
            {
                for (int i = 0; i < dgvabonnée.Rows.Count; i++)
                {
                    bool Cell = Convert.ToBoolean(dgvabonnée.Rows[i].Cells[0].Value);
                    if (Cell == true)
                    {
                       
                        int id = Convert.ToInt32(dgvabonnée.Rows[i].Cells[1].Value);

                        ad.textBox1.Text = dgvabonnée.Rows[i].Cells[2].Value.ToString();
                        ad.textBox3.Text = dgvabonnée.Rows[i].Cells[3].Value.ToString();
                        ad.textBox2.Text = dgvabonnée.Rows[i].Cells[1].Value.ToString();
                        ad.dateTimePicker1.Value = (DateTime)dgvabonnée.Rows[i].Cells[4].Value;
                        ad.textBox5.Text = dgvabonnée.Rows[i].Cells[5].Value.ToString();






                    }

                }
                ad.label1.Text = "modifier abonnée";


                ad.ShowDialog();


            }
            else
            {
                MessageBox.Show(selectverif(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.ajouter_modifier_abonnée aj = new ajouter_modifier_abonnée();
            aj.textBox2.Visible = false;
            aj.id.Visible = false;
            aj.ShowDialog();
        }

        private void liste_abonnée_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
    }
}
