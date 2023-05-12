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
using System.Configuration;

namespace Assignment3
{
    public partial class InsertData : Form
    {

        private string dbConnectionString;

        public InsertData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mainform = new Mainform();
            mainform.Show();
        }

        private void InsertData_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["Assignment3.Properties.Settings.CardConnectionString"].ConnectionString;


            cmbTeam.Items.Add("India");
            cmbTeam.Items.Add("Pakistan");
            cmbTeam.Items.Add("New Zealand");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //InsertTheData();
            if (txtboxPlayerName.Text != "" && cmbTeam.Text != "" && txtboxRun.Text != "" && txtboxAvg.Text != ""
                            && txtboxStrikeRate.Text != "" && txtboxWickets.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(dbConnectionString))
                {
                    connection.Open();

                    string queryString = "INSERT INTO newCard ([PlayerName],[Team],[Runs],[Avg],[StrickRate],[Wickets]) VALUES ('" + txtboxPlayerName.Text + "','" + cmbTeam.Text + "','" + txtboxRun.Text + "'," + "'" + txtboxAvg.Text + "','" + txtboxStrikeRate.Text + "','" + txtboxWickets.Text + "')";
                    
                        SqlCommand command = new SqlCommand(queryString, connection);

                        command = new SqlCommand(queryString, connection);                        
                        command.ExecuteNonQuery();
                        
                        connection.Close();

                        MessageBox.Show("Insert successfully!!!!!");


                    if (MessageBox.Show("Insert successfully!!!!!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        txtboxPlayerName.Clear();
                        txtboxRun.Clear();
                        txtboxAvg.Clear();
                        txtboxWickets.Clear();
                        txtboxStrikeRate.Clear();

                        this.Hide();
                        Mainform mainform = new Mainform();
                        mainform.Show();
                    }

                }
            }
            else
            {
                MessageBox.Show(" Attention!! Please fill all textboxes ");
            }
        }


        private void InsertTheData()
        {
            if (txtboxPlayerName.Text != "" && cmbTeam.Text != "" && txtboxRun.Text != "" && txtboxAvg.Text != ""
                            && txtboxStrikeRate.Text != "" && txtboxWickets.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(dbConnectionString))
                {
                    connection.Open();


                    string queryString = "INSERT INTO dbo.newCard ([PlayerName],[Team],[Runs],[Avg],[StrickRate],[Wickets]) VALUES ('" + txtboxPlayerName.Text + "','" + cmbTeam.Text + "','" + txtboxRun.Text + "'," + "'" + txtboxAvg.Text + "','" + txtboxStrikeRate.Text + "','" + txtboxWickets.Text + "')";

                    SqlCommand command = new SqlCommand(queryString, connection);

                    command = new SqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                    //connection.Close();

                    //MessageBox.Show("Insert successfully!!!!!");


                    //if (MessageBox.Show("Insert successfully!!!!!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                    //{
                    //    txtboxPlayerName.Clear();
                    //    txtboxRun.Clear();
                    //    txtboxAvg.Clear();
                    //    txtboxWickets.Clear();
                    //    txtboxStrikeRate.Clear();

                    //    this.Hide();
                    //    Mainform mainform = new Mainform();
                    //    mainform.Show();
                    //}

                }
            }
            else
            {
                MessageBox.Show(" Attention!! Please fill all textboxes ");
            }
        }
       
    }
}
