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

namespace ProtonData.Views
{
    public partial class RunQuery : Form
    {
        public RunQuery(string db)
        {
            InitializeComponent();
            ///set the database name
            this.lbldatabase.Text = db;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ///closet this foem object
            this.Close();
        }

        private void RunQuery_Load(object sender, EventArgs e)
        {
       
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
               ///read our temp sql file 
                String query = File.ReadAllText("Temp.sql");
               ///run the db query to insert to table
                Database.Mysqlapi.DatabaseApi db = new Database.Mysqlapi.DatabaseApi();
                db.Connect();
                db.ExecuteSQLQuery(query);
                ///show messge when complete
                MessageBox.Show("Successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch { }

        }
    }
}
