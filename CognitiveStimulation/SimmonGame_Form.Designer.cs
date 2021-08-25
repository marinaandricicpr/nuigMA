namespace Cognitive_Stimulation
{
    partial class SimmonGame_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimmonGame_Form));
            this.turnOffTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitArrowGame = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.howToLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBestScore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnStartSimmon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMovesValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.simonButtonYellow = new Cognitive_Stimulation.simonButton();
            this.simonButtonBlue = new Cognitive_Stimulation.simonButton();
            this.simonButtonRed = new Cognitive_Stimulation.simonButton();
            this.simonButtonGreen = new Cognitive_Stimulation.simonButton();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitArrowGame)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnOffTimer
            // 
            this.turnOffTimer.Interval = 300;
            this.turnOffTimer.Tick += new System.EventHandler(this.turnOffTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.btnBack);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.lblCorrect);
            this.gradientPanel1.Controls.Add(this.simonButtonYellow);
            this.gradientPanel1.Controls.Add(this.simonButtonBlue);
            this.gradientPanel1.Controls.Add(this.simonButtonRed);
            this.gradientPanel1.Controls.Add(this.simonButtonGreen);
            this.gradientPanel1.Controls.Add(this.groupBox2);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1500, 950);
            this.gradientPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnExitArrowGame);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 50);
            this.panel1.TabIndex = 40;
            // 
            // btnExitArrowGame
            // 
            this.btnExitArrowGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExitArrowGame.Image = global::Cognitive_Stimulation.Properties.Resources.home;
            this.btnExitArrowGame.Location = new System.Drawing.Point(1458, 11);
            this.btnExitArrowGame.Name = "btnExitArrowGame";
            this.btnExitArrowGame.Size = new System.Drawing.Size(30, 30);
            this.btnExitArrowGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitArrowGame.TabIndex = 54;
            this.btnExitArrowGame.TabStop = false;
            this.btnExitArrowGame.Click += new System.EventHandler(this.btnExitSimmonGame);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(618, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognitive Stimulation - MEMORY";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.lblBestScore);
            this.panel4.Controls.Add(this.howToLabel);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnBestScore);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(2, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 906);
            this.panel4.TabIndex = 62;
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBestScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBestScore.Location = new System.Drawing.Point(8, 618);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(0, 22);
            this.lblBestScore.TabIndex = 59;
            // 
            // howToLabel
            // 
            this.howToLabel.AutoSize = true;
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.howToLabel.Location = new System.Drawing.Point(3, 285);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(322, 162);
            this.howToLabel.TabIndex = 53;
            this.howToLabel.Text = "Simon highlights color \r\nlenses in the specific \r\norder and player               " +
    "    \r\nhas to repeat the pattern \r\nwhich progressively \r\nincreases in  dificulty " +
    "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-1, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 63);
            this.button1.TabIndex = 55;
            this.button1.Text = "How to play ????";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 37);
            this.label6.TabIndex = 52;
            this.label6.Text = "Simon Game";
            // 
            // btnBestScore
            // 
            this.btnBestScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBestScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestScore.ForeColor = System.Drawing.Color.Black;
            this.btnBestScore.Location = new System.Drawing.Point(-1, 552);
            this.btnBestScore.Name = "btnBestScore";
            this.btnBestScore.Size = new System.Drawing.Size(335, 63);
            this.btnBestScore.TabIndex = 58;
            this.btnBestScore.Text = "Best Score";
            this.btnBestScore.UseVisualStyleBackColor = false;
            this.btnBestScore.Click += new System.EventHandler(this.btnBestScore_Click);
            this.btnBestScore.MouseEnter += new System.EventHandler(this.btnBestScore_MouseEnter);
            this.btnBestScore.MouseLeave += new System.EventHandler(this.btnBestScore_MouseLeave);
            this.btnBestScore.MouseHover += new System.EventHandler(this.btnBestScore_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cognitive_Stimulation.Properties.Resources.MEMORY;
            this.pictureBox1.Location = new System.Drawing.Point(82, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AccessibleDescription = "lbl";
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblCorrect.Location = new System.Drawing.Point(861, 419);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(54, 59);
            this.lblCorrect.TabIndex = 32;
            this.lblCorrect.Text = "0";
            // 
            // btnStartSimmon
            // 
            this.btnStartSimmon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStartSimmon.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimmon.ForeColor = System.Drawing.Color.Black;
            this.btnStartSimmon.Location = new System.Drawing.Point(314, 522);
            this.btnStartSimmon.Name = "btnStartSimmon";
            this.btnStartSimmon.Size = new System.Drawing.Size(285, 63);
            this.btnStartSimmon.TabIndex = 3;
            this.btnStartSimmon.Text = "Start";
            this.btnStartSimmon.UseVisualStyleBackColor = false;
            this.btnStartSimmon.Click += new System.EventHandler(this.btnStartSimmon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.lblMovesValue);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblMoves);
            this.groupBox2.Controls.Add(this.lblTimeValue);
            this.groupBox2.Location = new System.Drawing.Point(1217, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 70);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // lblMovesValue
            // 
            this.lblMovesValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMovesValue.AutoSize = true;
            this.lblMovesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMovesValue.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblMovesValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovesValue.Location = new System.Drawing.Point(215, 25);
            this.lblMovesValue.Name = "lblMovesValue";
            this.lblMovesValue.Size = new System.Drawing.Size(21, 22);
            this.lblMovesValue.TabIndex = 31;
            this.lblMovesValue.Text = "0";
            this.lblMovesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(7, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 22);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoves
            // 
            this.lblMoves.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoves.AutoSize = true;
            this.lblMoves.BackColor = System.Drawing.Color.Transparent;
            this.lblMoves.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblMoves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoves.Location = new System.Drawing.Point(138, 25);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(71, 22);
            this.lblMoves.TabIndex = 30;
            this.lblMoves.Text = "Moves:";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTimeValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeValue.Location = new System.Drawing.Point(66, 26);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(21, 22);
            this.lblTimeValue.TabIndex = 29;
            this.lblTimeValue.Text = "0";
            this.lblTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnStartSimmon);
            this.panel3.Location = new System.Drawing.Point(428, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 699);
            this.panel3.TabIndex = 64;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(742, 808);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 63);
            this.btnBack.TabIndex = 68;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExitSimmonGame);
            // 
            // simonButtonYellow
            // 
            this.simonButtonYellow.Clicked = false;
            this.simonButtonYellow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simonButtonYellow.Location = new System.Drawing.Point(731, 450);
            this.simonButtonYellow.Name = "simonButtonYellow";
            this.simonButtonYellow.Rotation = 270;
            this.simonButtonYellow.Size = new System.Drawing.Size(150, 150);
            this.simonButtonYellow.TabIndex = 2;
            this.simonButtonYellow.Text = "simonButtonYellow";
            this.simonButtonYellow.UseVisualStyleBackColor = true;
            this.simonButtonYellow.Click += new System.EventHandler(this.simonButton_Click);
            // 
            // simonButtonBlue
            // 
            this.simonButtonBlue.Clicked = false;
            this.simonButtonBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.simonButtonBlue.Location = new System.Drawing.Point(731, 294);
            this.simonButtonBlue.Name = "simonButtonBlue";
            this.simonButtonBlue.Rotation = 0;
            this.simonButtonBlue.Size = new System.Drawing.Size(150, 150);
            this.simonButtonBlue.TabIndex = 0;
            this.simonButtonBlue.Text = "simonButtonBlue";
            this.simonButtonBlue.UseVisualStyleBackColor = true;
            this.simonButtonBlue.Click += new System.EventHandler(this.simonButton_Click);
            // 
            // simonButtonRed
            // 
            this.simonButtonRed.Clicked = false;
            this.simonButtonRed.ForeColor = System.Drawing.Color.Orange;
            this.simonButtonRed.Location = new System.Drawing.Point(887, 294);
            this.simonButtonRed.Name = "simonButtonRed";
            this.simonButtonRed.Rotation = 90;
            this.simonButtonRed.Size = new System.Drawing.Size(150, 150);
            this.simonButtonRed.TabIndex = 1;
            this.simonButtonRed.Text = "simonButtonRed";
            this.simonButtonRed.UseVisualStyleBackColor = true;
            this.simonButtonRed.Click += new System.EventHandler(this.simonButton_Click);
            // 
            // simonButtonGreen
            // 
            this.simonButtonGreen.Clicked = false;
            this.simonButtonGreen.ForeColor = System.Drawing.Color.GreenYellow;
            this.simonButtonGreen.Location = new System.Drawing.Point(887, 450);
            this.simonButtonGreen.Name = "simonButtonGreen";
            this.simonButtonGreen.Rotation = 180;
            this.simonButtonGreen.Size = new System.Drawing.Size(306, 202);
            this.simonButtonGreen.TabIndex = 3;
            this.simonButtonGreen.Text = "simonButtonGreen";
            this.simonButtonGreen.UseVisualStyleBackColor = true;
            this.simonButtonGreen.Click += new System.EventHandler(this.simonButton_Click);
            // 
            // SimmonGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 950);
            this.Controls.Add(this.gradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimmonGame_Form";
            this.Text = "Simon Game";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitArrowGame)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel1;
        private System.Windows.Forms.Timer turnOffTimer;
        private simonButton simonButtonYellow;
        private simonButton simonButtonBlue;
        private simonButton simonButtonRed;
        private simonButton simonButtonGreen;  
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExitArrowGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Button btnStartSimmon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblMovesValue;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Button btnBestScore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
    }
}

