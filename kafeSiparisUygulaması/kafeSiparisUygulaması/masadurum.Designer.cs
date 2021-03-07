namespace kafeSiparisUygulaması
{
    partial class masadurum
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
            this.lblMasa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Location = new System.Drawing.Point(12, 24);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(95, 13);
            this.lblMasa.TabIndex = 0;
            this.lblMasa.Text = "Masa Numarası : ?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 719);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Seçilen Ürünler"});
            this.listBox1.Location = new System.Drawing.Point(386, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 238);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Siparişi Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(494, 386);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(76, 13);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "Toplam Tutar :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sipariş Bitir ve Fiş Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // masadurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 793);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMasa);
            this.Name = "masadurum";
            this.Text = "Masa Durumu";
            this.Load += new System.EventHandler(this.Masadurum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTutar;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}