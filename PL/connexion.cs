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
    public partial class connexion : Form
    {
        private gestion_bibliothequeEntities3 db;
        BL.CLS_connexion c = new BL.CLS_connexion();
        public connexion()
        {
            InitializeComponent();
            db = new gestion_bibliothequeEntities3();
        }
        public string testobligatoire()
        {
            if (textname.Text == "")
            { return "entrer votre nom"; }
            if (textmotdepasse.Text == "")
            {
                return "entrer votre mot de passe";
            }
            return null;
        }
        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(testobligatoire()==null)
            {
               if(c.ConnexionValide(db,textname.Text,textmotdepasse.Text)==true)
                {
                    MessageBox.Show("connexion a reussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    PL.Menu m = new PL.Menu();
                    m.ShowDialog();
                }
               else
                {
                    MessageBox.Show("connexion a echoué", "connexon", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(testobligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
