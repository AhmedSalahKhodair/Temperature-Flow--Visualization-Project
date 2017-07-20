using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Visualization_project
{
    public partial class Form1 : Form
    {
        Room room;
        Color mid_color;
        int cell_side;
        double mid_color_data;
        bool mouse_clicked = false, value_to_color_btn = false, simulation_is_running = false, stop_pressed = false;
        double old_sMin, old_sMax;
        ToolTip hint;
        public Form1()
        {
            InitializeComponent();
            mid_color = ValueToColor.colors[ValueToColor.colors.Length / 2];
            Room_Panel.BackColor = mid_color;
            hint = new ToolTip();
        }
        private void Room_Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics pnlGraphix = e.Graphics;
            if (mouse_clicked == true || simulation_is_running == true || stop_pressed == true)
            {
                foreach (Cell c in room.cells)
                {
                    if (Parallel_C_plusPlus_RadioButton.Checked == true)
                        ValueToColor.Colorize(room.color_data[c.y / cell_side, c.x / cell_side]);
                    else
                        ValueToColor.Colorize(c.color_data);
                    c.color = Color.FromArgb((int)ValueToColor.X.R, (int)ValueToColor.X.G, (int)ValueToColor.X.B);
                    if (c.block_cell == true)
                        c.color = Color.Black;
                    c.draw(pnlGraphix);
                }
            }
            stop_pressed = false;
        }
        private void Room_Panel_MouseDown(object sender, MouseEventArgs e)
        {

            Panel p = (Panel)sender;
            Point tmp = p.PointToClient(Cursor.Position);
            if (cell_side == 0 || (tmp.X / cell_side) >= room.cells.GetLength(1) || (tmp.X / cell_side) < 0 || (tmp.Y / cell_side) >= room.cells.GetLength(0) || (tmp.Y / cell_side) < 0)
                return;
            tmp.X /= cell_side;
            tmp.Y /= cell_side;
            //====================================================
            if (Heat_Soruce_RadioButton.Checked == true)
            {
                room.cells[tmp.Y, tmp.X].update(false, false, ValueToColor.colors[ValueToColor.colors.Length - 1], false, ValueToColor.sMax);
                room.color_data[tmp.Y, tmp.X] = ValueToColor.sMax;
                room.normal_cells[tmp.Y, tmp.X] = 0;
                room.block_cells[tmp.Y, tmp.X] = 0;
            }
            else if (Cold_Soruce_RadioButton.Checked == true)
            {
                room.cells[tmp.Y, tmp.X].update(false, false, ValueToColor.colors[0], false, ValueToColor.sMin);
                room.color_data[tmp.Y, tmp.X] = ValueToColor.sMin;
                room.normal_cells[tmp.Y, tmp.X] = 0;
                room.block_cells[tmp.Y, tmp.X] = 0;
            }
            else if (Block_RadioButton.Checked == true)
            {
                room.cells[tmp.Y, tmp.X].update(false, true, Color.Black, false, 0);
                room.color_data[tmp.Y, tmp.X] = 0;
                room.normal_cells[tmp.Y, tmp.X] = 0;
                room.block_cells[tmp.Y, tmp.X] = 1;
            }
            else if (Window_RadioButton.Checked == true)
            {
                room.cells[tmp.Y, tmp.X].update(false, false, mid_color, true, (ValueToColor.sMax + ValueToColor.sMin) / 2.0);
                room.color_data[tmp.Y, tmp.X] = (ValueToColor.sMax + ValueToColor.sMin) / 2.0;
                room.normal_cells[tmp.Y, tmp.X] = 0;
                room.block_cells[tmp.Y, tmp.X] = 0;
            }
            else if (Normal_Cell_RadioButton.Checked == true)
            {
                room.cells[tmp.Y, tmp.X].update(true, false, mid_color, false, (ValueToColor.sMax + ValueToColor.sMin) / 2.0);
                room.color_data[tmp.Y, tmp.X] = (ValueToColor.sMax + ValueToColor.sMin) / 2.0;
                room.normal_cells[tmp.Y, tmp.X] = 1;
                room.block_cells[tmp.Y, tmp.X] = 0;
            }
            else
            {
                hint.SetToolTip(Room_Panel, "(" + tmp.Y * cell_side + "," + tmp.X * cell_side + "), value :" + room.cells[tmp.Y, tmp.X].color_data.ToString());
            }
            room.tmp_data[tmp.Y, tmp.X] = room.color_data[tmp.Y, tmp.X];
            room.cells[tmp.Y, tmp.X].color_data_tmp = room.cells[tmp.Y, tmp.X].color_data;
            //====================================================
            mouse_clicked = true;
            if (simulation_is_running == false)// 34an b3d mbdos start by3ml ivalidate mrten mra bsbb el click w mra bsbb el cells update fa m4 hy3ml invalidate hna 8er abl ma simulation ybd2.
                Room_Panel.Invalidate();
        }
        private void Value_to_color_set_btn_Click(object sender, EventArgs e)
        {
            if (value_to_color_btn)
            {
                ValueToColor.Set_SminAndSmax_fromTextBox();
                mid_color_data = (ValueToColor.sMin + ValueToColor.sMax) / 2.0;
                foreach (Cell c in room.cells)
                {
                    c.color_data = ((c.color_data - old_sMin) / (old_sMax - old_sMin))*(ValueToColor.sMax - ValueToColor.sMin)+ ValueToColor.sMin;
                    c.color_data_tmp = c.color_data;
                    room.tmp_data[c.y / c.side, c.x / c.side]= c.color_data;
                    room.color_data[c.y / c.side, c.x / c.side] = c.color_data;

                }
                old_sMax = ValueToColor.sMax;
                old_sMin = ValueToColor.sMin;
            }
            ValueToColor.Set_SminAndSmax_fromTextBox();
            mid_color_data = (ValueToColor.sMin + ValueToColor.sMax) / 2.0;
            value_to_color_btn = true;
            old_sMax = ValueToColor.sMax;
            old_sMin = ValueToColor.sMin;
        }
        private void num_of_threads_button_Click(object sender, EventArgs e)
        {
            int num_of_threads = 4;
            if (Number_Of_Threads_textBox1.Text != "")
                num_of_threads = int.Parse(Number_Of_Threads_textBox1.Text);
            room.Threads_Number = num_of_threads;
        }
        private void Start_Button_Click(object sender, EventArgs e)
        {
            simulation_is_running = !simulation_is_running;

            if (simulation_is_running)
                Start_Button.Text = "Stop";
            else
            {
                Start_Button.Text = "Continue";
                stop_pressed = true;
                Room_Panel.Invalidate();
            }

            while (simulation_is_running)
            {
                if (Sequ_RadioButton.Checked)
                {
                    room.update_cells_sequential();
                    room.update_tmp_value_sequential();
                }
                else if (Parallel_C_Sharp_RadioButton.Checked)
                {
                    room.update_cells_c_sharp_parallel();
                    room.update_tmp_value_c_sharp_parallel();
                }
                else
                {
                    room.update_cells_c_plus_plus_parallel();
                }

                Room_Panel.Invalidate();
                Application.DoEvents();
            }
        }
        private void Uncheck_button_Click(object sender, EventArgs e)
        {
            Block_RadioButton.Checked = false;
            Heat_Soruce_RadioButton.Checked = false;
            Window_RadioButton.Checked = false;
            Normal_Cell_RadioButton.Checked = false;
            Cold_Soruce_RadioButton.Checked = false;
        } 
        private void Room_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_clicked == true)
                Room_Panel_MouseDown(sender, e);

        }
        private void Room_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_clicked = false;
        }
        private void Set_Button_Click(object sender, EventArgs e)
        {
            if (value_to_color_btn == true)
            {
                cell_side = int.Parse(Cell_side_txt.Text);
                int row_cells = 480 / cell_side;
                int column_cells = 944 / cell_side;
                Room_Panel.Width = cell_side * column_cells;
                Room_Panel.Height = cell_side * row_cells;
                int num_of_threads = 4;
                if (Number_Of_Threads_textBox1.Text != "")
                    num_of_threads = int.Parse(Number_Of_Threads_textBox1.Text);
                room = new Room(row_cells, column_cells, ref ValueToColor, num_of_threads);
                room.construct_cells(Room_Panel.Height, cell_side, mid_color, mid_color_data);
                room.update_tmp_value_sequential();
                Heat_Soruce_RadioButton.Checked = false;
            }
            else
                MessageBox.Show("Please Set Color Map Data First.");
        }
    }
}