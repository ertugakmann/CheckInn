namespace CheckInn.Forms.ReceptionistForms.RoomForms.ManageRoomServiceRequests
{
    partial class UpdateServiceRequestsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceContent = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(33, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 115;
            this.label1.Text = "Service Content:";
            // 
            // txtServiceContent
            // 
            this.txtServiceContent.Location = new System.Drawing.Point(413, 177);
            this.txtServiceContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServiceContent.Name = "txtServiceContent";
            this.txtServiceContent.Size = new System.Drawing.Size(298, 26);
            this.txtServiceContent.TabIndex = 113;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(565, 246);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 49);
            this.btnUpdate.TabIndex = 112;
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(30, 52);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(689, 65);
            this.lblFormTitle.TabIndex = 111;
            this.lblFormTitle.Text = "Create Room Service Request";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(377, 246);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(146, 49);
            this.btnDeleteService.TabIndex = 116;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // UpdateServiceRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServiceContent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "UpdateServiceRequestsForm";
            this.Text = "UpdateServiceRequestsForm";
            this.Load += new System.EventHandler(this.UpdateServiceRequestsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceContent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnDeleteService;
    }
}