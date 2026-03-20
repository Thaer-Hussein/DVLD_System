namespace DVLD_System.User
{
    partial class frmUserChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbllsActiveValue = new System.Windows.Forms.Label();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblIsShowActive = new System.Windows.Forms.Label();
            this.lblShowUsername = new System.Windows.Forms.Label();
            this.lblShowUserID = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.ctrlPersonCard1 = new DVLD_System.People.Controls.ctrlPersonCard();
            this.errProvCurrentPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvConfirmPassword)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(12, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 100);
            this.panel1.TabIndex = 3;
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
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(37, 457);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(197, 25);
            this.lblCurrentPassword.TabIndex = 115;
            this.lblCurrentPassword.Text = "Current Password :";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(37, 502);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(167, 25);
            this.lblNewPassword.TabIndex = 116;
            this.lblNewPassword.Text = "New Password :";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(37, 548);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(200, 25);
            this.lblConfirmPassword.TabIndex = 117;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(241, 457);
            this.tbCurrentPassword.Multiline = true;
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(165, 33);
            this.tbCurrentPassword.TabIndex = 118;
            this.tbCurrentPassword.Leave += new System.EventHandler(this.tbCurrentPassword_Leave);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(211, 502);
            this.tbNewPassword.Multiline = true;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(165, 33);
            this.tbNewPassword.TabIndex = 119;
            this.tbNewPassword.Leave += new System.EventHandler(this.tbNewPassword_Leave);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(241, 548);
            this.tbConfirmPassword.Multiline = true;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(165, 33);
            this.tbConfirmPassword.TabIndex = 120;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tbConfirmPassword.Leave += new System.EventHandler(this.tbConfirmPassword_Leave);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(826, 294);
            this.ctrlPersonCard1.TabIndex = 2;
            // 
            // errProvCurrentPassword
            // 
            this.errProvCurrentPassword.ContainerControl = this;
            // 
            // errProvNewPassword
            // 
            this.errProvNewPassword.ContainerControl = this;
            // 
            // errProvConfirmPassword
            // 
            this.errProvConfirmPassword.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(689, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 52);
            this.btnSave.TabIndex = 121;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 593);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbllsActiveValue;
        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblIsShowActive;
        private System.Windows.Forms.Label lblShowUsername;
        private System.Windows.Forms.Label lblShowUserID;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.ErrorProvider errProvCurrentPassword;
        private System.Windows.Forms.ErrorProvider errProvNewPassword;
        private System.Windows.Forms.ErrorProvider errProvConfirmPassword;
        private System.Windows.Forms.Button btnSave;
    }
}