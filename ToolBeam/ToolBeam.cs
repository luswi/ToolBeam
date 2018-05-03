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

namespace ToolBeam
{
    public partial class ToolBeam : Form
    {
        public ToolBeam()
        {
            InitializeComponent();
        }
        profileClass v = new profileClass();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void bCrossSectionClassification_Click(object sender, EventArgs e)
        {
            modules.CrossSectionClassificationForm crossSectionClassification = new modules.CrossSectionClassificationForm();
            crossSectionClassification.Show();
            //showdialog - fix window
        }
    }
}
