namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            int result = value1 + value2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            int result = value1 * value2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            int result = value1 - value2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            int result = value1 / value2;
            textBox3.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}