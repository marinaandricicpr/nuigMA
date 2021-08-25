namespace Cognitive_Stimulation
{
    partial class MemoryGame_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGame_Form));
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bigLabel1 = new System.Windows.Forms.Label();
            this.levelPanel = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.howToLabel = new System.Windows.Forms.Label();
            this.btnhowTo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBestScore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblMovesValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMemoryStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.levelPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.levelPanel);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Location = new System.Drawing.Point(0, -4);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1500, 950);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 50);
            this.panel1.TabIndex = 1;
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
            this.pictureBox2.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(618, 10);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(411, 30);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "Cognitive Stimulation - MEMORY";
            // 
            // levelPanel
            // 
            this.levelPanel.BackColor = System.Drawing.Color.White;
            this.levelPanel.Controls.Add(this.btnLeft);
            this.levelPanel.Controls.Add(this.btnRight);
            this.levelPanel.Controls.Add(this.lblLevel);
            this.levelPanel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.levelPanel.ForeColor = System.Drawing.Color.White;
            this.levelPanel.Location = new System.Drawing.Point(872, 51);
            this.levelPanel.Name = "levelPanel";
            this.levelPanel.Size = new System.Drawing.Size(218, 60);
            this.levelPanel.TabIndex = 56;
            this.levelPanel.Text = "Memory";
            this.levelPanel.Visible = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLeft.Font = new System.Drawing.Font("Arial Black", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.Black;
            this.btnLeft.Location = new System.Drawing.Point(14, -1);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 51);
            this.btnLeft.TabIndex = 57;
            this.btnLeft.Text = "-";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRight.Font = new System.Drawing.Font("Arial Black", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.Black;
            this.btnRight.Location = new System.Drawing.Point(77, -1);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(57, 51);
            this.btnRight.TabIndex = 56;
            this.btnRight.Text = "+";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLevel.Location = new System.Drawing.Point(135, 15);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(67, 24);
            this.lblLevel.TabIndex = 36;
            this.lblLevel.Text = "Level:";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.lblBestScore);
            this.panel2.Controls.Add(this.howToLabel);
            this.panel2.Controls.Add(this.btnhowTo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnBestScore);
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 906);
            this.panel2.TabIndex = 55;
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
            this.lblBestScore.TabIndex = 57;
            // 
            // howToLabel
            // 
            this.howToLabel.AutoSize = true;
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.howToLabel.Location = new System.Drawing.Point(2, 284);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(336, 270);
            this.howToLabel.TabIndex = 53;
            this.howToLabel.Text = resources.GetString("howToLabel.Text");
            // 
            // btnhowTo
            // 
            this.btnhowTo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnhowTo.Enabled = false;
            this.btnhowTo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhowTo.ForeColor = System.Drawing.Color.Black;
            this.btnhowTo.Location = new System.Drawing.Point(-1, 219);
            this.btnhowTo.Name = "btnhowTo";
            this.btnhowTo.Size = new System.Drawing.Size(335, 63);
            this.btnhowTo.TabIndex = 55;
            this.btnhowTo.Text = "How to play ????";
            this.btnhowTo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "Matching Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cognitive_Stimulation.Properties.Resources.MEMORY;
            this.pictureBox1.Location = new System.Drawing.Point(67, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnBestScore
            // 
            this.btnBestScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBestScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestScore.ForeColor = System.Drawing.Color.Black;
            this.btnBestScore.Location = new System.Drawing.Point(-1, 552);
            this.btnBestScore.Name = "btnBestScore";
            this.btnBestScore.Size = new System.Drawing.Size(334, 63);
            this.btnBestScore.TabIndex = 56;
            this.btnBestScore.Text = "Best Score";
            this.btnBestScore.UseVisualStyleBackColor = false;
            this.btnBestScore.Click += new System.EventHandler(this.btnBestScore_Click);
            this.btnBestScore.MouseEnter += new System.EventHandler(this.btnBestScore_MouseEnter);
            this.btnBestScore.MouseLeave += new System.EventHandler(this.btnBestScore_MouseLeave);
            this.btnBestScore.MouseHover += new System.EventHandler(this.btnBestScore_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblMoves);
            this.groupBox1.Controls.Add(this.lblMovesValue);
            this.groupBox1.Controls.Add(this.lblTimeValue);
            this.groupBox1.Location = new System.Drawing.Point(1215, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 69);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(6, 27);
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
            this.lblMoves.Location = new System.Drawing.Point(135, 29);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(71, 22);
            this.lblMoves.TabIndex = 30;
            this.lblMoves.Text = "Moves:";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovesValue
            // 
            this.lblMovesValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMovesValue.AutoSize = true;
            this.lblMovesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMovesValue.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblMovesValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovesValue.Location = new System.Drawing.Point(220, 29);
            this.lblMovesValue.Name = "lblMovesValue";
            this.lblMovesValue.Size = new System.Drawing.Size(21, 22);
            this.lblMovesValue.TabIndex = 31;
            this.lblMovesValue.Text = "0";
            this.lblMovesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeValue.Location = new System.Drawing.Point(69, 29);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(22, 24);
            this.lblTimeValue.TabIndex = 29;
            this.lblTimeValue.Text = "0";
            this.lblTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnMemoryStart);
            this.panel3.Location = new System.Drawing.Point(532, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 699);
            this.panel3.TabIndex = 58;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(158, 633);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 63);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnMemoryStart
            // 
            this.btnMemoryStart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMemoryStart.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryStart.ForeColor = System.Drawing.Color.Black;
            this.btnMemoryStart.Location = new System.Drawing.Point(158, 516);
            this.btnMemoryStart.Name = "btnMemoryStart";
            this.btnMemoryStart.Size = new System.Drawing.Size(285, 63);
            this.btnMemoryStart.TabIndex = 3;
            this.btnMemoryStart.Text = "Start";
            this.btnMemoryStart.UseVisualStyleBackColor = false;
            this.btnMemoryStart.Click += new System.EventHandler(this.btnMemoryStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empty.png");
            this.imageList1.Images.SetKeyName(1, "card1.png");
            this.imageList1.Images.SetKeyName(2, "card2.png");
            this.imageList1.Images.SetKeyName(3, "card3.png");
            this.imageList1.Images.SetKeyName(4, "card4.png");
            this.imageList1.Images.SetKeyName(5, "card5.png");
            this.imageList1.Images.SetKeyName(6, "card6.png");
            this.imageList1.Images.SetKeyName(7, "card7.png");
            this.imageList1.Images.SetKeyName(8, "card8.png");
            this.imageList1.Images.SetKeyName(9, "card9.png");
            this.imageList1.Images.SetKeyName(10, "card10.png");
            this.imageList1.Images.SetKeyName(11, "card11.png");
            this.imageList1.Images.SetKeyName(12, "card12.png");
            this.imageList1.Images.SetKeyName(13, "card13.png");
            this.imageList1.Images.SetKeyName(14, "card14.png");
            this.imageList1.Images.SetKeyName(15, "card15.png");
            this.imageList1.Images.SetKeyName(16, "card16.png");
            // 
            // MemoryGame_Form
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
            this.Name = "MemoryGame_Form";
            this.Text = "Memory Game";
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.levelPanel.ResumeLayout(false);
            this.levelPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bigLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblMovesValue;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnMemoryStart;
        private System.Windows.Forms.Button btnhowTo;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Panel levelPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBestScore;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
    }
}

