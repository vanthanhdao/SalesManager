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
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0); 

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            panelPassword.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            panelEmail.BackColor = SystemColors.Control;
            txtEmail.BackColor = SystemColors.Control;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
            panelEmail.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            panelPassword.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
           
        }

        private void btnEye_Off_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnEye_Off.Visible = false;
            btnEye.Visible = true;
            txtPassword.Focus();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnEye_Off.Visible = true;
            btnEye.Visible = false;
            txtPassword.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location =  new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }

        }

        private void btnMInimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Hide();
            employee.ShowDialog();
            this.Show();

        }
    }
}
