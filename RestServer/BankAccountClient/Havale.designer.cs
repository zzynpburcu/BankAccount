namespace BankAccountControl
{
    partial class Havale
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
            this.txt_Iban = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ParaGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Iban
            // 
            this.txt_Iban.Location = new System.Drawing.Point(102, 45);
            this.txt_Iban.MaxLength = 26;
            this.txt_Iban.Name = "txt_Iban";
            this.txt_Iban.Size = new System.Drawing.Size(228, 20);
            this.txt_Iban.TabIndex = 1;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(102, 90);
            this.txt_AdSoyad.MaxLength = 26;
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(228, 20);
            this.txt_AdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(102, 132);
            this.txt_Miktar.MaxLength = 26;
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(228, 20);
            this.txt_Miktar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // btn_ParaGonder
            // 
            this.btn_ParaGonder.Location = new System.Drawing.Point(133, 192);
            this.btn_ParaGonder.Name = "btn_ParaGonder";
            this.btn_ParaGonder.Size = new System.Drawing.Size(132, 41);
            this.btn_ParaGonder.TabIndex = 6;
            this.btn_ParaGonder.Text = "Gönder";
            this.btn_ParaGonder.UseVisualStyleBackColor = true;
            this.btn_ParaGonder.Click += new System.EventHandler(this.btn_ParaGonder_Click);
            // 
            // Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.btn_ParaGonder);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Iban);
            this.Controls.Add(this.label1);
            this.Name = "Havale";
            this.Text = "EFT / Havale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Iban;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ParaGonder;
    }
}