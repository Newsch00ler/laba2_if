using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDereza_laba2_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textA.Text = Properties.Settings.Default.a.ToString();
            textB.Text = Properties.Settings.Default.b.ToString();
            textC.Text = Properties.Settings.Default.c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(this.textA.Text);
            float b = float.Parse(this.textB.Text); 
            float c = float.Parse(this.textC.Text);

            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Math(a, b, c));
        }
    }

    public class Logic
    {
        public static string Math(float a, float b, float c)
        {
            string message = "Треугольник не существует";
            if ((a < b + c) || (b < a + c) || (c < a + b))
            {
                if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                {
                    message = "Прямоугольный треугольник существует";
                }
                else
                {
                    message = "Прямоугольный треугольник не существует";
                }
            }
            return message;
        }
    }
}
