using Quanlyphongtro.UsingControlTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyphongtro
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            
            fpanelContainer.Controls.Clear();
            fpanelContainer.Controls.Add(userControl);
           
        }
        private void btnPizza_Click(object sender, EventArgs e)
        {
            ListPizza listPizza = new ListPizza();
            addUserControl(listPizza);
        }
     

        private void btnPasta_Click(object sender, EventArgs e)
        {
            ListPasta listPasta = new ListPasta();
            addUserControl(listPasta);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            ListDrink listDrink = new ListDrink();
            addUserControl(listDrink);
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            ListSalad listSalad = new ListSalad();
            addUserControl(listSalad);
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            ListAppetizer listAppetizer = new ListAppetizer();
            addUserControl(listAppetizer);
        }
    }
}
