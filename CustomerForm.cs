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
    public partial class CustomerForm : Form
    {
        private LoginForm Frm { get; set; }
        public static CustomerForm cusf;
        public CustomerForm()
        {
            InitializeComponent();
            cusf = this;

        }
        public CustomerForm(LoginForm frm) : this()
        {
            this.Frm = frm;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Frm.Visible = true;
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            CarRental cr = new CarRental();
            cr.Visible = true;
            cusf.Visible = false;

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCarReturn_Click(object sender, EventArgs e)
        {
            ReturnCar rc = new ReturnCar();
            rc.Visible = true;
            cusf.Visible = false;
        }
    }
}
