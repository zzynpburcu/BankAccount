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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            //eğer kullanıcı adı ve şifre doğruysa hesap işlem sayfasına yönlendirir.
            HesapIslem hi = new HesapIslem();
            hi.Show();
            //değilse hata ver
           // MessageBox.Show("TC Kimlik No / Hesap Numarası veya Şifre hatalı!");
        }

        private void btn_HesapAc_Click(object sender, EventArgs e)
        {
            HesapBasvuru hb = new HesapBasvuru();
            hb.Show();
        }
    }
}
