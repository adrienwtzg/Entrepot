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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMarchandArme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "Acheter 100 plants";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 137);
            this.button2.TabIndex = 1;
            this.button2.Text = "Acheter 100 plants";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 192);
            this.button3.TabIndex = 2;
            this.button3.Text = "Acheter 1000 plants";
            this.button3.UseVisualStyleBackColor = true;
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
            // frmHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmVilleV2.Properties.Resources.ImageHangar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 532);
            this.Controls.Add(this.btnMarchandArme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmHangar";
            this.Text = "Hangar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMarchandArme;

    }
}