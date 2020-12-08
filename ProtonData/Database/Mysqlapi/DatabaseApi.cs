using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtonData.Database.Mysqlapi
{
    class DatabaseApi
    {
        /// <summary>
        /// standard global variables for the whole classs
        /// this will be set to database connection details
        /// </summary>    

        public MySqlConnection con;
        public string servername { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string database { get; set; }
        public DatabaseApi()
        {
            try
            {
                ///read from connection file
                JObject main = JObject.Parse(File.ReadAllText("Connection.settings.json"));
                //set textboxes with the read settings
               servername = (string)main["server"];
               username = (string)main["username"];
               password = (string)main["password"];
               port= (string)main["port"];
               database = (string)main["database"];
            }
            catch (Exception)
            {
                ///if it finds error just set the default
                servername = "localhost";
                username = "root";
                password = "";
                port = "3306";
                database = "test";

            }

        }
        ~DatabaseApi()
        {
            ///close database connection      


            this.con.Close();
        }
        public void CloseConnection()
        {
            ///close database connection   
            this.con.Close();
        }
        public void Connect()
        {
            try
            {
                ///initiate the connection to the database.


                con = new MySqlConnection("server=" + this.servername + ";" + "uid=" + this.username + ";pwd=" + this.password + ";database=" + this.database + ";");
                con.Open();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n Please Ensure Your MySQL Server is always on \n and you have correct details.", "Proton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadTablesToCombo(ComboBox cbo)
        {
            ///this code loads list of table to the combobox control

            try
            {
                ///create commandtext and set the sql query
                MySqlCommand cmd = this.con.CreateCommand();
                cmd.CommandText = "SHOW tables;";
                ///use the mysql reader to read by looping through each item and adding to combobox
                MySqlDataReader read = cmd.ExecuteReader();
                while(read.Read())
                {
                    //get the first item which is table name
                    cbo.Items.Add(read.GetString(0));

                }
                ///always close the connection after using it
                this.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void ExecuteSQLQuery(String sql)
        {
            try
            {
                ///run the insert,update and delete queries here
                MySqlCommand cmd;
            cmd = this.con.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
                ///always close the connection after using it
            this.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message + "\n Please Ensure Your MySQL Server is always on,Ensure that you have the database and table created ", "Proton", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
