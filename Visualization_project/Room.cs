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

    class Room
    {

        [DllImport(@"E:\FCIS\4th year materials\1st semester\Scientific Visualization\Project\Visualization Project\C++ code\Debug\Parallel_calculations.dll", EntryPoint = "solve", CallingConvention = CallingConvention.Cdecl)]
        public static extern void update_prallel(double[,] data, double[,] temp_data, int[,] nromals, int[,] blocks, int row, int column, int threads);

        //====================================== C++ parallel variables 
        public Cell[,] cells;
        public double[,] color_data, tmp_data;
        public int[,] normal_cells, block_cells;
        //====================================== 
        public int Threads_Number;
        public Room(int row_cells, int column_cells, ref color_map.UserControl1 value_to_color, int thread_num)
        {
            cells = new Cell[row_cells, column_cells];
            color_data = new double[480, 944];
            tmp_data = new double[480, 944];
            normal_cells = new int[480, 944];
            block_cells = new int[480, 944];
            Threads_Number = thread_num;
        }
        public void construct_cells(int room_height, int cell_side, Color cell_color, double mid_color_data)
        {
            int x = 0, y = 0;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                x = 0;
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    color_data[i, j] = mid_color_data;
                    tmp_data[i, j] = mid_color_data;
                    normal_cells[i, j] = 1;
                    block_cells[i, j] = 0;
                    cells[i, j] = new Cell(x, y, cell_side, true, cell_color, false, false, mid_color_data);
                    x += cell_side;
                }
                y += cell_side;
            }
        }
        public void update_cells_sequential()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    int valid_cells_number = 1;

                    cells[i, j].color_data = color_data[i, j];
                    cells[i, j].color_data_tmp = tmp_data[i, j];


                    if (cells[i, j].normal_cell == false)
                        continue;


                    if (i + 1 < cells.GetLength(0) && i + 1 > -1 && j + 1 < cells.GetLength(1) && j + 1 > -1 && cells[i + 1, j + 1].block_cell == false)
                    {

                        cells[i + 1, j + 1].color_data_tmp = tmp_data[i + 1, j + 1];

                        cells[i, j].color_data += cells[i + 1, j + 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i + 1 < cells.GetLength(0) && i + 1 > -1 && j - 1 < cells.GetLength(1) && j - 1 > -1 && cells[i + 1, j - 1].block_cell == false)
                    {
                        cells[i + 1, j - 1].color_data_tmp = tmp_data[i + 1, j - 1];

                        cells[i, j].color_data += cells[i + 1, j - 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i + 1 < cells.GetLength(0) && i + 1 > -1 && j < cells.GetLength(1) && j > -1 && cells[i + 1, j].block_cell == false)
                    {
                        cells[i + 1, j].color_data_tmp = tmp_data[i + 1, j];

                        cells[i, j].color_data += cells[i + 1, j].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i - 1 < cells.GetLength(0) && i - 1 > -1 && j + 1 < cells.GetLength(1) && j + 1 > -1 && cells[i - 1, j + 1].block_cell == false)
                    {
                        cells[i - 1, j + 1].color_data_tmp = tmp_data[i - 1, j + 1];

                        cells[i, j].color_data += cells[i - 1, j + 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i - 1 < cells.GetLength(0) && i - 1 > -1 && j - 1 < cells.GetLength(1) && j - 1 > -1 && cells[i - 1, j - 1].block_cell == false)
                    {
                        cells[i - 1, j - 1].color_data_tmp = tmp_data[i - 1, j - 1];

                        cells[i, j].color_data += cells[i - 1, j - 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i - 1 < cells.GetLength(0) && i - 1 > -1 && j < cells.GetLength(1) && j > -1 && cells[i - 1, j].block_cell == false)
                    {
                        cells[i - 1, j].color_data_tmp = tmp_data[i - 1, j];

                        cells[i, j].color_data += cells[i - 1, j].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i < cells.GetLength(0) && i > -1 && j + 1 < cells.GetLength(1) && j + 1 > -1 && cells[i, j + 1].block_cell == false)
                    {
                        cells[i, j + 1].color_data_tmp = tmp_data[i, j + 1];

                        cells[i, j].color_data += cells[i, j + 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i < cells.GetLength(0) && i > -1 && j - 1 < cells.GetLength(1) && j - 1 > -1 && cells[i, j - 1].block_cell == false)
                    {
                        cells[i, j - 1].color_data_tmp = tmp_data[i, j - 1];

                        cells[i, j].color_data += cells[i, j - 1].color_data_tmp;
                        valid_cells_number++;
                    }
                    cells[i, j].color_data /= (double)valid_cells_number;
                    color_data[i, j] = cells[i, j].color_data;
                }
            }
        }
        public void update_tmp_value_sequential()
        {
            foreach (Cell c in cells)
            {
                c.color_data_tmp = c.color_data;
                tmp_data[c.y / c.side, c.x / c.side] = c.color_data_tmp;
            }
        }
        public void update_cells_c_sharp_parallel()
        {
            Parallel.For(0, cells.GetLength(0), new ParallelOptions { MaxDegreeOfParallelism = Threads_Number }, i =>
            {
                for (int j = 0; j < cells.GetLength(1); ++j)
                {
                    int valid_cells_number = 1;
                    cells[i, j].color_data = color_data[i, j];
                    cells[i, j].color_data_tmp = tmp_data[i, j];

                    if (cells[i, j].normal_cell == false)
                    {
                        continue;
                    }

                    if (i + 1 < cells.GetLength(0) && i + 1 > -1 && j + 1 < cells.GetLength(1) && j + 1 > -1 && cells[i + 1, j + 1].block_cell == false)
                    {

                        cells[i + 1, j + 1].color_data_tmp = tmp_data[i + 1, j + 1];

                        cells[i, j].color_data += cells[i + 1, j + 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i + 1 < cells.GetLength(0) && i + 1 > -1 && j - 1 < cells.GetLength(1) && j - 1 > -1 && cells[i + 1, j - 1].block_cell == false)
                    {
                        cells[i + 1, j - 1].color_data_tmp = tmp_data[i + 1, j - 1];

                        cells[i, j].color_data += cells[i + 1, j - 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i + 1 < cells.GetLength(0) && i + 1 > -1 && j < cells.GetLength(1) && j > -1 && cells[i + 1, j].block_cell == false)
                    {
                        cells[i + 1, j].color_data_tmp = tmp_data[i + 1, j];

                        cells[i, j].color_data += cells[i + 1, j].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i - 1 < cells.GetLength(0) && i - 1 > -1 && j + 1 < cells.GetLength(1) && j + 1 > -1 && cells[i - 1, j + 1].block_cell == false)
                    {
                        cells[i - 1, j + 1].color_data_tmp = tmp_data[i - 1, j + 1];

                        cells[i, j].color_data += cells[i - 1, j + 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i - 1 < cells.GetLength(0) && i - 1 > -1 && j - 1 < cells.GetLength(1) && j - 1 > -1 && cells[i - 1, j - 1].block_cell == false)
                    {
                        cells[i - 1, j - 1].color_data_tmp = tmp_data[i - 1, j - 1];

                        cells[i, j].color_data += cells[i - 1, j - 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i - 1 < cells.GetLength(0) && i - 1 > -1 && j < cells.GetLength(1) && j > -1 && cells[i - 1, j].block_cell == false)
                    {
                        cells[i - 1, j].color_data_tmp = tmp_data[i - 1, j];

                        cells[i, j].color_data += cells[i - 1, j].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i < cells.GetLength(0) && i > -1 && j + 1 < cells.GetLength(1) && j + 1 > -1 && cells[i, j + 1].block_cell == false)
                    {
                        cells[i, j + 1].color_data_tmp = tmp_data[i, j + 1];

                        cells[i, j].color_data += cells[i, j + 1].color_data_tmp;
                        valid_cells_number++;
                    }

                    if (i < cells.GetLength(0) && i > -1 && j - 1 < cells.GetLength(1) && j - 1 > -1 && cells[i, j - 1].block_cell == false)
                    {
                        cells[i, j - 1].color_data_tmp = tmp_data[i, j - 1];

                        cells[i, j].color_data += cells[i, j - 1].color_data_tmp;
                        valid_cells_number++;
                    }
                    cells[i, j].color_data /= (double)valid_cells_number;
                    color_data[i, j] = cells[i, j].color_data;
                }
            });
        }
        public void update_cells_c_plus_plus_parallel()
        {
            update_prallel(color_data, tmp_data, normal_cells, block_cells, cells.GetLength(0), cells.GetLength(1), Threads_Number);
        }
        public void update_tmp_value_c_sharp_parallel()
        {
            Parallel.For(0, cells.GetLength(0), new ParallelOptions { MaxDegreeOfParallelism = Threads_Number }, i =>
            {
                for (int j = 0; j < cells.GetLength(1); ++j)
                {
                    cells[i, j].color_data_tmp = cells[i, j].color_data;
                    tmp_data[cells[i, j].y / cells[i, j].side, cells[i, j].x / cells[i, j].side] = cells[i, j].color_data_tmp;

                }
            });
        }
    }
}
