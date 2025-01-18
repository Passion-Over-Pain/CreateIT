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
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Trolley().Show();
        }

        private void Recipes_MouseMove(object sender, MouseEventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLocalTime().ToShortTimeString(); // Changes the time
        }
    }
}
