using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace karsilastirmaV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(txt1.Text);
            sayi2 = Convert.ToByte(txt2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1.sayı 2.sayıdan büyüktür");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayılar birbirine eşittir");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.sayı 1.sayıdan büyüktür");
            }
        }
    }
}
