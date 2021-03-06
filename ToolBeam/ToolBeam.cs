﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
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
            panelMain.Controls.Clear();
            modules.CrossSectionClassificationForm crossSectionClassification = new modules.CrossSectionClassificationForm();
            crossSectionClassification.TopLevel = false;
            crossSectionClassification.AutoScroll = true;
            panelMain.Controls.Add(crossSectionClassification);
            crossSectionClassification.Dock = DockStyle.Fill;
            crossSectionClassification.Show();

            //modules.CrossSectionClassificationForm crossSectionClassification = new modules.CrossSectionClassificationForm();
            //crossSectionClassification.Show();
            //showdialog - fix window..
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

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            //panelMain.Controls.Clear();
            modules.SelectModule selectModule = new modules.SelectModule();
            selectModule.TopLevel = false;
            selectModule.AutoScroll = true;
            panelMain.Controls.Add(selectModule);
            selectModule.Dock = DockStyle.Fill;
            selectModule.Show();

        }

    }
}
