namespace FormKontrolleri
{
    partial class DatetimeVeMonth
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
            this.dtp_datetime = new System.Windows.Forms.DateTimePicker();
            this.btn_goruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_takvim = new System.Windows.Forms.Button();
            this.lbl_monthtakvim = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_datetime
            // 
            this.dtp_datetime.CalendarForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_datetime.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_datetime.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_datetime.Location = new System.Drawing.Point(52, 33);
            this.dtp_datetime.Name = "dtp_datetime";
            this.dtp_datetime.Size = new System.Drawing.Size(200, 20);
            this.dtp_datetime.TabIndex = 0;
            // 
            // btn_goruntule
            // 
            this.btn_goruntule.Location = new System.Drawing.Point(177, 95);
            this.btn_goruntule.Name = "btn_goruntule";
            this.btn_goruntule.Size = new System.Drawing.Size(75, 23);
            this.btn_goruntule.TabIndex = 1;
            this.btn_goruntule.Text = "Görüntüle";
            this.btn_goruntule.UseVisualStyleBackColor = true;
            this.btn_goruntule.Click += new System.EventHandler(this.Btn_goruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(52, 179);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // btn_takvim
            // 
            this.btn_takvim.Location = new System.Drawing.Point(211, 358);
            this.btn_takvim.Name = "btn_takvim";
            this.btn_takvim.Size = new System.Drawing.Size(75, 25);
            this.btn_takvim.TabIndex = 4;
            this.btn_takvim.Text = "Görüntüle";
            this.btn_takvim.UseVisualStyleBackColor = true;
            this.btn_takvim.Click += new System.EventHandler(this.Btn_takvim_Click);
            // 
            // lbl_monthtakvim
            // 
            this.lbl_monthtakvim.AutoSize = true;
            this.lbl_monthtakvim.Location = new System.Drawing.Point(28, 358);
            this.lbl_monthtakvim.Name = "lbl_monthtakvim";
            this.lbl_monthtakvim.Size = new System.Drawing.Size(0, 13);
            this.lbl_monthtakvim.TabIndex = 5;
            this.lbl_monthtakvim.Click += new System.EventHandler(this.Label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(52, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(189, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Bugünü göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(52, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // DatetimeVeMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_monthtakvim);
            this.Controls.Add(this.btn_takvim);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_goruntule);
            this.Controls.Add(this.dtp_datetime);
            this.Name = "DatetimeVeMonth";
            this.Text = "DatetimeVeMonth";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_datetime;
        private System.Windows.Forms.Button btn_goruntule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_takvim;
        private System.Windows.Forms.Label lbl_monthtakvim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}