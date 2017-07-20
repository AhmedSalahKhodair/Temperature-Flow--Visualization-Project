using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_map
{
    public partial class UserControl1 : UserControl
    {

        public Color[] colors = { Color.Blue ,Color.SkyBlue, Color.LimeGreen,Color.Yellow, Color.Red };
        public colorRgb X;

        public double sMin, sMax, s;
        public struct colorRgb
        {
            public double R, G, B;
        }
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Set_SminAndSmax_TextBox(double a, double b)
        {
            sMin = a;
            sMax = b;
            s_min_text.Text = a.ToString();
            s_max_text.Text = b.ToString();
        }
        public void Set_SminAndSmax_fromTextBox()
        {
            sMin = double.Parse(s_min_text.Text);
            sMax = double.Parse(s_max_text.Text);

        }
        public void Colorize(double ss)
        {

            s = ss;

            if (sMin > sMax)
            {
                double temp = sMin;
                sMin = sMax;
                sMax = temp;
            }

            X = new colorRgb();

            if (Dis_radio.Checked == true)
            {
                X = Disc_Value_To_Color();
            }
            else
            {
                X = Cont_Value_To_Color();
            }
        }
        public colorRgb Disc_Value_To_Color()
        {
            colorRgb X = new colorRgb();
            double indx = 0;
            if (s < sMin)
                indx = 0;

            else if (s > sMax || (s - sMax < .000001 && sMax - s < -.000001) || (sMax - s < .000001 && s - sMax < -.000001))
                indx = colors.Length - 1;
            else
            {
                double x = (sMax - sMin), y = (s - sMin), z = y * colors.Length;
                if (x == 0) x = 1;
                indx = (float)z / (float)x;
            }
            indx = Math.Min(Math.Floor(indx), 4);
            X.R = colors[(int)indx].R;
            X.G = colors[(int)indx].G;
            X.B = colors[(int)indx].B;
            return X;
        }
        public colorRgb Cont_Value_To_Color()
        {

            colorRgb X = new colorRgb();

            if (s < sMin)
            {
                X.R = colors[0].R;
                X.G = colors[0].G;
                X.B = colors[0].B;
            }

            else if (s > sMax || (s - sMax < .000001 && sMax - s < -.000001) || (sMax - s < .000001 && s - sMax < -.000001))
            {
                X.R = colors[colors.Length - 1].R;
                X.G = colors[colors.Length - 1].G;
                X.B = colors[colors.Length - 1].B;
            }
            else
            {
                double range = ((float)sMax - (float)sMin) / (colors.Length - 1);
                if (range == 0) range = 1;
                double deltaS = (s - sMin) / range; // nsbtha mn el color range kolo
                int indx = Math.Min((int)Math.Floor(deltaS), 3);
                double perc = deltaS - indx;// nsbtha mn el range (2 colors) ely hya feh bs  
                X.R = ((colors[indx].R) + perc * (colors[indx + 1].R - colors[indx].R));
                X.G = ((colors[indx].G) + perc * (colors[indx + 1].G - colors[indx].G));
                X.B = ((colors[indx].B) + perc * (colors[indx + 1].B - colors[indx].B));
            }

            return X;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            for (int i = 0; i < colors.Length; i++)
            {
                gr.FillRectangle(new SolidBrush(colors[i]), (panel1.Width / colors.Length) * i, 0, (panel1.Width / colors.Length), panel1.Height);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            float strt = 0, end = panel2.Width, range = panel2.Width / (colors.Length - 1), perc = 0;
            for (int i = 0; i < colors.Length - 1; i++)
            {
                strt = i * range;
                end = strt + range;
                for (float y = strt; y < end; y++)
                {
                    perc = (y - strt) / range;
                    int r = (int)((colors[i].R * (1 - perc)) + (colors[i + 1].R * perc));
                    int g = (int)((colors[i].G * (1 - perc)) + (colors[i + 1].G * perc));
                    int b = (int)((colors[i].B * (1 - perc)) + (colors[i + 1].B * perc));
                    Color C = Color.FromArgb(r, g, b);
                    gr.FillRectangle(new SolidBrush(C), y, 0, y + 1, panel2.Height);
                }

            }
        }

    }
}
