namespace Cognitive_Stimulation
{
    partial class ArrowsGame_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrowsGame_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.shortLabels5 = new System.Windows.Forms.Label();
            this.LabelWrong = new System.Windows.Forms.Label();
            this.LabelRight = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.howToLabel = new System.Windows.Forms.Label();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.btnBestScore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArrowStart = new System.Windows.Forms.Button();
            this.pictureboxGame1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bigLabel2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExitArrowGame = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGame1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitArrowGame)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 0);
            this.panel1.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.btnBack);
            this.gradientPanel1.Controls.Add(this.groupBox2);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.btnArrowStart);
            this.gradientPanel1.Controls.Add(this.pictureboxGame1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1500, 950);
            this.gradientPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(735, 822);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 63);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExitArrowGame_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMoves);
            this.groupBox2.Controls.Add(this.shortLabels5);
            this.groupBox2.Controls.Add(this.LabelWrong);
            this.groupBox2.Controls.Add(this.LabelRight);
            this.groupBox2.Controls.Add(this.Countdown);
            this.groupBox2.Location = new System.Drawing.Point(1191, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 69);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(220, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Incorrect: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(220, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Correct: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoves
            // 
            this.lblMoves.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoves.AutoSize = true;
            this.lblMoves.BackColor = System.Drawing.Color.Transparent;
            this.lblMoves.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblMoves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoves.Location = new System.Drawing.Point(148, 27);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(66, 22);
            this.lblMoves.TabIndex = 33;
            this.lblMoves.Text = "Score:";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shortLabels5
            // 
            this.shortLabels5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shortLabels5.AutoSize = true;
            this.shortLabels5.BackColor = System.Drawing.Color.Transparent;
            this.shortLabels5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.shortLabels5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shortLabels5.Location = new System.Drawing.Point(6, 27);
            this.shortLabels5.Name = "shortLabels5";
            this.shortLabels5.Size = new System.Drawing.Size(91, 22);
            this.shortLabels5.TabIndex = 28;
            this.shortLabels5.Text = "Seconds:";
            this.shortLabels5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWrong
            // 
            this.LabelWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelWrong.AutoSize = true;
            this.LabelWrong.BackColor = System.Drawing.Color.Transparent;
            this.LabelWrong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWrong.ForeColor = System.Drawing.Color.Black;
            this.LabelWrong.Location = new System.Drawing.Point(281, 35);
            this.LabelWrong.Name = "LabelWrong";
            this.LabelWrong.Size = new System.Drawing.Size(21, 22);
            this.LabelWrong.TabIndex = 29;
            this.LabelWrong.Text = "0";
            this.LabelWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRight
            // 
            this.LabelRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelRight.AutoSize = true;
            this.LabelRight.BackColor = System.Drawing.Color.Transparent;
            this.LabelRight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRight.ForeColor = System.Drawing.Color.Black;
            this.LabelRight.Location = new System.Drawing.Point(280, 14);
            this.LabelRight.Name = "LabelRight";
            this.LabelRight.Size = new System.Drawing.Size(21, 22);
            this.LabelRight.TabIndex = 28;
            this.LabelRight.Text = "0";
            this.LabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Countdown
            // 
            this.Countdown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Countdown.AutoSize = true;
            this.Countdown.BackColor = System.Drawing.Color.Transparent;
            this.Countdown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Countdown.Location = new System.Drawing.Point(101, 28);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(21, 22);
            this.Countdown.TabIndex = 26;
            this.Countdown.Text = "0";
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Controls.Add(this.lblBestScore);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.howToLabel);
            this.panel4.Controls.Add(this.btnHowTo);
            this.panel4.Controls.Add(this.btnBestScore);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 906);
            this.panel4.TabIndex = 59;
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
            this.lblBestScore.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "Arrow Game";
            // 
            // howToLabel
            // 
            this.howToLabel.AutoSize = true;
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.howToLabel.Location = new System.Drawing.Point(3, 284);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(298, 189);
            this.howToLabel.TabIndex = 53;
            this.howToLabel.Text = "Press the arrow on \r\nthe keyboard pointing in \r\nthe same direction \r\nas the arrow" +
    " on the screen\r\n\r\n\r\nGame Time: 60 seconds";
            // 
            // btnHowTo
            // 
            this.btnHowTo.BackColor = System.Drawing.Color.Orange;
            this.btnHowTo.Enabled = false;
            this.btnHowTo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowTo.ForeColor = System.Drawing.Color.Black;
            this.btnHowTo.Location = new System.Drawing.Point(-1, 219);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(334, 63);
            this.btnHowTo.TabIndex = 55;
            this.btnHowTo.Text = "How to play ????";
            this.btnHowTo.UseVisualStyleBackColor = false;
            // 
            // btnBestScore
            // 
            this.btnBestScore.BackColor = System.Drawing.Color.Orange;
            this.btnBestScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestScore.ForeColor = System.Drawing.Color.Black;
            this.btnBestScore.Location = new System.Drawing.Point(-1, 552);
            this.btnBestScore.Name = "btnBestScore";
            this.btnBestScore.Size = new System.Drawing.Size(334, 63);
            this.btnBestScore.TabIndex = 60;
            this.btnBestScore.Text = "Best Score";
            this.btnBestScore.UseVisualStyleBackColor = false;
            this.btnBestScore.Click += new System.EventHandler(this.btnBestScore_Click);
            this.btnBestScore.MouseEnter += new System.EventHandler(this.btnBestScore_MouseEnter);
            this.btnBestScore.MouseLeave += new System.EventHandler(this.btnBestScore_MouseLeave);
            this.btnBestScore.MouseHover += new System.EventHandler(this.btnBestScore_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cognitive_Stimulation.Properties.Resources.SPEEDOFPROCESS;
            this.pictureBox1.Location = new System.Drawing.Point(82, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnArrowStart
            // 
            this.btnArrowStart.BackColor = System.Drawing.Color.Orange;
            this.btnArrowStart.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowStart.ForeColor = System.Drawing.Color.Black;
            this.btnArrowStart.Location = new System.Drawing.Point(735, 725);
            this.btnArrowStart.Name = "btnArrowStart";
            this.btnArrowStart.Size = new System.Drawing.Size(285, 63);
            this.btnArrowStart.TabIndex = 3;
            this.btnArrowStart.Text = "Start";
            this.btnArrowStart.UseVisualStyleBackColor = false;
            this.btnArrowStart.Click += new System.EventHandler(this.btnArrowStart_Click);
            // 
            // pictureboxGame1
            // 
            this.pictureboxGame1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureboxGame1.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxGame1.Image = global::Cognitive_Stimulation.Properties.Resources._31;
            this.pictureboxGame1.Location = new System.Drawing.Point(719, 266);
            this.pictureboxGame1.Name = "pictureboxGame1";
            this.pictureboxGame1.Size = new System.Drawing.Size(326, 328);
            this.pictureboxGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxGame1.TabIndex = 38;
            this.pictureboxGame1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.bigLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 60);
            this.panel2.TabIndex = 4;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(382, -1);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(235, 30);
            this.bigLabel2.TabIndex = 8;
            this.bigLabel2.Text = "Speed of Processing";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.btnExitArrowGame);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 50);
            this.panel3.TabIndex = 9;
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
            this.btnExitArrowGame.Click += new System.EventHandler(this.btnExitArrowGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognitive Stimulation - SPEED OF PROCESSING";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMessage.Location = new System.Drawing.Point(25, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 21);
            this.lblMessage.TabIndex = 28;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArrowsGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 950);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrowsGame_Form";
            this.Text = "Arrows Game";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGame1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitArrowGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel1;
        private System.Windows.Forms.Panel panel1;  
        private System.Windows.Forms.Timer timer1; 
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel2; 
        private System.Windows.Forms.Label bigLabel2; 
        private System.Windows.Forms.PictureBox pictureboxGame1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnExitArrowGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHowTo;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Button btnArrowStart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label shortLabels5;
        private System.Windows.Forms.Label LabelWrong;
        private System.Windows.Forms.Label LabelRight;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Button btnBestScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Button btnBack;
    }
}

