namespace Stundenplan_neu
{
    partial class FormNotizen
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
            this.txtNotzEing = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.lblNotiz = new System.Windows.Forms.Label();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notizen eingeben:";
            // 
            // txtNotzEing
            // 
            this.txtNotzEing.Location = new System.Drawing.Point(352, 41);
            this.txtNotzEing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotzEing.Multiline = true;
            this.txtNotzEing.Name = "txtNotzEing";
            this.txtNotzEing.Size = new System.Drawing.Size(683, 442);
            this.txtNotzEing.TabIndex = 1;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(869, 505);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(165, 34);
            this.btnSpeichern.TabIndex = 2;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Location = new System.Drawing.Point(36, 505);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(165, 34);
            this.btnBeenden.TabIndex = 3;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // lblNotiz
            // 
            this.lblNotiz.AutoSize = true;
            this.lblNotiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiz.Location = new System.Drawing.Point(31, 89);
            this.lblNotiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotiz.Name = "lblNotiz";
            this.lblNotiz.Size = new System.Drawing.Size(62, 25);
            this.lblNotiz.TabIndex = 4;
            this.lblNotiz.Text = "Notiz:";
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoeschen.Location = new System.Drawing.Point(352, 505);
            this.btnLoeschen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(165, 34);
            this.btnLoeschen.TabIndex = 5;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // FormNotizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.lblNotiz);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtNotzEing);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNotizen";
            this.Text = "FormNotizen";
            this.Load += new System.EventHandler(this.FormNotizen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotzEing;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Label lblNotiz;
        private System.Windows.Forms.Button btnLoeschen;
    }
}