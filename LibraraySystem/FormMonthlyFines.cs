using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Measure;

namespace LibraraySystem
{
    public partial class FormMonthlyFines : Form
    {

        //https://github.com/Live-Charts/LiveCharts2/blob/master/samples/WinFormsSample/Bars/Basic/View.cs

        private readonly CartesianChart cartesianChart;
        public FormMonthlyFines()
        {
            InitializeComponent();
        }

        private void FormMonthlyFines_Load(object sender, EventArgs e)
        {

           
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            if(CBYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string year = CBYear.SelectedItem.ToString().Trim();
               

                DataSet ds = Fine.FindAllFinesByYear(int.Parse(year));

                if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    double[] values = new double[12];
                    var labels = new string[] {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};

                    double Jan = 0;
                    double Feb = 0;
                    double Mar = 0;
                    double Apr = 0;
                    double May = 0;
                    double Jun = 0;
                    double Jul = 0;
                    double Aug = 0;
                    double Sep = 0;
                    double Oct = 0;
                    double Nov = 0;
                    double Dec = 0;

                    foreach(DataRow row in ds.Tables[0].Rows)
                    {


                        string date = row["FINEDATE"].ToString();
                        string amount = row["AMOUNT"].ToString();



                        DateTime Tdate = DateTime.Parse(date);
                        double Damount= Convert.ToDouble(amount);

                        if(Tdate.Month == 1)
                        {
                            Jan += Damount;
                        }

                        if(Tdate.Month == 2)
                        {
                            Feb += Damount;
                        }

                        if(Tdate.Month == 3)
                        {
                            Mar += Damount;
                        }

                        if (Tdate.Month == 4)
                        {
                            Apr += Damount;
                        }

                        if (Tdate.Month == 5)
                        {
                            May += Damount;
                        }

                        if (Tdate.Month == 6)
                        {
                            Jun += Damount;
                        }

                        if (Tdate.Month == 7)
                        {
                            Jul += Damount;
                        }

                        if (Tdate.Month == 8)
                        {
                            Aug += Damount;
                        }

                        if (Tdate.Month == 9)
                        {
                            Sep += Damount;
                        }

                        if (Tdate.Month == 10)
                        {
                            Oct += Damount;
                        }

                        if (Tdate.Month == 11)
                        {
                            Nov += Damount;
                        }

                        if (Tdate.Month == 12)
                        {
                            Dec += Damount;
                        }

                        

                    }

                    values[0] = Jan;
                    values[1] = Feb;
                    values[2] = Mar;
                    values[3] = Apr;
                    values[4] = May;
                    values[5] = Jun;
                    values[6] = Jul;
                    values[7] = Aug;
                    values[8] = Sep;
                    values[9] = Oct;
                    values[10] = Nov;
                    values[11] = Dec;

                    var series = new ISeries[]
                    {
                        new ColumnSeries<double> { Name = "Monthly Fines for " + CBYear.SelectedItem.ToString(), Values = values },

                    };

                    var xAxis = new Axis
                    {
                        Labels = labels,
                        LabelsRotation = 0,
                        SeparatorsPaint = new LiveChartsCore.SkiaSharpView.Painting.SolidColorPaint(new SKColor(200, 200, 200)),
                        SeparatorsAtCenter = false,
                        TicksPaint = new LiveChartsCore.SkiaSharpView.Painting.SolidColorPaint(new SKColor(35, 35, 35)),
                        TicksAtCenter = true,
                        MinStep = 1,
                        ForceStepToMin = true
                    };

                    var cartesianChart = new CartesianChart
                    {
                        Series = series,
                        XAxes = [xAxis],
                        LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
                        Location = new System.Drawing.Point(0, 0),
                        Dock = DockStyle.Fill


                    };

                    Controls.Add(cartesianChart);





                }
                else
                {
                    MessageBox.Show("No Data Found","No Data",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
