Imports Vns.Erp.Core.Accounting.Domain
Imports DevExpress.XtraGrid.Views
Imports Vns.Erp.Core

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
                Return Nothing
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

                        If _EditObject.CTH_NX_ID = grtCTH_NX.CTH_NX_ID Then
                            _GridView.FocusedRowHandle = i
                            Exit For
                        End If
                    Next
                End If
            Case DataInputState.EditMode
                Dim grtCTH_NX As Extend.CT_H_GInfo = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), Extend.CT_H_GInfo)
                grtCTH_NX.NGAY_CT = _EditObject.NGAY_CT
                grtCTH_NX.NGAY_GHI = _EditObject.NGAY_GHI
                grtCTH_NX.SO_TIEN = _EditObject.SO_TIEN
                grtCTH_NX.MA_LOAI_CT = _EditObject.MA_LOAI_CT
                grtCTH_NX.GHI = _EditObject.GHI
                grtCTH_NX.DA_KHOA_SO = _EditObject.DA_KHOA_SO
                grtCTH_NX.CTH_NX_ID = _EditObject.CTH_NX_ID
                grtCTH_NX.CT_SO = _EditObject.CT_SO
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
            If _tempList(i).CTH_NX_ID = _ID Then
                '
                _tempList.RemoveAt(i)
                '
                If (i = 0) Then
                    i = 1
                End If
                _ID = _tempList(i - 1).CTH_NX_ID
                'SetObjectToControl()
                Return _ID
            End If
        Next

        Return New Guid()
    End Function
End Class
