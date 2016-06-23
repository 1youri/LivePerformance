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
            this.btnExport = new System.Windows.Forms.Button();
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
            this.lvHuurContracten.FullRowSelect = true;
            this.lvHuurContracten.GridLines = true;
            this.lvHuurContracten.Location = new System.Drawing.Point(178, 12);
            this.lvHuurContracten.Name = "lvHuurContracten";
            this.lvHuurContracten.Size = new System.Drawing.Size(387, 323);
            this.lvHuurContracten.TabIndex = 0;
            this.lvHuurContracten.UseCompatibleStateImageBehavior = false;
            this.lvHuurContracten.View = System.Windows.Forms.View.Details;
            this.lvHuurContracten.SelectedIndexChanged += new System.EventHandler(this.lvHuurContracten_SelectedIndexChanged);
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
            this.btnVoorspelling.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(568, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(227, 24);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Informatie Huurcontract";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(572, 50);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(79, 13);
            this.lblNaam.TabIndex = 4;
            this.lblNaam.Text = "Naam Huurder:";
            // 
            // lblDatumVan
            // 
            this.lblDatumVan.AutoSize = true;
            this.lblDatumVan.Location = new System.Drawing.Point(572, 73);
            this.lblDatumVan.Name = "lblDatumVan";
            this.lblDatumVan.Size = new System.Drawing.Size(72, 13);
            this.lblDatumVan.TabIndex = 5;
            this.lblDatumVan.Text = "Vanaf Datum:";
            // 
            // lblDatumTot
            // 
            this.lblDatumTot.AutoSize = true;
            this.lblDatumTot.Location = new System.Drawing.Point(572, 97);
            this.lblDatumTot.Name = "lblDatumTot";
            this.lblDatumTot.Size = new System.Drawing.Size(60, 13);
            this.lblDatumTot.TabIndex = 6;
            this.lblDatumTot.Text = "Tot Datum:";
            // 
            // lbBoten
            // 
            this.lbBoten.FormattingEnabled = true;
            this.lbBoten.Location = new System.Drawing.Point(572, 136);
            this.lbBoten.Name = "lbBoten";
            this.lbBoten.Size = new System.Drawing.Size(192, 147);
            this.lbBoten.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gekozen boten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(767, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gekozen bijkomende artikelen:";
            // 
            // lbArtiks
            // 
            this.lbArtiks.FormattingEnabled = true;
            this.lbArtiks.Location = new System.Drawing.Point(770, 136);
            this.lbArtiks.Name = "lbArtiks";
            this.lbArtiks.Size = new System.Drawing.Size(146, 147);
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
            this.btnZeilGame.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(770, 288);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(146, 46);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Huurcontract Exporteren";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnExtraArtik.Visible = false;
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
            this.btnVloot.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 351);
            this.Controls.Add(this.btnVloot);
            this.Controls.Add(this.btnExtraArtik);
            this.Controls.Add(this.btnExport);
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
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExtraArtik;
        private System.Windows.Forms.Button btnVloot;
        private System.Windows.Forms.ColumnHeader HuurCode;
    }
}