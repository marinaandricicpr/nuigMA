 using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms;
using System.Linq; 

namespace Cognitive_Stimulation
{    
    public partial class Sudoku_Form : Form
    {

        CommonFunctions common = new CommonFunctions(1);
        SudokuCell[,] cells = new SudokuCell[4, 4]; 

        int usedtime = 0;
        public Sudoku_Form()
        {
            InitializeComponent();

            createCells();
            
            common.GameLevel = 1;

            lblLevel.Text = "Level: " + (common.GameLevelText(common.GameLevel));
            panel3.Visible = common.GameStarted;
            btnStart.Visible = true;
            levelPanel.Visible = common.GameStarted;

            this.ResetTimer(false);

        }
        private void createCells()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(120, 120);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 120, j * 120);
                    cells[i, j].BackColor = ((i / 2) + (j / 2)) % 2 == 0 ? Color.YellowGreen : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Assign key press event for each cells
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel3.Controls.Add(cells[i, j]);
                }
            }
        } 
        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
           
            var cell = sender as SudokuCell;
             
            if (cell.IsLocked)
                return;

            int value;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
            
        }

        private void startNewGame()
        { 
            createCells(); 
            this.StartGame(); 
        }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            int min, sec;

            usedtime++;

            min = usedtime / 600;
            sec = (usedtime - min * 600) / 10; 
            lblTime.Text = min + ":" + sec.ToString("00");

        }  
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            if (common.GameStarted)
                common.EndGame(null,null, null, null, null, System.Drawing.Color.Orange);
            this.Close();
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
         
        private void checkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();
            var emptyCells = new List<SudokuCell>();

            // Find all the wrong inputs
            foreach (var cell in cells)
            {
                if (cell.Text != "")
                {
                    if (!string.Equals(cell.Value.ToString(), cell.Text))
                    {
                        wrongCells.Add(cell);
                    }
                }
                else
                {
                    emptyCells.Add(cell);
                }
            }

            // Check if the inputs are wrong or the player wins 
            if (wrongCells.Any())
            {
                // Highlight the wrong inputs 
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Incorect input(s)");
            }
            else if (emptyCells.Any())
            { 
                MessageBox.Show("Empty  input(s)");
            }
            else
            {
                timer1.Enabled = false;
                common.GameComplete = true; 
                common.EndGame(btnStart, btnBack, "Sudoku", "Time: " + lblTime.Text, "", System.Drawing.Color.YellowGreen);
            }
        } 

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.StartGame();

            common.StartGame(btnStart, btnBack);
            
            panel3.Visible = common.GameStarted;

            levelPanel.Visible = common.GameStarted;
        }

        private void StartGame()
        {
            loadValues();

            var hintsCount = 0;
             
            if (common.GameLevel==1)
                hintsCount = 45;
            else if (common.GameLevel == 2)
                hintsCount = 30;
            else if (common.GameLevel == 3)
                hintsCount = 15;

            showRandomValuesHints(hintsCount);
            ResetTimer(true);
        }
        private void ResetTimer(bool timerEnabled)
        {
            lblTime.Text = "0:00";
            usedtime = 0;
            timer1.Enabled = timerEnabled;
        }
        private void showRandomValuesHints(int hintsCount)
        {
            // Show value in radom cells
            // The hints count is based on the level player choose
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(4);
                var rY = random.Next(4);

                // Style the hint cells differently and
                // lock the cell so that player can't edit the value
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }

        private void loadValues()
        {
            // Clear the values in each cells
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            // This method will be called recursively 
            // until it finds suitable values for each cells
            findValueForNextCell(0, -1);
        }

        Random random = new Random();

        private bool findValueForNextCell(int i, int j)
        {
            // Increment the i and j values to move to the next cell
            // and if the columsn ends move to the next row
            if (++j > 3)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 3)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4 };

            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number
            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Take a random number from the numbers left in the list
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value; 
                // Remove the allocated value from the list
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 4; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 2); i < x - (x % 2) + 2; i++)
            {
                for (int j = y - (y % 2); j < y - (y % 2) + 2; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnRight.Enabled = true;
            common.GameLevel--;
            if (common.GameLevel < 2)
                btnLeft.Enabled = false;

            this.StartGame();
            lblLevel.Text = "Level: " + (common.GameLevelText(common.GameLevel));
            common.ReStartGame();
            ResetTimer(true);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            btnLeft.Enabled = true;
            common.GameLevel++;
            if (common.GameLevel > 2)
                btnRight.Enabled = false;

            this.StartGame();

            lblLevel.Text = "Level: " + (common.GameLevelText(common.GameLevel));
            common.ReStartGame();
            ResetTimer(true);
        }
    }
}
