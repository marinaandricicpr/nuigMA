using System; 
using System.Windows.Forms; 
using Cognitive_Stimulation;

namespace Cognitive_Stimulation
{
    public class CommonFunctions
    {
        public bool GameComplete { get; set; }
        public bool GameStarted { get; set; }

        public int GameLevel { get; set; }

        public bool FirstLoad { get; set; }

        public string GameLevelText(int GameLavel)
        {
            string LevelText = "";
            switch (GameLavel)
            {
                case 1:

                    LevelText = "Beginner";
                    break;
                case 2:

                    LevelText = "Intermediate";
                    break;
                case 3:

                    LevelText = "Advanced";
                    break;
            }
            return LevelText;
        }
        public CommonFunctions(int level)
        {
            GameComplete = false;
            GameStarted = false;

            GameLevel = level == 0 ? 5 : level;

            FirstLoad = true;
        }

        public void StartGame(Control btn, Control btnCLose)
        {
            if (btn != null)
                btn.Visible = false;

            if (btnCLose != null)
                btnCLose.Visible = false;

            Procedure.StartGame(Session.UserID, Session.GameID, GameLevel);
            GameStarted = true;
        }

        public void EndGame(Control btn, Control btnCLose,string title, string Time, string Score, System.Drawing.Color color)
        {
            if (btn != null)
                btn.Visible = true;
            if (btnCLose != null)
                btnCLose.Visible = true;

            Procedure.StopGame(Session.UserGameID, GameComplete);
            if (title != null)
                CustomMessageBox.Show(color, title, Time, Score);
            GameStarted = false;
        }


        public void ReStartGame()
        {
            Procedure.StopGame(Session.UserGameID, GameComplete);
            Procedure.StartGame(Session.UserID, Session.GameID, GameLevel);
            GameStarted = true;
            GameComplete = false;
        }
    }
}
