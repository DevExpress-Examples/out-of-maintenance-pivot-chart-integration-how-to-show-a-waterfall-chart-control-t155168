using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraCharts.Native;
using System.Collections;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
            BindChartData();
        }

        private void BindChartData()
        {
            chartControl1.DataSource = CreateIntermediateData(pivotGridControl1);
            chartControl1.SeriesDataMember = "Series";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Value1", "Value2");
            chartControl1.SeriesTemplate.ArgumentDataMember = "Argument";
        }

        DataTable CreateIntermediateData(PivotGridControl pivotgridControl)
        {
            PivotSummaryDataSource summaryDataSource = pivotGridControl1.CreateSummaryDataSource();

            DataTable intermediateDS = new DataTable();
            intermediateDS.Columns.Add("Argument", typeof(string));
            intermediateDS.Columns.Add("Series", typeof(string));
            intermediateDS.Columns.Add("Value1", typeof(decimal));
            intermediateDS.Columns.Add("Value2", typeof(decimal));

            string prevArgument = string.Empty;
            decimal sum = 0;
            foreach (PivotSummaryDataRow record in summaryDataSource)
            {
                DataRow row = intermediateDS.NewRow();
                if (pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns)
                {
                    List<string> columnValues = new List<string>();
                    foreach (PivotGridField columnField in pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea))
                        columnValues.Add(record[columnField].ToString());
                    row["Series"] = string.Join("|", columnValues);
                    List<string> rowValues = new List<string>();
                    foreach (PivotGridField rowField in pivotGridControl1.GetFieldsByArea(PivotArea.RowArea))
                        rowValues.Add(record[rowField].ToString());
                    row["Argument"] = string.Join("|", rowValues);

                }
                else
                {
                    List<string> columnValues = new List<string>();
                    foreach (PivotGridField columnField in pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea))
                        columnValues.Add(record[columnField].ToString());
                    row["Argument"] = string.Join("|", columnValues);
                    List<string> rowValues = new List<string>();
                    foreach (PivotGridField rowField in pivotGridControl1.GetFieldsByArea(PivotArea.RowArea))
                        rowValues.Add(record[rowField].ToString());
                    row["Series"] = string.Join("|", rowValues);

                }

                if (prevArgument != row["Argument"].ToString())
                {
                    prevArgument = row["Argument"].ToString();
                    sum = 0;
                }
                row["Value1"] = sum;
                sum += (decimal)record[pivotGridControl1.GetFieldByArea(PivotArea.DataArea, 0)];
                row["Value2"] = sum;
                intermediateDS.Rows.Add(row);
            }
            return intermediateDS;
        }

        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today, 7 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 4 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 14 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 10 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 4 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 8 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 });
        }


    }
}