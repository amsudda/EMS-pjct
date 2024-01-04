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
using System.Dynamic;

namespace Project_1
{
    public partial class Manage_Employee : Form
    {
        public Manage_Employee()
        {
            InitializeComponent();
        }
         
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=""EMS for pjct"";Integrated Security=True");
        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query_select = " SELECT * FROM EMPmanagetbl";
            SqlCommand cmnd = new SqlCommand(query_select, conn);
            SqlDataReader row = cmnd.ExecuteReader();
            EmpNOcb.Items.Add("New Register");
            while (row.Read()) 
            {
                EmpNOcb.Items.Add(row[0].ToString());
            }
            conn.Close();
        }

        private void regiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = fname.Text;
                string lastName = lname.Text;
                DateTime dob = DOB.Value; // Use the Value property of DateTimePicker
                string gender = SEXm.Checked ? "Male" : "Female";
                string address = Addi.Text;
                string email = Email.Text;

                // Validate and parse phone numbers
                if (int.TryParse(MPno.Text, out int mobilePhone) && int.TryParse(HPno.Text, out int homePhone))
                {
                    string departmentName = Dname.Text;
                    string designation = Desitxt.Text;
                    string employeeType = emptype.Text;

                    string  query_insert = "INSERT INTO EMPmanagetbl (firstname, lastname, DOB, gender, address, email, mobilephone, homephone, departmentName, designation, employeeType) " +
                                           "VALUES (@FirstName, @LastName, @DOB, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @DepartmentName, @Designation, @EmployeeType)";
                    ;

                    conn.Open();
                    using (SqlCommand cmnd = new SqlCommand(query_insert, conn))
                    {
                        cmnd.Parameters.AddWithValue("@FirstName", firstName);
                        cmnd.Parameters.AddWithValue("@LastName", lastName);
                        cmnd.Parameters.AddWithValue("@DOB", dob);
                        cmnd.Parameters.AddWithValue("@Gender", gender);
                        cmnd.Parameters.AddWithValue("@Address", address);
                        cmnd.Parameters.AddWithValue("@Email", email);
                        cmnd.Parameters.AddWithValue("@Mobilephone", mobilePhone);
                        cmnd.Parameters.AddWithValue("@Homephone", homePhone);
                        cmnd.Parameters.AddWithValue("@DepartmentName", departmentName);
                        cmnd.Parameters.AddWithValue("@Designation", designation);
                        cmnd.Parameters.AddWithValue("@EmployeeType", employeeType);

                        cmnd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Added Successfully!", "Registered Employee!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid phone number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Insert Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void Upbtn_Click(object sender, EventArgs e)
        {
           string no = EmpNOcb.Text;

            if (no != "New Register") 
            {
                string firstName = fname.Text;
                string lastName = lname.Text;
                DateTime dob = DOB.Value;
                string gender;
                if (SEXm.Checked)
                {
                    gender = "Male";

                }
                else
                {
                    gender = "Female";
                }
                string address = Addi.Text;
                string email = Email.Text;
                int mobilePhone = int.Parse(MPno.Text);
                int homePhone = int.Parse(MPno.Text);
                string departmentName = Dname.Text;
                string designation = Desitxt.Text;
                string employeeType = emptype.Text;
                string query_insert = "UPDATE EMPmanagetbl SET firstname = '" + firstName + "',lastname = '" + lastName + "', DOB = '" + dob + "', gender = '" + gender + "',address = '" + address + "',email = '" + email + "',mobilephone = '" + mobilePhone + "', homephone = '" + homePhone + "',departmentName = '" + departmentName + "', designation = '" + designation + "', employeetype = '" + employeeType + "' WHERE   empid ="+ no;

                conn.Open();
                SqlCommand cmdn = new SqlCommand(query_insert, conn);
                cmdn.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully!", "Updated Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearmBtn_Click(object sender, EventArgs e)
        {
            EmpNOcb.Text = "";
            fname.Text = "";
            lname.Text = "";
            DOB.Text = "";
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.Text = "";
           

            SEXm.Checked = false;
            SEXf.Checked = false;

            Addi.Text = "";
            Email.Text = "";
            MPno.Text = "";
            HPno.Text = "";
            Dname.Text = "";
            Desitxt.Text = "";
            emptype.Text = "";
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure , Do you really want to delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
              string no = EmpNOcb.Text;

                string query_insert = "DELETE FROM EMPmanagetbl WHERE empid = " + no + "";
                conn.Open();
                SqlCommand cmdn = new SqlCommand(query_insert, conn);
                cmdn.ExecuteNonQuery();
                MessageBox.Show("record Deleted Successfully!", "Deleted Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void Logoutlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void Exitlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are You Sure,Do you really want to exit..? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void EmpNOcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = EmpNOcb.Text;

            if (no != "New Register")
            {
                LoadEmployeeDetails(no);
                regiBtn.Enabled = false;
                Upbtn.Enabled = true;
                Deletebtn.Enabled = true;
            }
            else
            {
                ResetForm();
            }
        }

        private void LoadEmployeeDetails(string empId)
        {
            conn.Open();
            string query_select = "SELECT * FROM EMPmanagetbl WHERE empid = @empId";
            SqlCommand cmdn = new SqlCommand(query_select, conn);
            cmdn.Parameters.AddWithValue("@empId", empId);

            SqlDataReader row = cmdn.ExecuteReader();

            while (row.Read())
            {
                fname.Text = row["firstname"].ToString();
                lname.Text = row["lastname"].ToString();
                DOB.Value = DateTime.Parse(row["DOB"].ToString());

                if (row["gender"].ToString() == "Male")
                {
                    SEXm.Checked = true;
                    SEXf.Checked = false;
                }
                else
                {
                    SEXm.Checked = false;
                    SEXf.Checked = true;
                }

                Addi.Text = row["address"].ToString();
                Email.Text = row["email"].ToString();
                MPno.Text = row["mobilephone"].ToString();
                HPno.Text = row["homephone"].ToString();
                Dname.Text = row["departmentName"].ToString();
                Desitxt.Text = row["designation"].ToString();
                emptype.Text = row["employeetype"].ToString();
            }

            conn.Close();
        }

        private void ResetForm()
        {
            EmpNOcb.Text = "";
            fname.Text = "";
            lname.Text = "";
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "yyyy/MM/dd";
            DOB.Value = DateTime.Today;

            SEXm.Checked = true;
            SEXf.Checked = false;

            Addi.Text = "";
            Email.Text = "";
            MPno.Text = "";
            HPno.Text = "";
            Dname.Text = "";
            Desitxt.Text = "";
            emptype.Text = "";

            regiBtn.Enabled = true;
            Upbtn.Enabled = false;
            Deletebtn.Enabled = false;
        }

    }
}

