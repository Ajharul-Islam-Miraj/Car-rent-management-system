namespace CarRentManagementSystemFinalProject
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnLogout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnVehicleReg = new System.Windows.Forms.Button();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnCurrentRentCustomer = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnLogout.Location = new System.Drawing.Point(444, 452);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(107, 76);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVehicleReg
            // 
            this.btnVehicleReg.BackColor = System.Drawing.Color.LightGreen;
            this.btnVehicleReg.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleReg.Location = new System.Drawing.Point(233, 80);
            this.btnVehicleReg.Name = "btnVehicleReg";
            this.btnVehicleReg.Size = new System.Drawing.Size(511, 126);
            this.btnVehicleReg.TabIndex = 0;
            this.btnVehicleReg.Text = "Vehicle Registration";
            this.btnVehicleReg.UseVisualStyleBackColor = false;
            this.btnVehicleReg.Click += new System.EventHandler(this.btnVehicleReg_Click);
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCustomerInfo.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInfo.Location = new System.Drawing.Point(143, 277);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(244, 76);
            this.btnCustomerInfo.TabIndex = 1;
            this.btnCustomerInfo.Text = "Customer Information";
            this.btnCustomerInfo.UseVisualStyleBackColor = false;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(50, 34);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(92, 30);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Timer";
            // 
            // btnCurrentRentCustomer
            // 
            this.btnCurrentRentCustomer.BackColor = System.Drawing.Color.IndianRed;
            this.btnCurrentRentCustomer.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentRentCustomer.Location = new System.Drawing.Point(617, 277);
            this.btnCurrentRentCustomer.Name = "btnCurrentRentCustomer";
            this.btnCurrentRentCustomer.Size = new System.Drawing.Size(235, 80);
            this.btnCurrentRentCustomer.TabIndex = 5;
            this.btnCurrentRentCustomer.Text = "Current Rented Customer";
            this.btnCurrentRentCustomer.UseVisualStyleBackColor = false;
            this.btnCurrentRentCustomer.Click += new System.EventHandler(this.btnCurrentRentCustomer_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 581);
            this.Controls.Add(this.btnCurrentRentCustomer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(btnLogout);
            this.Controls.Add(this.btnCustomerInfo);
            this.Controls.Add(this.btnVehicleReg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVehicleReg;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnCurrentRentCustomer;
    }
}