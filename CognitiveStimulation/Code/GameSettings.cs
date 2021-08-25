using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cognitive_Stimulation
{    
    public  class GameSettings
    { 

        public static readonly int MIN_PIECE_WIDTH = 50;    
        public static readonly int MIN_PIECE_HEIGHT = 50;   

        public static readonly int NUM_ROWS = 5;
        public static readonly int NUM_COLUMNS = 5;
        
        public static readonly int SNAP_TOLERANCE = 15;
        public static readonly byte GHOST_PICTURE_ALPHA = 127;
        
        public static readonly int PIECE_OUTLINE_WIDTH = 4;
        public static readonly bool DRAW_PIECE_OUTLINE = true;

        public static readonly int DROP_SHADOW_DEPTH = 3;
        public static readonly Color DROP_SHADOW_COLOR = Color.FromArgb(50, 50, 50);

        public int[] TheArray = new int[1000];
        private int m_CorrectCount;
        public int CorrectCount
        {
            set { m_CorrectCount = value; }
            get { return m_CorrectCount; }
        }
        private int m_Turn;
        public int Turn
        {
            set { m_Turn = value; }
            get { return m_Turn; }
        }

        private int m_Count;
        public int Count
        {
            set { m_Count = value; }
            get { return m_Count; }
        }

        private bool m_Play;
        public bool Play
        {
            set { m_Play = value; }
            get { return m_Play; }
        }

        public GameSettings()
        {
            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                TheArray[i] = rnd.Next(0, 4);
            }

            m_Play = false;
            m_Turn = 0;
            m_Count = 0;
            m_CorrectCount = 0;
        }

        public void GameOver(Control btn,Control CloseButton, CommonFunctions common, string time, string score)
        {
            m_timer.Enabled = false;
            common.GameComplete = true;

            common.EndGame(btn, CloseButton, "Simon", "Time: " + time, "Score: " + score, System.Drawing.Color.DeepSkyBlue);


            m_Play = false;
            m_Turn = 0;
            m_Count = 0;
            m_CorrectCount = 0;
        }

        #region Timer
        public void Start()
        {
            m_timer = new Timer();
            m_timer.Interval = 500;
            m_timer.Tick += new EventHandler(TimerTick);
            m_timer.Enabled = true;
        }

        public void Restart()
        {
            m_timer.Enabled = true;
            m_Count = 0;
        }

        public void Stop()
        {
            m_timer.Enabled = false;
            m_Play = true;
            m_Count = 0;
        }

        private Timer m_timer;
        public event EventHandler Tick;

        private void TimerTick(object sender, EventArgs e)
        {
            if (Tick != null)
            {
                Tick(this, new EventArgs());
            }
        }
        #endregion
    } 
}
