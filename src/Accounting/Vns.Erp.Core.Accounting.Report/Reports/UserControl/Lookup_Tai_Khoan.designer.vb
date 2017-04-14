<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lookup_Tai_Khoan
    Inherits KTY_UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lookup_Tai_Khoan))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblTenTaiKhoan = New DevExpress.XtraEditors.LabelControl
        Me.c_TaiKhoan = New CustomFilter
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Chọn tên tài khoản "
        '
        'lblTenTaiKhoan
        '
        Me.lblTenTaiKhoan.Location = New System.Drawing.Point(313, 5)
        Me.lblTenTaiKhoan.Name = "lblTenTaiKhoan"
        Me.lblTenTaiKhoan.Size = New System.Drawing.Size(0, 13)
        Me.lblTenTaiKhoan.TabIndex = 2
        '
        'c_TaiKhoan
        '
        Me.c_TaiKhoan.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tài khoản-80-1;TenTaikhoan-Tên tài khoản-200-1;Id--50-0"
        Me.c_TaiKhoan.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan"
        Me.c_TaiKhoan.C_DATA_SOURCE = Nothing
        Me.c_TaiKhoan.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.c_TaiKhoan.C_FORM_TITLE = "Chọn tài khoản"
        Me.c_TaiKhoan.C_IS_CHECK_NUMBER = "="
        Me.c_TaiKhoan.C_IS_CHECK_OTHER = "="
        Me.c_TaiKhoan.C_IS_CHECK_STRING = "="
        Me.c_TaiKhoan.C_IS_FILTER_STRING = ""
        Me.c_TaiKhoan.C_IS_QUICKADD = False
        Me.c_TaiKhoan.C_IS_SORT_ORDER_STRING = ""
        Me.c_TaiKhoan.C_KEY_NAME = "MaTaikhoan"
        Me.c_TaiKhoan.EditValue = ""
        Me.c_TaiKhoan.EditValues = ""
        Me.c_TaiKhoan.ENABLES = True
        Me.c_TaiKhoan.ListEditValue = CType(resources.GetObject("c_TaiKhoan.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.c_TaiKhoan.Location = New System.Drawing.Point(122, 3)
        Me.c_TaiKhoan.Name = "c_TaiKhoan"
        Me.c_TaiKhoan.NEXT_TAB = 0
        Me.c_TaiKhoan.Size = New System.Drawing.Size(184, 20)
        Me.c_TaiKhoan.TabIndex = 5
        '
        'Lookup_Tai_Khoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.c_TaiKhoan)
        Me.Controls.Add(Me.lblTenTaiKhoan)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "Lookup_Tai_Khoan"
        Me.Size = New System.Drawing.Size(520, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenTaiKhoan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents c_TaiKhoan As CustomFilter

End Class
