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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private Ninja You = new Ninja(400, 40, 40);
        private Ninja Enemy = new Ninja(450, 80, 30);
        private void UpdateStats()
        {
            textBox1.Text = You.Lifepoints.ToString();
            textBox4.Text = Enemy.Lifepoints.ToString();
            textBox2.Text = You.Attack.ToString();
            textBox5.Text = Enemy.Attack.ToString();
            textBox3.Text = You.Energy.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            You.Slash(ref Enemy);
            MessageBox.Show("'Kogeki!' You Attack!");
            UpdateStats();
            int y;
            y = int.Parse(textBox4.Text);
            if (y <= 0)
            {
                MessageBox.Show("'Kuso kurae!!' Enemy defeated");
                this.Close();
            }
            else
            {
                Enemy.Slash(ref You);
                MessageBox.Show("'Nani!' Enemy fights back");
                You.EnergyRestore(ref You);
                UpdateStats();
            }
            int z;
            z = int.Parse(textBox1.Text);
            if (z <= 0)
            {
                MessageBox.Show("Lol, you died");
                System.Windows.Forms.Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            You.Heal(ref You);
            MessageBox.Show("You take a break");
            UpdateStats();
            Enemy.Slash(ref You);
            MessageBox.Show("But the enemy doesn't wait");
            You.EnergyRestore(ref You);
            UpdateStats();
            int c;
            c = int.Parse(textBox1.Text);
            if (c <= 0)
            {
                MessageBox.Show("Lol, you died");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            You.PowerUp(ref You);
            MessageBox.Show("Surpass your limits and reached greater heights");
            UpdateStats();
            Enemy.Slash(ref You);
            MessageBox.Show("The enemy doesn't care");
            You.EnergyRestore(ref You);
            UpdateStats();
            int b;
            b = int.Parse(textBox1.Text);
            if (b <= 0)
            {
                MessageBox.Show("Lol, you died");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            You.Yamimahou(ref Enemy);
            MessageBox.Show("'Kurae!!' You activate your special!");
            UpdateStats();
            int x;
            x = int.Parse(textBox4.Text);
            if (x <= 0)
            {
                MessageBox.Show("'Kuso kurae!!' Enemy defeated");
                this.Close();
            }
            else
            {
                Enemy.Slash(ref You);
                MessageBox.Show("'Name n na!!' Enemy retaliates");
                You.EnergyRestore(ref You);
                UpdateStats();
            }
            int a;
            a = int.Parse(textBox1.Text);
            if (a <= 0)
            {
                MessageBox.Show("Lol, you died");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Special Attack Yamimahou | Cost: 50 Energy");
        }
    }
}
