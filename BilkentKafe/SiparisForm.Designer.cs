namespace BilkentKafe
{
    partial class SiparisForm
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
            this.cboUrunler = new System.Windows.Forms.ComboBox();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.btnSiparisİptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.nudUrunEkle = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisDetayEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // cboUrunler
            // 
            this.cboUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrunler.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboUrunler.FormattingEnabled = true;
            this.cboUrunler.Location = new System.Drawing.Point(16, 29);
            this.cboUrunler.Name = "cboUrunler";
            this.cboUrunler.Size = new System.Drawing.Size(121, 23);
            this.cboUrunler.TabIndex = 2;
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(16, 68);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(452, 283);
            this.dgvSiparisDetaylar.TabIndex = 3;
            // 
            // btnSiparisİptal
            // 
            this.btnSiparisİptal.BackColor = System.Drawing.Color.Salmon;
            this.btnSiparisİptal.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisİptal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSiparisİptal.Location = new System.Drawing.Point(492, 239);
            this.btnSiparisİptal.Name = "btnSiparisİptal";
            this.btnSiparisİptal.Size = new System.Drawing.Size(133, 44);
            this.btnSiparisİptal.TabIndex = 4;
            this.btnSiparisİptal.Text = "TÜM SİPARİŞİ İPTAL ET";
            this.btnSiparisİptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.Plum;
            this.btnOdemeAl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdemeAl.Location = new System.Drawing.Point(631, 239);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(127, 44);
            this.btnOdemeAl.TabIndex = 5;
            this.btnOdemeAl.Text = "ÖDEME ALINDI HESABI KAPAT";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnaSayfa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnaSayfa.Location = new System.Drawing.Point(492, 304);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(266, 47);
            this.btnAnaSayfa.TabIndex = 6;
            this.btnAnaSayfa.Text = "<-- ANASAYFA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(489, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(584, 213);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(41, 15);
            this.lblOdemeTutari.TabIndex = 8;
            this.lblOdemeTutari.Text = "0,00 ₺";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblMasaNo.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMasaNo.Location = new System.Drawing.Point(540, 68);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(178, 133);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudUrunEkle
            // 
            this.nudUrunEkle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUrunEkle.Location = new System.Drawing.Point(158, 29);
            this.nudUrunEkle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUrunEkle.Name = "nudUrunEkle";
            this.nudUrunEkle.Size = new System.Drawing.Size(106, 23);
            this.nudUrunEkle.TabIndex = 10;
            this.nudUrunEkle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisDetayEkle
            // 
            this.btnSiparisDetayEkle.BackColor = System.Drawing.Color.LightPink;
            this.btnSiparisDetayEkle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetayEkle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSiparisDetayEkle.Location = new System.Drawing.Point(282, 20);
            this.btnSiparisDetayEkle.Name = "btnSiparisDetayEkle";
            this.btnSiparisDetayEkle.Size = new System.Drawing.Size(132, 36);
            this.btnSiparisDetayEkle.TabIndex = 11;
            this.btnSiparisDetayEkle.Text = "EKLE";
            this.btnSiparisDetayEkle.UseVisualStyleBackColor = false;
            this.btnSiparisDetayEkle.Click += new System.EventHandler(this.btnSiparisDetayEkle_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 373);
            this.Controls.Add(this.btnSiparisDetayEkle);
            this.Controls.Add(this.nudUrunEkle);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisİptal);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.cboUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUrunler;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Button btnSiparisİptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.NumericUpDown nudUrunEkle;
        private System.Windows.Forms.Button btnSiparisDetayEkle;
    }
}