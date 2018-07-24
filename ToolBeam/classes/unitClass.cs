using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBeam.classes
{
    class unitClass
    {
        // Variables used for calculations
        public string unitInput { get; set; }
        public string unitOutput { get; set; }
        public double ValueInput { get; set; }
        //public double ValueOutput { get; set; }
        public double conversion { get; set; }

        public bool unitConverter(unitClass v)
        {
            bool isSuccess = false;
            if ( ValueInput != 0)
            {
                isSuccess = true;

                if (unitInput == "kg" & unitOutput == "N")
                { conversion = ValueInput * 9.8066500286389; }
                else if (unitInput == "N" & unitOutput == "kg")
                { conversion = ValueInput / 9.8066500286389; }
                else if (unitInput == "tonne" & unitOutput == "kN")
                { }
                else if (unitInput == "kN" & unitOutput == "tonne")
                { }
                else
                {
                    MessageBox.Show("UPS!");
                }

            }
            else
            {
                isSuccess = false;
            }
            return isSuccess;
        }

    }
}
