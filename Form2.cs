using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOMANDA_A
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float sum = Convert.ToInt32(textBox1.Text);
                float srokvk = Convert.ToInt32(textBox2.Text);
                float monrefill = Convert.ToInt32(textBox3.Text);
                //стабильный
                float prsum1 = (sum / 100 * 8) / 12 * srokvk;
                //оптимальный
                float prsum2 = ((sum + monrefill) / 100 * 5) / 12 * srokvk;
                //стандарт
                float prsum3 = ((sum + monrefill) / 100 * 6) / 12 * srokvk;
                label11.Text = prsum1.ToString();
                label12.Text = prsum2.ToString();
                label13.Text = prsum3.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные, повторите ввод");
            }
            //float monrefill = Convert.ToInt32(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new KOMANDA_A.Form3();
            f3.Show();
            f3.label6.Text = label11.Text;
            f3.label10.Text = label12.Text;
            f3.label14.Text = label13.Text;
            float sum = Convert.ToInt32(textBox1.Text);
            float srokvk = Convert.ToInt32(textBox2.Text);
            float monrefill = Convert.ToInt32(textBox3.Text);
            float prsum1 = (sum / 100 * 8) / 12 * srokvk;
            float prsum2 = ((sum + monrefill) / 100 * 5) / 12 * srokvk;
            float prsum3 = ((sum + monrefill) / 100 * 6) / 12 * srokvk;
            float yearsum1 = sum + prsum1;
            float yearsum2 = sum + prsum2;
            float yearsum3 = sum + prsum3;
            f3.label7.Text = yearsum1.ToString();
            f3.label11.Text = yearsum2.ToString();
            f3.label15.Text = yearsum3.ToString();
            Hide();
        }
    }
}
