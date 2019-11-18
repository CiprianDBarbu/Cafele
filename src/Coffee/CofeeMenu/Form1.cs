using CoffeeBL;
using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeeMenu
{
    public partial class Form1 : Form
    {
        Order order = new Order();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                order.customer.name = txtUserName.Text;
                this.Text = $"Order for {order.customer.name}";

                if (lstCoffee.Items.Count == 0)
                {
                    CoffeeMenu cm = new CoffeeMenu();
                    cm.loadfromfile();

                    for (int i = 0; i < cm.CoffeeMenuList.Count; i++)
                    {
                        var curent = cm.CoffeeMenuList[i];
                        lstCoffee.Items.Add(curent);
                    }
                }
            }       
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            var x = lstCoffee.CheckedItems;

            for(int i = 0; i < x.Count; i++)
            {
                var curent = (Coffee)x[i];
                Ordered_Coffee aux = new Ordered_Coffee();

                aux.coffee_order = curent;
                order.coffees.Add(aux);

            }

            lblTotal.Text = order.total_price.ToString();
        }
    }
}
