namespace HeirsProperty
{
    partial class HPTestForm
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
            this.txtOutputBox = new System.Windows.Forms.TextBox();
            this.txtInputBox = new System.Windows.Forms.TextBox();
            this.btnTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutputBox
            // 
            this.txtOutputBox.Location = new System.Drawing.Point(180, 143);
            this.txtOutputBox.Multiline = true;
            this.txtOutputBox.Name = "txtOutputBox";
            this.txtOutputBox.Size = new System.Drawing.Size(236, 84);
            this.txtOutputBox.TabIndex = 0;
            // 
            // txtInputBox
            // 
            this.txtInputBox.Location = new System.Drawing.Point(180, 70);
            this.txtInputBox.Name = "txtInputBox";
            this.txtInputBox.Size = new System.Drawing.Size(236, 20);
            this.txtInputBox.TabIndex = 1;
            this.txtInputBox.TextChanged += new System.EventHandler(this.txtInputBox_TextChanged);
            // 
            // btnTestButton
            // 
            this.btnTestButton.Location = new System.Drawing.Point(180, 114);
            this.btnTestButton.Name = "btnTestButton";
            this.btnTestButton.Size = new System.Drawing.Size(75, 23);
            this.btnTestButton.TabIndex = 2;
            this.btnTestButton.Text = "Test Me!";
            this.btnTestButton.UseVisualStyleBackColor = true;
            this.btnTestButton.Click += new System.EventHandler(this.btnTestButton_Click);
            // 
            // HPTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestButton);
            this.Controls.Add(this.txtInputBox);
            this.Controls.Add(this.txtOutputBox);
            this.Name = "HPTestForm";
            this.Text = "HPTestForm";
            this.Load += new System.EventHandler(this.HPTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutputBox;
        private System.Windows.Forms.TextBox txtInputBox;
        private System.Windows.Forms.Button btnTestButton;
    }
}