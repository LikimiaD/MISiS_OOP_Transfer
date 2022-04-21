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
            currency.rand();
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
            currency.calc(
                "add",
                Convert.ToDouble(textBox6.Text),
                currency.convert.ElementAt(comboBox1.SelectedIndex).Key,
                currency.convert.ElementAt(comboBox2.SelectedIndex).Key
                );
            restart();
        }

        private void output_Click(object sender, EventArgs e)
        {
            currency.calc(
                "vivod",
                Convert.ToDouble(textBox6.Text),
                currency.convert.ElementAt(comboBox1.SelectedIndex).Key,
                currency.convert.ElementAt(comboBox2.SelectedIndex).Key
                );
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
                var usd_main_value = com(value / Convert.ToDouble(convert[name_of_main_currency]));
                var usd_transfer_value = com(exalted / Convert.ToDouble(convert[name_of_transfer_name_currency]));
                if (method == "add")
                    value = (usd_main_value + usd_transfer_value) * Convert.ToDouble(convert[name_of_main_currency]);
                else
                    value = (usd_main_value - usd_transfer_value) * Convert.ToDouble(convert[name_of_main_currency]);
            }
        }
        public void rand()
        {
            value = rnd.Next(10000, 20000);
        }
    }
    class Billy
    {
        public Random rnd = new Random();
        public double value;
        public double com(double exalted)
        {
            return exalted - exalted/100;
        }
    }
}
