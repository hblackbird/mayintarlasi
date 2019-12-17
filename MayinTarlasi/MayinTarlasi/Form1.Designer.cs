namespace MayinTarlasi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_zaman = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mayin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kisiyi_kaydet = new System.Windows.Forms.Button();
            this.yardim = new System.Windows.Forms.Button();
            this.skor_goruntule = new System.Windows.Forms.Button();
            this.kolay = new System.Windows.Forms.RadioButton();
            this.orta = new System.Windows.Forms.RadioButton();
            this.Zor = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saga = new System.Windows.Forms.Button();
            this.asagi = new System.Windows.Forms.Button();
            this.yukari = new System.Windows.Forms.Button();
            this.sola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seviye Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(424, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etraftaki Mayın :";
            // 
            // lbl_zaman
            // 
            this.lbl_zaman.AutoSize = true;
            this.lbl_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_zaman.Location = new System.Drawing.Point(799, 21);
            this.lbl_zaman.Name = "lbl_zaman";
            this.lbl_zaman.Size = new System.Drawing.Size(54, 20);
            this.lbl_zaman.TabIndex = 1;
            this.lbl_zaman.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(711, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Zaman :";
            // 
            // lbl_mayin
            // 
            this.lbl_mayin.AutoSize = true;
            this.lbl_mayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mayin.Location = new System.Drawing.Point(575, 21);
            this.lbl_mayin.Name = "lbl_mayin";
            this.lbl_mayin.Size = new System.Drawing.Size(19, 20);
            this.lbl_mayin.TabIndex = 1;
            this.lbl_mayin.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lütfen İsminizi Giriniz:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 26);
            this.textBox1.TabIndex = 3;
            // 
            // kisiyi_kaydet
            // 
            this.kisiyi_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisiyi_kaydet.Location = new System.Drawing.Point(20, 360);
            this.kisiyi_kaydet.Name = "kisiyi_kaydet";
            this.kisiyi_kaydet.Size = new System.Drawing.Size(192, 35);
            this.kisiyi_kaydet.TabIndex = 4;
            this.kisiyi_kaydet.Text = "Kişiyi Kaydet";
            this.kisiyi_kaydet.UseVisualStyleBackColor = true;
            this.kisiyi_kaydet.Click += new System.EventHandler(this.kisiyi_kaydet_Click);
            // 
            // yardim
            // 
            this.yardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yardim.Location = new System.Drawing.Point(26, 525);
            this.yardim.Name = "yardim";
            this.yardim.Size = new System.Drawing.Size(90, 60);
            this.yardim.TabIndex = 4;
            this.yardim.Text = "Yardım";
            this.yardim.UseVisualStyleBackColor = true;
            // 
            // skor_goruntule
            // 
            this.skor_goruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_goruntule.Location = new System.Drawing.Point(130, 525);
            this.skor_goruntule.Name = "skor_goruntule";
            this.skor_goruntule.Size = new System.Drawing.Size(148, 60);
            this.skor_goruntule.TabIndex = 4;
            this.skor_goruntule.Text = "Skorları Görüntüle";
            this.skor_goruntule.UseVisualStyleBackColor = true;
            this.skor_goruntule.Click += new System.EventHandler(this.skor_goruntule_Click);
            // 
            // kolay
            // 
            this.kolay.AutoSize = true;
            this.kolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolay.Location = new System.Drawing.Point(20, 92);
            this.kolay.Name = "kolay";
            this.kolay.Size = new System.Drawing.Size(77, 24);
            this.kolay.TabIndex = 8;
            this.kolay.TabStop = true;
            this.kolay.Text = "Kolay";
            this.kolay.UseVisualStyleBackColor = true;
            this.kolay.CheckedChanged += new System.EventHandler(this.kolay_CheckedChanged);
            // 
            // orta
            // 
            this.orta.AutoSize = true;
            this.orta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orta.Location = new System.Drawing.Point(20, 148);
            this.orta.Name = "orta";
            this.orta.Size = new System.Drawing.Size(69, 24);
            this.orta.TabIndex = 8;
            this.orta.TabStop = true;
            this.orta.Text = "Orta";
            this.orta.UseVisualStyleBackColor = true;
            this.orta.CheckedChanged += new System.EventHandler(this.orta_CheckedChanged);
            // 
            // Zor
            // 
            this.Zor.AutoSize = true;
            this.Zor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Zor.Location = new System.Drawing.Point(20, 198);
            this.Zor.Name = "Zor";
            this.Zor.Size = new System.Drawing.Size(61, 24);
            this.Zor.TabIndex = 8;
            this.Zor.TabStop = true;
            this.Zor.Text = "Zor";
            this.Zor.UseVisualStyleBackColor = true;
            this.Zor.CheckedChanged += new System.EventHandler(this.Zor_CheckedChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.ColumnCount = 20;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(366, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 614);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MayinTarlasi.Properties.Resources.timer;
            this.pictureBox2.Location = new System.Drawing.Point(664, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::MayinTarlasi.Properties.Resources.mine;
            this.pictureBox1.Location = new System.Drawing.Point(379, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // saga
            // 
            this.saga.BackgroundImage = global::MayinTarlasi.Properties.Resources.right_thin_chevron;
            this.saga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saga.Location = new System.Drawing.Point(700, 728);
            this.saga.Name = "saga";
            this.saga.Size = new System.Drawing.Size(33, 32);
            this.saga.TabIndex = 6;
            this.saga.UseVisualStyleBackColor = true;
            this.saga.Click += new System.EventHandler(this.saga_Click);
            // 
            // asagi
            // 
            this.asagi.BackgroundImage = global::MayinTarlasi.Properties.Resources.angle_arrow_down;
            this.asagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asagi.Location = new System.Drawing.Point(664, 763);
            this.asagi.Name = "asagi";
            this.asagi.Size = new System.Drawing.Size(33, 32);
            this.asagi.TabIndex = 6;
            this.asagi.UseVisualStyleBackColor = true;
            this.asagi.Click += new System.EventHandler(this.asagi_Click);
            // 
            // yukari
            // 
            this.yukari.BackgroundImage = global::MayinTarlasi.Properties.Resources.up_arrow;
            this.yukari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yukari.Location = new System.Drawing.Point(664, 691);
            this.yukari.Name = "yukari";
            this.yukari.Size = new System.Drawing.Size(33, 32);
            this.yukari.TabIndex = 6;
            this.yukari.TabStop = false;
            this.yukari.UseVisualStyleBackColor = true;
            this.yukari.Click += new System.EventHandler(this.yukari_Click);
            // 
            // sola
            // 
            this.sola.BackgroundImage = global::MayinTarlasi.Properties.Resources.back;
            this.sola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sola.Location = new System.Drawing.Point(628, 728);
            this.sola.Name = "sola";
            this.sola.Size = new System.Drawing.Size(33, 32);
            this.sola.TabIndex = 6;
            this.sola.UseVisualStyleBackColor = true;
            this.sola.Click += new System.EventHandler(this.sola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 814);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Zor);
            this.Controls.Add(this.orta);
            this.Controls.Add(this.kolay);
            this.Controls.Add(this.saga);
            this.Controls.Add(this.asagi);
            this.Controls.Add(this.yukari);
            this.Controls.Add(this.sola);
            this.Controls.Add(this.skor_goruntule);
            this.Controls.Add(this.yardim);
            this.Controls.Add(this.kisiyi_kaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_mayin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_zaman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_zaman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mayin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button kisiyi_kaydet;
        private System.Windows.Forms.Button yardim;
        private System.Windows.Forms.Button skor_goruntule;
        private System.Windows.Forms.Button sola;
        private System.Windows.Forms.Button yukari;
        private System.Windows.Forms.Button saga;
        private System.Windows.Forms.Button asagi;
        private System.Windows.Forms.RadioButton kolay;
        private System.Windows.Forms.RadioButton orta;
        private System.Windows.Forms.RadioButton Zor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

