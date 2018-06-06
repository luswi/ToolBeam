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
    public partial class hSectionForm : Form
    {
        public hSectionForm()
        {
            InitializeComponent();
        }

        profileClass v = new profileClass();

        private void bCalculateClass_Click(object sender, EventArgs e)
        {

            // Pick up values from text boxes
            v.hVar = double.Parse(hVar.Text);
            v.bVar = double.Parse(bVar.Text);
            v.tfVar = double.Parse(tfVar.Text);
            v.material = cbMaterialSelection.SelectedItem.ToString();
            v.rVar = double.Parse(rVar.Text);
            v.twVar = double.Parse(twVar.Text);

            // Send for calculations
            bool success = v.calculations(v);
            if (success == true)
            {
                
                lbEpsilonVar.Text = Convert.ToString(v.epsilon);
                lbWebVar.Text = Convert.ToString(v.web);
                lbWebClassVar.Text = v.webClass;
                lbFlangeVar.Text = Convert.ToString(v.flange);
                lbFlangeClassVar.Text = v.flangeClass;
                
            }
            else
            {
                MessageBox.Show("cos poszlo zle");
            }

                        
        }

        private void cbIprofiles_DropDown(object sender, EventArgs e)
        {
            cbIprofiles.DisplayMember = "Text";
            cbIprofiles.ValueMember = "Value";
            
            
            var items = new[]
            {
                new {Text = "IPE80", Value = "80"},
                new {Text = "IPE100", Value = "100"},
                new {Text = "IPE120", Value = "120"},
                new {Text = "IPE140", Value = "140"},
                new {Text = "IPE160", Value = "160"},
                new {Text = "IPE180", Value = "180"},
                new {Text = "IPE200", Value = "200"},
                new {Text = "IPE220", Value = "220"},
                new {Text = "IPE240", Value = "240"},
                new {Text = "IPE270", Value = "270"},
                new {Text = "IPE300", Value = "300"},
                new {Text = "IPE330", Value = "330"},
                new {Text = "IPE360", Value = "360"},
                new {Text = "IPE400", Value = "400"},
                new {Text = "IPE450", Value = "450"},
                new {Text = "IPE500", Value = "500"},
                new {Text = "IPE550", Value = "550"},
                new {Text = "IPE600", Value = "600"}
            };
            cbIprofiles.DataSource = items;
            
            
        }

        private void cbIprofiles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // IPE profile database from https://sketchup.engineeringtoolbox.com/IPE-steel-profiles-c_28.html
            switch (cbIprofiles.SelectedValue.ToString())
            {
                case "80":
                    hVar.Text = "80";
                    bVar.Text = "46";
                    twVar.Text = "3.8";
                    tfVar.Text = "5.2";
                    rVar.Text = "5";
                    break;
                case "100":
                    hVar.Text = "100";
                    bVar.Text = "55";
                    twVar.Text = "4.1";
                    tfVar.Text = "5.7";
                    rVar.Text = "7";
                    break;
                case "120":
                    hVar.Text = "120";
                    bVar.Text = "64";
                    twVar.Text = "4.4";
                    tfVar.Text = "6.3";
                    rVar.Text = "7";
                    break;
                case "140":
                    hVar.Text = "140";
                    bVar.Text = "73";
                    twVar.Text = "4.7";
                    tfVar.Text = "6.9";
                    rVar.Text = "7";
                    break;
                case "160":
                    hVar.Text = "160";
                    bVar.Text = "82";
                    twVar.Text = "5";
                    tfVar.Text = "7.7";
                    rVar.Text = "9";
                    break;
                case "180":
                    hVar.Text = "180";
                    bVar.Text = "91";
                    twVar.Text = "5.3";
                    tfVar.Text = "8";
                    rVar.Text = "9";
                    break;
                case "200":
                    hVar.Text = "200";
                    bVar.Text = "100";
                    twVar.Text = "5.6";
                    tfVar.Text = "8.5";
                    rVar.Text = "12";
                    break;
                case "220":
                    hVar.Text = "220";
                    bVar.Text = "110";
                    twVar.Text = "5.9";
                    tfVar.Text = "9.2";
                    rVar.Text = "12";
                    break;
                case "240":
                    hVar.Text = "240";
                    bVar.Text = "120";
                    twVar.Text = "6.2";
                    tfVar.Text = "9.8";
                    rVar.Text = "15";
                    break;
                case "270":
                    hVar.Text = "270";
                    bVar.Text = "135";
                    twVar.Text = "6.6";
                    tfVar.Text = "10.2";
                    rVar.Text = "15";
                    break;
                case "300":
                    hVar.Text = "300";
                    bVar.Text = "150";
                    twVar.Text = "7.1";
                    tfVar.Text = "10.7";
                    rVar.Text = "15";
                    break;
                case "330":
                    hVar.Text = "330";
                    bVar.Text = "160";
                    twVar.Text = "7.5";
                    tfVar.Text = "11.5";
                    rVar.Text = "18";
                    break;
                case "360":
                    hVar.Text = "360";
                    bVar.Text = "170";
                    twVar.Text = "8";
                    tfVar.Text = "12.7";
                    rVar.Text = "18";
                    break;
                case "400":
                    hVar.Text = "400";
                    bVar.Text = "180";
                    twVar.Text = "8.6";
                    tfVar.Text = "13.5";
                    rVar.Text = "21";
                    break;
                case "450":
                    hVar.Text = "450";
                    bVar.Text = "190";
                    twVar.Text = "9.4";
                    tfVar.Text = "14.6";
                    rVar.Text = "21";
                    break;
                case "500":
                    hVar.Text = "500";
                    bVar.Text = "200";
                    twVar.Text = "10.2";
                    tfVar.Text = "16";
                    rVar.Text = "21";
                    break;
                case "550":
                    hVar.Text = "550";
                    bVar.Text = "210";
                    twVar.Text = "11.1";
                    tfVar.Text = "17.2";
                    rVar.Text = "24";
                    break;
                case "600":
                    hVar.Text = "600";
                    bVar.Text = "220";
                    twVar.Text = "12";
                    tfVar.Text = "19";
                    rVar.Text = "24";
                    break;
            }
            bCalculateClass.PerformClick();

        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            modules.CrossSectionClassificationForm crossSectionClassificationForm = new modules.CrossSectionClassificationForm();
            crossSectionClassificationForm.TopLevel = false;
            crossSectionClassificationForm.AutoScroll = true;
            this.Controls.Add(crossSectionClassificationForm);
            crossSectionClassificationForm.Dock = DockStyle.Fill;
            crossSectionClassificationForm.Show();
        }

        private void hSectionForm_Load(object sender, EventArgs e)
        {
            cbMaterialSelection.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modules.Help.csHelp csHelp = new modules.Help.csHelp();
            csHelp.Show();
        }

        private void cbMaterialSelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bCalculateClass.PerformClick();
        }
    }
}
