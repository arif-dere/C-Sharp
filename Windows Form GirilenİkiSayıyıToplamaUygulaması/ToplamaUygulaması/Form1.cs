namespace ToplamaUygulaması
{
    public partial class Form1 : System.Windows.Forms.Form
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, toplam;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            toplam = sayı1 + sayı2;
            textBox3.Text = toplam.ToString();
            textBox3.Enabled = false;
        }
    }
}
