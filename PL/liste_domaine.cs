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
    public partial class liste_domaine : Form
    {
        private gestion_bibliothequeEntities3 db;
        public liste_domaine()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();
        }
        public void Actualisedatagrid()
        {
            dgvdomaine.Rows.Clear();
            if(db.domaine.Count()==0)
            {
                MessageBox.Show("vide");
            }
            foreach (var s in db.domaine)
            {
                dgvdomaine.Rows.Add(s.id_dom, s.libellé);
            }





        }

        private void dgvdomaine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.CLS_domaine cls_domaine = new BL.CLS_domaine();
            int nombreligneselect = 0;
            for (int i = 0; i < dgvdomaine.Rows.Count; i++)
            {
                bool Cell = Convert.ToBoolean(dgvdomaine.Rows[i].Cells[2].Value);
                if (Cell == true)
                {
                    nombreligneselect++;
                }


            }

            if (nombreligneselect == 0)
            {
                MessageBox.Show("selecioner le domaine que vous voulez supprimer");
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez vous le supprimer?", "suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvdomaine.Rows.Count; i++)
                    {
                        bool Cell = Convert.ToBoolean(dgvdomaine.Rows[i].Cells[2].Value);
                        if (Cell == true)
                        {
                            MessageBox.Show(dgvdomaine.Rows[i].Cells[0].Value.ToString());
                            cls_domaine.supprimer_domaine(int.Parse(dgvdomaine.Rows[i].Cells[0].Value.ToString()));
                        }



                    }

                    MessageBox.Show("suupresion avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    liste_domaine ad = new liste_domaine();
                    ad.ShowDialog();


                }
                else
                {
                    MessageBox.Show("supresion est annulé","Suppresion",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

            }
        }
        public String selectverif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dgvdomaine.Rows.Count; i++)
            {
                bool Cell = Convert.ToBoolean(dgvdomaine.Rows[i].Cells[2].Value);
                if (Cell==true)
                {
                    nombreligneselect++;
                }
               

            }
            
            if(nombreligneselect==0)
            {
                return "selecioner le domaine que vous voulez modifier ";
            }
            if (nombreligneselect>1)
            {
                return nombreligneselect+"selecioner seulement un seule domaine ";
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.ajouter_modifier_domaine ad = new ajouter_modifier_domaine();

            if(selectverif()==null)
            {
                for(int i=0;i<dgvdomaine.Rows.Count;i++)
                {
                    bool Cell = Convert.ToBoolean(dgvdomaine.Rows[i].Cells[2].Value);
                    if (Cell==true)
                    {
                      int  IDselect = Convert.ToInt32(dgvdomaine.Rows[i].Cells[2].Value);
                        int id = Convert.ToInt32(dgvdomaine.Rows[i].Cells[0].Value);
                       
                        ad.textBox1.Text = dgvdomaine.Rows[i].Cells[1].Value.ToString();
                        ad.textBox2.Text = dgvdomaine.Rows[i].Cells[0].Value.ToString();





                    }

                }
                ad.label1.Text = "modifier domaine";
             

                ad.ShowDialog();


            }else
            {
                MessageBox.Show(selectverif(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public int IDselect;
        public int id;
        private void button1_Click(object sender, EventArgs e)
        {

            PL.ajouter_modifier_domaine aj = new ajouter_modifier_domaine();
            aj.textBox2.Visible = false;
            aj.label3.Visible = false;
            aj.ShowDialog();
        }

        private void liste_domaine_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
    }
}
