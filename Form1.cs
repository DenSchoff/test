using System.IO;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dealer dealer = new Dealer();

        private void Form1_Load(object sender, EventArgs e)
        {
            dealer.Add("Toyota", "Land Cruiser", 4000000);
            dealer.Add("Toyota", "Camry", 1800000);
            dealer.Add("Toyota", "Prius", 2500000);
            dealer.Add("Renault", "Logan", 400000);
            dealer.Add("Renault", "Sandero", 600000);
            dealer.Add("Renault", "Duster", 1400000);
            dealer.Add("Renault", "Captur", 1600000);
            dealer.Add("Lada", "2114", 160000);
            dealer.Add("Lada", "2109", 120000);
            dealer.Add("Lada", "2107", 90000);
            dealer.Add("BMW", "M5 E34", 520000);
            dealer.Add("BMW", "X6", 1500000);
            dealer.Add("BMW", "i3", 3000000);
            dealer.Add("BMW", "Z4", 4000000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealer.Add(textBox1.Text, textBox2.Text, Convert.ToUInt32(textBox3.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dataGridView1.Rows.Add(dealer.ReturnCar(dealer.Car_list_id - 1).Id,
                                   dealer.ReturnCar(dealer.Car_list_id - 1).Brand,
                                   dealer.ReturnCar(dealer.Car_list_id - 1).Model,
                                   dealer.ReturnCar(dealer.Car_list_id - 1).Cost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dealer.Car_list_id; i++)
            {
                dataGridView1.Rows.Add(dealer.ReturnCar(i).Id, dealer.ReturnCar(i).Brand,
                                       dealer.ReturnCar(i).Model, dealer.ReturnCar(i).Cost);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string choose = textBox4.Text;
            var BrandModelChoose = from auto in dealer.cars
                                   where auto.Brand == choose || auto.Model == choose
                                   orderby auto.Cost ascending
                                   select auto;
            textBox4.Text = "";

            dataGridView1.Rows.Clear();
            foreach (var auto in BrandModelChoose)
            {
                dataGridView1.Rows.Add(auto.Id, auto.Brand, auto.Model, auto.Cost);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max = Int32.Parse(textBox6.Text);
            int min = Int32.Parse(textBox5.Text);
            var CostBrandGroups = from auto in dealer.cars
                                   where auto.Cost <= max && auto.Cost >= min
                                   orderby auto.Cost ascending
                                   group auto by auto.Brand into brandGroup
                                   orderby brandGroup.Key
                                   select brandGroup;

            dataGridView1.Rows.Clear();

            foreach (var brandGroups in CostBrandGroups)
            { 
                foreach (var auto in brandGroups)
                {
                    dataGridView1.Rows.Add(auto.Id, auto.Brand, auto.Model, auto.Cost);
                }
            }
        }
    }
}
