using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassenStatisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Zahl x = new Zahl(2.5);
            Zahl p = new Zahl(-5);
            x.MalDrei();
            label1.Text = $"{x}\n{p}\n\n";

            double y = 4.3;
            label1.Text += $"y: {y}\n" + $"Nach Verdoppelung: {Zahl.Verdoppeln(y)}\n\n";

            double r = 6.2;
            label1.Text += $"Radius: {r}\nFläche: {r*r*Zahl.pi}";
    }
}
