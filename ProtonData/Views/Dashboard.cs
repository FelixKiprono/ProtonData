using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProtonData.Database.Mysqlapi;
using ProtonData.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplatePrinter.ExcelLib;

namespace ProtonData.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ///dialog for opening the folders in your computer
            OpenFileDialog open = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx;*.csv;" };
            ///do a check if the user has clicked ok
            if (open.ShowDialog() == DialogResult.OK)
            {
                ///use the falcon class to import file to the datagrid it accepts two args 

                if (Falcon.ImportFromExcel(open.FileName, exceldata))
                {
                    ///count all columns
                    lblcolumns.Text = "Columns ( " + exceldata.ColumnCount.ToString() + ") ";

                    MessageBox.Show("Completed Importing", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sorry system failed importing from excel,", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void exceldata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ///count all rows  as it adds new rows on this event
            lblrows.Text = "Rows ( " + exceldata.RowCount.ToString()+") ";
         }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            String sql = "";
            Action<String> finish = (n) =>
            {
                sql = n;
            };
           var cl = Tools.GetColumns(exceldata);
            var data = exceldata;
           
          ////input box for generating columns
            InputBox inp = new InputBox(finish, cl);
            inp.ShowDialog();

       

            StringBuilder Statement = new StringBuilder();
            ///check if there is data in datagrid using rows 
            String[] column = null;
            if (data.Rows.Count > 0)
            {
                ///count the length of columns
                column = new String[data.Columns.Count];
                try
                {

                    Statement.Append(sql);
                    int i = 0;
                    ///First loop through all the items in the header to generate the SQL

                    ///  Statement.Append("VALUES" + Environment.NewLine);
                    ///now loop through rows and generate SQL            
                    foreach (DataGridViewRow row in data.Rows)
                    {
                        ///build  your sql query here
                        Statement.Append("(");
                        foreach (DataGridViewColumn col in data.Columns)
                        {
                            ///getting the data from the rows using columns names as index

                            Statement.Append("'" + row.Cells[Tools.GetIndex(data, col)].Value.ToString().Trim().Replace("'", "") + "',");
                        }
                        ///
                        Statement.Remove(Statement.Length - 1, 1);
                        Statement.Append("),");
                        Statement.Append("");
                    }
                    Statement.Remove(Statement.Length - 1, 1);
                    ///terminate the statement
                    Statement.Append(";");
                }
                catch (Exception ERROR)
                {
                    ///incase of any error write to file
                    File.AppendAllText("Errorlog.error", "Date : " + DateTime.Now.ToShortTimeString() + " " + ERROR.Message + " #" + Environment.NewLine);
                }
            }
            
            sqleditor.Text = Statement.ToString();
        }

        private void sqleditor_TextChanged(object sender, EventArgs e)
        {
            ///count the text characters in the sqleditor textbox
            lbllines.Text = "Chars ( " + sqleditor.Text.Length.ToString() + " )";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ///write the SQL query to temp file in order to execute against db later
                File.WriteAllText(Application.ExecutablePath + "SQL_QUERY.sql", sqleditor.Text);
                MessageBox.Show("File save at " + Application.ExecutablePath + "SQL_QUERY.sql", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

            }
          }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ////clear textboxes
            sqleditor.Text = "";
            lbllines.Text = "Chars";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ////use our small class lib to connect to mysql server
                Database.Mysqlapi.DatabaseApi mydb = new Database.Mysqlapi.DatabaseApi();
                mydb.Connect();

                MySqlConnection con = mydb.con;
                ////check if connection is open meaning the database settings are correct
                if (con.State.Equals(ConnectionState.Open))
                {
                    MessageBox.Show("Connection successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Set and save connection before connecting.", "Proton", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                con.Close();
            }
            catch (Exception)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////set the database settings to default standard mysql credentials
            txtserver.Text = "localhost";
            txtusername.Text = "root";
            txtpassword.Text = "";
            txtdatabase.Text = "test";
            txtport.Text = "3306";
        }
        public void readconnectionsettings()
        {
            try
            {
                ////read the settings from json file you saved earlier
                JObject main = JObject.Parse(File.ReadAllText("Connection.settings.json"));
                 ////set textboxes with the read settings
                txtserver.Text = (string)main["server"];
                txtusername.Text = (string)main["username"];
                txtpassword.Text = (string)main["password"];
                txtport.Text = (string)main["port"];
                txtdatabase.Text = (string)main["database"];
            }
            catch (Exception)
            {

            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var main = new SettingsModel();
                ///set the settings from textboxes to model in order to convert to json
                main.server = txtserver.Text;
                main.username = txtusername.Text;
                main.password = txtpassword.Text;
                main.port = txtport.Text;
                main.database = txtdatabase.Text;

                string json = JsonConvert.SerializeObject(main);
                ///save the them in json file
                File.WriteAllText("Connection.settings.json", json);
                MessageBox.Show("Database connection settings successfully saved on disk. \n Now try to connect", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch(Exception)
            {

            }


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ///set the import tab to selected
            this.metroTabControl1.SelectedTab = this.import;
            ///read the database connection settings
            readconnectionsettings();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ///DialogResult res = MessageBox.Show("Are you sure you want to run this query?","Proton",MessageBoxButtons.OK,MessageBoxIcon.Question);
            ///if(res == DialogResult.OK)
            ///{
            ///
            if (sqleditor.TextLength>0)
            {
                File.WriteAllText("Temp.sql", sqleditor.Text);
                new RunQuery(txtdatabase.Text).Show();
            }
            else
            {
                MessageBox.Show("Ensure there is some query!");
            }

            ///}
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///KILL THE APP
            Application.Exit();
        }
    }
}
