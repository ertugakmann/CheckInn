namespace CheckInn.Forms.ReceptionistForms.RoomForms.ManageRoomCharges
{
    partial class UpdateRoomChargesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChargeContent = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(47, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 48);
            this.label2.TabIndex = 123;
            this.label2.Text = "Charge Amount:";
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(425, 264);
            this.txtChargeAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.Size = new System.Drawing.Size(298, 26);
            this.txtChargeAmount.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(47, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 48);
            this.label1.TabIndex = 121;
            this.label1.Text = "Charge Content:";
            // 
            // txtChargeContent
            // 
            this.txtChargeContent.Location = new System.Drawing.Point(425, 170);
            this.txtChargeContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChargeContent.Name = "txtChargeContent";
            this.txtChargeContent.Size = new System.Drawing.Size(298, 26);
            this.txtChargeContent.TabIndex = 120;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(569, 323);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 49);
            this.btnUpdate.TabIndex = 119;
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(34, 45);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(709, 65);
            this.lblFormTitle.TabIndex = 118;
            this.lblFormTitle.Text = "Update Room Service Request";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(383, 323);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(146, 49);
            this.btnDeleteService.TabIndex = 124;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // UpdateRoomChargesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChargeAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChargeContent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "UpdateRoomChargesForm";
            this.Text = "UpdateRoomCharges";
            this.Load += new System.EventHandler(this.UpdateRoomChargesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChargeContent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnDeleteService;
    }
}