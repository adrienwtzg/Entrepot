using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmVilleV2
{
    public partial class frmHangar : Form
    {
        int Plants = 0;
        int Argent = frmFarmVille.Argent;
        public frmHangar()
        {
            InitializeComponent();
        }

        private void frmHangar_Load(object sender, EventArgs e)
        {
            ActualisationNbPlants();
            ActualisationArgent();
        }
        private void ActualisationNbPlants()
        {
            tbxAffichagePlants.Text = Plants.ToString();
        }
        private void ActualisationArgent()
        {
            tbxAffichageArgent.Text = frmFarmVille.Argent.ToString();
            Argent = frmFarmVille.Argent;
        }

        private void btnAcheter50Plants_Click(object sender, EventArgs e)
        {
            ActualisationArgent();
            if (Argent >= 250)
            {
                Argent -= 250;
                frmFarmVille.Argent -= 250;
                ActualisationArgent();
                Plants += 50;
                ActualisationNbPlants();
            }
        }

        private void btnAcheter100Plants_Click(object sender, EventArgs e)
        {
            ActualisationArgent();
            if (Argent >= 500)
            {
                Argent -= 500;
                frmFarmVille.Argent -= 500;
                ActualisationArgent();
                Plants += 100;
                ActualisationNbPlants();
            }
        }

        private void btnAcheter1000Plants_Click(object sender, EventArgs e)
        {
            ActualisationArgent();
            if (Argent >= 5000)
            {
                Argent -= 5000;
                frmFarmVille.Argent -= 5000;
                ActualisationArgent();
                Plants += 1000;
                ActualisationNbPlants();
            }
        }
    }
}
