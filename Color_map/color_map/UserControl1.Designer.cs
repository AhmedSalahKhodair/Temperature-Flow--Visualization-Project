namespace color_map
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.s_max_text = new System.Windows.Forms.TextBox();
            this.s_min_text = new System.Windows.Forms.TextBox();
            this.Cont_radio = new System.Windows.Forms.RadioButton();
            this.Dis_radio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(88, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 26);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // s_max_text
            // 
            this.s_max_text.Location = new System.Drawing.Point(190, 17);
            this.s_max_text.Name = "s_max_text";
            this.s_max_text.Size = new System.Drawing.Size(90, 20);
            this.s_max_text.TabIndex = 22;
            // 
            // s_min_text
            // 
            this.s_min_text.Location = new System.Drawing.Point(88, 19);
            this.s_min_text.Name = "s_min_text";
            this.s_min_text.Size = new System.Drawing.Size(90, 20);
            this.s_min_text.TabIndex = 21;
            // 
            // Cont_radio
            // 
            this.Cont_radio.AutoSize = true;
            this.Cont_radio.Location = new System.Drawing.Point(11, 103);
            this.Cont_radio.Name = "Cont_radio";
            this.Cont_radio.Size = new System.Drawing.Size(72, 17);
            this.Cont_radio.TabIndex = 19;
            this.Cont_radio.Text = "Continous";
            this.Cont_radio.UseVisualStyleBackColor = true;
            // 
            // Dis_radio
            // 
            this.Dis_radio.AutoSize = true;
            this.Dis_radio.Location = new System.Drawing.Point(11, 61);
            this.Dis_radio.Name = "Dis_radio";
            this.Dis_radio.Size = new System.Drawing.Size(64, 17);
            this.Dis_radio.TabIndex = 18;
            this.Dis_radio.Text = "Discrete";
            this.Dis_radio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(88, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 31);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.s_max_text);
            this.groupBox1.Controls.Add(this.Dis_radio);
            this.groupBox1.Controls.Add(this.s_min_text);
            this.groupBox1.Controls.Add(this.Cont_radio);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 145);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value To Color";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(311, 157);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox s_max_text;
        private System.Windows.Forms.TextBox s_min_text;
        private System.Windows.Forms.RadioButton Cont_radio;
        private System.Windows.Forms.RadioButton Dis_radio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
