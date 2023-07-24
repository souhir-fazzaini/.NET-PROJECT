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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.liste_livre lv = new liste_livre();
            lv.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.liste_domaine ld = new liste_domaine();
            ld.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PL.liste_abonnée la = new liste_abonnée();
            la.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.liste_employé le = new liste_employé();
            le.ShowDialog();
        }
    }
}
