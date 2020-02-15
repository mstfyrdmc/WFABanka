using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABanka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal bakiye = 0;
        private void btnYatır_Click(object sender, EventArgs e)
        {
            try
            {
                decimal yatirilanMiktar = Convert.ToDecimal(txtYatir.Text);
                if (yatirilanMiktar > 0)
                {
                    bakiye += yatirilanMiktar;
                    lblBakiye.Text = bakiye.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Sıfırdan Büyük Bir Miktar Giriniz.");
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Lütfen Sayısal Değer Giriniz...");
            }
           
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cekilenMiktar = Convert.ToDecimal(txtCek.Text);

                if (bakiye >= cekilenMiktar)
                {
                    bakiye -= cekilenMiktar;
                    lblBakiye.Text = bakiye.ToString("C2");
                }
                
                else
                {
                    MessageBox.Show("Yetersiz Bakiye");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Sayısal Bir Değer Girin...");
            }
            
        }
    }
}
