using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double x1, y1, z1, r1;
            if (double.TryParse(x.Text, out x1) == false && double.TryParse(y.Text, out y1) == false && double.TryParse(z.Text, out z1) == false)
            {
                MessageBox.Show("Помилка введення значення x, y та z !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(x.Text, out x1) == false && double.TryParse(y.Text, out y1) == false)
            {
                MessageBox.Show("Помилка введення значення x та y !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(z.Text, out z1) == false && double.TryParse(y.Text, out y1) == false)
            {
                MessageBox.Show("Помилка введення значення y та z !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(x.Text, out x1) == false && double.TryParse(z.Text, out z1) == false)
            {
                MessageBox.Show("Помилка введення значення x та z !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(x.Text, out x1) == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(y.Text, out y1) == false)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(z.Text, out z1) == false)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             else
            {
                x1 = Convert.ToDouble(x.Text);
                y1 = Convert.ToDouble(y.Text);
                z1 = Convert.ToDouble(z.Text);


                r1 = (2 * Math.Cos(x1 * x1) - 0.5) / (0.5 + Math.Sin(Math.Pow(y1, 2 - z1))) + (z1 * z1 / (7 - z1 / 3));
                r.Text = r1.ToString("F2");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }
    }
}
