namespace Cognitive_Stimulation
{
    partial class Words_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Words_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBestScore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.howToLabel = new System.Windows.Forms.Label();
            this.LabelV1 = new System.Windows.Forms.Label();
            this.btnStartVocabulary = new System.Windows.Forms.Button();
            this.LabelV2 = new System.Windows.Forms.Label();
            this.LabelV3 = new System.Windows.Forms.Label();
            this.LabelV4 = new System.Windows.Forms.Label();
            this.LabelQ = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.LabelWrong = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.LabelRight = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.btnBack);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.LabelV1);
            this.gradientPanel1.Controls.Add(this.btnStartVocabulary);
            this.gradientPanel1.Controls.Add(this.LabelV2);
            this.gradientPanel1.Controls.Add(this.LabelV3);
            this.gradientPanel1.Controls.Add(this.LabelV4);
            this.gradientPanel1.Controls.Add(this.LabelQ);
            this.gradientPanel1.Controls.Add(this.groupBox2);
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
            this.btnBack.Location = new System.Drawing.Point(769, 801);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 63);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 50);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(456, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(587, 30);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cognitive Stimulation - SPEED OF PROCESSING";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Image = global::Cognitive_Stimulation.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(1458, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(618, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognitive Stimulation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblBestScore);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnBestScore);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.howToLabel);
            this.panel2.Location = new System.Drawing.Point(1, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 906);
            this.panel2.TabIndex = 57;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "Vocabulary Game";
            // 
            // btnBestScore
            // 
            this.btnBestScore.BackColor = System.Drawing.Color.Orange;
            this.btnBestScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestScore.ForeColor = System.Drawing.Color.Black;
            this.btnBestScore.Location = new System.Drawing.Point(-1, 552);
            this.btnBestScore.Name = "btnBestScore";
            this.btnBestScore.Size = new System.Drawing.Size(336, 63);
            this.btnBestScore.TabIndex = 58;
            this.btnBestScore.Text = "Best Score";
            this.btnBestScore.UseVisualStyleBackColor = false;
            this.btnBestScore.Click += new System.EventHandler(this.btnBestScore_Click);
            this.btnBestScore.MouseEnter += new System.EventHandler(this.btnBestScore_MouseEnter);
            this.btnBestScore.MouseLeave += new System.EventHandler(this.btnBestScore_MouseLeave);
            this.btnBestScore.MouseHover += new System.EventHandler(this.btnBestScore_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-1, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 63);
            this.button1.TabIndex = 55;
            this.button1.Text = "How to play ????";
            this.button1.UseVisualStyleBackColor = false;
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
            // howToLabel
            // 
            this.howToLabel.AutoSize = true;
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.howToLabel.Location = new System.Drawing.Point(4, 257);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(324, 216);
            this.howToLabel.TabIndex = 53;
            this.howToLabel.Text = "\r\nFind the word that has          \r\nthe same letters as \r\nthe word in the middle " +
    "\r\nof the screen\r\n\r\nGame Time: 60 seconds\r\n\r\n";
            // 
            // LabelV1
            // 
            this.LabelV1.AutoSize = true;
            this.LabelV1.BackColor = System.Drawing.Color.Transparent;
            this.LabelV1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelV1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelV1.Location = new System.Drawing.Point(1206, 472);
            this.LabelV1.Name = "LabelV1";
            this.LabelV1.Size = new System.Drawing.Size(60, 32);
            this.LabelV1.TabIndex = 40;
            this.LabelV1.Text = "-----";
            this.LabelV1.Click += new System.EventHandler(this.LabelV_Click);
            // 
            // btnStartVocabulary
            // 
            this.btnStartVocabulary.BackColor = System.Drawing.Color.Orange;
            this.btnStartVocabulary.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartVocabulary.ForeColor = System.Drawing.Color.Black;
            this.btnStartVocabulary.Location = new System.Drawing.Point(769, 699);
            this.btnStartVocabulary.Name = "btnStartVocabulary";
            this.btnStartVocabulary.Size = new System.Drawing.Size(285, 63);
            this.btnStartVocabulary.TabIndex = 3;
            this.btnStartVocabulary.Text = "Start";
            this.btnStartVocabulary.UseVisualStyleBackColor = false;
            this.btnStartVocabulary.Click += new System.EventHandler(this.btnVocabulary_Click);
            // 
            // LabelV2
            // 
            this.LabelV2.AutoSize = true;
            this.LabelV2.BackColor = System.Drawing.Color.Transparent;
            this.LabelV2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelV2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelV2.Location = new System.Drawing.Point(542, 472);
            this.LabelV2.Name = "LabelV2";
            this.LabelV2.Size = new System.Drawing.Size(60, 32);
            this.LabelV2.TabIndex = 41;
            this.LabelV2.Text = "-----";
            this.LabelV2.Click += new System.EventHandler(this.LabelV_Click);
            // 
            // LabelV3
            // 
            this.LabelV3.AutoSize = true;
            this.LabelV3.BackColor = System.Drawing.Color.Transparent;
            this.LabelV3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelV3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelV3.Location = new System.Drawing.Point(999, 596);
            this.LabelV3.Name = "LabelV3";
            this.LabelV3.Size = new System.Drawing.Size(60, 32);
            this.LabelV3.TabIndex = 42;
            this.LabelV3.Text = "-----";
            this.LabelV3.Click += new System.EventHandler(this.LabelV_Click);
            // 
            // LabelV4
            // 
            this.LabelV4.AutoSize = true;
            this.LabelV4.BackColor = System.Drawing.Color.Transparent;
            this.LabelV4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelV4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelV4.Location = new System.Drawing.Point(746, 596);
            this.LabelV4.Name = "LabelV4";
            this.LabelV4.Size = new System.Drawing.Size(60, 32);
            this.LabelV4.TabIndex = 43;
            this.LabelV4.Text = "-----";
            this.LabelV4.Click += new System.EventHandler(this.LabelV_Click);
            // 
            // LabelQ
            // 
            this.LabelQ.AutoSize = true;
            this.LabelQ.BackColor = System.Drawing.Color.Transparent;
            this.LabelQ.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQ.ForeColor = System.Drawing.Color.Black;
            this.LabelQ.Location = new System.Drawing.Point(823, 308);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(137, 75);
            this.LabelQ.TabIndex = 44;
            this.LabelQ.Text = "-----";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.LabelWrong);
            this.groupBox2.Controls.Add(this.lblMoves);
            this.groupBox2.Controls.Add(this.LabelRight);
            this.groupBox2.Controls.Add(this.Countdown);
            this.groupBox2.Controls.Add(this.lblTimeValue);
            this.groupBox2.Location = new System.Drawing.Point(1194, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 72);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(212, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Correct: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(-1, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 22);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Seconds:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWrong
            // 
            this.LabelWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelWrong.AutoSize = true;
            this.LabelWrong.BackColor = System.Drawing.Color.Transparent;
            this.LabelWrong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWrong.ForeColor = System.Drawing.Color.Black;
            this.LabelWrong.Location = new System.Drawing.Point(276, 38);
            this.LabelWrong.Name = "LabelWrong";
            this.LabelWrong.Size = new System.Drawing.Size(21, 22);
            this.LabelWrong.TabIndex = 29;
            this.LabelWrong.Text = "0";
            this.LabelWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoves
            // 
            this.lblMoves.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoves.AutoSize = true;
            this.lblMoves.BackColor = System.Drawing.Color.Transparent;
            this.lblMoves.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblMoves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoves.Location = new System.Drawing.Point(140, 29);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(66, 22);
            this.lblMoves.TabIndex = 30;
            this.lblMoves.Text = "Score:";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRight
            // 
            this.LabelRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelRight.AutoSize = true;
            this.LabelRight.BackColor = System.Drawing.Color.Transparent;
            this.LabelRight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRight.ForeColor = System.Drawing.Color.Black;
            this.LabelRight.Location = new System.Drawing.Point(275, 13);
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
            this.Countdown.Location = new System.Drawing.Point(96, 29);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(21, 22);
            this.Countdown.TabIndex = 26;
            this.Countdown.Text = "0";
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTimeValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeValue.Location = new System.Drawing.Point(-7, 29);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(21, 22);
            this.lblTimeValue.TabIndex = 29;
            this.lblTimeValue.Text = "0";
            this.lblTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Words_Form
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
            this.Name = "Words_Form";
            this.Text = "Words";
            this.Load += new System.EventHandler(this.WordsForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelWrong;
        private System.Windows.Forms.Label LabelRight;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Label LabelV1;
        private System.Windows.Forms.Label LabelV2;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.Label LabelV4;
        private System.Windows.Forms.Label LabelV3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Button btnStartVocabulary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Button btnBestScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
    }
}

