using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBeam.classes
{
    class unitClass
    {
        // Variables used for calculations
        public double unitInput { get; set; }
        public double unitOutput { get; set; }
        public double ValueInput { get; set; }
        public double ValueOutput { get; set; }
        public double conversion { get; set; }

        public bool unitConverter(unitClass v)
        {
            bool isSuccess = false;
            if ( unitInput > 0 )
            {
                isSuccess = true;

                double conversion = ValueInput * 5;

            }
            else
            {
                isSuccess = false;
            }
            return isSuccess;
        }

    }
}
