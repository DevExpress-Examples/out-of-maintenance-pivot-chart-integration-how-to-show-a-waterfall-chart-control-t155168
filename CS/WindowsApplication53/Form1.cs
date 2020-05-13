using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsApplication53 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
            BindChartData();
        }

        private void BindChartData() {
            chartControl1.BoundDataChanged += ChartControl1_BoundDataChanged;
            chartControl1.DataSource = CreateIntermediateData(pivotGridControl1);
            chartControl1.SeriesDataMember = "Series";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Value");
            chartControl1.SeriesTemplate.ArgumentDataMember = "Argument";
        }

        void ChartControl1_BoundDataChanged(object sender, EventArgs e) {
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            diagram.AxisX.Label.Visible = false;
            diagram.PaneLayout.Direction = PaneLayoutDirection.Horizontal;
            diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden;
            for (int i = 0; i < chartControl1.Series.Count; i++) {
                XYDiagramPane pane = new XYDiagramPane();
                Series series = chartControl1.Series[i];
                pane.Title.Text = series.Name;
                pane.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.Panes.Add(pane);
                ((XYDiagramSeriesViewBase)series.View).Pane = pane;
                ((WaterfallSeriesView)series.View).ValueOptions.ShowTotal = true;
            }
        }

        DataTable CreateIntermediateData(PivotGridControl pivotgridControl) {
            PivotSummaryDataSource summaryDataSource = pivotGridControl1.CreateSummaryDataSource();

            DataTable intermediateDS = new DataTable();
            intermediateDS.Columns.Add("Argument", typeof(string));
            intermediateDS.Columns.Add("Series", typeof(string));
            intermediateDS.Columns.Add("Value", typeof(decimal));

            foreach (PivotSummaryDataRow record in summaryDataSource) {
                DataRow row = intermediateDS.NewRow();
                if (pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns) {
                    List<string> rowValues = new List<string>();
                    foreach (PivotGridField rowField in pivotGridControl1.GetFieldsByArea(PivotArea.RowArea))
                        rowValues.Add(record[rowField].ToString());
                    row["Series"] = string.Join("|", rowValues);

                    List<string> columnValues = new List<string>();
                    foreach (PivotGridField columnField in pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea))
                        columnValues.Add(record[columnField].ToString());
                    row["Argument"] = string.Join("|", columnValues);
                } else {
                    List<string> columnValues = new List<string>();
                    foreach (PivotGridField columnField in pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea))
                        columnValues.Add(record[columnField].ToString());
                    row["Series"] = string.Join("|", columnValues);
                    List<string> rowValues = new List<string>();
                    foreach (PivotGridField rowField in pivotGridControl1.GetFieldsByArea(PivotArea.RowArea))
                        rowValues.Add(record[rowField].ToString());
                    row["Argument"] = string.Join("|", rowValues);
                }
                row["Value"] = (decimal)record[pivotGridControl1.GetFieldByArea(PivotArea.DataArea, 0)];
                intermediateDS.Rows.Add(row);
            }
            return intermediateDS;
        }

        private void PopulateTable() {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "Product A", DateTime.Today, 7 });
            myTable.Rows.Add(new object[] { "Product A", DateTime.Today.AddDays(1), 4 });
            myTable.Rows.Add(new object[] { "Product B", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "Product B", DateTime.Today.AddDays(1), 14 });
            myTable.Rows.Add(new object[] { "Product C", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "Product C", DateTime.Today.AddDays(1), 10 });

            myTable.Rows.Add(new object[] { "Product A", DateTime.Today.AddYears(1), 4 });
            myTable.Rows.Add(new object[] { "Product A", DateTime.Today.AddYears(1).AddDays(1), 2 });
            myTable.Rows.Add(new object[] { "Product B", DateTime.Today.AddYears(1), 3 });
            myTable.Rows.Add(new object[] { "Product B", DateTime.Today.AddDays(1).AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Product C", DateTime.Today.AddYears(1), 8 });
            myTable.Rows.Add(new object[] { "Product C", DateTime.Today.AddDays(1).AddYears(1), 22 });
        }
    }
}