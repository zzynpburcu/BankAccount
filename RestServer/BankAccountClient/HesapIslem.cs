using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountControl
{
    public partial class HesapIslem : Form
    {
        public HesapIslem()
        {
            InitializeComponent();

        }

        private void lbl_HesapBakiye_Click(object sender, EventArgs e)
        {

        }
        #region IO Event Handlers
        private void HesapIslem_Load(object sender, EventArgs e)
        {
            
        }
        #endregion
        public void debugOutput(int hesapNo)
        {
            try
            {
                
            }
            catch
            {

            }
        }
        private void btn_Havale_Click(object sender, EventArgs e)
        {
            Havale hv = new Havale();
            hv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FaturaOdeme ftr = new FaturaOdeme();
            ftr.Show();
        }
    }
}
