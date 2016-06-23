namespace Live_Performance.Views
{
    partial class CreateContractForm
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lbBotenLinks = new System.Windows.Forms.ListBox();
            this.lbArtLinks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbArtRechts = new System.Windows.Forms.ListBox();
            this.lbBotenRechts = new System.Windows.Forms.ListBox();
            this.btnBootRight = new System.Windows.Forms.Button();
            this.btnBootLeft = new System.Windows.Forms.Button();
            this.btnArtLeft = new System.Windows.Forms.Button();
            this.btnArtRight = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAanmaken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(12, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(197, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(12, 86);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(197, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(12, 12);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(56, 20);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Vanaf:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(12, 63);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 20);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Tot:";
            // 
            // lbBotenLinks
            // 
            this.lbBotenLinks.FormattingEnabled = true;
            this.lbBotenLinks.Location = new System.Drawing.Point(243, 35);
            this.lbBotenLinks.Name = "lbBotenLinks";
            this.lbBotenLinks.Size = new System.Drawing.Size(220, 186);
            this.lbBotenLinks.TabIndex = 4;
            this.lbBotenLinks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbBotenLinks_MouseDoubleClick);
            // 
            // lbArtLinks
            // 
            this.lbArtLinks.FormattingEnabled = true;
            this.lbArtLinks.Location = new System.Drawing.Point(243, 258);
            this.lbArtLinks.Name = "lbArtLinks";
            this.lbArtLinks.Size = new System.Drawing.Size(220, 147);
            this.lbArtLinks.TabIndex = 5;
            this.lbArtLinks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbArtLinks_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Beschikbare Boten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beschikbare exrtra artikelen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gekozen exrtra artikelen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gekozen Boten";
            // 
            // lbArtRechts
            // 
            this.lbArtRechts.FormattingEnabled = true;
            this.lbArtRechts.Location = new System.Drawing.Point(504, 258);
            this.lbArtRechts.Name = "lbArtRechts";
            this.lbArtRechts.Size = new System.Drawing.Size(220, 147);
            this.lbArtRechts.TabIndex = 9;
            this.lbArtRechts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbArtRechts_MouseDoubleClick);
            // 
            // lbBotenRechts
            // 
            this.lbBotenRechts.FormattingEnabled = true;
            this.lbBotenRechts.Location = new System.Drawing.Point(504, 35);
            this.lbBotenRechts.Name = "lbBotenRechts";
            this.lbBotenRechts.Size = new System.Drawing.Size(220, 186);
            this.lbBotenRechts.TabIndex = 8;
            this.lbBotenRechts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbBotenRechts_MouseDoubleClick);
            // 
            // btnBootRight
            // 
            this.btnBootRight.Location = new System.Drawing.Point(470, 82);
            this.btnBootRight.Name = "btnBootRight";
            this.btnBootRight.Size = new System.Drawing.Size(28, 23);
            this.btnBootRight.TabIndex = 12;
            this.btnBootRight.Text = ">";
            this.btnBootRight.UseVisualStyleBackColor = true;
            this.btnBootRight.Click += new System.EventHandler(this.btnBootRight_Click);
            // 
            // btnBootLeft
            // 
            this.btnBootLeft.Location = new System.Drawing.Point(469, 111);
            this.btnBootLeft.Name = "btnBootLeft";
            this.btnBootLeft.Size = new System.Drawing.Size(28, 23);
            this.btnBootLeft.TabIndex = 13;
            this.btnBootLeft.Text = "<";
            this.btnBootLeft.UseVisualStyleBackColor = true;
            this.btnBootLeft.Click += new System.EventHandler(this.btnBootLeft_Click_1);
            // 
            // btnArtLeft
            // 
            this.btnArtLeft.Location = new System.Drawing.Point(469, 330);
            this.btnArtLeft.Name = "btnArtLeft";
            this.btnArtLeft.Size = new System.Drawing.Size(28, 23);
            this.btnArtLeft.TabIndex = 15;
            this.btnArtLeft.Text = "<";
            this.btnArtLeft.UseVisualStyleBackColor = true;
            this.btnArtLeft.Click += new System.EventHandler(this.btnArtLeft_Click);
            // 
            // btnArtRight
            // 
            this.btnArtRight.Location = new System.Drawing.Point(470, 301);
            this.btnArtRight.Name = "btnArtRight";
            this.btnArtRight.Size = new System.Drawing.Size(28, 23);
            this.btnArtRight.TabIndex = 14;
            this.btnArtRight.Text = ">";
            this.btnArtRight.UseVisualStyleBackColor = true;
            this.btnArtRight.Click += new System.EventHandler(this.btnArtRight_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 37);
            this.button5.TabIndex = 16;
            this.button5.Text = "Mogelijke meren inkijken";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Budget";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 201);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "€";
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanmaken.Location = new System.Drawing.Point(12, 359);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(197, 45);
            this.btnAanmaken.TabIndex = 20;
            this.btnAanmaken.Text = "HuurContract Aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // CreateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnArtLeft);
            this.Controls.Add(this.btnArtRight);
            this.Controls.Add(this.btnBootLeft);
            this.Controls.Add(this.btnBootRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbArtRechts);
            this.Controls.Add(this.lbBotenRechts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbArtLinks);
            this.Controls.Add(this.lbBotenLinks);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "CreateContractForm";
            this.Text = "CreateContractForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ListBox lbBotenLinks;
        private System.Windows.Forms.ListBox lbArtLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbArtRechts;
        private System.Windows.Forms.ListBox lbBotenRechts;
        private System.Windows.Forms.Button btnBootRight;
        private System.Windows.Forms.Button btnBootLeft;
        private System.Windows.Forms.Button btnArtLeft;
        private System.Windows.Forms.Button btnArtRight;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAanmaken;
    }
}