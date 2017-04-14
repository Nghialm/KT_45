Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Vns.Erp.Core.Admin.Domain
Imports DevExpress.Utils
Imports System.Drawing

'Imports KTY.ObjectInfo


Public Class Generals

    ''' <summary>
    ''' DataSet chua thong tin cau hinh cho xu ly log DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared DBLOG_CONFIG As DataSet = New DataSet()

    ''' <summary>
    ''' Doi tuong don vi - Khi nguoi dung lua chon don vi dang nhap.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared DON_VI As DmDonvi = New DmDonvi()
    Public Shared DonviID As Guid

    ''' <summary>
    ''' Doi tuong Nguoi dung - Nguoi dung dang nhap vao he thong
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared USER As AppUsers = New AppUsers()
    Public Shared Nam_Ke_Toan As Integer = 2010

    ''' <summary>
    ''' Thu muc chay chuogn trinh
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ThuMucChayCT As String = ""
    ''' <summary>
    ''' Thu muc luu File mau bao cao
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ThuMucFileBaocao As String = ""

    ''' <summary>
    ''' Duong dan file cau hinh Grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared FileResourceGrid As String = ""


    Public Shared TS_TuDo1 As HtThamso = New HtThamso()
    Public Shared TS_TuDo2 As HtThamso = New HtThamso()
    Public Shared TS_TuDo3 As HtThamso = New HtThamso()
    Public Shared TS_TuDo4 As HtThamso = New HtThamso()
    Public Shared TS_TuDo5 As HtThamso = New HtThamso()

    Public Shared TS_ThueGTGTDauVao As HtThamso = New HtThamso()
    Public Shared TS_ThueGTGTDauRa As HtThamso = New HtThamso()

    Public Shared TS_NoiTe_ID As HtThamso = New HtThamso()

    Public Shared Df_Tk_Kho As HtThamso = New HtThamso()
    Public Shared Df_Tk_DoanhThu As HtThamso = New HtThamso()
    Public Shared Df_Tk_GiaVon As HtThamso = New HtThamso()
    Public Shared Df_PP_TinhGiaKho As HtThamso = New HtThamso()

    Public Shared Ts_PheDuyetChungTu As Boolean = False
    Public Shared Ts_Auto_gen_KyHieu As Boolean = False

    Public Shared appError As AppearanceDefault = New AppearanceDefault(Color.White, Color.LightCoral, Color.Empty, Color.Pink, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)

    '0: Super Admin
    '1: Nomal
    Public Shared PriorityLevel As Integer = 1
End Class



