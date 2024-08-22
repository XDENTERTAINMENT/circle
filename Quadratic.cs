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
    public partial class Quadratic : Form
    {
        public Quadratic()
        {
            InitializeComponent();
        }
       


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try

            {

                a = Convert.ToDouble(txtQuadA.Text);

                b = Convert.ToDouble(txtQuadB.Text);

                c = Convert.ToDouble(txtQuadC.Text);



                string result = CalculateQuadraticRoots(a, b, c);
                txtResult.Text = result;



                 if (result.Contains("i"))
                {
                    txtResult.ForeColor = Color.Red;
                }
                else
                {
                    txtResult.ForeColor = Color.Black;
                }


            }

            catch (FormatException)
            {
                txtResult.Text = "Please enter valid numbers for a, b, and c.";
                txtResult.ForeColor = Color.Red;
            }

            catch (Exception ex)
            {
                txtResult.Text = $"Error: {ex.Message}";
                txtResult.ForeColor = Color.Red;
            }

        }


        public double DeterminantQuad(double b, double a, double c)

        {

            return ((b * b) - (4 * a * c));

        }


        private string CalculateQuadraticRoots(double a, double b, double c)
        {
            double determinant = DeterminantQuad(a, b, c);
            if (determinant > 0)
            {
                double root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(determinant)) / (2 * a);
                return $"Root 1: {root1}\n\tRoot 2: {root2}";
            }
            else if (determinant == 0)
            {
                double root = -b / (2 * a);
                return $"Root: {root}";
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-determinant) / (2 * a);
                return $"Root 1: {realPart} + {imaginaryPart}i\n\tRoot 2: {realPart} - {imaginaryPart}i";
            }
        }

    }

   

}
