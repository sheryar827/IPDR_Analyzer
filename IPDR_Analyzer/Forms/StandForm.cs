using Bunifu.UI.WinForms;
using Dapper;
using ExcelDataReader;
using IPDR_Analyzer.Classes;
using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPDR_Analyzer.Forms
{
    public partial class StandForm : Form
    {
        public DataTable dt = null;
        private DataTable dataTable = null;
        DataTableCollection tableCollection;
        List<StandIPDR> standIPDR = null;
        public int projectId = 0;
        public string project = null;
        String Number;
        bool cell_clicked = false;
        public StandForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                gvStandIPDR.DataSource = null;
                using (FileDialog openFileDialog = new OpenFileDialog() { Filter = "All Worksheets|*.xls;*.xlsx;*.csv;|Ms 97-2003|*.xls;|Ms Office 2007|*.xlsx;|CSV file|*.csv;|All Files|*.*" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        string extension = Path.GetExtension(openFileDialog.FileName);
                        if (extension == ".csv")
                        {

                            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(openFileDialog.FileName)), true))
                            {
                                dt = new DataTable();
                                //CSVToDataTable converter = new CSVToDataTable();
                                dt.Load(csvReader);
                                standCDRsAsync();
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
                                        standCDRsAsync();
                                    }
                                }

                            }
                            catch (IOException excep)
                            {
                                Console.WriteLine("EXCEPTION: " + excep.Message);
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
        }

        void SortIPDRListByDate(List<StandIPDR> ipdrList)
        {
            // Use the Sort method with a custom comparison function
            ipdrList.Sort((x, y) =>
            {
                // Parse the Date string into a DateTime object for accurate comparison
                DateTime dateX = DateTime.ParseExact(x.Date, "MM-dd-yyyy", CultureInfo.InvariantCulture);
                DateTime dateY = DateTime.ParseExact(y.Date, "MM-dd-yyyy", CultureInfo.InvariantCulture);

                // Compare the DateTime objects
                return dateX.CompareTo(dateY);
            });
        }

        private void standCDRs()
        {
            try
            {
                if (dt.Columns.Count > 0)
                {
                    standIPDR = new List<StandIPDR>();

                    string dateFormat = "dd-MM-yyyy H:mm"; // Updated date format to match "22-11-2023 23:57"
                    //Console.WriteLine(dateFormat);
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime dateTime = DateTime.ParseExact(TryParseDateTime(row["Time"].ToString()), dateFormat, CultureInfo.InvariantCulture);

                        //Console.WriteLine(dateTime);
                        
                        // Use DateTime.ParseExact to convert the string to a DateTime object
                        // Ensure the CultureInfo is set to InvariantCulture to use the Gregorian calendar
                        //DateTime dateTime = DateTime.ParseExact(dateTimeString, dateFormat, CultureInfo.InvariantCulture);

                        //Console.WriteLine(dateTime.ToString());

                        StandIPDR record = new StandIPDR
                        {
                            Number = row["Number"].ToString(),
                            Date = dateTime.ToString(Common.datef),//dateTime.ToString(Common.datef), // Format date as a string in the format you need
                            Time = dateTime.ToString(Common.timef), // Format time as a string
                            Dur = row["Dur"].ToString(),
                            Protocol = row["Protocol"].ToString(),
                            Source_IP = row["Source IP"].ToString(),
                            Source_PORT = row["Source PORT"].ToString(),
                            Dest_IP = row["Dest IP"].ToString(),
                            Dest_PORT = row["Dest PORT"].ToString(),
                            App = row["App"].ToString(),
                            Up = row["Up"].ToString(),
                            Down = row["Down"].ToString(),
                            Location = row["Location"].ToString(),
                            Latitude = Convert.ToDouble(row["Latitude"]),
                            Longitude = Convert.ToDouble(row["Longitude"]),

                            /*Converting Date into Weekdays like sunday, monday etc*/
                            Weekday = dateTime.DayOfWeek.ToString()
                        };

                        standIPDR.Add(record);
                    }

                    SortIPDRListByDate(standIPDR);

                    //gvStandIPDR.DataSource = standIPDR;

                    Number = standIPDR.First().Number;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                UpdateErrorHandlingText(standIPDR);
            }
        }

        private string TryParseDateTime(string dateTimeStr)
        {
            var formats = new string[] {
        // 24-hour formats
        "dd-MM-yyyy HH:mm:ss", "MM-dd-yyyy HH:mm:ss", "yyyy-MM-dd HH:mm:ss",
        "dd/MM/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss", "yyyy/MM/dd HH:mm:ss",
        "dd.MM.yyyy HH:mm:ss", "MM.dd.yyyy HH:mm:ss", "yyyy.MM.dd HH:mm:ss",
        // 12-hour formats with AM/PM
        "dd-MM-yyyy hh:mm:ss tt", "MM-dd-yyyy hh:mm:ss tt", "yyyy-MM-dd hh:mm:ss tt",
        "dd/MM/yyyy hh:mm:ss tt", "MM/dd/yyyy hh:mm:ss tt", "yyyy/MM/dd hh:mm:ss tt",
        "dd.MM.yyyy hh:mm:ss tt", "MM.dd.yyyy hh:mm:ss tt", "yyyy.MM.dd hh:mm:ss tt",
        "MM/dd/yyyy H:mm", "dd-MM-yyyy H:mm","MM/dd/yyyy HH:mm",
        // Variations with different separators
        "MM-dd-yyyy H:mm",
        "MM-dd-yyyy HH:mm",
        "MM.dd.yyyy H:mm",
        "MM.dd.yyyy HH:mm",
        "MM/dd/yyyy H:mm:ss",
        "MM/dd/yyyy HH:mm:ss",
        "MM-dd-yyyy H:mm:ss",
        "MM-dd-yyyy HH:mm:ss",
        "MM.dd.yyyy H:mm:ss",
        "MM.dd.yyyy HH:mm:ss",
        
        // 12-hour formats with AM/PM
        "MM/dd/yyyy h:mm tt",
        "MM/dd/yyyy hh:mm tt",
        "MM-dd-yyyy h:mm tt",
        "MM-dd-yyyy hh:mm tt",
        "MM.dd.yyyy h:mm tt",
        "MM.dd.yyyy hh:mm tt",

        // Other common formats can be added here
    };

            if (DateTime.TryParseExact(dateTimeStr, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate.ToString("dd-MM-yyyy h:mm", CultureInfo.InvariantCulture);
            }

            // If parsing fails, return the original string
            return dateTimeStr;
        }

        private async void standCDRsAsync()
        {
            bunifuLoader.Visible = true; // Show the loader

            try
            {
                await Task.Run(() =>
                {
                    // ... existing code moved inside Task.Run ...
                    standCDRs();
                });

                this.Invoke(new Action(() =>
                {
                    gvStandIPDR.DataSource = standIPDR;
                    Number = standIPDR.First().Number;
                    bunifuLoader.Visible = false; // Hide the loader
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UpdateErrorHandlingText(standIPDR);
                bunifuLoader.Visible = false; // Hide the loader in case of exception
            }
        }


        public void UpdateErrorHandlingText(List<StandIPDR> standIPDR)
        {
            //Here we plus 2 because 1 line is header
            bflbErrorExcelSheet.Text = $"{standIPDR.Count + 2}";

            if (standIPDR.Count >= 2)
            {
                var secondLastItem = standIPDR[standIPDR.Count - 2];
                var lastItem = standIPDR.Last();

                tbErrorHandling.Text = $"--Second Last Line--" +
                                       $"{Environment.NewLine}Number: {secondLastItem.Number}" +
                                       $"{Environment.NewLine}Time: {secondLastItem.Date}" +
                                       $"{Environment.NewLine}Dur: {secondLastItem.Dur}" +
                                       $"{Environment.NewLine}Protocol: {secondLastItem.Protocol}" +
                                       $"{Environment.NewLine}{Environment.NewLine}--Last Line--" +
                                       $"{Environment.NewLine}Number: {lastItem.Number}" +
                                       $"{Environment.NewLine}Time: {lastItem.Date}" +
                                       $"{Environment.NewLine}Dur: {lastItem.Dur}" +
                                       $"{Environment.NewLine}Protocol: {lastItem.Protocol}";
            }
            else
            {
                tbErrorHandling.Multiline = true; // Ensure this property is set
                var lastItem = standIPDR.LastOrDefault();

                tbErrorHandling.Text = $"--Last Line--" +
                                       $"{Environment.NewLine}Number: {lastItem?.Number}" +
                                       $"{Environment.NewLine}Time: {lastItem?.Date}" +
                                       $"{Environment.NewLine}Dur: {lastItem?.Dur}" +
                                       $"{Environment.NewLine}Protocol: {lastItem?.Protocol}";
            }
        }

        private async void saveToDataBank()
        {
           

                    try
                    {

                        // stored procedure to check CDR already exist in the database or not
                        string spCheck_IPDR_Exist = "exec dbo.Check_IPDR_Exist '" + standIPDR.Last().Number + "', '" + standIPDR.Last().Date + "', '" + projectId + "', '" + project + "', '" + Common.userName + "'";
                        DataTable dt = new DataTable();
                        dt = await CommonMethods.getRecords(spCheck_IPDR_Exist);

                        if (dt.Rows.Count >= 1)
                        {

                            MessageBox.Show("IPDR Already Exist");
                        }
                        else
                        {
                            saveToIPDRDataBank();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Please First Upload IPDR!! " + ex.Message);
                    }
            
        }

        private void saveToIPDRDataBank()
        {
            DataTable dtBulkInsert = new DataTable();

            // Adding the Columns.
            foreach (DataGridViewColumn column in gvStandIPDR.Columns)
            {
                dtBulkInsert.Columns.Add(column.HeaderText, column.ValueType);
            }

            dtBulkInsert.Columns.Add("ProjectId", typeof(int));
            dtBulkInsert.Columns.Add("project", typeof(string));
            dtBulkInsert.Columns.Add("username", typeof(string));

            //Adding the Rows.
            foreach (DataGridViewRow row in gvStandIPDR.Rows)
            {
                dtBulkInsert.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        dtBulkInsert.Rows[dtBulkInsert.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
                dtBulkInsert.Rows[dtBulkInsert.Rows.Count - 1]["ProjectId"] = projectId;
                dtBulkInsert.Rows[dtBulkInsert.Rows.Count - 1]["project"] = project;
                dtBulkInsert.Rows[dtBulkInsert.Rows.Count - 1]["username"] = Common.userName;

            }

            var stopWatch = new Stopwatch();
            progressBar.Maximum = gvStandIPDR.Rows.Count;
            stopWatch.Start();
            try
            {
                SqlConnection sqlcon = new SqlConnection(AppConnection.GetConnectionString());

                using (SqlBulkCopy objBulk = new SqlBulkCopy(sqlcon))
                {
                    // number of rows copy of table in one go
                    objBulk.BatchSize = gvStandIPDR.Rows.Count / 100;
                    objBulk.NotifyAfter = gvStandIPDR.Rows.Count / 100;
                    objBulk.SqlRowsCopied += (sender, eventArgs) =>
                    {
                        if ((progressBar.Maximum - progressBar.Value) < objBulk.NotifyAfter)
                        {
                            progressBar.Value = progressBar.Maximum;
                        }
                        else
                        {
                            progressBar.Value = Convert.ToInt32(eventArgs.RowsCopied);
                        }
                    };
                    objBulk.DestinationTableName = Common.ipdrDBTable;
            
                    objBulk.BulkCopyTimeout = 120;
                    objBulk.ColumnMappings.Add("Number", "Number");
                    objBulk.ColumnMappings.Add("Date", "Date");
                    objBulk.ColumnMappings.Add("Time", "Time");
                    objBulk.ColumnMappings.Add("Dur", "Dur");
                    objBulk.ColumnMappings.Add("Protocol", "Protocol");
                    objBulk.ColumnMappings.Add("Source_IP", "Source_IP");
                    objBulk.ColumnMappings.Add("Source_PORT", "Source_PORT");
                    objBulk.ColumnMappings.Add("Dest_IP", "Dest_IP");
                    objBulk.ColumnMappings.Add("Dest_PORT", "Dest_PORT");
                    objBulk.ColumnMappings.Add("App", "App");
                    objBulk.ColumnMappings.Add("Up", "Up");
                    objBulk.ColumnMappings.Add("Down", "Down");
                    objBulk.ColumnMappings.Add("Location", "Location");
                    objBulk.ColumnMappings.Add("Latitude", "Latitude");
                    objBulk.ColumnMappings.Add("Longitude", "Longitude");
                    objBulk.ColumnMappings.Add("Weekday", "Weekday");
                    objBulk.ColumnMappings.Add("UserName", "UserName");
                    objBulk.ColumnMappings.Add("ProjectId", "ProjectId");
                    objBulk.ColumnMappings.Add("Project", "Project");
                    

                    sqlcon.Open();
                    try
                    {
                        objBulk.WriteToServer(dtBulkInsert);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlcon.Close();
                        stopWatch.Stop();

                        saveToProjectTable();
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gvShowProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            projectId = (int)gvShowProject.Rows[e.RowIndex].Cells[0].Value;
            project = gvShowProject.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            //if cdr is standerize then it save to databank otherwise not
            if (gvStandIPDR.Rows.Count > 1)
                saveToDataBank();
        }

        private async void saveToProjectTable()
        {

            string spCheckNum = "exec dbo.Check_Mobile_Number_Exist '" + standIPDR.First().Number + "', '" + projectId + "', '" + project + "', '" + Common.userName + "'";
            DataTable dt = new DataTable();
            dt = await CommonMethods.getRecords(spCheckNum);
            if (dt.Rows.Count >= 1)
            {

                MessageBox.Show("Mobile Number Already Exist");
            }
            else
            {

                // sql query to add data to (GeneralPoliceTable)
                string qry = "insert into " + Common.projectTableNumber + "(ProjectId, project, Number, username) " +
                    "values ('" + projectId + "', '" + project + "','" + Number + "', '" + Common.userName + "')";
                using (SqlConnection db = new SqlConnection(AppConnection.GetConnectionString()))
                {

                    db.Execute(qry);
                }

                MessageBox.Show("Finish !!!");

                //clear the progress bar
                progressBar.Value = 0;

                getProjectNumber();

            }
        }

        private async void getProjectNumber()
        {
            try
            {
                clearGridView();
                DataTable allRecord = new DataTable();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    // Stored Procedure only getting project table records not general police table records
                    string proc = "exec dbo.ProjectsTableNumber_View_PID '" + Common.userName + "', '" + dataTable.Rows[i].Field<int>("ProjectId") + "', '" + dataTable.Rows[i].Field<string>("project") + "'";
                    allRecord.Merge(await CommonMethods.getRecords(proc));
                }

                /*DataView dv = allRecord.DefaultView;
                dv.Sort = "ProjectId DESC";*/
                gvIPDRNumber.DataSource = allRecord;
                gvIPDRNumber.Columns[0].HeaderText = "Project ID";
                gvIPDRNumber.Columns[1].HeaderText = "Project";
                gvIPDRNumber.Columns[2].HeaderText = "Number";

                /**
                 * Hiding id column only using for arranging CDRs in 
                 * descending order
                 */
                gvIPDRNumber.Columns[3].Visible = false;

                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.FlatStyle = FlatStyle.Popup;
                deleteButton.HeaderText = "Delete";
                deleteButton.Name = "delBtn";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Text = "Delete";
                deleteButton.Width = 60;
                if (gvIPDRNumber.Columns.Contains(deleteButton.Name = "delBtn"))
                {

                }
                else
                {
                    gvIPDRNumber.Columns.Add(deleteButton);
                }

                // Arranging CDRs A_Num in descending order on the basis
                // of id
                gvIPDRNumber.Sort(this.gvIPDRNumber.Columns["Id"], ListSortDirection.Descending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearGridView()
        {
            gvIPDRNumber.DataSource = null;
            gvIPDRNumber.Rows.Clear();
            gvIPDRNumber.Columns.Clear();
            gvIPDRNumber.Refresh();
        }

        private async void StandForm_Load(object sender, EventArgs e)
        {
            string proc = "exec dbo.Projects_View_Filter_UserName '" + Common.userName + "'";
            dataTable = await CommonMethods.getRecords(proc);

            if (dataTable.Rows.Count > 0)
            {
                gvShowProject.DataSource = dataTable;
                gvShowProject.Columns[0].HeaderText = "Project ID";
                /*gvShowCaseProject.Columns[0].Visible = false;*/
                gvShowProject.Columns[1].HeaderText = "Project";

                getProjectNumber();
            }
        }

        private async void gvIPDRNumber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bunifuLoader.Visible = true; // Show the loader

                Common.numForAnalysis = gvIPDRNumber.Rows[e.RowIndex].Cells[2].Value.ToString();
                Common.project_Name = gvIPDRNumber.Rows[e.RowIndex].Cells[1].Value.ToString();

                string spGetAllRecords = "exec dbo.GET_ALL_RECORD_NUM '" + Common.numForAnalysis + "', '" + Common.project_Name + "'";
                
                DataTable dt = new DataTable();
                
                dt = await CommonMethods.getRecords(spGetAllRecords);

                this.Invoke(new Action(() =>
                {
                    bunifuLoader.Visible = false;
                    try
                    {
                        if (dt.Columns.Count > 0)
                        {
                            Common.allRecordNum = new List<StandIPDR>();


                            foreach (DataRow row in dt.Rows)
                            {

                                StandIPDR record = new StandIPDR
                                {
                                    Number = row["Number"].ToString(),
                                    Date = row["Date"].ToString(),//dateTime.ToString(Common.datef), // Format date as a string in the format you need
                                    Time = row["Time"].ToString(), // Format time as a string
                                    Dur = row["Dur"].ToString(),
                                    Protocol = row["Protocol"].ToString(),
                                    Source_IP = row["Source_IP"].ToString(),
                                    Source_PORT = row["Source_PORT"].ToString(),
                                    Dest_IP = row["Dest_IP"].ToString(),
                                    Dest_PORT = row["Dest_PORT"].ToString(),
                                    App = row["App"].ToString(),
                                    Up = row["Up"].ToString(),
                                    Down = row["Down"].ToString(),
                                    Location = row["Location"].ToString(),
                                    Latitude = Convert.ToDouble(row["Latitude"]),
                                    Longitude = Convert.ToDouble(row["Longitude"]),
                                    Weekday = row["Weekday"].ToString()
                                };

                                Common.allRecordNum.Add(record);
                            }


                        }

                        Common.numForAnalysis = Common.allRecordNum.First().Number;

                        MessageBox.Show(Common.numForAnalysis + " With " + Common.allRecordNum.Count() + " Records Is Selected For Analysis");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        UpdateErrorHandlingText(standIPDR);
                    }
                }));

                //Common.allRecordA_Nums = Common.allRecordA_Nums.OrderBy(x => x.Date).ToList();
                //MessageBox.Show(Common.numForAnalysis + " With " + Common.allRecordNum.Count() + " Records Is Selected For Analysis");
            }
        }
    }

    
}
