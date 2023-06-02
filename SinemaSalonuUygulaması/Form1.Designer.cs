namespace SinemaSalonuUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBiletSat = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxİndirim = new System.Windows.Forms.CheckBox();
            this.buttonBiletİptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSalonAdı = new System.Windows.Forms.TextBox();
            this.textBoxKoltuSayı = new System.Windows.Forms.TextBox();
            this.buttonSinema = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBoşKoltuk = new System.Windows.Forms.Button();
            this.buttonBakiye = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBiletSat
            // 
            this.buttonBiletSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBiletSat.Location = new System.Drawing.Point(15, 48);
            this.buttonBiletSat.Name = "buttonBiletSat";
            this.buttonBiletSat.Size = new System.Drawing.Size(87, 58);
            this.buttonBiletSat.TabIndex = 0;
            this.buttonBiletSat.Text = "Bilet Sat";
            this.buttonBiletSat.UseVisualStyleBackColor = true;
            this.buttonBiletSat.Click += new System.EventHandler(this.buttonBiletSat_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(26, 31);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 25);
            this.labelInfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxİndirim);
            this.groupBox1.Controls.Add(this.buttonBiletİptal);
            this.groupBox1.Controls.Add(this.buttonBiletSat);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ-İPTAL";
            // 
            // checkBoxİndirim
            // 
            this.checkBoxİndirim.AutoSize = true;
            this.checkBoxİndirim.Location = new System.Drawing.Point(22, 19);
            this.checkBoxİndirim.Name = "checkBoxİndirim";
            this.checkBoxİndirim.Size = new System.Drawing.Size(60, 17);
            this.checkBoxİndirim.TabIndex = 1;
            this.checkBoxİndirim.Text = "İndirimli";
            this.checkBoxİndirim.UseVisualStyleBackColor = true;
            // 
            // buttonBiletİptal
            // 
            this.buttonBiletİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBiletİptal.Location = new System.Drawing.Point(123, 48);
            this.buttonBiletİptal.Name = "buttonBiletİptal";
            this.buttonBiletİptal.Size = new System.Drawing.Size(94, 58);
            this.buttonBiletİptal.TabIndex = 0;
            this.buttonBiletİptal.Text = "Bilet İptal";
            this.buttonBiletİptal.UseVisualStyleBackColor = true;
            this.buttonBiletİptal.Click += new System.EventHandler(this.buttonBiletİptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Koltuk Sayısı:";
            // 
            // textBoxSalonAdı
            // 
            this.textBoxSalonAdı.Location = new System.Drawing.Point(135, 31);
            this.textBoxSalonAdı.Name = "textBoxSalonAdı";
            this.textBoxSalonAdı.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalonAdı.TabIndex = 3;
            // 
            // textBoxKoltuSayı
            // 
            this.textBoxKoltuSayı.Location = new System.Drawing.Point(135, 67);
            this.textBoxKoltuSayı.Name = "textBoxKoltuSayı";
            this.textBoxKoltuSayı.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoltuSayı.TabIndex = 3;
            // 
            // buttonSinema
            // 
            this.buttonSinema.Location = new System.Drawing.Point(276, 31);
            this.buttonSinema.Name = "buttonSinema";
            this.buttonSinema.Size = new System.Drawing.Size(220, 56);
            this.buttonSinema.TabIndex = 0;
            this.buttonSinema.Text = "Sinema Oluştur";
            this.buttonSinema.UseVisualStyleBackColor = true;
            this.buttonSinema.Click += new System.EventHandler(this.buttonSinema_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBoşKoltuk);
            this.groupBox2.Controls.Add(this.buttonBakiye);
            this.groupBox2.Location = new System.Drawing.Point(276, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAPOR";
            // 
            // buttonBoşKoltuk
            // 
            this.buttonBoşKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoşKoltuk.Location = new System.Drawing.Point(120, 32);
            this.buttonBoşKoltuk.Name = "buttonBoşKoltuk";
            this.buttonBoşKoltuk.Size = new System.Drawing.Size(94, 58);
            this.buttonBoşKoltuk.TabIndex = 0;
            this.buttonBoşKoltuk.Text = "Boş Koltuk";
            this.buttonBoşKoltuk.UseVisualStyleBackColor = true;
            this.buttonBoşKoltuk.Click += new System.EventHandler(this.buttonBoşKoltuk_Click);
            // 
            // buttonBakiye
            // 
            this.buttonBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBakiye.Location = new System.Drawing.Point(20, 32);
            this.buttonBakiye.Name = "buttonBakiye";
            this.buttonBakiye.Size = new System.Drawing.Size(94, 58);
            this.buttonBakiye.TabIndex = 0;
            this.buttonBakiye.Text = "Bakiye";
            this.buttonBakiye.UseVisualStyleBackColor = true;
            this.buttonBakiye.Click += new System.EventHandler(this.buttonBakiye_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 90);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DURUM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 336);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxKoltuSayı);
            this.Controls.Add(this.textBoxSalonAdı);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSinema);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBiletSat;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSalonAdı;
        private System.Windows.Forms.TextBox textBoxKoltuSayı;
        private System.Windows.Forms.Button buttonSinema;
        private System.Windows.Forms.Button buttonBiletİptal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBoşKoltuk;
        private System.Windows.Forms.Button buttonBakiye;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxİndirim;
    }
}

