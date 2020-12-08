using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtonData.Views
{
    public partial class InputBox : Form
    {
        /// <summary>
        /// global variables here 
        /// </summary>
        public static String VALUE;

        /// <summary>
        /// create the excel columns list
        /// </summary>
        public List<String> EXCELCOLUMNS = new List<String>();

        /// <summary>
        /// action delegate for when the task is finished 
        /// </summary>
        public Action<String> onFinish;


        /// <constructor>
        /// the contructor has two args
        /// </constructor>
        /// <param name="onfinish"></param>
        /// <param name="COLS"></param>
        public InputBox(Action<String> onfinish, List<String> COLS)
        {
            InitializeComponent();
            ///
            /// 
            ///asign the columns from excel to this list
            EXCELCOLUMNS = COLS;
            //when finished invoke this action
            this.onFinish = onfinish;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ///add the column name to the textbox for use

            String n = "";
            if (column.Text == "" || column.Text == null)
            {
                column.Text += columnname.Text;
            }
            else
            {

                column.Text += "," + columnname.Text;
            }
        }
        public void CreateColumns()
        {
            StringBuilder bld = new StringBuilder();
            //ensure the table name is set
            if (txttablename.Text == "")
            {
                MessageBox.Show("Provide Table Name", "Proton", MessageBoxButtons.OK, MessageBoxIcon
                    .Warning);
                return;
            }
            if (chktable.Checked)
            {
                //build the create table statement
                bld.Append("CREATE TABLE " + txttablename.Text);
                bld.Append("(");
                String[] cols = column.Text.Split(',');
                int j = 0;
                //loop through columns to make the table columns based on the excel
                foreach (String chr in cols)
                {
                    j = j + 1;
                    bld.Append(chr + " " + CheckType(chr.GetType().ToString()) + " ");
                    if (j != cols.Length)
                    {
                        bld.Append(",");
                    }
                }
                bld.Append(");");
                ///add new line
                bld.Append(Environment.NewLine);
            }
            VALUE += bld.ToString();
            ///create the insert statement
            VALUE += "INSERT INTO `" + txttablename.Text + "`" + "(" + column.Text.ToString().TrimEnd() + ") VALUES ";
            onFinish.Invoke(VALUE);
        }
        ///check data type
        String CheckType(String TYPE)
        {
            String SQLTYPE = "";
            switch (TYPE.ToUpper())
            {
                case "SYSTEM.STRING":
                    SQLTYPE = "text";
                    break;
                case "SYSTEM.INTEGER":
                    SQLTYPE = "int";
                    break;
                case "SYSTEM.DOUBLE":
                    SQLTYPE = "int";
                    break;
                case "SYSTEM.FLOAT":
                    SQLTYPE = "float";
                    break;
                case "SYSTEM.DATETIME":
                    SQLTYPE = "datetime";
                    break;
                case "SYSTEM.DECIMAL":
                    SQLTYPE = "decimal";
                    break;
                case "SYSTEM.BOOL":
                    SQLTYPE = "bool";
                    break;
                case "SYSTEM.BOOLEAN":
                    SQLTYPE = "decimal";
                    break;
                case "SYSTEM.LONG":
                    SQLTYPE = "int";
                    break;
            }
            return SQLTYPE;
        }
        private void DisableStatus(Boolean state)
        {
            ///set the Enabled status of controls
            lblcolname.Enabled = state;
            columnname.Enabled = state;
            btnadd.Enabled = state;


        }
        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateColumns();
        }

        private void cbocolumns_CheckedChanged(object sender, EventArgs e)
        {
            column.Text = "";

            ///var t = COLUMNS;
            if (cbocolumns.Checked)
            {
                DisableStatus(false);
                int j = 0;
                ///add columns to textbox              
                foreach (String n in EXCELCOLUMNS)
                {
                    j = j + 1;
                    column.Text += n;
                    if (j != EXCELCOLUMNS.Count)
                    {
                        column.Text += ",";
                    }
                }
                /// column.Text.Remove(column.TextLength - 1);
            }
            if (!cbocolumns.Checked)
            {
                ///not checked
                DisableStatus(true);

            }
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }
    }
}
