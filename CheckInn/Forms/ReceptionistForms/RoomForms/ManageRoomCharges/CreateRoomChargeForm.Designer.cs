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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChargeContent = new System.Windows.Forms.TextBox();
            this.btnCreateCharge = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(43, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 48);
            this.label1.TabIndex = 115;
            this.label1.Text = "Charge Content:";
            // 
            // txtChargeContent
            // 
            this.txtChargeContent.Location = new System.Drawing.Point(421, 180);
            this.txtChargeContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChargeContent.Name = "txtChargeContent";
            this.txtChargeContent.Size = new System.Drawing.Size(298, 26);
            this.txtChargeContent.TabIndex = 113;
            // 
            // btnCreateCharge
            // 
            this.btnCreateCharge.Location = new System.Drawing.Point(565, 333);
            this.btnCreateCharge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCharge.Name = "btnCreateCharge";
            this.btnCreateCharge.Size = new System.Drawing.Size(146, 49);
            this.btnCreateCharge.TabIndex = 112;
            this.btnCreateCharge.Text = "Create Charge";
            this.btnCreateCharge.UseVisualStyleBackColor = true;
            this.btnCreateCharge.Click += new System.EventHandler(this.btnCreateCharge_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblFormTitle.Location = new System.Drawing.Point(30, 55);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(689, 65);
            this.lblFormTitle.TabIndex = 111;
            this.lblFormTitle.Text = "Create Room Service Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(43, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 48);
            this.label2.TabIndex = 117;
            this.label2.Text = "Charge Amount:";
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(421, 274);
            this.txtChargeAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.Size = new System.Drawing.Size(298, 26);
            this.txtChargeAmount.TabIndex = 116;
            // 
            // CreateRoomChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChargeAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChargeContent);
            this.Controls.Add(this.btnCreateCharge);
            this.Controls.Add(this.lblFormTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateRoomChargeForm";
            this.Text = "CreateRoomChargeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChargeContent;
        private System.Windows.Forms.Button btnCreateCharge;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChargeAmount;
    }
}