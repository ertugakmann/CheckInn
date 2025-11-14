namespace CheckInn
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomCard));
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // picDoor
            // 
            this.picDoor.Image = ((System.Drawing.Image)(resources.GetObject("picDoor.Image")));
            this.picDoor.Location = new System.Drawing.Point(23, 17);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(100, 104);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 0;
            this.picDoor.TabStop = false;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblRoomNumber.Location = new System.Drawing.Point(18, 107);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(23, 25);
            this.lblRoomNumber.TabIndex = 25;
            this.lblRoomNumber.Text = "1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(47, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 25);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Busy";
            // 
            // RoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.picDoor);
            this.Name = "RoomCard";
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDoor;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblStatus;
    }
}
