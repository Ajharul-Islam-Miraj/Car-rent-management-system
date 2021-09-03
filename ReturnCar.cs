using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentManagementSystemFinalProject
{
    public partial class ReturnCar : Form
    {

        DataAccess Da;
        //private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ReturnCar()
        {
            InitializeComponent();
            Da = new DataAccess();
            this.PopulateGrideView();
            txtCusId.Text = LoginForm.userId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dgvCarReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Sql = @"select * from carrent
                         where cus_id = '"+LoginForm.userId+"';";
            PopulateGrideView(this.Sql);
        }
        private void PopulateGrideView(string sql = "select * from carrent;")
        {

            
            DataSet ds = Da.ExecuteQuery(sql);
            this.dgvCarReturn.AutoGenerateColumns = false;
            this.dgvCarReturn.DataSource = ds.Tables[0];
        }

        private void txtCusId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCarReturn_DoubleClick(object sender, EventArgs e)
        {
            this.txtCarid.Text = this.dgvCarReturn.CurrentRow.Cells["car_id"].Value.ToString();
            DateTime dtToday = System.DateTime.Now;
            System.DateTime dtYestMidnight = Convert.ToDateTime
            (this.dgvCarReturn.CurrentRow.Cells["duedate"].Value.ToString());

            if (dtYestMidnight < dtToday)
            {
                
                System.TimeSpan diffResult = dtYestMidnight - dtToday;
                txtDayElapsed.Text = Math.Ceiling(diffResult.TotalDays).ToString();
                txtFine.Text = ((Math.Ceiling(diffResult.TotalDays) * 100)).ToString();
                txtTotalAmount.Text = (Int32.Parse(txtFine.Text.ToString()) + Int32.Parse(this.dgvCarReturn.CurrentRow.Cells["totalfee"].Value.ToString())).ToString();
            }
            else
            {
                txtDayElapsed.Text = "0";
                txtFine.Text = "0";
                txtTotalAmount.Text = this.dgvCarReturn.CurrentRow.Cells["totalfee"].Value.ToString();
            }
        }

        private void txtCarid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Sql = @"UPDATE vehiclereg
                         SET available='Yes'
                         WHERE id='"+ this.dgvCarReturn.CurrentRow.Cells["car_id"].Value.ToString() + "';";
            //this.Da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(Sql);
            MessageBox.Show(this.dgvCarReturn.CurrentRow.Cells["car_id"].Value.ToString());
            MessageBox.Show("Car Received ");
            this.Close();
            CustomerForm.cusf.Visible = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerForm.cusf.Visible = true;
            //MessageBox.Show(CustomerForm.cusf.Visible.ToString());
            //this.Close();
            this.Visible = false;
        }
    }
}
