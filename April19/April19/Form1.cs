using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace April19
{
    public partial class MyUtilite : Form
    {
        public MyUtilite()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My programs There","About Program");
        }
    }
}
