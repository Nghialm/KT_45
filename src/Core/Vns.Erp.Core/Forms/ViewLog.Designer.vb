<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLog))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.grcMain = New DevExpress.XtraGrid.GridControl
        Me.grvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LOG_ICON = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.LOG_NAME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOG_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 288)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(636, 35)
        Me.PanelControl1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(544, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Đóng"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grcMain)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(636, 288)
        Me.PanelControl2.TabIndex = 1
        '
        'grcMain
        '
        Me.grcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcMain.Location = New System.Drawing.Point(2, 2)
        Me.grcMain.MainView = Me.grvMain
        Me.grcMain.Name = "grcMain"
        Me.grcMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageEdit1, Me.RepositoryItemPictureEdit1, Me.RepositoryItemImageComboBox1})
        Me.grcMain.Size = New System.Drawing.Size(632, 284)
        Me.grcMain.TabIndex = 0
        Me.grcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMain, Me.GridView2})
        '
        'grvMain
        '
        Me.grvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LOG_ICON, Me.LOG_NAME, Me.LOG_CONTENT})
        Me.grvMain.GridControl = Me.grcMain
        Me.grvMain.Images = Me.imglImporter
        Me.grvMain.Name = "grvMain"
        Me.grvMain.OptionsBehavior.Editable = False
        Me.grvMain.OptionsView.ShowGroupPanel = False
        '
        'LOG_ICON
        '
        Me.LOG_ICON.Caption = " "
        Me.LOG_ICON.ColumnEdit = Me.RepositoryItemImageComboBox1
        Me.LOG_ICON.FieldName = "LOG_ICON"
        Me.LOG_ICON.Name = "LOG_ICON"
        Me.LOG_ICON.Visible = True
        Me.LOG_ICON.VisibleIndex = 0
        Me.LOG_ICON.Width = 30
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        Me.RepositoryItemImageComboBox1.SmallImages = Me.imglImporter
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "user_48.png")
        Me.imglImporter.Images.SetKeyName(1, "add_48.png")
        Me.imglImporter.Images.SetKeyName(2, "circle_orange.png")
        Me.imglImporter.Images.SetKeyName(3, "computer_48.png")
        '
        'LOG_NAME
        '
        Me.LOG_NAME.Caption = "Thông tin"
        Me.LOG_NAME.FieldName = "LOG_NAME"
        Me.LOG_NAME.Name = "LOG_NAME"
        Me.LOG_NAME.Visible = True
        Me.LOG_NAME.VisibleIndex = 1
        Me.LOG_NAME.Width = 173
        '
        'LOG_CONTENT
        '
        Me.LOG_CONTENT.Caption = "Nội dung"
        Me.LOG_CONTENT.FieldName = "LOG_CONTENT"
        Me.LOG_CONTENT.Name = "LOG_CONTENT"
        Me.LOG_CONTENT.Visible = True
        Me.LOG_CONTENT.VisibleIndex = 2
        Me.LOG_CONTENT.Width = 176
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Images = Me.imglImporter
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grcMain
        Me.GridView2.Name = "GridView2"
        '
        'ViewLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(636, 323)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin người dùng cuối"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LOG_ICON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOG_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOG_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
End Class
