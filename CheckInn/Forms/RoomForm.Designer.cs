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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSetCustomer = new System.Windows.Forms.Button();
            this.dateBookingStarts = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateBookingEndsDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkInnDatabaseDataSet = new CheckInn.CheckInnDatabaseDataSet();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRoomTableAdapter = new CheckInn.CheckInnDatabaseDataSetTableAdapters.tblRoomTableAdapter();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Navy;
            this.lblStaffName.Location = new System.Drawing.Point(20, 129);
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
            this.label3.Location = new System.Drawing.Point(20, 42);
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
            this.label1.Location = new System.Drawing.Point(202, 9);
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
            this.lblRoomNumber.Location = new System.Drawing.Point(123, 129);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(109, 45);
            this.lblRoomNumber.TabIndex = 29;
            this.lblRoomNumber.Text = "Room";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(238, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 25);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Busy";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(1007, 42);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(174, 45);
            this.lblFormTitle.TabIndex = 31;
            this.lblFormTitle.Text = "Form Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(969, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(969, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Customer DOB   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(969, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(969, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Phone Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(969, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 32);
            this.label7.TabIndex = 36;
            this.label7.Text = "Customer Address :";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1212, 255);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1212, 371);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 48);
            this.txtAddress.TabIndex = 38;
            this.txtAddress.Text = "";
            // 
            // dateDOB
            // 
            this.dateDOB.Location = new System.Drawing.Point(1212, 201);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(200, 20);
            this.dateDOB.TabIndex = 39;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(1212, 314);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumber.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1212, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 41;
            // 
            // btnSetCustomer
            // 
            this.btnSetCustomer.Location = new System.Drawing.Point(1317, 685);
            this.btnSetCustomer.Name = "btnSetCustomer";
            this.btnSetCustomer.Size = new System.Drawing.Size(97, 32);
            this.btnSetCustomer.TabIndex = 42;
            this.btnSetCustomer.Text = "Set Customer";
            this.btnSetCustomer.UseVisualStyleBackColor = true;
            this.btnSetCustomer.Click += new System.EventHandler(this.btnSetCustomer_Click);
            // 
            // dateBookingStarts
            // 
            this.dateBookingStarts.Location = new System.Drawing.Point(1227, 596);
            this.dateBookingStarts.Name = "dateBookingStarts";
            this.dateBookingStarts.Size = new System.Drawing.Size(200, 20);
            this.dateBookingStarts.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(984, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 32);
            this.label8.TabIndex = 43;
            this.label8.Text = "Booking Starts :";
            // 
            // dateBookingEndsDate
            // 
            this.dateBookingEndsDate.Location = new System.Drawing.Point(1227, 640);
            this.dateBookingEndsDate.Name = "dateBookingEndsDate";
            this.dateBookingEndsDate.Size = new System.Drawing.Size(200, 20);
            this.dateBookingEndsDate.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(984, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 32);
            this.label9.TabIndex = 45;
            this.label9.Text = "Booking Ends :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
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
            // cmbRoomID
            // 
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(1212, 452);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(200, 21);
            this.cmbRoomID.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(969, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 32);
            this.label11.TabIndex = 50;
            this.label11.Text = "Room Type and ID:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 744);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbRoomID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateBookingEndsDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateBookingStarts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSetCustomer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSetCustomer;
        private System.Windows.Forms.DateTimePicker dateBookingEndsDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateBookingStarts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private CheckInnDatabaseDataSet checkInnDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private CheckInnDatabaseDataSetTableAdapters.tblRoomTableAdapter tblRoomTableAdapter;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.Label label11;
    }
}