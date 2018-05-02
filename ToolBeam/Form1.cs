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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        profileClass v = new profileClass();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {

            // pobieranie wartosci z pol tekstowych.
            v.liczbaA = double.Parse(tb_A.Text);
            v.liczbaB = double.Parse(tb_B.Text);

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

        private void bCrossSectionClassification_Click(object sender, EventArgs e)
        {
            modules.CrossSectionClassificationForm crossSectionClassification = new modules.CrossSectionClassificationForm();
            crossSectionClassification.Show();
        }
    }
}
