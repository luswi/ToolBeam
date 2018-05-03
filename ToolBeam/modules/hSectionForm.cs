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
        private void button1_Click(object sender, EventArgs e)
        {
            // pobieranie wartosci z pol tekstowych.
            v.hVar = double.Parse(hVar.Text);
            v.bVar = double.Parse(bVar.Text);
            v.tfVar = int.Parse(tfVar.Text);
            v.material = tbMaterial.Text;

            //wysylanie do obliczen

            bool success = v.obliczenia(v);
            if (success == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("cos poszlo zle");
            }

            //int liczbaA = 5;
            //int liczbaB = 10;
            //int answer;

            //answer = liczbaA + liczbaB;

            //string pozmianie = Convert.ToString(answer);
            //MessageBox.Show(pozmianie);
        }
    }
}
