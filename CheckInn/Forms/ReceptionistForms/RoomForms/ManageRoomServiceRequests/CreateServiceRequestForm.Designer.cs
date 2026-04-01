namespace CheckInn.Forms.ReceptionistForms.RoomForms
{
    partial class CreateServiceRequestForm
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
            this.txtServiceContent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRequestService = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServiceContent
            // 
            this.txtServiceContent.Location = new System.Drawing.Point(401, 165);
            this.txtServiceContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServiceContent.Name = "txtServiceContent";
            this.txtServiceContent.Size = new System.Drawing.Size(298, 26);
            this.txtServiceContent.TabIndex = 104;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 109;
            // 
            // btnRequestService
            // 
            this.btnRequestService.Location = new System.Drawing.Point(553, 245);
            this.btnRequestService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRequestService.Name = "btnRequestService";
            this.btnRequestService.Size = new System.Drawing.Size(146, 49);
            this.btnRequestService.TabIndex = 101;
            this.btnRequestService.Text = "Request Service";
            this.btnRequestService.UseVisualStyleBackColor = true;
            this.btnRequestService.Click += new System.EventHandler(this.btnRequestService_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(18, 51);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(689, 65);
            this.lblFormTitle.TabIndex = 100;
            this.lblFormTitle.Text = "Create Room Service Request";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(21, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 110;
            this.label1.Text = "Service Content:";
            // 
            // CreateServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServiceContent);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRequestService);
            this.Controls.Add(this.lblFormTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateServiceRequestForm";
            this.Text = "CreateServiceRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtServiceContent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRequestService;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label label1;
    }
}