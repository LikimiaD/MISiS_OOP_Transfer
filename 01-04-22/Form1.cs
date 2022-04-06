namespace _01_04_22
{
    public partial class Form1 : Form
    {
        Currency cur = new Currency();
        public Form1()
        {
            InitializeComponent();
            cur.rand();
            cur.main_index = cur.rnd.Next(0, 5);
            main_box.Items.Add(cur.currency_dict[cur.main_index].Split(" ")[0]);
            for (int _ = 0; _ < 5; _++)
            {
                transfer_box.Items.Add(cur.currency_dict[_].Split(" ")[0]);
            }
            restart();
        }
        public void restart()
        {
            main_value.Text = $"Баланс : {cur.main}";
            transfer_value.Text = "";
        }

        private void add_buton_Click(object sender, EventArgs e)
        {
            cur.main = cur.calc(0, cur.main, Convert.ToDouble(transfer_value.Text.ToString()),transfer_box.SelectedIndex);
            restart();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cur.main = cur.calc(1, cur.main, Convert.ToDouble(transfer_value.Text.ToString()), transfer_box.SelectedIndex);
            restart();
        }
    }
    class Currency
    {
        public Random rnd = new Random();
        public double main;
        public int main_index;
        public Dictionary<int,string> currency_dict = new Dictionary<int, string>()
                {
                { 0, "RUR 83" },
                { 1, "EUR 0,90" },
                { 2, "USD 1" },
                { 3, "GBP 0,76" },
                { 4, "KGS 93,10" },
                };
        public void rand()
        {
            main = rnd.Next(10000, 20000);
        }
        public double com(double value)
        {
            return value - value / 100;
        }
        public double calc(int choice, double main,double value, int value_index)
        {
            double end_value;
            if (!(main_index == value_index))
            {
                var main_usd = main * Convert.ToDouble(currency_dict[Convert.ToInt32(main_index)].Split(" ")[1]);
                main_usd = main_usd - com(main_usd);
                var add_usd = value * Convert.ToDouble(currency_dict[value_index].Split(" ")[1]);
                add_usd = add_usd - com(add_usd);
                if (choice == 0)
                {
                    end_value = (main_usd + add_usd) * Convert.ToDouble(currency_dict[main_index].Split(" ")[1]);
                }
                else
                {
                    end_value = (main_usd - add_usd) * Convert.ToDouble(currency_dict[main_index].Split(" ")[1]);
                }
                return end_value - com(end_value);
            }
            else
                if (choice == 0)
                return main + value;
            else
                return main - value;
        }
    }
}