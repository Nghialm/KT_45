<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiFilterPopup
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiFilterPopup))
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.pcTop = New DevExpress.XtraEditors.PanelControl
        Me.btnQuickAdd = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtKeyWord = New DevExpress.XtraEditors.TextEdit
        Me.pcBottom = New DevExpress.XtraEditors.PanelControl
        Me.btnCancal = New DevExpress.XtraEditors.SimpleButton
        Me.btnSubmit = New DevExpress.XtraEditors.SimpleButton
        Me.pcMain = New DevExpress.XtraEditors.PanelControl
        Me.grcMain = New DevExpress.XtraGrid.GridControl
        Me.grvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.pcTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcTop.SuspendLayout()
        CType(Me.txtKeyWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcBottom.SuspendLayout()
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcMain.SuspendLayout()
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'pcTop
        '
        Me.pcTop.Controls.Add(Me.btnQuickAdd)
        Me.pcTop.Controls.Add(Me.LabelControl1)
        Me.pcTop.Controls.Add(Me.txtKeyWord)
        Me.pcTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pcTop.Location = New System.Drawing.Point(0, 0)
        Me.pcTop.Name = "pcTop"
        Me.pcTop.Size = New System.Drawing.Size(722, 40)
        Me.pcTop.TabIndex = 0
        '
        'btnQuickAdd
        '
        Me.btnQuickAdd.ImageIndex = 17
        Me.btnQuickAdd.ImageList = Me.imglImporter
        Me.btnQuickAdd.Location = New System.Drawing.Point(227, 6)
        Me.btnQuickAdd.Name = "btnQuickAdd"
        Me.btnQuickAdd.Size = New System.Drawing.Size(153, 30)
        Me.btnQuickAdd.TabIndex = 0
        Me.btnQuickAdd.TabStop = False
        Me.btnQuickAdd.Text = "Thêm nhanh (Alt + F3)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tìm kiếm"
        '
        'txtKeyWord
        '
        Me.txtKeyWord.EnterMoveNextControl = True
        Me.txtKeyWord.Location = New System.Drawing.Point(59, 11)
        Me.txtKeyWord.Name = "txtKeyWord"
        Me.txtKeyWord.Size = New System.Drawing.Size(150, 20)
        Me.txtKeyWord.TabIndex = 1
        '
        'pcBottom
        '
        Me.pcBottom.Controls.Add(Me.btnCancal)
        Me.pcBottom.Controls.Add(Me.btnSubmit)
        Me.pcBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pcBottom.Location = New System.Drawing.Point(0, 349)
        Me.pcBottom.Name = "pcBottom"
        Me.pcBottom.Size = New System.Drawing.Size(722, 40)
        Me.pcBottom.TabIndex = 2
        '
        'btnCancal
        '
        Me.btnCancal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancal.ImageIndex = 24
        Me.btnCancal.ImageList = Me.imglImporter
        Me.btnCancal.Location = New System.Drawing.Point(147, 5)
        Me.btnCancal.Name = "btnCancal"
        Me.btnCancal.Size = New System.Drawing.Size(127, 30)
        Me.btnCancal.TabIndex = 1
        Me.btnCancal.Text = "Hủy bỏ (Alt + F4)"
        '
        'btnSubmit
        '
        Me.btnSubmit.ImageIndex = 34
        Me.btnSubmit.ImageList = Me.imglImporter
        Me.btnSubmit.Location = New System.Drawing.Point(13, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(128, 30)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Đồng ý (Ctrl + S)"
        '
        'pcMain
        '
        Me.pcMain.Controls.Add(Me.grcMain)
        Me.pcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcMain.Location = New System.Drawing.Point(0, 40)
        Me.pcMain.Name = "pcMain"
        Me.pcMain.Size = New System.Drawing.Size(722, 309)
        Me.pcMain.TabIndex = 1
        '
        'grcMain
        '
        Me.grcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcMain.Location = New System.Drawing.Point(2, 2)
        Me.grcMain.MainView = Me.grvMain
        Me.grcMain.Name = "grcMain"
        Me.grcMain.Size = New System.Drawing.Size(718, 305)
        Me.grcMain.TabIndex = 0
        Me.grcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMain, Me.GridView2})
        '
        'grvMain
        '
        Me.grvMain.GridControl = Me.grcMain
        Me.grvMain.Name = "grvMain"
        Me.grvMain.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grcMain
        Me.GridView2.Name = "GridView2"
        '
        'MultiFilterPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancal
        Me.ClientSize = New System.Drawing.Size(722, 389)
        Me.Controls.Add(Me.pcMain)
        Me.Controls.Add(Me.pcBottom)
        Me.Controls.Add(Me.pcTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MultiFilterPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiFilterPopup"
        CType(Me.pcTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcTop.ResumeLayout(False)
        Me.pcTop.PerformLayout()
        CType(Me.txtKeyWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcBottom.ResumeLayout(False)
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcMain.ResumeLayout(False)
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents pcTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pcBottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pcMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtKeyWord As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnQuickAdd As DevExpress.XtraEditors.SimpleButton
End Class
