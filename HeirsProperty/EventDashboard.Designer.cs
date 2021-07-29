namespace HeirsProperty
{
    partial class EventDashboard
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
            this.btnPlanEvent = new System.Windows.Forms.Button();
            this.btnEventCal = new System.Windows.Forms.Button();
            this.btnVWManage = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlanEvent
            // 
            this.btnPlanEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanEvent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlanEvent.Location = new System.Drawing.Point(245, 162);
            this.btnPlanEvent.Name = "btnPlanEvent";
            this.btnPlanEvent.Size = new System.Drawing.Size(107, 23);
            this.btnPlanEvent.TabIndex = 7;
            this.btnPlanEvent.Text = "Plan Event **";
            this.btnPlanEvent.UseVisualStyleBackColor = true;
            // 
            // btnEventCal
            // 
            this.btnEventCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventCal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEventCal.Location = new System.Drawing.Point(245, 133);
            this.btnEventCal.Name = "btnEventCal";
            this.btnEventCal.Size = new System.Drawing.Size(107, 23);
            this.btnEventCal.TabIndex = 6;
            this.btnEventCal.Text = "Event Calendar**";
            this.btnEventCal.UseVisualStyleBackColor = true;
            // 
            // btnVWManage
            // 
            this.btnVWManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVWManage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVWManage.Location = new System.Drawing.Point(245, 104);
            this.btnVWManage.Name = "btnVWManage";
            this.btnVWManage.Size = new System.Drawing.Size(107, 23);
            this.btnVWManage.TabIndex = 5;
            this.btnVWManage.Text = "View/Manage Events";
            this.btnVWManage.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddEvent.Location = new System.Drawing.Point(245, 75);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(107, 23);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "Add Event\r\n";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // EventDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlanEvent);
            this.Controls.Add(this.btnEventCal);
            this.Controls.Add(this.btnVWManage);
            this.Controls.Add(this.btnAddEvent);
            this.Name = "EventDashboard";
            this.Text = "EventDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanEvent;
        private System.Windows.Forms.Button btnEventCal;
        private System.Windows.Forms.Button btnVWManage;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}