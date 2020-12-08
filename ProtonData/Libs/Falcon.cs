using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplatePrinter.ExcelLib
{
    public class Falcon
    {
        public DataTable output { set; get; }
        public List<String> columns { set; get; }
        public Falcon(String path)
        {

            DataSet result = new DataSet();
            columns = new List<string>();
            String Ext = Path.GetExtension(path);
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            ///check if file is .xls or .xlsx 
            if (Ext == ".xls")
            {
                /// Reading from a binary Excel file ('97-2003 format; *.xls)
                IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                result = excelReader.AsDataSet();
                excelReader.Close();
            }
            if (Ext == ".xlsx")
            {
                /// Reading from a OpenXml Excel file (2007 format; *.xlsx)
                IExcelDataReader excelReader2 = ExcelReaderFactory.CreateOpenXmlReader(stream);
                /// DataSet - The result of each spreadsheet will be created in the result.Tables
                result = excelReader2.AsDataSet();
                excelReader2.Close();
            }
            ///create columns here
            foreach (String col in result.Tables[0].Rows[0].ItemArray)
            {
                columns.Add(col);
            }

            ///result.Tables[0].Rows[0].Delete();
            output = result.Tables[0];

        }
        public static Boolean ImportFromExcel(String path, DataGridView output)
        {
            ///if the is already data in datagrid clear (rows and columns)
            if (output.Rows.Count > 1 || output.Columns.Count > 0)
            {

                output.Columns.Clear();
                output.Rows.Clear();

            }

            ///create new dataset

            DataSet result = new DataSet(); 
            ///get path extension of the file to be imported
            String Ext = Path.GetExtension(path);
            FileStream stream;
            try
            {
                ///open using filestream
                stream = File.Open(path, FileMode.Open, FileAccess.Read);
            }
            catch (System.IO.IOException ex)
            {
                ///incase of error show this message and return 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ///check if file is .xls or .xlsx 
            if (Ext == ".xls")
            {
                /// Reading from a binary Excel file ('97-2003 format; *.xls)
                IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                result = excelReader.AsDataSet();
                excelReader.Close();
            }
            else if (Ext == ".xlsx")
            {
                /// Reading from a OpenXml Excel file (2007 format; *.xlsx)
                IExcelDataReader excelReader2 = ExcelReaderFactory.CreateOpenXmlReader(stream);
                /// DataSet - The result of each spreadsheet will be created in the result.Tables
                result = excelReader2.AsDataSet();
                excelReader2.Close();
            }
            int i = 0;
            foreach (DataTable table in result.Tables)
            {
                ///loop through all the tables 
                foreach (DataRow row in table.Rows)
                {
                    i = i + 1;
                    ///check if its the first row then add the value to headers Columns
                    if (i == 1)
                    {
                        ///create columns here
                        foreach (String col in row.ItemArray)
                        {
                            output.Columns.Add(col, col);
                        }
                    }
                    else
                    {
                        ///add row items  using the Row array item
                        output.Rows.Add(row.ItemArray);
                    }
                }
            }

            return true;
        }


    }
}
