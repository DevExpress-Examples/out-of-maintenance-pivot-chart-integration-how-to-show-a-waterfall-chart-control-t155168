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
            Dim SideBySideRangeBarSeriesView1 As DevExpress.XtraCharts.SideBySideRangeBarSeriesView = New DevExpress.XtraCharts.SideBySideRangeBarSeriesView()
            Dim ChartControlCommandGalleryItemGroup2DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
            Dim CreateBarChartItem1 As DevExpress.XtraCharts.UI.CreateBarChartItem = New DevExpress.XtraCharts.UI.CreateBarChartItem()
            Dim CreateFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
            Dim CreateSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
            Dim CreateSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
            Dim CreateStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
            Dim ChartControlCommandGalleryItemGroup3DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
            Dim CreateBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateBar3DChartItem = New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
            Dim CreateFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
            Dim CreateManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
            Dim CreateSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
            Dim CreateSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
            Dim CreateStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroupCylinderColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
            Dim CreateCylinderBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
            Dim CreateCylinderFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
            Dim CreateCylinderManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
            Dim CreateCylinderSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
            Dim CreateCylinderSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
            Dim CreateCylinderStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroupConeColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
            Dim CreateConeBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
            Dim CreateConeFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
            Dim CreateConeManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
            Dim CreateConeSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
            Dim CreateConeSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
            Dim CreateConeStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroupPyramidColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
            Dim CreatePyramidBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
            Dim CreatePyramidFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
            Dim CreatePyramidManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
            Dim CreatePyramidSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
            Dim CreatePyramidSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
            Dim CreatePyramidStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroup2DLine2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
            Dim CreateLineChartItem2 As DevExpress.XtraCharts.UI.CreateLineChartItem = New DevExpress.XtraCharts.UI.CreateLineChartItem()
            Dim CreateFullStackedLineChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
            Dim CreateScatterLineChartItem2 As DevExpress.XtraCharts.UI.CreateScatterLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
            Dim CreateSplineChartItem2 As DevExpress.XtraCharts.UI.CreateSplineChartItem = New DevExpress.XtraCharts.UI.CreateSplineChartItem()
            Dim CreateStackedLineChartItem2 As DevExpress.XtraCharts.UI.CreateStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
            Dim CreateStepLineChartItem2 As DevExpress.XtraCharts.UI.CreateStepLineChartItem = New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
            Dim ChartControlCommandGalleryItemGroup3DLine2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
            Dim CreateLine3DChartItem2 As DevExpress.XtraCharts.UI.CreateLine3DChartItem = New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
            Dim CreateFullStackedLine3DChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
            Dim CreateSpline3DChartItem2 As DevExpress.XtraCharts.UI.CreateSpline3DChartItem = New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
            Dim CreateStackedLine3DChartItem2 As DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
            Dim CreateStepLine3DChartItem2 As DevExpress.XtraCharts.UI.CreateStepLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
            Dim ChartControlCommandGalleryItemGroup2DPie2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
            Dim CreatePieChartItem2 As DevExpress.XtraCharts.UI.CreatePieChartItem = New DevExpress.XtraCharts.UI.CreatePieChartItem()
            Dim CreateDoughnutChartItem2 As DevExpress.XtraCharts.UI.CreateDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
            Dim CreateNestedDoughnutChartItem2 As DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
            Dim ChartControlCommandGalleryItemGroup3DPie2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
            Dim CreatePie3DChartItem2 As DevExpress.XtraCharts.UI.CreatePie3DChartItem = New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
            Dim CreateDoughnut3DChartItem2 As DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem = New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
            Dim ChartControlCommandGalleryItemGroup2DBar2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
            Dim CreateRotatedBarChartItem2 As DevExpress.XtraCharts.UI.CreateRotatedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
            Dim CreateRotatedFullStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim CreateRotatedSideBySideFullStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
            Dim CreateRotatedSideBySideStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
            Dim CreateRotatedStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
            Dim ChartControlCommandGalleryItemGroup2DArea2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
            Dim CreateAreaChartItem2 As DevExpress.XtraCharts.UI.CreateAreaChartItem = New DevExpress.XtraCharts.UI.CreateAreaChartItem()
            Dim CreateFullStackedAreaChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
            Dim CreateFullStackedSplineAreaChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
            Dim CreateSplineAreaChartItem2 As DevExpress.XtraCharts.UI.CreateSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
            Dim CreateStackedAreaChartItem2 As DevExpress.XtraCharts.UI.CreateStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
            Dim CreateStackedSplineAreaChartItem2 As DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
            Dim CreateStepAreaChartItem2 As DevExpress.XtraCharts.UI.CreateStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
            Dim ChartControlCommandGalleryItemGroup3DArea2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
            Dim CreateArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateArea3DChartItem = New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
            Dim CreateFullStackedArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
            Dim CreateFullStackedSplineArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
            Dim CreateSplineArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
            Dim CreateStackedArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
            Dim CreateStackedSplineArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
            Dim CreateStepArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateStepArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
            Dim ChartControlCommandGalleryItemGroupPoint2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
            Dim CreatePointChartItem2 As DevExpress.XtraCharts.UI.CreatePointChartItem = New DevExpress.XtraCharts.UI.CreatePointChartItem()
            Dim CreateBubbleChartItem2 As DevExpress.XtraCharts.UI.CreateBubbleChartItem = New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
            Dim ChartControlCommandGalleryItemGroupFunnel2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
            Dim CreateFunnelChartItem2 As DevExpress.XtraCharts.UI.CreateFunnelChartItem = New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
            Dim CreateFunnel3DChartItem2 As DevExpress.XtraCharts.UI.CreateFunnel3DChartItem = New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
            Dim ChartControlCommandGalleryItemGroupFinancial2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
            Dim CreateStockChartItem2 As DevExpress.XtraCharts.UI.CreateStockChartItem = New DevExpress.XtraCharts.UI.CreateStockChartItem()
            Dim CreateCandleStickChartItem2 As DevExpress.XtraCharts.UI.CreateCandleStickChartItem = New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
            Dim ChartControlCommandGalleryItemGroupRadar2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
            Dim CreateRadarPointChartItem2 As DevExpress.XtraCharts.UI.CreateRadarPointChartItem = New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
            Dim CreateRadarLineChartItem2 As DevExpress.XtraCharts.UI.CreateRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
            Dim CreateRadarAreaChartItem2 As DevExpress.XtraCharts.UI.CreateRadarAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
            Dim ChartControlCommandGalleryItemGroupPolar2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
            Dim CreatePolarPointChartItem2 As DevExpress.XtraCharts.UI.CreatePolarPointChartItem = New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
            Dim CreatePolarLineChartItem2 As DevExpress.XtraCharts.UI.CreatePolarLineChartItem = New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
            Dim CreatePolarAreaChartItem2 As DevExpress.XtraCharts.UI.CreatePolarAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
            Dim ChartControlCommandGalleryItemGroupRange2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
            Dim CreateRangeBarChartItem2 As DevExpress.XtraCharts.UI.CreateRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
            Dim CreateSideBySideRangeBarChartItem2 As DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
            Dim CreateRangeAreaChartItem2 As DevExpress.XtraCharts.UI.CreateRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
            Dim CreateRangeArea3DChartItem2 As DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem = New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
            Dim ChartControlCommandGalleryItemGroupGantt2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
            Dim CreateGanttChartItem2 As DevExpress.XtraCharts.UI.CreateGanttChartItem = New DevExpress.XtraCharts.UI.CreateGanttChartItem()
            Dim CreateSideBySideGanttChartItem2 As DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
            Dim SkinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim SkinPaddingEdges2 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim ChartControlCommandGalleryItemGroup2DColumn2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
            Dim CreateBarChartItem2 As DevExpress.XtraCharts.UI.CreateBarChartItem = New DevExpress.XtraCharts.UI.CreateBarChartItem()
            Dim CreateFullStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
            Dim CreateSideBySideFullStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
            Dim CreateSideBySideStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
            Dim CreateStackedBarChartItem2 As DevExpress.XtraCharts.UI.CreateStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
            Dim CreateWaterfallChartItem1 As DevExpress.XtraCharts.UI.CreateWaterfallChartItem = New DevExpress.XtraCharts.UI.CreateWaterfallChartItem()
            Dim ChartControlCommandGalleryItemGroup3DColumn2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
            Dim CreateBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateBar3DChartItem = New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
            Dim CreateFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
            Dim CreateManhattanBarChartItem2 As DevExpress.XtraCharts.UI.CreateManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
            Dim CreateSideBySideFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
            Dim CreateSideBySideStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
            Dim CreateStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroupCylinderColumn2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
            Dim CreateCylinderBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
            Dim CreateCylinderFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
            Dim CreateCylinderManhattanBarChartItem2 As DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
            Dim CreateCylinderSideBySideFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
            Dim CreateCylinderSideBySideStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
            Dim CreateCylinderStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroupConeColumn2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
            Dim CreateConeBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateConeBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
            Dim CreateConeFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
            Dim CreateConeManhattanBarChartItem2 As DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
            Dim CreateConeSideBySideFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
            Dim CreateConeSideBySideStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
            Dim CreateConeStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroupPyramidColumn2 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
            Dim CreatePyramidBar3DChartItem2 As DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
            Dim CreatePyramidFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
            Dim CreatePyramidManhattanBarChartItem2 As DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
            Dim CreatePyramidSideBySideFullStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
            Dim CreatePyramidSideBySideStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
            Dim CreatePyramidStackedBar3DChartItem2 As DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
            Dim ChartControlCommandGalleryItemGroup2DLine1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
            Dim CreateLineChartItem1 As DevExpress.XtraCharts.UI.CreateLineChartItem = New DevExpress.XtraCharts.UI.CreateLineChartItem()
            Dim CreateFullStackedLineChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
            Dim CreateScatterLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
            Dim CreateSplineChartItem1 As DevExpress.XtraCharts.UI.CreateSplineChartItem = New DevExpress.XtraCharts.UI.CreateSplineChartItem()
            Dim CreateStackedLineChartItem1 As DevExpress.XtraCharts.UI.CreateStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
            Dim CreateStepLineChartItem1 As DevExpress.XtraCharts.UI.CreateStepLineChartItem = New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
            Dim ChartControlCommandGalleryItemGroup3DLine1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
            Dim CreateLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateLine3DChartItem = New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
            Dim CreateFullStackedLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
            Dim CreateSpline3DChartItem1 As DevExpress.XtraCharts.UI.CreateSpline3DChartItem = New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
            Dim CreateStackedLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
            Dim CreateStepLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateStepLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
            Dim ChartControlCommandGalleryItemGroup2DPie1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
            Dim CreatePieChartItem1 As DevExpress.XtraCharts.UI.CreatePieChartItem = New DevExpress.XtraCharts.UI.CreatePieChartItem()
            Dim CreateDoughnutChartItem1 As DevExpress.XtraCharts.UI.CreateDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
            Dim CreateNestedDoughnutChartItem1 As DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
            Dim ChartControlCommandGalleryItemGroup3DPie1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
            Dim CreatePie3DChartItem1 As DevExpress.XtraCharts.UI.CreatePie3DChartItem = New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
            Dim CreateDoughnut3DChartItem1 As DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem = New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
            Dim ChartControlCommandGalleryItemGroup2DBar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
            Dim CreateRotatedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
            Dim CreateRotatedFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
            Dim CreateRotatedSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
            Dim CreateRotatedSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
            Dim CreateRotatedStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
            Dim ChartControlCommandGalleryItemGroup2DArea1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
            Dim CreateAreaChartItem1 As DevExpress.XtraCharts.UI.CreateAreaChartItem = New DevExpress.XtraCharts.UI.CreateAreaChartItem()
            Dim CreateFullStackedAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
            Dim CreateFullStackedSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
            Dim CreateFullStackedStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem()
            Dim CreateSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
            Dim CreateStackedAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
            Dim CreateStackedStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem()
            Dim CreateStackedSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
            Dim CreateStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
            Dim ChartControlCommandGalleryItemGroup3DArea1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
            Dim CreateArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateArea3DChartItem = New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
            Dim CreateFullStackedArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
            Dim CreateFullStackedSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
            Dim CreateSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
            Dim CreateStackedArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
            Dim CreateStackedSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
            Dim CreateStepArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStepArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
            Dim ChartControlCommandGalleryItemGroupPoint1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
            Dim CreatePointChartItem1 As DevExpress.XtraCharts.UI.CreatePointChartItem = New DevExpress.XtraCharts.UI.CreatePointChartItem()
            Dim CreateBubbleChartItem1 As DevExpress.XtraCharts.UI.CreateBubbleChartItem = New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
            Dim ChartControlCommandGalleryItemGroupFunnel1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
            Dim CreateFunnelChartItem1 As DevExpress.XtraCharts.UI.CreateFunnelChartItem = New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
            Dim CreateFunnel3DChartItem1 As DevExpress.XtraCharts.UI.CreateFunnel3DChartItem = New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
            Dim ChartControlCommandGalleryItemGroupFinancial1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
            Dim CreateStockChartItem1 As DevExpress.XtraCharts.UI.CreateStockChartItem = New DevExpress.XtraCharts.UI.CreateStockChartItem()
            Dim CreateCandleStickChartItem1 As DevExpress.XtraCharts.UI.CreateCandleStickChartItem = New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
            Dim ChartControlCommandGalleryItemGroupRadar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
            Dim CreateRadarPointChartItem1 As DevExpress.XtraCharts.UI.CreateRadarPointChartItem = New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
            Dim CreateRadarLineChartItem1 As DevExpress.XtraCharts.UI.CreateRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
            Dim CreateRadarAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRadarAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
            Dim CreateRadarRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem()
            Dim CreateScatterRadarLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem()
            Dim ChartControlCommandGalleryItemGroupPolar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
            Dim CreatePolarPointChartItem1 As DevExpress.XtraCharts.UI.CreatePolarPointChartItem = New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
            Dim CreatePolarLineChartItem1 As DevExpress.XtraCharts.UI.CreatePolarLineChartItem = New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
            Dim CreatePolarAreaChartItem1 As DevExpress.XtraCharts.UI.CreatePolarAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
            Dim CreatePolarRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem()
            Dim CreateScatterPolarLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem()
            Dim ChartControlCommandGalleryItemGroupRange1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
            Dim CreateRangeBarChartItem1 As DevExpress.XtraCharts.UI.CreateRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
            Dim CreateSideBySideRangeBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
            Dim CreateRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
            Dim CreateRangeArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem = New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
            Dim ChartControlCommandGalleryItemGroupGantt1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
            Dim CreateGanttChartItem1 As DevExpress.XtraCharts.UI.CreateGanttChartItem = New DevExpress.XtraCharts.UI.CreateGanttChartItem()
            Dim CreateSideBySideGanttChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
            Dim ChartControlCommandGalleryItemGroupBoxPlot1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupBoxPlot = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupBoxPlot()
            Dim CreateBoxPlotChartItem1 As DevExpress.XtraCharts.UI.CreateBoxPlotChartItem = New DevExpress.XtraCharts.UI.CreateBoxPlotChartItem()
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
            Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.chartTypeBar1 = New DevExpress.XtraCharts.UI.ChartTypeBar()
            Me.chartAppearanceBar1 = New DevExpress.XtraCharts.UI.ChartAppearanceBar()
            Me.chartTemplatesBar1 = New DevExpress.XtraCharts.UI.ChartTemplatesBar()
            Me.chartPrintExportBar1 = New DevExpress.XtraCharts.UI.ChartPrintExportBar()
            Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.ChartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController(Me.components)
            Me.ChartTypeBar2 = New DevExpress.XtraCharts.UI.ChartTypeBar()
            Me.CreateBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
            Me.CommandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.CreateLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
            Me.CommandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.CreatePieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
            Me.CommandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.CreateRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
            Me.CommandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.CreateAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
            Me.CommandBarGalleryDropDown13 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.CreateOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
            Me.CommandBarGalleryDropDown14 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.ChartAppearanceBar2 = New DevExpress.XtraCharts.UI.ChartAppearanceBar()
            Me.ChangePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
            Me.CommandBarGalleryDropDown15 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.ChangeAppearanceGalleryBaseBarManagerItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem()
            Me.CommandBarGalleryDropDown16 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.ChartDesignerBar1 = New DevExpress.XtraCharts.UI.ChartDesignerBar()
            Me.RunDesignerChartItem1 = New DevExpress.XtraCharts.UI.RunDesignerChartItem()
            Me.ChartTemplatesBar2 = New DevExpress.XtraCharts.UI.ChartTemplatesBar()
            Me.SaveAsTemplateChartItem1 = New DevExpress.XtraCharts.UI.SaveAsTemplateChartItem()
            Me.LoadTemplateChartItem1 = New DevExpress.XtraCharts.UI.LoadTemplateChartItem()
            Me.ChartPrintExportBar2 = New DevExpress.XtraCharts.UI.ChartPrintExportBar()
            Me.PrintPreviewChartItem1 = New DevExpress.XtraCharts.UI.PrintPreviewChartItem()
            Me.PrintChartItem1 = New DevExpress.XtraCharts.UI.PrintChartItem()
            Me.ExportToPDFChartItem1 = New DevExpress.XtraCharts.UI.ExportToPDFChartItem()
            Me.ExportToHTMLChartItem1 = New DevExpress.XtraCharts.UI.ExportToHTMLChartItem()
            Me.ExportToMHTChartItem1 = New DevExpress.XtraCharts.UI.ExportToMHTChartItem()
            Me.ExportToXLSChartItem1 = New DevExpress.XtraCharts.UI.ExportToXLSChartItem()
            Me.ExportToXLSXChartItem1 = New DevExpress.XtraCharts.UI.ExportToXLSXChartItem()
            Me.ExportToRTFChartItem1 = New DevExpress.XtraCharts.UI.ExportToRTFChartItem()
            Me.ExportToBMPChartItem1 = New DevExpress.XtraCharts.UI.ExportToBMPChartItem()
            Me.ExportToGIFChartItem1 = New DevExpress.XtraCharts.UI.ExportToGIFChartItem()
            Me.ExportToJPEGChartItem1 = New DevExpress.XtraCharts.UI.ExportToJPEGChartItem()
            Me.ExportToPNGChartItem1 = New DevExpress.XtraCharts.UI.ExportToPNGChartItem()
            Me.ExportToTIFFChartItem1 = New DevExpress.XtraCharts.UI.ExportToTIFFChartItem()
            Me.CreateExportToImageBaseItem1 = New DevExpress.XtraCharts.UI.CreateExportToImageBaseItem()
            Me.CreateExportBaseItem1 = New DevExpress.XtraCharts.UI.CreateExportBaseItem()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fiedName, Me.fieldDate, Me.fieldValue, Me.fieldValue1, Me.fieldValue2, Me.fieldDate1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(590, 546)
            Me.pivotGridControl1.TabIndex = 0
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            '
            'dataTable1
            '
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Data"
            '
            'dataColumn1
            '
            Me.dataColumn1.ColumnName = "Name"
            '
            'dataColumn2
            '
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(Date)
            '
            'dataColumn3
            '
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Decimal)
            '
            'fiedName
            '
            Me.fiedName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fiedName.AreaIndex = 0
            Me.fiedName.FieldName = "Name"
            Me.fiedName.MinWidth = 27
            Me.fiedName.Name = "fiedName"
            Me.fiedName.Width = 133
            '
            'fieldDate
            '
            Me.fieldDate.AreaIndex = 0
            Me.fieldDate.Caption = "Year"
            Me.fieldDate.FieldName = "Date"
            Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldDate.MinWidth = 27
            Me.fieldDate.Name = "fieldDate"
            Me.fieldDate.UnboundFieldName = "fieldDate"
            Me.fieldDate.Width = 133
            '
            'fieldValue
            '
            Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue.AreaIndex = 0
            Me.fieldValue.Caption = "Sum"
            Me.fieldValue.FieldName = "Value"
            Me.fieldValue.MinWidth = 27
            Me.fieldValue.Name = "fieldValue"
            Me.fieldValue.Width = 133
            '
            'fieldValue1
            '
            Me.fieldValue1.AreaIndex = 2
            Me.fieldValue1.Caption = "Count"
            Me.fieldValue1.FieldName = "Value"
            Me.fieldValue1.MinWidth = 27
            Me.fieldValue1.Name = "fieldValue1"
            Me.fieldValue1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
            Me.fieldValue1.Width = 133
            '
            'fieldValue2
            '
            Me.fieldValue2.AreaIndex = 1
            Me.fieldValue2.Caption = "Average"
            Me.fieldValue2.FieldName = "Value"
            Me.fieldValue2.MinWidth = 27
            Me.fieldValue2.Name = "fieldValue2"
            Me.fieldValue2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldValue2.Width = 133
            '
            'fieldDate1
            '
            Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate1.AreaIndex = 0
            Me.fieldDate1.Caption = "Date"
            Me.fieldDate1.FieldName = "Date"
            Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate1.MinWidth = 27
            Me.fieldDate1.Name = "fieldDate1"
            Me.fieldDate1.UnboundFieldName = "fieldDate1"
            Me.fieldDate1.ValueFormat.FormatString = "dd MMM yyyy"
            Me.fieldDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.fieldDate1.Width = 133
            '
            'splitContainer1
            '
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 61)
            Me.splitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.splitContainer1.Name = "splitContainer1"
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.pivotGridControl1)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.chartControl1)
            Me.splitContainer1.Size = New System.Drawing.Size(1401, 546)
            Me.splitContainer1.SplitterDistance = 590
            Me.splitContainer1.SplitterWidth = 5
            Me.splitContainer1.TabIndex = 1
            '
            'chartControl1
            '
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Legend.MaxVerticalPercentage = 30.0R
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Me.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.SeriesTemplate.View = SideBySideRangeBarSeriesView1
            Me.chartControl1.Size = New System.Drawing.Size(806, 546)
            Me.chartControl1.SmallChartText.Text = "Increase the chart's size," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to view its layout." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    "
            Me.chartControl1.TabIndex = 0
            '
            'commandBarGalleryDropDown1
            '
            '
            '
            '
            Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 4
            CreateBarChartItem1.Caption = "Clustered Column"
            CreateBarChartItem1.Description = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the" &
    " order of categories is not important or for displaying item counts such as a hi" &
    "stogram."
            CreateBarChartItem1.Hint = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the" &
    " order of categories is not important or for displaying item counts such as a hi" &
    "stogram."
            CreateFullStackedBarChartItem1.Caption = "100% Stacked Column"
            CreateFullStackedBarChartItem1.Description = "Compare the percentage that each value contributes to a total across categories b" &
    "y using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the proportion of each data " &
    "series."
            CreateFullStackedBarChartItem1.Hint = "Compare the percentage that each value contributes to a total across categories b" &
    "y using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the proportion of each data " &
    "series."
            CreateSideBySideFullStackedBarChartItem1.Caption = "Clustered 100% Stacked Column"
            CreateSideBySideFullStackedBarChartItem1.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" &
    " types, so that you can stack different columns, and combine them into groups ac" &
    "ross the same axis value."
            CreateSideBySideFullStackedBarChartItem1.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" &
    " types, so that you can stack different columns, and combine them into groups ac" &
    "ross the same axis value."
            CreateSideBySideStackedBarChartItem1.Caption = "Clustered Stacked Column"
            CreateSideBySideStackedBarChartItem1.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" &
    "s, so that you can stack different columns, and combine them into groups across " &
    "the same axis value."
            CreateSideBySideStackedBarChartItem1.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" &
    "s, so that you can stack different columns, and combine them into groups across " &
    "the same axis value."
            CreateStackedBarChartItem1.Caption = "Stacked Column"
            CreateStackedBarChartItem1.Description = "Compare the contribution of each value to a total across categories by using vert" &
    "ical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the total across series for one category" &
    "."
            CreateStackedBarChartItem1.Hint = "Compare the contribution of each value to a total across categories by using vert" &
    "ical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the total across series for one category" &
    "."
            ChartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBarChartItem1, CreateFullStackedBarChartItem1, CreateSideBySideFullStackedBarChartItem1, CreateSideBySideStackedBarChartItem1, CreateStackedBarChartItem1})
            CreateBar3DChartItem1.Caption = "3-D Clustered Column"
            CreateBar3DChartItem1.Description = "Compare values across categories and display clustered columns in 3-D format."
            CreateBar3DChartItem1.Hint = "Compare values across categories and display clustered columns in 3-D format."
            CreateFullStackedBar3DChartItem1.Caption = "100% Stacked Column in 3-D"
            CreateFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories and di" &
    "splay 100% stacked columns in 3-D format."
            CreateFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories and di" &
    "splay 100% stacked columns in 3-D format."
            CreateManhattanBarChartItem1.Caption = "3-D Column"
            CreateManhattanBarChartItem1.Description = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when " &
    "the categories and series are equally important."
            CreateManhattanBarChartItem1.Hint = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when " &
    "the categories and series are equally important."
            CreateSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Column in 3-D"
            CreateSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" &
    " types in 3-D format, so that you can stack different columns, and combine them " &
    "into groups across the same axis value."
            CreateSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" &
    " types in 3-D format, so that you can stack different columns, and combine them " &
    "into groups across the same axis value."
            CreateSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Column in 3-D"
            CreateSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" &
    "s in 3-D format, so that you can stack different columns, and combine them into " &
    "groups across the same axis value."
            CreateSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" &
    "s in 3-D format, so that you can stack different columns, and combine them into " &
    "groups across the same axis value."
            CreateStackedBar3DChartItem1.Caption = "Stacked Column in 3-D"
            CreateStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories and display s" &
    "tacked columns in 3-D format."
            CreateStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories and display s" &
    "tacked columns in 3-D format."
            ChartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBar3DChartItem1, CreateFullStackedBar3DChartItem1, CreateManhattanBarChartItem1, CreateSideBySideFullStackedBar3DChartItem1, CreateSideBySideStackedBar3DChartItem1, CreateStackedBar3DChartItem1})
            CreateCylinderBar3DChartItem1.Caption = "Clustered Cylinder"
            CreateCylinderBar3DChartItem1.Description = "Compare values across categories."
            CreateCylinderBar3DChartItem1.Hint = "Compare values across categories."
            CreateCylinderFullStackedBar3DChartItem1.Caption = "100% Stacked Cylinder"
            CreateCylinderFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories."
            CreateCylinderFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories."
            CreateCylinderManhattanBarChartItem1.Caption = "3-D Cylinder"
            CreateCylinderManhattanBarChartItem1.Description = "Compare values across categories and across series and display a cylinder chart o" &
    "n three axes."
            CreateCylinderManhattanBarChartItem1.Hint = "Compare values across categories and across series and display a cylinder chart o" &
    "n three axes."
            CreateCylinderSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Cylinder"
            CreateCylinderSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" &
    "hart types, so that you can stack different cylinders, and combine them into gro" &
    "ups across the same axis value."
            CreateCylinderSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" &
    "hart types, so that you can stack different cylinders, and combine them into gro" &
    "ups across the same axis value."
            CreateCylinderSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Cylinder"
            CreateCylinderSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " &
    "types, so that you can stack different cylinders, and combine them into groups a" &
    "cross the same axis value."
            CreateCylinderSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " &
    "types, so that you can stack different cylinders, and combine them into groups a" &
    "cross the same axis value."
            CreateCylinderStackedBar3DChartItem1.Caption = "Stacked Cylinder"
            CreateCylinderStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories."
            CreateCylinderStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories."
            ChartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateCylinderBar3DChartItem1, CreateCylinderFullStackedBar3DChartItem1, CreateCylinderManhattanBarChartItem1, CreateCylinderSideBySideFullStackedBar3DChartItem1, CreateCylinderSideBySideStackedBar3DChartItem1, CreateCylinderStackedBar3DChartItem1})
            CreateConeBar3DChartItem1.Caption = "Clustered Cone"
            CreateConeBar3DChartItem1.Description = "Compare values across categories."
            CreateConeBar3DChartItem1.Hint = "Compare values across categories."
            CreateConeFullStackedBar3DChartItem1.Caption = "100% Stacked Cone"
            CreateConeFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories."
            CreateConeFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories."
            CreateConeManhattanBarChartItem1.Caption = "3-D Cone"
            CreateConeManhattanBarChartItem1.Description = "Compare values across categories and across series and display a cone chart on th" &
    "ree axes."
            CreateConeManhattanBarChartItem1.Hint = "Compare values across categories and across series and display a cone chart on th" &
    "ree axes."
            CreateConeSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Cone"
            CreateConeSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" &
    "es, so that you can stack different cones, and combine them into groups across t" &
    "he same axis value."
            CreateConeSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" &
    "es, so that you can stack different cones, and combine them into groups across t" &
    "he same axis value."
            CreateConeSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Cone"
            CreateConeSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" &
    "o that you can stack different cones, and combine them into groups across the sa" &
    "me axis value."
            CreateConeSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" &
    "o that you can stack different cones, and combine them into groups across the sa" &
    "me axis value."
            CreateConeStackedBar3DChartItem1.Caption = "Stacked Cone"
            CreateConeStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories."
            CreateConeStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories."
            ChartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateConeBar3DChartItem1, CreateConeFullStackedBar3DChartItem1, CreateConeManhattanBarChartItem1, CreateConeSideBySideFullStackedBar3DChartItem1, CreateConeSideBySideStackedBar3DChartItem1, CreateConeStackedBar3DChartItem1})
            CreatePyramidBar3DChartItem1.Caption = "Clustered Pyramid"
            CreatePyramidBar3DChartItem1.Description = "Compare values across categories."
            CreatePyramidBar3DChartItem1.Hint = "Compare values across categories."
            CreatePyramidFullStackedBar3DChartItem1.Caption = "100% Stacked Pyramid"
            CreatePyramidFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories."
            CreatePyramidFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories."
            CreatePyramidManhattanBarChartItem1.Caption = "3-D Pyramid"
            CreatePyramidManhattanBarChartItem1.Description = "Compare values across categories and across series and display a pyramid chart on" &
    " three axes."
            CreatePyramidManhattanBarChartItem1.Hint = "Compare values across categories and across series and display a pyramid chart on" &
    " three axes."
            CreatePyramidSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Pyramid"
            CreatePyramidSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" &
    "rt types, so that you can stack different pyramids, and combine them into groups" &
    " across the same axis value."
            CreatePyramidSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" &
    "rt types, so that you can stack different pyramids, and combine them into groups" &
    " across the same axis value."
            CreatePyramidSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Pyramid"
            CreatePyramidSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" &
    "pes, so that you can stack different pyramids, and combine them into groups acro" &
    "ss the same axis value."
            CreatePyramidSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" &
    "pes, so that you can stack different pyramids, and combine them into groups acro" &
    "ss the same axis value."
            CreatePyramidStackedBar3DChartItem1.Caption = "Stacked Pyramid"
            CreatePyramidStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories."
            CreatePyramidStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories."
            ChartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePyramidBar3DChartItem1, CreatePyramidFullStackedBar3DChartItem1, CreatePyramidManhattanBarChartItem1, CreatePyramidSideBySideFullStackedBar3DChartItem1, CreatePyramidSideBySideStackedBar3DChartItem1, CreatePyramidStackedBar3DChartItem1})
            Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DColumn1, ChartControlCommandGalleryItemGroup3DColumn1, ChartControlCommandGalleryItemGroupCylinderColumn1, ChartControlCommandGalleryItemGroupConeColumn1, ChartControlCommandGalleryItemGroupPyramidColumn1})
            Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown1.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown1.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
            '
            'commandBarGalleryDropDown2
            '
            '
            '
            '
            Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown2.Gallery.ColumnCount = 3
            CreateLineChartItem2.Caption = "Line"
            CreateLineChartItem2.Description = "Displays trend overtime (dates, years) or ordered categories. Useful when there a" &
    "re many data points and the order is important."
            CreateLineChartItem2.Hint = "Displays trend overtime (dates, years) or ordered categories. Useful when there a" &
    "re many data points and the order is important."
            CreateFullStackedLineChartItem2.Caption = "100% Stacked Line"
            CreateFullStackedLineChartItem2.Description = "Displays the trend of the percentage each value contributes over time or ordered " &
    "categories."
            CreateFullStackedLineChartItem2.Hint = "Displays the trend of the percentage each value contributes over time or ordered " &
    "categories."
            CreateScatterLineChartItem2.Caption = "Scatter Line"
            CreateScatterLineChartItem2.Description = "Represent series points in the same order that they have in the collection."
            CreateScatterLineChartItem2.Hint = "Represent series points in the same order that they have in the collection."
            CreateSplineChartItem2.Caption = "Spline"
            CreateSplineChartItem2.Description = "Plot a fitted curve through each data point in a series."
            CreateSplineChartItem2.Hint = "Plot a fitted curve through each data point in a series."
            CreateStackedLineChartItem2.Caption = "Stacked Line"
            CreateStackedLineChartItem2.Description = "Displays the trend of the contribution of each value over time or ordered categor" &
    "ies."
            CreateStackedLineChartItem2.Hint = "Displays the trend of the contribution of each value over time or ordered categor" &
    "ies."
            CreateStepLineChartItem2.Caption = "Step Line"
            CreateStepLineChartItem2.Description = "Show to what extent values have changed for different points in the same series."
            CreateStepLineChartItem2.Hint = "Show to what extent values have changed for different points in the same series."
            ChartControlCommandGalleryItemGroup2DLine2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLineChartItem2, CreateFullStackedLineChartItem2, CreateScatterLineChartItem2, CreateSplineChartItem2, CreateStackedLineChartItem2, CreateStepLineChartItem2})
            CreateLine3DChartItem2.Caption = "3-D Line"
            CreateLine3DChartItem2.Description = "Displays each row or column of data as a 3-D ribbon on three axes."
            CreateLine3DChartItem2.Hint = "Displays each row or column of data as a 3-D ribbon on three axes."
            CreateFullStackedLine3DChartItem2.Caption = "100% Stacked Line in 3-D"
            CreateFullStackedLine3DChartItem2.Description = "Displays all series stacked and is useful when it is necessary to compare how muc" &
    "h each series adds to the total aggregate value for specific arguments (as perce" &
    "nts)."
            CreateFullStackedLine3DChartItem2.Hint = "Displays all series stacked and is useful when it is necessary to compare how muc" &
    "h each series adds to the total aggregate value for specific arguments (as perce" &
    "nts)."
            CreateSpline3DChartItem2.Caption = "3-D Spline"
            CreateSpline3DChartItem2.Description = "Plot a fitted curve through each data point in a series."
            CreateSpline3DChartItem2.Hint = "Plot a fitted curve through each data point in a series."
            CreateStackedLine3DChartItem2.Caption = "Stacked Line in 3-D"
            CreateStackedLine3DChartItem2.Description = "Displays all points from different series in a stacked manner and is useful when " &
    "it is necessary to compare how much each series adds to the total aggregate valu" &
    "e for specific arguments."
            CreateStackedLine3DChartItem2.Hint = "Displays all points from different series in a stacked manner and is useful when " &
    "it is necessary to compare how much each series adds to the total aggregate valu" &
    "e for specific arguments."
            CreateStepLine3DChartItem2.Caption = "Step Line in 3-D"
            CreateStepLine3DChartItem2.Description = "Show to what extent values have changed for different points in the same series."
            CreateStepLine3DChartItem2.Hint = "Show to what extent values have changed for different points in the same series."
            ChartControlCommandGalleryItemGroup3DLine2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLine3DChartItem2, CreateFullStackedLine3DChartItem2, CreateSpline3DChartItem2, CreateStackedLine3DChartItem2, CreateStepLine3DChartItem2})
            Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DLine2, ChartControlCommandGalleryItemGroup3DLine2})
            Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown2.Gallery.RowCount = 4
            Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown2.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
            '
            'commandBarGalleryDropDown3
            '
            '
            '
            '
            Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown3.Gallery.ColumnCount = 3
            CreatePieChartItem2.Caption = "Pie"
            CreatePieChartItem2.Description = "Displays the contribution of each value to a total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the values can" &
    " be added together or when you have only one data series and all values are posi" &
    "tive."
            CreatePieChartItem2.Hint = "Displays the contribution of each value to a total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the values can" &
    " be added together or when you have only one data series and all values are posi" &
    "tive."
            CreateDoughnutChartItem2.Caption = "Doughnut"
            CreateDoughnutChartItem2.Description = "Displays the contribution of each value to a total like a pie chart, but it can c" &
    "ontain multiple series."
            CreateDoughnutChartItem2.Hint = "Displays the contribution of each value to a total like a pie chart, but it can c" &
    "ontain multiple series."
            CreateNestedDoughnutChartItem2.Caption = "Nested Doughnut"
            CreateNestedDoughnutChartItem2.Description = "Displays the contribution of each value to a total while comparing series with on" &
    "e doughnut nested in another one."
            CreateNestedDoughnutChartItem2.Hint = "Displays the contribution of each value to a total while comparing series with on" &
    "e doughnut nested in another one."
            ChartControlCommandGalleryItemGroup2DPie2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePieChartItem2, CreateDoughnutChartItem2, CreateNestedDoughnutChartItem2})
            CreatePie3DChartItem2.Caption = "Pie in 3-D"
            CreatePie3DChartItem2.Description = "Displays the contribution of each value to a total."
            CreatePie3DChartItem2.Hint = "Displays the contribution of each value to a total."
            CreateDoughnut3DChartItem2.Caption = "Doughnut in 3-D"
            CreateDoughnut3DChartItem2.Description = "Compare the percentage values of different point arguments in the same series, an" &
    "d illustrate these values as easy to understand pie slices, but with a hole in i" &
    "ts center."
            CreateDoughnut3DChartItem2.Hint = "Compare the percentage values of different point arguments in the same series, an" &
    "d illustrate these values as easy to understand pie slices, but with a hole in i" &
    "ts center."
            ChartControlCommandGalleryItemGroup3DPie2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePie3DChartItem2, CreateDoughnut3DChartItem2})
            Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DPie2, ChartControlCommandGalleryItemGroup3DPie2})
            Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown3.Gallery.RowCount = 2
            Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown3.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
            '
            'commandBarGalleryDropDown4
            '
            '
            '
            '
            Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown4.Gallery.ColumnCount = 3
            CreateRotatedBarChartItem2.Caption = "Bar"
            CreateRotatedBarChartItem2.Description = "Insert a bar chart." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bar charts are the best chart type for comparing multiple " &
    "values."
            CreateRotatedBarChartItem2.Hint = "Insert a bar chart." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bar charts are the best chart type for comparing multiple " &
    "values."
            CreateRotatedFullStackedBarChartItem2.Caption = "100% Stacked Bar"
            CreateRotatedFullStackedBarChartItem2.Description = resources.GetString("CreateRotatedFullStackedBarChartItem2.Description")
            CreateRotatedFullStackedBarChartItem2.Hint = resources.GetString("CreateRotatedFullStackedBarChartItem2.Hint")
            CreateRotatedSideBySideFullStackedBarChartItem2.Caption = "Clustered 100% Stacked Bar"
            CreateRotatedSideBySideFullStackedBarChartItem2.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" &
    ", so you can stack different bars, and combine them into groups across the same " &
    "axis value."
            CreateRotatedSideBySideFullStackedBarChartItem2.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" &
    ", so you can stack different bars, and combine them into groups across the same " &
    "axis value."
            CreateRotatedSideBySideStackedBarChartItem2.Caption = "Clustered Stacked Bar"
            CreateRotatedSideBySideStackedBarChartItem2.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " &
    "that you can stack different bars, and combine them into groups across the same " &
    "axis value."
            CreateRotatedSideBySideStackedBarChartItem2.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " &
    "that you can stack different bars, and combine them into groups across the same " &
    "axis value."
            CreateRotatedStackedBarChartItem2.Caption = "Stacked Bar"
            CreateRotatedStackedBarChartItem2.Description = "Compare the contribution of each value to a total across categories by using hori" &
    "zontal rectangles."
            CreateRotatedStackedBarChartItem2.Hint = "Compare the contribution of each value to a total across categories by using hori" &
    "zontal rectangles."
            ChartControlCommandGalleryItemGroup2DBar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRotatedBarChartItem2, CreateRotatedFullStackedBarChartItem2, CreateRotatedSideBySideFullStackedBarChartItem2, CreateRotatedSideBySideStackedBarChartItem2, CreateRotatedStackedBarChartItem2})
            Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DBar2})
            Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown4.Gallery.RowCount = 2
            Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown4.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
            '
            'commandBarGalleryDropDown5
            '
            '
            '
            '
            Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 4
            CreateAreaChartItem2.Caption = "Area"
            CreateAreaChartItem2.Description = "Displays the trend of values over time or categories."
            CreateAreaChartItem2.Hint = "Displays the trend of values over time or categories."
            CreateFullStackedAreaChartItem2.Caption = "100% Stacked Area"
            CreateFullStackedAreaChartItem2.Description = "Displays the trend of the percentage each value contributes over time or categori" &
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the trend in the proportion of each series."
            CreateFullStackedAreaChartItem2.Hint = "Displays the trend of the percentage each value contributes over time or categori" &
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the trend in the proportion of each series."
            CreateFullStackedSplineAreaChartItem2.Caption = "100% Stacked Spline Area"
            CreateFullStackedSplineAreaChartItem2.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" &
    "int in a series."
            CreateFullStackedSplineAreaChartItem2.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" &
    "int in a series."
            CreateSplineAreaChartItem2.Caption = "Spline Area"
            CreateSplineAreaChartItem2.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" &
    " series."
            CreateSplineAreaChartItem2.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" &
    " series."
            CreateStackedAreaChartItem2.Caption = "Stacked Area"
            CreateStackedAreaChartItem2.Description = "Displays the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Use it to emphasize the trend in the total across series for one category."
            CreateStackedAreaChartItem2.Hint = "Displays the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Use it to emphasize the trend in the total across series for one category."
            CreateStackedSplineAreaChartItem2.Caption = "Stacked Spline Area"
            CreateStackedSplineAreaChartItem2.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" &
    "int in a series."
            CreateStackedSplineAreaChartItem2.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" &
    "int in a series."
            CreateStepAreaChartItem2.Caption = "Step Area"
            CreateStepAreaChartItem2.Description = "Show how much values have changed for different points of the same series."
            CreateStepAreaChartItem2.Hint = "Show how much values have changed for different points of the same series."
            ChartControlCommandGalleryItemGroup2DArea2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateAreaChartItem2, CreateFullStackedAreaChartItem2, CreateFullStackedSplineAreaChartItem2, CreateSplineAreaChartItem2, CreateStackedAreaChartItem2, CreateStackedSplineAreaChartItem2, CreateStepAreaChartItem2})
            CreateArea3DChartItem2.Caption = "3-D Area"
            CreateArea3DChartItem2.Description = resources.GetString("CreateArea3DChartItem2.Description")
            CreateArea3DChartItem2.Hint = resources.GetString("CreateArea3DChartItem2.Hint")
            CreateFullStackedArea3DChartItem2.Caption = "100% Stacked Area in 3-D"
            CreateFullStackedArea3DChartItem2.Description = resources.GetString("CreateFullStackedArea3DChartItem2.Description")
            CreateFullStackedArea3DChartItem2.Hint = resources.GetString("CreateFullStackedArea3DChartItem2.Hint")
            CreateFullStackedSplineArea3DChartItem2.Caption = "100% Stacked Spline Area in 3-D"
            CreateFullStackedSplineArea3DChartItem2.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " &
    "each data point in a series."
            CreateFullStackedSplineArea3DChartItem2.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " &
    "each data point in a series."
            CreateSplineArea3DChartItem2.Caption = "Spline Area in 3-D"
            CreateSplineArea3DChartItem2.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " &
    "in a series."
            CreateSplineArea3DChartItem2.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " &
    "in a series."
            CreateStackedArea3DChartItem2.Caption = "Stacked Area in 3-D"
            CreateStackedArea3DChartItem2.Description = "Displays series as areas on a diagram, so that the value of each data point is ag" &
    "gregated with the underlying data points' values."
            CreateStackedArea3DChartItem2.Hint = "Displays series as areas on a diagram, so that the value of each data point is ag" &
    "gregated with the underlying data points' values."
            CreateStackedSplineArea3DChartItem2.Caption = "Stacked Spline Area in 3-D"
            CreateStackedSplineArea3DChartItem2.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " &
    "data point in a series."
            CreateStackedSplineArea3DChartItem2.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " &
    "data point in a series."
            CreateStepArea3DChartItem2.Caption = "Step Area in 3-D"
            CreateStepArea3DChartItem2.Description = "Show to what extent values have changed for different points in the same series."
            CreateStepArea3DChartItem2.Hint = "Show to what extent values have changed for different points in the same series."
            ChartControlCommandGalleryItemGroup3DArea2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateArea3DChartItem2, CreateFullStackedArea3DChartItem2, CreateFullStackedSplineArea3DChartItem2, CreateSplineArea3DChartItem2, CreateStackedArea3DChartItem2, CreateStackedSplineArea3DChartItem2, CreateStepArea3DChartItem2})
            Me.commandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DArea2, ChartControlCommandGalleryItemGroup3DArea2})
            Me.commandBarGalleryDropDown5.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown5.Gallery.RowCount = 5
            Me.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown5.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
            '
            'commandBarGalleryDropDown6
            '
            '
            '
            '
            Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown6.Gallery.ColumnCount = 4
            CreatePointChartItem2.Caption = "Point"
            CreatePointChartItem2.Description = "Use it when it's necessary to show stand-alone data points on the same chart plot" &
    "."
            CreatePointChartItem2.Hint = "Use it when it's necessary to show stand-alone data points on the same chart plot" &
    "."
            CreateBubbleChartItem2.Caption = "Bubble"
            CreateBubbleChartItem2.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" &
    "ird value determines the size of the bubble marker."
            CreateBubbleChartItem2.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" &
    "ird value determines the size of the bubble marker."
            ChartControlCommandGalleryItemGroupPoint2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePointChartItem2, CreateBubbleChartItem2})
            CreateFunnelChartItem2.Caption = "Funnel"
            CreateFunnelChartItem2.Description = resources.GetString("CreateFunnelChartItem2.Description")
            CreateFunnelChartItem2.Hint = resources.GetString("CreateFunnelChartItem2.Hint")
            CreateFunnel3DChartItem2.Caption = "3-D Funnel"
            CreateFunnel3DChartItem2.Description = resources.GetString("CreateFunnel3DChartItem2.Description")
            CreateFunnel3DChartItem2.Hint = resources.GetString("CreateFunnel3DChartItem2.Hint")
            ChartControlCommandGalleryItemGroupFunnel2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateFunnelChartItem2, CreateFunnel3DChartItem2})
            CreateStockChartItem2.Caption = "Stock"
            CreateStockChartItem2.Description = resources.GetString("CreateStockChartItem2.Description")
            CreateStockChartItem2.Hint = resources.GetString("CreateStockChartItem2.Hint")
            CreateCandleStickChartItem2.Caption = "Candle Stick"
            CreateCandleStickChartItem2.Description = resources.GetString("CreateCandleStickChartItem2.Description")
            CreateCandleStickChartItem2.Hint = resources.GetString("CreateCandleStickChartItem2.Hint")
            ChartControlCommandGalleryItemGroupFinancial2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateStockChartItem2, CreateCandleStickChartItem2})
            CreateRadarPointChartItem2.Caption = "Radar Point"
            CreateRadarPointChartItem2.Description = "Show points from two or more different series on the same points arguments on a c" &
    "ircular grid that has multiple axes along which data can be plotted."
            CreateRadarPointChartItem2.Hint = "Show points from two or more different series on the same points arguments on a c" &
    "ircular grid that has multiple axes along which data can be plotted."
            CreateRadarLineChartItem2.Caption = "Radar Line"
            CreateRadarLineChartItem2.Description = "Show trends for several series and compare their values for the same points argum" &
    "ents on a circular grid that has multiple axes along which data can be plotted."
            CreateRadarLineChartItem2.Hint = "Show trends for several series and compare their values for the same points argum" &
    "ents on a circular grid that has multiple axes along which data can be plotted."
            CreateRadarAreaChartItem2.Caption = "Radar Area"
            CreateRadarAreaChartItem2.Description = "Displays series as filled area on a circular grid that has multiple axes along wh" &
    "ich data can be plotted."
            CreateRadarAreaChartItem2.Hint = "Displays series as filled area on a circular grid that has multiple axes along wh" &
    "ich data can be plotted."
            ChartControlCommandGalleryItemGroupRadar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRadarPointChartItem2, CreateRadarLineChartItem2, CreateRadarAreaChartItem2})
            CreatePolarPointChartItem2.Caption = "Polar Point"
            CreatePolarPointChartItem2.Description = "Show points from two or more different series on the same circular diagram on the" &
    " basis of angles."
            CreatePolarPointChartItem2.Hint = "Show points from two or more different series on the same circular diagram on the" &
    " basis of angles."
            CreatePolarLineChartItem2.Caption = "Polar Line"
            CreatePolarLineChartItem2.Description = "Show trends for several series and compare their values for the same points argum" &
    "ents on a circular diagram on the basis of angles."
            CreatePolarLineChartItem2.Hint = "Show trends for several series and compare their values for the same points argum" &
    "ents on a circular diagram on the basis of angles."
            CreatePolarAreaChartItem2.Caption = "Polar Area"
            CreatePolarAreaChartItem2.Description = "Displays series as filled area on a circular diagram on the basis of angles."
            CreatePolarAreaChartItem2.Hint = "Displays series as filled area on a circular diagram on the basis of angles."
            ChartControlCommandGalleryItemGroupPolar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePolarPointChartItem2, CreatePolarLineChartItem2, CreatePolarAreaChartItem2})
            CreateRangeBarChartItem2.Caption = "Range Column"
            CreateRangeBarChartItem2.Description = "Displays vertical columns along the Y-axis (the axis of values). Each column repr" &
    "esents a range of data for each argument value."
            CreateRangeBarChartItem2.Hint = "Displays vertical columns along the Y-axis (the axis of values). Each column repr" &
    "esents a range of data for each argument value."
            CreateSideBySideRangeBarChartItem2.Caption = "Clustered Range Column"
            CreateSideBySideRangeBarChartItem2.Description = "Show activity columns from different series grouped by their arguments. Each colu" &
    "mn represents a range of data with two values for each argument value."
            CreateSideBySideRangeBarChartItem2.Hint = "Show activity columns from different series grouped by their arguments. Each colu" &
    "mn represents a range of data with two values for each argument value."
            CreateRangeAreaChartItem2.Caption = "Range Area"
            CreateRangeAreaChartItem2.Description = resources.GetString("CreateRangeAreaChartItem2.Description")
            CreateRangeAreaChartItem2.Hint = resources.GetString("CreateRangeAreaChartItem2.Hint")
            CreateRangeArea3DChartItem2.Caption = "Range Area in 3-D"
            CreateRangeArea3DChartItem2.Description = resources.GetString("CreateRangeArea3DChartItem2.Description")
            CreateRangeArea3DChartItem2.Hint = resources.GetString("CreateRangeArea3DChartItem2.Hint")
            ChartControlCommandGalleryItemGroupRange2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRangeBarChartItem2, CreateSideBySideRangeBarChartItem2, CreateRangeAreaChartItem2, CreateRangeArea3DChartItem2})
            CreateGanttChartItem2.Caption = "Gantt"
            CreateGanttChartItem2.Description = "Track different activities during the time frame."
            CreateGanttChartItem2.Hint = "Track different activities during the time frame."
            CreateSideBySideGanttChartItem2.Caption = "Clustered Gantt"
            CreateSideBySideGanttChartItem2.Description = resources.GetString("CreateSideBySideGanttChartItem2.Description")
            CreateSideBySideGanttChartItem2.Hint = resources.GetString("CreateSideBySideGanttChartItem2.Hint")
            ChartControlCommandGalleryItemGroupGantt2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateGanttChartItem2, CreateSideBySideGanttChartItem2})
            Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroupPoint2, ChartControlCommandGalleryItemGroupFunnel2, ChartControlCommandGalleryItemGroupFinancial2, ChartControlCommandGalleryItemGroupRadar2, ChartControlCommandGalleryItemGroupPolar2, ChartControlCommandGalleryItemGroupRange2, ChartControlCommandGalleryItemGroupGantt2})
            Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown6.Gallery.RowCount = 9
            Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown6.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
            '
            'commandBarGalleryDropDown7
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
            SkinPaddingEdges1.Bottom = -3
            SkinPaddingEdges1.Top = -3
            Me.commandBarGalleryDropDown7.Gallery.ItemImagePadding = SkinPaddingEdges1
            SkinPaddingEdges2.Bottom = -3
            SkinPaddingEdges2.Top = -3
            Me.commandBarGalleryDropDown7.Gallery.ItemTextPadding = SkinPaddingEdges2
            Me.commandBarGalleryDropDown7.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown7.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown7.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
            '
            'commandBarGalleryDropDown8
            '
            '
            '
            '
            Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown8.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(80, 50)
            Me.commandBarGalleryDropDown8.Gallery.RowCount = 4
            Me.commandBarGalleryDropDown8.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
            Me.commandBarGalleryDropDown8.Manager = Me.BarManager1
            Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
            '
            'chartTypeBar1
            '
            Me.chartTypeBar1.BarName = ""
            Me.chartTypeBar1.Control = Me.chartControl1
            Me.chartTypeBar1.DockCol = 0
            Me.chartTypeBar1.DockRow = 0
            Me.chartTypeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartTypeBar1.Text = ""
            '
            'chartAppearanceBar1
            '
            Me.chartAppearanceBar1.BarName = ""
            Me.chartAppearanceBar1.Control = Me.chartControl1
            Me.chartAppearanceBar1.DockCol = 1
            Me.chartAppearanceBar1.DockRow = 0
            Me.chartAppearanceBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartAppearanceBar1.Text = ""
            '
            'chartTemplatesBar1
            '
            Me.chartTemplatesBar1.BarName = ""
            Me.chartTemplatesBar1.Control = Me.chartControl1
            Me.chartTemplatesBar1.DockCol = 1
            Me.chartTemplatesBar1.DockRow = 1
            Me.chartTemplatesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartTemplatesBar1.Text = ""
            '
            'chartPrintExportBar1
            '
            Me.chartPrintExportBar1.BarName = ""
            Me.chartPrintExportBar1.Control = Me.chartControl1
            Me.chartPrintExportBar1.DockCol = 2
            Me.chartPrintExportBar1.DockRow = 1
            Me.chartPrintExportBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartPrintExportBar1.Text = ""
            '
            'BarManager1
            '
            Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.ChartTypeBar2, Me.ChartAppearanceBar2, Me.ChartDesignerBar1, Me.ChartTemplatesBar2, Me.ChartPrintExportBar2})
            Me.BarManager1.DockControls.Add(Me.barDockControlTop)
            Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager1.DockControls.Add(Me.barDockControlRight)
            Me.BarManager1.Form = Me
            Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CreateBarBaseItem1, Me.CreateLineBaseItem1, Me.CreatePieBaseItem1, Me.CreateRotatedBarBaseItem1, Me.CreateAreaBaseItem1, Me.CreateOtherSeriesTypesBaseItem1, Me.ChangePaletteGalleryBaseItem1, Me.ChangeAppearanceGalleryBaseBarManagerItem1, Me.RunDesignerChartItem1, Me.SaveAsTemplateChartItem1, Me.LoadTemplateChartItem1, Me.PrintPreviewChartItem1, Me.PrintChartItem1, Me.CreateExportBaseItem1, Me.ExportToPDFChartItem1, Me.ExportToHTMLChartItem1, Me.ExportToMHTChartItem1, Me.ExportToXLSChartItem1, Me.ExportToXLSXChartItem1, Me.ExportToRTFChartItem1, Me.ExportToBMPChartItem1, Me.ExportToGIFChartItem1, Me.ExportToJPEGChartItem1, Me.ExportToPNGChartItem1, Me.ExportToTIFFChartItem1, Me.CreateExportToImageBaseItem1})
            Me.BarManager1.MaxItemId = 26
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(1401, 61)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 607)
            Me.barDockControlBottom.Manager = Me.BarManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(1401, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 61)
            Me.barDockControlLeft.Manager = Me.BarManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 546)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1401, 61)
            Me.barDockControlRight.Manager = Me.BarManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 546)
            '
            'ChartBarController1
            '
            Me.ChartBarController1.BarItems.Add(Me.CreateBarBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreateLineBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreatePieBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreateRotatedBarBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreateAreaBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreateOtherSeriesTypesBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.ChangePaletteGalleryBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.ChangeAppearanceGalleryBaseBarManagerItem1)
            Me.ChartBarController1.BarItems.Add(Me.RunDesignerChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.SaveAsTemplateChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.LoadTemplateChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.PrintPreviewChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.PrintChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToPDFChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToHTMLChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToMHTChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToXLSChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToXLSXChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToRTFChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToBMPChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToGIFChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToJPEGChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToPNGChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.ExportToTIFFChartItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreateExportToImageBaseItem1)
            Me.ChartBarController1.BarItems.Add(Me.CreateExportBaseItem1)
            Me.ChartBarController1.Control = Me.chartControl1
            '
            'ChartTypeBar2
            '
            Me.ChartTypeBar2.Control = Me.chartControl1
            Me.ChartTypeBar2.DockCol = 0
            Me.ChartTypeBar2.DockRow = 1
            Me.ChartTypeBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.ChartTypeBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CreateBarBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateLineBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreatePieBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateRotatedBarBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateAreaBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateOtherSeriesTypesBaseItem1)})
            Me.ChartTypeBar2.Offset = 959
            '
            'CreateBarBaseItem1
            '
            Me.CreateBarBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown9
            Me.CreateBarBaseItem1.Id = 0
            Me.CreateBarBaseItem1.Name = "CreateBarBaseItem1"
            '
            'CommandBarGalleryDropDown9
            '
            '
            '
            '
            ChartControlCommandGalleryItemGroup2DColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBarChartItem2, CreateFullStackedBarChartItem2, CreateSideBySideFullStackedBarChartItem2, CreateSideBySideStackedBarChartItem2, CreateStackedBarChartItem2, CreateWaterfallChartItem1})
            ChartControlCommandGalleryItemGroup3DColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBar3DChartItem2, CreateFullStackedBar3DChartItem2, CreateManhattanBarChartItem2, CreateSideBySideFullStackedBar3DChartItem2, CreateSideBySideStackedBar3DChartItem2, CreateStackedBar3DChartItem2})
            ChartControlCommandGalleryItemGroupCylinderColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateCylinderBar3DChartItem2, CreateCylinderFullStackedBar3DChartItem2, CreateCylinderManhattanBarChartItem2, CreateCylinderSideBySideFullStackedBar3DChartItem2, CreateCylinderSideBySideStackedBar3DChartItem2, CreateCylinderStackedBar3DChartItem2})
            ChartControlCommandGalleryItemGroupConeColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateConeBar3DChartItem2, CreateConeFullStackedBar3DChartItem2, CreateConeManhattanBarChartItem2, CreateConeSideBySideFullStackedBar3DChartItem2, CreateConeSideBySideStackedBar3DChartItem2, CreateConeStackedBar3DChartItem2})
            ChartControlCommandGalleryItemGroupPyramidColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePyramidBar3DChartItem2, CreatePyramidFullStackedBar3DChartItem2, CreatePyramidManhattanBarChartItem2, CreatePyramidSideBySideFullStackedBar3DChartItem2, CreatePyramidSideBySideStackedBar3DChartItem2, CreatePyramidStackedBar3DChartItem2})
            Me.CommandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DColumn2, ChartControlCommandGalleryItemGroup3DColumn2, ChartControlCommandGalleryItemGroupCylinderColumn2, ChartControlCommandGalleryItemGroupConeColumn2, ChartControlCommandGalleryItemGroupPyramidColumn2})
            Me.CommandBarGalleryDropDown9.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown9.Name = "CommandBarGalleryDropDown9"
            '
            'CreateLineBaseItem1
            '
            Me.CreateLineBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown10
            Me.CreateLineBaseItem1.Id = 1
            Me.CreateLineBaseItem1.Name = "CreateLineBaseItem1"
            '
            'CommandBarGalleryDropDown10
            '
            '
            '
            '
            ChartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLineChartItem1, CreateFullStackedLineChartItem1, CreateScatterLineChartItem1, CreateSplineChartItem1, CreateStackedLineChartItem1, CreateStepLineChartItem1})
            ChartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLine3DChartItem1, CreateFullStackedLine3DChartItem1, CreateSpline3DChartItem1, CreateStackedLine3DChartItem1, CreateStepLine3DChartItem1})
            Me.CommandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DLine1, ChartControlCommandGalleryItemGroup3DLine1})
            Me.CommandBarGalleryDropDown10.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown10.Name = "CommandBarGalleryDropDown10"
            '
            'CreatePieBaseItem1
            '
            Me.CreatePieBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown11
            Me.CreatePieBaseItem1.Id = 2
            Me.CreatePieBaseItem1.Name = "CreatePieBaseItem1"
            '
            'CommandBarGalleryDropDown11
            '
            '
            '
            '
            ChartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePieChartItem1, CreateDoughnutChartItem1, CreateNestedDoughnutChartItem1})
            ChartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePie3DChartItem1, CreateDoughnut3DChartItem1})
            Me.CommandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DPie1, ChartControlCommandGalleryItemGroup3DPie1})
            Me.CommandBarGalleryDropDown11.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown11.Name = "CommandBarGalleryDropDown11"
            '
            'CreateRotatedBarBaseItem1
            '
            Me.CreateRotatedBarBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown12
            Me.CreateRotatedBarBaseItem1.Id = 3
            Me.CreateRotatedBarBaseItem1.Name = "CreateRotatedBarBaseItem1"
            '
            'CommandBarGalleryDropDown12
            '
            '
            '
            '
            ChartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRotatedBarChartItem1, CreateRotatedFullStackedBarChartItem1, CreateRotatedSideBySideFullStackedBarChartItem1, CreateRotatedSideBySideStackedBarChartItem1, CreateRotatedStackedBarChartItem1})
            Me.CommandBarGalleryDropDown12.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DBar1})
            Me.CommandBarGalleryDropDown12.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown12.Name = "CommandBarGalleryDropDown12"
            '
            'CreateAreaBaseItem1
            '
            Me.CreateAreaBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown13
            Me.CreateAreaBaseItem1.Id = 4
            Me.CreateAreaBaseItem1.Name = "CreateAreaBaseItem1"
            '
            'CommandBarGalleryDropDown13
            '
            '
            '
            '
            ChartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateAreaChartItem1, CreateFullStackedAreaChartItem1, CreateFullStackedSplineAreaChartItem1, CreateFullStackedStepAreaChartItem1, CreateSplineAreaChartItem1, CreateStackedAreaChartItem1, CreateStackedStepAreaChartItem1, CreateStackedSplineAreaChartItem1, CreateStepAreaChartItem1})
            ChartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateArea3DChartItem1, CreateFullStackedArea3DChartItem1, CreateFullStackedSplineArea3DChartItem1, CreateSplineArea3DChartItem1, CreateStackedArea3DChartItem1, CreateStackedSplineArea3DChartItem1, CreateStepArea3DChartItem1})
            Me.CommandBarGalleryDropDown13.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DArea1, ChartControlCommandGalleryItemGroup3DArea1})
            Me.CommandBarGalleryDropDown13.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown13.Name = "CommandBarGalleryDropDown13"
            '
            'CreateOtherSeriesTypesBaseItem1
            '
            Me.CreateOtherSeriesTypesBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown14
            Me.CreateOtherSeriesTypesBaseItem1.Id = 5
            Me.CreateOtherSeriesTypesBaseItem1.Name = "CreateOtherSeriesTypesBaseItem1"
            '
            'CommandBarGalleryDropDown14
            '
            '
            '
            '
            ChartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePointChartItem1, CreateBubbleChartItem1})
            ChartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateFunnelChartItem1, CreateFunnel3DChartItem1})
            ChartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateStockChartItem1, CreateCandleStickChartItem1})
            ChartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRadarPointChartItem1, CreateRadarLineChartItem1, CreateRadarAreaChartItem1, CreateRadarRangeAreaChartItem1, CreateScatterRadarLineChartItem1})
            ChartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePolarPointChartItem1, CreatePolarLineChartItem1, CreatePolarAreaChartItem1, CreatePolarRangeAreaChartItem1, CreateScatterPolarLineChartItem1})
            ChartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRangeBarChartItem1, CreateSideBySideRangeBarChartItem1, CreateRangeAreaChartItem1, CreateRangeArea3DChartItem1})
            ChartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateGanttChartItem1, CreateSideBySideGanttChartItem1})
            ChartControlCommandGalleryItemGroupBoxPlot1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBoxPlotChartItem1})
            Me.CommandBarGalleryDropDown14.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroupPoint1, ChartControlCommandGalleryItemGroupFunnel1, ChartControlCommandGalleryItemGroupFinancial1, ChartControlCommandGalleryItemGroupRadar1, ChartControlCommandGalleryItemGroupPolar1, ChartControlCommandGalleryItemGroupRange1, ChartControlCommandGalleryItemGroupGantt1, ChartControlCommandGalleryItemGroupBoxPlot1})
            Me.CommandBarGalleryDropDown14.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown14.Name = "CommandBarGalleryDropDown14"
            '
            'ChartAppearanceBar2
            '
            Me.ChartAppearanceBar2.Control = Me.chartControl1
            Me.ChartAppearanceBar2.DockCol = 1
            Me.ChartAppearanceBar2.DockRow = 1
            Me.ChartAppearanceBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.ChartAppearanceBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ChangePaletteGalleryBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ChangeAppearanceGalleryBaseBarManagerItem1)})
            Me.ChartAppearanceBar2.Offset = 1301
            '
            'ChangePaletteGalleryBaseItem1
            '
            Me.ChangePaletteGalleryBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown15
            Me.ChangePaletteGalleryBaseItem1.Id = 6
            Me.ChangePaletteGalleryBaseItem1.Name = "ChangePaletteGalleryBaseItem1"
            '
            'CommandBarGalleryDropDown15
            '
            Me.CommandBarGalleryDropDown15.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown15.Name = "CommandBarGalleryDropDown15"
            '
            'ChangeAppearanceGalleryBaseBarManagerItem1
            '
            Me.ChangeAppearanceGalleryBaseBarManagerItem1.DropDownControl = Me.CommandBarGalleryDropDown16
            Me.ChangeAppearanceGalleryBaseBarManagerItem1.Id = 7
            Me.ChangeAppearanceGalleryBaseBarManagerItem1.Name = "ChangeAppearanceGalleryBaseBarManagerItem1"
            '
            'CommandBarGalleryDropDown16
            '
            Me.CommandBarGalleryDropDown16.Manager = Me.BarManager1
            Me.CommandBarGalleryDropDown16.Name = "CommandBarGalleryDropDown16"
            '
            'ChartDesignerBar1
            '
            Me.ChartDesignerBar1.Control = Me.chartControl1
            Me.ChartDesignerBar1.DockCol = 0
            Me.ChartDesignerBar1.DockRow = 0
            Me.ChartDesignerBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.ChartDesignerBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.RunDesignerChartItem1)})
            Me.ChartDesignerBar1.Offset = 920
            '
            'RunDesignerChartItem1
            '
            Me.RunDesignerChartItem1.Id = 8
            Me.RunDesignerChartItem1.Name = "RunDesignerChartItem1"
            '
            'ChartTemplatesBar2
            '
            Me.ChartTemplatesBar2.Control = Me.chartControl1
            Me.ChartTemplatesBar2.DockCol = 1
            Me.ChartTemplatesBar2.DockRow = 0
            Me.ChartTemplatesBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.ChartTemplatesBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SaveAsTemplateChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.LoadTemplateChartItem1)})
            Me.ChartTemplatesBar2.Offset = 1020
            '
            'SaveAsTemplateChartItem1
            '
            Me.SaveAsTemplateChartItem1.Id = 9
            Me.SaveAsTemplateChartItem1.Name = "SaveAsTemplateChartItem1"
            '
            'LoadTemplateChartItem1
            '
            Me.LoadTemplateChartItem1.Id = 10
            Me.LoadTemplateChartItem1.Name = "LoadTemplateChartItem1"
            '
            'ChartPrintExportBar2
            '
            Me.ChartPrintExportBar2.Control = Me.chartControl1
            Me.ChartPrintExportBar2.DockCol = 2
            Me.ChartPrintExportBar2.DockRow = 0
            Me.ChartPrintExportBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.ChartPrintExportBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPreviewChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateExportBaseItem1)})
            Me.ChartPrintExportBar2.Offset = 1013
            '
            'PrintPreviewChartItem1
            '
            Me.PrintPreviewChartItem1.Id = 11
            Me.PrintPreviewChartItem1.Name = "PrintPreviewChartItem1"
            '
            'PrintChartItem1
            '
            Me.PrintChartItem1.Id = 12
            Me.PrintChartItem1.Name = "PrintChartItem1"
            '
            'ExportToPDFChartItem1
            '
            Me.ExportToPDFChartItem1.Id = 14
            Me.ExportToPDFChartItem1.Name = "ExportToPDFChartItem1"
            '
            'ExportToHTMLChartItem1
            '
            Me.ExportToHTMLChartItem1.Id = 15
            Me.ExportToHTMLChartItem1.Name = "ExportToHTMLChartItem1"
            '
            'ExportToMHTChartItem1
            '
            Me.ExportToMHTChartItem1.Id = 16
            Me.ExportToMHTChartItem1.Name = "ExportToMHTChartItem1"
            '
            'ExportToXLSChartItem1
            '
            Me.ExportToXLSChartItem1.Id = 17
            Me.ExportToXLSChartItem1.Name = "ExportToXLSChartItem1"
            '
            'ExportToXLSXChartItem1
            '
            Me.ExportToXLSXChartItem1.Id = 18
            Me.ExportToXLSXChartItem1.Name = "ExportToXLSXChartItem1"
            '
            'ExportToRTFChartItem1
            '
            Me.ExportToRTFChartItem1.Id = 19
            Me.ExportToRTFChartItem1.Name = "ExportToRTFChartItem1"
            '
            'ExportToBMPChartItem1
            '
            Me.ExportToBMPChartItem1.Id = 21
            Me.ExportToBMPChartItem1.Name = "ExportToBMPChartItem1"
            '
            'ExportToGIFChartItem1
            '
            Me.ExportToGIFChartItem1.Id = 22
            Me.ExportToGIFChartItem1.Name = "ExportToGIFChartItem1"
            '
            'ExportToJPEGChartItem1
            '
            Me.ExportToJPEGChartItem1.Id = 23
            Me.ExportToJPEGChartItem1.Name = "ExportToJPEGChartItem1"
            '
            'ExportToPNGChartItem1
            '
            Me.ExportToPNGChartItem1.Id = 24
            Me.ExportToPNGChartItem1.Name = "ExportToPNGChartItem1"
            '
            'ExportToTIFFChartItem1
            '
            Me.ExportToTIFFChartItem1.Id = 25
            Me.ExportToTIFFChartItem1.Name = "ExportToTIFFChartItem1"
            '
            'CreateExportToImageBaseItem1
            '
            Me.CreateExportToImageBaseItem1.Id = 20
            Me.CreateExportToImageBaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToBMPChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToGIFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToJPEGChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToPNGChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToTIFFChartItem1)})
            Me.CreateExportToImageBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
            Me.CreateExportToImageBaseItem1.Name = "CreateExportToImageBaseItem1"
            '
            'CreateExportBaseItem1
            '
            Me.CreateExportBaseItem1.Id = 13
            Me.CreateExportBaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToPDFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToHTMLChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToMHTChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToXLSChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToXLSXChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToRTFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateExportToImageBaseItem1)})
            Me.CreateExportBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
            Me.CreateExportBaseItem1.Name = "CreateExportBaseItem1"
            Me.CreateExportBaseItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1401, 607)
            Me.Controls.Add(Me.splitContainer1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType(SideBySideRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

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
		Private chartTypeBar1 As DevExpress.XtraCharts.UI.ChartTypeBar
		Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private chartAppearanceBar1 As DevExpress.XtraCharts.UI.ChartAppearanceBar
		Private commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private chartTemplatesBar1 As DevExpress.XtraCharts.UI.ChartTemplatesBar
		Private chartPrintExportBar1 As DevExpress.XtraCharts.UI.ChartPrintExportBar
		Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
		Friend WithEvents ChartTypeBar2 As DevExpress.XtraCharts.UI.ChartTypeBar
		Friend WithEvents CreateBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
		Friend WithEvents CommandBarGalleryDropDown9 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents CreateLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
		Friend WithEvents CommandBarGalleryDropDown10 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents CreatePieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
		Friend WithEvents CommandBarGalleryDropDown11 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents CreateRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
		Friend WithEvents CommandBarGalleryDropDown12 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents CreateAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
		Friend WithEvents CommandBarGalleryDropDown13 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents CreateOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
		Friend WithEvents CommandBarGalleryDropDown14 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents ChartAppearanceBar2 As DevExpress.XtraCharts.UI.ChartAppearanceBar
		Friend WithEvents ChangePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
		Friend WithEvents CommandBarGalleryDropDown15 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents ChangeAppearanceGalleryBaseBarManagerItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem
		Friend WithEvents CommandBarGalleryDropDown16 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Friend WithEvents ChartDesignerBar1 As DevExpress.XtraCharts.UI.ChartDesignerBar
		Friend WithEvents RunDesignerChartItem1 As DevExpress.XtraCharts.UI.RunDesignerChartItem
		Friend WithEvents ChartTemplatesBar2 As DevExpress.XtraCharts.UI.ChartTemplatesBar
		Friend WithEvents SaveAsTemplateChartItem1 As DevExpress.XtraCharts.UI.SaveAsTemplateChartItem
		Friend WithEvents LoadTemplateChartItem1 As DevExpress.XtraCharts.UI.LoadTemplateChartItem
		Friend WithEvents ChartPrintExportBar2 As DevExpress.XtraCharts.UI.ChartPrintExportBar
		Friend WithEvents PrintPreviewChartItem1 As DevExpress.XtraCharts.UI.PrintPreviewChartItem
		Friend WithEvents PrintChartItem1 As DevExpress.XtraCharts.UI.PrintChartItem
		Friend WithEvents CreateExportBaseItem1 As DevExpress.XtraCharts.UI.CreateExportBaseItem
		Friend WithEvents ExportToPDFChartItem1 As DevExpress.XtraCharts.UI.ExportToPDFChartItem
		Friend WithEvents ExportToHTMLChartItem1 As DevExpress.XtraCharts.UI.ExportToHTMLChartItem
		Friend WithEvents ExportToMHTChartItem1 As DevExpress.XtraCharts.UI.ExportToMHTChartItem
		Friend WithEvents ExportToXLSChartItem1 As DevExpress.XtraCharts.UI.ExportToXLSChartItem
		Friend WithEvents ExportToXLSXChartItem1 As DevExpress.XtraCharts.UI.ExportToXLSXChartItem
		Friend WithEvents ExportToRTFChartItem1 As DevExpress.XtraCharts.UI.ExportToRTFChartItem
		Friend WithEvents CreateExportToImageBaseItem1 As DevExpress.XtraCharts.UI.CreateExportToImageBaseItem
		Friend WithEvents ExportToBMPChartItem1 As DevExpress.XtraCharts.UI.ExportToBMPChartItem
		Friend WithEvents ExportToGIFChartItem1 As DevExpress.XtraCharts.UI.ExportToGIFChartItem
		Friend WithEvents ExportToJPEGChartItem1 As DevExpress.XtraCharts.UI.ExportToJPEGChartItem
		Friend WithEvents ExportToPNGChartItem1 As DevExpress.XtraCharts.UI.ExportToPNGChartItem
		Friend WithEvents ExportToTIFFChartItem1 As DevExpress.XtraCharts.UI.ExportToTIFFChartItem
		Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
		Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
		Friend WithEvents ChartBarController1 As DevExpress.XtraCharts.UI.ChartBarController
	End Class
End Namespace

