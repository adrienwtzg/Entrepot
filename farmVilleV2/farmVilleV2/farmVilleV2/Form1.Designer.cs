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
            this.btnPlusBle1 = new System.Windows.Forms.Button();
            this.btnBle1 = new System.Windows.Forms.Button();
            this.TimerBle1 = new System.Windows.Forms.Timer(this.components);
            this.btnAcheterHangar = new System.Windows.Forms.Button();
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
            // btnPlusBle1
            // 
            this.btnPlusBle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlusBle1.BackgroundImage")));
            this.btnPlusBle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusBle1.Location = new System.Drawing.Point(11, 12);
            this.btnPlusBle1.Name = "btnPlusBle1";
            this.btnPlusBle1.Size = new System.Drawing.Size(26, 23);
            this.btnPlusBle1.TabIndex = 41;
            this.btnPlusBle1.UseVisualStyleBackColor = true;
            this.btnPlusBle1.Click += new System.EventHandler(this.btnPlusBle1_Click);
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
            // TimerBle1
            // 
            this.TimerBle1.Interval = 1000;
            this.TimerBle1.Tick += new System.EventHandler(this.TimerBle1_Tick);
            // 
            // btnAcheterHangar
            // 
            this.btnAcheterHangar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcheterHangar.Location = new System.Drawing.Point(580, 92);
            this.btnAcheterHangar.Name = "btnAcheterHangar";
            this.btnAcheterHangar.Size = new System.Drawing.Size(173, 45);
            this.btnAcheterHangar.TabIndex = 44;
            this.btnAcheterHangar.Text = "Acheter le Hangar";
            this.btnAcheterHangar.UseVisualStyleBackColor = true;
            // 
            // frmFarmVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 532);
            this.Controls.Add(this.btnAcheterHangar);
            this.Controls.Add(this.tbxBle1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlusBle1);
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
        private System.Windows.Forms.Button btnPlusBle1;
        private System.Windows.Forms.Button btnBle1;
        private System.Windows.Forms.Timer TimerBle1;
        private System.Windows.Forms.Button btnAcheterHangar;
    }
}

