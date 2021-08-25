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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }  
        public static void Show(Color color, string Title,string Time, string Score)
        {
            CustomMessageBox mb = new CustomMessageBox();

            mb.Text = Title;
            mb.BackColor = Color.White;
            mb.CenterToScreen();
            mb.btnClose.BackColor = color;
            if (Score == "")
            {
                mb.lblScore.Visible = false;
                mb.pictureBox3.Visible = false;
            }
            mb.lblScore.Text= Score;

            if (Time == "")
            {
                mb.lblTime.Visible = false;
                mb.pictureBox2.Visible = false;
            }
            
            mb.lblTime.Text = Time;
            mb.ShowDialog(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); 
        } 
    }
}
