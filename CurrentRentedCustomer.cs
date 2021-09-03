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
    public partial class CurrentRentedCustomer : Form
    {
        DataAccess Da; 
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public CurrentRentedCustomer()
        {
            InitializeComponent();
            Da = new DataAccess();
            Sql = @"select * from carrent as c,
                    vehiclereg as v, login as l where c.car_id = v.id and c.cus_id = l.id and v.available = 'No'; ";
            this.PopulateGrideView(Sql);
        }
        private void PopulateGrideView(string sql)
        {
            
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvCurrentRentedCus.AutoGenerateColumns = false;

            this.dgvCurrentRentedCus.DataSource = ds.Tables[0];
        }

        private void dgvCurrentRentedCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.af.Visible = true;
        }
    }
}
