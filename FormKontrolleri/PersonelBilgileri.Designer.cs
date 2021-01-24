namespace FormKontrolleri
{
    partial class PersonelBilgileri
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
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.tb_yas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(90, 44);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(213, 20);
            this.tb_ad.TabIndex = 0;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(90, 82);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(213, 20);
            this.tb_soyad.TabIndex = 1;
            // 
            // tb_yas
            // 
            this.tb_yas.Location = new System.Drawing.Point(90, 196);
            this.tb_yas.Name = "tb_yas";
            this.tb_yas.Size = new System.Drawing.Size(213, 20);
            this.tb_yas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyadı";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(90, 315);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(213, 23);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(326, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 173);
            this.listBox1.TabIndex = 11;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.Location = new System.Drawing.Point(10, 21);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(52, 17);
            this.rb_kadin.TabIndex = 12;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın";
            this.rb_kadin.UseVisualStyleBackColor = true;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(10, 44);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(53, 17);
            this.rb_erkek.TabIndex = 13;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Location = new System.Drawing.Point(14, 23);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(53, 17);
            this.rb_bekar.TabIndex = 12;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(14, 46);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(42, 17);
            this.rb_evli.TabIndex = 13;
            this.rb_evli.TabStop = true;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_kadin);
            this.groupBox1.Controls.Add(this.rb_erkek);
            this.groupBox1.Location = new System.Drawing.Point(90, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 87);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_bekar);
            this.groupBox2.Controls.Add(this.rb_evli);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(177, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(73, 87);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(90, 155);
            this.tb_telefon.Mask = "(999) 000-0000";
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(213, 20);
            this.tb_telefon.TabIndex = 16;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(90, 120);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(213, 20);
            this.tb_email.TabIndex = 2;
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 362);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_yas);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Name = "PersonelBilgileri";
            this.Text = "PersonelBilgileri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.TextBox tb_yas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rb_kadin;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_email;
    }
}