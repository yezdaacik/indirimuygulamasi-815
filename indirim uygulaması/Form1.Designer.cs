namespace indirim_uygulaması
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
            this.rbİndirim1 = new System.Windows.Forms.RadioButton();
            this.rbİndirim2 = new System.Windows.Forms.RadioButton();
            this.rbİndirim3 = new System.Windows.Forms.RadioButton();
            this.rbİndirim4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblİndirim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbİndirim1
            // 
            this.rbİndirim1.AutoSize = true;
            this.rbİndirim1.Location = new System.Drawing.Point(12, 93);
            this.rbİndirim1.Name = "rbİndirim1";
            this.rbİndirim1.Size = new System.Drawing.Size(71, 17);
            this.rbİndirim1.TabIndex = 0;
            this.rbİndirim1.TabStop = true;
            this.rbİndirim1.Text = "%5 indirim";
            this.rbİndirim1.UseVisualStyleBackColor = true;
            // 
            // rbİndirim2
            // 
            this.rbİndirim2.AutoSize = true;
            this.rbİndirim2.Location = new System.Drawing.Point(12, 125);
            this.rbİndirim2.Name = "rbİndirim2";
            this.rbİndirim2.Size = new System.Drawing.Size(77, 17);
            this.rbİndirim2.TabIndex = 1;
            this.rbİndirim2.TabStop = true;
            this.rbİndirim2.Text = "%10 indirim";
            this.rbİndirim2.UseVisualStyleBackColor = true;
            // 
            // rbİndirim3
            // 
            this.rbİndirim3.AutoSize = true;
            this.rbİndirim3.Location = new System.Drawing.Point(12, 158);
            this.rbİndirim3.Name = "rbİndirim3";
            this.rbİndirim3.Size = new System.Drawing.Size(77, 17);
            this.rbİndirim3.TabIndex = 2;
            this.rbİndirim3.TabStop = true;
            this.rbİndirim3.Text = "%15 indirim";
            this.rbİndirim3.UseVisualStyleBackColor = true;
            // 
            // rbİndirim4
            // 
            this.rbİndirim4.AutoSize = true;
            this.rbİndirim4.Location = new System.Drawing.Point(12, 190);
            this.rbİndirim4.Name = "rbİndirim4";
            this.rbİndirim4.Size = new System.Drawing.Size(77, 17);
            this.rbİndirim4.TabIndex = 3;
            this.rbİndirim4.TabStop = true;
            this.rbİndirim4.Text = "%25 indirim";
            this.rbİndirim4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İndirimli fiyat";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(81, 29);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 225);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(115, 42);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblİndirim
            // 
            this.lblİndirim.AutoSize = true;
            this.lblİndirim.Location = new System.Drawing.Point(92, 68);
            this.lblİndirim.Name = "lblİndirim";
            this.lblİndirim.Size = new System.Drawing.Size(0, 13);
            this.lblİndirim.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 337);
            this.Controls.Add(this.lblİndirim);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbİndirim4);
            this.Controls.Add(this.rbİndirim3);
            this.Controls.Add(this.rbİndirim2);
            this.Controls.Add(this.rbİndirim1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbİndirim1;
        private System.Windows.Forms.RadioButton rbİndirim2;
        private System.Windows.Forms.RadioButton rbİndirim3;
        private System.Windows.Forms.RadioButton rbİndirim4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblİndirim;
    }
}

