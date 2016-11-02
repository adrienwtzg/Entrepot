namespace farmVilleV2
{
    partial class frmHangar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcheter50Plants = new System.Windows.Forms.Button();
            this.btnAcheter100Plants = new System.Windows.Forms.Button();
            this.btnAcheter1000Plants = new System.Windows.Forms.Button();
            this.btnMarchandArme = new System.Windows.Forms.Button();
            this.tbxAffichagePlants = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAffichageArgent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcheter50Plants
            // 
            this.btnAcheter50Plants.Location = new System.Drawing.Point(87, 235);
            this.btnAcheter50Plants.Name = "btnAcheter50Plants";
            this.btnAcheter50Plants.Size = new System.Drawing.Size(184, 137);
            this.btnAcheter50Plants.TabIndex = 0;
            this.btnAcheter50Plants.Text = "Acheter 50 plants\r\n(250 $)\r\n";
            this.btnAcheter50Plants.UseVisualStyleBackColor = true;
            this.btnAcheter50Plants.Click += new System.EventHandler(this.btnAcheter50Plants_Click);
            // 
            // btnAcheter100Plants
            // 
            this.btnAcheter100Plants.Location = new System.Drawing.Point(495, 235);
            this.btnAcheter100Plants.Name = "btnAcheter100Plants";
            this.btnAcheter100Plants.Size = new System.Drawing.Size(184, 137);
            this.btnAcheter100Plants.TabIndex = 1;
            this.btnAcheter100Plants.Text = "Acheter 100 plants \r\n(500 $)";
            this.btnAcheter100Plants.UseVisualStyleBackColor = true;
            this.btnAcheter100Plants.Click += new System.EventHandler(this.btnAcheter100Plants_Click);
            // 
            // btnAcheter1000Plants
            // 
            this.btnAcheter1000Plants.Location = new System.Drawing.Point(268, 180);
            this.btnAcheter1000Plants.Name = "btnAcheter1000Plants";
            this.btnAcheter1000Plants.Size = new System.Drawing.Size(231, 192);
            this.btnAcheter1000Plants.TabIndex = 2;
            this.btnAcheter1000Plants.Text = "Acheter 1000 plants\r\n(5000 $)";
            this.btnAcheter1000Plants.UseVisualStyleBackColor = true;
            this.btnAcheter1000Plants.Click += new System.EventHandler(this.btnAcheter1000Plants_Click);
            // 
            // btnMarchandArme
            // 
            this.btnMarchandArme.Location = new System.Drawing.Point(12, 12);
            this.btnMarchandArme.Name = "btnMarchandArme";
            this.btnMarchandArme.Size = new System.Drawing.Size(131, 35);
            this.btnMarchandArme.TabIndex = 3;
            this.btnMarchandArme.Text = "Marchand Armes";
            this.btnMarchandArme.UseVisualStyleBackColor = true;
            // 
            // tbxAffichagePlants
            // 
            this.tbxAffichagePlants.Enabled = false;
            this.tbxAffichagePlants.Location = new System.Drawing.Point(653, 11);
            this.tbxAffichagePlants.Name = "tbxAffichagePlants";
            this.tbxAffichagePlants.ReadOnly = true;
            this.tbxAffichagePlants.Size = new System.Drawing.Size(100, 20);
            this.tbxAffichagePlants.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plants :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Argent :";
            // 
            // tbxAffichageArgent
            // 
            this.tbxAffichageArgent.Enabled = false;
            this.tbxAffichageArgent.Location = new System.Drawing.Point(653, 44);
            this.tbxAffichageArgent.Name = "tbxAffichageArgent";
            this.tbxAffichageArgent.ReadOnly = true;
            this.tbxAffichageArgent.Size = new System.Drawing.Size(100, 20);
            this.tbxAffichageArgent.TabIndex = 7;
            // 
            // frmHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmVilleV2.Properties.Resources.ImageHangar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 532);
            this.Controls.Add(this.tbxAffichageArgent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAffichagePlants);
            this.Controls.Add(this.btnMarchandArme);
            this.Controls.Add(this.btnAcheter1000Plants);
            this.Controls.Add(this.btnAcheter100Plants);
            this.Controls.Add(this.btnAcheter50Plants);
            this.Name = "frmHangar";
            this.Text = "Hangar";
            this.Load += new System.EventHandler(this.frmHangar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcheter50Plants;
        private System.Windows.Forms.Button btnAcheter100Plants;
        private System.Windows.Forms.Button btnAcheter1000Plants;
        private System.Windows.Forms.Button btnMarchandArme;
        private System.Windows.Forms.TextBox tbxAffichagePlants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAffichageArgent;

    }
}