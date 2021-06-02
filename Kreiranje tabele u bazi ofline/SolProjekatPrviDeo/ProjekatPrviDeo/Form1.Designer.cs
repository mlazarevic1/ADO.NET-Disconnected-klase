
namespace ProjekatPrviDeo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgKupci = new System.Windows.Forms.DataGridView();
            this.dgFakture = new System.Windows.Forms.DataGridView();
            this.dgFaktureStavke = new System.Windows.Forms.DataGridView();
            this.gBKupac = new System.Windows.Forms.GroupBox();
            this.btnUnesiKupca = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtNazivKupca = new System.Windows.Forms.TextBox();
            this.lblNazivKupca = new System.Windows.Forms.Label();
            this.gBFaktura = new System.Windows.Forms.GroupBox();
            this.btnUnesiFakturu = new System.Windows.Forms.Button();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.cboKupacID = new System.Windows.Forms.ComboBox();
            this.gBFaktureStavke = new System.Windows.Forms.GroupBox();
            this.btnUnesiFakturuIStavku = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCenaStavke = new System.Windows.Forms.Label();
            this.txtNazivStavke = new System.Windows.Forms.TextBox();
            this.lblNazivStavke = new System.Windows.Forms.Label();
            this.lblFakturaID = new System.Windows.Forms.Label();
            this.cboFakturaID = new System.Windows.Forms.ComboBox();
            this.btnSaveXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktureStavke)).BeginInit();
            this.gBKupac.SuspendLayout();
            this.gBFaktura.SuspendLayout();
            this.gBFaktureStavke.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKupci
            // 
            this.dgKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKupci.Location = new System.Drawing.Point(38, 255);
            this.dgKupci.Name = "dgKupci";
            this.dgKupci.RowTemplate.Height = 25;
            this.dgKupci.Size = new System.Drawing.Size(489, 171);
            this.dgKupci.TabIndex = 0;
            // 
            // dgFakture
            // 
            this.dgFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFakture.Location = new System.Drawing.Point(552, 255);
            this.dgFakture.Name = "dgFakture";
            this.dgFakture.RowTemplate.Height = 25;
            this.dgFakture.Size = new System.Drawing.Size(536, 171);
            this.dgFakture.TabIndex = 1;
            // 
            // dgFaktureStavke
            // 
            this.dgFaktureStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFaktureStavke.Location = new System.Drawing.Point(38, 477);
            this.dgFaktureStavke.Name = "dgFaktureStavke";
            this.dgFaktureStavke.RowTemplate.Height = 25;
            this.dgFaktureStavke.Size = new System.Drawing.Size(1050, 150);
            this.dgFaktureStavke.TabIndex = 2;
            // 
            // gBKupac
            // 
            this.gBKupac.Controls.Add(this.btnUnesiKupca);
            this.gBKupac.Controls.Add(this.txtAdresa);
            this.gBKupac.Controls.Add(this.lblAdresa);
            this.gBKupac.Controls.Add(this.txtNazivKupca);
            this.gBKupac.Controls.Add(this.lblNazivKupca);
            this.gBKupac.Location = new System.Drawing.Point(41, 37);
            this.gBKupac.Name = "gBKupac";
            this.gBKupac.Size = new System.Drawing.Size(250, 185);
            this.gBKupac.TabIndex = 3;
            this.gBKupac.TabStop = false;
            this.gBKupac.Text = "Kupac";
            // 
            // btnUnesiKupca
            // 
            this.btnUnesiKupca.Location = new System.Drawing.Point(98, 141);
            this.btnUnesiKupca.Name = "btnUnesiKupca";
            this.btnUnesiKupca.Size = new System.Drawing.Size(126, 38);
            this.btnUnesiKupca.TabIndex = 4;
            this.btnUnesiKupca.Text = "Unesi kupca";
            this.btnUnesiKupca.UseVisualStyleBackColor = true;
            this.btnUnesiKupca.Click += new System.EventHandler(this.btnUnesiKupca_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(89, 101);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(145, 23);
            this.txtAdresa.TabIndex = 3;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdresa.Location = new System.Drawing.Point(7, 102);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(54, 19);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtNazivKupca
            // 
            this.txtNazivKupca.Location = new System.Drawing.Point(89, 49);
            this.txtNazivKupca.Name = "txtNazivKupca";
            this.txtNazivKupca.Size = new System.Drawing.Size(145, 23);
            this.txtNazivKupca.TabIndex = 1;
            // 
            // lblNazivKupca
            // 
            this.lblNazivKupca.AutoSize = true;
            this.lblNazivKupca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNazivKupca.Location = new System.Drawing.Point(7, 50);
            this.lblNazivKupca.Name = "lblNazivKupca";
            this.lblNazivKupca.Size = new System.Drawing.Size(85, 19);
            this.lblNazivKupca.TabIndex = 0;
            this.lblNazivKupca.Text = "Naziv kupca:";
            // 
            // gBFaktura
            // 
            this.gBFaktura.Controls.Add(this.btnUnesiFakturu);
            this.gBFaktura.Controls.Add(this.dtDatum);
            this.gBFaktura.Controls.Add(this.lblDatum);
            this.gBFaktura.Controls.Add(this.lblCombo);
            this.gBFaktura.Controls.Add(this.cboKupacID);
            this.gBFaktura.Location = new System.Drawing.Point(340, 37);
            this.gBFaktura.Name = "gBFaktura";
            this.gBFaktura.Size = new System.Drawing.Size(313, 185);
            this.gBFaktura.TabIndex = 5;
            this.gBFaktura.TabStop = false;
            this.gBFaktura.Text = "Faktura";
            // 
            // btnUnesiFakturu
            // 
            this.btnUnesiFakturu.Location = new System.Drawing.Point(60, 139);
            this.btnUnesiFakturu.Name = "btnUnesiFakturu";
            this.btnUnesiFakturu.Size = new System.Drawing.Size(155, 40);
            this.btnUnesiFakturu.TabIndex = 10;
            this.btnUnesiFakturu.Text = "Unesi fakturu";
            this.btnUnesiFakturu.UseVisualStyleBackColor = true;
            this.btnUnesiFakturu.Click += new System.EventHandler(this.btnUnesiFakturu_Click);
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(107, 70);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 23);
            this.dtDatum.TabIndex = 9;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatum.Location = new System.Drawing.Point(16, 74);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(54, 19);
            this.lblDatum.TabIndex = 8;
            this.lblDatum.Text = "Datum:";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCombo.Location = new System.Drawing.Point(16, 36);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(67, 19);
            this.lblCombo.TabIndex = 7;
            this.lblCombo.Text = "Kupac ID:";
            // 
            // cboKupacID
            // 
            this.cboKupacID.FormattingEnabled = true;
            this.cboKupacID.Location = new System.Drawing.Point(107, 35);
            this.cboKupacID.Name = "cboKupacID";
            this.cboKupacID.Size = new System.Drawing.Size(121, 23);
            this.cboKupacID.TabIndex = 6;
            // 
            // gBFaktureStavke
            // 
            this.gBFaktureStavke.Controls.Add(this.btnUnesiFakturuIStavku);
            this.gBFaktureStavke.Controls.Add(this.txtCena);
            this.gBFaktureStavke.Controls.Add(this.lblCenaStavke);
            this.gBFaktureStavke.Controls.Add(this.txtNazivStavke);
            this.gBFaktureStavke.Controls.Add(this.lblNazivStavke);
            this.gBFaktureStavke.Controls.Add(this.lblFakturaID);
            this.gBFaktureStavke.Controls.Add(this.cboFakturaID);
            this.gBFaktureStavke.Location = new System.Drawing.Point(691, 39);
            this.gBFaktureStavke.Name = "gBFaktureStavke";
            this.gBFaktureStavke.Size = new System.Drawing.Size(292, 183);
            this.gBFaktureStavke.TabIndex = 6;
            this.gBFaktureStavke.TabStop = false;
            this.gBFaktureStavke.Text = "Fakture i stavke";
            // 
            // btnUnesiFakturuIStavku
            // 
            this.btnUnesiFakturuIStavku.Location = new System.Drawing.Point(58, 139);
            this.btnUnesiFakturuIStavku.Name = "btnUnesiFakturuIStavku";
            this.btnUnesiFakturuIStavku.Size = new System.Drawing.Size(133, 38);
            this.btnUnesiFakturuIStavku.TabIndex = 13;
            this.btnUnesiFakturuIStavku.Text = "Unesi fakturu i stavku";
            this.btnUnesiFakturuIStavku.UseVisualStyleBackColor = true;
            this.btnUnesiFakturuIStavku.Click += new System.EventHandler(this.btnUnesiFakturuIStavku_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(107, 102);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(121, 23);
            this.txtCena.TabIndex = 12;
            // 
            // lblCenaStavke
            // 
            this.lblCenaStavke.AutoSize = true;
            this.lblCenaStavke.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCenaStavke.Location = new System.Drawing.Point(13, 103);
            this.lblCenaStavke.Name = "lblCenaStavke";
            this.lblCenaStavke.Size = new System.Drawing.Size(86, 19);
            this.lblCenaStavke.TabIndex = 11;
            this.lblCenaStavke.Text = "Cena stavke:";
            // 
            // txtNazivStavke
            // 
            this.txtNazivStavke.Location = new System.Drawing.Point(107, 67);
            this.txtNazivStavke.Name = "txtNazivStavke";
            this.txtNazivStavke.Size = new System.Drawing.Size(121, 23);
            this.txtNazivStavke.TabIndex = 10;
            // 
            // lblNazivStavke
            // 
            this.lblNazivStavke.AutoSize = true;
            this.lblNazivStavke.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNazivStavke.Location = new System.Drawing.Point(13, 68);
            this.lblNazivStavke.Name = "lblNazivStavke";
            this.lblNazivStavke.Size = new System.Drawing.Size(88, 19);
            this.lblNazivStavke.TabIndex = 9;
            this.lblNazivStavke.Text = "Naziv stavke:";
            // 
            // lblFakturaID
            // 
            this.lblFakturaID.AutoSize = true;
            this.lblFakturaID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFakturaID.Location = new System.Drawing.Point(13, 31);
            this.lblFakturaID.Name = "lblFakturaID";
            this.lblFakturaID.Size = new System.Drawing.Size(76, 19);
            this.lblFakturaID.TabIndex = 8;
            this.lblFakturaID.Text = "Faktura ID:";
            // 
            // cboFakturaID
            // 
            this.cboFakturaID.FormattingEnabled = true;
            this.cboFakturaID.Location = new System.Drawing.Point(107, 27);
            this.cboFakturaID.Name = "cboFakturaID";
            this.cboFakturaID.Size = new System.Drawing.Size(121, 23);
            this.cboFakturaID.TabIndex = 7;
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(319, 643);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(388, 81);
            this.btnSaveXML.TabIndex = 7;
            this.btnSaveXML.Text = "Sacuvaj u XML fajl";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 736);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.gBFaktureStavke);
            this.Controls.Add(this.gBFaktura);
            this.Controls.Add(this.gBKupac);
            this.Controls.Add(this.dgFaktureStavke);
            this.Controls.Add(this.dgFakture);
            this.Controls.Add(this.dgKupci);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktureStavke)).EndInit();
            this.gBKupac.ResumeLayout(false);
            this.gBKupac.PerformLayout();
            this.gBFaktura.ResumeLayout(false);
            this.gBFaktura.PerformLayout();
            this.gBFaktureStavke.ResumeLayout(false);
            this.gBFaktureStavke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKupci;
        private System.Windows.Forms.DataGridView dgFakture;
        private System.Windows.Forms.DataGridView dgFaktureStavke;
        private System.Windows.Forms.GroupBox gBKupac;
        private System.Windows.Forms.Label lblNazivKupca;
        private System.Windows.Forms.Button btnUnesiKupca;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtNazivKupca;
        private System.Windows.Forms.GroupBox gBFaktura;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.ComboBox cboKupacID;
        private System.Windows.Forms.Button btnUnesiFakturu;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox gBFaktureStavke;
        private System.Windows.Forms.Label lblFakturaID;
        private System.Windows.Forms.ComboBox cboFakturaID;
        private System.Windows.Forms.Label lblNazivStavke;
        private System.Windows.Forms.TextBox txtNazivStavke;
        private System.Windows.Forms.Button btnUnesiFakturuIStavku;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCenaStavke;
        private System.Windows.Forms.Button btnSaveXML;
    }
}

