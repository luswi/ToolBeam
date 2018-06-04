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
        //== for top move
        private bool m_firstClick = false;
        private Point m_firstClickLoc;
        //== end
        profileClass v = new profileClass();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void bCrossSectionClassification_Click(object sender, EventArgs e)
        {
            modules.CrossSectionClassificationForm crossSectionClassification = new modules.CrossSectionClassificationForm();
            crossSectionClassification.Show();
            //showdialog - fix window.
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(m_firstClick == false)
                {
                    m_firstClick = true;
                    m_firstClickLoc = new Point(e.X, e.Y);
                }
                this.Location = new Point(
                    this.Location.X + e.X - m_firstClickLoc.X,
                    this.Location.Y + e.Y - m_firstClickLoc.Y
                );
            }
            else
            {
                m_firstClick = false;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
