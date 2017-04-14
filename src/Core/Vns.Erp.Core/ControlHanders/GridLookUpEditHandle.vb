
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Public Class GridLookUpEditHandle
    Inherits NativeWindow

    Private WithEvents objGridLookUpEdit As GridLookUpEdit

    Private Sub New()
    End Sub

    Public Sub New(ByVal tb As GridLookUpEdit)
        objGridLookUpEdit = tb
    End Sub

    Private Sub objGridLookUpEdit_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objGridLookUpEdit.Validated
        Dim objFormControl As FormControlExt

        If objGridLookUpEdit.Tag Is Nothing Then
            Return
        Else
            If TypeOf objGridLookUpEdit.Tag Is FormControlExt Then
                objFormControl = objGridLookUpEdit.Tag
            Else
                Return
            End If
        End If

        Dim sDescField As String = objFormControl.DescFieldName
        If sDescField <> "" Then
            'Get content to display
            Dim sDescValue As String = ""
            Dim objInfo As Object = Nothing
            Try
                objInfo = objGridLookUpEdit.Properties.View.GetRow(objGridLookUpEdit.Properties.View.FocusedRowHandle)
                If TypeOf objInfo Is DataRowView Then
                    Dim iRowIdx As Integer = objGridLookUpEdit.Properties.GetIndexByKeyValue(objGridLookUpEdit.EditValue)
                    If iRowIdx >= 0 Then
                        Dim dr As DataRow = DirectCast(objGridLookUpEdit.Properties.DataSource, DataTable).Rows(iRowIdx)
                        If dr IsNot Nothing Then
                            sDescValue = dr.Item(sDescField).ToString
                        End If
                    End If
                ElseIf objInfo IsNot Nothing Then
                    sDescValue = objInfo.GetType.GetProperty(sDescField).GetValue(objInfo, Nothing)
                End If
            Catch ex As Exception
                Throw New Exception(String.Format("Property '{0}' is not memember of object '{1}'", sDescField, objInfo.GetType.Name))
            End Try

            If objFormControl.DescFieldObject Is Nothing Then
                Dim sLabelName As String = objGridLookUpEdit.Name & "_DescriptionLabel"
                Dim objControl As Control = objGridLookUpEdit.Parent.Controls(sLabelName)
                Dim mLabel As Label = objControl

                If mLabel Is Nothing Then
                    mLabel = New Label
                    mLabel.Name = sLabelName
                    mLabel.AutoSize = True
                    mLabel.Anchor = objGridLookUpEdit.Anchor
                    mLabel.Text = ""
                    mLabel.Top = objGridLookUpEdit.Top + 3
                    mLabel.Left = objGridLookUpEdit.Left + objGridLookUpEdit.Width + 10
                    objGridLookUpEdit.Parent.Controls.Add(mLabel)
                    mLabel.Visible = True
                    mLabel.BringToFront()
                End If
                mLabel.Text = sDescValue
            Else
                If TypeOf objFormControl.DescFieldObject Is TextEdit Then
                    Dim txtLabel As TextEdit = objFormControl.DescFieldObject
                    txtLabel.Text = sDescValue
                End If
            End If
        End If
    End Sub
End Class
