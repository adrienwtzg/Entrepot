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
    public partial class frmFarmVille : Form
    {
        System.Drawing.Bitmap terre = farmVilleV2.Properties.Resources.ImageTerre;
        System.Drawing.Bitmap ble = farmVilleV2.Properties.Resources.ImageBle;
        System.Drawing.Bitmap plus = farmVilleV2.Properties.Resources.ImagePlus;
        public int Argent = 200;
        public int Ble = 0;
        public int RebourBle1 = 11;

        public frmFarmVille()
        {
            InitializeComponent();
        }

        private void frmFarmVille_Load(object sender, EventArgs e)
        {
            //Bouton blé 1
            btnBle1.Enabled = false;
            btnPlusBle1.Enabled = true;
            tbxBle1.Text = "";
        }

        private void btnPlusBle1_Click(object sender, EventArgs e)
        {
            if(Argent >= 50)
            {
                Argent -= 50;
                lblArgent.Text = Argent.ToString();
                btnPlusBle1.Enabled = false;
                TimerBle1.Enabled = true;
                btnBle1.BackgroundImage = ble;
            }
        }

        private void TimerBle1_Tick(object sender, EventArgs e)
        {
            RebourBle1 -= 1;
            tbxBle1.Text = RebourBle1.ToString() + " secondes";
            if(RebourBle1 < 1)
            {
                RebourBle1 = 11;
                TimerBle1.Enabled = false;
                btnBle1.Enabled = true;
                tbxBle1.Text = "Terminé";
                
            }
        }

        private void btnBle1_Click(object sender, EventArgs e)
        {
            Ble += 100;
            lblBle.Text = Ble.ToString();
            btnBle1.BackgroundImage = terre;
            btnBle1.Enabled = false;
            btnPlusBle1.Enabled = true;
            tbxBle1.Text = "";
        }
    }
}
