Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
			BindChartData()
		End Sub

		Private Sub BindChartData()
			AddHandler chartControl1.BoundDataChanged, AddressOf ChartControl1_BoundDataChanged
			chartControl1.DataSource = CreateIntermediateData(pivotGridControl1)
			chartControl1.SeriesDataMember = "Series"
			chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Value")
			chartControl1.SeriesTemplate.ArgumentDataMember = "Argument"
		End Sub

		Private Sub ChartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)
			diagram.AxisX.Label.Visible = False
			diagram.PaneLayout.Direction = PaneLayoutDirection.Horizontal
			diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden
			For i As Integer = 0 To chartControl1.Series.Count - 1
				Dim pane As New XYDiagramPane()
				Dim series As Series = chartControl1.Series(i)
				pane.Title.Text = series.Name
				pane.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
				diagram.Panes.Add(pane)
				CType(series.View, XYDiagramSeriesViewBase).Pane = pane
				CType(series.View, WaterfallSeriesView).ValueOptions.ShowTotal = True
			Next i
		End Sub

		Private Function CreateIntermediateData(ByVal pivotgridControl As PivotGridControl) As DataTable
			Dim summaryDataSource As PivotSummaryDataSource = pivotGridControl1.CreateSummaryDataSource()

			Dim intermediateDS As New DataTable()
			intermediateDS.Columns.Add("Argument", GetType(String))
			intermediateDS.Columns.Add("Series", GetType(String))
			intermediateDS.Columns.Add("Value", GetType(Decimal))

			For Each record As PivotSummaryDataRow In summaryDataSource
				Dim row As DataRow = intermediateDS.NewRow()
				If pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns Then
					Dim rowValues As New List(Of String)()
					For Each rowField As PivotGridField In pivotGridControl1.GetFieldsByArea(PivotArea.RowArea)
						rowValues.Add(record(rowField).ToString())
					Next rowField
					row("Series") = String.Join("|", rowValues)

					Dim columnValues As New List(Of String)()
					For Each columnField As PivotGridField In pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea)
						columnValues.Add(record(columnField).ToString())
					Next columnField
					row("Argument") = String.Join("|", columnValues)
				Else
					Dim columnValues As New List(Of String)()
					For Each columnField As PivotGridField In pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea)
						columnValues.Add(record(columnField).ToString())
					Next columnField
					row("Series") = String.Join("|", columnValues)
					Dim rowValues As New List(Of String)()
					For Each rowField As PivotGridField In pivotGridControl1.GetFieldsByArea(PivotArea.RowArea)
						rowValues.Add(record(rowField).ToString())
					Next rowField
					row("Argument") = String.Join("|", rowValues)
				End If
				row("Value") = CDec(record(pivotGridControl1.GetFieldByArea(PivotArea.DataArea, 0)))
				intermediateDS.Rows.Add(row)
			Next record
			Return intermediateDS
		End Function

		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "Product A", DateTime.Today, 7 })
			myTable.Rows.Add(New Object() { "Product A", DateTime.Today.AddDays(1), 4 })
			myTable.Rows.Add(New Object() { "Product B", DateTime.Today, 12 })
			myTable.Rows.Add(New Object() { "Product B", DateTime.Today.AddDays(1), 14 })
			myTable.Rows.Add(New Object() { "Product C", DateTime.Today, 11 })
			myTable.Rows.Add(New Object() { "Product C", DateTime.Today.AddDays(1), 10 })

			myTable.Rows.Add(New Object() { "Product A", DateTime.Today.AddYears(1), 4 })
			myTable.Rows.Add(New Object() { "Product A", DateTime.Today.AddYears(1).AddDays(1), 2 })
			myTable.Rows.Add(New Object() { "Product B", DateTime.Today.AddYears(1), 3 })
			myTable.Rows.Add(New Object() { "Product B", DateTime.Today.AddDays(1).AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Product C", DateTime.Today.AddYears(1), 8 })
			myTable.Rows.Add(New Object() { "Product C", DateTime.Today.AddDays(1).AddYears(1), 22 })
		End Sub
	End Class
End Namespace