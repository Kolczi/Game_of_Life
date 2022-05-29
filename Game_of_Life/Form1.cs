using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private int cellSize;
        private Color aliveColor = Color.White;
        private Color backgroundColor = Color.Black;
        private List<Point> aliveCells;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void prepareBoard()
        {

        }
    }
}
