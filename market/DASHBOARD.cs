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
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circulPB.Value += 1;
            circulPB.Text = circulPB.Value.ToString() + "%";
            if (circulPB.Value == 60)
            {
                timer1.Enabled = false;
            }
        }
    }
}
