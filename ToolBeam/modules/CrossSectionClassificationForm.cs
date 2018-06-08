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
            this.Controls.Clear();
            modules.iSectionForm hSectionForm = new modules.iSectionForm();
            hSectionForm.TopLevel = false;
            hSectionForm.AutoScroll = true;
            this.Controls.Add(hSectionForm);
            hSectionForm.Dock = DockStyle.Fill;
            hSectionForm.Show();
            
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
