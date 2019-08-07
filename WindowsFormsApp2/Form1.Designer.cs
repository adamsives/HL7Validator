namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnSelectHL7File = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectHL7File
            // 
            this.btnSelectHL7File.Location = new System.Drawing.Point(196, 83);
            this.btnSelectHL7File.Name = "btnSelectHL7File";
            this.btnSelectHL7File.Size = new System.Drawing.Size(75, 23);
            this.btnSelectHL7File.TabIndex = 0;
            this.btnSelectHL7File.Text = "Select .hl7 file";
            this.btnSelectHL7File.UseVisualStyleBackColor = true;
            this.btnSelectHL7File.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSelectHL7File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectHL7File;
    }
}

