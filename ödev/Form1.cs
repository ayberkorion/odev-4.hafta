namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Liste_AdSoyad = new List<string>();
        List<string> Liste_Eposta = new List<string>();
        List<string> Liste_sifre = new List<string>();
        List<string> Liste_Kullanici_adi = new List<string>();
        List<string> Liste_GirisKullanici_Adi = new List<string>();
        List<string> Liste_Giris_sifre = new List<string>();
        int sayac = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste_AdSoyad.Add(textBox1.Text);
            Liste_Eposta.Add(textBox2.Text);
            Liste_Kullanici_adi.Add(textBox3.Text);
            Liste_sifre.Add(textBox4.Text);
            sayac++;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Liste_GirisKullanici_Adi.Add(textBox6.Text);
            Liste_Giris_sifre.Add(textBox5.Text);
            foreach (string listenumarakayit in Liste_Kullanici_adi)
            {
                foreach (string listenumarakayitsifre in Liste_sifre)
                {
                    foreach (string listenumaragirissifre in Liste_Giris_sifre)
                    {
                        foreach (string listenumaragiris in Liste_GirisKullanici_Adi)
                        {
                            if (listenumaragiris == listenumarakayit && listenumaragirissifre == listenumarakayitsifre)
                            {
                                MessageBox.Show("Giriş Başarılı");
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış. Tekrar Deneyiniz");
                            }
                        }
                    }
                }
            }






        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayac; i++)
            {
                string deger = Liste_AdSoyad[i] + " " + Liste_Kullanici_adi[i] + " " + Liste_Eposta[i];
                listBox1.Items.Add(deger);
                comboBox1.Items.Add(deger);

            }
        }
    }
}