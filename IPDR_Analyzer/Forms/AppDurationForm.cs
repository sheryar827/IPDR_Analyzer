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
    public partial class AppDurationForm : Form
    {
        List<TopAppCallSec> top5App = null;
        List<StandIPDR> selectedRecordsA_Num, morningRecordsA_Num, dayRecordsA_Num, eveningRecordsA_Num;

        public AppDurationForm()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void AppDurationForm_Load(object sender, EventArgs e)
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

            panelDT.Enabled = false;

            labelA_Num.Text = Common.numForAnalysis;
            //callsSecsCount();
            callsSecsCountList(Common.allRecordNum);
            pcCallsSecCount.LegendLocation = LegendLocation.Top;
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

                    lbListSize.Text = top5App.Count.ToString();
                    if (top5App.Count > 5)
                    {
                        foreach (var app in top5App.GetRange(0, 5))
                        {

                            series.Add(item: new PieSeries() { Title = app.App, Values = new ChartValues<long> { app.AppCallSec/1000 }, DataLabels = true, LabelPoint = labelPoint });
                            pcCallsSecCount.Series = series;
                        }
                    }
                    else
                    {
                        foreach (var app in top5App)
                        {

                            series.Add(item: new PieSeries() { Title = app.App, Values = new ChartValues<long> { app.AppCallSec/1000 }, DataLabels = true, LabelPoint = labelPoint });
                            pcCallsSecCount.Series = series;
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
            panelDT.Enabled = true;
            flpTime.Enabled = false;
        }

        private void rbAllData_Click(object sender, EventArgs e)
        {
            panelDT.Enabled = false;
            flpTime.Enabled = true;

            rbDay.Checked = false; rbMorning.Checked = false; rbEvening.Checked = false;
            // get all call records
            callsSecsCountList(Common.allRecordNum);
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            try
            {
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

        private void rbMorning_Click(object sender, EventArgs e)
        {
            morningRecordsA_Num = new List<StandIPDR>();
            try
            {
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
            eveningRecordsA_Num = new List<StandIPDR>();

            try
            {
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
            dayRecordsA_Num = new List<StandIPDR>();

            try
            {
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
