using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Oil_station_task
{
    public partial class Form1 : Form
    {
        List<Fuel> fuels = new List<Fuel>();
        List<Food> foods = new List<Food>();
        public Form1()
        {
            InitializeComponent();

            fuels.Add(new Fuel
            {
                Name = "AI92",
                Price = 1
            });
            fuels.Add(new Fuel
            {
                Name = "AI95",
                Price = 1.8
            });
            fuels.Add(new Fuel
            {
                Name = "AI98",
                Price = 2.3
            });
            fuels.Add(new Fuel
            {
                Name = "Diesel",
                Price = 0.8
            });
            fuels.Add(new Fuel
            {
                Name = "LPG",
                Price = 0.5
            });
            Food burger = new Food
            {
                FoodName = "Burger",
                FoodPrice = 5.6
            };
            Food hotdog = new Food
            {
                FoodName = "Hotdog",
                FoodPrice = 3.4
            };
            Food Nuggets = new Food
            {
                FoodName = "Nuggets",
                FoodPrice = 4.5
            };
            Food Cola = new Food
            {
                FoodName = "Coca Cola",
                FoodPrice = 2.3
            };
            Food pepsi = new Food
            {
                FoodName = "Pepsi",
                FoodPrice = 2.4
            };
            foods.Add(Cola); foods.Add(pepsi); foods.Add(Nuggets); foods.Add(hotdog); foods.Add(burger);
            guna2ComboBox1.DisplayMember = nameof(Fuel.Name);
            guna2ComboBox1.Items.AddRange(fuels.ToArray());
            guna2ComboBox1.SelectedIndex = 0;
            HotdogGunaCheckBox.Text = hotdog.FoodName;
            ColaGunaCheckBox.Text = Cola.FoodName;
            PepsiGunaCheckBox.Text = pepsi.FoodName;
            BurgerGunaCheckBox.Text = burger.FoodName;
            NuggetsGunaCheckBox.Text = Nuggets.FoodName;
        }

        private void MoneyGunaRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Moneymaskedtxtb.Enabled = true;
            Litermaskedtxtb.Enabled = false;
        }

        private void LiterGunaRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Litermaskedtxtb.Enabled = true;
            Moneymaskedtxtb.Enabled = false;
        }

        private void Moneymaskedtxtb_TextChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "AI92")
            {
                double.Parse(Moneymaskedtxtb.Text) /1;
            }

        }
    }
}
