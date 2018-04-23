Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraCharts.Native
Imports System.Collections

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
			BindChartData()
		End Sub

		Private Sub BindChartData()
			chartControl1.DataSource = CreateIntermediateData(pivotGridControl1)
			chartControl1.SeriesDataMember = "Series"
			chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Value1", "Value2")
			chartControl1.SeriesTemplate.ArgumentDataMember = "Argument"
		End Sub

		Private Function CreateIntermediateData(ByVal pivotgridControl As PivotGridControl) As DataTable
			Dim summaryDataSource As PivotSummaryDataSource = pivotGridControl1.CreateSummaryDataSource()

			Dim intermediateDS As New DataTable()
			intermediateDS.Columns.Add("Argument", GetType(String))
			intermediateDS.Columns.Add("Series", GetType(String))
			intermediateDS.Columns.Add("Value1", GetType(Decimal))
			intermediateDS.Columns.Add("Value2", GetType(Decimal))

			Dim prevArgument As String = String.Empty
			Dim sum As Decimal = 0
			For Each record As PivotSummaryDataRow In summaryDataSource
				Dim row As DataRow = intermediateDS.NewRow()
				If pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns Then
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

				Else
					Dim columnValues As New List(Of String)()
					For Each columnField As PivotGridField In pivotGridControl1.GetFieldsByArea(PivotArea.ColumnArea)
						columnValues.Add(record(columnField).ToString())
					Next columnField
					row("Argument") = String.Join("|", columnValues)
					Dim rowValues As New List(Of String)()
					For Each rowField As PivotGridField In pivotGridControl1.GetFieldsByArea(PivotArea.RowArea)
						rowValues.Add(record(rowField).ToString())
					Next rowField
					row("Series") = String.Join("|", rowValues)

				End If

				If prevArgument <> row("Argument").ToString() Then
					prevArgument = row("Argument").ToString()
					sum = 0
				End If
				row("Value1") = sum
				sum += CDec(record(pivotGridControl1.GetFieldByArea(PivotArea.DataArea, 0)))
				row("Value2") = sum
				intermediateDS.Rows.Add(row)
			Next record
			Return intermediateDS
		End Function

		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today, 7 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(1), 4 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 12 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1), 14 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 11 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1), 10 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1), 4 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddYears(1), 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddYears(1), 8 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 })
		End Sub


	End Class
End Namespace