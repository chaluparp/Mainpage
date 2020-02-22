using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass
{
    public partial class bizt : Form
    {
        public bizt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 b = new Form1();
            b.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main h = new Main();
            h.Show();
            
        }
    }
}
