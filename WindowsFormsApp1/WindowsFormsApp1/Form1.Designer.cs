namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDGisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDGEmail = new System.Windows.Forms.TextBox();
            this.txtDGsoyisim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDGTelefon = new System.Windows.Forms.TextBox();
            this.pctDGResim = new System.Windows.Forms.PictureBox();
            this.cmbKisiListesi = new System.Windows.Forms.ComboBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDGResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResimEkle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.pctResim);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.txtEMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKisiListesi);
            this.groupBox2.Controls.Add(this.pctDGResim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDGisim);
            this.groupBox2.Controls.Add(this.txtDGTelefon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDGsoyisim);
            this.groupBox2.Controls.Add(this.txtDGEmail);
            this.groupBox2.Location = new System.Drawing.Point(621, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Görüntüle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(136, 99);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(243, 28);
            this.txtIsim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(136, 133);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(243, 28);
            this.txtSoyisim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(136, 167);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(243, 28);
            this.txtEMail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(136, 201);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(243, 28);
            this.txtTelefon.TabIndex = 3;
            // 
            // pctResim
            // 
            this.pctResim.Location = new System.Drawing.Point(398, 45);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(187, 194);
            this.pctResim.TabIndex = 5;
            this.pctResim.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(136, 245);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(243, 38);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(398, 245);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(187, 38);
            this.btnResimEkle.TabIndex = 6;
            this.btnResimEkle.Text = "RESİM EKLE";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "İsim";
            // 
            // txtDGisim
            // 
            this.txtDGisim.Location = new System.Drawing.Point(121, 143);
            this.txtDGisim.Name = "txtDGisim";
            this.txtDGisim.Size = new System.Drawing.Size(243, 28);
            this.txtDGisim.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "E-Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Soyisim";
            // 
            // txtDGEmail
            // 
            this.txtDGEmail.Location = new System.Drawing.Point(121, 211);
            this.txtDGEmail.Name = "txtDGEmail";
            this.txtDGEmail.Size = new System.Drawing.Size(243, 28);
            this.txtDGEmail.TabIndex = 3;
            // 
            // txtDGsoyisim
            // 
            this.txtDGsoyisim.Location = new System.Drawing.Point(121, 177);
            this.txtDGsoyisim.Name = "txtDGsoyisim";
            this.txtDGsoyisim.Size = new System.Drawing.Size(243, 28);
            this.txtDGsoyisim.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon";
            // 
            // txtDGTelefon
            // 
            this.txtDGTelefon.Location = new System.Drawing.Point(121, 245);
            this.txtDGTelefon.Name = "txtDGTelefon";
            this.txtDGTelefon.Size = new System.Drawing.Size(243, 28);
            this.txtDGTelefon.TabIndex = 3;
            // 
            // pctDGResim
            // 
            this.pctDGResim.Location = new System.Drawing.Point(383, 89);
            this.pctDGResim.Name = "pctDGResim";
            this.pctDGResim.Size = new System.Drawing.Size(187, 194);
            this.pctDGResim.TabIndex = 5;
            this.pctDGResim.TabStop = false;
            // 
            // cmbKisiListesi
            // 
            this.cmbKisiListesi.FormattingEnabled = true;
            this.cmbKisiListesi.Location = new System.Drawing.Point(18, 45);
            this.cmbKisiListesi.Name = "cmbKisiListesi";
            this.cmbKisiListesi.Size = new System.Drawing.Size(541, 29);
            this.cmbKisiListesi.TabIndex = 7;
            this.cmbKisiListesi.SelectedIndexChanged += new System.EventHandler(this.cmbKisiListesi_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Büyük Datalar İle Çalışmak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDGResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.PictureBox pctResim;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKisiListesi;
        private System.Windows.Forms.PictureBox pctDGResim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDGisim;
        private System.Windows.Forms.TextBox txtDGTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDGsoyisim;
        private System.Windows.Forms.TextBox txtDGEmail;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

