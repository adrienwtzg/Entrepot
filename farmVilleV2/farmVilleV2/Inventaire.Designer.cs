namespace farmVilleV2
{
    partial class Inventaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArgentInventaire = new System.Windows.Forms.Label();
            this.lblBleInventaire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheatInventaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Argent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pain :";
            // 
            // lblArgentInventaire
            // 
            this.lblArgentInventaire.AutoSize = true;
            this.lblArgentInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgentInventaire.Location = new System.Drawing.Point(85, 19);
            this.lblArgentInventaire.Name = "lblArgentInventaire";
            this.lblArgentInventaire.Size = new System.Drawing.Size(18, 20);
            this.lblArgentInventaire.TabIndex = 3;
            this.lblArgentInventaire.Text = "0";
            // 
            // lblBleInventaire
            // 
            this.lblBleInventaire.AutoSize = true;
            this.lblBleInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBleInventaire.Location = new System.Drawing.Point(85, 56);
            this.lblBleInventaire.Name = "lblBleInventaire";
            this.lblBleInventaire.Size = new System.Drawing.Size(18, 20);
            this.lblBleInventaire.TabIndex = 4;
            this.lblBleInventaire.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // btnCheatInventaire
            // 
            this.btnCheatInventaire.Location = new System.Drawing.Point(352, 335);
            this.btnCheatInventaire.Name = "btnCheatInventaire";
            this.btnCheatInventaire.Size = new System.Drawing.Size(75, 23);
            this.btnCheatInventaire.TabIndex = 6;
            this.btnCheatInventaire.Text = "cheat";
            this.btnCheatInventaire.UseVisualStyleBackColor = true;
            this.btnCheatInventaire.Click += new System.EventHandler(this.btnCheatInventaire_Click);
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 370);
            this.Controls.Add(this.btnCheatInventaire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBleInventaire);
            this.Controls.Add(this.lblArgentInventaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArgentInventaire;
        private System.Windows.Forms.Label lblBleInventaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheatInventaire;
    }
}