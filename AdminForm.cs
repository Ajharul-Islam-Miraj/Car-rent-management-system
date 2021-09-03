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
    public partial class AdminForm : Form
    {
        private  LoginForm Frm { get; set; }
        

        public AdminForm()
        {
            InitializeComponent();
            timer.Start();
        }
        public AdminForm(LoginForm frm):this()
        {
            this.Frm = frm;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Frm.Visible = true;
            //Application.Exit();
        }

        private void btnVehicleReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CarRegistration cr = new CarRegistration();
            cr.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTimer.Text = dateTime.ToString();
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            dgvCustomerInformation ci = new dgvCustomerInformation();
            ci.Visible = true;
            this.Visible = false;
        }

        private void btnCurrentRentCustomer_Click(object sender, EventArgs e)
        {
            CurrentRentedCustomer crc = new CurrentRentedCustomer();
            crc.Visible = true;
            this.Visible = false;
        }
    }
}
