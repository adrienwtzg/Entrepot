namespace farmVilleV2
{
    partial class frmFarmVille
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFarmVille));
            this.label13 = new System.Windows.Forms.Label();
            this.lblBle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArgent = new System.Windows.Forms.Label();
            this.tbxBle1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerBle1 = new System.Windows.Forms.Timer(this.components);
            this.btnAcheterHangar = new System.Windows.Forms.Button();
            this.tbxBle2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimerBle2 = new System.Windows.Forms.Timer(this.components);
            this.btnAcheterTerrain1 = new System.Windows.Forms.Button();
            this.tbxBle3 = new System.Windows.Forms.TextBox();
            this.lblDollarBle3 = new System.Windows.Forms.Label();
            this.btnCheat = new System.Windows.Forms.Button();
            this.TimerBle3 = new System.Windows.Forms.Timer(this.components);
            this.pgbLevel = new System.Windows.Forms.ProgressBar();
            this.lblExp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOuvrirHangar = new System.Windows.Forms.Button();
            this.btnVendre100Ble = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInventaire = new System.Windows.Forms.Button();
            this.btnPlusBle3 = new System.Windows.Forms.Button();
            this.btnBle3 = new System.Windows.Forms.Button();
            this.btnPlusBle2 = new System.Windows.Forms.Button();
            this.btnBle2 = new System.Windows.Forms.Button();
            this.btnBle1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(576, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Blé :";
            // 
            // lblBle
            // 
            this.lblBle.AutoSize = true;
            this.lblBle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBle.Location = new System.Drawing.Point(689, 42);
            this.lblBle.Name = "lblBle";
            this.lblBle.Size = new System.Drawing.Size(39, 20);
            this.lblBle.TabIndex = 38;
            this.lblBle.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Argent :";
            // 
            // lblArgent
            // 
            this.lblArgent.AutoSize = true;
            this.lblArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgent.Location = new System.Drawing.Point(689, 10);
            this.lblArgent.Name = "lblArgent";
            this.lblArgent.Size = new System.Drawing.Size(39, 20);
            this.lblArgent.TabIndex = 35;
            this.lblArgent.Text = "200";
            // 
            // tbxBle1
            // 
            this.tbxBle1.Enabled = false;
            this.tbxBle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxBle1.Location = new System.Drawing.Point(12, 130);
            this.tbxBle1.Name = "tbxBle1";
            this.tbxBle1.ReadOnly = true;
            this.tbxBle1.Size = new System.Drawing.Size(80, 20);
            this.tbxBle1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "50 $";
            // 
            // TimerBle1
            // 
            this.TimerBle1.Interval = 1000;
            this.TimerBle1.Tick += new System.EventHandler(this.TimerBle1_Tick);
            // 
            // btnAcheterHangar
            // 
            this.btnAcheterHangar.Enabled = false;
            this.btnAcheterHangar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcheterHangar.Location = new System.Drawing.Point(579, 118);
            this.btnAcheterHangar.Name = "btnAcheterHangar";
            this.btnAcheterHangar.Size = new System.Drawing.Size(173, 45);
            this.btnAcheterHangar.TabIndex = 44;
            this.btnAcheterHangar.Text = "Acheter le Hangar (Level 5) (5000$)";
            this.btnAcheterHangar.UseVisualStyleBackColor = true;
            this.btnAcheterHangar.Click += new System.EventHandler(this.btnAcheterHangar_Click);
            // 
            // tbxBle2
            // 
            this.tbxBle2.Enabled = false;
            this.tbxBle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxBle2.Location = new System.Drawing.Point(98, 131);
            this.tbxBle2.Name = "tbxBle2";
            this.tbxBle2.ReadOnly = true;
            this.tbxBle2.Size = new System.Drawing.Size(80, 20);
            this.tbxBle2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "50 $";
            // 
            // TimerBle2
            // 
            this.TimerBle2.Interval = 1000;
            this.TimerBle2.Tick += new System.EventHandler(this.TimerBle2_Tick);
            // 
            // btnAcheterTerrain1
            // 
            this.btnAcheterTerrain1.Location = new System.Drawing.Point(184, 44);
            this.btnAcheterTerrain1.Name = "btnAcheterTerrain1";
            this.btnAcheterTerrain1.Size = new System.Drawing.Size(80, 81);
            this.btnAcheterTerrain1.TabIndex = 49;
            this.btnAcheterTerrain1.Text = "Acheter le terrain (500$)";
            this.btnAcheterTerrain1.UseVisualStyleBackColor = true;
            this.btnAcheterTerrain1.Click += new System.EventHandler(this.btnAcheterTerrain1_Click);
            // 
            // tbxBle3
            // 
            this.tbxBle3.Enabled = false;
            this.tbxBle3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxBle3.Location = new System.Drawing.Point(184, 131);
            this.tbxBle3.Name = "tbxBle3";
            this.tbxBle3.ReadOnly = true;
            this.tbxBle3.Size = new System.Drawing.Size(80, 20);
            this.tbxBle3.TabIndex = 53;
            this.tbxBle3.Visible = false;
            this.tbxBle3.TextChanged += new System.EventHandler(this.tbxBle3_TextChanged);
            // 
            // lblDollarBle3
            // 
            this.lblDollarBle3.AutoSize = true;
            this.lblDollarBle3.Location = new System.Drawing.Point(216, 18);
            this.lblDollarBle3.Name = "lblDollarBle3";
            this.lblDollarBle3.Size = new System.Drawing.Size(28, 13);
            this.lblDollarBle3.TabIndex = 52;
            this.lblDollarBle3.Text = "50 $";
            this.lblDollarBle3.Visible = false;
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(677, 497);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(75, 23);
            this.btnCheat.TabIndex = 54;
            this.btnCheat.Text = "Cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // TimerBle3
            // 
            this.TimerBle3.Interval = 1000;
            this.TimerBle3.Tick += new System.EventHandler(this.TimerBle3_Tick);
            // 
            // pgbLevel
            // 
            this.pgbLevel.Location = new System.Drawing.Point(301, 41);
            this.pgbLevel.Name = "pgbLevel";
            this.pgbLevel.Size = new System.Drawing.Size(195, 10);
            this.pgbLevel.TabIndex = 55;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(346, 18);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(13, 13);
            this.lblExp.TabIndex = 57;
            this.lblExp.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Level :";
            // 
            // btnOuvrirHangar
            // 
            this.btnOuvrirHangar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrirHangar.Location = new System.Drawing.Point(580, 117);
            this.btnOuvrirHangar.Name = "btnOuvrirHangar";
            this.btnOuvrirHangar.Size = new System.Drawing.Size(173, 45);
            this.btnOuvrirHangar.TabIndex = 59;
            this.btnOuvrirHangar.Text = "Ouvrir le Hangar";
            this.btnOuvrirHangar.UseVisualStyleBackColor = true;
            this.btnOuvrirHangar.Visible = false;
            this.btnOuvrirHangar.Click += new System.EventHandler(this.btnOuvrirHangar_Click);
            // 
            // btnVendre100Ble
            // 
            this.btnVendre100Ble.Location = new System.Drawing.Point(12, 455);
            this.btnVendre100Ble.Name = "btnVendre100Ble";
            this.btnVendre100Ble.Size = new System.Drawing.Size(131, 37);
            this.btnVendre100Ble.TabIndex = 60;
            this.btnVendre100Ble.Text = "Vendre 100 blé";
            this.btnVendre100Ble.UseVisualStyleBackColor = true;
            this.btnVendre100Ble.Click += new System.EventHandler(this.btnVendre100Ble_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "100 blé = 100$";
            // 
            // btnInventaire
            // 
            this.btnInventaire.Location = new System.Drawing.Point(579, 74);
            this.btnInventaire.Name = "btnInventaire";
            this.btnInventaire.Size = new System.Drawing.Size(173, 23);
            this.btnInventaire.TabIndex = 62;
            this.btnInventaire.Text = "Inventaire";
            this.btnInventaire.UseVisualStyleBackColor = true;
            this.btnInventaire.Click += new System.EventHandler(this.btnInventaire_Click);
            // 
            // btnPlusBle3
            // 
            this.btnPlusBle3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlusBle3.BackgroundImage")));
            this.btnPlusBle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusBle3.Location = new System.Drawing.Point(183, 13);
            this.btnPlusBle3.Name = "btnPlusBle3";
            this.btnPlusBle3.Size = new System.Drawing.Size(26, 23);
            this.btnPlusBle3.TabIndex = 51;
            this.btnPlusBle3.UseVisualStyleBackColor = true;
            this.btnPlusBle3.Visible = false;
            this.btnPlusBle3.Click += new System.EventHandler(this.btnPlusBle3_Click);
            // 
            // btnBle3
            // 
            this.btnBle3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBle3.BackgroundImage")));
            this.btnBle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBle3.Location = new System.Drawing.Point(184, 44);
            this.btnBle3.Name = "btnBle3";
            this.btnBle3.Size = new System.Drawing.Size(80, 82);
            this.btnBle3.TabIndex = 50;
            this.btnBle3.UseVisualStyleBackColor = true;
            this.btnBle3.Visible = false;
            this.btnBle3.Click += new System.EventHandler(this.btnBle3_Click);
            // 
            // btnPlusBle2
            // 
            this.btnPlusBle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlusBle2.BackgroundImage")));
            this.btnPlusBle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusBle2.Location = new System.Drawing.Point(97, 13);
            this.btnPlusBle2.Name = "btnPlusBle2";
            this.btnPlusBle2.Size = new System.Drawing.Size(26, 23);
            this.btnPlusBle2.TabIndex = 46;
            this.btnPlusBle2.UseVisualStyleBackColor = true;
            this.btnPlusBle2.Click += new System.EventHandler(this.btnPlusBle2_Click);
            // 
            // btnBle2
            // 
            this.btnBle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBle2.BackgroundImage")));
            this.btnBle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBle2.Location = new System.Drawing.Point(98, 42);
            this.btnBle2.Name = "btnBle2";
            this.btnBle2.Size = new System.Drawing.Size(80, 82);
            this.btnBle2.TabIndex = 45;
            this.btnBle2.UseVisualStyleBackColor = true;
            this.btnBle2.Click += new System.EventHandler(this.btnBle2_Click);
            // 
            // btnBle1
            // 
            this.btnBle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBle1.BackgroundImage")));
            this.btnBle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBle1.Location = new System.Drawing.Point(12, 41);
            this.btnBle1.Name = "btnBle1";
            this.btnBle1.Size = new System.Drawing.Size(80, 82);
            this.btnBle1.TabIndex = 40;
            this.btnBle1.UseVisualStyleBackColor = true;
            this.btnBle1.Click += new System.EventHandler(this.btnBle1_Click);
            // 
            // frmFarmVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 532);
            this.Controls.Add(this.btnInventaire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVendre100Ble);
            this.Controls.Add(this.btnOuvrirHangar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.pgbLevel);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.tbxBle3);
            this.Controls.Add(this.lblDollarBle3);
            this.Controls.Add(this.btnPlusBle3);
            this.Controls.Add(this.btnBle3);
            this.Controls.Add(this.btnAcheterTerrain1);
            this.Controls.Add(this.tbxBle2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlusBle2);
            this.Controls.Add(this.btnBle2);
            this.Controls.Add(this.btnAcheterHangar);
            this.Controls.Add(this.tbxBle1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBle1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblBle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArgent);
            this.Name = "frmFarmVille";
            this.Text = "FarmVille v2";
            this.Load += new System.EventHandler(this.frmFarmVille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArgent;
        private System.Windows.Forms.TextBox tbxBle1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBle1;
        private System.Windows.Forms.Timer TimerBle1;
        private System.Windows.Forms.Button btnAcheterHangar;
        private System.Windows.Forms.TextBox tbxBle2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlusBle2;
        private System.Windows.Forms.Button btnBle2;
        private System.Windows.Forms.Timer TimerBle2;
        private System.Windows.Forms.Button btnAcheterTerrain1;
        private System.Windows.Forms.TextBox tbxBle3;
        private System.Windows.Forms.Label lblDollarBle3;
        private System.Windows.Forms.Button btnPlusBle3;
        private System.Windows.Forms.Button btnBle3;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.Timer TimerBle3;
        private System.Windows.Forms.ProgressBar pgbLevel;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOuvrirHangar;
        private System.Windows.Forms.Button btnVendre100Ble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInventaire;
    }
}

