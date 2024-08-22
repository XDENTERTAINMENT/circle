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
    public partial class Pythagoras : Form
    {
        public Pythagoras()
        {
            InitializeComponent();
        }
        private double hypotenus (double opp, double adj)
        {
            double hyp = Math.Sqrt(Math.Pow(opp, 2) + Math.Pow(adj,2));
            return hyp;
        }
        private double adjacent(double hyp, double opp) 
        {
            double adj = Math.Sqrt((Math.Pow(hyp, 2) + (Math.Pow(opp, 2))));
            return adj;
        }
        private double opposite (double hyp, double adj)
        {
            double opp = Math.Sqrt((Math.Pow(hyp,2) + (Math.Pow(adj,2))));
            return opp;
        }
        private void cmbside_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbside.Text == "Adjacent")
            {
                lblfirst.Text = "Opposite";
                lblsec.Text = "Hypotenus";
            }
            else if (cmbside.Text == "Opposite")
            {
                lblfirst.Text = "Adjacent";
                lblsec.Text = "Hypotenus";
            }
            if (cmbside.Text == "Hypotenus")
            {
                lblfirst.Text = "Adjacent";
                lblsec.Text = "Opposite";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbside.Text != "")
            {
                if(txtfirst.Text != "" &&  txtsec.Text != "")
                {
                    if (cmbside.Text == "Opposite" & Convert.ToDouble(txtsec.Text) <= Convert.ToDouble(txtfirst.Text))
                    {
                        MessageBox.Show("The Hypotenus is always the longest side");
                    }
                    else if (cmbside.Text == "Adjacent" & Convert.ToDouble(txtsec.Text) <= Convert.ToDouble(txtfirst.Text))
                    {
                        MessageBox.Show("The Hypotenus is always the longest side");
                    }
                    else if(cmbside.Text == "Hypotenus")
                    {
                        double hyp = hypotenus(Convert.ToDouble(txtfirst.Text), Convert.ToDouble(txtsec.Text));
                        lblanswer.Text = hyp.ToString();
                    }
                    else if (cmbside.Text == "Adjacent")
                    {
                        double adj = adjacent(Convert.ToDouble(txtfirst.Text), Convert.ToDouble(txtsec.Text));
                        lblanswer.Text = adj.ToString();
                    }
                    else if (cmbside.Text == "Opposite")
                    {
                        double opp = opposite(Convert.ToDouble(txtfirst.Text), Convert.ToDouble(txtsec.Text));
                        lblanswer.Text = opp.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Provide values for the availabe sides");
                }
            }
            else
            {
                MessageBox.Show("Choose a side to find for");
                txtfirst.Clear();
                txtsec.Clear();
            }
        }
    }
}
