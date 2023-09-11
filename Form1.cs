using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string textToConvert()
        {
            return fromInput.Text;
        }

        private string textToOutput(string fromInput)
        {
            return toOutput.Text = fromInput;
        }

        private string getUnitIn()
        {
            return comboBoxUnitIn.Text;
        }

        private string getUnitOut()
        {
            return comboBoxUnitOut.Text;
        }

        private string getMeasureType()
        {
            return MeasureBox.Text;
        }

        private void popComboBoxUIn(List<string> popList)
        {
            foreach (string item in popList)
            {
                comboBoxUnitIn.Items.Add(item);
            }
        }

        private void popComboBoxUOut(List<string> popList)
        {
            foreach (string item in popList)
            {
                comboBoxUnitOut.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fromInput = Convert.ToDouble(textToConvert());
            string unitsIn = getUnitIn();
            string unitsOut = getUnitOut();
            double toOutput;
            if (unitsIn == "Mile" && unitsOut == "Kilometer") {
                toOutput = fromInput * ConversionFactors.MILES_TO_KILOMETERS;
            }
            else if (unitsIn == "Kilometer" && unitsOut == "Mile")
            {
                toOutput = fromInput / ConversionFactors.MILES_TO_KILOMETERS;
            }
            else
            {
                toOutput = 1.0;
            }
            // check selections of combo boxes
            // If no selections, or empty fields, return error
            // Return error if non-numeric
            // try except/catch??
            
            string toOutputS = Convert.ToString(toOutput);
            textToOutput(toOutputS);
        }

        private void comboBoxMeasureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dictUnitTypes = UnitTypes.AddDictItems();
            string measureType = getMeasureType();
            var measuresList = dictUnitTypes[measureType];
            popComboBoxUIn(measuresList);
            popComboBoxUOut(measuresList);
        }
    }
}
