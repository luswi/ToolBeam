namespace ToolBeam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.bCrossSectionClassification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(48, 66);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(100, 20);
            this.tb_A.TabIndex = 0;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(48, 107);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(100, 20);
            this.tb_B.TabIndex = 1;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(48, 154);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // bCrossSectionClassification
            // 
            this.bCrossSectionClassification.Location = new System.Drawing.Point(388, 84);
            this.bCrossSectionClassification.Name = "bCrossSectionClassification";
            this.bCrossSectionClassification.Size = new System.Drawing.Size(164, 80);
            this.bCrossSectionClassification.TabIndex = 3;
            this.bCrossSectionClassification.Text = "Cross-Section Classification";
            this.bCrossSectionClassification.UseVisualStyleBackColor = true;
            this.bCrossSectionClassification.Click += new System.EventHandler(this.bCrossSectionClassification_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCrossSectionClassification);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_A);
            this.Name = "Form1";
            this.Text = "ToolBeam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button bCrossSectionClassification;
    }
}

