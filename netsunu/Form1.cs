namespace netsunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KtextBox1.Text == "" || StextBox2.Text == "")
            {
                MessageBox.Show("Eksik bilgi !");
            }
            else if (KtextBox1.Text == ".NETSUNU" && StextBox2.Text == "2023")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz þifre ya da kullanýcý !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KtextBox1.Text = "";
            StextBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}