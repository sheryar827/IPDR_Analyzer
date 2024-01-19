using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using LumenWorks.Framework.IO.Csv;


namespace IPDR_Analyzer.Classes
{
    class CommonMethods
    {

        public static int getCount(string qry)
        {
            int numRecs = 0;
            SqlConnection sqlcon = new SqlConnection(AppConnection.GetConnectionString());
            try
            {
                SqlCommand sqlcmnd = new SqlCommand(qry, sqlcon);
                sqlcon.Open();
                numRecs = (int)sqlcmnd.ExecuteScalar();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return numRecs;
        }

        public static int getTotalCount(string sp)
        {
            int numRecs = 0;
            SqlConnection sqlcon = new SqlConnection(AppConnection.GetConnectionString());
            try
            {
                SqlCommand sqlcmnd = new SqlCommand(sp, sqlcon);
                sqlcon.Open();
                numRecs = (int)sqlcmnd.ExecuteScalar();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return numRecs;
        }

        public static GetSqlDRAndConn getvalues(string Qry)
        {
            // Command to connect to sql server
            SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString());
            SqlDataReader dr = null;
            try
            {
                // executing the command
                SqlCommand Comm = new SqlCommand(Qry, conn);
                Comm.CommandTimeout = 0;
                // Open the connection to sql server
                conn.Open();
                // Read data from sql server
                dr = Comm.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // after data read closing the sql connection

            GetSqlDRAndConn getSqlDRAndConn = new GetSqlDRAndConn(conn, dr);
            // return data to the funcation from where getvalues is called
            return getSqlDRAndConn;

            //Conn.Close();

        }

        public static async Task<DataTable> getRecords(string proc)
        {

            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(proc, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    DataTable dt = new DataTable();
                    // SqlCommand timeout 360 seconds
                    cmd.CommandTimeout = 360;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.UpdateBatchSize = 5000;
                    await Task.Run(() =>
                    da.Fill(dt));
                    return dt;
                }
            }
            

        }

        public static void insertRecords(string proc)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(proc, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            
        }


        public static DataTable browseFile()
        {
            DataTable dt = null;
            DataTableCollection tableCollection = null;
            try
            {

                using (FileDialog openFileDialog = new OpenFileDialog() { Filter = "All Worksheets|*.xls;*.xlsx;*.csv;|Ms 97-2003|*.xls;|Ms Office 2007|*.xlsx;|CSV file|*.csv;|All Files|*.*" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //txtFileName.Text = openFileDialog.FileName;
                        string extension = Path.GetExtension(openFileDialog.FileName);
                        if (extension == ".csv")
                        {

                            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(openFileDialog.FileName)), true))
                            {
                                dt = new DataTable();
                                dt.Load(csvReader);
                                //                                standCDRs();
                            }
                        }
                        else
                        {
                            try
                            {
                                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                                {
                                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                                    {
                                        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                        {
                                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                        });

                                        tableCollection = result.Tables;

                                        /*Getting first sheet from the excel file no need to select
                                         sheet from the combobox*/
                                        dt = tableCollection[0];
                                        //standCDRs();
                                        /*cboSheet.Items.Clear();
                                        foreach (DataTable table in tableCollection)
                                            cboSheet.Items.Add(table.TableName);*/ //add sheet to combobox
                                    }
                                }

                            }
                            catch (IOException excep)
                            {

                                MessageBox.Show(excep.Message);
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static DataTable uniqueDataTable(DataTable dt, string colName/*this column makes the datatable unique*/)
        {
            /*
             * This code make the datatable unique *
             */
            DataTable uniqueDT = dt.AsEnumerable()
             .GroupBy(x => x.Field<string>(colName))
             .Select(x => x.First()).CopyToDataTable();

            return uniqueDT;
        }


        // converting hex messages to text send by different brand and companies
        public static string ConvertHex(string hexString)
        {
            try
            {
                string ascii = string.Empty;
                //System.Text.RegularExpressions.Regex.IsMatch(item.Key, @"\A\b[0-9a-fA-F]+\b\Z")
                if (!System.Text.RegularExpressions.Regex.IsMatch(hexString, @"\A\b[0-9]+\b\Z"))
                {
                    if (hexString.Length % 2 != 0)
                    {
                        hexString = hexString.Remove(hexString.Length - 1, 1);
                        for (int i = 0; i < hexString.Length; i += 2)
                        {
                            string hs = string.Empty;

                            hs = hexString.Substring(i, 2);
                            ulong decval = Convert.ToUInt64(hs, 16);
                            long deccc = Convert.ToInt64(hs, 16);
                            char character = Convert.ToChar(deccc);
                            ascii += character;

                        }
                    }
                    else
                    {
                        for (int i = 0; i < hexString.Length; i += 2)
                        {
                            string hs = string.Empty;

                            hs = hexString.Substring(i, 2);
                            ulong decval = Convert.ToUInt64(hs, 16);
                            long deccc = Convert.ToInt64(hs, 16);
                            char character = Convert.ToChar(deccc);
                            ascii += character;

                        }
                    }
                }
                return ascii + " " + hexString;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        public static string AddArrayParameters(string[] array)
        {
            /* An array cannot be simply added as a parameter to a SqlCommand so we need to loop through things and add it manually. 
             * Each item in the array will end up being it's own SqlParameter so the return value for this must be used as part of the
             * IN statement in the CommandText.
             */
            var parameters = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                parameters[i] = string.Format("'{0}'", array[i]);
            }

            return string.Join(", ", parameters);
        }

        


    }
}
