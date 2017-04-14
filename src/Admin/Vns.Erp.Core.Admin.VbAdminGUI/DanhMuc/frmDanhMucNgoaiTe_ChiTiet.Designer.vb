Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucNgoaiTe_ChiTiet
    Inherits FrmBaseDmChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhMucNgoaiTe_ChiTiet))
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl
        Me.txtTEN_NTE = New DevExpress.XtraEditors.TextEdit
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit
        Me.txtTY_GIA = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.Color = New DevExpress.XtraEditors.LabelControl
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnTyGia = New DevExpress.XtraEditors.SimpleButton
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtTEN_NTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_NTE)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTY_GIA)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.Color)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(402, 60)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2"
        '
        'txtTEN_NTE
        '
        Me.txtTEN_NTE.EnterMoveNextControl = True
        Me.txtTEN_NTE.Location = New System.Drawing.Point(107, 33)
        Me.txtTEN_NTE.Name = "txtTEN_NTE"
        Me.txtTEN_NTE.Size = New System.Drawing.Size(230, 20)
        Me.txtTEN_NTE.TabIndex = 1
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(107, 7)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(230, 20)
        Me.txtKY_HIEU.TabIndex = 0
        '
        'txtTY_GIA
        '
        Me.txtTY_GIA.EditValue = "0"
        Me.txtTY_GIA.EnterMoveNextControl = True
        Me.txtTY_GIA.Location = New System.Drawing.Point(107, 64)
        Me.txtTY_GIA.Name = "txtTY_GIA"
        Me.txtTY_GIA.Properties.Mask.EditMask = "n0"
        Me.txtTY_GIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA.Size = New System.Drawing.Size(230, 20)
        Me.txtTY_GIA.TabIndex = 1
        Me.txtTY_GIA.Visible = False
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(23, 36)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl17.TabIndex = 83
        Me.LabelControl17.Text = "Tên ngoại tệ"
        '
        'Color
        '
        Me.Color.Location = New System.Drawing.Point(54, 67)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(29, 13)
        Me.Color.TabIndex = 56
        Me.Color.Text = "Tỷ giá"
        Me.Color.Visible = False
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(48, 10)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 0
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Controls.Add(Me.btnTyGia)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 64)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(402, 38)
        Me._ActionPanel.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(204, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 87
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(118, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 86
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(32, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 85
        Me.btnSave.Text = "&Lưu"
        '
        'btnTyGia
        '
        Me.btnTyGia.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTyGia.ImageIndex = 18
        Me.btnTyGia.ImageList = Me.imglImporter
        Me.btnTyGia.Location = New System.Drawing.Point(290, 5)
        Me.btnTyGia.Name = "btnTyGia"
        Me.btnTyGia.Size = New System.Drawing.Size(80, 30)
        Me.btnTyGia.TabIndex = 84
        Me.btnTyGia.Text = "&Tỷ giá"
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
        '
        'frmDanhMucNgoaiTe_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(410, 106)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucNgoaiTe_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục ngoại tệ"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtTEN_NTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Friend imglImporter As System.Windows.Forms.ImageList
    Private txtTEN_NTE As DevExpress.XtraEditors.TextEdit
    Private txtTY_GIA As DevExpress.XtraEditors.TextEdit
    Friend Color As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTyGia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
