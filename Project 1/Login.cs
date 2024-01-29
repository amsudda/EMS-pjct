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

namespace Project_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_DB;Integrated Security=True");




        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
         conn.Open();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query_select = "SELECT * FROM login WHERE username ='" + username + "' AND Password = '"+ password +"' "; 
            SqlCommand cmdn = new SqlCommand(query_select, conn);
            SqlDataReader row = cmdn.ExecuteReader();

            if (row.HasRows)
            {
               this.Hide();
               Manage_Employee obj = new Manage_Employee();
                obj.Show();
            }
            else 
            {
               MessageBox.Show("Invalid Login, Please Check username & Password and try again !","Invalid Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) 
            {
                Application.Exit();         
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
