namespace Live_Performance.Views
{
    partial class ExceptionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbDetails = new System.Windows.Forms.CheckBox();
            this.tbException = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(480, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Er was een probleem met de applicatie, probeer het opnieuw of neem contact op met" +
    " een administrator.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "details:";
            // 
            // cbDetails
            // 
            this.cbDetails.AutoSize = true;
            this.cbDetails.Location = new System.Drawing.Point(62, 69);
            this.cbDetails.Name = "cbDetails";
            this.cbDetails.Size = new System.Drawing.Size(15, 14);
            this.cbDetails.TabIndex = 2;
            this.cbDetails.UseVisualStyleBackColor = true;
            this.cbDetails.CheckedChanged += new System.EventHandler(this.cbDetails_CheckedChanged);
            // 
            // tbException
            // 
            this.tbException.Location = new System.Drawing.Point(9, 85);
            this.tbException.Multiline = true;
            this.tbException.Name = "tbException";
            this.tbException.ReadOnly = true;
            this.tbException.Size = new System.Drawing.Size(463, 186);
            this.tbException.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Throw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbException);
            this.Controls.Add(this.cbDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExceptionForm";
            this.Text = "ExceptionForm";
            this.Load += new System.EventHandler(this.ExceptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDetails;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.Button button1;
    }
}