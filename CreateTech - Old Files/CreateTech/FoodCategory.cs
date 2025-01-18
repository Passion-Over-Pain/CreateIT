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
    public partial class FoodCategory : Form
    {
        public FoodCategory()
        {
            InitializeComponent();
        }

        private void backbtnicon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to return to the sign in page?", "Warning Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new frmHome().Show();
            }
            else
            {
                MessageBox.Show("Cancelled successfully, enjoy browsing CreateIT's food categories.", "Abort Confirmed");
            }
        }

        private void pnlCarbohydrates_Click(object sender, EventArgs e)
        {
            this.Close();
            new Carbohydrates().Show();
        }

        private void pnlDairy_Click(object sender, EventArgs e)
        {
            this.Close();
            new Dairy_Products().Show();
        }

        private void pnlFruits_Click(object sender, EventArgs e)
        {
            this.Close();
            new Fruits().Show();
        }

        private void pnlFats_Click(object sender, EventArgs e)
        {
            this.Close();
            new FatsandOils().Show();
        }

        private void pnlProtein_Click(object sender, EventArgs e)
        {
            this.Close();
            new Protien().Show();
        }

        private void pnlVegetables_Click(object sender, EventArgs e)
        {
            this.Close();
            new Vegetables().Show();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLocalTime().ToShortTimeString(); // Changes the time
        }
    }
}
