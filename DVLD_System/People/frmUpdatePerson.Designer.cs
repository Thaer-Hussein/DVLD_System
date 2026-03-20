namespace DVLD_System.People
{
    partial class frmUpdatePerson
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.addPersonControl1 = new DVLD_System.Controls.AddUpdatePersonControl();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHeader.Location = new System.Drawing.Point(347, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(387, 60);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Update Person";
            // 
            // addPersonControl1
            // 
            this.addPersonControl1.Location = new System.Drawing.Point(83, 85);
            this.addPersonControl1.Name = "addPersonControl1";
            this.addPersonControl1.Size = new System.Drawing.Size(942, 605);
            this.addPersonControl1.TabIndex = 2;
            this.addPersonControl1.Load += new System.EventHandler(this.addPersonControl1_Load);
            // 
            // frmUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 660);
            this.Controls.Add(this.addPersonControl1);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdatePerson";
            this.Load += new System.EventHandler(this.frmUpdatePerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private DVLD_System.Controls.AddUpdatePersonControl addPersonControl1;
    }
}