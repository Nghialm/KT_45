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

Public Class GridHelper
    Public Shared Sub RefreshLeftGrid(ByRef _GridView As Grid.GridView, ByRef _DataSource As List(Of Extend.CT_H_GInfo), ByVal _EditObject As Extend.CT_H_GInfo, ByVal _Status As DataInputState)
        Select Case _Status
            Case DataInputState.AddMode, DataInputState.CopyMode
                _DataSource.Add(_EditObject)
                If (_DataSource.Count = 1) Then
                    _GridView.GridControl.DataSource = _DataSource
                End If

                _GridView.RefreshData()
                If _DataSource IsNot Nothing And _DataSource.Count > 0 Then
                    For i = 0 To _GridView.RowCount - 1
                        Dim grtCTH_NX As Extend.CT_H_GInfo = CType(_GridView.GetRow(i), Extend.CT_H_GInfo)

                        If _EditObject.Id = grtCTH_NX.Id Then
                            _GridView.FocusedRowHandle = i
                            Exit For
                        End If
                    Next
                End If
            Case DataInputState.EditMode
                Dim grtCTH_NX As Extend.CT_H_GInfo = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), Extend.CT_H_GInfo)
                grtCTH_NX.NgayCt = _EditObject.NgayCt
                grtCTH_NX.NgayGhi = _EditObject.NgayGhi
                grtCTH_NX.SoTien = _EditObject.SoTien
                grtCTH_NX.MaLoaiCt = _EditObject.MaLoaiCt
                grtCTH_NX.Ghi = _EditObject.Ghi
                grtCTH_NX.DaKhoaSo = _EditObject.DaKhoaSo
                grtCTH_NX.Id = _EditObject.Id
                grtCTH_NX.CtSo = _EditObject.CtSo
        End Select
        _GridView.RefreshData()
    End Sub

    ''' <summary>
    ''' Xoa ban ghi duoc lua chon tren Phieu (Luoi ben Trai)
    ''' </summary>
    ''' <param name="_tempList">Danh sach ban ghi</param>
    ''' <param name="_ID">ID So sanh</param>
    ''' <returns>True: Duoc phep lay lai du lieu theo ID dc tra ve</returns>
    ''' <remarks></remarks>
    Public Shared Function RemoveLeftGrid(ByRef _tempList As List(Of Extend.CT_H_GInfo), ByVal _ID As Guid) As Guid
        For i = _tempList.Count - 1 To 0 Step -1
            If _tempList.Count = 1 Then
                _tempList.RemoveAt(0)
                Return New Guid()
            End If
            If _tempList(i).Id = _ID Then
                '
                _tempList.RemoveAt(i)
                '
                If (i = 0) Then
                    i = 1
                End If
                _ID = _tempList(i - 1).Id
                'SetObjectToControl()
                Return _ID
            End If
        Next

        Return New Guid()
    End Function

    Public Shared Function CheckAddNewRow(ByVal _GridView As Grid.GridView) As Boolean
        Return CheckAddNewRow(_GridView, True)
    End Function

    Public Shared Function CheckAddNewRow(ByVal _GridView As Grid.GridView, ByVal _ShowConfirm As Boolean) As Boolean
        Dim Check As Boolean = True
        If (_GridView.IsLastRow) Then
            Dim i As Integer = _GridView.Columns.Count
            Dim j As Integer = -1
            While i >= 0
                Try
                    If _GridView.GetVisibleColumn(i).Visible Then
                        j = _GridView.GetVisibleColumn(i).AbsoluteIndex
                        If _GridView.FocusedColumn.AbsoluteIndex = j And Not j = -1 Then
                            If (_ShowConfirm) Then
                                Dim dr As DialogResult = MessageBox.Show("Bạn có muốn thêm dòng mới không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                If dr = DialogResult.Yes Then
                                    Return True
                                Else
                                    Return False
                                End If
                            Else
                                Return True
                            End If
                        End If
                        Exit While
                    End If
                Catch ex As Exception
                End Try
                i = i - 1
            End While
        End If
        Return False
    End Function
End Class

