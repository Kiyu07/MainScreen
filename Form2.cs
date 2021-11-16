using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.ShowDialog();
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You died from falling of a cliff. Restart the game");
            System.Windows.Forms.Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ran into your dead sister and died from shock. Restart the game");
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            c.ShowDialog();
            button2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.ShowDialog();
            button8.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
