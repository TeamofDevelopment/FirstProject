using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KOMANDA_A
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_Login = textBox1.Text.Trim();
            string user_Password = textBox2.Text.Trim();


            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-HUKDHSQ;Initial Catalog=DataBaseDesktopApp;Integrated Security=True");
            string query = "Select * FROM User1 WHERE Login='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
                reader.Close();
                Conn.Close();
                {
                    Form5 f5 = new Form5();

                    f5.Show();
                }
            }
        }
    }
}
