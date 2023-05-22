using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to go back?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void button_newsignup_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESSX;Initial Catalog=LoginDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Login_new(username, password) VALUES ('"+txt_newuser.Text+"', '"+txt_newpass.Text+"')";
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            // close 
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
