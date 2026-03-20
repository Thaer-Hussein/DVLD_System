namespace DVLD_System.People
{
    partial class frmAddNewPerson
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
            this.addPersonControl1 = new DVLD_System.Controls.AddUpdatePersonControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(305, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Person";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addPersonControl1
            // 
            this.addPersonControl1.Location = new System.Drawing.Point(53, 71);
            this.addPersonControl1.Name = "addPersonControl1";
            this.addPersonControl1.Size = new System.Drawing.Size(942, 605);
            this.addPersonControl1.TabIndex = 1;
            this.addPersonControl1.Load += new System.EventHandler(this.addPersonControl1_Load);
            // 
            // frmAddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 654);
            this.Controls.Add(this.addPersonControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Person ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewPerson_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DVLD_System.Controls.AddUpdatePersonControl addPersonControl1;
    }
}