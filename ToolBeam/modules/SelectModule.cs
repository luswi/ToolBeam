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
    public partial class SelectModule : Form
    {
        public SelectModule()
        {
            InitializeComponent();
        }

        private void bCrossSectionClassification_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            modules.CrossSectionClassificationForm crossSectionClassificationForm = new modules.CrossSectionClassificationForm();
            crossSectionClassificationForm.TopLevel = false;
            crossSectionClassificationForm.AutoScroll = true;
            this.Controls.Add(crossSectionClassificationForm);
            crossSectionClassificationForm.Dock = DockStyle.Fill;
            crossSectionClassificationForm.Show();




        }

        private void bLiftingLug_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            modules.LiftingLugTypes liftingLugTypes = new modules.LiftingLugTypes();
            liftingLugTypes.TopLevel = false;
            liftingLugTypes.AutoScroll = true;
            this.Controls.Add(liftingLugTypes);
            liftingLugTypes.Dock = DockStyle.Fill;
            liftingLugTypes.Show();
        }
    }
}
