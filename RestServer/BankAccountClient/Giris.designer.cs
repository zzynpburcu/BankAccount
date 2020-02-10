namespace BankAccountControl
{
    partial class Giris
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
            this.btn_HesapAc = new System.Windows.Forms.Button();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TCHesapNo = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HesapAc
            // 
            this.btn_HesapAc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_HesapAc.Location = new System.Drawing.Point(51, 168);
            this.btn_HesapAc.Name = "btn_HesapAc";
            this.btn_HesapAc.Size = new System.Drawing.Size(168, 40);
            this.btn_HesapAc.TabIndex = 0;
            this.btn_HesapAc.Text = "Hesap Aç";
            this.btn_HesapAc.UseVisualStyleBackColor = false;
            this.btn_HesapAc.Click += new System.EventHandler(this.btn_HesapAc_Click);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GirisYap.Location = new System.Drawing.Point(236, 168);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(168, 40);
            this.btn_GirisYap.TabIndex = 1;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC Kimlik No / Hesap No:";
            // 
            // txt_TCHesapNo
            // 
            this.txt_TCHesapNo.Location = new System.Drawing.Point(194, 51);
            this.txt_TCHesapNo.Name = "txt_TCHesapNo";
            this.txt_TCHesapNo.Size = new System.Drawing.Size(210, 20);
            this.txt_TCHesapNo.TabIndex = 3;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(194, 100);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(210, 20);
            this.txt_Sifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 290);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TCHesapNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.btn_HesapAc);
            this.Name = "Giris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HesapAc;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TCHesapNo;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label2;
    }
}

