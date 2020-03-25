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
                MessageBox.Show(" Lütfen bilgileri tüm yazın ");
                return;
            }

            StreamReader kontrol = new StreamReader("data.txt");
            string strKontrol = kontrol.ReadToEnd();
            kontrol.Close();
            if (strKontrol.Contains(cep.Text + ";")) // aynı numara tekrarlamamak için 
            {
                MessageBox.Show("girdiğiniz cep no sistemde mevcuttur!");
                cep.Focus();
                cep.SelectAll(); // değiştirme işlemi kolaylaştırmak için 

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
            if (cep.Text.Trim() != "") // eğer cep satrı boş değilse arama işlemi yapılacak.
            {
                StreamReader sr = new StreamReader("data.txt");
                string satir = ""; // her döndüğünüzde satir değerleri taşıyacaktır.
                bool bul = false;

                do
                {
                    satir = sr.ReadLine();   
                    if(satir !=null) // satir boş değil ise
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


                } while (satir != null); // dosya boş ise
                sr.Close();
                if (!bul)
                {
                    MessageBox.Show("Aradığınız cep numara kayıtlı değildir !");

                }
            }
            else // cep satri bos ise
            {
                MessageBox.Show("Aramak istediniz cep num. yazın !");
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