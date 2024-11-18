using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace netsunu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                double threshold = double.Parse(textBox1.Text);

                if (threshold < 0 || threshold > 100)
                {
                    throw new ArgumentException("Ortalama eşiği 0-100 arasında olmalıdır.");
                }

                var sortedOgrenciler = Odevnet.Ogrenciler.Where(s => s.Ortalama < threshold).OrderByDescending(s => s.Ortalama);

                foreach (var odevnet in sortedOgrenciler)
                {
                    string odevnetInfo =
                        ($"{odevnet.Ad} " +
                         $"{odevnet.Soyad} " +
                         $"({odevnet.OgrenciNo})" +
                         $" - {odevnet.DogumTarihi}" +
                         $" - Ortalama: {odevnet.Ortalama}");
                    listBox1.Items.Add(odevnetInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                double threshold = double.Parse(textBox1.Text);

                if (threshold < 0 || threshold > 100)
                {
                    throw new ArgumentException("Ortalama eşiği 0-100 arasında olmalıdır.");
                }

                var sortedOgrenciler = Odevnet.Ogrenciler.Where(s => s.Ortalama > threshold).OrderByDescending(s => s.Ortalama);

                foreach (var odevnet in sortedOgrenciler)
                {
                    string odevnetInfo =
                        ($"{odevnet.Ad} " +
                         $"{odevnet.Soyad} " +
                         $"({odevnet.OgrenciNo})" +
                         $" - {odevnet.DogumTarihi}" +
                         $" - Ortalama: {odevnet.Ortalama}");
                    listBox1.Items.Add(odevnetInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                double minOrtalama = double.Parse(textBox1.Text);
                double maxOrtalama = double.Parse(textBox2.Text);

                if (minOrtalama < 0 || minOrtalama > 100 || maxOrtalama < 0 || maxOrtalama > 100)
                {
                    throw new ArgumentException("Ortalama aralığı 0-100 arasında olmalıdır.");
                }

                var sortedOgrenciler = Odevnet.Ogrenciler
                    .Where(s => s.Ortalama >= minOrtalama && s.Ortalama <= maxOrtalama)
                    .OrderByDescending(s => s.Ortalama);

                foreach (var odevnet in sortedOgrenciler)
                {
                    string odevnetInfo =
                        ($"{odevnet.Ad} " +
                         $"{odevnet.Soyad}" +
                         $" ({odevnet.OgrenciNo})" +
                         $" - {odevnet.DogumTarihi}" +
                         $" - Ortalama: {odevnet.Ortalama}");
                    listBox1.Items.Add(odevnetInfo);
                }
                DialogResult result = MessageBox.Show("Tüm işlemleri uyguladınız. Form3'e dönmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }
            catch (ArgumentException ex)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Lütfen 2 notu da giriniz ve tekrar deneyiniz.");
                }
                else
                {
                    MessageBox.Show("Ortalama aralığı 0-100 arasında olmalıdır.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen 2 notu da giriniz ve tekrar deneyiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
