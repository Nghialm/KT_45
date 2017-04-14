<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lookup_Hang_Hoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lookup_Hang_Hoa))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblTenHangHoa = New DevExpress.XtraEditors.LabelControl
        Me.c_HangHoa = New CustomFilter
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Chọn tên hàng hóa"
        '
        'lblTenHangHoa
        '
        Me.lblTenHangHoa.Location = New System.Drawing.Point(312, 6)
        Me.lblTenHangHoa.Name = "lblTenHangHoa"
        Me.lblTenHangHoa.Size = New System.Drawing.Size(0, 13)
        Me.lblTenHangHoa.TabIndex = 2
        '
        'c_HangHoa
        '
        Me.c_HangHoa.C_ARR_COLS_DISPLAY = "MaHanghoa-Mã hàng hóa-80-1;KyHieu-Ký hiệu-100-1;TenHanghoa-Tên hàng hóa-200-1;" & _
            "Id--50-0"
        Me.c_HangHoa.C_ARR_COLS_RETURN = "Id;MaHanghoa;KyHieu;TenHanghoa"
        Me.c_HangHoa.C_DATA_SOURCE = Nothing
        Me.c_HangHoa.C_FORM_DANHSACH = "frmDanhMucHangHoa_DanhSach"
        Me.c_HangHoa.C_FORM_TITLE = "Chọn hàng hóa"
        Me.c_HangHoa.C_IS_CHECK_NUMBER = "="
        Me.c_HangHoa.C_IS_CHECK_OTHER = "="
        Me.c_HangHoa.C_IS_CHECK_STRING = "="
        Me.c_HangHoa.C_IS_FILTER_STRING = ""
        Me.c_HangHoa.C_IS_QUICKADD = False
        Me.c_HangHoa.C_IS_SORT_ORDER_STRING = ""
        Me.c_HangHoa.C_KEY_NAME = "KyHieu"
        Me.c_HangHoa.EditValue = ""
        Me.c_HangHoa.EditValues = ""
        Me.c_HangHoa.ENABLES = True
        Me.c_HangHoa.ListEditValue = CType(resources.GetObject("c_HangHoa.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.c_HangHoa.Location = New System.Drawing.Point(122, 3)
        Me.c_HangHoa.Name = "c_HangHoa"
        Me.c_HangHoa.NEXT_TAB = 0
        Me.c_HangHoa.Size = New System.Drawing.Size(184, 20)
        Me.c_HangHoa.TabIndex = 3
        '
        'Lookup_Hang_Hoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.c_HangHoa)
        Me.Controls.Add(Me.lblTenHangHoa)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "Lookup_Hang_Hoa"
        Me.Size = New System.Drawing.Size(520, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenHangHoa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents c_HangHoa As CustomFilter

End Class
