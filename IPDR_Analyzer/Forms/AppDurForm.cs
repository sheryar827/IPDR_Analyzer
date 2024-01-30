using Bunifu.Charts.WinForms;
using IPDR_Analyzer.Classes;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IPDR_Analyzer.Forms
{
    public partial class AppDurForm : Form
    {
        List<Double> data = new List<Double>();
        List<TopAppCallSec> top5App = null;
        List<StandIPDR> selectedRecordsA_Num, morningRecordsA_Num, dayRecordsA_Num, eveningRecordsA_Num;

        public AppDurForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error during form loading: " + ex.Message);
            }
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void AppDurForm_Load(object sender, EventArgs e)
        {
            try
            {
                //panel3.BackColor = ThemeManager.RandomizeTheme();
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

                panelDT.Enabled = false;

                //labelA_Num.Text = Common.numForAnalysis;
                //callsSecsCount();
                callsSecsCountList(Common.allRecordNum);
                pcCallsSecCount.LegendLocation = LegendLocation.Top;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void callsSecsCountList(List<StandIPDR> appsSecList)
        {
            try
            {
                SeriesCollection series = new SeriesCollection();

                if (appsSecList.Count > 0)
                {

                    // Adding Call seconds of same number togather
                    var result = appsSecList.GroupBy(app => app.App)
                        .Select(gr => new TopAppCallSec(gr.Key
                        , TimeSpan.FromMilliseconds(gr.Sum(x => Convert.ToInt32(x.Dur))).ToString()
                        , gr.Sum(x => Convert.ToInt32(x.Dur))));


                    /* Aranging the list in decending order on the basis of B_NumCallSec*/
                    top5App = result.OrderByDescending(t1 => t1.AppCallMin).ToList();

                    //Console.WriteLine(top5App.First().AppCallMin);

                    gvCallsSecCount.DataSource = top5App;

                    gvCallsSecCount.Columns[0].HeaderText = "App";
                    gvCallsSecCount.Columns[1].HeaderText = "Duration";

                    gvCallsSecCount.Columns[2].Visible = false;

                    //lbListSize.Text = top5App.Count.ToString();
                    if (top5App.Count > 5)
                    {
                        foreach (var app in top5App.GetRange(0, 5))
                        {

                            series.Add(item: new PieSeries() { Title = app.App, Values = new ChartValues<long> { app.AppCallSec / 1000 }, DataLabels = true, LabelPoint = labelPoint });
                            pcCallsSecCount.Series = series;
                            
                        }
                        
                    }
                    else
                    {
                        foreach (var app in top5App)
                        {

                            series.Add(item: new PieSeries() { Title = app.App, Values = new ChartValues<long> { app.AppCallSec / 1000 }, DataLabels = true, LabelPoint = labelPoint });
                            pcCallsSecCount.Series = series;
                            data.Add(app.AppCallSec / 1000);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbSelected_Click(object sender, EventArgs e)
        {
            try
            {
                panelDT.Enabled = true;
                flpTime.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbAllData_Click(object sender, EventArgs e)
        {
            try
            {
                panelDT.Enabled = false;
                flpTime.Enabled = true;

                rbDays.Checked = false; rbMorning.Checked = false; rbEvening.Checked = false;
                // get all call records
                callsSecsCountList(Common.allRecordNum);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Sql Query to get every row from CDRTable
                DateTime startDate = Convert.ToDateTime(dtpDateFrom.Value.ToString("yyyy/MM/dd"));
                DateTime endDate = Convert.ToDateTime(dtpDateTo.Value.ToString("yyyy/MM/dd"));

                // Converting time to 24H format and removing PM, AM from it e.g 16:00:00 AM getting only first 8 char like 16:00:00
                TimeSpan startTime = Convert.ToDateTime(dtpTimeFrom.Value.ToString("HH:mm:ss tt").Substring(0, 8)).TimeOfDay;
                TimeSpan endTime = Convert.ToDateTime(dtpTimeTo.Value.ToString("HH:mm:ss tt").Substring(0, 8)).TimeOfDay;

                selectedRecordsA_Num = new List<StandIPDR>();
                selectedRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Date) >= startDate && Convert.ToDateTime(t.Date) <= endDate
                && Convert.ToDateTime(t.Time).TimeOfDay >= startTime && Convert.ToDateTime(t.Time).TimeOfDay <= endTime).ToList();

                if (selectedRecordsA_Num.Count > 0)
                {
                    callsSecsCountList(selectedRecordsA_Num);
                }
                else
                {
                    MessageBox.Show(Common.NoRecord);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            try
            {
                btnSearch.IconColor = ThemeManager.RandomizeTheme();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                btnSearch.IconColor = Color.White;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbMorning_Click(object sender, EventArgs e)
        {
            
            try
            {
                morningRecordsA_Num = new List<StandIPDR>();
                morningRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.mStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.mEnd).ToList();
                callsSecsCountList(morningRecordsA_Num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbEvening_Click(object sender, EventArgs e)
        {
            

            try
            {
                eveningRecordsA_Num = new List<StandIPDR>();
                eveningRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.eStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.eEnd).ToList();
                callsSecsCountList(eveningRecordsA_Num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbDay_Click(object sender, EventArgs e)
        {
            

            try
            {
                dayRecordsA_Num = new List<StandIPDR>();
                dayRecordsA_Num = Common.allRecordNum.Where(t => Convert.ToDateTime(t.Time).TimeOfDay >= Common.dStart
            && Convert.ToDateTime(t.Time).TimeOfDay <= Common.dEnd).ToList();
                callsSecsCountList(dayRecordsA_Num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
