using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmiCalculator
{
    public partial class bmi_calculator : Form
    {
        //Global variable used to tell the unit used for data entry
        int unitType = 0;

        public bmi_calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear_heightWeightLbl();
        }

        /*
         * Method for clearing the fields of text to be reused, either for new data or a change of units.
         */
        public void clear_heightWeightLbl()
        {
            heightEntry1_lbl.Text = "";
            heightEntry2_lbl.Text = "";
            weightEntry_lbl.Text = "";
            heightEntryCM_lbl.Text = "";
            weightEntryKG_lbl.Text = "";
            bmiOutput_txt.Text = "";
        }

        /*
         * Method for setting the fields of text to imperial units, runs after the radio button is selected.
         */
        private void imperial_rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (imperial_rdo.Checked)
            {
                //Sets up unitType int to the imperial setting for later use in a switch statement.
                unitType = 1;
                clear_heightWeightLbl();
                //Makes sure the entry field for inches is visible to the user if they are working with imperial units.
                heightInch_txt.Visible = true;

                //Sets up the titles for imperial units and hides the metric titles.
                heightEntry1_lbl.Text = "(Feet)";
                heightEntry2_lbl.Text = "(Inches)";
                heightEntryCM_lbl.Text = "";
                weightEntry_lbl.Text = "(Pounds[lbs])";
                weightEntryKG_lbl.Text = "";
            }
        }

        /*
         * Method for setting the fields of text to metric units, runs after the radio button is selected.
         */
        private void metric_rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (metric_rdo.Checked)
            {
                //Sets up unitType int to the metric setting for later use in a switch statement.
                unitType = 2;
                clear_heightWeightLbl();
                //Makes sure the entry field for inches is hidden to the user if they are working with metric units.
                heightInch_txt.Visible = false;

                //Sets up the titles for metric units and hides the imperial titles.
                heightEntry1_lbl.Text = "";
                heightEntry2_lbl.Text = "";
                heightEntryCM_lbl.Text = "(Centimeters)";
                weightEntry_lbl.Text = "";
                weightEntryKG_lbl.Text = "(Kilograms[Kg])";
            }
        }

        /*
         * Method containing the main program code. Validates user entry to ensure that a unit type has been selected and the appropriate data has been
         * entered by the user before continuing. Contains a case statement that will calculate the BMI with the imperial or metric formula depending 
         * on the users selection, this is determined with the unitType variable setup earlier in the program.
         */
        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double totalHeightInch = 0;
            double userBMI = 0;
            string weightCatagory = "";

            //If statement to validate the users entry data before continuing with the program. Checks that a unit system has been selected and that the 
            //appropriate height and weight data has been entered.
            if (unitType < 1 || unitType > 2) {
                MessageBox.Show("Please select the appropriate units for your entry data.");
                return;
            }
            else if (unitType == 1 && (heightMain_txt.Text == "" || heightInch_txt.Text == "" || weightMain_txt.Text == ""))
            {
                MessageBox.Show("Please enter your height and weight in the appropriate spaces.");
                return;
            }
            else if (unitType == 2 && (heightMain_txt.Text == "" || weightMain_txt.Text == ""))
            {
                MessageBox.Show("Please enter your height and weight in the appropriate spaces.");
                return;
            }
            
            double userHeight = double.Parse(heightMain_txt.Text);
            double userWeight = double.Parse(weightMain_txt.Text);
            int userHeightInches = 0;

            //Only takes in the users inches measurement if the imperial unit option was selected.
            if (unitType == 1) {
                userHeightInches = int.Parse(heightInch_txt.Text);
            }

            //Switch statement that contains the code to calculate the users bmi and output that value along with the appropriate bmi catagory.
            switch (unitType)
            {
                //Finds the users total height in inches, calculates the users bmi using the imperial formula. Formats the output string to show the bmi and
                //the appropriate bmi catagory. Displays the final bmi and the catagory to the user.
                case 1:
                    totalHeightInch = Convert.ToDouble(imperialTotalHeight(userHeight, userHeightInches));
                    userBMI = calcImperialBMI(userWeight, totalHeightInch);
                    string tempString1 = bmiCatagory(userBMI, weightCatagory);
                    bmiOutput_txt.Text = (Convert.ToString(userBMI)) + tempString1;
                    break;
                //Calculates the users bmi using the metric formula. Formats the output string to show the bmi and the appropriate bmi catagory.
                //Displays the final bmi and the catagory to the user.
                case 2:
                    userBMI = calcMetricBMI(userWeight, userHeight);
                    string tempString2 = bmiCatagory(userBMI, weightCatagory);
                    bmiOutput_txt.Text = (Convert.ToString(userBMI)) + tempString2;
                    break;
            }
        }

        /*
         * Method to find the users height in inches to be used in the bmi calculation. 
         * Converts feet to inches and adds any remaining inches to the total, then returns this value.
         */
        public int imperialTotalHeight(double userHeight, int userHeightInches)
        {
            int totalInches = 0;

            totalInches += Convert.ToInt32(userHeight * 12);
            totalInches += userHeightInches;

            return totalInches;
        }

        /*
         * Method to calculate the users bmi using the imperial formula. Rounds the output to 2 decimal places and returns the value.
         */
        public double calcImperialBMI(double userWeight, double totalHeightInch) {
            double tempWeightCalc;
            double heightSquared = 0;
            double tempBMI = 0;

            tempWeightCalc = (userWeight * 703);
            heightSquared = (totalHeightInch * totalHeightInch);
            tempBMI = (tempWeightCalc / heightSquared);

            tempBMI = Math.Round(tempBMI, 2);

            return tempBMI;
        }

        /*
         * Method to calculate the users bmi using the metric formula. Rounds the output to 2 decimal places and returns the value.
         */
        public double calcMetricBMI(double userWeight, double userHeight) {
            double tempBMI = 0;

            tempBMI = ((userWeight / userHeight / userHeight) * 10000);

            tempBMI = Math.Round(tempBMI, 2);

            return tempBMI;
        }

        /*
         * Method to find the appropriate bmi catagory for the calculated bmi. Sets up the catagory section of the output string. 
         * Returns a string value containing this section to be concatenated to create the final output string.
         */
        public string bmiCatagory(double userBMI, string weightCatagory) {
            double underWeight = 18.50;
            double normalWeight = 24.99;
            double overWeight = 29.99;

            if (userBMI < underWeight)
            {
                weightCatagory = ". You are under weight.";
                return weightCatagory;
            }
            else if (userBMI >= underWeight && userBMI <= normalWeight)
            {
                weightCatagory = ". You are a normal weight.";
                return weightCatagory;
            }
            else if (userBMI > normalWeight && userBMI <= overWeight)
            {
                weightCatagory = ". You are over weight.";
                return weightCatagory;
            }
            else {
                weightCatagory = ". You are obese.";
                return weightCatagory;
            }
        }

        /*
         *Method to clear the form of the users input data and unit selection for re-use. Also clears the system generated titles from the form.
         */
        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_heightWeightLbl();

            heightMain_txt.Text = "";
            heightInch_txt.Text = "";
            weightMain_txt.Text = "";

            imperial_rdo.Checked = false;
            metric_rdo.Checked = false;
        }
    }
}