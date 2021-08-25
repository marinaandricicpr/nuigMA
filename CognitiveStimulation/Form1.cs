using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Cognitive_Stimulation
{
    public partial class Form1 : Form
    {

        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent(); 
        }
        /*Dragable FORM */
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Basics*/
        private void Form1_Load(object sender, EventArgs e)
        {
            gbMemory.Left = 20;
            ReasoningBox.Left = (gradientPanel1.Width - ReasoningBox.Width) / 2;
            SpeedBox.Left = (gradientPanel1.Width - SpeedBox.Width - 20);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            Session.GameID = 1;
            MemoryGame_Form me = new MemoryGame_Form();
            me.StartPosition = FormStartPosition.CenterParent;
            me.ShowDialog(this);

        }
        private void btnSimmon_Click(object sender, EventArgs e)
        {
            Session.GameID = 2;
            SimmonGame_Form me = new SimmonGame_Form();
            me.StartPosition = FormStartPosition.CenterParent;
            me.ShowDialog(this);

        }
        private void btnPuzzle_Click(object sender, EventArgs e)
        {
            Session.GameID = 3;
            Puzzle vo = new Puzzle();
            vo.StartPosition = FormStartPosition.CenterParent;
            vo.ShowDialog(this);
        }
        private void btnVocabulary_Click(object sender, EventArgs e)
        {
            Session.GameID = 6;
            Words_Form vo = new Words_Form();
            vo.StartPosition = FormStartPosition.CenterParent;
            vo.ShowDialog(this);
        }
        private void btnArrows_Click(object sender, EventArgs e)
        {
            Session.GameID = 5;
            ArrowsGame_Form at = new ArrowsGame_Form(); 
            at.StartPosition = FormStartPosition.CenterParent;
            at.ShowDialog(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Signin_Form vo = new Signin_Form();
            vo.StartPosition = FormStartPosition.CenterParent;
            vo.ShowDialog(this);
        }

        private void btnPuzzleSlide_Click(object sender, EventArgs e)
        {
            Session.GameID = 4;
            Sudoku_Form ps = new Sudoku_Form();
            ps.StartPosition = FormStartPosition.CenterParent;
            ps.ShowDialog(this);
        }
    }
}
