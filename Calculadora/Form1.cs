namespace Calculadora
{
    public partial class Form1 : Form
    {
        public List<Double> values = new List<double>();
        public string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text += textBox1.Text + "+";
                values.Add(double.Parse(textBox1.Text));
                operation += "+";
                textBox1.Text = "";
            }
        }

        private void buttonSubt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text += textBox1.Text + "-";
                values.Add(double.Parse(textBox1.Text));
                operation += "-";
                textBox1.Text = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text += textBox1.Text + "/";
                values.Add(double.Parse(textBox1.Text));
                operation += "/";
                textBox1.Text = "";
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text += textBox1.Text + "x";
                values.Add(double.Parse(textBox1.Text));
                operation += "*";
                textBox1.Text = "";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double currentValue = values[0];
            values.Add(double.Parse(textBox1.Text));
            label1.Text = "";
            for (int i = 0; i < operation.Length; i++)
            {
                switch (operation[i])
                {
                    case '+':
                        currentValue += values[i + 1];
                        break;
                    case '-':
                        currentValue -= values[i + 1];
                        break;
                    case '/':
                        currentValue /= values[i + 1];
                        break;
                    case '*':
                        currentValue *= values[i + 1];
                        break;
                }

            }
            textBox1.Text = $"{currentValue}";
            values.Clear();
            operation = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            values.Clear();
            operation = "";
            textBox1.Text = "";
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text[0] != '-')
                textBox1.Text = "-" + textBox1.Text;
            else
                textBox1.Text = textBox1.Text.Substring(1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0,";
            else
                textBox1.Text += ",";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}