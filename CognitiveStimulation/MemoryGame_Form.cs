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
    public partial class MemoryGame_Form : Form
    {
        CommonFunctions common = new CommonFunctions(1);
         
        int pairFound = 0;
        int wrongPair = 0;
         
        int usedtime = 0, valitut = 0, displaytime = -1;
        int pairs = 0, transfers = 0;
        int[,] img = new int[5, 6];
        int[,] displayedImagesArray = new int[5, 6];
        int[,] selectedArray = new int[2, 2];

        int[,] levels = new int[,] { { 3, 2 }, { 2, 4 }, { 3, 4 }, { 4, 4 }, { 5, 4 }, { 5, 6 } };

        MyPicBox[,] cardsArray = new MyPicBox[5, 6];
        Random r = new Random();

        public MemoryGame_Form()
        {
            InitializeComponent();
            if (Session.UserID < 1)
                Session.UserID = 1; 
        }

        private void Card_Click(object sender, EventArgs e)
        {
            MyPicBox pb = (MyPicBox)sender;

            if ((displaytime == -1) && ((pb.y < levels[common.GameLevel, 0]) && (pb.x < levels[common.GameLevel, 1])))
            {
                if (displayedImagesArray[pb.y, pb.x] == 0)
                {
                    selectedArray[valitut, 0] = pb.y;
                    selectedArray[valitut, 1] = pb.x;
                    cardsArray[pb.y, pb.x].Image = imageList1.Images[img[pb.y, pb.x]];
                    displayedImagesArray[pb.y, pb.x] = img[pb.y, pb.x];
                    valitut++;

                    if (valitut == 2)
                    {
                        transfers++;

                        if (img[selectedArray[0, 0], selectedArray[0, 1]] == img[selectedArray[1, 0], selectedArray[1, 1]])
                        {
                            pairs--;
                            try
                            {
                                pairFound++; 
                            }
                            catch { }

                            if (pairs == 0)
                            {
                                common.GameComplete = true;
                                 
                                common.EndGame(btnMemoryStart, btnBack, "Memory","Time: "+ lblTimeValue.Text, "Score: "+ (Convert.ToInt32(lblMovesValue.Text)+1).ToString(), System.Drawing.Color.DeepSkyBlue);
                                
                                levelPanel.Visible = false;
                                this.panel3.Visible = false; 

                                stirimg();
                                imagesArray();
                                transfers = 0;
                                usedtime = 0; 
                                pairFound = 0;
                                wrongPair = 0;

                                timer1.Stop();
                                lblMovesValue.Text = "0";
                                lblTimeValue.Text = "0:00";
                            }
                        }
                        else 
                        {
                            displaytime = 10; 
                            try
                            {
                                wrongPair++; 
                            }
                            catch { }
                        }

                        valitut = 0;
                    }
                }
            }
        }


        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnRight.Enabled = true;
            common.GameLevel--;
            if (common.GameLevel < 2)
                btnLeft.Enabled = false;
             
            common.ReStartGame();

            stirimg();
            imagesArray();
            transfers = 0;
            usedtime = 0;
             
            pairFound = 0;
            wrongPair = 0;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnLeft.Enabled = true;
            common.GameLevel++;
            if (common.GameLevel > 4)
                btnRight.Enabled = false;

            stirimg();
            imagesArray();
            transfers = 0;
            usedtime = 0;

            common.ReStartGame();

            pairFound = 0;
            wrongPair = 0;
        }

        private void btnMemoryStart_Click(object sender, EventArgs e)
        {    
            levelPanel.Visible = true;
            if (common.FirstLoad)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        cardsArray[i, j] = new MyPicBox(i, j);
                        cardsArray[i, j].Location = new System.Drawing.Point(0 + j * 130, 0 + i * 130);
                        cardsArray[i, j].Size = new System.Drawing.Size(130, 130);
                        cardsArray[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
                        cardsArray[i, j].Click += new System.EventHandler(Card_Click);
                        this.panel3.Controls.Add(cardsArray[i, j]);
                    }
                }
                common.FirstLoad = false;
            }
            this.panel3.Visible = true;
            stirimg();
            imagesArray();
            transfers = 0;
            usedtime = 0;
            btnRight.Enabled = true;
            common.StartGame(btnMemoryStart, btnBack);
            pairFound = 0;
            wrongPair = 0;

            timer1.Start();
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

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (common.GameStarted)
                common.EndGame(null,null,null,null,null, System.Drawing.Color.DeepSkyBlue);
            this.Close();
        }

        private void imagesArray()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((i < levels[common.GameLevel, 0]) && (j < levels[common.GameLevel, 1]))
                        cardsArray[i, j].Image = imageList1.Images[displayedImagesArray[i, j]];
                    else
                        cardsArray[i, j].Image = Image.FromFile("EMPTY_Card.bmp");
                }
            }

            lblLevel.Text = "Level: " + (common.GameLevel);
        }

        private void stirimg()
        {
            pairs = levels[common.GameLevel, 0] * levels[common.GameLevel, 1] / 2;

            for (int i = 0; i < levels[common.GameLevel, 0]; i++)
            {
                for (int j = 0; j < levels[common.GameLevel, 1]; j++)
                {
                    img[i, j] = (i * 6 + j) / 2 + 1;
                    displayedImagesArray[i, j] = 0;
                }
            }

            for (int i = 0; i < 100; i++)
            {
                int tmp, x1, x2, y1, y2;

                y1 = r.Next(0, levels[common.GameLevel, 0]);
                x1 = r.Next(0, levels[common.GameLevel, 1]);
                y2 = r.Next(0, levels[common.GameLevel, 0]);
                x2 = r.Next(0, levels[common.GameLevel, 1]);
                tmp = img[y1, x1];
                img[y1, x1] = img[y2, x2];
                img[y2, x2] = tmp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int min, sec;

            if (pairs > 0)
                usedtime++;

            min = usedtime / 600;
            sec = (usedtime - min * 600) / 10;
            lblTimeValue.Text = min + ":" + sec.ToString("00");
            lblMovesValue.Text = transfers.ToString();
            if (common.GameStarted)
                Procedure.UpdateTimeGame(Session.UserGameID, lblTimeValue.Text, pairFound, wrongPair);

            if (displaytime >= 0)
                displaytime--;

            if (displaytime == 0)
            {
                cardsArray[selectedArray[0, 0], selectedArray[0, 1]].Image = imageList1.Images[0];
                displayedImagesArray[selectedArray[0, 0], selectedArray[0, 1]] = 0;
                cardsArray[selectedArray[1, 0], selectedArray[1, 1]].Image = imageList1.Images[0];
                displayedImagesArray[selectedArray[1, 0], selectedArray[1, 1]] = 0;
            }
        }
    }


    public class MyPicBox : PictureBox
    {
        public int x, y;

        public MyPicBox(int i, int j)
        {
            y = i;
            x = j;
        }
    }
}
