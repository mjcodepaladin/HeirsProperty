namespace HeirsProperty
{
    partial class EventCreation
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
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventPrice = new System.Windows.Forms.TextBox();
            this.txtEventCapacity = new System.Windows.Forms.TextBox();
            this.optYes = new System.Windows.Forms.RadioButton();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEventDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbTimeHours = new System.Windows.Forms.ComboBox();
            this.cmbTimeMinutes = new System.Windows.Forms.ComboBox();
            this.cmbTimeAMPM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(213, 51);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(142, 20);
            this.txtEventName.TabIndex = 0;
            // 
            // txtEventPrice
            // 
            this.txtEventPrice.Location = new System.Drawing.Point(213, 90);
            this.txtEventPrice.Name = "txtEventPrice";
            this.txtEventPrice.Size = new System.Drawing.Size(142, 20);
            this.txtEventPrice.TabIndex = 1;
            //this.txtEventPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEventCapacity
            // 
            this.txtEventCapacity.Location = new System.Drawing.Point(213, 129);
            this.txtEventCapacity.Name = "txtEventCapacity";
            this.txtEventCapacity.Size = new System.Drawing.Size(142, 20);
            this.txtEventCapacity.TabIndex = 2;
            // 
            // optYes
            // 
            this.optYes.AutoSize = true;
            this.optYes.Location = new System.Drawing.Point(213, 167);
            this.optYes.Name = "optYes";
            this.optYes.Size = new System.Drawing.Size(43, 17);
            this.optYes.TabIndex = 3;
            this.optYes.TabStop = true;
            this.optYes.Text = "Yes\r\n";
            this.optYes.UseVisualStyleBackColor = true;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(304, 167);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(39, 17);
            this.optNo.TabIndex = 4;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Event Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Determined";
            // 
            // dateEventDateTime
            // 
            this.dateEventDateTime.Location = new System.Drawing.Point(155, 214);
            this.dateEventDateTime.Name = "dateEventDateTime";
            this.dateEventDateTime.Size = new System.Drawing.Size(200, 20);
            this.dateEventDateTime.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(213, 252);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.cmbTimeHours.Location = new System.Drawing.Point(362, 212);
            this.cmbTimeHours.Name = "cmbTimeHours";
            this.cmbTimeHours.Size = new System.Drawing.Size(37, 21);
            this.cmbTimeHours.TabIndex = 11;
            // 
            // cmbTimeMinutes
            // 
            this.cmbTimeMinutes.FormattingEnabled = true;
            this.cmbTimeMinutes.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbTimeMinutes.Location = new System.Drawing.Point(405, 212);
            this.cmbTimeMinutes.Name = "cmbTimeMinutes";
            this.cmbTimeMinutes.Size = new System.Drawing.Size(37, 21);
            this.cmbTimeMinutes.TabIndex = 12;
            // 
            // cmbTimeAMPM
            // 
            this.cmbTimeAMPM.FormattingEnabled = true;
            this.cmbTimeAMPM.Location = new System.Drawing.Point(448, 213);
            this.cmbTimeAMPM.Name = "cmbTimeAMPM";
            this.cmbTimeAMPM.Size = new System.Drawing.Size(37, 21);
            this.cmbTimeAMPM.TabIndex = 13;
            // 
            // EventCreation
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
            this.Name = "EventCreation";
            this.Text = "EventCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventPrice;
        private System.Windows.Forms.TextBox txtEventCapacity;
        private System.Windows.Forms.RadioButton optYes;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateEventDateTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbTimeHours;
        private System.Windows.Forms.ComboBox cmbTimeMinutes;
        private System.Windows.Forms.ComboBox cmbTimeAMPM;
    }
}