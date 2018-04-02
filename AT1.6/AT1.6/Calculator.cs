using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT1._6
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //the follow several methods handles the number buttons being clicked, adding the relevent number to the textbox
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        //Clears the textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }


        //checks that the input is not 0 then runs the SquareRoot method on the input
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = squareRoot(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
        }

        //Handles the cube root button being clicked
        private void btnCubeRT_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = cubeRoot(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
        }

        //Handles the Inverse Function being clicked
        private void btnInv_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = inverse(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
        }

        //Handles the Tan function button being clicked
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    if (num != 90)
                    {
                        txtDisplay.Text = tan(num).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tan(90) is undefined", "Error Message");
                    }
                }
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        //handles the Sin function button being clicked
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = sine(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
        }

        //handles the Cos function 
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = cosine(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
        }

        //calls the MathsLib.Algebraic.squareRoot function. returns the sqrt of x as a double
        private double squareRoot(double x)
        {
            return MathsLib.Algebraic.squareRoot(x);
        }

        //calls the MathsLib.Algebraic.cubeRoot function. returns the Cube Root of x as a double
        private double cubeRoot(double x)
        {
            return MathsLib.Algebraic.cubeRoot(x);
        }

        //calls the MathsLib.Trigometric.Inverse function. returns the Inverse of x as a double
        private double inverse(double x)
        {
            return MathsLib.Algebraic.inverse(x);
        }

        //calls the MathsLib.Trigometric.Tan function. returns Tan(x) as a double
        private double tan(double x)
        {
            return MathsLib.Trigometric.Tan(x);
        }

        //calls the MathsLib.Trigometric.Sine function. returns Sine(x) as a double
        private double sine(double x)
        {
            return MathsLib.Trigometric.Sine(x);
        }

        //calls the MathsLib.Trigometric.Cosine function. returns Cosine(x) as a double
        private double cosine(double x)
        {
            return MathsLib.Trigometric.Cosine(x);
        }

        //Explain each of the Variables
        double subTotal = 0; //Stores the current number we are up to so we can work on it
        double outPut = 0; //stores the final result for output
        bool plusButtonClicked = false; //was the plus button clicked last
        bool minusButtonClicked = false;//was the minus button clicked last
        bool divideButtonClicked = false;//was the divide button clicked last
        bool multiplyButtonClicked = false;//was the multiply button clicked last

        //the following four methods handle the +, - ,*  and - buttons. its stores the variables in the subtotal, and sets the flag for which button was clicked last
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                subTotal += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            { 
                subTotal += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            }
            else
            {
                txtDisplay.Text = "-";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                subTotal += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                subTotal += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
            }
            
        }

       
        //Checks which buton was clicked last by reading the flags, and performs the relevent operations
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true)
            {
                outPut = MathsLib.Arithmetic.Add(subTotal, double.Parse(txtDisplay.Text));
            }
            else if (minusButtonClicked == true)
            {
                outPut = MathsLib.Arithmetic.Sub(subTotal, double.Parse(txtDisplay.Text));
            }
            else if (divideButtonClicked == true)
            {
                outPut = MathsLib.Arithmetic.Divide(subTotal, double.Parse(txtDisplay.Text));
            }
            else if (multiplyButtonClicked == true)
            {
                outPut = MathsLib.Arithmetic.Multi(subTotal, double.Parse(txtDisplay.Text));
            }

            //output the result to display
            txtDisplay.Text = outPut.ToString();
            subTotal = 0;
        }

        //Menu item to quit
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Menu item to clear the calc
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //Function for checking if a string is numeric
        private Boolean isNumeric(string input)
        {
            if(double.TryParse(input,out double result ))
            {
                return true;
            }
            return false;
        }
    }
}

