using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2___calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            byte first;
            byte second;
            try
            {
                first = byte.Parse(textBoxNumber1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("First number should be an double");
                return;
            }

            try
            {
                second = byte.Parse(textBoxNumber2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Second number should be an double");
                return;
            }

            int result = first + second;
            MessageBox.Show(result.ToString());

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double first;
            double second;
            bool isParasablefirst = double.TryParse(textBoxNumber1.Text, out first);
            if (!isParasablefirst)
            {
                MessageBox.Show("First number should be a double!");
                return;
            }
            bool isParasablesecond = double.TryParse(textBoxNumber2.Text, out second);
            if (!isParasablesecond)
            {
                MessageBox.Show("Second number should be a double!");
                return;
            }
            double result = first - second;
            MessageBox.Show(result.ToString());
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            double first;
            double second;
            bool isParasablefirst = double.TryParse(textBoxNumber1.Text, out first);
            if (!isParasablefirst)
            {
                MessageBox.Show("First number should be a double!");
                return;
            }
            bool isParasablesecond = double.TryParse(textBoxNumber2.Text, out second);
            if (!isParasablesecond)
            {
                MessageBox.Show("Second number should be a double!");
                return;
            }
            double result = first * second;
            MessageBox.Show(result.ToString());
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            double first;
            double second;
            bool isParasablefirst = double.TryParse(textBoxNumber1.Text, out first);
            if (!isParasablefirst)
            {
                MessageBox.Show("First number should be a double!");
                return;
            }
            bool isParasablesecond = double.TryParse(textBoxNumber2.Text, out second);
            if (!isParasablesecond)
            {
                MessageBox.Show("Second number should be a double!");
                return;
            }
            if (second == 0)
            {
                MessageBox.Show("Division by zero!");
                return;
            }
            double result = first / second;
            MessageBox.Show(result.ToString());
        }
    }
}
