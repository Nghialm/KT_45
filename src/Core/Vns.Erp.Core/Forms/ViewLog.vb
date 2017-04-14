Public Class ViewLog
#Region "Variables"
    Private _ROW_DATA As DataRow
    Public Property ROW_DATA() As System.Data.DataRow
        Get
            Return _ROW_DATA
        End Get
        Set(ByVal value As System.Data.DataRow)
            _ROW_DATA = value
        End Set
    End Property
#End Region

#Region "Event Hanles"
    Private Sub ViewLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TNCommon.setIconControl(Me)
            BindData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Common Functions"
    Private Sub Demo()
        'Dim listLog As New List(Of LogInfo)
        'listLog.Add(New LogInfo(1, "Tên người tạo", "Nguyễn Quyết Tiến"))
        'listLog.Add(New LogInfo(1, "Tên người sửa", "Nguyễn Thế Việt"))
        'listLog.Add(New LogInfo(1, "Ngày tạo so với máy chủ", "20/11/2011"))
        'listLog.Add(New LogInfo(3, "Ngày sửa so với máy chủ", "21/11/2011"))
        'listLog.Add(New LogInfo(3, "Thời gian tạo so với máy chủ", "11:49:15"))
        'listLog.Add(New LogInfo(2, "Thời gian sửa so với máy chủ", "08:50:44"))
        'listLog.Add(New LogInfo(2, "Tạo tại máy trạm", "TIENIT-PC # TIENIT"))
        'listLog.Add(New LogInfo(0, "Sửa tại máy trạm", "VIETNT-PC # VIETNT"))
        'grcMain.DataSource = listLog
    End Sub

    'Private Function GetInfo() As List(Of LogInfo)
    '    Dim listData As New List(Of LogInfo)

    '    If Not ROW_DATA Is Nothing Then
    '        Dim nguoi_tao_id As String = ""
    '        Dim nguoi_sua_id As String = ""
    '        Dim nguoi_tao_name As String = ""
    '        Dim nguoi_sua_name As String = ""
    '        Dim date_tao As String = ""
    '        Dim date_sua As String = ""
    '        Dim ngay_tao As String = ""
    '        Dim ngay_sua As String = ""
    '        Dim tg_tao As String = ""
    '        Dim tg_sua As String = ""
    '        Dim may_tram_tao As String = ""
    '        Dim may_tram_sua As String = ""

    '        Try
    '            nguoi_tao_id = ROW_DATA("NGUOI_TAO").ToString
    '            date_tao = ROW_DATA("NGAY_TAO").ToString
    '            nguoi_sua_id = ROW_DATA("NGUOI_SUA").ToString
    '            date_sua = ROW_DATA("NGAY_SUA").ToString
    '        Catch
    '        End Try

    '        Try
    '            If Not nguoi_tao_id.Equals("") Then
    '                nguoi_tao_name = GetById(Decimal.Parse(nguoi_tao_id)).Tables(0).Rows(0)("FULLNAME").ToString
    '            End If
    '            listData.Add(New LogInfo(0, "Tên người tạo", nguoi_tao_name))
    '        Catch
    '        End Try

    '        Try
    '            If Not nguoi_sua_id.Equals("") Then
    '                nguoi_sua_name = GetById(Decimal.Parse(nguoi_sua_id)).Tables(0).Rows(0)("FULLNAME").ToString
    '            End If
    '            listData.Add(New LogInfo(0, "Tên người sửa", nguoi_sua_name))
    '        Catch
    '        End Try

    '        Try
    '            If Not date_tao.Equals("") Then
    '                Dim dateTAO As DateTime = DateTime.Parse(date_tao)
    '                ngay_tao = dateTAO.Day.ToString + "/" + dateTAO.Month.ToString + "/" + dateTAO.Year.ToString
    '                tg_tao = dateTAO.Hour.ToString + ":" + dateTAO.Minute.ToString + ":" + dateTAO.Second.ToString
    '            End If
    '            listData.Add(New LogInfo(1, "Ngày tạo so với máy chủ", ngay_tao))
    '            listData.Add(New LogInfo(1, "Thời gian tạo so với máy chủ", tg_tao))
    '        Catch
    '        End Try

    '        Try
    '            If Not date_sua.Equals("") Then
    '                Dim dateSUA As DateTime = DateTime.Parse(date_sua)
    '                ngay_sua = dateSUA.Day.ToString + "/" + dateSUA.Month.ToString + "/" + dateSUA.Year.ToString
    '                tg_sua = dateSUA.Hour.ToString + ":" + dateSUA.Minute.ToString + ":" + dateSUA.Second.ToString
    '            End If
    '            listData.Add(New LogInfo(2, "Ngày sửa so với máy chủ", ngay_sua))
    '            listData.Add(New LogInfo(2, "Thời gian sửa so với máy chủ", tg_sua))
    '        Catch
    '        End Try

    '        Try
    '            may_tram_tao = Environment.MachineName + " # " + Environment.UserName
    '            may_tram_sua = Environment.MachineName + " # " + Environment.UserName
    '            listData.Add(New LogInfo(3, "Tạo tại máy trạm", may_tram_tao))
    '            listData.Add(New LogInfo(3, "Sửa tại máy trạm", may_tram_sua))
    '        Catch
    '        End Try
    '    End If

    '    Return listData
    'End Function

    Private Sub BindData()
        'Dim listData As List(Of LogInfo) = GetInfo()
        'grcMain.DataSource = listData
    End Sub

    Public Function GetById(ByVal USERID As Decimal) As DataSet
        'Return OracleHelper.ExecuteDataset(OracleConnect.ConnectionString, Constants.Instance.APP_ADMIN_PKG_APP_USERS_GETBYID, USERID)
    End Function
#End Region
End Class