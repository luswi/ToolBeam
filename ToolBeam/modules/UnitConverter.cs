using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBeam.modules
{
    public partial class UnitConverter : Form
    {
        public UnitConverter()
        {
            InitializeComponent();
            units();
        }
        public void units()
        {
            lbUnitTypes.Items.Add("Pressure");
            lbUnitTypes.Items.Add("Force");
            lbUnitTypes.Items.Add("Torque");
            if((string)lbUnitTypes.SelectedItem == "Pressure")
            {
                lbUnitInput.Items.Add("suuper");
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
            units();
        }
    }
}
