using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
public partial class PTKT : DevExpress.XtraReports.UI.XtraReport
{

	//XtraReport overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	//Required by the Designer

	private System.ComponentModel.IContainer components;
	//NOTE: The following procedure is required by the Designer
	//It can be modified using the Designer.  
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
		DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTKT));
		this.Detail = new DevExpress.XtraReports.UI.DetailBand();
		this.table6 = new DevExpress.XtraReports.UI.XRTable();
		this.tableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
		this.PT_ = new DevExpress.XtraReports.UI.XRTableCell();
		this.PT_TEN_PT = new DevExpress.XtraReports.UI.XRTableCell();
		this.PT_DON_VI = new DevExpress.XtraReports.UI.XRTableCell();
		this.PT_SO_LUONG = new DevExpress.XtraReports.UI.XRTableCell();
		this.PT_GT = new DevExpress.XtraReports.UI.XRTableCell();
		this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
		this.label10 = new DevExpress.XtraReports.UI.XRLabel();
		this.table5 = new DevExpress.XtraReports.UI.XRTable();
		this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
		this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
		this.table4 = new DevExpress.XtraReports.UI.XRTable();
		this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
		this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
		this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
		this.PT = new System.Data.DataSet();
		this.DataTable1 = new System.Data.DataTable();
		this.DataColumn1 = new System.Data.DataColumn();
		this.DataColumn2 = new System.Data.DataColumn();
		this.DataColumn3 = new System.Data.DataColumn();
		this.DataColumn4 = new System.Data.DataColumn();
		this.DataColumn5 = new System.Data.DataColumn();
		this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
		this.label12 = new DevExpress.XtraReports.UI.XRLabel();
		this.label15 = new DevExpress.XtraReports.UI.XRLabel();
		this.label14 = new DevExpress.XtraReports.UI.XRLabel();
		this.label13 = new DevExpress.XtraReports.UI.XRLabel();
		this.label16 = new DevExpress.XtraReports.UI.XRLabel();
		((System.ComponentModel.ISupportInitialize)this.table6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.table5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.table4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DataTable1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this).BeginInit();
		//
		//Detail
		//
		this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] { this.table6 });
		this.Detail.Height = 25;
		this.Detail.Name = "Detail";
		this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100f);
		this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
		//
		//table6
		//
		this.table6.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
		this.table6.Location = new System.Drawing.Point(0, 0);
		this.table6.Name = "table6";
		this.table6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] { this.tableRow6 });
		this.table6.Size = new System.Drawing.Size(765, 25);
		this.table6.StylePriority.UseBorders = false;
		this.table6.StylePriority.UseTextAlignment = false;
		this.table6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
		//
		//tableRow6
		//
		this.tableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
			this.PT_,
			this.PT_TEN_PT,
			this.PT_DON_VI,
			this.PT_SO_LUONG,
			this.PT_GT
		});
		this.tableRow6.Name = "tableRow6";
		this.tableRow6.Weight = 1;
		//
		//PT_
		//
		this.PT_.Name = "PT_";
		XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
		XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
		this.PT_.Summary = XrSummary1;
		this.PT_.Text = "A1";
		this.PT_.Weight = 0.252941176470588;
		//
		//PT_TEN_PT
		//
		this.PT_TEN_PT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "DmPtkt.TenPtung", "") });
		this.PT_TEN_PT.Name = "PT_TEN_PT";
		this.PT_TEN_PT.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100f);
		this.PT_TEN_PT.StylePriority.UsePadding = false;
		this.PT_TEN_PT.StylePriority.UseTextAlignment = false;
		this.PT_TEN_PT.Text = "PT_TEN_PT";
		this.PT_TEN_PT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
		this.PT_TEN_PT.Weight = 1.40588235294118;
		//
		//PT_DON_VI
		//
		this.PT_DON_VI.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "DmPtkt.TenDvt", "") });
		this.PT_DON_VI.Name = "PT_DON_VI";
		this.PT_DON_VI.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100f);
		this.PT_DON_VI.StylePriority.UsePadding = false;
		this.PT_DON_VI.StylePriority.UseTextAlignment = false;
		this.PT_DON_VI.Text = "PT_DON_VI";
		this.PT_DON_VI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
		this.PT_DON_VI.Weight = 0.423529411764706;
		//
		//PT_SO_LUONG
		//
		this.PT_SO_LUONG.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "DmPtkt.SoLuong", "") });
		this.PT_SO_LUONG.Name = "PT_SO_LUONG";
		this.PT_SO_LUONG.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100f);
		this.PT_SO_LUONG.StylePriority.UsePadding = false;
		this.PT_SO_LUONG.StylePriority.UseTextAlignment = false;
		this.PT_SO_LUONG.Text = "PT_SO_LUONG";
		this.PT_SO_LUONG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
		this.PT_SO_LUONG.Weight = 0.492156862745098;
		//
		//PT_GT
		//
		this.PT_GT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "DmPtkt.SoTien", "{0:n0}") });
		this.PT_GT.Multiline = true;
		this.PT_GT.Name = "PT_GT";
		this.PT_GT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100f);
		this.PT_GT.StylePriority.UsePadding = false;
		this.PT_GT.StylePriority.UseTextAlignment = false;
		this.PT_GT.Text = "PT_GT";
		this.PT_GT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
		this.PT_GT.Weight = 0.425490196078431;
		//
		//GroupHeader1
		//
		this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
			this.label10,
			this.table5,
			this.table4
		});
		this.GroupHeader1.Height = 92;
		this.GroupHeader1.Name = "GroupHeader1";
		//
		//label10
		//
		this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
		this.label10.Location = new System.Drawing.Point(0, 0);
		this.label10.Name = "label10";
		this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100f);
		this.label10.Size = new System.Drawing.Size(758, 25);
		this.label10.StylePriority.UseFont = false;
		this.label10.StylePriority.UseTextAlignment = false;
		this.label10.Text = "Dụng cụ, phụ tùng kèm theo";
		this.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
		//
		//table5
		//
		this.table5.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
		this.table5.Location = new System.Drawing.Point(0, 67);
		this.table5.Name = "table5";
		this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] { this.tableRow5 });
		this.table5.Size = new System.Drawing.Size(765, 25);
		this.table5.StylePriority.UseBorders = false;
		this.table5.StylePriority.UseTextAlignment = false;
		this.table5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
		//
		//tableRow5
		//
		this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
			this.tableCell23,
			this.tableCell24,
			this.tableCell25,
			this.tableCell26,
			this.tableCell27
		});
		this.tableRow5.Name = "tableRow5";
		this.tableRow5.Weight = 1;
		//
		//tableCell23
		//
		this.tableCell23.Name = "tableCell23";
		this.tableCell23.Text = "A";
		this.tableCell23.Weight = 0.252941176470588;
		//
		//tableCell24
		//
		this.tableCell24.Name = "tableCell24";
		this.tableCell24.Text = "B";
		this.tableCell24.Weight = 1.40588235294118;
		//
		//tableCell25
		//
		this.tableCell25.Name = "tableCell25";
		this.tableCell25.Text = "C";
		this.tableCell25.Weight = 0.423529411764706;
		//
		//tableCell26
		//
		this.tableCell26.Name = "tableCell26";
		this.tableCell26.Text = "1";
		this.tableCell26.Weight = 0.492156862745098;
		//
		//tableCell27
		//
		this.tableCell27.Name = "tableCell27";
		this.tableCell27.Text = "2";
		this.tableCell27.Weight = 0.425490196078431;
		//
		//table4
		//
		this.table4.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
		this.table4.Location = new System.Drawing.Point(0, 42);
		this.table4.Name = "table4";
		this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] { this.tableRow4 });
		this.table4.Size = new System.Drawing.Size(765, 25);
		this.table4.StylePriority.UseBorders = false;
		this.table4.StylePriority.UseTextAlignment = false;
		this.table4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
		//
		//tableRow4
		//
		this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
			this.tableCell21,
			this.tableCell18,
			this.tableCell19,
			this.tableCell22,
			this.tableCell20
		});
		this.tableRow4.Name = "tableRow4";
		this.tableRow4.Weight = 1;
		//
		//tableCell21
		//
		this.tableCell21.Name = "tableCell21";
		this.tableCell21.Text = "STT";
		this.tableCell21.Weight = 0.252941176470588;
		//
		//tableCell18
		//
		this.tableCell18.Name = "tableCell18";
		this.tableCell18.Text = "Tên, quy cách dụng cụ, phụ tùng";
		this.tableCell18.Weight = 1.40588235294118;
		//
		//tableCell19
		//
		this.tableCell19.Name = "tableCell19";
		this.tableCell19.Text = "Đon vị";
		this.tableCell19.Weight = 0.423529411764706;
		//
		//tableCell22
		//
		this.tableCell22.Name = "tableCell22";
		this.tableCell22.Text = "Số lượng";
		this.tableCell22.Weight = 0.492156862745098;
		//
		//tableCell20
		//
		this.tableCell20.Name = "tableCell20";
		this.tableCell20.Text = "Giá trị";
		this.tableCell20.Weight = 0.425490196078431;
		//
		//PT
		//
		this.PT.DataSetName = "NewDataSet";
		this.PT.Tables.AddRange(new System.Data.DataTable[] { this.DataTable1 });
		//
		//DataTable1
		//
		this.DataTable1.Columns.AddRange(new System.Data.DataColumn[] {
			this.DataColumn1,
			this.DataColumn2,
			this.DataColumn3,
			this.DataColumn4,
			this.DataColumn5
		});
		this.DataTable1.TableName = "PT";
		//
		//DataColumn1
		//
		this.DataColumn1.ColumnName = "DM_TSCD_ID";
		//
		//DataColumn2
		//
		this.DataColumn2.ColumnName = "TEN_PTUNG";
		//
		//DataColumn3
		//
		this.DataColumn3.ColumnName = "TEN_DVT";
		//
		//DataColumn4
		//
		this.DataColumn4.ColumnName = "SO_LUONG";
		//
		//DataColumn5
		//
		this.DataColumn5.ColumnName = "SO_TIEN";
		//
		//ReportFooter
		//
		this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
			this.label12,
			this.label15,
			this.label14,
			this.label13,
			this.label16
		});
		this.ReportFooter.Name = "ReportFooter";
		//
		//label12
		//
		this.label12.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold);
		this.label12.Location = new System.Drawing.Point(25, 17);
		this.label12.Name = "label12";
		this.label12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100f);
		this.label12.Size = new System.Drawing.Size(133, 20);
		this.label12.StylePriority.UseFont = false;
		this.label12.StylePriority.UseTextAlignment = false;
		this.label12.Text = " Người ghi sổ";
		this.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
		//
		//label15
		//
		this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Italic);
		this.label15.Location = new System.Drawing.Point(575, 67);
		this.label15.Name = "label15";
		this.label15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100f);
		this.label15.Size = new System.Drawing.Size(150, 17);
		this.label15.StylePriority.UseFont = false;
		this.label15.StylePriority.UseTextAlignment = false;
		this.label15.Text = "(Ký, họ tên, đóng dấu)";
		this.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
		//
		//label14
		//
		this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Italic);
		this.label14.Location = new System.Drawing.Point(25, 42);
		this.label14.Name = "label14";
		this.label14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100f);
		this.label14.Size = new System.Drawing.Size(100, 17);
		this.label14.StylePriority.UseFont = false;
		this.label14.StylePriority.UseTextAlignment = false;
		this.label14.Text = "(Ký, họ tên)";
		this.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
		//
		//label13
		//
		this.label13.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold);
		this.label13.Location = new System.Drawing.Point(575, 42);
		this.label13.Name = "label13";
		this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100f);
		this.label13.Size = new System.Drawing.Size(133, 20);
		this.label13.StylePriority.UseFont = false;
		this.label13.StylePriority.UseTextAlignment = false;
		this.label13.Text = "Kế toán trưởng";
		this.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
		//
		//label16
		//
		this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Italic);
		this.label16.Location = new System.Drawing.Point(525, 17);
		this.label16.Name = "label16";
		this.label16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100f);
		this.label16.Size = new System.Drawing.Size(217, 20);
		this.label16.StylePriority.UseFont = false;
		this.label16.StylePriority.UseTextAlignment = false;
		this.label16.Text = "Lập, ngày..........tháng.........năm..........";
		this.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
		//
		//PTKT
		//
		this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
			this.Detail,
			this.GroupHeader1,
			this.ReportFooter
		});
		this.DataSource = this.PT;
		this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
		this.Margins = new System.Drawing.Printing.Margins(40, 41, 100, 100);
		this.Name = "PTKT";
		this.PageHeight = 1100;
		this.PageWidth = 850;
		this.Version = "9.1";
		((System.ComponentModel.ISupportInitialize)this.table6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.table5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.table4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DataTable1).EndInit();
		((System.ComponentModel.ISupportInitialize)this).EndInit();

	}
	internal DevExpress.XtraReports.UI.DetailBand Detail;
	internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
	internal DevExpress.XtraReports.UI.XRTable table4;
	internal DevExpress.XtraReports.UI.XRTableRow tableRow4;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell21;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell18;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell19;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell22;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell20;
	internal DevExpress.XtraReports.UI.XRTable table5;
	internal DevExpress.XtraReports.UI.XRTableRow tableRow5;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell23;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell24;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell25;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell26;
	internal DevExpress.XtraReports.UI.XRTableCell tableCell27;
	internal DevExpress.XtraReports.UI.XRLabel label10;
	internal DevExpress.XtraReports.UI.XRTable table6;
	internal DevExpress.XtraReports.UI.XRTableRow tableRow6;
	internal DevExpress.XtraReports.UI.XRTableCell PT_;
	internal DevExpress.XtraReports.UI.XRTableCell PT_TEN_PT;
	internal DevExpress.XtraReports.UI.XRTableCell PT_DON_VI;
	internal DevExpress.XtraReports.UI.XRTableCell PT_SO_LUONG;
	internal DevExpress.XtraReports.UI.XRTableCell PT_GT;
	internal System.Data.DataSet PT;
	internal System.Data.DataTable DataTable1;
	internal System.Data.DataColumn DataColumn1;
	internal System.Data.DataColumn DataColumn2;
	internal System.Data.DataColumn DataColumn3;
	internal System.Data.DataColumn DataColumn4;
	internal System.Data.DataColumn DataColumn5;
	internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
	internal DevExpress.XtraReports.UI.XRLabel label12;
	internal DevExpress.XtraReports.UI.XRLabel label15;
	internal DevExpress.XtraReports.UI.XRLabel label14;
	internal DevExpress.XtraReports.UI.XRLabel label13;
	internal DevExpress.XtraReports.UI.XRLabel label16;
	public PTKT()
	{
		InitializeComponent();
	}
}
}