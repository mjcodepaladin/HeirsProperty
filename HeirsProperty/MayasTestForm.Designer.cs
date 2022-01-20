
namespace HeirsProperty
{
    partial class MayasTestForm
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
            this.btnTestButton = new System.Windows.Forms.Button();
            this.txtInputBox = new System.Windows.Forms.TextBox();
            this.txtOutputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestButton
            // 
            this.btnTestButton.Location = new System.Drawing.Point(1261, 341);
            this.btnTestButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTestButton.Name = "btnTestButton";
            this.btnTestButton.Size = new System.Drawing.Size(200, 55);
            this.btnTestButton.TabIndex = 5;
            this.btnTestButton.Text = "Test Me!";
            this.btnTestButton.UseVisualStyleBackColor = true;
            this.btnTestButton.Click += new System.EventHandler(this.btnTestButton_Click);
            // 
            // txtInputBox
            // 
            this.txtInputBox.Location = new System.Drawing.Point(1067, 224);
            this.txtInputBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtInputBox.Name = "txtInputBox";
            this.txtInputBox.Size = new System.Drawing.Size(623, 38);
            this.txtInputBox.TabIndex = 4;
            // 
            // txtOutputBox
            // 
            this.txtOutputBox.Location = new System.Drawing.Point(1067, 423);
            this.txtOutputBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtOutputBox.Multiline = true;
            this.txtOutputBox.Name = "txtOutputBox";
            this.txtOutputBox.Size = new System.Drawing.Size(634, 681);
            this.txtOutputBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 384);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type:\r\n\r\n        \"C\" - AddTestDontion\r\n\r\n        \"RSingle\" - GetSingleDonation\r\n\r" +
    "\n       \"RAll\" - GetDonationsAsString (All)\r\n\r\n        \"U\" - UpdateTestDonation\r" +
    "\n\r\n        \"D\" - DeleteTestDonation\r\n\r\n";
            // 
            // MayasTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2735, 1192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestButton);
            this.Controls.Add(this.txtInputBox);
            this.Controls.Add(this.txtOutputBox);
            this.Name = "MayasTestForm";
            this.Text = "MayasTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestButton;
        private System.Windows.Forms.TextBox txtInputBox;
        private System.Windows.Forms.TextBox txtOutputBox;
        private System.Windows.Forms.Label label1;
    }
}