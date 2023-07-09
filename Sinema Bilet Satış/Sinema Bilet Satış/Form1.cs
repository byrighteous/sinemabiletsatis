using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans1ucret = 0;
        int seans2 = 0;
        int seans2ucret= 0;
        int seans3 = 0;
        int seans3ucret = 0;
        int misir=0;
        int misirfiyat = 0;
        int kola = 0;
        int kolafiyat = 0;
        int su= 0;
        int sufiyat= 0;
        int toplamizleyici, toplamucret;
        int toplamgida, toplamucretgida;
        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1ucret = seans1ucret + 50;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            

            if (seans1 == 30)
            {
                button1.Enabled = false;
            }
            if (seans1 >= 0)
                button2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text=0.ToString();
            textBox2.Text=0.ToString();
            textBox3.Text=0.ToString();
            textBox4.Text=0.ToString();
            textBox5.Text=0.ToString();
            textBox6.Text=0.ToString();
            textBox7.Text = 0.ToString();
            textBox8.Text = 0.ToString();
            textBox9.Text = 0.ToString();
            textBox10.Text = 0.ToString();
            textBox11.Text = 0.ToString();
            textBox12.Text = 0.ToString();
            textBox1.Enabled=false;
            textBox2.Enabled=false;
            textBox3.Enabled=false;
            textBox4.Enabled=false;
            textBox5.Enabled=false;
            textBox6.Enabled=false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ucret=seans1ucret - 50;
            textBox1.Text =seans1.ToString();
            textBox2.Text = seans1ucret.ToString();

            if(seans1==0)
            {
                button2.Enabled = false;
            }
            if (seans1 <= 10)
            {
                button1.Enabled=true;
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2ucret = seans2ucret + 50;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucret.ToString();


            if (seans2 == 30)
            {
                button4.Enabled = false;
            }
            if (seans1 >= 0)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ucret = seans2ucret - 50;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucret.ToString();

            if (seans2 == 0)
            {
                button3.Enabled = false;
            }
            if (seans2 <= 10)
            {
                button4.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3ucret = seans3ucret + 50;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucret.ToString();


            if (seans3 == 30)
            {
                button6.Enabled = false;
            }
            if (seans3 >= 0)
            {
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ucret = seans3ucret - 50;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucret.ToString();

            if (seans3 == 0)
            {
                button5.Enabled = false;
            }
            if (seans3 <= 10)
            {
                button6.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            misir++;
            misirfiyat = misirfiyat + 20;
            textBox7.Text = misir.ToString();
            textBox8.Text = misirfiyat.ToString();
            if (misir==10)
            {
                button7.Enabled= false;
            }
            if(misir>=0)
            {
                button10.Enabled= true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            misir--;
            misirfiyat = misirfiyat - 20;
            textBox7.Text = misir.ToString();
            textBox8.Text = misirfiyat.ToString();
            if (misir==0)
            {
                button10.Enabled= false;
            }
            if (misir <= 5)
            {
                button7.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kola++;
            kolafiyat = kolafiyat + 10;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolafiyat.ToString();
            if (kola == 10)
            {
                button8.Enabled = false;
            }
            if (kola >= 0)
            {
                button11.Enabled = true;
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            kola--;
            kolafiyat = kolafiyat - 10;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolafiyat.ToString();
            if (kola == 0)
            {
                button11.Enabled = false;
            }
            if (misir <= 5)
            {
                button8.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            su++;
            sufiyat = sufiyat + 5;
            textBox11.Text = su.ToString();
            textBox12.Text = sufiyat.ToString();
            if (su == 10)
            {
                button9.Enabled = false;
            }
            if (su >= 0)
            {
                button12.Enabled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            su--;
            sufiyat = sufiyat - 5;
            textBox11.Text = su.ToString();
            textBox12.Text = sufiyat.ToString();
            if (su == 0)
            {
                button12.Enabled = false;
            }
            if (su <= 2)
            {
                button9.Enabled = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            toplamizleyici = seans1+seans2+seans3;
            label13.Text = toplamizleyici.ToString();
            toplamucret = seans1ucret + seans2ucret + seans3ucret;
            label14.Text=toplamucret.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            toplamgida = misir + kola + su;
            toplamucretgida=misirfiyat+kolafiyat+sufiyat;
            label15.Text = toplamgida.ToString();
            label16.Text = toplamucretgida.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int genel = toplamucret + toplamucretgida;
            label20.Text = genel.ToString();

        }
    }
}
