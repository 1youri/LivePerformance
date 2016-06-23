namespace Live_Performance.Views
{
    partial class RegisterForm
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassCheck = new System.Windows.Forms.Label();
            this.tbPasswordCheck = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblEmailUsed = new System.Windows.Forms.Label();
            this.lblUsernameUsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(154, 117);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(167, 22);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(154, 145);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(167, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(14, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Gebruikersnaam";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblPassCheck
            // 
            this.lblPassCheck.AutoSize = true;
            this.lblPassCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassCheck.Location = new System.Drawing.Point(14, 176);
            this.lblPassCheck.Name = "lblPassCheck";
            this.lblPassCheck.Size = new System.Drawing.Size(134, 16);
            this.lblPassCheck.TabIndex = 5;
            this.lblPassCheck.Text = "Wachtwoord controle";
            // 
            // tbPasswordCheck
            // 
            this.tbPasswordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordCheck.Location = new System.Drawing.Point(154, 173);
            this.tbPasswordCheck.Name = "tbPasswordCheck";
            this.tbPasswordCheck.Size = new System.Drawing.Size(167, 22);
            this.tbPasswordCheck.TabIndex = 4;
            this.tbPasswordCheck.UseSystemPasswordChar = true;
            this.tbPasswordCheck.TextChanged += new System.EventHandler(this.tbPasswordCheck_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(14, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 16);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Voornaam";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(154, 12);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(167, 22);
            this.tbFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(14, 43);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Achternaam";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(154, 40);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(167, 22);
            this.tbLastName.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(14, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(154, 68);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(167, 22);
            this.tbEmail.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(89, 219);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(148, 40);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Registreer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblEmailUsed
            // 
            this.lblEmailUsed.AutoSize = true;
            this.lblEmailUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsed.ForeColor = System.Drawing.Color.Red;
            this.lblEmailUsed.Location = new System.Drawing.Point(151, 93);
            this.lblEmailUsed.Name = "lblEmailUsed";
            this.lblEmailUsed.Size = new System.Drawing.Size(124, 15);
            this.lblEmailUsed.TabIndex = 13;
            this.lblEmailUsed.Text = "Email is al in gebruik!";
            this.lblEmailUsed.Visible = false;
            // 
            // lblUsernameUsed
            // 
            this.lblUsernameUsed.AutoSize = true;
            this.lblUsernameUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameUsed.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameUsed.Location = new System.Drawing.Point(151, 198);
            this.lblUsernameUsed.Name = "lblUsernameUsed";
            this.lblUsernameUsed.Size = new System.Drawing.Size(184, 15);
            this.lblUsernameUsed.TabIndex = 14;
            this.lblUsernameUsed.Text = "Gebruikersnaam is al in gebruik!";
            this.lblUsernameUsed.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 267);
            this.Controls.Add(this.lblUsernameUsed);
            this.Controls.Add(this.lblEmailUsed);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblPassCheck);
            this.Controls.Add(this.tbPasswordCheck);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPassCheck;
        private System.Windows.Forms.TextBox tbPasswordCheck;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmailUsed;
        private System.Windows.Forms.Label lblUsernameUsed;
    }
}