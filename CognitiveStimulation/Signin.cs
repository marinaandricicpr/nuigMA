using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cognitive_Stimulation
{
    public partial class Signin_Form : Form
    { 
        public Signin_Form()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            DataTable dt = Procedure.GetUsers();

            cbUsers.DataSource = dt;
            cbUsers.DisplayMember = "Name";
            cbUsers.ValueMember = "ID";


            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);

            DisplayDataUSer(1);
        }
        private void DisplayDataUSer(int UserID)
        {
            Session.UserID = UserID;

            groupBoxUserGameDetails.Visible = false;

            DataSet ds = Procedure.GetUserDetails(UserID);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.HeaderText = "Details";
            editButton.Name = "Details";

            editButton.UseColumnTextForButtonValue = true;
            editButton.Text = "Details";

            editButton.Width = 60;
            if (!dataGridView1.Columns.Contains(editButton.Name = "Details"))
                dataGridView1.Columns.Add(editButton);
        }
        private void DisplayDataUSerGame(int UserID)
        {  
                groupBoxUserGameDetails.Visible = true;
                DataSet ds = Procedure.GetUserGameDetails(UserID); 

                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.AllowUserToAddRows = false; 
        }
        
        //int 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            { 
                string age = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gender = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Session.UserID > 0)
                {
                    DisplayDataUSerGame(Session.UserID);
                }
            }
        }
        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ComboBox comboBox = (ComboBox)sender;
            int selectedUser =(int)  comboBox.SelectedValue;
            
            DisplayDataUSer(selectedUser);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //howToLabel.Visible = true;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
    }
}
