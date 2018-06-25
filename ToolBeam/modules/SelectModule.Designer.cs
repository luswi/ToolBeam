namespace ToolBeam.modules
{
    partial class SelectModule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.bCrossSectionClassification = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bLiftingLug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.bCrossSectionClassification);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.bLiftingLug);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1056, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select module";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 235);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(267, 98);
            this.button6.TabIndex = 10;
            this.button6.Text = "New Rules module";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bCrossSectionClassification
            // 
            this.bCrossSectionClassification.BackColor = System.Drawing.Color.DarkOrange;
            this.bCrossSectionClassification.Location = new System.Drawing.Point(8, 23);
            this.bCrossSectionClassification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCrossSectionClassification.Name = "bCrossSectionClassification";
            this.bCrossSectionClassification.Size = new System.Drawing.Size(267, 98);
            this.bCrossSectionClassification.TabIndex = 3;
            this.bCrossSectionClassification.Text = "Cross-Section Classification";
            this.bCrossSectionClassification.UseVisualStyleBackColor = false;
            this.bCrossSectionClassification.Click += new System.EventHandler(this.bCrossSectionClassification_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 98);
            this.button4.TabIndex = 9;
            this.button4.Text = "Welded connections";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(283, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 98);
            this.button5.TabIndex = 8;
            this.button5.Text = "Cross-section load capacity";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 98);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lateral - Torsional Buckling";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bLiftingLug
            // 
            this.bLiftingLug.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bLiftingLug.Location = new System.Drawing.Point(8, 129);
            this.bLiftingLug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLiftingLug.Name = "bLiftingLug";
            this.bLiftingLug.Size = new System.Drawing.Size(267, 98);
            this.bLiftingLug.TabIndex = 5;
            this.bLiftingLug.Text = "Lifting Lug Check";
            this.bLiftingLug.UseVisualStyleBackColor = false;
            this.bLiftingLug.Click += new System.EventHandler(this.bLiftingLug_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Profile database";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SelectModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 431);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectModule";
            this.Text = "SelectModule";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bCrossSectionClassification;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bLiftingLug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}