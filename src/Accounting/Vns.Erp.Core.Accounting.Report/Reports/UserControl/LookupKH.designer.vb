<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookupKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LookupKH))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblTenKhachHang = New DevExpress.XtraEditors.LabelControl
        Me.c_KHang = New CustomFilter
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Chọn khách hàng :"
        '
        'lblTenKhachHang
        '
        Me.lblTenKhachHang.Location = New System.Drawing.Point(318, 5)
        Me.lblTenKhachHang.Name = "lblTenKhachHang"
        Me.lblTenKhachHang.Size = New System.Drawing.Size(0, 13)
        Me.lblTenKhachHang.TabIndex = 2
        '
        'c_KHang
        '
        Me.c_KHang.AllowNull = True
        Me.c_KHang.C_ARR_COLS_DISPLAY = "KyHieu-Mã khách hàng-80-1;KyHieu--50-0;TenKhang-Tên khách hàng-200-1;Id-" & _
            "-50-0"
        Me.c_KHang.C_ARR_COLS_RETURN = "Id;MaKhang;KyHieu;TenKhang"
        Me.c_KHang.C_DATA_SOURCE = Nothing
        Me.c_KHang.C_FORM_DANHSACH = "frmDanhMucKhachHang_DanhSach"
        Me.c_KHang.C_FORM_TITLE = "Chọn khách hàng"
        Me.c_KHang.C_IS_CHECK_NUMBER = "="
        Me.c_KHang.C_IS_CHECK_OTHER = "="
        Me.c_KHang.C_IS_CHECK_STRING = "="
        Me.c_KHang.C_IS_FILTER_STRING = ""
        Me.c_KHang.C_IS_QUICKADD = False
        Me.c_KHang.C_IS_SORT_ORDER_STRING = ""
        Me.c_KHang.C_KEY_NAME = "KyHieu"
        Me.c_KHang.EditValue = ""
        Me.c_KHang.EditValues = ""
        Me.c_KHang.ENABLES = True
        Me.c_KHang.ListEditValue = CType(resources.GetObject("c_KHang.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.c_KHang.Location = New System.Drawing.Point(122, 3)
        Me.c_KHang.MessageWarning = "Giá trị không hợp lệ"
        Me.c_KHang.Name = "c_KHang"
        Me.c_KHang.NEXT_TAB = 0
        Me.c_KHang.Size = New System.Drawing.Size(184, 20)
        Me.c_KHang.TabIndex = 4
        '
        'LookupKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.c_KHang)
        Me.Controls.Add(Me.lblTenKhachHang)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "LookupKH"
        Me.Size = New System.Drawing.Size(520, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenKhachHang As DevExpress.XtraEditors.LabelControl
    Friend WithEvents c_KHang As CustomFilter

End Class
