using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DİKDÖRTGENİN_ALAINI_CEVRESI_İF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar, alan, çevre, sonuç;
            uzunkenar = Convert.ToInt16(textBox1.Text);
            kısakenar = Convert.ToInt16(textBox2.Text);

            if (radioButton1.Checked)
            {
               
                alan = kısakenar * uzunkenar;
                label1.Text = alan.ToString();
            }
            else if (radioButton2.Checked)
            {
               
                çevre = (kısakenar + uzunkenar) * 2;
                label1.Text = çevre.ToString();
            }


        }
    }
}
