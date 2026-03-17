namespace CheckInn.Forms.ReceptionistForms.RoomForms
{
    partial class CreateRoomChargeForm
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
            this.dateRequestService = new System.Windows.Forms.DateTimePicker();
            this.txtServicePriority = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServiceDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCreateCharge = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateRequestService
            // 
            this.dateRequestService.Location = new System.Drawing.Point(275, 264);
            this.dateRequestService.Name = "dateRequestService";
            this.dateRequestService.Size = new System.Drawing.Size(200, 20);
            this.dateRequestService.TabIndex = 119;
            // 
            // txtServicePriority
            // 
            this.txtServicePriority.Location = new System.Drawing.Point(275, 200);
            this.txtServicePriority.Name = "txtServicePriority";
            this.txtServicePriority.Size = new System.Drawing.Size(200, 20);
            this.txtServicePriority.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(14, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 32);
            this.label6.TabIndex = 117;
            this.label6.Text = "Request Time:";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Location = new System.Drawing.Point(275, 86);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(200, 21);
            this.cmbServiceType.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(14, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 32);
            this.label7.TabIndex = 115;
            this.label7.Text = "Service Type:";
            // 
            // txtServiceDesc
            // 
            this.txtServiceDesc.Location = new System.Drawing.Point(275, 138);
            this.txtServiceDesc.Name = "txtServiceDesc";
            this.txtServiceDesc.Size = new System.Drawing.Size(200, 20);
            this.txtServiceDesc.TabIndex = 114;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(14, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 32);
            this.label14.TabIndex = 113;
            this.label14.Text = "Priority:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(14, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 32);
            this.label15.TabIndex = 112;
            this.label15.Text = "Service Description:";
            // 
            // btnCreateCharge
            // 
            this.btnCreateCharge.Location = new System.Drawing.Point(378, 310);
            this.btnCreateCharge.Name = "btnCreateCharge";
            this.btnCreateCharge.Size = new System.Drawing.Size(97, 32);
            this.btnCreateCharge.TabIndex = 111;
            this.btnCreateCharge.Text = "Create Charge";
            this.btnCreateCharge.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 23);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(329, 45);
            this.lblFormTitle.TabIndex = 110;
            this.lblFormTitle.Text = "Create Room Charge";
            // 
            // CreateRoomChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 384);
            this.Controls.Add(this.dateRequestService);
            this.Controls.Add(this.txtServicePriority);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServiceDesc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCreateCharge);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "CreateRoomChargeForm";
            this.Text = "CreateRoomChargeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateRequestService;
        private System.Windows.Forms.TextBox txtServicePriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServiceDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCreateCharge;
        private System.Windows.Forms.Label lblFormTitle;
    }
}