using FoundationLibrary.TransformSignal;
using NetManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OnlineTask
{
    public partial class Form1 : Form
    {
        readonly Label[] labels;
        readonly LinkedList<double>[] channels = new LinkedList<double>[4];
        readonly int[] channelsInd = { 4};
        readonly int sampleRate = 1000;
        readonly int freqFrom = 8;
        readonly int freqTo = 12;
        readonly int window;
        int direction = 0;

        private bool buttonClicked = false;
        private double midle = 100;
        private List<double> spms = new List<double>();

        public Form1()
        {
            InitializeComponent();
            labels = new Label[] { labelO1};
            window = (int)(24 * Math.Ceiling(sampleRate / 24.0));
            for (int i = 0; i < channels.Length; i++)
            {
                channels[i] = new LinkedList<double>();
            }
            InitChart();
            reseiveClientControl.Client.Reseive += Client_Reseive;
            reseiveClientControl.Client.Error += Client_Error;
            System.Timers.Timer timer = new System.Timers.Timer(5);
            timer.Elapsed += Timer_Elapsed; ;
            timer.AutoReset = true;
            timer.Enabled = true;
            
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (reseiveClientControl.Client.IsRunning)
            {
                if (buttonClicked == true)
                {
                    System.Windows.Forms.Cursor.Position = new Point(
                        System.Windows.Forms.Cursor.Position.X + 5 * direction,
                        System.Windows.Forms.Cursor.Position.Y);
                }
            }
        }

        private void InitChart()
        {
            var title = new Title("ЭЭГ")
            {
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            chart.Titles.Add(title);
            chart.Legends.Clear();
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            String[] name = { "O1"};
            ChartArea chartArea = new ChartArea(name[0])
            {
                Position = new ElementPosition(0, 0 * 23 + 5, 100, 60)
            };
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = window;
            chartArea.CursorX.AutoScroll = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(new Legend(name[0]) { DockedToChartArea = name[0], Docking = Docking.Right });
            chart.Series.Add(new Series() { ChartArea = name[0], Legend = name[0], LegendText = name[0] });
            chart.Series[0].ChartType = SeriesChartType.FastLine;
            
        }

        private void Client_Error(object sender, EventMsgArgs e)
        {
            MessageBox.Show(e.Msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Client_Reseive(object sender, EventClientMsgArgs e)
        {
            Frame frame = new Frame(e.Msg);

            for (int j = 0; j < 24; j++)
            {
                double y = Convert.ToDouble(frame.Data[channelsInd[0] * 24 + j]);
                channels[0].AddLast(y);
            }
            while (channels[0].Count > window)
            {
                channels[0].RemoveFirst();
            }
            chart.Series[0].Points.DataBindY(channels[0]);
            
            if (channels[0].Count == window)
            {
                double[] sum = new double[4];

                double[] data = channels[0].ToArray();
                Trend.SubtractionTrend(data);
                alglib.fftr1d(data, out alglib.complex[] fur);
                int from = freqFrom * window / sampleRate;
                int to = freqTo * window / sampleRate;
                for (int j = from; j <= to; j++)
                {
                    sum[0] += fur[j].x * fur[j].x + fur[j].y * fur[j].y;
                }
                labels[0].Text = sum[0].ToString("0.##");
                spms.Add(sum[0]);
                double leftAvg = (sum[0] + sum[1]) / 2;               
                double k = leftAvg ;

                if ((sum[0] - midle) < 100)
                {
                    direction = -1;
                    labelDir.Text = "←";
                }
                else if ((sum[0] - midle) > 100)
                {
                    direction = 1;
                    labelDir.Text = "→";
                }
                else
                {
                    direction = 0;
                    labelDir.Text = "-";
                }           
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(5000); 

            List<double> spmsLast = spms.Skip(spms.Count - 100).ToList();

            double maxVal = spmsLast.Max();
            double minVal = spmsLast.Min();
            midle = (maxVal - minVal) / 2.0;

            labelL.Text = midle.ToString(); 
        }


        private void Button_Click(object sender, EventArgs e)
        {
            if (!reseiveClientControl.Client.IsRunning)
            {
                reseiveClientControl.Client.StartClient();
                reseiveClientControl.Enabled = false;
                button.Text = "Стоп";
            }
            else
            {
                reseiveClientControl.Client.StopClient();
                reseiveClientControl.Enabled = true;
                button.Text = "Старт";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelC3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClicked = false;
        }

        

        private void labelL_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
