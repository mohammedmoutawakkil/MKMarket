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
using FontAwesome.Sharp;

namespace market
{
    public partial class Form1 : Form
    {
        //field
        private IconButton currentbtn;
        private Panel leftberderbtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
           
            leftberderbtn = new Panel();
            leftberderbtn.Size = new Size(7, 60);
            panelmenu.Controls.Add(leftberderbtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

       

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color1);
            lblhome.Text = dashbtn.Text;
            Openforms(new DASHBOARD());
            notifications.Visible = true;
            Profil_name.Visible = true;
            bars.Visible = true;
            anagl_down.Visible = true;
        }
        //methods
        private void ActivateButton(object senderBT, Color color)
        {
            if (senderBT != null)
            {
                DisableButton();
                // button
                currentbtn = (IconButton)senderBT;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //left berder button
                leftberderbtn.BackColor = color;
                leftberderbtn.Location = new Point(0, currentbtn.Location.Y);
                leftberderbtn.BringToFront();
                leftberderbtn.Visible = true;
                //Icon
                iconCHARFORM.IconChar = currentbtn.IconChar;
                iconCHARFORM.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {

                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private class RGBCOLORS
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(57, 164, 50);
        }
        private void Openforms(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Dock = DockStyle.Fill;
            panelDESKTOP.Controls.Add(childForm);
            panelDESKTOP.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblhome.Text = childForm.Text;

        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color2);
            Openforms(new Orders());
            lblhome.Text = orderbtn.Text;
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color3);
            Openforms(new Products());
            lblhome.Text = productbtn.Text;
        }

        private void custemersbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color4);
            Openforms(new Custemers());
            lblhome.Text = productbtn.Text;
        }

        private void marketingbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color5);
            Openforms(new Marketing());
            lblhome.Text = productbtn.Text;
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color6);
            Openforms(new Settings());
            lblhome.Text = productbtn.Text;
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOLORS.color7);
            Openforms(new About());
            lblhome.Text = productbtn.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftberderbtn.Visible = false;
            iconCHARFORM.IconChar = IconChar.Home;
            iconCHARFORM.IconColor = Color.MediumPurple;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void iconCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Profil_name_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDESKTOP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
