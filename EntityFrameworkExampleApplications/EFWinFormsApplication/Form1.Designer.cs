
namespace EFWinFormsApplication
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamCalisan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.lblStokUrunAdet = new System.Windows.Forms.Label();
            this.lblStoktaOlmayanUrunAdet = new System.Windows.Forms.Label();
            this.lblEnYuksekUrunFiyat = new System.Windows.Forms.Label();
            this.lblYuksekFiyatUrun = new System.Windows.Forms.Label();
            this.lblEnDusukUrunFiyat = new System.Windows.Forms.Label();
            this.lblDusukFiyatUrun = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDusukFiyatUrun);
            this.groupBox1.Controls.Add(this.lblEnDusukUrunFiyat);
            this.groupBox1.Controls.Add(this.lblYuksekFiyatUrun);
            this.groupBox1.Controls.Add(this.lblEnYuksekUrunFiyat);
            this.groupBox1.Controls.Add(this.lblStoktaOlmayanUrunAdet);
            this.groupBox1.Controls.Add(this.lblStokUrunAdet);
            this.groupBox1.Controls.Add(this.lblUrunAdet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İstatistikleri :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamCalisan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(413, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan İstatistikleri :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan Toplam";
            // 
            // lblToplamCalisan
            // 
            this.lblToplamCalisan.AutoSize = true;
            this.lblToplamCalisan.Location = new System.Drawing.Point(190, 66);
            this.lblToplamCalisan.Name = "lblToplamCalisan";
            this.lblToplamCalisan.Size = new System.Drawing.Size(13, 17);
            this.lblToplamCalisan.TabIndex = 1;
            this.lblToplamCalisan.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok Ürün Adet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stokta Olmayan Ürün Adet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "En Yüksek Ürün Fiyatı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yüksek Fiyatlı Ürün Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "En Düşük Ürün Fiyatı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Düşük Fiyatlı Ürün Adı :";
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(253, 66);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(13, 17);
            this.lblUrunAdet.TabIndex = 7;
            this.lblUrunAdet.Text = "*";
            // 
            // lblStokUrunAdet
            // 
            this.lblStokUrunAdet.AutoSize = true;
            this.lblStokUrunAdet.Location = new System.Drawing.Point(253, 96);
            this.lblStokUrunAdet.Name = "lblStokUrunAdet";
            this.lblStokUrunAdet.Size = new System.Drawing.Size(13, 17);
            this.lblStokUrunAdet.TabIndex = 8;
            this.lblStokUrunAdet.Text = "*";
            // 
            // lblStoktaOlmayanUrunAdet
            // 
            this.lblStoktaOlmayanUrunAdet.AutoSize = true;
            this.lblStoktaOlmayanUrunAdet.Location = new System.Drawing.Point(253, 130);
            this.lblStoktaOlmayanUrunAdet.Name = "lblStoktaOlmayanUrunAdet";
            this.lblStoktaOlmayanUrunAdet.Size = new System.Drawing.Size(13, 17);
            this.lblStoktaOlmayanUrunAdet.TabIndex = 9;
            this.lblStoktaOlmayanUrunAdet.Text = "*";
            // 
            // lblEnYuksekUrunFiyat
            // 
            this.lblEnYuksekUrunFiyat.AutoSize = true;
            this.lblEnYuksekUrunFiyat.Location = new System.Drawing.Point(253, 160);
            this.lblEnYuksekUrunFiyat.Name = "lblEnYuksekUrunFiyat";
            this.lblEnYuksekUrunFiyat.Size = new System.Drawing.Size(13, 17);
            this.lblEnYuksekUrunFiyat.TabIndex = 10;
            this.lblEnYuksekUrunFiyat.Text = "*";
            // 
            // lblYuksekFiyatUrun
            // 
            this.lblYuksekFiyatUrun.AutoSize = true;
            this.lblYuksekFiyatUrun.Location = new System.Drawing.Point(253, 191);
            this.lblYuksekFiyatUrun.Name = "lblYuksekFiyatUrun";
            this.lblYuksekFiyatUrun.Size = new System.Drawing.Size(13, 17);
            this.lblYuksekFiyatUrun.TabIndex = 11;
            this.lblYuksekFiyatUrun.Text = "*";
            // 
            // lblEnDusukUrunFiyat
            // 
            this.lblEnDusukUrunFiyat.AutoSize = true;
            this.lblEnDusukUrunFiyat.Location = new System.Drawing.Point(253, 223);
            this.lblEnDusukUrunFiyat.Name = "lblEnDusukUrunFiyat";
            this.lblEnDusukUrunFiyat.Size = new System.Drawing.Size(13, 17);
            this.lblEnDusukUrunFiyat.TabIndex = 12;
            this.lblEnDusukUrunFiyat.Text = "*";
            // 
            // lblDusukFiyatUrun
            // 
            this.lblDusukFiyatUrun.AutoSize = true;
            this.lblDusukFiyatUrun.Location = new System.Drawing.Point(253, 253);
            this.lblDusukFiyatUrun.Name = "lblDusukFiyatUrun";
            this.lblDusukFiyatUrun.Size = new System.Drawing.Size(13, 17);
            this.lblDusukFiyatUrun.TabIndex = 13;
            this.lblDusukFiyatUrun.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDusukFiyatUrun;
        private System.Windows.Forms.Label lblEnDusukUrunFiyat;
        private System.Windows.Forms.Label lblYuksekFiyatUrun;
        private System.Windows.Forms.Label lblEnYuksekUrunFiyat;
        private System.Windows.Forms.Label lblStoktaOlmayanUrunAdet;
        private System.Windows.Forms.Label lblStokUrunAdet;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamCalisan;
        private System.Windows.Forms.Label label1;
    }
}

