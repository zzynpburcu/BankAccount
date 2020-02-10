namespace BankAccountControl
{
    partial class FaturaOdeme
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
            this.txt_AboneNo = new System.Windows.Forms.TextBox();
            this.txt_FaturaMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone No:";
            // 
            // txt_AboneNo
            // 
            this.txt_AboneNo.Location = new System.Drawing.Point(141, 52);
            this.txt_AboneNo.Name = "txt_AboneNo";
            this.txt_AboneNo.Size = new System.Drawing.Size(146, 20);
            this.txt_AboneNo.TabIndex = 1;
            // 
            // txt_FaturaMiktar
            // 
            this.txt_FaturaMiktar.Location = new System.Drawing.Point(141, 103);
            this.txt_FaturaMiktar.Name = "txt_FaturaMiktar";
            this.txt_FaturaMiktar.Size = new System.Drawing.Size(146, 20);
            this.txt_FaturaMiktar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fatura Miktarı:";
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.Location = new System.Drawing.Point(141, 176);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(133, 34);
            this.btn_Odeme.TabIndex = 4;
            this.btn_Odeme.Text = "Faturayı Öde";
            this.btn_Odeme.UseVisualStyleBackColor = true;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_Odeme_Click);
            // 
            // FaturaOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 315);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.txt_FaturaMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AboneNo);
            this.Controls.Add(this.label1);
            this.Name = "FaturaOdeme";
            this.Text = "FaturaOdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AboneNo;
        private System.Windows.Forms.TextBox txt_FaturaMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Odeme;
    }
}