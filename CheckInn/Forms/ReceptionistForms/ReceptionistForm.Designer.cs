namespace CheckInn.Forms
{
    partial class ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistForm));
            this.lblStaffName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.flwRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.groupBoxOverview = new System.Windows.Forms.GroupBox();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.groupBoxCheckIns = new System.Windows.Forms.GroupBox();
            this.gridCheckIns = new System.Windows.Forms.DataGridView();
            this.groupBoxCheckOuts = new System.Windows.Forms.GroupBox();
            this.gridCheckOuts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOverview.SuspendLayout();
            this.groupBoxCheckIns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckIns)).BeginInit();
            this.groupBoxCheckOuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckOuts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Navy;
            this.lblStaffName.Location = new System.Drawing.Point(21, 149);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(199, 45);
            this.lblStaffName.TabIndex = 22;
            this.lblStaffName.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 45);
            this.label3.TabIndex = 20;
            this.label3.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(203, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 86);
            this.label1.TabIndex = 19;
            this.label1.Text = "CheckInn";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Navy;
            this.lblRole.Location = new System.Drawing.Point(26, 204);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(104, 25);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "RoleName";
            // 
            // flwRooms
            // 
            this.flwRooms.AutoScroll = true;
            this.flwRooms.Location = new System.Drawing.Point(681, 32);
            this.flwRooms.Name = "flwRooms";
            this.flwRooms.Size = new System.Drawing.Size(1180, 835);
            this.flwRooms.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(21, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 45);
            this.label2.TabIndex = 26;
            this.label2.Text = "Create a New Customer";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(29, 345);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(101, 23);
            this.btnCreateCustomer.TabIndex = 0;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(31, 462);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(101, 23);
            this.btnCreateBooking.TabIndex = 27;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(23, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 45);
            this.label4.TabIndex = 28;
            this.label4.Text = "Create a New Booking";
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.Location = new System.Drawing.Point(153, 462);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(115, 23);
            this.btnManageBookings.TabIndex = 29;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(153, 345);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(115, 23);
            this.btnManageCustomer.TabIndex = 30;
            this.btnManageCustomer.Text = "Manage Customers";
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // groupBoxOverview
            // 
            this.groupBoxOverview.Controls.Add(this.lblAvailableRooms);
            this.groupBoxOverview.Controls.Add(this.lblOccupiedRooms);
            this.groupBoxOverview.Controls.Add(this.lblTotalRooms);
            this.groupBoxOverview.Location = new System.Drawing.Point(29, 778);
            this.groupBoxOverview.Name = "groupBoxOverview";
            this.groupBoxOverview.Size = new System.Drawing.Size(372, 89);
            this.groupBoxOverview.TabIndex = 31;
            this.groupBoxOverview.TabStop = false;
            this.groupBoxOverview.Text = "Hotel Overview";
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Location = new System.Drawing.Point(6, 16);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(70, 13);
            this.lblTotalRooms.TabIndex = 0;
            this.lblTotalRooms.Text = "Total Rooms:";
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.AutoSize = true;
            this.lblOccupiedRooms.Location = new System.Drawing.Point(6, 39);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(92, 13);
            this.lblOccupiedRooms.TabIndex = 1;
            this.lblOccupiedRooms.Text = "Occupied Rooms:";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Location = new System.Drawing.Point(6, 63);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(89, 13);
            this.lblAvailableRooms.TabIndex = 2;
            this.lblAvailableRooms.Text = "Available Rooms:";
            // 
            // groupBoxCheckIns
            // 
            this.groupBoxCheckIns.Controls.Add(this.gridCheckIns);
            this.groupBoxCheckIns.Location = new System.Drawing.Point(31, 500);
            this.groupBoxCheckIns.Name = "groupBoxCheckIns";
            this.groupBoxCheckIns.Size = new System.Drawing.Size(576, 126);
            this.groupBoxCheckIns.TabIndex = 3;
            this.groupBoxCheckIns.TabStop = false;
            this.groupBoxCheckIns.Text = "Today\'s Check - Ins";
            // 
            // gridCheckIns
            // 
            this.gridCheckIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckIns.Location = new System.Drawing.Point(9, 17);
            this.gridCheckIns.Name = "gridCheckIns";
            this.gridCheckIns.Size = new System.Drawing.Size(561, 103);
            this.gridCheckIns.TabIndex = 0;
            // 
            // groupBoxCheckOuts
            // 
            this.groupBoxCheckOuts.Controls.Add(this.gridCheckOuts);
            this.groupBoxCheckOuts.Location = new System.Drawing.Point(31, 632);
            this.groupBoxCheckOuts.Name = "groupBoxCheckOuts";
            this.groupBoxCheckOuts.Size = new System.Drawing.Size(576, 126);
            this.groupBoxCheckOuts.TabIndex = 4;
            this.groupBoxCheckOuts.TabStop = false;
            this.groupBoxCheckOuts.Text = "Today\'s Check - Outs";
            // 
            // gridCheckOuts
            // 
            this.gridCheckOuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckOuts.Location = new System.Drawing.Point(9, 17);
            this.gridCheckOuts.Name = "gridCheckOuts";
            this.gridCheckOuts.Size = new System.Drawing.Size(561, 103);
            this.gridCheckOuts.TabIndex = 0;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 879);
            this.Controls.Add(this.groupBoxCheckOuts);
            this.Controls.Add(this.groupBoxCheckIns);
            this.Controls.Add(this.groupBoxOverview);
            this.Controls.Add(this.btnManageCustomer);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flwRooms);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOverview.ResumeLayout(false);
            this.groupBoxOverview.PerformLayout();
            this.groupBoxCheckIns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckIns)).EndInit();
            this.groupBoxCheckOuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckOuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.FlowLayoutPanel flwRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.GroupBox groupBoxOverview;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.GroupBox groupBoxCheckIns;
        private System.Windows.Forms.DataGridView gridCheckIns;
        private System.Windows.Forms.GroupBox groupBoxCheckOuts;
        private System.Windows.Forms.DataGridView gridCheckOuts;
    }
}