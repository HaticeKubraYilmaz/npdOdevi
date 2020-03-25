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

            if ( cep.Text.Trim()== ""|| isim.Text.Trim() == "" || adres.Text.Trim() == "" )
            {
                MessageBox.Show( " Lütfen bilgileri tüm yazın ") ;
                return;
            }

            StreamReader kontrol = new StreamReader("date.txt");
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
                StreamWriter sw = new StreamWriter("date.txt", true);
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
            if (cep.Text.Trim() != "") // cep num. yazılmadığında 
            {
                StreamReader sr = new StreamReader("date.txt");
                String satir = "";
                bool bul = false;
                do
                {
                    sr.ReadLine();
                    if (satir != null) // son satır boşsa
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
                } while (satir != null); // doya boş olunca
                sr.Close();
                if ( !bul)
                {
                    MessageBox.Show(" bu numara kayirli değil !");
                }

            }
            else
            {
                MessageBox.Show(" Lütfen cep numara yazın !");
                cep.Focus();
            }

    }
}
}