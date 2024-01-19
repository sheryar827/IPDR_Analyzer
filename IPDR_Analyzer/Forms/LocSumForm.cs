using IPDR_Analyzer.Classes;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IPDR_Analyzer.Forms
{
    public partial class LocSumForm : Form
    {
        DataTable LocSum = null;
        DataTable LocDetail = null;
        //List which have overall CDR Summary
        List<LocSummary> locCompSumm;

        List<StandIPDR> selectedRecordsA_Num, morningRecordsA_Num, dayRecordsA_Num, eveningRecordsA_Num;

        public LocSumForm()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        public void clearGridView()
        {
            LocSumDataGridView.DataSource = null;
            LocSumDataGridView.Rows.Clear();
            LocSumDataGridView.Columns.Clear();
            LocSumDataGridView.Refresh();
        }

        private List<LocSummary> getLocRecords(List<StandIPDR> ipdrList)
        {
            List<LocSummary> locsum = new List<LocSummary>();

            // Using LINQ to group and count the applications
            var appCounts = ipdrList
                .GroupBy(ipdr => ipdr.Location)
                .Select(group => new
                {
                    LocName = group.Key,
                    Lat = group.First().Latitude, // Assuming Lat is a property of ipdr
                    Lng = group.First().Longitude, // Assuming Lng is a property of ipdr
                    Count = group.Count()
                })
                .ToList();

            // Printing the results
            foreach (var LocCount in appCounts)
            {
                LocSummary LocSummary = new LocSummary(LocCount.LocName, LocCount.Lat, LocCount.Lng, LocCount.Count);
                locsum.Add(LocSummary);
                //Console.WriteLine(LocSummary.Loc);
            }

            return locsum;
        }

        private void getAllSummary(List<LocSummary> locsum)
        {
            if (locsum.Count() > 0)
            {


                // List to show in PiChart
                List<GetBasicConversation> getBasicConversations = new List<GetBasicConversation>();


                

                /*Aranging the list in decending order on the basis of total in our calls and sms*/
                var locCompSumm = locsum.OrderByDescending(cs => cs.Total).ToList();

                LocSumDataGridView.DataSource = locCompSumm;

                SeriesCollection series = new SeriesCollection();

                if (locCompSumm.Count >= 5)
                {
                    foreach (var bc in locCompSumm.GetRange(0, 5))
                    {
                        series.Add(item: new PieSeries()
                        {
                            Title = bc.Loc/*BasicConversation contain B-Party Contact Number*/
                            ,
                            Values = new ChartValues<int> { bc.Total },
                            DataLabels = true,
                            LabelPoint = labelPoint
                        });
                        pcLocSummary.Series = series;
                    }
                }
                else
                {
                    foreach (var bc in locCompSumm)
                    {
                        series.Add(item: new PieSeries()
                        {
                            Title = bc.Loc/*BasicConversation contain B-Party Contact Number*/
                            ,
                            Values = new ChartValues<int> { bc.Total },
                            DataLabels = true,
                            LabelPoint = labelPoint
                        });
                        pcLocSummary.Series = series;
                    }
                }
            }
        }

        private void LocSumForm_Load(object sender, EventArgs e)
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

            getAllSummary(getLocRecords(Common.allRecordNum));
        }

        private List<AppSummary> getAppRecords(List<StandIPDR> ipdrList)
        {
            List<AppSummary> appsum = new List<AppSummary>();

            // Using LINQ to group and count the applications
            var appCounts = ipdrList
                .GroupBy(ipdr => ipdr.Location)
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

            getAllSummary(getLocRecords(selectedRecordsA_Num));

        }

        private void rbAllData_Click(object sender, EventArgs e)
        {
            panelDT.Enabled = false;
            flpTime.Enabled = true;

            rbDay.Checked = false; rbMorning.Checked = false; rbEvening.Checked = false;

            // function to get complete cdr summary
            getAllSummary(getLocRecords(Common.allRecordNum));
        }

        private void rbMorning_Click(object sender, EventArgs e)
        {
            morningRecordsA_Num = new List<StandIPDR>();

            try
            {
                morningRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.mStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.mEnd).ToList();
                getAllSummary(getLocRecords(morningRecordsA_Num));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbDay_Click(object sender, EventArgs e)
        {
            dayRecordsA_Num = new List<StandIPDR>();


            try
            {
                dayRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.dStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.dEnd).ToList();
                getAllSummary(getLocRecords(dayRecordsA_Num));
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
                getAllSummary(getLocRecords(eveningRecordsA_Num));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
