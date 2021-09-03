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
    public partial class CarRental : Form
    {
        DataAccess Da; 
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public CarRental()
        {
            InitializeComponent();
            Da = new DataAccess(); 
            this.txtCustomerName.Text = LoginForm.userName;
            this.txtCustomerId.Text = LoginForm.userId;
            
            Sql = "select * from vehiclereg;";
            this.PopulateGrideView(Sql);
        }
        private void PopulateGrideView(string sql)
        {
            //this.Da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvCarRent.AutoGenerateColumns = false;
            
            this.dgvCarRent.DataSource = ds.Tables[0];
        }
        private void CarRental_Load(object sender, EventArgs e)
        {

        }

        private void dgvCarRent_DoubleClick(object sender, EventArgs e)
        {
            this.txtCarId.ReadOnly = true;
            this.txtCarId.Text = this.dgvCarRent.CurrentRow.Cells["id"].Value.ToString();
            this.txtAvailable.Text = this.dgvCarRent.CurrentRow.Cells["available"].Value.ToString();
            this.txtRentalFee.Text = this.dgvCarRent.CurrentRow.Cells["rate"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            CustomerForm.cusf.Visible = true;
            //MessageBox.Show(CustomerForm.cusf.Visible.ToString());
            //this.Close();
            this.Visible = false;
            
        }

        private void txtSearchPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtToday =  System.DateTime.Now;
            System.DateTime dtYestMidnight = dtpDueDate.Value;
            System.TimeSpan diffResult = dtYestMidnight - dtToday;
            txtTotalDay.Text = Math.Ceiling( diffResult.TotalDays).ToString();
            txtTotalFee.Text = (Math.Ceiling(diffResult.TotalDays) * Int32.Parse( txtRentalFee.Text.ToString())).ToString();
            //MessageBox.Show("")


        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarRental_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Sql = @"insert into carrent(cus_id,car_id,date,duedate,totalday,totalfee)
                         values('"+this.txtCustomerId.Text+"','"+this.txtCarId.Text+"','"+this.dtpDate.Value.ToString("yyyy-MM-dd") + "','"+this.dtpDueDate.Value.ToString("yyyy-MM-dd")+"',"+this.txtTotalDay.Text+","+this.txtTotalFee.Text+");";
            this.Da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(this.Sql);
            MessageBox.Show(this.dgvCarRent.CurrentRow.Cells["id"].Value.ToString());
            
            this.Sql = @"UPDATE vehiclereg
                         SET available='No'
                         WHERE id='" + this.txtCarId.Text + "';";

            //this.Da = new DataAccess();
            ds = this.Da.ExecuteQuery(Sql);
            MessageBox.Show(this.dgvCarRent.CurrentRow.Cells["id"].Value.ToString());
            /*            MessageBox.Show("Car Registered ");
                        this.Close();*/
            CustomerForm.cusf.Visible = true;
            int count = this.Da.ExecuteUpdateQuery(Sql);
            if (count == 1)
            {
                MessageBox.Show("Registered Successfully");
                
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }
            
        }

        private void txtSearchPrice_TextChanged_1(object sender, EventArgs e)
        {
            if(this.txtSearchPrice.Text.ToString() != "")
            {
                this.Sql = "select * from vehiclereg where rate < " + Int32.Parse(this.txtSearchPrice.Text.ToString()) + "; ";
                PopulateGrideView(Sql);
            }
            

 
        }

        private void dgvCarRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCarId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
