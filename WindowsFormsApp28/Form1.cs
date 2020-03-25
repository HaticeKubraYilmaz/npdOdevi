/**************************************************************************** 
** SAKARYA ÜNİVERSİTESİ 
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
** NESNEYE DAYALI PROGRAMLAMA DERSİ 
** 2019-2020 BAHAR DÖNEMİ 
** 
** ÖDEV NUMARASI..........: 
** ÖĞRENCİ ADI............: Hatice Kübra YILMAZ
** ÖĞRENCİ NUMARASI.......: B181200049
** DERSİN ALINDIĞI GRUP...: BSM
****************************************************************************/
using System;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void çik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {

            if (cep.Text.Trim() == "" || isim.Text.Trim() == "" || adres.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz girin!");
                return;
            }

            StreamReader kontrol = new StreamReader("data.txt");
            string strKontrol = kontrol.ReadToEnd();
            kontrol.Close();
            if (strKontrol.Contains(cep.Text + ";")) // Aynı numaranın tekrarlanmaması için 
            {
                MessageBox.Show("Girdiğiniz cep numarası sistemde mevcuttur!");
                cep.Focus();
                cep.SelectAll(); // Değiştirme işlemini kolaylaştırmak için 

            }
            else
            {
                StreamWriter sw = new StreamWriter("data.txt", true);
                string strkisi = isim.Text + ";"
                           + cep.Text + ";"
                           + adres.Text;
                sw.WriteLine(strkisi);
                sw.Close();
                MessageBox.Show("Yeni Kişi Eklendi");


                foreach (Control c in this.Controls) // Kutuları boşaltmak için 
                {
                    if (c is TextBox)
                        c.Text = "";

                }
                isim.Focus();



            }



        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (cep.Text.Trim() != "") // Eğer cep numarası satırı boş değilse arama işlemi yapılacak.
            {
                StreamReader sr = new StreamReader("data.txt");
                string satır = ""; // Her döndüğünüzde satır değerlerini taşıyacak.
                bool bul = false;

                do
                {
                    satir = sr.ReadLine();   
                    if(satir !=null) // Satır boş değil ise
                    {
                        string[] arrData = satir.Split(';');
                        if (arrData[1] == cep.Text)
                        {
                            isim.Text = arrData[0];
                            cep.Text = arrData[1];
                            adres.Text = arrData[2];
                            bul = true;
                            break;
                        }


                    }


                } while (satir != null); // Dosya boş ise
                sr.Close();
                if (!bul)
                {
                    MessageBox.Show("Aradığınız cep numarası kayıtlı değildir!");

                }
            }
            else // Cep numarası satırı boş ise
            {
                MessageBox.Show("Aramak istediğiniz cep numarasını yazınız");
                cep.Focus();
            }
        }

        private void hepsi_Click(object sender, EventArgs e)
        {
            Form frmShow = new Form();
            TextBox fa = new TextBox();
            frmShow.StartPosition = FormStartPosition.CenterScreen;
            frmShow.Font = this.Font;
            frmShow.Size = this.Size;
            fa.ReadOnly = true;
            frmShow.Text = "TÜM LİSTE";
            fa.BackColor = this.BackColor;
            fa.Multiline = true;
            fa.Dock = DockStyle.Fill;

            frmShow.Controls.Add(fa);
            
           

            StreamReader sr = new StreamReader("data.txt");
            string strAll = sr.ReadToEnd();
            sr.Close();
            fa.Text = strAll;
            frmShow.ShowDialog();

        }
    }
}
