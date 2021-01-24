namespace FormKontrolleri
{
    partial class KontrollerDevam
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
            this.cb_unbound = new System.Windows.Forms.ComboBox();
            this.cb_databound = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_unbound = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_deger = new System.Windows.Forms.ComboBox();
            this.btn_databound = new System.Windows.Forms.Button();
            this.btn_tursec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_unbound
            // 
            this.cb_unbound.FormattingEnabled = true;
            this.cb_unbound.Items.AddRange(new object[] {
            "Seçenek 1",
            "Seçenek 2",
            "Seçenek 3",
            "Seçenek 4"});
            this.cb_unbound.Location = new System.Drawing.Point(37, 62);
            this.cb_unbound.Name = "cb_unbound";
            this.cb_unbound.Size = new System.Drawing.Size(121, 21);
            this.cb_unbound.TabIndex = 0;
            // 
            // cb_databound
            // 
            this.cb_databound.FormattingEnabled = true;
            this.cb_databound.Location = new System.Drawing.Point(37, 123);
            this.cb_databound.Name = "cb_databound";
            this.cb_databound.Size = new System.Drawing.Size(121, 21);
            this.cb_databound.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UnBound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataBound";
            // 
            // btn_unbound
            // 
            this.btn_unbound.Location = new System.Drawing.Point(179, 62);
            this.btn_unbound.Name = "btn_unbound";
            this.btn_unbound.Size = new System.Drawing.Size(75, 23);
            this.btn_unbound.TabIndex = 4;
            this.btn_unbound.Text = "Kaydet";
            this.btn_unbound.UseVisualStyleBackColor = true;
            this.btn_unbound.Click += new System.EventHandler(this.Btn_unbound_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tursec);
            this.groupBox1.Controls.Add(this.cb_deger);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_tur);
            this.groupBox1.Location = new System.Drawing.Point(37, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cb_tur
            // 
            this.cb_tur.FormattingEnabled = true;
            this.cb_tur.Items.AddRange(new object[] {
            "Günler",
            "Yıllar"});
            this.cb_tur.Location = new System.Drawing.Point(6, 36);
            this.cb_tur.Name = "cb_tur";
            this.cb_tur.Size = new System.Drawing.Size(121, 21);
            this.cb_tur.TabIndex = 0;
            this.cb_tur.SelectedIndexChanged += new System.EventHandler(this.Cb_tur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Değer";
            // 
            // cb_deger
            // 
            this.cb_deger.FormattingEnabled = true;
            this.cb_deger.Location = new System.Drawing.Point(7, 90);
            this.cb_deger.Name = "cb_deger";
            this.cb_deger.Size = new System.Drawing.Size(121, 21);
            this.cb_deger.TabIndex = 3;
            // 
            // btn_databound
            // 
            this.btn_databound.Location = new System.Drawing.Point(179, 121);
            this.btn_databound.Name = "btn_databound";
            this.btn_databound.Size = new System.Drawing.Size(75, 23);
            this.btn_databound.TabIndex = 6;
            this.btn_databound.Text = "Kaydet";
            this.btn_databound.UseVisualStyleBackColor = true;
            this.btn_databound.Click += new System.EventHandler(this.Btn_databound_Click);
            // 
            // btn_tursec
            // 
            this.btn_tursec.Location = new System.Drawing.Point(142, 36);
            this.btn_tursec.Name = "btn_tursec";
            this.btn_tursec.Size = new System.Drawing.Size(75, 23);
            this.btn_tursec.TabIndex = 4;
            this.btn_tursec.Text = "Seç";
            this.btn_tursec.UseVisualStyleBackColor = true;
            this.btn_tursec.Click += new System.EventHandler(this.Btn_tursec_Click);
            // 
            // KontrollerDevam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.btn_databound);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_unbound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_databound);
            this.Controls.Add(this.cb_unbound);
            this.Name = "KontrollerDevam";
            this.Text = "KontrollerDevam";
            this.Load += new System.EventHandler(this.KontrollerDevam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_unbound;
        private System.Windows.Forms.ComboBox cb_databound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_unbound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_deger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tur;
        private System.Windows.Forms.Button btn_databound;
        private System.Windows.Forms.Button btn_tursec;
    }
}