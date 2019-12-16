Imports Vns.Erp.Core.Accounting.Domain
Imports DevExpress.XtraGrid.Views
Imports Vns.Erp.Core
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class Commons
    Public Shared Function ConvertLstObjCtHtoCtHG(ByVal lstObjCtH As IList(Of CtH)) As List(Of Extend.CT_H_GInfo)
        Try
            Dim lstobjCTHG As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
            For i As Integer = 0 To lstObjCtH.Count - 1
                Dim objCTHG As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(lstObjCtH(i))
                lstobjCTHG.Add(objCTHG)
            Next
            If lstobjCTHG.Count > 0 Then
                Return lstobjCTHG
            Else
                Return New List(Of Extend.CT_H_GInfo)
            End If
        Catch ex As Exception
            Return New List(Of Extend.CT_H_GInfo)
        End Try
    End Function

    Public Shared Function ConvertLstObjCtHtoCtHG(ByVal lstObjCtH As IList(Of KtCtHKhac)) As List(Of Extend.CT_H_GInfo)
        Try
            Dim lstobjCTHG As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
            For i As Integer = 0 To lstObjCtH.Count - 1
                Dim objCTHG As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(lstObjCtH(i))
                lstobjCTHG.Add(objCTHG)
            Next
            If lstobjCTHG.Count > 0 Then
                Return lstobjCTHG
            Else
                Return New List(Of Extend.CT_H_GInfo)
            End If
        Catch ex As Exception
            Return New List(Of Extend.CT_H_GInfo)
        End Try
    End Function

    Public Shared Function ConvertToCTHG(ByVal lstObjCTHNX As IList(Of CtHNx)) As List(Of Extend.CT_H_GInfo)
        Try
            Dim lstobjCTHG As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
            For i As Integer = 0 To lstObjCTHNX.Count - 1
                Dim objCTHG As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(lstObjCTHNX(i))
                lstobjCTHG.Add(objCTHG)
            Next
            If lstobjCTHG.Count > 0 Then
                Return lstobjCTHG
            Else
                Return New List(Of Extend.CT_H_GInfo)()
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function ConvertToCTHG(ByVal lstObjCTHNX As IList(Of KtCtHHddv)) As List(Of Extend.CT_H_GInfo)
        Try
            Dim lstobjCTHG As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
            For i As Integer = 0 To lstObjCTHNX.Count - 1
                Dim objCTHG As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(lstObjCTHNX(i))
                lstobjCTHG.Add(objCTHG)
            Next
            If lstobjCTHG.Count > 0 Then
                Return lstobjCTHG
            Else
                Return New List(Of Extend.CT_H_GInfo)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function CheckStatusEscape(ByVal inputState As DataInputState) As Boolean
        Try
            Dim m_InputState As DataInputState
            m_InputState = inputState
            If m_InputState = DataInputState.AddMode Then
                Dim dr As DialogResult = MessageBox.Show("Bạn muốn thoát khỏi chương trình nhập và mọi dữ liệu chưa lưu sẽ bị xóa mất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If dr = DialogResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            Message_Error(ex)
            Return False
        End Try
    End Function


#Region "Validate"

    Private Shared _RequireInputControl As Control()
    Private Shared _ErrorProvider As DXErrorProvider

    Public Shared Property ErrorProvider() As DXErrorProvider
        Get
            If _ErrorProvider Is Nothing Then
                _ErrorProvider = New DXErrorProvider()
            End If
            Return _ErrorProvider
        End Get
        Set(ByVal value As DXErrorProvider)
            _ErrorProvider = value
        End Set
    End Property

    Public Shared Property RequireInputControls() As Control()
        Get
            Return _RequireInputControl
        End Get
        Set(ByVal value As Control())
            _RequireInputControl = value
        End Set
    End Property

    Public Shared Sub ApplyRequireInputValidate(ByVal RequireInputControls As Control())
        If RequireInputControls Is Nothing Then
            Return
        End If

        For Each _Control As Control In RequireInputControls
            'Dim lbl As New LabelControl()
            'lbl.Text = "*"
            'lbl.ForeColor = System.Drawing.Color.Red
            '_Control.Parent.Controls.Add(lbl)
            'lbl.Location = New Point(_Control.Location.X - 10, _Control.Location.Y)
            AddHandler _Control.Validating, New CancelEventHandler(AddressOf ValidateRequireInput)
        Next
    End Sub

    Public Shared Sub ValidateRequireInput(ByVal sender As [Object], ByVal e As CancelEventArgs)
        Dim value As Object = String.Empty
        Dim support As Boolean = False
        If TypeOf sender Is TextEdit Then
            value = DirectCast(sender, TextEdit).Text.Trim
            support = True
        End If
        If TypeOf sender Is LookUpEdit Then
            value = DirectCast(sender, LookUpEdit).EditValue
            support = True
        End If

        If TypeOf sender Is GridLookUpEdit Then
            value = DirectCast(sender, GridLookUpEdit).EditValue
            support = True
        End If
        If TypeOf sender Is DateEdit Then
            value = DirectCast(sender, DateEdit).EditValue
            support = True
        End If
        If Not support Then
            Throw New Exception([String].Format(GeneralString.VALIDATE_REQUIRE_NOT_SUPPORT_CONTROL, sender.[GetType]().ToString()))
        End If

        Dim ctl As Control = TryCast(sender, Control)

        If value Is Nothing OrElse value.ToString.Length = 0 Then
            ErrorProvider.SetIconAlignment(ctl, ErrorIconAlignment.MiddleRight)
            ErrorProvider.SetError(ctl, GeneralString.NO_INPUT_DATA)
            'e.Cancel = True
        Else
            ErrorProvider.SetErrorType(ctl, ErrorType.None)
        End If
    End Sub
#End Region
End Class

