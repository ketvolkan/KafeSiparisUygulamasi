namespace kafeSiparisUygulaması
{
    partial class giris
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMasasayi = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnMasa = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(17, 64);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(167, 29);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giris Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 118);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnBilgi);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.btnMasa);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.lblMasasayi);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 190);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // lblMasasayi
            // 
            this.lblMasasayi.AutoSize = true;
            this.lblMasasayi.Location = new System.Drawing.Point(17, 15);
            this.lblMasasayi.Name = "lblMasasayi";
            this.lblMasasayi.Size = new System.Drawing.Size(122, 13);
            this.lblMasasayi.TabIndex = 0;
            this.lblMasasayi.Text = "Masa Sayısı Değiştir (??)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btnMasa
            // 
            this.btnMasa.Location = new System.Drawing.Point(146, 15);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(74, 36);
            this.btnMasa.TabIndex = 2;
            this.btnMasa.Text = "Değiştir";
            this.btnMasa.UseVisualStyleBackColor = true;
            this.btnMasa.Click += new System.EventHandler(this.BtnMasa_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Adı Şifre Değiştir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(87, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // btnBilgi
            // 
            this.btnBilgi.Location = new System.Drawing.Point(17, 141);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(170, 35);
            this.btnBilgi.TabIndex = 6;
            this.btnBilgi.Text = "Değiştir";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.BtnBilgi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Uygulamaya Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 201);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "giris";
            this.Text = "giris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblMasasayi;
        private System.Windows.Forms.Button button1;
    }
}