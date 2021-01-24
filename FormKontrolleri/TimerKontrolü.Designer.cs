namespace FormKontrolleri
{
    partial class TimerKontrolü
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.btn_dur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(42, 27);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(13, 13);
            this.lbl_ekran.TabIndex = 0;
            this.lbl_ekran.Text = "0";
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(45, 74);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(75, 23);
            this.btn_basla.TabIndex = 1;
            this.btn_basla.Text = "Başla";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.Btn_basla_Click);
            // 
            // btn_dur
            // 
            this.btn_dur.Location = new System.Drawing.Point(180, 74);
            this.btn_dur.Name = "btn_dur";
            this.btn_dur.Size = new System.Drawing.Size(75, 23);
            this.btn_dur.TabIndex = 2;
            this.btn_dur.Text = "Dur";
            this.btn_dur.UseVisualStyleBackColor = true;
            this.btn_dur.Click += new System.EventHandler(this.Btn_dur_Click);
            // 
            // TimerKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 177);
            this.Controls.Add(this.btn_dur);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.lbl_ekran);
            this.Name = "TimerKontrolü";
            this.Text = "TimerKontrolü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btn_dur;
    }
}