using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class presentation : Form
    {
        public presentation()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circulP.Value += 1;
            circulP.Text = circulP.Value.ToString() + '%';
            if (circulP.Value == 100)
            {
                timer1.Enabled = false;
                login f = new login();
                timer1.Stop();
                f.Show();
                this.Hide();

            }
        }

        private void presentation_Load(object sender, EventArgs e)
        {

        }
    }
}
