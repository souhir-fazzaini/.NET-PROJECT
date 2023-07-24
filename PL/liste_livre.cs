using System;
using System.Linq;
using System.Windows.Forms;

namespace GESTION_BIBLIOTHEQUES.PL
{
    public partial class liste_livre : Form
    {
        gestion_bibliothequeEntities3 db;
        public liste_livre()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();
        }
        public void Actualisedatagrid()
        {
            dataGridView1.Rows.Clear();
            if (db.livre.Count() == 0)
            {
                MessageBox.Show("vide");
            }
            foreach (var s in db.livre)
            {
                if(s.empruneter==false)

                dataGridView1.Rows.Add(false,s.id_livre, s.titre, s.auteur, s.editeur, s.annee_publication, s.nombre_pages,s.prix,"non emprunter","non abonnée");
                else
                    foreach(var s1 in db.abonnée)
                        if(s.id_abonnée==s1.id_abonnée)
                    dataGridView1.Rows.Add(false,s.id_livre, s.titre, s.auteur, s.editeur, s.annee_publication, s.nombre_pages, s.prix, "emprunter",s1.nom);
                
            }





        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void liste_livre_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new gestion_bibliothequeEntities3();

        
            livre d = new livre();

            PL.ajouter_modifier_livre aj = new ajouter_modifier_livre();
        var   listedomaine= db.domaine.ToList();
            if (listedomaine.Count() == 0)
                MessageBox.Show("domaine vide");
            foreach (var element in listedomaine)
            {
              
                aj.comboBox1.Items.Add(element.libellé.ToString());
            }
            aj.label11.Visible = false;
            aj.comboBox2.Visible = false;
            aj.textBox7.Visible = false;
            aj.label9.Visible = false;
            aj.label10.Visible = false;
            aj.textBox6.Visible = false;

            aj.ShowDialog();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            BL.CLS_livre cls_livre = new BL.CLS_livre();
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
                MessageBox.Show("selecioner le livre que vous voulez supprimer");
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
                            cls_livre.supprimer_livre(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                        }



                        
                    }
                    MessageBox.Show("suupresion avec succes", "Suppression");
                    liste_livre al = new liste_livre();
                    al.ShowDialog();


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
                return "selecioner le livre  ";
            }
            if (nombreligneselect > 1)
            {
                return nombreligneselect + "selecioner seulement un seule livre ";
            }
            return null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PL.ajouter_modifier_livre ad = new ajouter_modifier_livre();

            if (selectverif() == null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    bool Cell = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                    if (Cell == true)
                    {

                      

                        ad.textBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ad.textBox2.Text= dataGridView1.Rows[i].Cells[7].Value.ToString();
                        ad.textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        ad.textBox4.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        ad.textBox5.Text= dataGridView1.Rows[i].Cells[4].Value.ToString();
                        ad.dateTimePicker1.Value = (DateTime)dataGridView1.Rows[i].Cells[5].Value;
                        ad.textBox7.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        ad.textBox6.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

                        
                        foreach (var element in db.abonnée)
                            ad.comboBox2.Items.Add(element.nom.ToString());






                    }

                }
                ad.label1.Text = "modifier livre";


                ad.ShowDialog();


            }
            else
            {
                MessageBox.Show(selectverif(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
