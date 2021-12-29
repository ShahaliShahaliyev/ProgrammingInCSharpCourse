using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var maxWidth = this.ClientSize.Width;
            var maxHeight = this.ClientSize.Height;
             
            this.CatchMe.Location = new Point(random.Next(maxWidth),random.Next(maxHeight));

            MessageBox.Show("You WIN");
        }
    }
}
