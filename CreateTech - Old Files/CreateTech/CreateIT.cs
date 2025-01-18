using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CreateTech
{
    public partial class CreateIT : Form
    {
        public CreateIT()
        {
            InitializeComponent();
           
        }
        public void Loading()
        {
            this.Hide();
            new frmHome().Show();
           
        }

        private void CreateIT_MouseMove(object sender, MouseEventArgs e)
        {
           // Thread.Sleep(100); // This is what gives the illusion of the loading state
            Loading();
        }
    }
}
