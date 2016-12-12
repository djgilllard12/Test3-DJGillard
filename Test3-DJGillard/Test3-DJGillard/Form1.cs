using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3_DJGillard
{
    public partial class Test3 : Form
    {
        public Test3()
        {
            InitializeComponent();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            // creating varaiables
            Boolean formOk = true;
            Int32 product=0;
            Int32 num1 = Convert.ToInt32(txtInput1.Text);
            Int32 num2 = Convert.ToInt32(txtInput2.Text);
            // validating variables
            if (Int32.TryParse(txtInput1.Text, out num1)== false)
            {
                lblErrorMessage1.Visible = true;
                formOk = false;
            }
            if (Int32.TryParse(txtInput2.Text, out num2) == false)
            {
                lblErrorMessage2.Visible = true;
                formOk = false;
            }
            else
            {
                // creating method
                formOk = true;
                lblOutputProduct.Text = multiplyNumbers(product);
            }
        }
        private String multiplyNumbers(Int32 product)
        {
            // using method to calculate product and output it
            String message;
            Int32 num1 = Convert.ToInt32(txtInput1.Text);
            Int32 num2 = Convert.ToInt32(txtInput2.Text);
            product = num1 * num2;
            message = Convert.ToString(product);
            return message;
        }


        private void btnLoopChristmas_Click(object sender, EventArgs e)
        {
            // creating array
            String[] christmas = new String[3];
            christmas[0] = "Merry";
            christmas[1] = "Christmas";
            christmas[2] = "C# is great";
            //looping array
            for (var i = 0; i <= 2; i++)
            {
                lblLoopChristmas.Text += " " + christmas[i];
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String password = txtPassword.Text;
            if (password == "frosty")
            {
                // outputing the correct colors and error message
                lblLoginMessage.Text = "You entered the correct password";
                lblLoginMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblLoginMessage.Text = "You entered the incorrect password";
                lblLoginMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnLoopMovies_Click(object sender, EventArgs e)
        {
            String[,] movies = new String[3, 2];
            // creating 2-D array
            movies[0, 0] = "How the Grinch Stole Christmas";
            movies[0, 1] = "1966";
            movies[1, 0] = "Frosty the Snowman";
            movies[1, 1] = "1969";
            movies[2, 0] = "Arthur Christmas";
            movies[2, 1] = "2011";
            
            // loop through the array
            for (var i = 0; i<=2; i++)
            {
                lblLoopMovies.Text += Convert.ToString(movies[i, 0] + "-" + movies[i,1])+ " ";
            }
        }

        private void btnShowMonths_Click(object sender, EventArgs e)
        {
            String season = Convert.ToString(cboSeason);
            // deciding which months to fill second combobox with
            if (season == ("Spring"))
            {
                cboMonths.Items.Add("March");
                cboMonths.Items.Add("April");
                cboMonths.Items.Add("May");
            }
            if (season == "Summer")
            {
                cboMonths.Items.Add("June");
                cboMonths.Items.Add("July");
                cboMonths.Items.Add("August");
            }
            if (season == "Fall")
            {
                cboMonths.Items.Add("September");
                cboMonths.Items.Add("October");
                cboMonths.Items.Add("November");
            }
            if (season == "Winter")
            {
                cboMonths.Items.Add("December");
                cboMonths.Items.Add("January");
                cboMonths.Items.Add("Febuary");
            }

        }

        private void btnQ7_Click(object sender, EventArgs e)
        {
            // fixing broken code
            Double x = 4;
            Double y = 12;
            Double result = x / y;
            lblQ7.Text = Convert.ToString(result);
        }
    }
} 

