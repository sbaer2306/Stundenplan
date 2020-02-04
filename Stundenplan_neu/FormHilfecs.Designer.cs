namespace Stundenplan_neu
{
    partial class FormHilfe
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
            this.btnNotenberechnung = new System.Windows.Forms.Button();
            this.btnNotizen = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.lblUeber = new System.Windows.Forms.Label();
            this.lblUeber1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnKontaktdaten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotenberechnung
            // 
            this.btnNotenberechnung.Location = new System.Drawing.Point(30, 90);
            this.btnNotenberechnung.Name = "btnNotenberechnung";
            this.btnNotenberechnung.Size = new System.Drawing.Size(205, 38);
            this.btnNotenberechnung.TabIndex = 0;
            this.btnNotenberechnung.Text = "Notenberechnung";
            this.btnNotenberechnung.UseVisualStyleBackColor = true;
            this.btnNotenberechnung.Click += new System.EventHandler(this.btnNotenberechnung_Click);
            // 
            // btnNotizen
            // 
            this.btnNotizen.Location = new System.Drawing.Point(30, 134);
            this.btnNotizen.Name = "btnNotizen";
            this.btnNotizen.Size = new System.Drawing.Size(205, 37);
            this.btnNotizen.TabIndex = 2;
            this.btnNotizen.Text = "Notizen";
            this.btnNotizen.UseVisualStyleBackColor = true;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(30, 333);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(205, 39);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // lblUeber
            // 
            this.lblUeber.AutoSize = true;
            this.lblUeber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeber.Location = new System.Drawing.Point(371, 9);
            this.lblUeber.Name = "lblUeber";
            this.lblUeber.Size = new System.Drawing.Size(60, 25);
            this.lblUeber.TabIndex = 4;
            this.lblUeber.Text = "Hilfe";
            // 
            // lblUeber1
            // 
            this.lblUeber1.AutoSize = true;
            this.lblUeber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeber1.Location = new System.Drawing.Point(204, 46);
            this.lblUeber1.Name = "lblUeber1";
            this.lblUeber1.Size = new System.Drawing.Size(434, 24);
            this.lblUeber1.TabIndex = 5;
            this.lblUeber1.Text = "Bitte drücken Sie einen Button um Hilfe zu erhalten";
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(306, 90);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(459, 327);
            this.txtInfo.TabIndex = 6;
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(30, 378);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(205, 39);
            this.btnBeenden.TabIndex = 7;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(30, 177);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(205, 37);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Infos";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnKontaktdaten
            // 
            this.btnKontaktdaten.Location = new System.Drawing.Point(30, 220);
            this.btnKontaktdaten.Name = "btnKontaktdaten";
            this.btnKontaktdaten.Size = new System.Drawing.Size(205, 37);
            this.btnKontaktdaten.TabIndex = 9;
            this.btnKontaktdaten.Text = "Kontaktdaten";
            this.btnKontaktdaten.UseVisualStyleBackColor = true;
            this.btnKontaktdaten.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHilfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKontaktdaten);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblUeber1);
            this.Controls.Add(this.lblUeber);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnNotizen);
            this.Controls.Add(this.btnNotenberechnung);
            this.Name = "FormHilfe";
            this.Text = "FormHilfe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotenberechnung;
        private System.Windows.Forms.Button btnNotizen;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Label lblUeber;
        private System.Windows.Forms.Label lblUeber1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnKontaktdaten;
    }
}