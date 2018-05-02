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
    public partial class CrossSectionClassificationForm : Form
    {
        public CrossSectionClassificationForm()
        {
            InitializeComponent();
        }

        private void CrossSectionClassificationForm_Load(object sender, EventArgs e)
        {

        }

        private void hSection_Click(object sender, EventArgs e)
        {
            modules.hSectionForm hSection = new modules.hSectionForm();
            hSection.Show();
        }
    }
}
