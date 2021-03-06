Imports Microsoft.VisualBasic
Imports System

Partial Public Class BaseGridPopupForm


    Inherits DevExpress.XtraEditors.XtraForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseGridPopupForm))
        Me.pnlHeader = New DevExpress.XtraEditors.PanelControl
        Me.txtKeyword = New DevExpress.XtraEditors.TextEdit
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        Me.lblResult = New DevExpress.XtraEditors.LabelControl
        Me.pnlFooter = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.btnChoose = New DevExpress.XtraEditors.SimpleButton
        Me.pnlBody = New DevExpress.XtraEditors.PanelControl
        Me._GridControl = New DevExpress.XtraGrid.GridControl
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.chkMarkSelection = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.txtKeyword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        CType(Me.pnlBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBody.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMarkSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.txtKeyword)
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(589, 34)
        Me.pnlHeader.TabIndex = 0
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(56, 7)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(113, 20)
        Me.txtKeyword.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(6, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(44, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Tìm kiếm:"
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(212, 6)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Visible = False
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.lblResult)
        Me.pnlFooter.Controls.Add(Me.btnCancel)
        Me.pnlFooter.Controls.Add(Me.btnChoose)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 306)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(589, 37)
        Me.pnlFooter.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.ImageList = Me.imglImporter
        Me.btnCancel.Location = New System.Drawing.Point(86, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 29)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Hủy bỏ"
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "save-as-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "close-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "copy-32x32.png")
        Me.imglImporter.Images.SetKeyName(3, "delete-32x32.png")
        Me.imglImporter.Images.SetKeyName(4, "edit-32x32.png")
        Me.imglImporter.Images.SetKeyName(5, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(6, "open-32x32.png")
        Me.imglImporter.Images.SetKeyName(7, "preview-32x32.png")
        Me.imglImporter.Images.SetKeyName(8, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(9, "save-32x32.png")
        Me.imglImporter.Images.SetKeyName(10, "save-all-32x32.png")
        Me.imglImporter.Images.SetKeyName(11, "save-and-close-32x32.png")
        Me.imglImporter.Images.SetKeyName(12, "Add.bmp")
        Me.imglImporter.Images.SetKeyName(13, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(14, "Close.png")
        Me.imglImporter.Images.SetKeyName(15, "EDITITEM.GIF")
        Me.imglImporter.Images.SetKeyName(16, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(17, "Add Button-32.png")
        Me.imglImporter.Images.SetKeyName(18, "Add-32(1).png")
        Me.imglImporter.Images.SetKeyName(19, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(20, "Book-Edit-32.png")
        Me.imglImporter.Images.SetKeyName(21, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(22, "BtnSaveDisabled.png")
        Me.imglImporter.Images.SetKeyName(23, "Close.png")
        Me.imglImporter.Images.SetKeyName(24, "Close-32.png")
        Me.imglImporter.Images.SetKeyName(25, "Close-box-red-32.png")
        Me.imglImporter.Images.SetKeyName(26, "delete-32.png")
        Me.imglImporter.Images.SetKeyName(27, "EDITITEM.GIF")
        Me.imglImporter.Images.SetKeyName(28, "edtError.png")
        Me.imglImporter.Images.SetKeyName(29, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(30, "icon_save.bmp")
        Me.imglImporter.Images.SetKeyName(31, "pcCloseButton.png")
        Me.imglImporter.Images.SetKeyName(32, "Edit-32.png")
        Me.imglImporter.Images.SetKeyName(33, "Edit-128.png")
        Me.imglImporter.Images.SetKeyName(34, "okicon.png")
        '
        'btnChoose
        '
        Me.btnChoose.ImageIndex = 34
        Me.btnChoose.ImageList = Me.imglImporter
        Me.btnChoose.Location = New System.Drawing.Point(5, 4)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(75, 29)
        Me.btnChoose.TabIndex = 2
        Me.btnChoose.Text = "&Chọn"
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me._GridControl)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 34)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(589, 272)
        Me.pnlBody.TabIndex = 2
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 2)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkMarkSelection})
        Me._GridControl.Size = New System.Drawing.Size(585, 268)
        Me._GridControl.TabIndex = 1
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'chkMarkSelection
        '
        Me.chkMarkSelection.AutoHeight = False
        Me.chkMarkSelection.Name = "chkMarkSelection"
        '
        'BaseGridPopupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 343)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "BaseGridPopupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.txtKeyword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlFooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        CType(Me.pnlBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBody.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMarkSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private pnlHeader As DevExpress.XtraEditors.PanelControl
    Private pnlFooter As DevExpress.XtraEditors.PanelControl
    Private pnlBody As DevExpress.XtraEditors.PanelControl
    Private lblSearch As DevExpress.XtraEditors.LabelControl
    Private WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    'Private txtKeyword As DevExpress.XtraEditors.TextEdit
    Private chkMarkSelection As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private lblResult As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents btnChoose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtKeyword As DevExpress.XtraEditors.TextEdit
End Class