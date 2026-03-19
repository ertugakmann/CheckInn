namespace CheckInn.Forms
{
    partial class RoomForm
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
            this.lblStaffName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label10 = new System.Windows.Forms.Label();
            this.checkInnDatabaseDataSet = new CheckInn.CheckInnDatabaseDataSet();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRoomTableAdapter = new CheckInn.CheckInnDatabaseDataSetTableAdapters.tblRoomTableAdapter();
            this.groupBoxCheckIns = new System.Windows.Forms.GroupBox();
            this.gridBookings = new System.Windows.Forms.DataGridView();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.groupBoxOverview = new System.Windows.Forms.GroupBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblPricePerNight = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateRoomService = new System.Windows.Forms.Button();
            this.groupBoxRoomCharges = new System.Windows.Forms.GroupBox();
            this.dataGridRoomCharges = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreateRoomCharges = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            this.groupBoxCheckIns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).BeginInit();
            this.groupBoxOverview.SuspendLayout();
            this.groupBoxRoomCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomCharges)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Navy;
            this.lblStaffName.Location = new System.Drawing.Point(29, 87);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(109, 45);
            this.lblStaffName.TabIndex = 28;
            this.lblStaffName.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(211, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 86);
            this.label1.TabIndex = 25;
            this.label1.Text = "CheckInn";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblRoomNumber.Location = new System.Drawing.Point(132, 87);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 45);
            this.lblRoomNumber.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(240, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 30;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(743, 83);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(330, 45);
            this.lblFormTitle.TabIndex = 31;
            this.lblFormTitle.Text = "Create Room Service";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-9, -148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 49;
            // 
            // checkInnDatabaseDataSet
            // 
            this.checkInnDatabaseDataSet.DataSetName = "CheckInnDatabaseDataSet";
            this.checkInnDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tblRoom";
            this.tblRoomBindingSource.DataSource = this.checkInnDatabaseDataSet;
            // 
            // tblRoomTableAdapter
            // 
            this.tblRoomTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxCheckIns
            // 
            this.groupBoxCheckIns.Controls.Add(this.gridBookings);
            this.groupBoxCheckIns.Location = new System.Drawing.Point(28, 484);
            this.groupBoxCheckIns.Name = "groupBoxCheckIns";
            this.groupBoxCheckIns.Size = new System.Drawing.Size(574, 147);
            this.groupBoxCheckIns.TabIndex = 50;
            this.groupBoxCheckIns.TabStop = false;
            // 
            // gridBookings
            // 
            this.gridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookings.Location = new System.Drawing.Point(7, 13);
            this.gridBookings.Name = "gridBookings";
            this.gridBookings.Size = new System.Drawing.Size(561, 128);
            this.gridBookings.TabIndex = 0;
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBookings.Location = new System.Drawing.Point(198, 371);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(132, 32);
            this.btnManageBookings.TabIndex = 53;
            this.btnManageBookings.Text = "Manage Bookings";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.Location = new System.Drawing.Point(198, 333);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(132, 32);
            this.btnCreateBooking.TabIndex = 51;
            this.btnCreateBooking.Text = "Create Booking";
            // 
            // groupBoxOverview
            // 
            this.groupBoxOverview.Controls.Add(this.lblRoomStatus);
            this.groupBoxOverview.Controls.Add(this.lblRoomType);
            this.groupBoxOverview.Controls.Add(this.lblPricePerNight);
            this.groupBoxOverview.Location = new System.Drawing.Point(35, 160);
            this.groupBoxOverview.Name = "groupBoxOverview";
            this.groupBoxOverview.Size = new System.Drawing.Size(268, 89);
            this.groupBoxOverview.TabIndex = 54;
            this.groupBoxOverview.TabStop = false;
            this.groupBoxOverview.Text = "Room Overview";
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomStatus.Location = new System.Drawing.Point(6, 63);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(110, 21);
            this.lblRoomStatus.TabIndex = 2;
            this.lblRoomStatus.Text = "Room Status:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomType.Location = new System.Drawing.Point(6, 39);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(99, 21);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lblPricePerNight
            // 
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPricePerNight.Location = new System.Drawing.Point(6, 16);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(129, 21);
            this.lblPricePerNight.TabIndex = 0;
            this.lblPricePerNight.Text = "Price Per Night:";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReport.Location = new System.Drawing.Point(35, 700);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(132, 32);
            this.btnGetReport.TabIndex = 55;
            this.btnGetReport.Text = "Get Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 45);
            this.label2.TabIndex = 56;
            this.label2.Text = "Get Statistics Report of the Room";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(35, 371);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(132, 32);
            this.btnCheckOut.TabIndex = 59;
            this.btnCheckOut.Text = "Check Out";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(35, 333);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(132, 32);
            this.btnCheckIn.TabIndex = 57;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(27, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 45);
            this.label5.TabIndex = 58;
            this.label5.Text = "Quick Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(29, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 45);
            this.label4.TabIndex = 60;
            this.label4.Text = "Bookings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(743, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 45);
            this.label8.TabIndex = 100;
            this.label8.Text = "Create Room Charge";
            // 
            // btnCreateRoomService
            // 
            this.btnCreateRoomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoomService.Location = new System.Drawing.Point(751, 140);
            this.btnCreateRoomService.Name = "btnCreateRoomService";
            this.btnCreateRoomService.Size = new System.Drawing.Size(158, 32);
            this.btnCreateRoomService.TabIndex = 101;
            this.btnCreateRoomService.Text = "Create Room Service";
            this.btnCreateRoomService.Click += new System.EventHandler(this.btnCreateRoomService_Click);
            // 
            // groupBoxRoomCharges
            // 
            this.groupBoxRoomCharges.Controls.Add(this.dataGridRoomCharges);
            this.groupBoxRoomCharges.Location = new System.Drawing.Point(751, 545);
            this.groupBoxRoomCharges.Name = "groupBoxRoomCharges";
            this.groupBoxRoomCharges.Size = new System.Drawing.Size(574, 147);
            this.groupBoxRoomCharges.TabIndex = 51;
            this.groupBoxRoomCharges.TabStop = false;
            this.groupBoxRoomCharges.Text = "Room Charges";
            // 
            // dataGridRoomCharges
            // 
            this.dataGridRoomCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoomCharges.Location = new System.Drawing.Point(7, 13);
            this.dataGridRoomCharges.Name = "dataGridRoomCharges";
            this.dataGridRoomCharges.Size = new System.Drawing.Size(561, 128);
            this.dataGridRoomCharges.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(751, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 147);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Service Requests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCreateRoomCharges
            // 
            this.btnCreateRoomCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoomCharges.Location = new System.Drawing.Point(751, 497);
            this.btnCreateRoomCharges.Name = "btnCreateRoomCharges";
            this.btnCreateRoomCharges.Size = new System.Drawing.Size(158, 32);
            this.btnCreateRoomCharges.TabIndex = 103;
            this.btnCreateRoomCharges.Text = "Create Room Charge";
            this.btnCreateRoomCharges.Click += new System.EventHandler(this.btnCreateRoomCharges_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(937, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 13);
            this.label11.TabIndex = 105;
            this.label11.Text = "Double Click to Update Service Requests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(943, 695);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Double Click to Manage Room Charges";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 744);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCreateRoomCharges);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRoomCharges);
            this.Controls.Add(this.btnCreateRoomService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxOverview);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.groupBoxCheckIns);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            this.groupBoxCheckIns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).EndInit();
            this.groupBoxOverview.ResumeLayout(false);
            this.groupBoxOverview.PerformLayout();
            this.groupBoxRoomCharges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomCharges)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFormTitle;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label10;
        private CheckInnDatabaseDataSet checkInnDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private CheckInnDatabaseDataSetTableAdapters.tblRoomTableAdapter tblRoomTableAdapter;
        private System.Windows.Forms.DataGridView gridBookings;
        private System.Windows.Forms.GroupBox groupBoxCheckIns;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxOverview;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblPricePerNight;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateRoomService;
        private System.Windows.Forms.GroupBox groupBoxRoomCharges;
        private System.Windows.Forms.DataGridView dataGridRoomCharges;
        private System.Windows.Forms.Button btnCreateRoomCharges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}