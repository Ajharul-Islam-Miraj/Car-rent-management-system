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

namespace CarRentManagementSystemFinalProject
{
    public partial class LoginForm : Form
    {
        public static AdminForm af;
        public static LoginForm lf;
        public static string userId;
        public static  string userName;

        public LoginForm()
        {
            InitializeComponent();
            lf = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from login;";

            SqlConnection sqlcon = new SqlConnection(@"Data Source=miraj\sqlexpress;Initial Catalog=CarRentManagementSystem;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int count = 0;
            bool d = false;
            while (count < ds.Tables[0].Rows.Count)
            {
                if (this.txtUserID.Text == ds.Tables[0].Rows[count][0].ToString() && this.txtPassword.Text == ds.Tables[0].Rows[count][2].ToString())
                {
                    MessageBox.Show("Hello  " + ds.Tables[0].Rows[count][1]+ " Your Login approved");
                    if(this.txtUserID.Text[0].ToString() == "a")
                    {
                        af = new AdminForm(this);
                        af.Visible = true;
                        this.Visible = false;
                        //this.Dispose();
                        //Application.Exit();
                    }
                    else if(this.txtUserID.Text[0].ToString() == "c")
                    {
                        CustomerForm cf = new CustomerForm(this);
                        cf.Visible = true;
                        this.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Login Invalid");
                    }
                    //Application.Exit();
                    userId = this.txtUserID.Text;
                    userName = ds.Tables[0].Rows[count][1].ToString();
                    d = true;
                    break;
                }

                count++;
            }
            if (!d)
                MessageBox.Show("Login Invalid");
            sqlcon.Close();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPassword.Clear();
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
                txtPassword.PasswordChar = '•';
            else
                txtPassword.PasswordChar = '\0';
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CustomerRegistration cr = new CustomerRegistration();
            cr.Visible = true;
            this.Visible = false;
        }
    }


}
