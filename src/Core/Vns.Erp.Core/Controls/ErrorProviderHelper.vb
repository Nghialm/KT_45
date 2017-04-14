Imports DevExpress
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Windows.Forms

Public Class ErrorProviderHelper
    Public Shared Sub SetError(ByVal erp As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider, ByVal ErrMess As String, ByVal ctl As System.Windows.Forms.Control)
        erp.SetError(ctl, ErrMess, ErrorType.Warning)
        erp.SetIconAlignment(ctl, ErrorIconAlignment.TopRight)
    End Sub
End Class
