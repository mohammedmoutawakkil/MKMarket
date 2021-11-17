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
    public partial class Sign_in : Form
    {
        

        public Sign_in()
        {
            InitializeComponent();
        }
        //login form
        login n;
        //counter
        int c = 0;
        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            iconuser.IconColor = Color.FromArgb(0, 64, 64);
            paneluser.BackColor = Color.FromArgb(0, 64, 64);
            txtusername.ForeColor = Color.FromArgb(0, 64, 64);
            if (txtpassword.Text == "" || txtpassword.Text == "Password")
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
            if (txtemail.Text==""||txtemail.Text=="Email")
            {
                if (txtusername.Text == "" || txtusername.Text == "User Name")
                {
                    txtusername.Clear();
                }
                iconemail.IconColor = Color.White;
                txtemail.Text = "Email";
                panelemail.BackColor = Color.White;
                txtemail.ForeColor = Color.White;
            }
           

            if (txtemail.Text != "" && txtemail.Text != "Email")
            {
                if (txtusername.Text == "" || txtusername.Text == "User Name")
                {
                    txtusername.Clear();
                }
                //disable email
                iconemail.IconColor = Color.White;
                panelemail.BackColor = Color.White;
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            iconpassword.IconColor = Color.FromArgb(0, 64, 64);
            panelpassword.BackColor = Color.FromArgb(0, 64, 64);
            txtpassword.ForeColor = Color.FromArgb(0, 64, 64);
            txtpassword.UseSystemPasswordChar = true;
            if (txtusername.Text == "" || txtusername.Text == "User Name")
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
            if (txtemail.Text == "" || txtemail.Text == "Email")
            {
                if (txtpassword.Text == "" || txtpassword.Text == "User Name")
                {
                    txtpassword.Clear();
                }
                iconemail.IconColor = Color.White;
                txtemail.Text = "Email";
                panelemail.BackColor = Color.White;
                txtemail.ForeColor = Color.White;
            }


            if (txtemail.Text != "" && txtemail.Text != "Email")
            {
                if (txtpassword.Text == "" || txtpassword.Text == "User Name")
                {
                    txtpassword.Clear();
                }
                //disable email
                iconemail.IconColor = Color.White;
                panelemail.BackColor = Color.White;
                txtemail.ForeColor = Color.White;
            }

        }

        private void txtemail_Click(object sender, EventArgs e)
        {

            iconemail.IconColor = Color.FromArgb(0, 64, 64);
            panelemail.BackColor = Color.FromArgb(0, 64, 64);
            txtemail.ForeColor = Color.FromArgb(0, 64, 64);
            if (txtpassword.Text == "" || txtpassword.Text == "Password")
            {
                if (txtemail.Text == "" || txtemail.Text == "Email")
                {
                    txtemail.Clear();
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
                if (txtemail.Text == "" || txtemail.Text == "Email")
                {
                    txtemail.Clear();
                }
                //disable
                iconpassword.IconColor = Color.White;
                panelpassword.BackColor = Color.White;
                txtpassword.ForeColor = Color.White;
            }
            if (txtusername.Text == "" || txtusername.Text == "User Name")
            {
                if (txtemail.Text == "" || txtemail.Text == "Email")
                {
                    txtemail.Clear();
                }
                //disable
                iconuser.IconColor = Color.White;
                txtusername.Text = "User Name";
                paneluser.BackColor = Color.White;
                txtusername.ForeColor = Color.White;

            }
            if (txtusername.Text != "" && txtusername.Text != "User Name")
            {
                if (txtemail.Text == "" || txtemail.Text == "Email")
                {
                    txtemail.Clear();
                }
                iconuser.IconColor = Color.White;
                paneluser.BackColor = Color.White;
                txtusername.ForeColor = Color.White;
            }

        }

        private void iconCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void singnbtn_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n==null)
            {
                n = new login();
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
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Sign_in_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
