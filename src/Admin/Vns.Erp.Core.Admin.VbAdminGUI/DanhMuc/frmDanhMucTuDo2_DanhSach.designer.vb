Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucTuDo2_DanhSach
    Inherits FrmBaseDmDanhSach
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
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
        Me._GroupControlList = New DevExpress.XtraEditors.GroupControl()
        Me._TreeList = New DevExpress.XtraTreeList.TreeList()
        Me.lkeCoSuDung = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btExport = New Vns.Erp.Core.MultiExportButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me._SearchHelper = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._FieldChooser = New DevExpress.XtraEditors.GridLookUpEdit()
        Me._FieldChooserView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._GroupControlSearch = New DevExpress.XtraEditors.GroupControl()
        CType(Me._GroupControlList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlList.SuspendLayout()
        CType(Me._TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeCoSuDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FieldChooserView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlList
        '
        Me._GroupControlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._GroupControlList.Controls.Add(Me._TreeList)
        Me._GroupControlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlList.Location = New System.Drawing.Point(4, 64)
        Me._GroupControlList.Name = "_GroupControlList"
        Me._GroupControlList.Size = New System.Drawing.Size(1000, 507)
        Me._GroupControlList.TabIndex = 13
        Me._GroupControlList.Text = "Danh sách..."
        '
        '_TreeList
        '
        Me._TreeList.CustomizationFormBounds = New System.Drawing.Rectangle(749, 385, 216, 178)
        Me._TreeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TreeList.KeyFieldName = "DM_TUDO_2_ID"
        Me._TreeList.Location = New System.Drawing.Point(0, 0)
        Me._TreeList.Name = "_TreeList"
        Me._TreeList.ParentFieldName = "DM_TUDO_2_ID_CHA"
        Me._TreeList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkeCoSuDung})
        Me._TreeList.Size = New System.Drawing.Size(1000, 507)
        Me._TreeList.TabIndex = 0
        '
        'lkeCoSuDung
        '
        Me.lkeCoSuDung.AutoHeight = False
        Me.lkeCoSuDung.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeCoSuDung.Name = "lkeCoSuDung"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnDelete)
        Me._ActionPanel.Controls.Add(Me.btExport)
        Me._ActionPanel.Controls.Add(Me.btnPrint)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Controls.Add(Me.btnModify)
        Me._ActionPanel.Controls.Add(Me.btnCreate)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 571)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(1000, 37)
        Me._ActionPanel.TabIndex = 15
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 5
        Me.btnDelete.Location = New System.Drawing.Point(174, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Xóa"
        '
        'btExport
        '
        Me.btExport.GRID_VIEW = Me._TreeList
        Me.btExport.Location = New System.Drawing.Point(260, 5)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(135, 30)
        Me.btExport.TabIndex = 11
        Me.btExport.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.ImageIndex = 15
        Me.btnPrint.Location = New System.Drawing.Point(579, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 30)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&In"
        Me.btnPrint.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(920, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Đó&ng"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 3
        Me.btnModify.Location = New System.Drawing.Point(88, 5)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.ImageIndex = 2
        Me.btnCreate.Location = New System.Drawing.Point(2, 5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 30)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "&Mới"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(19, 31)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(65, 13)
        Me.labelControl1.TabIndex = 21
        Me.labelControl1.Text = "Tìm kiếm theo"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(260, 31)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(28, 13)
        Me.labelControl2.TabIndex = 21
        Me.labelControl2.Text = "Giá trị"
        '
        '_SearchHelper
        '
        Me._SearchHelper.EditValue = ""
        Me._SearchHelper.Location = New System.Drawing.Point(304, 28)
        Me._SearchHelper.Name = "_SearchHelper"
        Me._SearchHelper.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._SearchHelper.Properties.ImmediatePopup = True
        Me._SearchHelper.Properties.View = Me.gridLookUpEdit1View
        Me._SearchHelper.Size = New System.Drawing.Size(141, 20)
        Me._SearchHelper.TabIndex = 1
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        '_FieldChooser
        '
        Me._FieldChooser.EditValue = ""
        Me._FieldChooser.Location = New System.Drawing.Point(90, 28)
        Me._FieldChooser.Name = "_FieldChooser"
        Me._FieldChooser.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me._FieldChooser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FieldChooser.Properties.ImmediatePopup = True
        Me._FieldChooser.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder
        Me._FieldChooser.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me._FieldChooser.Properties.ShowFooter = False
        Me._FieldChooser.Properties.ShowPopupShadow = False
        Me._FieldChooser.Properties.View = Me._FieldChooserView
        Me._FieldChooser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FieldChooser.Size = New System.Drawing.Size(141, 20)
        Me._FieldChooser.TabIndex = 0
        '
        '_FieldChooserView
        '
        Me._FieldChooserView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me._FieldChooserView.Name = "_FieldChooserView"
        Me._FieldChooserView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me._FieldChooserView.OptionsView.ShowGroupPanel = False
        '
        '_GroupControlSearch
        '
        Me._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White
        Me._GroupControlSearch.Appearance.Options.UseBackColor = True
        Me._GroupControlSearch.Appearance.Options.UseBorderColor = True
        Me._GroupControlSearch.Controls.Add(Me._FieldChooser)
        Me._GroupControlSearch.Controls.Add(Me._SearchHelper)
        Me._GroupControlSearch.Controls.Add(Me.labelControl2)
        Me._GroupControlSearch.Controls.Add(Me.labelControl1)
        Me._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlSearch.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlSearch.Name = "_GroupControlSearch"
        Me._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._GroupControlSearch.Size = New System.Drawing.Size(1000, 60)
        Me._GroupControlSearch.TabIndex = 12
        Me._GroupControlSearch.Text = "Tìm kiếm"
        '
        'frmDanhMucTuDo2_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me._GroupControlList)
        Me.Controls.Add(Me._ActionPanel)
        Me.Controls.Add(Me._GroupControlSearch)
        Me.Name = "frmDanhMucTuDo2_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục tự do 2"
        CType(Me._GroupControlList, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlList.ResumeLayout(False)
        CType(Me._TreeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeCoSuDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FieldChooserView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlSearch.ResumeLayout(False)
        Me._GroupControlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlList As DevExpress.XtraEditors.GroupControl
    Friend GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Private _TreeList As DevExpress.XtraTreeList.TreeList
    Private lkeCoSuDung As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private labelControl2 As DevExpress.XtraEditors.LabelControl
    Private _SearchHelper As DevExpress.XtraEditors.GridLookUpEdit
    Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private _FieldChooser As DevExpress.XtraEditors.GridLookUpEdit
    Private _FieldChooserView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend _GroupControlSearch As DevExpress.XtraEditors.GroupControl
    Friend btnModify As DevExpress.XtraEditors.SimpleButton
    Friend btnCreate As DevExpress.XtraEditors.SimpleButton
    'Friend btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btExport As MultiExportButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton

End Class
