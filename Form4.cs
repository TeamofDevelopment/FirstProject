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
            string ConStr = @"Data Source = АФАНАСИЙ-ПК\SQLEXPRESS; Initial Catalog = ApplicationDataBase; Integrated Security = True";
            SqlConnection Conn = new SqlConnection(ConStr);
            Conn.Open();
            string query = "SELECT * FROM User WHERE Login = '"+user_Login+"' AND Password = '"+user_Password+"'";
            SqlCommand cmd = new SqlCommand(query, Conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                /*while (reader.Read())
                {
                
                }*/
                MessageBox.Show("Авторизация прошла успешно");
                reader.Close(); 
            }
            Conn.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }
     }
 }

