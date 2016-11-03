namespace romaliasker
{
    partial class frmAsker
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
            this.components = new System.ComponentModel.Container();
            this.lblKalanlar = new System.Windows.Forms.Label();
            this.lblAdimSayisi = new System.Windows.Forms.Label();
            this.txtAdimSayisi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblAskerSayisi = new System.Windows.Forms.Label();
            this.txtAskerSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.lblKalanAsker = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblIlkDeger = new System.Windows.Forms.Label();
            this.lblDegerler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKalanlar
            // 
            this.lblKalanlar.AutoSize = true;
            this.lblKalanlar.Location = new System.Drawing.Point(14, 94);
            this.lblKalanlar.Name = "lblKalanlar";
            this.lblKalanlar.Size = new System.Drawing.Size(75, 13);
            this.lblKalanlar.TabIndex = 9;
            this.lblKalanlar.Text = "Kalan Askerler";
            // 
            // lblAdimSayisi
            // 
            this.lblAdimSayisi.AutoSize = true;
            this.lblAdimSayisi.Location = new System.Drawing.Point(14, 40);
            this.lblAdimSayisi.Name = "lblAdimSayisi";
            this.lblAdimSayisi.Size = new System.Drawing.Size(69, 13);
            this.lblAdimSayisi.TabIndex = 10;
            this.lblAdimSayisi.Text = "Adım Sayısı : ";
            // 
            // txtAdimSayisi
            // 
            this.txtAdimSayisi.Location = new System.Drawing.Point(93, 38);
            this.txtAdimSayisi.Name = "txtAdimSayisi";
            this.txtAdimSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtAdimSayisi.TabIndex = 2;
            this.txtAdimSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdimSayisi_KeyPress);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(199, 12);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 47);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblAskerSayisi
            // 
            this.lblAskerSayisi.AutoSize = true;
            this.lblAskerSayisi.Location = new System.Drawing.Point(14, 15);
            this.lblAskerSayisi.Name = "lblAskerSayisi";
            this.lblAskerSayisi.Size = new System.Drawing.Size(73, 13);
            this.lblAskerSayisi.TabIndex = 6;
            this.lblAskerSayisi.Text = "Asker Sayısı : ";
            // 
            // txtAskerSayisi
            // 
            this.txtAskerSayisi.Location = new System.Drawing.Point(93, 12);
            this.txtAskerSayisi.Name = "txtAskerSayisi";
            this.txtAskerSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtAskerSayisi.TabIndex = 1;
            this.txtAskerSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAskerSayisi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Süre(Milisaniye)";
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.AutoSize = true;
            this.lblGecenSure.Location = new System.Drawing.Point(245, 94);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(25, 13);
            this.lblGecenSure.TabIndex = 13;
            this.lblGecenSure.Text = "000";
            // 
            // lblKalanAsker
            // 
            this.lblKalanAsker.AutoSize = true;
            this.lblKalanAsker.Location = new System.Drawing.Point(95, 94);
            this.lblKalanAsker.Name = "lblKalanAsker";
            this.lblKalanAsker.Size = new System.Drawing.Size(25, 13);
            this.lblKalanAsker.TabIndex = 12;
            this.lblKalanAsker.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Aşamalar";
            // 
            // lblIlkDeger
            // 
            this.lblIlkDeger.AutoSize = true;
            this.lblIlkDeger.Location = new System.Drawing.Point(95, 61);
            this.lblIlkDeger.Name = "lblIlkDeger";
            this.lblIlkDeger.Size = new System.Drawing.Size(0, 13);
            this.lblIlkDeger.TabIndex = 16;
            // 
            // lblDegerler
            // 
            this.lblDegerler.AutoSize = true;
            this.lblDegerler.Location = new System.Drawing.Point(280, 29);
            this.lblDegerler.Name = "lblDegerler";
            this.lblDegerler.Size = new System.Drawing.Size(0, 13);
            this.lblDegerler.TabIndex = 14;
            // 
            // frmAsker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 189);
            this.Controls.Add(this.lblIlkDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDegerler);
            this.Controls.Add(this.lblGecenSure);
            this.Controls.Add(this.lblKalanAsker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKalanlar);
            this.Controls.Add(this.lblAdimSayisi);
            this.Controls.Add(this.txtAdimSayisi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblAskerSayisi);
            this.Controls.Add(this.txtAskerSayisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAsker";
            this.Text = "Romalı Asker Problemi";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalanlar;
        private System.Windows.Forms.Label lblAdimSayisi;
        private System.Windows.Forms.TextBox txtAdimSayisi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblAskerSayisi;
        private System.Windows.Forms.TextBox txtAskerSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.Label lblKalanAsker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIlkDeger;
        private System.Windows.Forms.Label lblDegerler;
    }
}

