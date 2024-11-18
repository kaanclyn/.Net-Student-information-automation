using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.IO;
using static netsunu.Odevnet;


namespace netsunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*using (StreamWriter dosya = new StreamWriter("dosya2.txt", true))
                {
                    foreach (var item in listBox1.Items)
                    {
                         HOCAM EĞER KODLARDAKİ YORUM SATIRLARINI KALDIRINCA ANLAYACAKSINIZ VERİLERİ KAYITLI TUTMAYI BAŞARDIM ANCAK UYGULAMAYI KAPATIP AÇINCA BİLGİLERİ İKİYE KATLIYOR.
                         dosya.WriteLine(item.ToString()); ONUN HARİCİNDE BİR SIKINTI YOK UMARIM GEÇERİM ÇÜN KÜSON SENEM VE ALTTAN ALIYORUM. :)
                     
                    }
                }*/

            try
            {
         

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))
                {
                    MessageBox.Show("Lütfen boş kutucuk bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ogrenciNo = Convert.ToInt32(textBox3.Text);
                if (ogrenciNo < 0)
                {
                    MessageBox.Show("Lütfen pozitif bir öğrenci numarası girin.");
                    return;
                }

                int kısaSınav = Convert.ToInt32(textBox4.Text);
                int vize1 = Convert.ToInt32(textBox5.Text);
                int vize2 = Convert.ToInt32(textBox6.Text);
                int final = Convert.ToInt32(textBox7.Text);

                if (kısaSınav < 0 || kısaSınav > 100 || vize1 < 0 || vize1 > 100 || vize2 < 0 || vize2 > 100 || final < 0 || final > 100)
                {
                    MessageBox.Show("Lütfen sadece 0-100 aralığındaki notları girin.");
                    return;
                }

                // Textbox1 ve Textbox2'deki karakterleri büyük harfle yazmadan önce kontrol eder PromFİt//
                if (textBox1.Text == textBox1.Text.ToUpper() && textBox2.Text == textBox2.Text.ToUpper())
                {

                }
                else
                {
                    // Textbox'ların içeriği büyük harfle yazılmamışsa büyük harfe dönüştürür
                    textBox1.Text = textBox1.Text.ToUpper();
                    textBox2.Text = textBox2.Text.ToUpper();
                }

                double ortalama = kısaSınav * 0.1 + vize1 * 0.2 + vize2 * 0.2 + final * 0.5;
                textBox8.Text = ortalama.ToString();

                Odevnet odevnet = new Odevnet(textBox1.Text, textBox2.Text, ogrenciNo, dateTimePicker1.Text, kısaSınav, vize1, vize2, final);
                odevnet.HesaplaOrtalama(kısaSınav, vize1, vize2, final);

                UpdateList();



                DialogResult result = MessageBox.Show("Bu işlemin akabinde yeni bir kullanıcı daha eklemek istiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("O halde lütfen ileri butonuna basınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                


            }
            catch (ArgumentException ex)
            {

                if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))
                {
                    MessageBox.Show("Lütfen boş kutucuk bırakmayınız. Öğrenci NU ve Notlar bölümünü doldururken yalnızca RAKAM kullanınız ve notlar bölümüne sadece 0-100 arası bir değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ortalama aralığı 0-100 arasında olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Öğrenci NU ve Notlar bölümünü doldururken yalnızca RAKAM kullanınız ve notlar bölümüne sadece 0-100 arası bir değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UpdateList()
        {
            
            foreach (Odevnet odevnet in Odevnet.Ogrenciler)
            {

                string ListItem =
                    ($"{odevnet.Ad}" +
                     $" {odevnet.Soyad} " +
                     $"Numara : " +
                     $"{odevnet.OgrenciNo} " +
                     $"Doğum : " +
                     $"{odevnet.DogumTarihi} " +
                     $"Ortalama : " +
                     $"{odevnet.Ortalama}");

                

                // listbox'ta mevcut olup olmadığını kontrol ediyoruz
                if (!listBox1.Items.Contains(ListItem))
                {
                    listBox1.Items.Add(ListItem);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                /*if (listBox1.SelectedItem != null)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);

                    // "dosya.txt" dosyasındaki tüm verileri yeniden yaz
                    using (StreamWriter dosya = new StreamWriter("dosya2.txt"))
                    {
                        foreach (var item in listBox1.Items)
                        {
                            dosya.WriteLine(item.ToString());
                        }
                    }
                }*/
                

                int index = listBox1.SelectedIndex;
                if (index != -1)
                {
                    Ogrenciler.RemoveAt(index);
                    listBox1.Items.RemoveAt(index);
                    UpdateList();
                }
                else
                {
                    throw new Exception("Öğrenci seçilmedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool allEmpty = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (!string.IsNullOrEmpty(control.Text))
                    {
                        allEmpty = false;
                        break;
                    }
                }
            }

            if (allEmpty)
            {
                MessageBox.Show("Textbox'lar zaten temiz");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* using (StreamReader dosya = new StreamReader("dosya2.txt"))
            {
                string line;
                while ((line = dosya.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
             }*/ 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}