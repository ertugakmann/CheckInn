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
            this.lblFormTitle.Location = new System.Drawing.Point(710, 31);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(174, 45);
            this.lblFormTitle.TabIndex = 31;
            this.lblFormTitle.Text = "Form Title";
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
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 744);
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
    }
}