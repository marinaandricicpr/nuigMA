namespace Cognitive_Stimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.btnExitGame = new Cognitive_Stimulation.ImgButton();
            this.bigLabel1 = new System.Windows.Forms.Label();
            this.gbMemory = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMemory = new System.Windows.Forms.Button();
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPuzzleSlide = new System.Windows.Forms.Button();
            this.btnSimmon = new System.Windows.Forms.Button();
            this.btnArrows = new System.Windows.Forms.Button();
            this.btnVocabulary = new System.Windows.Forms.Button();
            this.btnPuzzle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReasoningBox = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SpeedBox = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.gbMemory.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReasoningBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SpeedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnExitGame);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Image = global::Cognitive_Stimulation.Properties.Resources.userlogin;
            this.btnLogin.Location = new System.Drawing.Point(1420, 11);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(30, 30);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogin.TabIndex = 55;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExitGame.BackColor = System.Drawing.Color.Transparent;
            this.btnExitGame.FlatAppearance.BorderSize = 0;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.ForeColor = System.Drawing.Color.White;
            this.btnExitGame.Location = new System.Drawing.Point(1470, 11);
            this.btnExitGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(28, 28);
            this.btnExitGame.TabIndex = 5;
            this.btnExitGame.Text = "X";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(618, 10);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(264, 30);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "Cognitive Stimulation";
            // 
            // gbMemory
            // 
            this.gbMemory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbMemory.Controls.Add(this.label4);
            this.gbMemory.Controls.Add(this.label2);
            this.gbMemory.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.gbMemory.Location = new System.Drawing.Point(1, 221);
            this.gbMemory.Name = "gbMemory";
            this.gbMemory.Size = new System.Drawing.Size(500, 298);
            this.gbMemory.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(148, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "MEMORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 124);
            this.label2.TabIndex = 51;
            this.label2.Text = "Memory refers to how efficiently \r\nyou remember and recall \r\nobjects, pictures, p" +
    "atterns, formulas \r\nand other visual information. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMemory.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.ForeColor = System.Drawing.Color.Black;
            this.btnMemory.Location = new System.Drawing.Point(9, 18);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(239, 63);
            this.btnMemory.TabIndex = 3;
            this.btnMemory.Text = "Matching Game";
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.ReasoningBox);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.SpeedBox);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1500, 950);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnPuzzleSlide);
            this.panel3.Controls.Add(this.btnSimmon);
            this.panel3.Controls.Add(this.btnMemory);
            this.panel3.Controls.Add(this.btnArrows);
            this.panel3.Controls.Add(this.btnVocabulary);
            this.panel3.Controls.Add(this.btnPuzzle);
            this.panel3.Location = new System.Drawing.Point(0, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 100);
            this.panel3.TabIndex = 54;
            // 
            // btnPuzzleSlide
            // 
            this.btnPuzzleSlide.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPuzzleSlide.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuzzleSlide.ForeColor = System.Drawing.Color.Black;
            this.btnPuzzleSlide.Location = new System.Drawing.Point(753, 18);
            this.btnPuzzleSlide.Name = "btnPuzzleSlide";
            this.btnPuzzleSlide.Size = new System.Drawing.Size(239, 63);
            this.btnPuzzleSlide.TabIndex = 6;
            this.btnPuzzleSlide.Text = "Sudoku Game";
            this.btnPuzzleSlide.UseVisualStyleBackColor = false;
            this.btnPuzzleSlide.Click += new System.EventHandler(this.btnPuzzleSlide_Click);
            // 
            // btnSimmon
            // 
            this.btnSimmon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSimmon.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimmon.ForeColor = System.Drawing.Color.Black;
            this.btnSimmon.Location = new System.Drawing.Point(254, 18);
            this.btnSimmon.Name = "btnSimmon";
            this.btnSimmon.Size = new System.Drawing.Size(239, 63);
            this.btnSimmon.TabIndex = 5;
            this.btnSimmon.Text = "Simon Game";
            this.btnSimmon.UseVisualStyleBackColor = false;
            this.btnSimmon.Click += new System.EventHandler(this.btnSimmon_Click);
            // 
            // btnArrows
            // 
            this.btnArrows.BackColor = System.Drawing.Color.Orange;
            this.btnArrows.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrows.ForeColor = System.Drawing.Color.Black;
            this.btnArrows.Location = new System.Drawing.Point(1005, 19);
            this.btnArrows.Name = "btnArrows";
            this.btnArrows.Size = new System.Drawing.Size(239, 63);
            this.btnArrows.TabIndex = 4;
            this.btnArrows.Text = "Arrow Game";
            this.btnArrows.UseVisualStyleBackColor = false;
            this.btnArrows.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnVocabulary
            // 
            this.btnVocabulary.BackColor = System.Drawing.Color.Orange;
            this.btnVocabulary.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVocabulary.ForeColor = System.Drawing.Color.Black;
            this.btnVocabulary.Location = new System.Drawing.Point(1254, 19);
            this.btnVocabulary.Name = "btnVocabulary";
            this.btnVocabulary.Size = new System.Drawing.Size(239, 63);
            this.btnVocabulary.TabIndex = 2;
            this.btnVocabulary.Text = "Vocabulary Game";
            this.btnVocabulary.UseVisualStyleBackColor = false;
            this.btnVocabulary.Click += new System.EventHandler(this.btnVocabulary_Click);
            // 
            // btnPuzzle
            // 
            this.btnPuzzle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPuzzle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuzzle.ForeColor = System.Drawing.Color.Black;
            this.btnPuzzle.Location = new System.Drawing.Point(507, 18);
            this.btnPuzzle.Name = "btnPuzzle";
            this.btnPuzzle.Size = new System.Drawing.Size(239, 63);
            this.btnPuzzle.TabIndex = 3;
            this.btnPuzzle.Text = "Puzzle";
            this.btnPuzzle.UseVisualStyleBackColor = false;
            this.btnPuzzle.Click += new System.EventHandler(this.btnPuzzle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.gbMemory);
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 539);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cognitive_Stimulation.Properties.Resources.MEMORY;
            this.pictureBox1.Location = new System.Drawing.Point(158, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // ReasoningBox
            // 
            this.ReasoningBox.Controls.Add(this.pictureBox2);
            this.ReasoningBox.Controls.Add(this.groupBox1);
            this.ReasoningBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.ReasoningBox.ForeColor = System.Drawing.Color.White;
            this.ReasoningBox.Location = new System.Drawing.Point(498, 406);
            this.ReasoningBox.Name = "ReasoningBox";
            this.ReasoningBox.Size = new System.Drawing.Size(500, 539);
            this.ReasoningBox.TabIndex = 3;
            this.ReasoningBox.Text = "Reasoning";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cognitive_Stimulation.Properties.Resources.REASONING;
            this.pictureBox2.Location = new System.Drawing.Point(163, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.groupBox1.Location = new System.Drawing.Point(0, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 298);
            this.groupBox1.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(127, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 37);
            this.label5.TabIndex = 52;
            this.label5.Text = "REASONING";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(72, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 62);
            this.label6.TabIndex = 51;
            this.label6.Text = "Reasoning is the ability to visualize \r\nhow objects relate in space. ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpeedBox
            // 
            this.SpeedBox.BackColor = System.Drawing.Color.Transparent;
            this.SpeedBox.Controls.Add(this.pictureBox3);
            this.SpeedBox.Controls.Add(this.groupBox2);
            this.SpeedBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.SpeedBox.ForeColor = System.Drawing.Color.White;
            this.SpeedBox.Location = new System.Drawing.Point(998, 408);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(500, 539);
            this.SpeedBox.TabIndex = 3;
            this.SpeedBox.Text = "Speed of Processing";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cognitive_Stimulation.Properties.Resources.SPEEDOFPROCESS;
            this.pictureBox3.Location = new System.Drawing.Point(172, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.groupBox2.Location = new System.Drawing.Point(0, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 298);
            this.groupBox2.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 37);
            this.label1.TabIndex = 52;
            this.label1.Text = "SPEED OF PROCESSING";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(85, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 62);
            this.label7.TabIndex = 51;
            this.label7.Text = "Visual motor speed is how efficiently \r\nyour eyes and hands work together.\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Cognitive_Stimulation.Properties.Resources.aa2a3267882791aeb99b66b68a832dc2;
            this.pictureBox4.Location = new System.Drawing.Point(361, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(790, 342);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.gbMemory.ResumeLayout(false);
            this.gbMemory.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReasoningBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SpeedBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
         
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bigLabel1;
        private ImgButton btnExitGame;
        private System.Windows.Forms.Panel ReasoningBox;
        private System.Windows.Forms.Button btnVocabulary;
        private System.Windows.Forms.Panel SpeedBox;
        private System.Windows.Forms.Button btnSimmon;
        private System.Windows.Forms.Button btnArrows;
        private System.Windows.Forms.Panel gbMemory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Panel gradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Button btnPuzzleSlide;
        private System.Windows.Forms.Button btnPuzzle;
    }
}

