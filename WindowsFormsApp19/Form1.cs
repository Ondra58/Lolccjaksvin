using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zamestnanec zamestnanec;
        private void button1_Click(object sender, EventArgs e)
        {
            zamestnanec = new Zamestnanec(textBox1.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zamestnanec.Vypis());
        }
    }
}
