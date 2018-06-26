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
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            modules.SelectModule selectModule = new modules.SelectModule();
            selectModule.TopLevel = false;
            selectModule.AutoScroll = true;
            this.Controls.Add(selectModule);
            selectModule.Dock = DockStyle.Fill;
            selectModule.Show();
        }
    }
}
