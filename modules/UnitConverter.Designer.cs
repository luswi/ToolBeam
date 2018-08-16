namespace ToolBeam.modules
{
    partial class UnitConverter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbValueOutput = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbValueInput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbUnitOutput = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbUnitInput = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbUnitTypes = new System.Windows.Forms.ListBox();
            this.b_Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.b_Back);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Converter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToolBeam.Properties.Resources.convert;
            this.pictureBox1.Location = new System.Drawing.Point(661, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbValueOutput);
            this.groupBox6.Location = new System.Drawing.Point(421, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 51);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Output Value";
            // 
            // tbValueOutput
            // 
            this.tbValueOutput.Location = new System.Drawing.Point(6, 19);
            this.tbValueOutput.Name = "tbValueOutput";
            this.tbValueOutput.ReadOnly = true;
            this.tbValueOutput.Size = new System.Drawing.Size(188, 20);
            this.tbValueOutput.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbValueInput);
            this.groupBox5.Location = new System.Drawing.Point(215, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 51);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input Value";
            // 
            // tbValueInput
            // 
            this.tbValueInput.Location = new System.Drawing.Point(6, 19);
            this.tbValueInput.Name = "tbValueInput";
            this.tbValueInput.Size = new System.Drawing.Size(188, 20);
            this.tbValueInput.TabIndex = 11;
            this.tbValueInput.TextChanged += new System.EventHandler(this.tbValueInput_TextChanged);
            this.tbValueInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueInput_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbUnitOutput);
            this.groupBox4.Location = new System.Drawing.Point(421, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 200);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // lbUnitOutput
            // 
            this.lbUnitOutput.FormattingEnabled = true;
            this.lbUnitOutput.Location = new System.Drawing.Point(6, 19);
            this.lbUnitOutput.Name = "lbUnitOutput";
            this.lbUnitOutput.Size = new System.Drawing.Size(188, 173);
            this.lbUnitOutput.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbUnitInput);
            this.groupBox3.Location = new System.Drawing.Point(215, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // lbUnitInput
            // 
            this.lbUnitInput.FormattingEnabled = true;
            this.lbUnitInput.Location = new System.Drawing.Point(6, 19);
            this.lbUnitInput.Name = "lbUnitInput";
            this.lbUnitInput.Size = new System.Drawing.Size(188, 173);
            this.lbUnitInput.TabIndex = 9;
            this.lbUnitInput.SelectedIndexChanged += new System.EventHandler(this.lbUnitInput_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbUnitTypes);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 200);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit Types";
            // 
            // lbUnitTypes
            // 
            this.lbUnitTypes.FormattingEnabled = true;
            this.lbUnitTypes.Items.AddRange(new object[] {
            "Pressure",
            "Force",
            "Torque",
            "Mass"});
            this.lbUnitTypes.Location = new System.Drawing.Point(6, 19);
            this.lbUnitTypes.Name = "lbUnitTypes";
            this.lbUnitTypes.Size = new System.Drawing.Size(188, 173);
            this.lbUnitTypes.TabIndex = 8;
            this.lbUnitTypes.SelectedIndexChanged += new System.EventHandler(this.lbUnitTypes_SelectedIndexChanged);
            // 
            // b_Back
            // 
            this.b_Back.Location = new System.Drawing.Point(9, 311);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(75, 23);
            this.b_Back.TabIndex = 7;
            this.b_Back.Text = "Back";
            this.b_Back.UseVisualStyleBackColor = true;
            this.b_Back.Click += new System.EventHandler(this.b_Back_Click);
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitConverter";
            this.Text = "UnitConverter";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_Back;
        private System.Windows.Forms.ListBox lbUnitTypes;
        private System.Windows.Forms.ListBox lbUnitOutput;
        private System.Windows.Forms.ListBox lbUnitInput;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbValueOutput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbValueInput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}