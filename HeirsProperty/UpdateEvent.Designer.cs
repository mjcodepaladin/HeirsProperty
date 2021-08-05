namespace HeirsProperty
{
    partial class UpdateEvent
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
            this.cmbTimeAMPM = new System.Windows.Forms.ComboBox();
            this.cmbTimeMinutes = new System.Windows.Forms.ComboBox();
            this.cmbTimeHours = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateEventDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optYes = new System.Windows.Forms.RadioButton();
            this.txtEventCapacity = new System.Windows.Forms.TextBox();
            this.txtEventPrice = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTimeAMPM
            // 
            this.cmbTimeAMPM.FormattingEnabled = true;
            this.cmbTimeAMPM.Location = new System.Drawing.Point(490, 220);
            this.cmbTimeAMPM.Name = "cmbTimeAMPM";
            this.cmbTimeAMPM.Size = new System.Drawing.Size(37, 21);
            this.cmbTimeAMPM.TabIndex = 27;
            // 
            // cmbTimeMinutes
            // 
            this.cmbTimeMinutes.FormattingEnabled = true;
            this.cmbTimeMinutes.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbTimeMinutes.Location = new System.Drawing.Point(447, 219);
            this.cmbTimeMinutes.Name = "cmbTimeMinutes";
            this.cmbTimeMinutes.Size = new System.Drawing.Size(37, 21);
            this.cmbTimeMinutes.TabIndex = 26;
            // 
            // cmbTimeHours
            // 
            this.cmbTimeHours.FormattingEnabled = true;
            this.cmbTimeHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbTimeHours.Location = new System.Drawing.Point(404, 219);
            this.cmbTimeHours.Name = "cmbTimeHours";
            this.cmbTimeHours.Size = new System.Drawing.Size(37, 21);
            this.cmbTimeHours.TabIndex = 25;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(255, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateEventDateTime
            // 
            this.dateEventDateTime.Location = new System.Drawing.Point(197, 221);
            this.dateEventDateTime.Name = "dateEventDateTime";
            this.dateEventDateTime.Size = new System.Drawing.Size(200, 20);
            this.dateEventDateTime.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date Determined";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Event Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Event Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Event Name";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(346, 174);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(39, 17);
            this.optNo.TabIndex = 18;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optYes
            // 
            this.optYes.AutoSize = true;
            this.optYes.Location = new System.Drawing.Point(255, 174);
            this.optYes.Name = "optYes";
            this.optYes.Size = new System.Drawing.Size(43, 17);
            this.optYes.TabIndex = 17;
            this.optYes.TabStop = true;
            this.optYes.Text = "Yes\r\n";
            this.optYes.UseVisualStyleBackColor = true;
            // 
            // txtEventCapacity
            // 
            this.txtEventCapacity.Location = new System.Drawing.Point(255, 136);
            this.txtEventCapacity.Name = "txtEventCapacity";
            this.txtEventCapacity.Size = new System.Drawing.Size(142, 20);
            this.txtEventCapacity.TabIndex = 16;
            // 
            // txtEventPrice
            // 
            this.txtEventPrice.Location = new System.Drawing.Point(255, 97);
            this.txtEventPrice.Name = "txtEventPrice";
            this.txtEventPrice.Size = new System.Drawing.Size(142, 20);
            this.txtEventPrice.TabIndex = 15;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(255, 58);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(142, 20);
            this.txtEventName.TabIndex = 14;
            // 
            // UpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTimeAMPM);
            this.Controls.Add(this.cmbTimeMinutes);
            this.Controls.Add(this.cmbTimeHours);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateEventDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optNo);
            this.Controls.Add(this.optYes);
            this.Controls.Add(this.txtEventCapacity);
            this.Controls.Add(this.txtEventPrice);
            this.Controls.Add(this.txtEventName);
            this.Name = "UpdateEvent";
            this.Text = "UpdateEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTimeAMPM;
        private System.Windows.Forms.ComboBox cmbTimeMinutes;
        private System.Windows.Forms.ComboBox cmbTimeHours;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateEventDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optYes;
        private System.Windows.Forms.TextBox txtEventCapacity;
        private System.Windows.Forms.TextBox txtEventPrice;
        private System.Windows.Forms.TextBox txtEventName;
    }
}