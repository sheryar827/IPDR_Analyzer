using IPDR_Analyzer.Classes;
using LiveCharts.Wpf;
using LiveCharts;
using System;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace IPDR_Analyzer.Forms
{
    public partial class BasicConversationInfoForm : Form
    {
        public BasicConversationInfoForm()
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization error: " + ex.Message);
            }

        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);



        private void activeQtr()
        {
            try
            {
                lbQTR1Voice.Text = GetQTR("08:00:00", "15:59:59").ToString();

                lbQTR2Voice.Text = GetQTR("16:00:00", "23:59:59").ToString();

                lbQTR3Voice.Text = GetQTR("00:00:00", "7:59:59").ToString();

                /*lbQTR4Voice.Text = GetQTR("Voice", "00:00:00", "05:59:59").ToString();
                lbQTR4Sms.Text = GetQTR("SMS", "00:00:00", "05:59:59").ToString();*/
                List<GetBasicConversation> getBasicConversations = new List<GetBasicConversation>();
                getBasicConversations.Add(new GetBasicConversation("08:00:00 To 15:59:59", Convert.ToInt32(lbQTR1Voice.Text.ToString())));

                getBasicConversations.Add(new GetBasicConversation("16:00:00 To 23:59:59", Convert.ToInt32(lbQTR2Voice.Text.ToString())));


                getBasicConversations.Add(new GetBasicConversation("00:00:00 To 7:59:59", Convert.ToInt32(lbQTR3Voice.Text.ToString())));



                SeriesCollection series = new SeriesCollection();

                foreach (var aq in getBasicConversations)
                {
                    series.Add(item: new PieSeries() { Title = aq.BasicConversation, Values = new ChartValues<int> { aq.BasicConversationCount }, DataLabels = true, LabelPoint = labelPoint });
                    pcbasicConver.Series = series;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in activeQtr: " + ex.Message);
            }

        }

        private Int32 GetQTR(string T1, string T2)
        {

            try
            {
                Int32 a = Common.allRecordNum.Where(x => Convert.ToDateTime(x.Time).TimeOfDay >= Convert.ToDateTime(T1).TimeOfDay
                    && Convert.ToDateTime(x.Time).TimeOfDay <= Convert.ToDateTime(T2).TimeOfDay).Count();
                // return count to function from where GetQTR is called
                return a;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in GetQTR: " + ex.Message);
                return 0;
            }

        }

        private void daysAnalyz()
        {
            try
            {
                string countQry = null;

                // counting calls on Sunday
                lbCallsSun.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Sunday")).Count().ToString();

                lbCallsMon.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Monday")).Count().ToString();

                lbCallsTue.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Tuesday")).Count().ToString();

                lbCallsWed.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Wednesday")).Count().ToString();

                lbCallsThu.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Thursday")).Count().ToString();

                lbCallsFri.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Friday")).Count().ToString();

                lbCallsSat.Text = Common.allRecordNum.Where(x => x.Weekday.Equals("Saturday")).Count().ToString();




                List<GetBasicConversation> getBasicConversations = new List<GetBasicConversation>();

                // Adding Calls and SMS then displaying results
                getBasicConversations.Add(new GetBasicConversation("Sun", Convert.ToInt32(lbCallsSun.Text.ToString())));
                getBasicConversations.Add(new GetBasicConversation("Mon", Convert.ToInt32(lbCallsMon.Text.ToString())));
                getBasicConversations.Add(new GetBasicConversation("Tue", Convert.ToInt32(lbCallsTue.Text.ToString())));
                getBasicConversations.Add(new GetBasicConversation("Wed", Convert.ToInt32(lbCallsWed.Text.ToString())));
                getBasicConversations.Add(new GetBasicConversation("Thu", Convert.ToInt32(lbCallsThu.Text.ToString())));
                getBasicConversations.Add(new GetBasicConversation("Fri", Convert.ToInt32(lbCallsFri.Text.ToString())));
                getBasicConversations.Add(new GetBasicConversation("Sat", Convert.ToInt32(lbCallsSat.Text.ToString())));


                SeriesCollection series = new SeriesCollection();

                foreach (var aq in getBasicConversations)
                {
                    series.Add(item: new PieSeries() { Title = aq.BasicConversation, Values = new ChartValues<int> { aq.BasicConversationCount }, DataLabels = true, LabelPoint = labelPoint });
                    pcbasicConver.Series = series;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in daysAnalyz: " + ex.Message);
            }
        }

        private void BasicConversationInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                panel1.BackColor = ThemeManager.RandomizeTheme();
                panel3.BackColor = ThemeManager.RandomizeTheme();
                panelActiveThirds.BackColor = ThemeManager.RandomizeTheme();
                panelWeekDays.BackColor = ThemeManager.RandomizeTheme();
                daysAnalyz();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error during form loading: " + ex.Message);
            }
        }

        private void gbWeekDays_MouseHover(object sender, EventArgs e)
        {
            try
            {
                daysAnalyz();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error on mouse hover in gbWeekDays: " + ex.Message);
            }
        }

        private void gbActiveThirds_MouseHover(object sender, EventArgs e)
        {
            try
            {
                activeQtr();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error on mouse hover in gbActiveThirds: " + ex.Message);
            }
        }

        

    }
}
