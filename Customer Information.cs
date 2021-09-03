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
    public partial class dgvCustomerInformation : Form
    {
        DataAccess Da; 
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public dgvCustomerInformation()
        {
            InitializeComponent();
            Da = new DataAccess();
            Sql = "select * from login where type = 'customer';";
            this.PopulateGrideView(Sql);
        }
        private void PopulateGrideView(string sql)
        {
            //this.Da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvCusInfo .AutoGenerateColumns = false;

            this.dgvCusInfo.DataSource = ds.Tables[0];
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from login where name like '" + this.txtSearchName.Text + "%' and id like  'c-%';";
            this.PopulateGrideView(this.Sql);
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from login where id like 'c-" + this.txtSearchID.Text.ToString() + "%';";
            this.PopulateGrideView(this.Sql);
        }

        private void dtpDateCus_ValueChanged(object sender, EventArgs e)
        {
            string dt;
            dt = dtpDateCus.Value.ToString("yyyy-MM-dd");
            this.Sql = @"select * from carrent as c,
                        vehiclereg as v, login as l where c.car_id = v.id and c.cus_id = l.id and c.date = '"+dt+"'; ";
            this.PopulateGrideView(this.Sql);
        }

        private void dgvCusInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.af.Visible = true;
        }
    }
}
