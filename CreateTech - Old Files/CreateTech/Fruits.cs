using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTech
{
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }

        private void backbtnicon_Click(object sender, EventArgs e)
        {
            this.Close();
            new FoodCategory().Show();
        }

        private void pnlBackground_MouseHover(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLocalTime().ToShortTimeString(); // Changes the time
        }
    }
}
