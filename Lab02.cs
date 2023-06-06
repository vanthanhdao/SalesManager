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
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void Tinh_Click(object sender, EventArgs e)
        {

        }

        //Nhan 2 so 
        //Hai so a va b nhap tu ban phim
        private void Multiplication(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int c = a * b;
            txtNhan.Text = c.ToString();
        }
    }
}
