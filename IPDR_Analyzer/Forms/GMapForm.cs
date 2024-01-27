using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IPDR_Analyzer.Classes;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace IPDR_Analyzer.Forms
{
    public partial class GMapForm : Form
    {
        
        private DataTable dataTable = null;
        int isSetPoint;  //Set the start and end points, 1 is the start point, 2 is the end point
        GMapOverlay markers;
        GMapOverlay markerStart;
        GMapOverlay markerEnd;
        PointLatLng startPoint;
        PointLatLng endPoint;
        List<StandIPDR> allLocRecordA_Num = new List<StandIPDR>();
        List<StandIPDR> commonLatLngList = new List<StandIPDR>();
        List<StandIPDR> allRecordNum = new List<StandIPDR>();


        GMapOverlay routes;

        bool zoom = false;
        /*bool distance = false;*/
        bool route = false;
        bool locDetails = false;
        public GMapForm()
        {
            InitializeComponent();

            routes = new GMapOverlay("routes");
        }

        private void plotMarkers(string A_Num
           , string project_Name
           , List<PointLatLng> _points
           , Color selectedColor)
        {
            gMap.DragButton = MouseButtons.Left;
            markers = new GMapOverlay("markers");
            
            foreach (PointLatLng point in _points)
            {
                //PointLatLng point = new PointLatLng(lat, lng);

                //Bitmap bmpMarker = (Bitmap)Image.FromFile("img/location.png");

                /*GMapMarker marker = new GMarkerGoogle(point, bmpMarker);*/

                //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);
                //marker.IsVisible = true;

                Bitmap markerBitmap = CreateCustomMarkerBitmap(selectedColor, new Size(40, 40)); // Customize size as needed

                GMapMarker marker = new GMarkerGoogle(point, markerBitmap);

                marker.ToolTipMode = MarkerTooltipMode.Always;
                /* marker.Tag = point.Lat.ToString() + " " + point.Lng.ToString();
                 marker.ToolTipText = point.Lat.ToString() + " " + point.Lng.ToString();*/

                marker.Tag = project_Name;
                marker.ToolTipText = A_Num + " " + project_Name;

                /*marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;*/

                //2. Add all available markers to that Overlay
                markers.Markers.Add(marker);
                //3. Cover map with Overlay

            }


            gMap.Overlays.Add(markers);
        }

        private Bitmap CreateCustomMarkerBitmap(Color color, Size size)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Antialiasing to smooth the shape
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Define the size of the circle
                int circleDiameter = size.Height / 2;
                Rectangle circleRect = new Rectangle(size.Width / 2 - circleDiameter / 2, 0, circleDiameter, circleDiameter);

                // Draw the circle (head of the marker)
                g.FillEllipse(new SolidBrush(color), circleRect);

                // Define the points for the triangle (tail of the marker)
                PointF topPoint = new PointF(size.Width / 2, circleDiameter);
                PointF leftPoint = new PointF(size.Width / 2 - circleDiameter / 2, size.Height);
                PointF rightPoint = new PointF(size.Width / 2 + circleDiameter / 2, size.Height);

                PointF[] trianglePoints = { topPoint, leftPoint, rightPoint };

                // Draw the triangle
                g.FillPolygon(new SolidBrush(color), trianglePoints);
            }
            return bmp;
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            
            //gMap.CacheLocation = Application.StartupPath + @"\MAP\"; //Reset the default cache location (the default cache problem of Grandpa and Dog Thief, a waste of labor and youth for a day)
            gMap.CacheLocation = @"cache";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            
            gMap.ShowCenter = false;
            gMap.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble("32.71086");
            double lng = Convert.ToDouble("73.93865");
            gMap.Position = new PointLatLng(lat, lng);
            gMap.MinZoom = 5;
            gMap.MaxZoom = 100;
            gMap.Zoom = 5;

            getProjectNum();

        }

        private async void getProjectNum()
        {

            try
            {
                string proc = "exec dbo.Projects_View";
                DataTable dataTable = await CommonMethods.getRecords(proc);

                DataTable allRecord = new DataTable();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    // Stored Procedure only getting project table records not general police table records
                    string proce = "exec dbo.ProjectsTableA_Num_View '" + Common.userName + "', '" + dataTable.Rows[i].Field<int>("projectId") + "', '" + dataTable.Rows[i].Field<string>("project") + "'";
                    allRecord.Merge(await CommonMethods.getRecords(proce));
                }


                gvProjectNum.DataSource = allRecord;
                gvProjectNum.Columns[0].HeaderText = "Project";
                gvProjectNum.Columns[1].HeaderText = "A Party";

                // Hiding id column only using for arranging CDRs in
                // descending order
                gvProjectNum.Columns[2].Visible = false;

                // Arranging CDRs A_Num in descending order on the basis
                // of id
                gvProjectNum.Sort(this.gvProjectNum.Columns["Id"], ListSortDirection.Descending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private static bool IsValidPoint(PointLatLng point)
        {
            // Example criteria: point is invalid if both latitude and longitude are 0
            return !(point.Lat == 0 && point.Lng == 0);
        }

        private async void gvProjectNum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                List<PointLatLng> _points = new List<PointLatLng>();
                string a_numForAnalysis = gvProjectNum.Rows[e.RowIndex].Cells[1].Value.ToString();
                string project_Name = gvProjectNum.Rows[e.RowIndex].Cells[0].Value.ToString();
                Color selectColor = Color.Red;

                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectColor = colorDialog.Color;
                    }
                }


                CurrencyManager cm = (CurrencyManager)BindingContext[gvProjectNum.DataSource];
                cm.SuspendBinding();
                gvProjectNum.Rows[e.RowIndex].Visible = false;
                cm.ResumeBinding();

                string spGetAllRecords = "exec dbo.GET_ALL_RECORD_NUM '" + a_numForAnalysis + "', '" + project_Name + "'";

                DataTable dt = new DataTable();

                dt = await CommonMethods.getRecords(spGetAllRecords);

                Console.WriteLine(dt.Rows.Count);

                try
                {
                    if (dt.Columns.Count > 0)
                    {
                        allRecordNum = new List<StandIPDR>();



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

                            allLocRecordA_Num.Add(record);
                            
                            

                            PointLatLng getLatLngForMap = new PointLatLng(record.Latitude
                                , record.Longitude);

                            _points.Add(getLatLngForMap);
                        }
                    }

                    

                    List<PointLatLng> uniquePointLst = _points.Distinct().ToList();

                    // Filter out invalid points. Define your own criteria for invalidity
                    uniquePointLst = uniquePointLst.Where(p => IsValidPoint(p)).ToList();

                    plotMarkers(a_numForAnalysis, project_Name, uniquePointLst, selectColor);

                    allLocRecordA_Num = allLocRecordA_Num.OrderBy(x => x.Date).Distinct().ToList();

                    //get start date from datatable
                    string sd = allLocRecordA_Num.First().Date.ToString();


                    //getting end date from datatable
                    string ed = allLocRecordA_Num.Last().Date.ToString();

                    txtDateLimit.Text = $"{sd.Split(' ').First()} - {ed.Split(' ').First()}";

                    DatePickerStartDate.Value = DateTime.Parse(sd).Date;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
 
            }
        }

        private void gMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (locDetails)
            {
                /*var latlngRecord = FilterBySpecificCoordinates(commonLatLngList
                    , item.Position.Lat.ToString()
                    , item.Position.Lng.ToString());*/

                var matchingRecords = allLocRecordA_Num.Where(r => r.Latitude == item.Position.Lat && r.Longitude == item.Position.Lng).ToList();

                //matchingRecords = matchingRecords.OrderByDescending(cs => cs.Number).ThenBy(cs => cs.Time).ToList();

                var groupedData = matchingRecords.GroupBy(
                n => new { n.Number, n.Date, LatLong = new { n.Latitude, n.Longitude }}
                ).Select(g => new
                {
                    g.Key.Number,
                    g.Key.Date,
                    g.Key.LatLong,
                    StartTime = g.Min(n => n.Time),
                    EndTime = g.Max(n => n.Time),
                    Duration = g.Max(n => TimeSpan.Parse(n.Time)) - g.Min(n => TimeSpan.Parse(n.Time)) // Calculate the duration
                });

                //var specificLatLngDT = new ListtoDataTable().ToDataTable(groupedData);

                var timeOverLap = new List<TimeOverLap>();

                foreach (var group in groupedData)
                {
                    var to = new TimeOverLap(group.Number, group.Date, group.StartTime, group.EndTime, group.Duration.ToString(), group.LatLong.Latitude, group.LatLong.Longitude);

                    timeOverLap.Add(to);
                    //Console.WriteLine($"Number: {group.Number}, LatLong: ({group.LatLong.Latitude}, {group.LatLong.Longitude}), Start Time: {group.StartTime}, End Time: {group.EndTime}");
                }

                new CommonLocDetailsForm(new ListtoDataTable().ToDataTable(timeOverLap), matchingRecords).Show();
                
            }
        }

        private void btnLocDetails_Click(object sender, EventArgs e)
        {
            if (locDetails == false)
            {
                locDetails = true;
                zoom = false;
                route = false;
                btnLocDetails.FlatAppearance.BorderSize = 1;
            }

            else
            {
                locDetails = false;
                btnLocDetails.FlatAppearance.BorderSize = 0;
            }
        }

        /*private void btnExtract_Click(object sender, EventArgs e)
        {
            // Sql Query to get every row from CDRTable
            DateTime startDate = DatePickerStartDate.Value.Date;

            
            var dateExtLatLngList = new List<StandIPDR>();
            dateExtLatLngList = allLocRecordA_Num.Where(record => DateTime.Parse(record.Date).Date == startDate).ToList();
            foreach (StandIPDR record in dateExtLatLngList)
            {
                Console.WriteLine($"Date: {record.Date}");
                // You can add more fields as needed
            }
            plotExtractedLatLng(dateExtLatLngList);
        }*/
    }
}
