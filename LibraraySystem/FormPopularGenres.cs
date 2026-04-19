using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Measure;
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
using System.Windows.Forms;

namespace LibraraySystem
{
    public partial class FormPopularGenres : Form
    {
        /*private readonly CartesianChart cartesianChart;
        private readonly PieChart pieChart;*/

        /*private readonly PieChart pieChart;
        private readonly Random _random = new();*/

        //public readonly PieChart Chart;
        private readonly PieChart pieChart;
        public FormPopularGenres()
        {
            InitializeComponent();


        }

        private void FormPopularGenres_Load(object sender, EventArgs e)
        {
            //https://ourcodeworld.com/articles/read/583/how-to-create-a-pie-chart-using-the-livecharts-library-in-winforms-c-sharp
            //https://github.com/Live-Charts/LiveCharts2/tree/master/samples/WinFormsSample/Pies

            DataSet ds = Genres.popularGenres();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                var seriresList = new List<ISeries>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    string desc = row["GENREDESC"].ToString();
                    double total = Convert.ToDouble(row["TOTAL"]);

                    seriresList.Add(new PieSeries<double>
                    {
                        Name = desc,
                        Values = new[] { total },
                        DataLabelsSize = 14,
                        DataLabelsFormatter = point => total.ToString()

                    });
                }

                var pieChart = new PieChart()
                {
                    Dock = DockStyle.Fill,
                    LegendPosition = LegendPosition.Right,
                    Series = seriresList.ToArray(),
                    
                };

                Controls.Add(pieChart);
            }
            else
            {
                MessageBox.Show("No Data Found","No Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }
    }
}
