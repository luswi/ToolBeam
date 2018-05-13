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
            v.tfVar = double.Parse(tfVar.Text);
            v.material = tbMaterial.Text;

            //var myInst = new profileClass();
            //var myInst = new obl



            //wysylanie do obliczen

            bool success = v.obliczenia(v);
            if (success == true)
            {
                // Label epsilon

                //lbEpsilon.Text = "cos zmieniono";
                //lbEpsilon.Text = Convert.ToString(myInst.fyVar);
                //Refresh();
                
            }
            else
            {
                MessageBox.Show("cos poszlo zle");
            }
            lbEpsilon.Text = Convert.ToString(v.fyVar);

            //int liczbaA = 5;
            //int liczbaB = 10;
            //int answer;

            //answer = liczbaA + liczbaB;

            //string pozmianie = Convert.ToString(answer);
            //MessageBox.Show(pozmianie);
        }


    }
}
