namespace BankAccountControl
{
    partial class HesapIslem
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
            this.labl_hesapAdı = new System.Windows.Forms.Label();
            this.lbl_HesapBakiye = new System.Windows.Forms.Label();
            this.btn_Havale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_HesapNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Iban = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap Bakiye:";
            // 
            // labl_hesapAdı
            // 
            this.labl_hesapAdı.AutoSize = true;
            this.labl_hesapAdı.Location = new System.Drawing.Point(160, 43);
            this.labl_hesapAdı.Name = "labl_hesapAdı";
            this.labl_hesapAdı.Size = new System.Drawing.Size(0, 13);
            this.labl_hesapAdı.TabIndex = 2;
            // 
            // lbl_HesapBakiye
            // 
            this.lbl_HesapBakiye.AutoSize = true;
            this.lbl_HesapBakiye.Location = new System.Drawing.Point(373, 43);
            this.lbl_HesapBakiye.Name = "lbl_HesapBakiye";
            this.lbl_HesapBakiye.Size = new System.Drawing.Size(0, 13);
            this.lbl_HesapBakiye.TabIndex = 3;
            this.lbl_HesapBakiye.Click += new System.EventHandler(this.lbl_HesapBakiye_Click);
            // 
            // btn_Havale
            // 
            this.btn_Havale.Location = new System.Drawing.Point(44, 327);
            this.btn_Havale.Name = "btn_Havale";
            this.btn_Havale.Size = new System.Drawing.Size(161, 45);
            this.btn_Havale.TabIndex = 5;
            this.btn_Havale.Text = "EFT / HAVALE";
            this.btn_Havale.UseVisualStyleBackColor = true;
            this.btn_Havale.Click += new System.EventHandler(this.btn_Havale_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "FATURA ÖDEME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_HesapNo
            // 
            this.lbl_HesapNo.AutoSize = true;
            this.lbl_HesapNo.Location = new System.Drawing.Point(157, 88);
            this.lbl_HesapNo.Name = "lbl_HesapNo";
            this.lbl_HesapNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_HesapNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hesap No:";
            // 
            // lbl_Iban
            // 
            this.lbl_Iban.AutoSize = true;
            this.lbl_Iban.Location = new System.Drawing.Point(373, 88);
            this.lbl_Iban.Name = "lbl_Iban";
            this.lbl_Iban.Size = new System.Drawing.Size(0, 13);
            this.lbl_Iban.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "IBAN No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 156);
            this.dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hesap Hareketleri:";
            // 
            // HesapIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Iban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_HesapNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Havale);
            this.Controls.Add(this.lbl_HesapBakiye);
            this.Controls.Add(this.labl_hesapAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "HesapIslem";
            this.Text = "HesapIslem";
            this.Load += new System.EventHandler(this.HesapIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labl_hesapAdı;
        private System.Windows.Forms.Label lbl_HesapBakiye;
        private System.Windows.Forms.Button btn_Havale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_HesapNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Iban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}