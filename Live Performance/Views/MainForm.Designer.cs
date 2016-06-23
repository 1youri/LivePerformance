namespace Live_Performance.Views
{
    partial class MainForm
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
            this.lvHuurContracten = new System.Windows.Forms.ListView();
            this.HuurCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHuurder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewHuurContract = new System.Windows.Forms.Button();
            this.btnVoorspelling = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblDatumVan = new System.Windows.Forms.Label();
            this.lblDatumTot = new System.Windows.Forms.Label();
            this.lbBoten = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbArtiks = new System.Windows.Forms.ListBox();
            this.btnZeilGame = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExtraArtik = new System.Windows.Forms.Button();
            this.btnVloot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvHuurContracten
            // 
            this.lvHuurContracten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HuurCode,
            this.chHuurder,
            this.chFrom,
            this.chTo});
            this.lvHuurContracten.Location = new System.Drawing.Point(178, 12);
            this.lvHuurContracten.Name = "lvHuurContracten";
            this.lvHuurContracten.Size = new System.Drawing.Size(387, 323);
            this.lvHuurContracten.TabIndex = 0;
            this.lvHuurContracten.UseCompatibleStateImageBehavior = false;
            this.lvHuurContracten.View = System.Windows.Forms.View.Details;
            // 
            // HuurCode
            // 
            this.HuurCode.Text = "#";
            this.HuurCode.Width = 30;
            // 
            // chHuurder
            // 
            this.chHuurder.Text = "Huurder";
            this.chHuurder.Width = 150;
            // 
            // chFrom
            // 
            this.chFrom.Text = "Vanaf";
            this.chFrom.Width = 100;
            // 
            // chTo
            // 
            this.chTo.Text = "Tot";
            this.chTo.Width = 100;
            // 
            // btnNewHuurContract
            // 
            this.btnNewHuurContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHuurContract.Location = new System.Drawing.Point(12, 12);
            this.btnNewHuurContract.Name = "btnNewHuurContract";
            this.btnNewHuurContract.Size = new System.Drawing.Size(146, 46);
            this.btnNewHuurContract.TabIndex = 1;
            this.btnNewHuurContract.Text = "Nieuw Huurcontract";
            this.btnNewHuurContract.UseVisualStyleBackColor = true;
            this.btnNewHuurContract.Click += new System.EventHandler(this.btnNewHuurContract_Click);
            // 
            // btnVoorspelling
            // 
            this.btnVoorspelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoorspelling.Location = new System.Drawing.Point(12, 64);
            this.btnVoorspelling.Name = "btnVoorspelling";
            this.btnVoorspelling.Size = new System.Drawing.Size(146, 46);
            this.btnVoorspelling.TabIndex = 2;
            this.btnVoorspelling.Text = "Voorspelling gevoelstemperatuur";
            this.btnVoorspelling.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(606, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(227, 24);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Informatie Huurcontract";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(610, 50);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(79, 13);
            this.lblNaam.TabIndex = 4;
            this.lblNaam.Text = "Naam Huurder:";
            // 
            // lblDatumVan
            // 
            this.lblDatumVan.AutoSize = true;
            this.lblDatumVan.Location = new System.Drawing.Point(610, 73);
            this.lblDatumVan.Name = "lblDatumVan";
            this.lblDatumVan.Size = new System.Drawing.Size(72, 13);
            this.lblDatumVan.TabIndex = 5;
            this.lblDatumVan.Text = "Vanaf Datum:";
            // 
            // lblDatumTot
            // 
            this.lblDatumTot.AutoSize = true;
            this.lblDatumTot.Location = new System.Drawing.Point(610, 97);
            this.lblDatumTot.Name = "lblDatumTot";
            this.lblDatumTot.Size = new System.Drawing.Size(60, 13);
            this.lblDatumTot.TabIndex = 6;
            this.lblDatumTot.Text = "Tot Datum:";
            // 
            // lbBoten
            // 
            this.lbBoten.FormattingEnabled = true;
            this.lbBoten.Location = new System.Drawing.Point(613, 136);
            this.lbBoten.Name = "lbBoten";
            this.lbBoten.Size = new System.Drawing.Size(147, 147);
            this.lbBoten.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gekozen boten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gekozen bijkomende artikelen:";
            // 
            // lbArtiks
            // 
            this.lbArtiks.FormattingEnabled = true;
            this.lbArtiks.Location = new System.Drawing.Point(766, 136);
            this.lbArtiks.Name = "lbArtiks";
            this.lbArtiks.Size = new System.Drawing.Size(147, 147);
            this.lbArtiks.TabIndex = 9;
            // 
            // btnZeilGame
            // 
            this.btnZeilGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeilGame.Location = new System.Drawing.Point(12, 120);
            this.btnZeilGame.Name = "btnZeilGame";
            this.btnZeilGame.Size = new System.Drawing.Size(146, 46);
            this.btnZeilGame.TabIndex = 11;
            this.btnZeilGame.Text = "Zeil-Game Spelen";
            this.btnZeilGame.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(766, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Huurcontract Exporteren";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnExtraArtik
            // 
            this.btnExtraArtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraArtik.Location = new System.Drawing.Point(12, 289);
            this.btnExtraArtik.Name = "btnExtraArtik";
            this.btnExtraArtik.Size = new System.Drawing.Size(146, 46);
            this.btnExtraArtik.TabIndex = 13;
            this.btnExtraArtik.Text = "Bijkomende artikelen aanpassen";
            this.btnExtraArtik.UseVisualStyleBackColor = true;
            // 
            // btnVloot
            // 
            this.btnVloot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVloot.Location = new System.Drawing.Point(12, 237);
            this.btnVloot.Name = "btnVloot";
            this.btnVloot.Size = new System.Drawing.Size(146, 46);
            this.btnVloot.TabIndex = 14;
            this.btnVloot.Text = "Vloot aanpassen";
            this.btnVloot.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 351);
            this.Controls.Add(this.btnVloot);
            this.Controls.Add(this.btnExtraArtik);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnZeilGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbArtiks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBoten);
            this.Controls.Add(this.lblDatumTot);
            this.Controls.Add(this.lblDatumVan);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnVoorspelling);
            this.Controls.Add(this.btnNewHuurContract);
            this.Controls.Add(this.lvHuurContracten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(944, 390);
            this.MinimumSize = new System.Drawing.Size(944, 390);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHuurContracten;
        private System.Windows.Forms.ColumnHeader chFrom;
        private System.Windows.Forms.ColumnHeader chTo;
        internal System.Windows.Forms.ColumnHeader chHuurder;
        private System.Windows.Forms.Button btnNewHuurContract;
        private System.Windows.Forms.Button btnVoorspelling;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblDatumVan;
        private System.Windows.Forms.Label lblDatumTot;
        private System.Windows.Forms.ListBox lbBoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbArtiks;
        private System.Windows.Forms.Button btnZeilGame;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExtraArtik;
        private System.Windows.Forms.Button btnVloot;
        private System.Windows.Forms.ColumnHeader HuurCode;
    }
}