namespace CarRentManagementSystemFinalProject
{
    partial class CurrentRentedCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentRentedCustomer));
            this.dgvCurrentRentedCus = new System.Windows.Forms.DataGridView();
            this.cus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentRentedCus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurrentRentedCus
            // 
            this.dgvCurrentRentedCus.AllowUserToAddRows = false;
            this.dgvCurrentRentedCus.AllowUserToDeleteRows = false;
            this.dgvCurrentRentedCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentRentedCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cus_id,
            this.car_id,
            this.totalday,
            this.totalfee,
            this.producer,
            this.model,
            this.rate,
            this.phoneno,
            this.address});
            this.dgvCurrentRentedCus.Location = new System.Drawing.Point(52, 211);
            this.dgvCurrentRentedCus.Name = "dgvCurrentRentedCus";
            this.dgvCurrentRentedCus.ReadOnly = true;
            this.dgvCurrentRentedCus.RowHeadersWidth = 51;
            this.dgvCurrentRentedCus.RowTemplate.Height = 24;
            this.dgvCurrentRentedCus.Size = new System.Drawing.Size(1345, 494);
            this.dgvCurrentRentedCus.TabIndex = 0;
            this.dgvCurrentRentedCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentRentedCus_CellContentClick);
            // 
            // cus_id
            // 
            this.cus_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cus_id.DataPropertyName = "cus_id";
            this.cus_id.HeaderText = "CustomerID";
            this.cus_id.MinimumWidth = 6;
            this.cus_id.Name = "cus_id";
            this.cus_id.ReadOnly = true;
            // 
            // car_id
            // 
            this.car_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.car_id.DataPropertyName = "car_id";
            this.car_id.HeaderText = "Car ID";
            this.car_id.MinimumWidth = 6;
            this.car_id.Name = "car_id";
            this.car_id.ReadOnly = true;
            // 
            // totalday
            // 
            this.totalday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalday.DataPropertyName = "totalday";
            this.totalday.HeaderText = "Total Day";
            this.totalday.MinimumWidth = 6;
            this.totalday.Name = "totalday";
            this.totalday.ReadOnly = true;
            // 
            // totalfee
            // 
            this.totalfee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalfee.DataPropertyName = "totalfee";
            this.totalfee.HeaderText = "Total Fee";
            this.totalfee.MinimumWidth = 6;
            this.totalfee.Name = "totalfee";
            this.totalfee.ReadOnly = true;
            // 
            // producer
            // 
            this.producer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producer.DataPropertyName = "producer";
            this.producer.HeaderText = "Car Company";
            this.producer.MinimumWidth = 6;
            this.producer.Name = "producer";
            this.producer.ReadOnly = true;
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Car Model";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rate.DataPropertyName = "rate";
            this.rate.HeaderText = "Rate Per Day";
            this.rate.MinimumWidth = 6;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // phoneno
            // 
            this.phoneno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneno.DataPropertyName = "phoneno";
            this.phoneno.HeaderText = "Phone Number";
            this.phoneno.MinimumWidth = 6;
            this.phoneno.Name = "phoneno";
            this.phoneno.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(67, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 72);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CurrentRentedCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 754);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvCurrentRentedCus);
            this.Name = "CurrentRentedCustomer";
            this.Text = "CurrentRentedCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentRentedCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrentRentedCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalday;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.Button btnBack;
    }
}