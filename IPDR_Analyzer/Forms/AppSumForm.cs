using IPDR_Analyzer.Classes;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPDR_Analyzer.Forms
{
    public partial class AppSumForm : Form
    {
        DataTable ipdrSum = null;
        DataTable ipdrDetail = null;
        //List which have overall CDR Summary
        List<AppSummary> ipdrCompSumm;
        List<StandIPDR> selectedRecordsA_Num, morningRecordsA_Num, dayRecordsA_Num, eveningRecordsA_Num;

        public AppSumForm()
        {
            InitializeComponent();
        }


        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        public void clearGridView()
        {
            IPDRSummaryGridView.DataSource = null;
            IPDRSummaryGridView.Rows.Clear();
            IPDRSummaryGridView.Columns.Clear();
            IPDRSummaryGridView.Refresh();
        }

        private void rbDay_Click(object sender, EventArgs e)
        {
            dayRecordsA_Num = new List<StandIPDR>();


            try
            {
                dayRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.dStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.dEnd).ToList();
                getAllSummary(getAppRecords(dayRecordsA_Num));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbEvening_Click(object sender, EventArgs e)
        {
            eveningRecordsA_Num = new List<StandIPDR>();


            try
            {
                eveningRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.eStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.eEnd).ToList();
                getAllSummary(getAppRecords(eveningRecordsA_Num));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbSelected_Click(object sender, EventArgs e)
        {
            panelDT.Enabled = true;
            flpTime.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cdrSelectedSummary();
        }

        private void cdrSelectedSummary()
        {
            //string Qry = "select * from CDRTable WHERE Call_Type = 'Voice'";

            // Sql Query to get every row from CDRTable
            DateTime startDate = Convert.ToDateTime(dtpDateFrom.Value.ToString("yyyy/MM/dd"));
            DateTime endDate = Convert.ToDateTime(dtpDateTo.Value.ToString("yyyy/MM/dd"));
            // Converting time to 24H format and removing PM, AM from it e.g 16:00:00 AM getting only first 8 char like 16:00:00
            TimeSpan startTime = Convert.ToDateTime(dtpTimeFrom.Value.ToString("HH:mm:ss tt").Substring(0, 8)).TimeOfDay;
            TimeSpan endTime = Convert.ToDateTime(dtpTimeTo.Value.ToString("HH:mm:ss tt").Substring(0, 8)).TimeOfDay;

            selectedRecordsA_Num = new List<StandIPDR>();
            selectedRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Date) >= startDate && Convert.ToDateTime(t.Date) <= endDate
            && Convert.ToDateTime(t.Time).TimeOfDay >= startTime && Convert.ToDateTime(t.Time).TimeOfDay <= endTime).ToList();

            getAllSummary(getAppRecords(selectedRecordsA_Num));

        }

        private void rbAllData_Click(object sender, EventArgs e)
        {
            panelDT.Enabled = false;
            flpTime.Enabled = true;

            rbDay.Checked = false; rbMorning.Checked = false; rbEvening.Checked = false;

            // function to get complete cdr summary
            getAllSummary(getAppRecords(Common.allRecordNum));

            //IPDRSummaryGridView.DataSource = new ListtoDataTable()
              //      .ToDataTable(getAllSummary(getAppRecords(Common.allRecordNum)));
        }

        private List<AppSummary> getAppRecords(List<StandIPDR> ipdrList)
        {
            List<AppSummary> appsum = new List<AppSummary>();

            // Using LINQ to group and count the applications
            var appCounts = ipdrList
                .GroupBy(ipdr => ipdr.App)
                .Select(group => new
                {
                    AppName = group.Key,
                    Count = group.Count()
                })
                .ToList();

            // Printing the results
            foreach (var appCount in appCounts)
            {
                AppSummary appSummary = new AppSummary(appCount.AppName, appCount.Count);
                appsum.Add(appSummary);
            }

            return appsum;
        }

        private void IPDRSummaryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string appName = IPDRSummaryGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string columnType = IPDRSummaryGridView.Columns[e.ColumnIndex].HeaderText;

            if (!rbSelected.Checked)
            {
                if (rbMorning.Checked)
                {
                    getDetailedRecords(appName, morningRecordsA_Num);
                }
                else if (rbDay.Checked)
                {
                    getDetailedRecords(appName, dayRecordsA_Num);
                }
                else if (rbEvening.Checked)
                {
                    getDetailedRecords(appName, eveningRecordsA_Num);
                }
                else
                {
                    getDetailedRecords(appName, Common.allRecordNum);
                }
            }
            else
            {
                getDetailedRecords(appName, selectedRecordsA_Num);
            }
        }

        private void getDetailedRecords(string appName, List<StandIPDR> list)
        {
            try
            {
                var matchingRecords = list.Where(record => record.App == appName).ToList();

                ListtoDataTable ltdt = new ListtoDataTable();
                DataTable dataTable = ltdt.ToDataTable(matchingRecords);

                new IPDRSummaryDetailForm(dataTable).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbMorning_Click(object sender, EventArgs e)
        {
            morningRecordsA_Num = new List<StandIPDR>();

            try
            {
                morningRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.mStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.mEnd).ToList();
                getAllSummary(getAppRecords(morningRecordsA_Num));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getAllSummary(List<AppSummary> ipdrList)
        {
            if (ipdrList.Count() > 0)
            {
                

                // List to show in PiChart
                List<GetBasicConversation> getBasicConversations = new List<GetBasicConversation>();

                /*Arranging the list in decending order on the basis of total in our calls and sms*/
                var ipdrCompSumm = ipdrList.OrderByDescending(cs => cs.Total).ToList();

                IPDRSummaryGridView.DataSource = new ListtoDataTable()
                    .ToDataTable(ipdrCompSumm);



                SeriesCollection series = new SeriesCollection();
                if (ipdrCompSumm.Count >= 5)
                {
                    foreach (var bc in ipdrCompSumm.GetRange(0, 5))
                    {
                        series.Add(item: new PieSeries()
                        {
                            Title = bc.App/*BasicConversation contain B-Party Contact Number*/
                            ,
                            Values = new ChartValues<int> { bc.Total },
                            DataLabels = true,
                            LabelPoint = labelPoint
                        });
                        pcCDRSummary.Series = series;
                    }
                }
                else
                {
                    foreach (var bc in ipdrCompSumm)
                    {
                        series.Add(item: new PieSeries()
                        {
                            Title = bc.App/*BasicConversation contain B-Party Contact Number*/
                            ,
                            Values = new ChartValues<int> { bc.Total },
                            DataLabels = true,
                            LabelPoint = labelPoint
                        });
                        pcCDRSummary.Series = series;
                    }
                }
            }
        }

        private void AppSumForm_Load(object sender, EventArgs e)
        {
            try
            {
                //getting start date from datatable
                string sd = Common.allRecordNum.First().Date.ToString();
                string st = Common.allRecordNum.First().Time.ToString();

                //getting end date from datatable
                string ed = Common.allRecordNum.Last().Date.ToString();
                string et = Common.allRecordNum.Last().Time.ToString();

                dtpDateFrom.Value = Convert.ToDateTime(sd);
                dtpDateTo.Value = Convert.ToDateTime(ed);
                dtpTimeFrom.Value = Convert.ToDateTime(st);
                dtpTimeTo.Value = Convert.ToDateTime(et);



                labelA_Num.Text = Common.numForAnalysis;

                clearGridView();

                /*CommonMethods.messageDialog("Please Wait...");*/

                dtpTimeFrom.Format = DateTimePickerFormat.Time;
                /*dtpTimeFrom.Format = DateTimePickerFormat.Custom;
                dtpTimeFrom.CustomFormat = "HH:mm:ss tt";*/
                dtpTimeFrom.ShowUpDown = true;

                dtpTimeTo.Format = DateTimePickerFormat.Time;
                /*dtpTimeTo.Format = DateTimePickerFormat.Custom;
                dtpTimeTo.CustomFormat = "HH:mm:ss tt";*/
                dtpTimeTo.ShowUpDown = true;

                /*rbAllData.Checked = true;*/
                panelDT.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            getAllSummary(getAppRecords(Common.allRecordNum));
        }

        
    }
}
