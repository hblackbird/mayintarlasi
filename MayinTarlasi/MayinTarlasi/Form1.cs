using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int etraftaki_mayin = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (mayinlar[10, 18] == "x")
            {
                etraftaki_mayin++;
                lbl_mayin.Text = etraftaki_mayin.ToString();
            }
        }
        int mayin_zorluk = 0;
        private void kolay_CheckedChanged(object sender, EventArgs e)
        {
            mayin_zorluk = 40;
        }
        private void orta_CheckedChanged(object sender, EventArgs e)
        {
            mayin_zorluk = 60;
        }
        private void Zor_CheckedChanged_1(object sender, EventArgs e)
        {
            mayin_zorluk = 90;
        }

        string[,] mayinlar = new string[20, 20];

        int satir = 10, sutun = 19;
        private void kisiyi_kaydet_Click(object sender, EventArgs e)
        {
            yeni_oyun();
        }
        int kisi_sayisi = 0;
        private void yeni_oyun()
        {
            this.BackColor = SystemColors.Control;
            saniye = 0;
            dakika = 0;
            lbl_zaman.Text = dakika.ToString() + ":" + saniye.ToString();
            kisi_sayisi++;
            yukari.Enabled = true;
            asagi.Enabled = true;
            saga.Enabled = true;
            sola.Enabled = true;
            etraftaki_mayin = 0;
            if (kolay.Checked == true || orta.Checked == true || Zor.Checked == true)
            {
                satir = 10;
                sutun = 19;
                Random rnd = new Random();
                int mayin_sayisi = 0;
                tableLayoutPanel1.Controls.Clear();
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        tableLayoutPanel1.Controls.Add(new Label() { BackColor = Color.SkyBlue }, i, j);
                    }
                }
                tableLayoutPanel1.GetControlFromPosition(10, 19).BackColor = Color.Red;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        mayinlar[i, j] = "";
                    }
                }

                for (int i = 0; i < mayin_zorluk; i++)
                {
                    int a = rnd.Next(0, 19);
                    int b = rnd.Next(0, 19);
                    if (mayinlar[a, b] == "x")
                    {
                        a = rnd.Next(0, 19);
                        b = rnd.Next(0, 19);
                        i--;
                    }
                    if (mayin_sayisi < mayin_zorluk)
                    {
                        mayinlar[a, b] = "x";
                        mayin_sayisi++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Zorluk derecesi seçiniz.");
            }
        }
        private void mayin_yaz()
        {
            Image resim = Image.FromFile("bomb.png");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (mayinlar[i, j] == "x")
                    {
                        tableLayoutPanel1.GetControlFromPosition(i, j).BackgroundImage=resim;
                        tableLayoutPanel1.GetControlFromPosition(i, j).BackColor=Color.Yellow;
                    }
                }
            }
        }

        int saniye = 00, dakika = 00;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                dakika++;
                saniye = 00;
            }
            lbl_zaman.Text = dakika.ToString() + ":" + saniye.ToString();
            saniye++;
        }
        private void yukari_Click(object sender, EventArgs e)
        {
            timer1.Start();
            etraftaki_mayin = 0;
            asagi.Enabled = true;
            saga.Enabled = true;
            sola.Enabled = true;
            lbl_mayin.Text = etraftaki_mayin.ToString();
            if (sutun-1 == 0)
            {
                tableLayoutPanel1.GetControlFromPosition(satir, sutun-1).BackColor = Color.Red;
                yukari.Enabled = false;
                asagi.Enabled = false;
                saga.Enabled = false;
                sola.Enabled = false;
                mayin_yaz();
                MessageBox.Show("Kazandın!");
            }
            else
            {
                
            }
            if (--sutun < 0)
            {
                MessageBox.Show("Yukarı cok geldin");
                yukari.Enabled = false;
                sutun++;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(satir, sutun).BackColor = Color.Red;
                tableLayoutPanel1.GetControlFromPosition(satir, sutun+1).BackColor = Color.Blue;
            }
            if (satir - 1 > 0)
            {
                if (mayinlar[satir - 1, sutun] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (satir + 1 < 20)
            {
                if (mayinlar[satir + 1, sutun] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (sutun - 1 > 0)
            {
                if (mayinlar[satir, sutun - 1] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            else
            {

            }
            if (sutun <= 19)
            {
                if (mayinlar[satir, sutun] == "x")
                {
                    yukari.Enabled = false;
                    asagi.Enabled = false;
                    saga.Enabled = false;
                    sola.Enabled = false;
                    mayin_yaz();
                    timer1.Stop();
                    dosyaya_yaz();
                    this.BackColor = Color.Yellow;
                    DialogResult sonuc = MessageBox.Show("Yeni Oyun?","Kaybettiniz",MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        yeni_oyun();
                    }
                }
            }
            else
            {

            }


        }

        private void sola_Click(object sender, EventArgs e)
        {
            timer1.Start();
            asagi.Enabled = true;
            yukari.Enabled = true;
            saga.Enabled = true;
            etraftaki_mayin = 0;
            lbl_mayin.Text = etraftaki_mayin.ToString();
            if (--satir < 0)
            {
                MessageBox.Show("Sola cok geldin");
                sola.Enabled = false;
                satir++;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(satir, sutun).BackColor = Color.Red;
                tableLayoutPanel1.GetControlFromPosition(satir+1, sutun).BackColor = Color.Blue;
            }
            if (sutun + 1 < 20)
            {
                if (mayinlar[satir, sutun + 1] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (satir - 1 > 0)
            {
                if (mayinlar[satir - 1, sutun] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (mayinlar[satir, sutun - 1] == "x")
            {
                etraftaki_mayin++;
                lbl_mayin.Text = etraftaki_mayin.ToString();
            }
            else
            {

            }
            if (satir <= 19)
            {
                if (mayinlar[satir, sutun] == "x")
                {
                    yukari.Enabled = false;
                    asagi.Enabled = false;
                    saga.Enabled = false;
                    sola.Enabled = false;
                    mayin_yaz();
                    timer1.Stop();
                    dosyaya_yaz();
                    DialogResult sonuc = MessageBox.Show("Yeni Oyun?", "Kaybettiniz", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        yeni_oyun();
                    }
                }
            }
            
        }

        private void saga_Click(object sender, EventArgs e)
        {
            timer1.Start();
            asagi.Enabled = true;
            yukari.Enabled = true;
            sola.Enabled = true;
            etraftaki_mayin = 0;
            lbl_mayin.Text = etraftaki_mayin.ToString();
            if (++satir > 19)
            {
                MessageBox.Show("Saga cok geldin");
                saga.Enabled = false;
                satir--;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(satir, sutun).BackColor = Color.Red;
                tableLayoutPanel1.GetControlFromPosition(satir-1, sutun).BackColor = Color.Blue;
            }
            if (sutun + 1 < 20)
            {
                if (mayinlar[satir, sutun + 1] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (satir + 1 < 20)
            {
                if (mayinlar[satir + 1, sutun] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (mayinlar[satir, sutun - 1] == "x")
            {
                etraftaki_mayin++;
                lbl_mayin.Text = etraftaki_mayin.ToString();
            }
            else
            {

            }
            if (satir <= 19)
            {
              if (mayinlar[satir, sutun] == "x")
                {
                    yukari.Enabled = false;
                    asagi.Enabled = false;
                    saga.Enabled = false;
                    sola.Enabled = false;
                    mayin_yaz();
                    timer1.Stop();
                    dosyaya_yaz();
                    DialogResult sonuc = MessageBox.Show("Yeni Oyun?", "Kaybettiniz", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        yeni_oyun();
                    }
                }
            }
        }

        private void asagi_Click(object sender, EventArgs e)
        {
            saga.Enabled = true;
            yukari.Enabled = true;
            sola.Enabled = true;
            etraftaki_mayin = 0;
            if (++sutun > 19)
            {
                MessageBox.Show("Asagıya cok geldin");
                asagi.Enabled = false;
                sutun--;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(satir, sutun).BackColor = Color.Red;
                tableLayoutPanel1.GetControlFromPosition(satir, sutun-1).BackColor = Color.Blue;
            }
            if (sutun + 1 < 20)
            {
                if (mayinlar[satir, sutun + 1] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (satir -1 > 0)
            {
                if (mayinlar[satir - 1, sutun] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (satir + 1 < 20)
            {
                if (mayinlar[satir + 1, sutun] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }
            if (sutun - 1 > 0)
            {
                if (mayinlar[satir, sutun - 1] == "x")
                {
                    etraftaki_mayin++;
                    lbl_mayin.Text = etraftaki_mayin.ToString();
                }
            }

            else
            {

            }
            if (sutun <= 19)
            {
                if (mayinlar[satir, sutun] == "x")
                {
                    yukari.Enabled = false;
                    asagi.Enabled = false;
                    saga.Enabled = false;
                    sola.Enabled = false;
                    mayin_yaz();
                    timer1.Stop();
                    dosyaya_yaz();
                    DialogResult sonuc = MessageBox.Show("Yeni Oyun?", "Kaybettiniz", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        yeni_oyun();
                    }
                }
            }
        }
        private void skor_goruntule_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\skorlar.txt");

        }
        private void dosyaya_yaz()
        {
            string isim;
            isim = textBox1.Text;
            string[] skor = new string[10];
            skor[kisi_sayisi-1] = isim +"  " +dakika.ToString() +":"+ saniye.ToString();
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\" + "skorlar.txt",skor);

        }
    }
}
