using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concatenation
{
    public partial class Concatenation : Form
    {
        public Concatenation()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text = txtZone1.Text + txtZone2.Text;
            txtResult.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtZone1.Clear();
            txtZone2.Clear();
        }

        private void txtZone2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = txtZone1.Text + txtZone2.Text;
        }
    }
}
