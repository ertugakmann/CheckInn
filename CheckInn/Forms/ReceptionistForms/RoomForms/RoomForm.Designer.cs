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
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
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
            this.dgvRoomCharges = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvServiceRequests = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomCharges)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Navy;
            this.lblStaffName.Location = new System.Drawing.Point(44, 134);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(160, 65);
            this.lblStaffName.TabIndex = 28;
            this.lblStaffName.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(44, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 65);
            this.label3.TabIndex = 26;
            this.label3.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(316, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 128);
            this.label1.TabIndex = 25;
            this.label1.Text = "CheckInn";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblRoomNumber.Location = new System.Drawing.Point(198, 134);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 65);
            this.lblRoomNumber.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(360, 158);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 38);
            this.lblStatus.TabIndex = 30;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(1114, 128);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(495, 65);
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
            this.label10.Location = new System.Drawing.Point(-14, -228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 35);
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
            this.groupBoxCheckIns.Location = new System.Drawing.Point(42, 745);
            this.groupBoxCheckIns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCheckIns.Name = "groupBoxCheckIns";
            this.groupBoxCheckIns.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCheckIns.Size = new System.Drawing.Size(861, 226);
            this.groupBoxCheckIns.TabIndex = 50;
            this.groupBoxCheckIns.TabStop = false;
            // 
            // gridBookings
            // 
            this.gridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookings.Location = new System.Drawing.Point(10, 20);
            this.gridBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridBookings.Name = "gridBookings";
            this.gridBookings.RowHeadersWidth = 62;
            this.gridBookings.Size = new System.Drawing.Size(842, 197);
            this.gridBookings.TabIndex = 0;
            this.gridBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookings_CellContentClick);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBookings.Location = new System.Drawing.Point(297, 571);
            this.btnManageBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(198, 49);
            this.btnManageBookings.TabIndex = 53;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.Location = new System.Drawing.Point(297, 512);
            this.btnCreateBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(198, 49);
            this.btnCreateBooking.TabIndex = 51;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // groupBoxOverview
            // 
            this.groupBoxOverview.Controls.Add(this.lblCheckOutDate);
            this.groupBoxOverview.Controls.Add(this.lblCheckInDate);
            this.groupBoxOverview.Controls.Add(this.lblRoomStatus);
            this.groupBoxOverview.Controls.Add(this.lblRoomType);
            this.groupBoxOverview.Controls.Add(this.lblPricePerNight);
            this.groupBoxOverview.Location = new System.Drawing.Point(52, 208);
            this.groupBoxOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOverview.Name = "groupBoxOverview";
            this.groupBoxOverview.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOverview.Size = new System.Drawing.Size(402, 220);
            this.groupBoxOverview.TabIndex = 54;
            this.groupBoxOverview.TabStop = false;
            this.groupBoxOverview.Text = "Room Overview";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutDate.Location = new System.Drawing.Point(9, 177);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(165, 32);
            this.lblCheckOutDate.TabIndex = 4;
            this.lblCheckOutDate.Text = "Checked Out:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckInDate.Location = new System.Drawing.Point(9, 145);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(146, 32);
            this.lblCheckInDate.TabIndex = 3;
            this.lblCheckInDate.Text = "Checked In:";
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomStatus.Location = new System.Drawing.Point(9, 97);
            this.lblRoomStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(164, 32);
            this.lblRoomStatus.TabIndex = 2;
            this.lblRoomStatus.Text = "Room Status:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomType.Location = new System.Drawing.Point(9, 60);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(149, 32);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lblPricePerNight
            // 
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPricePerNight.Location = new System.Drawing.Point(9, 25);
            this.lblPricePerNight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(193, 32);
            this.lblPricePerNight.TabIndex = 0;
            this.lblPricePerNight.Text = "Price Per Night:";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReport.Location = new System.Drawing.Point(52, 1077);
            this.btnGetReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(198, 49);
            this.btnGetReport.TabIndex = 55;
            this.btnGetReport.Text = "Get Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(40, 995);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 65);
            this.label2.TabIndex = 56;
            this.label2.Text = "Get Statistics Report of the Room";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(52, 571);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(198, 49);
            this.btnCheckOut.TabIndex = 59;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(52, 512);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(198, 49);
            this.btnCheckIn.TabIndex = 57;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(40, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 65);
            this.label5.TabIndex = 58;
            this.label5.Text = "Quick Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(44, 671);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 65);
            this.label4.TabIndex = 60;
            this.label4.Text = "Future Bookings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(1114, 671);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(492, 65);
            this.label8.TabIndex = 100;
            this.label8.Text = "Create Room Charge";
            // 
            // btnCreateRoomService
            // 
            this.btnCreateRoomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoomService.Location = new System.Drawing.Point(1126, 215);
            this.btnCreateRoomService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateRoomService.Name = "btnCreateRoomService";
            this.btnCreateRoomService.Size = new System.Drawing.Size(237, 49);
            this.btnCreateRoomService.TabIndex = 101;
            this.btnCreateRoomService.Text = "Create Room Service";
            this.btnCreateRoomService.Click += new System.EventHandler(this.btnCreateRoomService_Click);
            // 
            // groupBoxRoomCharges
            // 
            this.groupBoxRoomCharges.Controls.Add(this.dgvRoomCharges);
            this.groupBoxRoomCharges.Location = new System.Drawing.Point(1126, 838);
            this.groupBoxRoomCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRoomCharges.Name = "groupBoxRoomCharges";
            this.groupBoxRoomCharges.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRoomCharges.Size = new System.Drawing.Size(861, 226);
            this.groupBoxRoomCharges.TabIndex = 51;
            this.groupBoxRoomCharges.TabStop = false;
            this.groupBoxRoomCharges.Text = "Room Charges";
            // 
            // dgvRoomCharges
            // 
            this.dgvRoomCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomCharges.Location = new System.Drawing.Point(10, 20);
            this.dgvRoomCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRoomCharges.Name = "dgvRoomCharges";
            this.dgvRoomCharges.RowHeadersWidth = 62;
            this.dgvRoomCharges.Size = new System.Drawing.Size(842, 197);
            this.dgvRoomCharges.TabIndex = 0;
            this.dgvRoomCharges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookings_CellContentClick);
            this.dgvRoomCharges.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomCharges_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvServiceRequests);
            this.groupBox1.Location = new System.Drawing.Point(1126, 292);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(861, 226);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Service Requests";
            // 
            // dgvServiceRequests
            // 
            this.dgvServiceRequests.ColumnHeadersHeight = 34;
            this.dgvServiceRequests.Location = new System.Drawing.Point(10, 27);
            this.dgvServiceRequests.Name = "dgvServiceRequests";
            this.dgvServiceRequests.RowHeadersWidth = 62;
            this.dgvServiceRequests.Size = new System.Drawing.Size(840, 191);
            this.dgvServiceRequests.TabIndex = 0;
            this.dgvServiceRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookings_CellContentClick);
            this.dgvServiceRequests.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomServiceRequests_CellDoubleClick);
            // 
            // btnCreateRoomCharges
            // 
            this.btnCreateRoomCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoomCharges.Location = new System.Drawing.Point(1126, 765);
            this.btnCreateRoomCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateRoomCharges.Name = "btnCreateRoomCharges";
            this.btnCreateRoomCharges.Size = new System.Drawing.Size(237, 49);
            this.btnCreateRoomCharges.TabIndex = 103;
            this.btnCreateRoomCharges.Text = "Create Room Charge";
            this.btnCreateRoomCharges.Click += new System.EventHandler(this.btnCreateRoomCharges_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(1406, 523);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 21);
            this.label11.TabIndex = 105;
            this.label11.Text = "Double Click to Update Service Requests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1414, 1069);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 21);
            this.label6.TabIndex = 106;
            this.label6.Text = "Double Click to Manage Room Charges";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2229, 1145);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomCharges)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceRequests)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRoomCharges;
        private System.Windows.Forms.Button btnCreateRoomCharges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvServiceRequests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
    }
}