using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtonData.Utils
{
    public class Tools
    {
        /// <summary>
        /// this function returns the index from the datagrid and the columnname text
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int GetIndex(DataGridView dg, DataGridViewColumn text)
        {
            return dg.Columns.IndexOf(text);
        }

        /// <summary>
        /// this function returns columns from a given datagrid
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public static List<String> GetColumns(DataGridView dg)
        {
            var Columns = new List<String>();
            if (dg.Columns != null)
            {
                ///basically loop through all columns building new list

                foreach (DataGridViewColumn col in dg.Columns)
                {
                    Columns.Add(col.HeaderText);
                }
            }
            return Columns; ;

        }
        /// <summary>
        /// this function makes the table query for mysql
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public static String GenerateTableSQL(String[] cols, String tablename)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("CREATE TABLE ");
            sb.Append("`" + tablename + "`");
            sb.Append("(");

            foreach (string n in cols)
            {
                sb.Append("`" + n.Trim() + "` TEXT ,");
            }

            sb.Remove(sb.Length - 1, 1);
            sb.Append(");");
            return sb.ToString();

        }
    }
}
