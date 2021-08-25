using System; 
using System.Windows.Forms;
using System.IO;

namespace Cognitive_Stimulation
{
    public partial class Words_Form : Form
    {

        CommonFunctions common = new CommonFunctions(1);

        int i;
        int seconds; 
        int ok = 0;
        float corect = 0; 
        float wrong = 0;  

        string[] c = new string[100];  
        string[] c1 = new string[30]; 
        string[] c2 = new string[30];
        string[] c3 = new string[30]; 
        string[] c4 = new string[30]; 
        string[] cc = new string[30]; 


        public Words_Form()
        {
            InitializeComponent();  
        }
        

        /*Basics*/
        private void WordsForm_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("vocabulary.txt");
            for (i = 1; i <= 10; i++)
            {
                c[i] = f.ReadLine();
                c1[i] = f.ReadLine();
                c2[i] = f.ReadLine();
                c3[i] = f.ReadLine();
                c4[i] = f.ReadLine();
                cc[i] = f.ReadLine();
            }
            LabelEnable(true);
            LabelHide(false);
        }

        public void Stop()
        {
            timer1.Stop();
            LabelHide(false);
        }
         
        private void btnVocabulary_Click(object sender, EventArgs e)
        {  
            seconds = 60;
            timer1.Start();

            corect = 0;
            wrong = 0;

            LabelWrong.Text = "0";
            LabelRight.Text = "0";
            LabelQ.Text = c[1].ToString();
            LabelV1.Text = c1[1].ToString();
            LabelV2.Text = c2[1].ToString();
            LabelV3.Text = c3[1].ToString();
            LabelV4.Text = c4[1].ToString();
            LabelHide(true);
            i = 1;

            common.StartGame(btnStartVocabulary, btnBack);
            common.FirstLoad = false;
        } 

        public void Check()
        {
            i++;
            ok = 0;
            if (i <= 10)
            {
                LabelQ.Text = c[i].ToString();
                LabelV1.Text = c1[i].ToString();
                LabelV2.Text = c2[i].ToString();
                LabelV3.Text = c3[i].ToString();
                LabelV4.Text = c4[i].ToString();
            }
            else
                if (corect + wrong == 10)
            {
                Stop();
                string message = "Correct: " + corect.ToString() +", "+ "Incorrect: " + wrong.ToString();
                common.GameComplete = true;
                common.EndGame(btnStartVocabulary, btnBack, "Arrows","Time:"+ seconds.ToString()+" seconds","Score: " + message,System.Drawing.Color.YellowGreen);
            }
        }
          
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds = seconds - 1;
            var displayValue = seconds == 0 ? "1:00" : "0:" + (60 - seconds).ToString();
            if (seconds == 0)
            {
                Stop();
                
                string message =  "Correct: " + corect.ToString() + ", " + "Incorrect: " + wrong.ToString() ;

                common.GameComplete = true; 
                common.EndGame(btnStartVocabulary, btnBack, "Arrows","Time: "+ displayValue, "Score: "+message, System.Drawing.Color.YellowGreen); 
            }
            Countdown.Text = seconds.ToString();
             
            if (common.GameStarted)
                Procedure.UpdateTimeGame(Session.UserGameID, displayValue, (int)corect, (int)wrong);

        }

        private void LabelV_Click(object sender, EventArgs e)
        {
            var buttonName = ((Label)sender).Name;
            if (ok == 0)
            {
                switch (buttonName)
                {
                    case "LabelV1":
                        if (c1[i] == cc[i])
                        {
                            corect++;
                            LabelRight.Text = corect.ToString();
                        }
                        else
                        {
                            wrong++;
                            LabelWrong.Text = wrong.ToString();
                        }
                        break;
                    case "LabelV2":
                        if (c2[i] == cc[i])
                        {
                            corect++;
                            LabelRight.Text = corect.ToString();
                        }
                        else
                        {
                            wrong++;
                            LabelWrong.Text = wrong.ToString();
                        }
                        break;
                    case "LabelV3":
                        if (c3[i] == cc[i])
                        {
                            corect++;
                            LabelRight.Text = corect.ToString();
                        }
                        else
                        {
                            wrong++;
                            LabelWrong.Text = wrong.ToString();
                        }
                        break;
                    case "LabelV4":
                        if (c4[i] == cc[i])
                        {
                            corect++;
                            LabelRight.Text = corect.ToString();
                        }
                        else
                        {
                            wrong++;
                            LabelWrong.Text = wrong.ToString();
                        }
                        break;
                }
            } 
            ok = 1;
            Check();
        } 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (common.GameStarted)
                common.EndGame(null,null, null, null, null , System.Drawing.Color.YellowGreen);
            this.Close(); 
        }

        /*Basics*/
        private void LabelEnable(bool enabled)
        {
            LabelV1.Enabled = enabled;
            LabelV2.Enabled = enabled;
            LabelV3.Enabled = enabled;
            LabelV4.Enabled = enabled;
        }
        private void LabelHide(bool visible)
        {
            LabelV1.Visible = visible;
            LabelV2.Visible = visible;
            LabelV3.Visible = visible;
            LabelV4.Visible = visible;
            LabelQ.Visible = visible;
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
