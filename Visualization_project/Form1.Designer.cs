namespace Visualization_project
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
            this.Start_Button = new System.Windows.Forms.Button();
            this.Heat_Soruce_RadioButton = new System.Windows.Forms.RadioButton();
            this.Cold_Soruce_RadioButton = new System.Windows.Forms.RadioButton();
            this.Normal_Cell_RadioButton = new System.Windows.Forms.RadioButton();
            this.Block_RadioButton = new System.Windows.Forms.RadioButton();
            this.Window_RadioButton = new System.Windows.Forms.RadioButton();
            this.Set_Button = new System.Windows.Forms.Button();
            this.Cell_side_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Value_to_color_set_btn = new System.Windows.Forms.Button();
            this.Parallel_C_plusPlus_RadioButton = new System.Windows.Forms.RadioButton();
            this.ValueToColor = new color_map.UserControl1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_of_threads_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_Of_Threads_textBox1 = new System.Windows.Forms.TextBox();
            this.Parallel_C_Sharp_RadioButton = new System.Windows.Forms.RadioButton();
            this.Sequ_RadioButton = new System.Windows.Forms.RadioButton();
            this.Uncheck_button = new System.Windows.Forms.Button();
            this.Room_Panel = new Visualization_project.DoubleBufferedPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Start_Button.Location = new System.Drawing.Point(975, 205);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(83, 32);
            this.Start_Button.TabIndex = 4;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Heat_Soruce_RadioButton
            // 
            this.Heat_Soruce_RadioButton.AutoSize = true;
            this.Heat_Soruce_RadioButton.Location = new System.Drawing.Point(1166, 82);
            this.Heat_Soruce_RadioButton.Name = "Heat_Soruce_RadioButton";
            this.Heat_Soruce_RadioButton.Size = new System.Drawing.Size(85, 17);
            this.Heat_Soruce_RadioButton.TabIndex = 6;
            this.Heat_Soruce_RadioButton.TabStop = true;
            this.Heat_Soruce_RadioButton.Text = "Heat Soruce";
            this.Heat_Soruce_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Cold_Soruce_RadioButton
            // 
            this.Cold_Soruce_RadioButton.AutoSize = true;
            this.Cold_Soruce_RadioButton.Location = new System.Drawing.Point(1166, 108);
            this.Cold_Soruce_RadioButton.Name = "Cold_Soruce_RadioButton";
            this.Cold_Soruce_RadioButton.Size = new System.Drawing.Size(83, 17);
            this.Cold_Soruce_RadioButton.TabIndex = 7;
            this.Cold_Soruce_RadioButton.TabStop = true;
            this.Cold_Soruce_RadioButton.Text = "Cold Soruce";
            this.Cold_Soruce_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Normal_Cell_RadioButton
            // 
            this.Normal_Cell_RadioButton.AutoSize = true;
            this.Normal_Cell_RadioButton.Location = new System.Drawing.Point(1166, 33);
            this.Normal_Cell_RadioButton.Name = "Normal_Cell_RadioButton";
            this.Normal_Cell_RadioButton.Size = new System.Drawing.Size(78, 17);
            this.Normal_Cell_RadioButton.TabIndex = 8;
            this.Normal_Cell_RadioButton.TabStop = true;
            this.Normal_Cell_RadioButton.Text = "Normal Cell";
            this.Normal_Cell_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Block_RadioButton
            // 
            this.Block_RadioButton.AutoSize = true;
            this.Block_RadioButton.Location = new System.Drawing.Point(1166, 134);
            this.Block_RadioButton.Name = "Block_RadioButton";
            this.Block_RadioButton.Size = new System.Drawing.Size(52, 17);
            this.Block_RadioButton.TabIndex = 9;
            this.Block_RadioButton.TabStop = true;
            this.Block_RadioButton.Text = "Block";
            this.Block_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Window_RadioButton
            // 
            this.Window_RadioButton.AutoSize = true;
            this.Window_RadioButton.Location = new System.Drawing.Point(1166, 57);
            this.Window_RadioButton.Name = "Window_RadioButton";
            this.Window_RadioButton.Size = new System.Drawing.Size(64, 17);
            this.Window_RadioButton.TabIndex = 10;
            this.Window_RadioButton.TabStop = true;
            this.Window_RadioButton.Text = "Window";
            this.Window_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Set_Button
            // 
            this.Set_Button.Location = new System.Drawing.Point(1163, 241);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(75, 23);
            this.Set_Button.TabIndex = 21;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // Cell_side_txt
            // 
            this.Cell_side_txt.Location = new System.Drawing.Point(1166, 210);
            this.Cell_side_txt.Name = "Cell_side_txt";
            this.Cell_side_txt.Size = new System.Drawing.Size(63, 20);
            this.Cell_side_txt.TabIndex = 19;
            this.Cell_side_txt.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1108, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cell Side";
            // 
            // Value_to_color_set_btn
            // 
            this.Value_to_color_set_btn.Location = new System.Drawing.Point(1166, 438);
            this.Value_to_color_set_btn.Name = "Value_to_color_set_btn";
            this.Value_to_color_set_btn.Size = new System.Drawing.Size(75, 23);
            this.Value_to_color_set_btn.TabIndex = 22;
            this.Value_to_color_set_btn.Text = "Set";
            this.Value_to_color_set_btn.UseVisualStyleBackColor = true;
            this.Value_to_color_set_btn.Click += new System.EventHandler(this.Value_to_color_set_btn_Click);
            // 
            // Parallel_C_plusPlus_RadioButton
            // 
            this.Parallel_C_plusPlus_RadioButton.AutoSize = true;
            this.Parallel_C_plusPlus_RadioButton.Location = new System.Drawing.Point(22, 89);
            this.Parallel_C_plusPlus_RadioButton.Name = "Parallel_C_plusPlus_RadioButton";
            this.Parallel_C_plusPlus_RadioButton.Size = new System.Drawing.Size(84, 17);
            this.Parallel_C_plusPlus_RadioButton.TabIndex = 23;
            this.Parallel_C_plusPlus_RadioButton.TabStop = true;
            this.Parallel_C_plusPlus_RadioButton.Text = "Parallel  C++";
            this.Parallel_C_plusPlus_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ValueToColor
            // 
            this.ValueToColor.Location = new System.Drawing.Point(955, 275);
            this.ValueToColor.Name = "ValueToColor";
            this.ValueToColor.Size = new System.Drawing.Size(311, 157);
            this.ValueToColor.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_of_threads_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Number_Of_Threads_textBox1);
            this.groupBox1.Controls.Add(this.Parallel_C_Sharp_RadioButton);
            this.groupBox1.Controls.Add(this.Sequ_RadioButton);
            this.groupBox1.Controls.Add(this.Parallel_C_plusPlus_RadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(975, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 146);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Performance";
            // 
            // num_of_threads_button
            // 
            this.num_of_threads_button.Location = new System.Drawing.Point(109, 116);
            this.num_of_threads_button.Name = "num_of_threads_button";
            this.num_of_threads_button.Size = new System.Drawing.Size(45, 23);
            this.num_of_threads_button.TabIndex = 26;
            this.num_of_threads_button.Text = "Set";
            this.num_of_threads_button.UseVisualStyleBackColor = true;
            this.num_of_threads_button.Click += new System.EventHandler(this.num_of_threads_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "#Threads";
            // 
            // Number_Of_Threads_textBox1
            // 
            this.Number_Of_Threads_textBox1.Location = new System.Drawing.Point(15, 116);
            this.Number_Of_Threads_textBox1.Name = "Number_Of_Threads_textBox1";
            this.Number_Of_Threads_textBox1.Size = new System.Drawing.Size(32, 20);
            this.Number_Of_Threads_textBox1.TabIndex = 24;
            this.Number_Of_Threads_textBox1.Text = "4";
            // 
            // Parallel_C_Sharp_RadioButton
            // 
            this.Parallel_C_Sharp_RadioButton.AutoSize = true;
            this.Parallel_C_Sharp_RadioButton.Location = new System.Drawing.Point(22, 58);
            this.Parallel_C_Sharp_RadioButton.Name = "Parallel_C_Sharp_RadioButton";
            this.Parallel_C_Sharp_RadioButton.Size = new System.Drawing.Size(76, 17);
            this.Parallel_C_Sharp_RadioButton.TabIndex = 1;
            this.Parallel_C_Sharp_RadioButton.Text = "Parallel C#";
            this.Parallel_C_Sharp_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Sequ_RadioButton
            // 
            this.Sequ_RadioButton.AutoSize = true;
            this.Sequ_RadioButton.Checked = true;
            this.Sequ_RadioButton.Location = new System.Drawing.Point(22, 28);
            this.Sequ_RadioButton.Name = "Sequ_RadioButton";
            this.Sequ_RadioButton.Size = new System.Drawing.Size(75, 17);
            this.Sequ_RadioButton.TabIndex = 0;
            this.Sequ_RadioButton.TabStop = true;
            this.Sequ_RadioButton.Text = "Sequential";
            this.Sequ_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Uncheck_button
            // 
            this.Uncheck_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uncheck_button.Location = new System.Drawing.Point(1162, 163);
            this.Uncheck_button.Name = "Uncheck_button";
            this.Uncheck_button.Size = new System.Drawing.Size(70, 21);
            this.Uncheck_button.TabIndex = 27;
            this.Uncheck_button.Text = "UnCheck";
            this.Uncheck_button.UseVisualStyleBackColor = true;
            this.Uncheck_button.Click += new System.EventHandler(this.Uncheck_button_Click);
            // 
            // Room_Panel
            // 
            this.Room_Panel.Location = new System.Drawing.Point(9, 6);
            this.Room_Panel.Name = "Room_Panel";
            this.Room_Panel.Size = new System.Drawing.Size(944, 480);
            this.Room_Panel.TabIndex = 2;
            this.Room_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Room_Panel_Paint);
            this.Room_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Room_Panel_MouseDown);
            this.Room_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Room_Panel_MouseMove);
            this.Room_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Room_Panel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 494);
            this.Controls.Add(this.Uncheck_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ValueToColor);
            this.Controls.Add(this.Value_to_color_set_btn);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.Cell_side_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Window_RadioButton);
            this.Controls.Add(this.Block_RadioButton);
            this.Controls.Add(this.Normal_Cell_RadioButton);
            this.Controls.Add(this.Cold_Soruce_RadioButton);
            this.Controls.Add(this.Heat_Soruce_RadioButton);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Room_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DoubleBufferedPanel Room_Panel;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.RadioButton Heat_Soruce_RadioButton;
        private System.Windows.Forms.RadioButton Cold_Soruce_RadioButton;
        private System.Windows.Forms.RadioButton Normal_Cell_RadioButton;
        private System.Windows.Forms.RadioButton Block_RadioButton;
        private System.Windows.Forms.RadioButton Window_RadioButton;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.TextBox Cell_side_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Value_to_color_set_btn;
        private System.Windows.Forms.RadioButton Parallel_C_plusPlus_RadioButton;
        private color_map.UserControl1 ValueToColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Parallel_C_Sharp_RadioButton;
        private System.Windows.Forms.RadioButton Sequ_RadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number_Of_Threads_textBox1;
        private System.Windows.Forms.Button num_of_threads_button;
        private System.Windows.Forms.Button Uncheck_button;
    }
}

