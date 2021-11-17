using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace market
{
    public partial class login : Form
    {
        
       
        public login()
        {
            InitializeComponent();
        }
        Sign_in n ;
        int c = 0;
        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            
            iconuser.IconColor = Color.FromArgb(0, 64, 64);
            paneluser.BackColor= Color.FromArgb(0, 64, 64);
            txtusername.ForeColor= Color.FromArgb(0, 64, 64);
            if (txtpassword.Text==""||txtpassword.Text=="Password")
            {
                if (txtusername.Text == "" || txtusername.Text == "User Name")
                {
                    txtusername.Clear();
                }
                //disable
            txtpassword.UseSystemPasswordChar = false;
            iconpassword.IconColor = Color.White;
            txtpassword.Text = "Password";
            panelpassword.BackColor = Color.White;
            txtpassword.ForeColor = Color.White;

            }
            if (txtpassword.Text != "" && txtpassword.Text != "Password")
            {
                if (txtusername.Text == "" || txtusername.Text == "User Name")
                {
                    txtusername.Clear();
                }
                //disable
                iconpassword.IconColor = Color.White;
                panelpassword.BackColor = Color.White;
                txtpassword.ForeColor = Color.White;
            }
           
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            iconpassword.IconColor = Color.FromArgb(0, 64, 64);
            panelpassword.BackColor = Color.FromArgb(0, 64, 64);
            txtpassword.ForeColor = Color.FromArgb(0, 64, 64);
            txtpassword.UseSystemPasswordChar = true;
            if (txtusername.Text==""||txtusername.Text== "User Name")
            {
                if (txtpassword.Text == "" || txtpassword.Text == "Password")
                {
                    txtpassword.Clear();
                }
            //disable
            iconuser.IconColor = Color.White;
            txtusername.Text = "User Name";
            paneluser.BackColor = Color.White;
            txtusername.ForeColor = Color.White;

            }
            if (txtusername.Text != "" && txtusername.Text != "User Name")
            {
                if (txtpassword.Text == "" || txtpassword.Text == "Password")
                {
                    txtpassword.Clear();
                }
                iconuser.IconColor = Color.White;
                paneluser.BackColor = Color.White;
                txtusername.ForeColor = Color.White;
            }

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            pnl_password_error.Visible = false;
            pnl_username_error.Visible = false;

            Form1 f = new Form1();
            f.Show();
            this.Hide();
            
        }

        private void lblSingIn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            n = new Sign_in();
            n.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == null)
            {
                n = new Sign_in();
                n.Show();
            }
           
            
            this.ShowInTaskbar = false;
            n.Left += 10;
            c += 10;
            if (n.Left >= 970)
            {
                timer1.Stop();
                this.TopMost = false;
                n.TopMost = true;
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            n.Left -= 10;
            c -= 10;
            if (c <= 0)
            {
                timer2.Stop();
                this.Hide();
            }

        }

        private void facebookbtn_Click(object sender, EventArgs e)
        {

        
        }

        private void iconCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconLOGO_Click(object sender, EventArgs e)
        {

        }
    }
}
