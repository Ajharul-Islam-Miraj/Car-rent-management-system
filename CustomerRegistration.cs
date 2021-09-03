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
    public partial class CustomerRegistration : Form
    {
        DataAccess Da; 
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public CustomerRegistration()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateVehicleID();
        }
        private void GenerateVehicleID()
        {
            this.Sql = "select * from login where id like 'c%' order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0]["id"].ToString();
            string[] str = id.Split('-');
            int number = Convert.ToInt32(str[1]);
            string newId = "c-" + (++number).ToString("d3");
            this.txtCustomerId.Text = newId;
        }

        private void btnSigup_Click(object sender, EventArgs e)
        {
            this.Sql = @"insert into login 
                                    values('" + this.txtCustomerId.Text + "','" + this.txtCustomerName.Text + "'," + this.txtPassword.Text + ",'" + this.txtType.Text + "','" + this.txtPhoneNumber.Text + "','" + this.txtAddress.Text + "');";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Welcome!You have Successfully Registered ");
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }
            //MessageBox.Show("Registration Failed");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
            LoginForm.lf.Visible = true;
        }
    }
}
