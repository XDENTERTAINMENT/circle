using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }
        
        private void btnClick_Click(object sender, EventArgs e)
        {
            double rad, area;
            rad = Convert.ToDouble(txtboxRadius.Text);
            area = Math.PI * Math.Pow(rad, 2);
            lblArea.Text = area.ToString();

        }
    }
}
