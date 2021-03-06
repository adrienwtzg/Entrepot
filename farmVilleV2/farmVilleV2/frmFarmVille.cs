﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace farmVilleV2
{
    public partial class frmFarmVille : Form
    {
        System.Drawing.Bitmap terre = farmVilleV2.Properties.Resources.ImageTerre;
        System.Drawing.Bitmap ble = farmVilleV2.Properties.Resources.ImageBle;
        System.Drawing.Bitmap plus = farmVilleV2.Properties.Resources.ImagePlus;

        public static int Argent = 200;
        public static int Ble = 0;

        public int RebourBle1 = 10;
        public int RebourBle2 = 10;
        public int RebourBle3 = 10;
        public int MaxExp = 500;
        public int LevelExp = 1;
        frmHangar Hangar = new frmHangar();
        Inventaire Inventaire = new Inventaire();

        bool ble1EnCours = false, ble1Termine = false;
        bool ble2EnCours = false, ble2Termine = false;
        bool ble3EnCours = false, ble3Termine = false;
        

        public frmFarmVille()
        {
            InitializeComponent();
        }

        private void frmFarmVille_Load(object sender, EventArgs e)
        {
            //Bouton blé 1
            btnBle1.Enabled = true;
            tbxBle1.Text = "";

            //Bouton blé 2
            btnBle2.Enabled = true;
            tbxBle2.Text = "";

            //Bouton blé 3
            btnBle3.Enabled = true;
            tbxBle3.Text = "";

            //Progressbar
            pgbLevel.Maximum = MaxExp;
            pgbLevel.Value = 0;

            //Blé
            Ble = 0;
            lblBle.Text = Ble.ToString();

        }
        private void tbxBle3_TextChanged(object sender, EventArgs e)
        {

        }


        bool terrain1Acheter = false;

        private void btnAcheterTerrain1_Click(object sender, EventArgs e)
        {
            if ((Argent >= 500) && !terrain1Acheter)
            {
                terrain1Acheter = true;
                Argent -= 500;
                btnBle3.Visible = true;
                tbxBle3.Visible = true;
                lblDollarBle3.Visible = true;
                btnAcheterTerrain1.Dispose();

                Affichage();
            }

        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            Argent += 1000;
            Affichage();
            for (int i = 0; i < 50; i++)
            {
                pgbLevel.PerformStep();
                VerifiePgbLevel();
            }
        }


        // Blé 1**************************************************

        private void TimerBle1_Tick(object sender, EventArgs e)
        {
            ble1EnCours = true;
            tbxBle1.Text = RebourBle1.ToString() + " secondes";
            
            
            if(RebourBle1 < 1)
            {
                RebourBle1 = 11;
                TimerBle1.Enabled = false;
                btnBle1.Enabled = true;
                tbxBle1.Text = "Terminé";
                ble1Termine = true;
            }
            RebourBle1 -= 1;
        }

        private void btnBle1_Click(object sender, EventArgs e)
        {
            if ((Argent >= 50) && !ble1EnCours)
            {
                Argent -= 50;
                btnBle1.Enabled = false;
                TimerBle1.Enabled = true;
                btnBle1.BackgroundImage = ble;
            }

            if (ble1Termine)
            {
                AjoutExp();

                Ble += 100;
                btnBle1.BackgroundImage = terre;
                btnBle1.Enabled = true;
                tbxBle1.Text = "";
                ble1Termine = false;
                ble1EnCours = false;
            }

            Affichage();
        }

        // blé 2 ************************************************

        private void TimerBle2_Tick(object sender, EventArgs e)
        {
            ble2EnCours = true;
            tbxBle2.Text = RebourBle2.ToString() + " secondes";

            if (RebourBle2 < 1)
            {
                RebourBle2 = 11;
                TimerBle2.Enabled = false;
                btnBle2.Enabled = true;
                tbxBle2.Text = "Terminé";
                ble2Termine = true;
            }
            RebourBle2 -= 1;
        }

        private void btnBle2_Click(object sender, EventArgs e)
        {
            if ((Argent >= 50) && !ble2EnCours)
            {
                Argent -= 50;
                btnBle2.Enabled = false;
                TimerBle2.Enabled = true;
                btnBle2.BackgroundImage = ble;
            }

            if (ble2Termine)
            {
                AjoutExp();

                Ble += 100;
                pgbLevel.PerformStep();
                btnBle2.BackgroundImage = terre;
                btnBle2.Enabled = true;
                tbxBle2.Text = "";
                ble2EnCours = false;
                ble2Termine = false;
            }

            Affichage();
        }


        //Blé 3 **************************************************

        private void TimerBle3_Tick(object sender, EventArgs e)
        {
            ble3EnCours = true;
            tbxBle3.Text = RebourBle2.ToString() + " secondes";
            if (RebourBle3 < 1)
            {
                RebourBle3 = 11;
                TimerBle3.Enabled = false;
                btnBle3.Enabled = true;
                tbxBle3.Text = "Terminé";
                ble3Termine = true;
            }
            RebourBle3 -= 1;
        }

        private void btnBle3_Click(object sender, EventArgs e)
        {
            if ((Argent >= 50) && !ble3EnCours)
            {
                Argent -= 50;
                btnBle3.Enabled = false;
                TimerBle3.Enabled = true;
                btnBle3.BackgroundImage = ble;
            }

            if (ble3Termine)
            {
                AjoutExp();

                Ble += 100;
                pgbLevel.PerformStep();
                btnBle3.BackgroundImage = terre;
                btnBle3.Enabled = true;
                tbxBle3.Text = "";
                ble3EnCours = false;
                ble3Termine = false;
            }

            Affichage();
        }


        private void btnAcheterHangar_Click(object sender, EventArgs e)
        {
            if (Argent >= 5000)
            {
                Argent -= 5000;
                lblArgent.Text = Argent.ToString();
                btnOuvrirHangar.Visible = true;
                btnAcheterHangar.Visible = false; 
            }
        }

        private void btnOuvrirHangar_Click(object sender, EventArgs e)
        {
            Hangar.ShowDialog();
        }

        /// <summary>
        /// Verifie si la barre d'experience est au maximum, change les niveaux en fonction
        /// </summary>
        private void VerifiePgbLevel()
        {
            if (pgbLevel.Value == pgbLevel.Maximum)
            {
                pgbLevel.Value = 0;
                LevelExp += 1;
                MaxExp += 200;
                lblExp.Text = LevelExp.ToString();
            }
            if (LevelExp >= 5)
            {
                btnAcheterHangar.Enabled = true;
            }
        }

        /// <summary>
        /// Ajoute de l'experience
        /// </summary>
        private void AjoutExp()
        {
            pgbLevel.Step = 100;
            pgbLevel.PerformStep();
            pgbLevel.Step = 0;
            VerifiePgbLevel();
        }


        private void Affichage()
        {
            lblArgent.Text = Argent.ToString();
            lblBle.Text = Ble.ToString();
        }

        private void btnVendre100Ble_Click(object sender, EventArgs e)
        {
            if (Ble >= 100)
            {
                Ble -= 100;
                Argent += 100;
                lblArgent.Text = Argent.ToString();
                lblBle.Text = Ble.ToString();
            }
        }

        private void btnInventaire_Click(object sender, EventArgs e)
        {
            Inventaire.ShowDialog();
        }

        private void CheatOuvrirHangar_Click(object sender, EventArgs e)
        {
            Hangar.ShowDialog();
        }
    }
}
