using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment3
{
    public partial class Mainform : Form
    {
        private string dbConnectionString;
        private List<CardData> Mycard = new List<CardData>();


        public Mainform()
        {
            InitializeComponent();
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            this.Hide();
           InsertData insertData = new InsertData();
            insertData.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["Assignment3.Properties.Settings.CardConnectionString"].ConnectionString;
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {
            GetInformation();
        }

        private void GetInformation()
        {
            using (SqlConnection myconnection = new SqlConnection(dbConnectionString))
            using (
                
                SqlDataAdapter clientAdapter = new SqlDataAdapter("select * from newCard", myconnection))
            {
                DataTable clientData = new DataTable();
                myconnection.Open();
                clientAdapter.Fill(clientData);
                myconnection.Close();



                clientData = clientData.DefaultView.ToTable();

                //pull all data into the belone new variables
                for (int row = 0; row < clientData.Rows.Count; row++)
                {
                    int id = (int)clientData.Rows[row]["Id"];
                    string PlayerName = clientData.Rows[row]["PlayerName"].ToString();
                    string Team = clientData.Rows[row]["Team"].ToString();
                    int Runs = (int)clientData.Rows[row]["Runs"];
                    string Avg = clientData.Rows[row]["Avg"].ToString() ;
                    int Wickets = (int)clientData.Rows[row]["Wickets"];
                    int StrickRate = (int)clientData.Rows[row]["StrickRate"];



                    CardData cardData = new CardData()
                    {
                        id = id,
                        PlayerName = PlayerName,
                        Team = Team,
                        Runs = Runs,
                        Avg = Avg,
                        Wickets = Wickets,
                        StrickRate = StrickRate
                    };

                    Mycard.Add(cardData);
                    ListViewItem myItem = new ListViewItem(id.ToString());
                    myItem.SubItems.Add(PlayerName);
                    myItem.SubItems.Add(Team);
                    //if (Convert.ToDouble(listingPrice) / Convert.ToDouble(SquareFootage) <= 2000)
                    //{
                    //    myItem.ForeColor = Color.DarkRed;
                    //}

                    mySmallListView.Items.Add(myItem);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mySmallListView_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < mySmallListView.Items.Count; i++)
            {
                if (mySmallListView.Items[i].Selected == true)
                {
                    string id = mySmallListView.Items[i].Text;

                    FillTheFullData(Int32.Parse(id));
                    break;
                }
            }
        }

        private void FillTheFullData(int id)
        {
            foreach (var x in Mycard)
            {
                if (x.id == id)
                {
                    //ListViewItem myItem = new ListViewItem(x.id.ToString());
                    //myItem.SubItems.Add(x.PlayerName);
                    //myItem.SubItems.Add(x.Team);
                    //myItem.SubItems.Add(x.Runs.ToString());
                    //myItem.SubItems.Add(x.Avg);
                    //myItem.SubItems.Add(x.Wickets.ToString());
                    //myItem.SubItems.Add(x.StrickRate.ToString());

                    txtboxShow.Visible = true;
                    

                


                    txtboxShow.Text = "Player Name: " + x.PlayerName+ "\r\n" + "Team: " + x.Team + "\r\n" + "Runs " + x.Runs + "\r\n" + "Avg: " + x.Avg + "\r\n" + "Wickets: " + x.Wickets + "\r\n" + "StrickRate: " + x.StrickRate;


                   

                    pictureBox.Visible = true;
                    pictureBox.ImageLocation = "C:\\Rapid Development\\Assignment3\\Assignment3\\Resources\\" + x.id.ToString() + ".jpg";

                    //DBListBox.Items.Add(myItem);
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
