using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Visualization_project
{
    class Cell
    {
        public int x, y, side;
        public bool normal_cell,/*34an n3rf btt2sr b ely 7waleh wla la fa lw b false htb2a heat , cold , block, window */
                    block_cell,/*34an n3rf by2sr f ely 7waleh wla la */
                    window_cell;/*34an arsmlha el border*/
        public Color color;
        public double color_data;
        public double color_data_tmp;
        public Cell(int x, int y, int side, bool normal_cell, Color cell_color, bool block_cell, bool window_cell, double temp_data)
        {
            this.x = x;
            this.y = y;
            this.side = side;
            this.normal_cell = normal_cell;
            this.window_cell = window_cell;
            this.block_cell = block_cell;
            this.color_data = temp_data;
            this.color = cell_color;
        }
        public void update(bool normal_cell, bool block_cell, Color cell_color, bool window_cell, double color_data)
        {
            this.normal_cell = normal_cell;
            this.block_cell = block_cell;
            this.window_cell = window_cell;
            this.color_data = color_data;
            this.color = cell_color;

        }
        public void draw(Graphics graphics)
        {
            if (window_cell == false)
                graphics.FillRectangle(new SolidBrush(color), new Rectangle(this.x, this.y, this.side, this.side));
            else
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                graphics.DrawRectangle(pen, new Rectangle(this.x, this.y, this.side, this.side));
            }
        }

    }
}