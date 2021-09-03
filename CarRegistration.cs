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
    public partial class CarRegistration : Form
    {
        DataAccess Da; 
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public CarRegistration()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGrideView();
            this.GenerateVehicleID();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGrideView();
           
        }
        private void PopulateGrideView(string sql = "select * from vehiclereg;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvCarReg.AutoGenerateColumns = false;
            this.dgvCarReg.DataSource = ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from vehiclereg where producer like '"+this.txtAutoSearch.Text+"%';";
            this.PopulateGrideView(this.Sql);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Sql = @"insert into vehiclereg
                        values('"+this.txtCarReg.Text+"','"+this.txtProducer.Text+"','"+this.txtModel.Text+"','"+this.txtRatePerDay.Text+"','"+this.cmbAvailable.Text+"');";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if(count == 1)
            {
                MessageBox.Show("Data Added Successfully");
                this.GenerateVehicleID();
            }
            else
            {
                MessageBox.Show("Data Insertion Failed");
            }
            this.PopulateGrideView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvCarReg.CurrentRow.Cells[0].Value.ToString();
            string model = this.dgvCarReg.CurrentRow.Cells["model"].Value.ToString();
            this.Sql = @"delete from vehiclereg
                        where id = '"+id+"';";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show(model +"  Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.PopulateGrideView();

        }

        private void dgvCarReg_DoubleClick(object sender, EventArgs e)
        {
            this.txtCarReg.ReadOnly = true;
            this.txtCarReg.Text = this.dgvCarReg.CurrentRow.Cells["id"].Value.ToString();
            this.txtModel.Text = this.dgvCarReg.CurrentRow.Cells["model"].Value.ToString();
            this.txtProducer.Text = this.dgvCarReg.CurrentRow.Cells["producer"].Value.ToString();
            this.txtRatePerDay.Text = this.dgvCarReg.CurrentRow.Cells["rate"].Value.ToString();
            this.cmbAvailable.Text = this.dgvCarReg.CurrentRow.Cells["available"].Value.ToString();


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Sql = @"update vehiclereg
                        set producer = '" + this.txtProducer.Text + @"',
                        model = '" + this.txtModel.Text + @"',
                        available = '" + this.cmbAvailable.Text + @"',
                        rate = " + this.txtRatePerDay.Text + @"
                        where id = '" + this.txtCarReg.Text + "';";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show(" Update Successfully");
            }
            else
            {
                MessageBox.Show("Data Update Failed");
            }
            this.PopulateGrideView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.GenerateVehicleID();
            this.txtCarReg.Clear();
            this.txtModel.Clear();
            this.txtProducer.Clear();
            this.txtRatePerDay.Clear();
            this.cmbAvailable.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            LoginForm.af.Visible = true;
            
        }
        private void GenerateVehicleID()
        {
            this.Sql = "select * from vehiclereg order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0]["id"].ToString();
            string[] str = id.Split('v');
            int number = Convert.ToInt32(str[1]);
            string newId = "v" + (++number).ToString("d3");
            this.txtCarReg.Text = newId;
        }

        private void dgvCarReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
