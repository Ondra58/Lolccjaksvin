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
        Pekar pekar;
        private void button1_Click(object sender, EventArgs e)
        {
            zamestnanec = new Zamestnanec(textBox1.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
            pekar = new Pekar(textBox1.Text, dateTimePicker1.Value, (int)numericUpDown1.Value, (int)numericUpDown3.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zamestnanec.Vypis());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pekar.OdpracujHodiny((int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }
    }
}
