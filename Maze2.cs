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
    public partial class Maze2 : Form
    {
        Point startLocation;
        public Maze2()
        {
            InitializeComponent();
            startLocation = panel1.Location;
            Cursor.Position = PointToScreen(startLocation);
        }

        private void MazeWall(object sender, EventArgs e)
        {
            MessageBox.Show("Whoops, you touched the walls. Rip. No hint 4 you! XP");
            this.Close();
        }

        private void panelOuter_MouseEnter(object sender, EventArgs e)
        {
            startLocation = panel1.Location;
            Cursor.Position = PointToScreen(startLocation);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats on completing the game! Here's a hint! Don't click the button on the middle!");
            this.Close();
        }
    }
}
