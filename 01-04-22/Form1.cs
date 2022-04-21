using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Currency currency = new Currency();
        public Form1()
        {
            InitializeComponent();
            currency.value = currency.value_index;
            textBox3.Text = currency.value.ToString();
            foreach (var item in currency.convert)
            {
                comboBox1.Items.Add(item.Key);
                comboBox2.Items.Add(item.Key);
            }
            restart();
        }
        public void restart()
        {
            textBox3.Text = currency.value.ToString();
            textBox6.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void input_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                currency.calc(
                "add",
                Convert.ToDouble(textBox6.Text),
                currency.convert.ElementAt(comboBox1.SelectedIndex).Key,
                currency.convert.ElementAt(comboBox2.SelectedIndex).Key
                );
                restart();
            }
            else
                MessageBox.Show("Ты забыл чет написать =/");
        }

        private void output_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                currency.calc(
                    "vivod",
                    Convert.ToDouble(textBox6.Text),
                    currency.convert.ElementAt(comboBox1.SelectedIndex).Key,
                    currency.convert.ElementAt(comboBox2.SelectedIndex).Key
                    );
                restart();
            }
            else
                MessageBox.Show("Ты забыл чет написать =/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency.value = currency.value_index * Convert.ToDouble(currency.convert.ElementAt(comboBox1.SelectedIndex).Value);
            restart();
        }
    }
    class Currency : Billy
    {
        public Dictionary<string, string> convert = new Dictionary<string, string>()
                {
                { "USD", "1" },
                { "EUR", "0,93" },
                { "RUB", "83" },
                { "PLN", "0,23" },
                { "KAD", "0,79" }};
    
        public void calc(string method, double exalted, string name_of_main_currency, string name_of_transfer_name_currency)
        {
            if (name_of_main_currency == name_of_transfer_name_currency)
                if (method == "add")
                    value = value + exalted;
                else
                    value = value - exalted;
            else
            {
                var usd_main_value = value / Convert.ToDouble(convert[name_of_main_currency]);
                var usd_transfer_value = exalted / Convert.ToDouble(convert[name_of_transfer_name_currency]);
                if (method == "add")
                {
                    value = (usd_main_value + com(usd_transfer_value)) * Convert.ToDouble(convert[name_of_main_currency]);
                    value_index = usd_main_value + usd_transfer_value;
                }
                else
                {
                    value = (usd_main_value - com(usd_transfer_value)) * Convert.ToDouble(convert[name_of_main_currency]);
                    value_index = usd_main_value + usd_transfer_value;
                }
            }
        }
    }
    class Billy
    {
        public Random rnd = new Random();
        public double value = 10000;
        public double value_index = 10000;
        public double com(double exalted)
        {
            return exalted - exalted/100;
        }
    }
}
