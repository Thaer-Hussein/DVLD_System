namespace DVLD_System.User
{
    partial class frmShowUserInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbllsActiveValue = new System.Windows.Forms.Label();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblIsShowActive = new System.Windows.Forms.Label();
            this.lblShowUsername = new System.Windows.Forms.Label();
            this.lblShowUserID = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLD_System.People.Controls.ctrlPersonCard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbllsActiveValue);
            this.panel1.Controls.Add(this.lblUsernameValue);
            this.panel1.Controls.Add(this.lblUserIDValue);
            this.panel1.Controls.Add(this.lblIsShowActive);
            this.panel1.Controls.Add(this.lblShowUsername);
            this.panel1.Controls.Add(this.lblShowUserID);
            this.panel1.Location = new System.Drawing.Point(23, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbllsActiveValue
            // 
            this.lbllsActiveValue.AutoSize = true;
            this.lbllsActiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllsActiveValue.Location = new System.Drawing.Point(635, 35);
            this.lbllsActiveValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllsActiveValue.Name = "lbllsActiveValue";
            this.lbllsActiveValue.Size = new System.Drawing.Size(68, 25);
            this.lbllsActiveValue.TabIndex = 135;
            this.lbllsActiveValue.Text = "[????]";
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameValue.Location = new System.Drawing.Point(387, 35);
            this.lblUsernameValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(68, 25);
            this.lblUsernameValue.TabIndex = 134;
            this.lblUsernameValue.Text = "[????]";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.Location = new System.Drawing.Point(130, 35);
            this.lblUserIDValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(68, 25);
            this.lblUserIDValue.TabIndex = 133;
            this.lblUserIDValue.Text = "[????]";
            // 
            // lblIsShowActive
            // 
            this.lblIsShowActive.AutoSize = true;
            this.lblIsShowActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsShowActive.Location = new System.Drawing.Point(531, 35);
            this.lblIsShowActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsShowActive.Name = "lblIsShowActive";
            this.lblIsShowActive.Size = new System.Drawing.Size(108, 25);
            this.lblIsShowActive.TabIndex = 116;
            this.lblIsShowActive.Text = "IsActive : ";
            // 
            // lblShowUsername
            // 
            this.lblShowUsername.AutoSize = true;
            this.lblShowUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUsername.Location = new System.Drawing.Point(256, 35);
            this.lblShowUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowUsername.Name = "lblShowUsername";
            this.lblShowUsername.Size = new System.Drawing.Size(123, 25);
            this.lblShowUsername.TabIndex = 115;
            this.lblShowUsername.Text = "Username :";
            // 
            // lblShowUserID
            // 
            this.lblShowUserID.AutoSize = true;
            this.lblShowUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUserID.Location = new System.Drawing.Point(25, 35);
            this.lblShowUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowUserID.Name = "lblShowUserID";
            this.lblShowUserID.Size = new System.Drawing.Size(97, 25);
            this.lblShowUserID.TabIndex = 114;
            this.lblShowUserID.Text = "User ID :";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(23, 12);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(826, 294);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowUserInfo";
            this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIsShowActive;
        private System.Windows.Forms.Label lblShowUsername;
        private System.Windows.Forms.Label lblShowUserID;
        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lbllsActiveValue;
    }
}