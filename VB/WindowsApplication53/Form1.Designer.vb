Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication53
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim sideBySideRangeBarSeriesView1 As New DevExpress.XtraCharts.SideBySideRangeBarSeriesView()
			Dim chartControlCommandGalleryItemGroup2DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem1 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem1 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem1 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem1 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim createNestedDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem1 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem1 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem1 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim skinPaddingEdges1 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges2 As New DevExpress.Skins.SkinPaddingEdges()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.fiedName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.chartTypeBar1 = New DevExpress.XtraCharts.UI.ChartTypeBar()
			Me.createBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
			Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
			Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createPieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
			Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
			Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
			Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
			Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.chartAppearanceBar1 = New DevExpress.XtraCharts.UI.ChartAppearanceBar()
			Me.changePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
			Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.changeAppearanceGalleryBaseBarManagerItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem()
			Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.chartWizardBar1 = New DevExpress.XtraCharts.UI.ChartWizardBar()
			Me.runWizardChartItem1 = New DevExpress.XtraCharts.UI.RunWizardChartItem()
			Me.chartTemplatesBar1 = New DevExpress.XtraCharts.UI.ChartTemplatesBar()
			Me.saveAsTemplateChartItem1 = New DevExpress.XtraCharts.UI.SaveAsTemplateChartItem()
			Me.loadTemplateChartItem1 = New DevExpress.XtraCharts.UI.LoadTemplateChartItem()
			Me.chartPrintExportBar1 = New DevExpress.XtraCharts.UI.ChartPrintExportBar()
			Me.printPreviewChartItem1 = New DevExpress.XtraCharts.UI.PrintPreviewChartItem()
			Me.printChartItem1 = New DevExpress.XtraCharts.UI.PrintChartItem()
			Me.createExportBaseItem1 = New DevExpress.XtraCharts.UI.CreateExportBaseItem()
			Me.exportToPDFChartItem1 = New DevExpress.XtraCharts.UI.ExportToPDFChartItem()
			Me.exportToHTMLChartItem1 = New DevExpress.XtraCharts.UI.ExportToHTMLChartItem()
			Me.exportToMHTChartItem1 = New DevExpress.XtraCharts.UI.ExportToMHTChartItem()
			Me.exportToXLSChartItem1 = New DevExpress.XtraCharts.UI.ExportToXLSChartItem()
			Me.exportToXLSXChartItem1 = New DevExpress.XtraCharts.UI.ExportToXLSXChartItem()
			Me.exportToRTFChartItem1 = New DevExpress.XtraCharts.UI.ExportToRTFChartItem()
			Me.createExportToImageBaseItem1 = New DevExpress.XtraCharts.UI.CreateExportToImageBaseItem()
			Me.exportToBMPChartItem1 = New DevExpress.XtraCharts.UI.ExportToBMPChartItem()
			Me.exportToGIFChartItem1 = New DevExpress.XtraCharts.UI.ExportToGIFChartItem()
			Me.exportToJPEGChartItem1 = New DevExpress.XtraCharts.UI.ExportToJPEGChartItem()
			Me.exportToPNGChartItem1 = New DevExpress.XtraCharts.UI.ExportToPNGChartItem()
			Me.exportToTIFFChartItem1 = New DevExpress.XtraCharts.UI.ExportToTIFFChartItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.chartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "Data"
			Me.pivotGridControl1.DataSource = Me.dataSet1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fiedName, Me.fieldDate, Me.fieldValue, Me.fieldValue1, Me.fieldValue2, Me.fieldDate1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
			Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(443, 431)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomChartDataSourceData += New DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(Me.pivotGridControl1_CustomChartDataSourceData);
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Data"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Date"
			Me.dataColumn2.DataType = GetType(System.DateTime)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Value"
			Me.dataColumn3.DataType = GetType(Decimal)
			' 
			' fiedName
			' 
			Me.fiedName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fiedName.AreaIndex = 0
			Me.fiedName.FieldName = "Name"
			Me.fiedName.Name = "fiedName"
			' 
			' fieldDate
			' 
			Me.fieldDate.AreaIndex = 0
			Me.fieldDate.Caption = "Year"
			Me.fieldDate.FieldName = "Date"
			Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldDate.Name = "fieldDate"
			Me.fieldDate.UnboundFieldName = "fieldDate"
			' 
			' fieldValue
			' 
			Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldValue.AreaIndex = 0
			Me.fieldValue.Caption = "Sum"
			Me.fieldValue.FieldName = "Value"
			Me.fieldValue.Name = "fieldValue"
			' 
			' fieldValue1
			' 
			Me.fieldValue1.AreaIndex = 2
			Me.fieldValue1.Caption = "Count"
			Me.fieldValue1.FieldName = "Value"
			Me.fieldValue1.Name = "fieldValue1"
			Me.fieldValue1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
			' 
			' fieldValue2
			' 
			Me.fieldValue2.AreaIndex = 1
			Me.fieldValue2.Caption = "Average"
			Me.fieldValue2.FieldName = "Value"
			Me.fieldValue2.Name = "fieldValue2"
			Me.fieldValue2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			' 
			' fieldDate1
			' 
			Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldDate1.AreaIndex = 0
			Me.fieldDate1.Caption = "Date"
			Me.fieldDate1.FieldName = "Date"
			Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
			Me.fieldDate1.Name = "fieldDate1"
			Me.fieldDate1.UnboundFieldName = "fieldDate1"
			Me.fieldDate1.ValueFormat.FormatString = "dd MMM yyyy"
			Me.fieldDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 62)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.pivotGridControl1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.chartControl1)
			Me.splitContainer1.Size = New System.Drawing.Size(1051, 431)
			Me.splitContainer1.SplitterDistance = 443
			Me.splitContainer1.TabIndex = 1
			' 
			' chartControl1
			' 
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.EmptyChartText.Text = ""
			Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chartControl1.Legend.MaxVerticalPercentage = 30R
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			Me.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.SeriesTemplate.View = sideBySideRangeBarSeriesView1
			Me.chartControl1.Size = New System.Drawing.Size(604, 431)
			Me.chartControl1.SmallChartText.Text = "Increase the chart's size," & Constants.vbCrLf & "to view its layout." & Constants.vbCrLf & "    "
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.CustomDrawSeriesPoint += New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(Me.chartControl1_CustomDrawSeriesPoint);
'			Me.chartControl1.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chartControl1_BoundDataChanged);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.chartTypeBar1, Me.chartAppearanceBar1, Me.chartWizardBar1, Me.chartTemplatesBar1, Me.chartPrintExportBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.createBarBaseItem1, Me.createLineBaseItem1, Me.createPieBaseItem1, Me.createRotatedBarBaseItem1, Me.createAreaBaseItem1, Me.createOtherSeriesTypesBaseItem1, Me.changePaletteGalleryBaseItem1, Me.changeAppearanceGalleryBaseBarManagerItem1, Me.runWizardChartItem1, Me.saveAsTemplateChartItem1, Me.loadTemplateChartItem1, Me.printPreviewChartItem1, Me.printChartItem1, Me.createExportBaseItem1, Me.exportToPDFChartItem1, Me.exportToHTMLChartItem1, Me.exportToMHTChartItem1, Me.exportToXLSChartItem1, Me.exportToXLSXChartItem1, Me.exportToRTFChartItem1, Me.exportToBMPChartItem1, Me.exportToGIFChartItem1, Me.exportToJPEGChartItem1, Me.exportToPNGChartItem1, Me.exportToTIFFChartItem1, Me.createExportToImageBaseItem1})
			Me.barManager1.MaxItemId = 26
			' 
			' chartTypeBar1
			' 
			Me.chartTypeBar1.Control = Me.chartControl1
			Me.chartTypeBar1.DockCol = 0
			Me.chartTypeBar1.DockRow = 0
			Me.chartTypeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.chartTypeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.createBarBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createLineBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createPieBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createRotatedBarBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createAreaBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createOtherSeriesTypesBaseItem1)})
			' 
			' createBarBaseItem1
			' 
			Me.createBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown1
			Me.createBarBaseItem1.Id = 0
			Me.createBarBaseItem1.Name = "createBarBaseItem1"
			' 
			' commandBarGalleryDropDown1
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem1, createFullStackedBarChartItem1, createSideBySideFullStackedBarChartItem1, createSideBySideStackedBarChartItem1, createStackedBarChartItem1})
			chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem1, createFullStackedBar3DChartItem1, createManhattanBarChartItem1, createSideBySideFullStackedBar3DChartItem1, createSideBySideStackedBar3DChartItem1, createStackedBar3DChartItem1})
			chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem1, createCylinderFullStackedBar3DChartItem1, createCylinderManhattanBarChartItem1, createCylinderSideBySideFullStackedBar3DChartItem1, createCylinderSideBySideStackedBar3DChartItem1, createCylinderStackedBar3DChartItem1})
			chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem1, createConeFullStackedBar3DChartItem1, createConeManhattanBarChartItem1, createConeSideBySideFullStackedBar3DChartItem1, createConeSideBySideStackedBar3DChartItem1, createConeStackedBar3DChartItem1})
			chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem1, createPyramidFullStackedBar3DChartItem1, createPyramidManhattanBarChartItem1, createPyramidSideBySideFullStackedBar3DChartItem1, createPyramidSideBySideStackedBar3DChartItem1, createPyramidStackedBar3DChartItem1})
			Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn1, chartControlCommandGalleryItemGroup3DColumn1, chartControlCommandGalleryItemGroupCylinderColumn1, chartControlCommandGalleryItemGroupConeColumn1, chartControlCommandGalleryItemGroupPyramidColumn1})
			Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown1.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown1.Manager = Me.barManager1
			Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
			' 
			' createLineBaseItem1
			' 
			Me.createLineBaseItem1.DropDownControl = Me.commandBarGalleryDropDown2
			Me.createLineBaseItem1.Id = 1
			Me.createLineBaseItem1.Name = "createLineBaseItem1"
			' 
			' commandBarGalleryDropDown2
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown2.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem1, createFullStackedLineChartItem1, createScatterLineChartItem1, createSplineChartItem1, createStackedLineChartItem1, createStepLineChartItem1})
			chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem1, createFullStackedLine3DChartItem1, createSpline3DChartItem1, createStackedLine3DChartItem1, createStepLine3DChartItem1})
			Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine1, chartControlCommandGalleryItemGroup3DLine1})
			Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown2.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown2.Manager = Me.barManager1
			Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
			' 
			' createPieBaseItem1
			' 
			Me.createPieBaseItem1.DropDownControl = Me.commandBarGalleryDropDown3
			Me.createPieBaseItem1.Id = 2
			Me.createPieBaseItem1.Name = "createPieBaseItem1"
			' 
			' commandBarGalleryDropDown3
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown3.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem1, createDoughnutChartItem1, createNestedDoughnutChartItem1})
			chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem1, createDoughnut3DChartItem1})
			Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie1, chartControlCommandGalleryItemGroup3DPie1})
			Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown3.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown3.Manager = Me.barManager1
			Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
			' 
			' createRotatedBarBaseItem1
			' 
			Me.createRotatedBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown4
			Me.createRotatedBarBaseItem1.Id = 3
			Me.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1"
			' 
			' commandBarGalleryDropDown4
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown4.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem1, createRotatedFullStackedBarChartItem1, createRotatedSideBySideFullStackedBarChartItem1, createRotatedSideBySideStackedBarChartItem1, createRotatedStackedBarChartItem1})
			Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar1})
			Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown4.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown4.Manager = Me.barManager1
			Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
			' 
			' createAreaBaseItem1
			' 
			Me.createAreaBaseItem1.DropDownControl = Me.commandBarGalleryDropDown5
			Me.createAreaBaseItem1.Id = 4
			Me.createAreaBaseItem1.Name = "createAreaBaseItem1"
			' 
			' commandBarGalleryDropDown5
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem1, createFullStackedAreaChartItem1, createFullStackedSplineAreaChartItem1, createSplineAreaChartItem1, createStackedAreaChartItem1, createStackedSplineAreaChartItem1, createStepAreaChartItem1})
			chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem1, createFullStackedArea3DChartItem1, createFullStackedSplineArea3DChartItem1, createSplineArea3DChartItem1, createStackedArea3DChartItem1, createStackedSplineArea3DChartItem1, createStepArea3DChartItem1})
			Me.commandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea1, chartControlCommandGalleryItemGroup3DArea1})
			Me.commandBarGalleryDropDown5.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown5.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown5.Manager = Me.barManager1
			Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
			' 
			' createOtherSeriesTypesBaseItem1
			' 
			Me.createOtherSeriesTypesBaseItem1.DropDownControl = Me.commandBarGalleryDropDown6
			Me.createOtherSeriesTypesBaseItem1.Id = 5
			Me.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1"
			' 
			' commandBarGalleryDropDown6
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown6.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem1, createBubbleChartItem1})
			chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem1, createFunnel3DChartItem1})
			chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem1, createCandleStickChartItem1})
			chartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem1, createRadarLineChartItem1, createRadarAreaChartItem1})
			chartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem1, createPolarLineChartItem1, createPolarAreaChartItem1})
			chartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem1, createSideBySideRangeBarChartItem1, createRangeAreaChartItem1, createRangeArea3DChartItem1})
			chartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem1, createSideBySideGanttChartItem1})
			Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint1, chartControlCommandGalleryItemGroupFunnel1, chartControlCommandGalleryItemGroupFinancial1, chartControlCommandGalleryItemGroupRadar1, chartControlCommandGalleryItemGroupPolar1, chartControlCommandGalleryItemGroupRange1, chartControlCommandGalleryItemGroupGantt1})
			Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown6.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown6.Manager = Me.barManager1
			Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
			' 
			' chartAppearanceBar1
			' 
			Me.chartAppearanceBar1.Control = Me.chartControl1
			Me.chartAppearanceBar1.DockCol = 1
			Me.chartAppearanceBar1.DockRow = 0
			Me.chartAppearanceBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.chartAppearanceBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.changePaletteGalleryBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeAppearanceGalleryBaseBarManagerItem1)})
			' 
			' changePaletteGalleryBaseItem1
			' 
			Me.changePaletteGalleryBaseItem1.DropDownControl = Me.commandBarGalleryDropDown7
			Me.changePaletteGalleryBaseItem1.Id = 6
			Me.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1"
			' 
			' commandBarGalleryDropDown7
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges1.Bottom = -3
			skinPaddingEdges1.Top = -3
			Me.commandBarGalleryDropDown7.Gallery.ItemImagePadding = skinPaddingEdges1
			skinPaddingEdges2.Bottom = -3
			skinPaddingEdges2.Top = -3
			Me.commandBarGalleryDropDown7.Gallery.ItemTextPadding = skinPaddingEdges2
			Me.commandBarGalleryDropDown7.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown7.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown7.Manager = Me.barManager1
			Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
			' 
			' changeAppearanceGalleryBaseBarManagerItem1
			' 
			Me.changeAppearanceGalleryBaseBarManagerItem1.DropDownControl = Me.commandBarGalleryDropDown8
			Me.changeAppearanceGalleryBaseBarManagerItem1.Id = 7
			Me.changeAppearanceGalleryBaseBarManagerItem1.Name = "changeAppearanceGalleryBaseBarManagerItem1"
			' 
			' commandBarGalleryDropDown8
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown8.Gallery.ColumnCount = 7
			Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(80, 50)
			Me.commandBarGalleryDropDown8.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown8.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown8.Manager = Me.barManager1
			Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
			' 
			' chartWizardBar1
			' 
			Me.chartWizardBar1.Control = Me.chartControl1
			Me.chartWizardBar1.DockCol = 0
			Me.chartWizardBar1.DockRow = 1
			Me.chartWizardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.chartWizardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.runWizardChartItem1)})
			' 
			' runWizardChartItem1
			' 
			Me.runWizardChartItem1.Id = 8
			Me.runWizardChartItem1.Name = "runWizardChartItem1"
			' 
			' chartTemplatesBar1
			' 
			Me.chartTemplatesBar1.Control = Me.chartControl1
			Me.chartTemplatesBar1.DockCol = 1
			Me.chartTemplatesBar1.DockRow = 1
			Me.chartTemplatesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.chartTemplatesBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.saveAsTemplateChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.loadTemplateChartItem1)})
			' 
			' saveAsTemplateChartItem1
			' 
			Me.saveAsTemplateChartItem1.Id = 9
			Me.saveAsTemplateChartItem1.Name = "saveAsTemplateChartItem1"
			' 
			' loadTemplateChartItem1
			' 
			Me.loadTemplateChartItem1.Id = 10
			Me.loadTemplateChartItem1.Name = "loadTemplateChartItem1"
			' 
			' chartPrintExportBar1
			' 
			Me.chartPrintExportBar1.Control = Me.chartControl1
			Me.chartPrintExportBar1.DockCol = 2
			Me.chartPrintExportBar1.DockRow = 1
			Me.chartPrintExportBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.chartPrintExportBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createExportBaseItem1)})
			' 
			' printPreviewChartItem1
			' 
			Me.printPreviewChartItem1.Id = 11
			Me.printPreviewChartItem1.Name = "printPreviewChartItem1"
			' 
			' printChartItem1
			' 
			Me.printChartItem1.Id = 12
			Me.printChartItem1.Name = "printChartItem1"
			' 
			' createExportBaseItem1
			' 
			Me.createExportBaseItem1.Id = 13
			Me.createExportBaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.exportToPDFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToHTMLChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToMHTChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToXLSChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToXLSXChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToRTFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.createExportToImageBaseItem1)})
			Me.createExportBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
			Me.createExportBaseItem1.Name = "createExportBaseItem1"
			' 
			' exportToPDFChartItem1
			' 
			Me.exportToPDFChartItem1.Id = 14
			Me.exportToPDFChartItem1.Name = "exportToPDFChartItem1"
			' 
			' exportToHTMLChartItem1
			' 
			Me.exportToHTMLChartItem1.Id = 15
			Me.exportToHTMLChartItem1.Name = "exportToHTMLChartItem1"
			' 
			' exportToMHTChartItem1
			' 
			Me.exportToMHTChartItem1.Id = 16
			Me.exportToMHTChartItem1.Name = "exportToMHTChartItem1"
			' 
			' exportToXLSChartItem1
			' 
			Me.exportToXLSChartItem1.Id = 17
			Me.exportToXLSChartItem1.Name = "exportToXLSChartItem1"
			' 
			' exportToXLSXChartItem1
			' 
			Me.exportToXLSXChartItem1.Id = 18
			Me.exportToXLSXChartItem1.Name = "exportToXLSXChartItem1"
			' 
			' exportToRTFChartItem1
			' 
			Me.exportToRTFChartItem1.Id = 19
			Me.exportToRTFChartItem1.Name = "exportToRTFChartItem1"
			' 
			' createExportToImageBaseItem1
			' 
			Me.createExportToImageBaseItem1.Id = 20
			Me.createExportToImageBaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.exportToBMPChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToGIFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToJPEGChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToPNGChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.exportToTIFFChartItem1)})
			Me.createExportToImageBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
			Me.createExportToImageBaseItem1.Name = "createExportToImageBaseItem1"
			' 
			' exportToBMPChartItem1
			' 
			Me.exportToBMPChartItem1.Id = 21
			Me.exportToBMPChartItem1.Name = "exportToBMPChartItem1"
			' 
			' exportToGIFChartItem1
			' 
			Me.exportToGIFChartItem1.Id = 22
			Me.exportToGIFChartItem1.Name = "exportToGIFChartItem1"
			' 
			' exportToJPEGChartItem1
			' 
			Me.exportToJPEGChartItem1.Id = 23
			Me.exportToJPEGChartItem1.Name = "exportToJPEGChartItem1"
			' 
			' exportToPNGChartItem1
			' 
			Me.exportToPNGChartItem1.Id = 24
			Me.exportToPNGChartItem1.Name = "exportToPNGChartItem1"
			' 
			' exportToTIFFChartItem1
			' 
			Me.exportToTIFFChartItem1.Id = 25
			Me.exportToTIFFChartItem1.Name = "exportToTIFFChartItem1"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(1051, 62)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 493)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1051, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 431)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1051, 62)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 431)
			' 
			' chartBarController1
			' 
			Me.chartBarController1.BarItems.Add(Me.createBarBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.createLineBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.createPieBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.createRotatedBarBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.createAreaBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.createOtherSeriesTypesBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.changePaletteGalleryBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.changeAppearanceGalleryBaseBarManagerItem1)
			Me.chartBarController1.BarItems.Add(Me.runWizardChartItem1)
			Me.chartBarController1.BarItems.Add(Me.saveAsTemplateChartItem1)
			Me.chartBarController1.BarItems.Add(Me.loadTemplateChartItem1)
			Me.chartBarController1.BarItems.Add(Me.printPreviewChartItem1)
			Me.chartBarController1.BarItems.Add(Me.printChartItem1)
			Me.chartBarController1.BarItems.Add(Me.createExportBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToPDFChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToHTMLChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToMHTChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToXLSChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToXLSXChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToRTFChartItem1)
			Me.chartBarController1.BarItems.Add(Me.createExportToImageBaseItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToBMPChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToGIFChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToJPEGChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToPNGChartItem1)
			Me.chartBarController1.BarItems.Add(Me.exportToTIFFChartItem1)
			Me.chartBarController1.Control = Me.chartControl1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1051, 493)
			Me.Controls.Add(Me.splitContainer1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.ResumeLayout(False)
			CType(sideBySideRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private fiedName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private chartTypeBar1 As DevExpress.XtraCharts.UI.ChartTypeBar
		Private createBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
		Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
		Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createPieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
		Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
		Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
		Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
		Private commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private chartAppearanceBar1 As DevExpress.XtraCharts.UI.ChartAppearanceBar
		Private changePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
		Private commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private changeAppearanceGalleryBaseBarManagerItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem
		Private commandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private chartWizardBar1 As DevExpress.XtraCharts.UI.ChartWizardBar
		Private runWizardChartItem1 As DevExpress.XtraCharts.UI.RunWizardChartItem
		Private chartTemplatesBar1 As DevExpress.XtraCharts.UI.ChartTemplatesBar
		Private saveAsTemplateChartItem1 As DevExpress.XtraCharts.UI.SaveAsTemplateChartItem
		Private loadTemplateChartItem1 As DevExpress.XtraCharts.UI.LoadTemplateChartItem
		Private chartPrintExportBar1 As DevExpress.XtraCharts.UI.ChartPrintExportBar
		Private printPreviewChartItem1 As DevExpress.XtraCharts.UI.PrintPreviewChartItem
		Private printChartItem1 As DevExpress.XtraCharts.UI.PrintChartItem
		Private createExportBaseItem1 As DevExpress.XtraCharts.UI.CreateExportBaseItem
		Private exportToPDFChartItem1 As DevExpress.XtraCharts.UI.ExportToPDFChartItem
		Private exportToHTMLChartItem1 As DevExpress.XtraCharts.UI.ExportToHTMLChartItem
		Private exportToMHTChartItem1 As DevExpress.XtraCharts.UI.ExportToMHTChartItem
		Private exportToXLSChartItem1 As DevExpress.XtraCharts.UI.ExportToXLSChartItem
		Private exportToXLSXChartItem1 As DevExpress.XtraCharts.UI.ExportToXLSXChartItem
		Private exportToRTFChartItem1 As DevExpress.XtraCharts.UI.ExportToRTFChartItem
		Private createExportToImageBaseItem1 As DevExpress.XtraCharts.UI.CreateExportToImageBaseItem
		Private exportToBMPChartItem1 As DevExpress.XtraCharts.UI.ExportToBMPChartItem
		Private exportToGIFChartItem1 As DevExpress.XtraCharts.UI.ExportToGIFChartItem
		Private exportToJPEGChartItem1 As DevExpress.XtraCharts.UI.ExportToJPEGChartItem
		Private exportToPNGChartItem1 As DevExpress.XtraCharts.UI.ExportToPNGChartItem
		Private exportToTIFFChartItem1 As DevExpress.XtraCharts.UI.ExportToTIFFChartItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private chartBarController1 As DevExpress.XtraCharts.UI.ChartBarController
	End Class
End Namespace

