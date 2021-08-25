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
    public partial class ArrowsGame_Form : Form
    {
        CommonFunctions common = new CommonFunctions(1);
         
        int sec;
        Random r = new Random();
        int x = 4;
        int correct = 0; 
        int wrong = 0; 
        int y;  
        int z;

        public ArrowsGame_Form()
        {
            KeyPreview = true;
            InitializeComponent(); 
        }

        private void btnExitArrowGame_Click(object sender, EventArgs e)
        {
            if (common.GameStarted)
                common.EndGame(null,null, null,null,null, System.Drawing.Color.Orange);

            this.Close();
        }
        public void Check(int y)
        {
            if (sec != 0)
            {
                if (x % 4 == y)
                {
                    correct++;

                }
                else
                {
                    wrong++;
                }
                LabelRight.Text = correct.ToString();
                LabelWrong.Text = wrong.ToString();
                do
                {
                    x = r.Next(1, 5);
                } while (x == z);
                z = x;
                pictureboxGame1.Image = Image.FromFile(x + ".png");
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            { 
                case Keys.Left: 
                    y = 2;
                    Check(y);
                    return true; 
                case Keys.Right:  
                    y = 0;
                    Check(y);
                    return true;
                case Keys.Up:
                    y = 3;
                    Check(y);
                    return true;
                case Keys.Down:
                    y = 1;
                    Check(y);
                    return true;



            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
         
        private void btnArrowStart_Click(object sender, EventArgs e)
        {  
            common.StartGame(btnArrowStart, btnBack); 
            pictureboxGame1.Visible = true;

            RestartAll();

            sec = 60;
            timer1.Start();
            z = 3;
            x = 3; 
            correct = 0;
            wrong = 0;
            LabelWrong.Text = "0";
            LabelRight.Text = "0";

            common.FirstLoad = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec - 1;
            var displayValue = sec == 0 ? "1:00" : "0:" + (60 - sec).ToString();
            if (sec == 0)
            { 
               string message = "Correct: " + correct.ToString() + '\n' + "Incorrect: " + wrong.ToString() + '\n' ;

                timer1.Stop(); 
                common.GameComplete = true; 
                common.EndGame(btnArrowStart, btnBack, "Arrows","Time: " + displayValue, "Score: "+ message, System.Drawing.Color.Orange);
            }
            Countdown.Text = sec.ToString();
          
            if (common.GameStarted)
                Procedure.UpdateTimeGame(Session.UserGameID, displayValue, (int)correct, (int)wrong);
        }


        private void RestartAll()
        {
            Countdown.Text = "0";
            LabelRight.Text = "0";
            LabelWrong.Text = "0";
        }
         
        private void btnBestScore_Click(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
        }
          
        private void btnBestScore_MouseEnter(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
            lblBestScore.Visible = true;
        }

        private void btnBestScore_MouseHover(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
            lblBestScore.Visible = true;
        }

        private void btnBestScore_MouseLeave(object sender, EventArgs e)
        {
            lblBestScore.Text = "";
            lblBestScore.Visible = false;
        }
    }
}
