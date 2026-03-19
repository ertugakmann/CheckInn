namespace CheckInn.Forms.ReceptionistForms.RoomForms.ManageBookingForms
{
    partial class CheckInForm
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.cmbBooking = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(134, 28);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(235, 45);
            this.lblFormTitle.TabIndex = 32;
            this.lblFormTitle.Text = "Check In Form";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(26, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 32);
            this.label11.TabIndex = 85;
            this.label11.Text = "Booking:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 90;
            this.label3.Text = "Room :";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Enabled = false;
            this.txtRoomType.Location = new System.Drawing.Point(269, 203);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(200, 20);
            this.txtRoomType.TabIndex = 89;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(26, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 32);
            this.label15.TabIndex = 88;
            this.label15.Text = "Room Type :";
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(353, 331);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(116, 32);
            this.btnUpdateBooking.TabIndex = 92;
            this.btnUpdateBooking.Text = "Check In Customer";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Enabled = false;
            this.txtRoomID.Location = new System.Drawing.Point(269, 158);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(200, 20);
            this.txtRoomID.TabIndex = 94;
            // 
            // cmbBooking
            // 
            this.cmbBooking.FormattingEnabled = true;
            this.cmbBooking.Location = new System.Drawing.Point(269, 105);
            this.cmbBooking.Name = "cmbBooking";
            this.cmbBooking.Size = new System.Drawing.Size(200, 21);
            this.cmbBooking.TabIndex = 95;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.cmbBooking);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.ComboBox cmbBooking;
    }
}