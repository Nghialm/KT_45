<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupOfSetup
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupOfSetup))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtGroupIndexTarget = New DevExpress.XtraEditors.TextEdit()
        Me.lblNotice = New DevExpress.XtraEditors.LabelControl()
        Me.txtGroupFormId = New DevExpress.XtraEditors.TextEdit()
        Me.txtFormOrder = New DevExpress.XtraEditors.TextEdit()
        Me.txtGroupIdTarget = New DevExpress.XtraEditors.TextEdit()
        Me.txtFlag = New DevExpress.XtraEditors.TextEdit()
        Me.txtFormParam = New DevExpress.XtraEditors.TextEdit()
        Me.txtFormText = New DevExpress.XtraEditors.TextEdit()
        Me.txtFormName = New DevExpress.XtraEditors.TextEdit()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.txtFormID = New DevExpress.XtraEditors.TextEdit()
        Me.btnSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.listMenu = New DevExpress.XtraTreeList.TreeList()
        Me.GROUP_TEN = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtGroupIndexTarget.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupFormId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupIdTarget.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormParam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.listMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtGroupIndexTarget)
        Me.PanelControl2.Controls.Add(Me.lblNotice)
        Me.PanelControl2.Controls.Add(Me.txtGroupFormId)
        Me.PanelControl2.Controls.Add(Me.txtFormOrder)
        Me.PanelControl2.Controls.Add(Me.txtGroupIdTarget)
        Me.PanelControl2.Controls.Add(Me.txtFlag)
        Me.PanelControl2.Controls.Add(Me.txtFormParam)
        Me.PanelControl2.Controls.Add(Me.txtFormText)
        Me.PanelControl2.Controls.Add(Me.txtFormName)
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.txtFormID)
        Me.PanelControl2.Controls.Add(Me.btnSubmit)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 294)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(395, 46)
        Me.PanelControl2.TabIndex = 1
        '
        'txtGroupIndexTarget
        '
        Me.txtGroupIndexTarget.Enabled = False
        Me.txtGroupIndexTarget.Location = New System.Drawing.Point(133, 25)
        Me.txtGroupIndexTarget.Name = "txtGroupIndexTarget"
        Me.txtGroupIndexTarget.Size = New System.Drawing.Size(15, 20)
        Me.txtGroupIndexTarget.TabIndex = 13
        Me.txtGroupIndexTarget.Visible = False
        '
        'lblNotice
        '
        Me.lblNotice.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblNotice.Appearance.Options.UseForeColor = True
        Me.lblNotice.Location = New System.Drawing.Point(5, 11)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(40, 13)
        Me.lblNotice.TabIndex = 12
        Me.lblNotice.Text = "lblNotice"
        '
        'txtGroupFormId
        '
        Me.txtGroupFormId.Enabled = False
        Me.txtGroupFormId.Location = New System.Drawing.Point(294, 25)
        Me.txtGroupFormId.Name = "txtGroupFormId"
        Me.txtGroupFormId.Size = New System.Drawing.Size(15, 20)
        Me.txtGroupFormId.TabIndex = 11
        Me.txtGroupFormId.Visible = False
        '
        'txtFormOrder
        '
        Me.txtFormOrder.Enabled = False
        Me.txtFormOrder.Location = New System.Drawing.Point(294, 4)
        Me.txtFormOrder.Name = "txtFormOrder"
        Me.txtFormOrder.Size = New System.Drawing.Size(15, 20)
        Me.txtFormOrder.TabIndex = 10
        Me.txtFormOrder.Visible = False
        '
        'txtGroupIdTarget
        '
        Me.txtGroupIdTarget.Enabled = False
        Me.txtGroupIdTarget.Location = New System.Drawing.Point(241, 25)
        Me.txtGroupIdTarget.Name = "txtGroupIdTarget"
        Me.txtGroupIdTarget.Size = New System.Drawing.Size(15, 20)
        Me.txtGroupIdTarget.TabIndex = 8
        Me.txtGroupIdTarget.Visible = False
        '
        'txtFlag
        '
        Me.txtFlag.Enabled = False
        Me.txtFlag.Location = New System.Drawing.Point(241, 4)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(15, 20)
        Me.txtFlag.TabIndex = 7
        Me.txtFlag.Visible = False
        '
        'txtFormParam
        '
        Me.txtFormParam.Enabled = False
        Me.txtFormParam.Location = New System.Drawing.Point(276, 25)
        Me.txtFormParam.Name = "txtFormParam"
        Me.txtFormParam.Size = New System.Drawing.Size(15, 20)
        Me.txtFormParam.TabIndex = 6
        Me.txtFormParam.Visible = False
        '
        'txtFormText
        '
        Me.txtFormText.Enabled = False
        Me.txtFormText.Location = New System.Drawing.Point(258, 25)
        Me.txtFormText.Name = "txtFormText"
        Me.txtFormText.Size = New System.Drawing.Size(15, 20)
        Me.txtFormText.TabIndex = 5
        Me.txtFormText.Visible = False
        '
        'txtFormName
        '
        Me.txtFormName.Enabled = False
        Me.txtFormName.Location = New System.Drawing.Point(276, 4)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(15, 20)
        Me.txtFormName.TabIndex = 4
        Me.txtFormName.Visible = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.ImageList = Me.imgList
        Me.btnClose.Location = New System.Drawing.Point(310, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Đóng"
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "find_selection.png")
        Me.imgList.Images.SetKeyName(1, "selection.png")
        Me.imgList.Images.SetKeyName(2, "document_add.png")
        Me.imgList.Images.SetKeyName(3, "document_edit.png")
        Me.imgList.Images.SetKeyName(4, "document_view.png")
        Me.imgList.Images.SetKeyName(5, "document_delete.png")
        Me.imgList.Images.SetKeyName(6, "pcCloseButton.png")
        Me.imgList.Images.SetKeyName(7, "BtnSave.png")
        Me.imgList.Images.SetKeyName(8, "ButtonSaveAndClose.png")
        Me.imgList.Images.SetKeyName(9, "Copy of save-32x32.png")
        Me.imgList.Images.SetKeyName(10, "copy.png")
        Me.imgList.Images.SetKeyName(11, "export1.png")
        Me.imgList.Images.SetKeyName(12, "cashier.png")
        Me.imgList.Images.SetKeyName(13, "printer.png")
        Me.imgList.Images.SetKeyName(14, "EDITITEM.GIF")
        Me.imgList.Images.SetKeyName(15, "icon-excel-16x16.gif")
        Me.imgList.Images.SetKeyName(16, "cubes_yellow.png")
        Me.imgList.Images.SetKeyName(17, "cubes.png")
        Me.imgList.Images.SetKeyName(18, "cubes_blue.png")
        Me.imgList.Images.SetKeyName(19, "cubes_green.png")
        Me.imgList.Images.SetKeyName(20, "cube_blue.png")
        Me.imgList.Images.SetKeyName(21, "cube_green.png")
        Me.imgList.Images.SetKeyName(22, "cube_yellow.png")
        '
        'txtFormID
        '
        Me.txtFormID.Enabled = False
        Me.txtFormID.Location = New System.Drawing.Point(258, 4)
        Me.txtFormID.Name = "txtFormID"
        Me.txtFormID.Size = New System.Drawing.Size(15, 20)
        Me.txtFormID.TabIndex = 1
        Me.txtFormID.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.ImageIndex = 7
        Me.btnSubmit.ImageList = Me.imgList
        Me.btnSubmit.Location = New System.Drawing.Point(154, 10)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 28)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.listMenu)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(395, 294)
        Me.PanelControl1.TabIndex = 2
        '
        'listMenu
        '
        Me.listMenu.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GROUP_TEN})
        Me.listMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listMenu.KeyFieldName = "GROUP_ID"
        Me.listMenu.Location = New System.Drawing.Point(2, 2)
        Me.listMenu.Name = "listMenu"
        Me.listMenu.OptionsBehavior.Editable = False
        Me.listMenu.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listMenu.OptionsView.ShowColumns = False
        Me.listMenu.OptionsView.ShowIndicator = False
        Me.listMenu.ParentFieldName = "PARENT_ID"
        Me.listMenu.PreviewFieldName = "GROUP_ID"
        Me.listMenu.Size = New System.Drawing.Size(391, 290)
        Me.listMenu.TabIndex = 0
        '
        'GROUP_TEN
        '
        Me.GROUP_TEN.Caption = "GROUP_TEN"
        Me.GROUP_TEN.FieldName = "GroupTen"
        Me.GROUP_TEN.Name = "GROUP_TEN"
        Me.GROUP_TEN.Visible = True
        Me.GROUP_TEN.VisibleIndex = 0
        '
        'frmPopupOfSetup
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(395, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPopupOfSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết lập danh mục chức năng"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtGroupIndexTarget.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupFormId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupIdTarget.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormParam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.listMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents listMenu As DevExpress.XtraTreeList.TreeList
    Public WithEvents txtFormID As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnSubmit As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtFormText As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtFormName As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Public WithEvents txtFlag As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtFormParam As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtGroupIdTarget As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GROUP_TEN As DevExpress.XtraTreeList.Columns.TreeListColumn
    Public WithEvents txtFormOrder As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtGroupFormId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNotice As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtGroupIndexTarget As DevExpress.XtraEditors.TextEdit
End Class
