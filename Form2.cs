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

        private int counter;
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.ShowDialog();
            button1.Visible = false;
            counter += 1;
            count.Text = counter.ToString();
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
            button4.Visible = false;
            counter += 1;
            count.Text = counter.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.ShowDialog();
            button8.Visible = false;
            counter += 1;
            count.Text = counter.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
            button6.Visible = false;
            counter += 1;
            count.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Maze1 g = new Maze1();
            g.ShowDialog();
            button2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Maze2 h = new Maze2();
            h.ShowDialog();
            button7.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Maze3 i = new Maze3();
            i.ShowDialog();
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(counter == 4)
            {
                MessageBox.Show("Welp, in the end there is no hidden treasure in the cave. What matters is the fun you had. HAHAHA");
                this.Close();
            }
            else
            {
                MessageBox.Show("I feel like Im missing something");
            }
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Rest: Heals 20 LP and Increase Energy by 20. | Energize: Increase Attack and Energy by 10 | Beware of some buttons! You need to win 4 battles to finish the game");
        }
    }
}
