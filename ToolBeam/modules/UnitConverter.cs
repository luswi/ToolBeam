using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBeam.classes;

namespace ToolBeam.modules
{
    public partial class UnitConverter : Form
    {
        public UnitConverter()
        {
            InitializeComponent();
        }
        unitClass v = new unitClass();

        public void unitsInput()
        {
            if((string)lbUnitTypes.SelectedItem == "Pressure")
            {
                lbUnitInput.Items.Clear();
                lbUnitInput.Items.Add("A");
                lbUnitInput.Items.Add("B");
                lbUnitInput.Items.Add("C");
            }
            else if((string)lbUnitTypes.SelectedItem == "Force")
            {
                lbUnitInput.Items.Clear();
                lbUnitInput.Items.Add("Force selected...");
            }
            else if((string)lbUnitTypes.SelectedItem == "Torque")
            {
                lbUnitInput.Items.Clear();
                lbUnitInput.Items.Add("Torque selected...");
            }
            else if((string)lbUnitTypes.SelectedItem == "Mass")
            {
                lbUnitInput.Items.Clear();
                lbUnitInput.Items.Add("kg");

            }
           
        }
        public void unitsOutput()
        {
            if ((string)lbUnitInput.SelectedItem == "A")
            {
                lbUnitOutput.Items.Clear();
                lbUnitOutput.Items.Add("AAA");
            }
            else if ((string)lbUnitInput.SelectedItem == "B")
            {
                lbUnitOutput.Items.Clear();
                lbUnitOutput.Items.Add("BBB");
            }
            else if ((string)lbUnitInput.SelectedItem == "C")
            {
                lbUnitOutput.Items.Clear();
                lbUnitOutput.Items.Add("CCC");
            }
            else if((string)lbUnitInput.SelectedItem == "kg")
            {
                lbUnitOutput.Items.Clear();
                lbUnitOutput.Items.Add("N");
            }
        }
        private void b_Back_Click(object sender, EventArgs e)
        {
            //https://codereview.stackexchange.com/questions/161131/unit-conversion-application
            
            this.Controls.Clear();
            modules.SelectModule selectModule = new modules.SelectModule();
            selectModule.TopLevel = false;
            selectModule.AutoScroll = true;
            this.Controls.Add(selectModule);
            selectModule.Dock = DockStyle.Fill;
            selectModule.Show();
        }

        private void lbUnitTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
           unitsInput();
        }

        private void lbUnitInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitsOutput();
        }

        private void tbValueInput_TextChanged(object sender, EventArgs e)
        {
            v.ValueInput = double.Parse(tbValueInput.Text);
            v.ValueOutput = double.Parse(tbValueOutput.Text);
            v.unitInput = double.Parse(lbUnitInput.Text);
            v.unitOutput = double.Parse(lbUnitOutput.Text);

            //results
            bool success = v.unitConverter(v);
            if(success == true)
            {
                lbUnitOutput.Text = Convert.ToString(v.conversion);
            }

        }
    }
}
