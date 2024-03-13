using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Adres: Tekirdağ/Ergene, Türkiye";
            label4.Text = "Telefon: 0535 052 02 53";
            label5.Text = "E-posta: atakan_adali@hotmail.com.tr";
            linkLabel1.Text = "Linkedin: Atakan Adalı";
            linkLabel2.Text = "Github: PISTIN22";
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://www.linkedin.com/in/atakan-adal%C4%B1/");
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, "https://github.com/PISTIN22");

            label6.Text = "Mezun Olduğu Okul: Deri Sanayicilieri Mesleki Teknik Anadolu Lisesi";
            label7.Text = "Bölüm: Bilişim";
            label8.Text = "Mezuniyet Yılı: 2019";

            label9.Text = "Okul: Mehmet Âkif Ersoy Üniversitesi Ağlasun Meslek Yüksekolulu";
            label10.Text = "Bölüm: Bilişim Güvenliği Teknolojisi";
            label11.Text = "Öğrenim Durumu: Devam Etmekte";

            label12.Text = "Doğum Tarihi: 02/05/2001";
            label13.Text = "Cinsiyet: Erkek";
            label14.Text = "Ehliyet: B2";

            label15.Text = "İngilizce: B1";
            label16.Text = "Bulgarca: A2";

            label17.Text = "Python:";
            label18.Text = "JavaScript:";
            label19.Text = "HTML & CSS:";
            label20.Text = "C#:";
            label21.Text = "SQL:";
            label22.Text = "Unity:";
            progressBar1.Value = 75;
            progressBar2.Value = 70;
            progressBar3.Value = 90;
            progressBar4.Value = 85;
            progressBar5.Value = 70;
            progressBar6.Value = 50;
            progressBar7.Value = 70;
            progressBar8.Value = 20;
            label23.Text = "Oyun Oynamak & Tasarlamak";
            label24.Text = "Film izlemek";
            label25.Text = "Kitap okumak";
            label26.Text = "Kahve";
            label27.Text = "Elektronik cihaz tamir etmek";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string clickedUrl = e.Link.LinkData as string; if (!string.IsNullOrEmpty(clickedUrl))
            {
                System.Diagnostics.Process.Start(clickedUrl);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string clickedUrl = e.Link.LinkData as string; if (!string.IsNullOrEmpty(clickedUrl))
            {
                System.Diagnostics.Process.Start(clickedUrl);
            }
        }
    }
}
