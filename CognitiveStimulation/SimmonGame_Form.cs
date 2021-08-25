using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Cognitive_Stimulation
{
    public partial class SimmonGame_Form : Form
    {
        CommonFunctions common = new CommonFunctions(1);
        private GameSettings m_game;
        int usedtime = 0; 
        public SimmonGame_Form()
        {
            InitializeComponent();

            simonButtonBlue.Enabled = false;
            simonButtonRed.Enabled = false;
            simonButtonYellow.Enabled = false;
            simonButtonGreen.Enabled = false; 
        }
         
        private void btnStartSimmon_Click(object sender, EventArgs e)
        {  
            this.timer1.Enabled = true; 
            m_game = new GameSettings();
            m_game.Tick += new EventHandler(GameTick);
            m_game.Start();
            common.StartGame(btnStartSimmon, btnBack);
            common.FirstLoad = false;
        }

        private void GameTick(object sender, EventArgs e)
        {
            if (m_game.Count <= m_game.Turn)
            {
                switch (m_game.TheArray[m_game.Count])
                {
                    case 0:
                        this.simonButtonBlue.Clicked = true;
                        break;

                    case 1:
                        this.simonButtonRed.Clicked = true;
                        break;

                    case 2:
                        this.simonButtonYellow.Clicked = true;
                        break;

                    case 3:
                        this.simonButtonGreen.Clicked = true;
                        break;

                    default: /* Should never get here */ break;
                }

                m_game.Count++;

                this.turnOffTimer.Enabled = true;
            }

            if (m_game.Count > m_game.Turn)
            {
                m_game.Stop();

                simonButtonBlue.Enabled = true;
                simonButtonRed.Enabled = true;
                simonButtonYellow.Enabled = true;
                simonButtonGreen.Enabled = true;
            }
        }

        private void turnOffTimer_Tick(object sender, EventArgs e)
        {
            this.simonButtonBlue.Clicked = false;
            this.simonButtonRed.Clicked = false;
            this.simonButtonYellow.Clicked = false;
            this.simonButtonGreen.Clicked = false;
            this.turnOffTimer.Enabled = false; 
        }
        private void simonButton_Click(object sender, EventArgs e)
        { 
            if (m_game.Play == true)
            {
                Button btn = (Button)sender;
                int val = 4;

                switch (btn.Text)
                {
                    case "simonButtonBlue":
                        val = 0;
                        break;

                    case "simonButtonRed":
                        val = 1;
                        break;

                    case "simonButtonYellow":
                        val = 2;
                        break;

                    case "simonButtonGreen":
                        val = 3;
                        break;
                }

                if (val == m_game.TheArray[m_game.Count])
                {
                     
                    if (m_game.Count < m_game.Turn)
                    {
                        m_game.Count++;
                    }
                    else
                    {
                        m_game.Play = false;
                        m_game.Turn++;
                        simonButtonBlue.Enabled = false;
                        simonButtonRed.Enabled = false;
                        simonButtonYellow.Enabled = false;
                        simonButtonGreen.Enabled = false;
                        m_game.Restart(); 
                    }
                    if (m_game.CorrectCount < m_game.Count)
                    {
                        m_game.CorrectCount = m_game.Count;

                        lblMovesValue.Text = (m_game.Count + 1).ToString();
                        lblCorrect.Text = (m_game.Count + 1).ToString();
                    }
                }
                else
                {
                    m_game.GameOver(btnStartSimmon, btnBack, common, lblTimeValue.Text, lblMovesValue.Text);
                    Procedure.UpdateTimeGame(Session.UserGameID, lblTimeValue.Text, Convert.ToInt32(lblMovesValue.Text), (int)0);
                    lblMovesValue.Text = "0";
                    lblCorrect.Text = "0";
                    lblTimeValue.Text = "0:00"; ;
                    usedtime=0;

                    simonButtonBlue.Enabled = false;
                    simonButtonRed.Enabled = false;
                    simonButtonYellow.Enabled = false;
                    simonButtonGreen.Enabled = false; 
                    this.timer1.Enabled = false; 
                }
            }
        }

        private void btnExitSimmonGame(object sender, EventArgs e)
        {
            if (common.GameStarted)
                common.EndGame(null,null, null, null, null, System.Drawing.Color.Orange);
            this.Close();
        }

        #region Movement
        // points to hold the current position and the new position for the form and the mouse

        Point MouseCurrentPos, MouseNewPos, formPos, formNewPos;

        bool mouseDown = false;

        private void timer1_Tick(object sender, EventArgs e)
        { 
            int min, sec;

            usedtime++;

            min = usedtime / 600;
            sec = (usedtime - min * 600) / 10;
            int CorrectMove = Convert.ToInt32(lblMovesValue.Text);

            lblTimeValue.Text = min + ":" + sec.ToString("00"); 
        }
          
        private void btnBestScore_Click(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
        }
        private void btnBestScore_MouseEnter(object sender, System.EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
            lblBestScore.Visible = true;
        }

        private void btnBestScore_MouseHover(object sender, System.EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
            lblBestScore.Visible = true;
        }

        private void btnBestScore_MouseLeave(object sender, System.EventArgs e)
        {
            lblBestScore.Text = "";
            lblBestScore.Visible = false;
        }
         

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // when the mouse is down we must activate a flag to say that the left button is down
            // and then store the current position of the mouse and the form and we will 
            // use these posotions to calculate the offset that must be added to the loaction
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                MouseCurrentPos = Control.MousePosition;
                formPos = Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            // when the mouse moves we get its new position then calculate the new location that the form 
            // should be moved to 
            // and then set the current position of the form and the mouse with the new ones 
            if (mouseDown == true)
            {
                MouseNewPos = Control.MousePosition;  // get the position of the mouse in the screen
                formNewPos.X = MouseNewPos.X - MouseCurrentPos.X + formPos.X;
                formNewPos.Y = MouseNewPos.Y - MouseCurrentPos.Y + formPos.Y;
                Location = formNewPos;
                formPos = formNewPos;
                MouseCurrentPos = MouseNewPos;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            // when the user release the mouse button we must update the flag
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
            }
        }
        #endregion
         
    }
}
