'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Imports DevComponents.DotNetBar
Imports DevComponents.WinForms

Partial Class frmMenu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Menu_Resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.listIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.HelpProvider = New System.Windows.Forms.HelpProvider
        Me.barControlMain = New DevExpress.XtraNavBar.NavBarControl
        Me.g01 = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarItem8 = New DevExpress.XtraNavBar.NavBarItem
        Me.g02 = New DevExpress.XtraNavBar.NavBarGroup
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.barForm = New DevExpress.XtraNavBar.NavBarControl
        Me.groupForm = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem
        'Me.paneSearch = New DevComponents.DotNetBar.NavigationPane
        'Me.NavigationPanePanel1 = New DevComponents.DotNetBar.NavigationPanePanel
        'Me.txtKeySearch = New System.Windows.Forms.TextBox
        Me.lblNotice = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        'Me.btnRefreshMenu = New DevExpress.XtraEditors.SimpleButton
        'Me.ButtonItem = New DevComponents.DotNetBar.ButtonItem
        Me.listForm = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.barControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.barForm, System.ComponentModel.ISupportInitialize).BeginInit()
        'Me.paneSearch.SuspendLayout()
        'Me.NavigationPanePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listIcon
        '
        Me.listIcon.ImageStream = CType(Menu_Resources.GetObject("listIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.listIcon.Images.SetKeyName(0, "level3.png")
        Me.listIcon.Images.SetKeyName(1, "level2.png")
        Me.listIcon.Images.SetKeyName(2, "level1.png")
        Me.listIcon.Images.SetKeyName(3, "log_off.png")
        Me.listIcon.Images.SetKeyName(4, "help.png")
        Me.listIcon.Images.SetKeyName(5, "cap1.png")
        Me.listIcon.Images.SetKeyName(6, "cap2.png")
        Me.listIcon.Images.SetKeyName(7, "cap3.png")
        Me.listIcon.Images.SetKeyName(8, "form_ok1_24.png")
        Me.listIcon.Images.SetKeyName(9, "form_ok2_24.png")
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "KTY.chm"
        '
        'barControlMain
        '
        Me.barControlMain.ActiveGroup = Me.g01
        Me.barControlMain.AllowSelectedLink = True
        Me.barControlMain.ContentButtonHint = Nothing
        Me.barControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barControlMain.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.g01, Me.g02})
        Me.barControlMain.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem8})
        Me.barControlMain.Location = New System.Drawing.Point(0, 0)
        Me.barControlMain.Name = "barControlMain"
        Me.barControlMain.OptionsNavPane.ExpandedWidth = 288
        Me.barControlMain.Size = New System.Drawing.Size(278, 535)
        Me.barControlMain.TabIndex = 0
        Me.barControlMain.Text = "Danh mục Nhóm"
        Me.barControlMain.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Money Twins")
        '
        'g01
        '
        Me.g01.Caption = "Nhóm danh mục 1"
        Me.g01.Expanded = True
        Me.g01.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem8)})
        Me.g01.Name = "g01"
        Me.g01.SelectedLinkIndex = 0
        Me.g01.SmallImage = My.Resources.cap1
        '
        'NavBarItem8
        '
        Me.NavBarItem8.Caption = "NavBarItem8"
        Me.NavBarItem8.Name = "NavBarItem8"
        Me.NavBarItem8.SmallImage = CType(Menu_Resources.GetObject("NavBarItem8.SmallImage"), System.Drawing.Image)
        '
        'g02
        '
        Me.g02.Caption = "Nhóm danh mục 2"
        Me.g02.Expanded = True
        Me.g02.Name = "g02"
        Me.g02.SmallImage = My.Resources.cap1
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.barControlMain)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.barForm)
        'Me.SplitContainerControl1.Panel2.Controls.Add(Me.paneSearch)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(946, 535)
        Me.SplitContainerControl1.SplitterPosition = 278
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'barForm
        '
        Me.barForm.ActiveGroup = Me.groupForm
        Me.barForm.ContentButtonHint = Nothing
        Me.barForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barForm.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.groupForm})
        Me.barForm.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1})
        Me.barForm.Location = New System.Drawing.Point(0, 0)
        Me.barForm.Name = "barForm"
        Me.barForm.OptionsNavPane.ExpandedWidth = 442
        Me.barForm.ShowGroupHint = False
        Me.barForm.ShowLinkHint = False
        Me.barForm.Size = New System.Drawing.Size(456, 535)
        Me.barForm.TabIndex = 1
        Me.barForm.Text = "NavBarControl1"
        Me.barForm.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Money Twins")
        '
        'groupForm
        '
        Me.groupForm.Caption = "Danh mục chức năng"
        Me.groupForm.Expanded = True
        Me.groupForm.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1)})
        Me.groupForm.Name = "groupForm"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = CType(Menu_Resources.GetObject("NavBarItem1.SmallImage"), System.Drawing.Image)
        '
        'paneSearch
        '
        'Me.paneSearch.CanCollapse = True
        'Me.paneSearch.ConfigureAddRemoveVisible = False
        'Me.paneSearch.ConfigureItemVisible = False
        'Me.paneSearch.ConfigureNavOptionsVisible = False
        'Me.paneSearch.ConfigureShowHideVisible = False
        'Me.paneSearch.Controls.Add(Me.NavigationPanePanel1)
        'Me.paneSearch.Controls.Add(Me.paneSearch.TitlePanel)
        'Me.paneSearch.Dock = System.Windows.Forms.DockStyle.Right
        'Me.paneSearch.Expanded = False
        'Me.paneSearch.ItemPaddingBottom = 2
        'Me.paneSearch.ItemPaddingTop = 2
        'Me.paneSearch.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem})
        'Me.paneSearch.Location = New System.Drawing.Point(456, 0)
        'Me.paneSearch.Name = "paneSearch"
        'Me.paneSearch.Padding = New System.Windows.Forms.Padding(1)
        'Me.paneSearch.Size = New System.Drawing.Size(206, 535)
        'Me.paneSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        'Me.paneSearch.TabIndex = 0
        'Me.paneSearch.Width = 210
        '
        'NavigationPanePanel1
        '
        'Me.NavigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        'Me.NavigationPanePanel1.Controls.Add(Me.txtKeySearch)
        'Me.NavigationPanePanel1.Controls.Add(Me.lblNotice)
        'Me.NavigationPanePanel1.Controls.Add(Me.LabelControl1)
        'Me.NavigationPanePanel1.Controls.Add(Me.btnSearch)
        'Me.NavigationPanePanel1.Controls.Add(Me.btnRefreshMenu)
        'Me.NavigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.NavigationPanePanel1.Location = New System.Drawing.Point(1, 25)
        'Me.NavigationPanePanel1.Name = "NavigationPanePanel1"
        'Me.NavigationPanePanel1.ParentItem = Me.ButtonItem
        'Me.NavigationPanePanel1.Size = New System.Drawing.Size(32, 477)
        'Me.NavigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        'Me.NavigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        'Me.NavigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        'Me.NavigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        'Me.NavigationPanePanel1.Style.GradientAngle = 90
        'Me.NavigationPanePanel1.TabIndex = 2
        'Me.NavigationPanePanel1.Visible = False
        '
        'txtKeySearch
        '
        'Me.txtKeySearch.AutoCompleteCustomSource.AddRange(New String() {"Nguyễn Quyết Tiến"})
        'Me.txtKeySearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        'Me.txtKeySearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        'Me.txtKeySearch.Location = New System.Drawing.Point(9, 49)
        'Me.txtKeySearch.Name = "txtKeySearch"
        'Me.txtKeySearch.Size = New System.Drawing.Size(198, 21)
        'Me.txtKeySearch.TabIndex = 5
        '
        'lblNotice
        '
        Me.lblNotice.Location = New System.Drawing.Point(9, 114)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(30, 13)
        Me.lblNotice.TabIndex = 3
        Me.lblNotice.Text = "Notice"
        Me.lblNotice.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Tên chức năng :"
        '
        'btnSearch
        '
        Me.btnSearch.ImageIndex = 0
        Me.btnSearch.ImageList = Me.imglImporter
        Me.btnSearch.Location = New System.Drawing.Point(9, 76)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Tìm kiếm"
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(Menu_Resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "preview-32x32.png")
        '
        'btnRefreshMenu
        '
        'Me.btnRefreshMenu.ImageIndex = 1
        'Me.btnRefreshMenu.ImageList = Me.imglImporter
        'Me.btnRefreshMenu.Location = New System.Drawing.Point(105, 76)
        'Me.btnRefreshMenu.Name = "btnRefreshMenu"
        'Me.btnRefreshMenu.Size = New System.Drawing.Size(101, 30)
        'Me.btnRefreshMenu.TabIndex = 2
        'Me.btnRefreshMenu.Text = "Làm mới menu"
        '
        'ButtonItem
        '
        'Me.ButtonItem.Checked = True
        'Me.ButtonItem.Image = CType(Menu_Resources.GetObject("ButtonItem.Image"), System.Drawing.Image)
        'Me.ButtonItem.ImageFixedSize = New System.Drawing.Size(16, 16)
        'Me.ButtonItem.Name = "ButtonItem"
        'Me.ButtonItem.OptionGroup = "navBar"
        'Me.ButtonItem.Text = "Tìm kiếm chức năng"
        '
        'listForm
        '
        Me.listForm.ImageStream = CType(Menu_Resources.GetObject("listForm.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listForm.TransparentColor = System.Drawing.Color.Transparent
        Me.listForm.Images.SetKeyName(0, "form_ok1.png")
        Me.listForm.Images.SetKeyName(1, "form_ok2.png")
        Me.listForm.Images.SetKeyName(2, "form_ok3.png")
        '
        'frmMenu
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 535)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục chức năng"
        CType(Me.barControlMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.barForm, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.paneSearch.ResumeLayout(False)
        'Me.NavigationPanePanel1.ResumeLayout(False)
        'Me.NavigationPanePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listIcon As System.Windows.Forms.ImageList
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents barControlMain As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents g01 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem8 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents g02 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents barForm As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents groupForm As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNotice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents listForm As System.Windows.Forms.ImageList
    'Friend WithEvents txtKeySearch As System.Windows.Forms.TextBox
    'Private WithEvents paneSearch As DevComponents.DotNetBar.NavigationPane
    'Private WithEvents NavigationPanePanel1 As DevComponents.DotNetBar.NavigationPanePanel
    'Private WithEvents ButtonItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    'Friend WithEvents btnRefreshMenu As DevExpress.XtraEditors.SimpleButton
End Class

