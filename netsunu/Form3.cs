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

namespace netsunu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var odevnet in Odevnet.Ogrenciler.OrderBy(s => s.OgrenciNo))
            {
                string odevnetInfo =
                    ($"{odevnet.Ad}" +
                    $" {odevnet.Soyad}" +
                    $" - Öğrenci No: ({odevnet.OgrenciNo})" +
                    $" - Doğum Tarihi: " +
                    $"{odevnet.DogumTarihi}" +
                    $" - Ortalama: {odevnet.Ortalama}");
                listBox1.Items.Add(odevnetInfo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var odevnet in Odevnet.Ogrenciler.OrderBy(s => s.Ortalama))
            {
                string odevnetInfo =
                    ($"{odevnet.Ad} " +
                     $"{odevnet.Soyad}" +
                     $" - Öğrenci No: " +
                     $"({odevnet.OgrenciNo})" +
                     $" - Doğum Tarihi: " +
                     $"{odevnet.DogumTarihi}" +
                     $" - Ortalama: " +
                     $"{odevnet.Ortalama}");
                listBox1.Items.Add(odevnetInfo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Liste boş gözükebilir, bilgileriniz silinmedi! Yenileye basarsanız göreceksiniz.", "Uyarı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
