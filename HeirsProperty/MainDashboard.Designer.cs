namespace HeirsProperty
{
    partial class MainDashboard
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
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnDonorInvDash = new System.Windows.Forms.Button();
            this.btnDonationDash = new System.Windows.Forms.Button();
            this.btnStatisticsDash = new System.Windows.Forms.Button();
            this.btnQuickTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvents
            // 
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEvents.Location = new System.Drawing.Point(224, 74);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(107, 23);
            this.btnEvents.TabIndex = 0;
            this.btnEvents.Text = "Manage Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnDonorInvDash
            // 
            this.btnDonorInvDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonorInvDash.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDonorInvDash.Location = new System.Drawing.Point(224, 103);
            this.btnDonorInvDash.Name = "btnDonorInvDash";
            this.btnDonorInvDash.Size = new System.Drawing.Size(107, 23);
            this.btnDonorInvDash.TabIndex = 1;
            this.btnDonorInvDash.Text = "Manage Donors";
            this.btnDonorInvDash.UseVisualStyleBackColor = true;
            this.btnDonorInvDash.Click += new System.EventHandler(this.btnDonorInvDash_Click);
            // 
            // btnDonationDash
            // 
            this.btnDonationDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonationDash.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDonationDash.Location = new System.Drawing.Point(224, 132);
            this.btnDonationDash.Name = "btnDonationDash";
            this.btnDonationDash.Size = new System.Drawing.Size(107, 23);
            this.btnDonationDash.TabIndex = 2;
            this.btnDonationDash.Text = "Manage Donations";
            this.btnDonationDash.UseVisualStyleBackColor = true;
            this.btnDonationDash.Click += new System.EventHandler(this.btnDonationDash_Click);
            // 
            // btnStatisticsDash
            // 
            this.btnStatisticsDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsDash.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatisticsDash.Location = new System.Drawing.Point(224, 161);
            this.btnStatisticsDash.Name = "btnStatisticsDash";
            this.btnStatisticsDash.Size = new System.Drawing.Size(107, 23);
            this.btnStatisticsDash.TabIndex = 3;
            this.btnStatisticsDash.Text = "Manage Statistics";
            this.btnStatisticsDash.UseVisualStyleBackColor = true;
            this.btnStatisticsDash.Click += new System.EventHandler(this.btnStatisticsDash_Click);
            // 
            // btnQuickTest
            // 
            this.btnQuickTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickTest.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuickTest.Location = new System.Drawing.Point(224, 200);
            this.btnQuickTest.Name = "btnQuickTest";
            this.btnQuickTest.Size = new System.Drawing.Size(107, 23);
            this.btnQuickTest.TabIndex = 8;
            this.btnQuickTest.Text = "Quick Test **";
            this.btnQuickTest.UseVisualStyleBackColor = true;
            this.btnQuickTest.Click += new System.EventHandler(this.btnQuickTest_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuickTest);
            this.Controls.Add(this.btnStatisticsDash);
            this.Controls.Add(this.btnDonationDash);
            this.Controls.Add(this.btnDonorInvDash);
            this.Controls.Add(this.btnEvents);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnDonorInvDash;
        private System.Windows.Forms.Button btnDonationDash;
        private System.Windows.Forms.Button btnStatisticsDash;
        private System.Windows.Forms.Button btnQuickTest;
    }
}