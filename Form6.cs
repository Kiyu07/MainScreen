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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private Ninja You = new Ninja(300, 40, 50);
        private Ninja Enemy = new Ninja(400, 35, 30);
        private void UpdateStats()
        {
            textBox1.Text = You.Lifepoints.ToString();
            textBox4.Text = Enemy.Lifepoints.ToString();
            textBox2.Text = You.Attack.ToString();
            textBox5.Text = Enemy.Attack.ToString();
            textBox3.Text = You.Energy.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            UpdateStats();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            You.Slash(ref Enemy);
            MessageBox.Show("You Attack!");
            UpdateStats();
            int y;
            y = int.Parse(textBox4.Text);
            if (y <= 0)
            {
                MessageBox.Show("Defeat");
                this.Close();
            }
            else
            {
                Enemy.Slash(ref You);
                MessageBox.Show("Enemy fights back");
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
            MessageBox.Show("Enemy doesn't wait");
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
            MessageBox.Show("Hamehamehaaaa");
            UpdateStats();
            Enemy.Slash(ref You);
            MessageBox.Show("Enemy attacks");
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
            You.Backslash(ref Enemy);
            MessageBox.Show("Special Activated");
            UpdateStats();
            int x;
            x = int.Parse(textBox4.Text);
            if (x <= 0)
            {
                MessageBox.Show("Defeat");
                this.Close();
            }
            else
            {
                Enemy.Slash(ref You);
                MessageBox.Show("Enemy fights back");
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
    }
}
