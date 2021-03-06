Imports System
Imports System.Xml
Imports System.Windows.Forms
Imports System.Reflection

Public Class frmNamKeToan
#Region "Variables"
    Private keyEncrypted As String = "hko98f8flKfOeiIlLjL" 'KEY FOR ENCRYPT AND DECRYPT
#End Region

#Region "Event Handles"
    Private Sub frmNamKeToan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ReadInfo()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtYear.MaskFull = True Then
                Generals.Nam_Ke_Toan = Integer.Parse(txtYear.Text)
                WriteInfo(txtYear.Text)
                ChangeNamKeToan()
            Else
                Message_Information("Năm không hợp lệ !")
                Return
            End If
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Common Function"

    Private Sub WriteInfo(ByVal nam_ke_toan As String)
        Try
            'Remove Lock
            'RemoveLock()

            'Encrypt info
            nam_ke_toan = Crypto.EncryptString128Bit(nam_ke_toan, keyEncrypted)

            'Get Document
            Dim doc As XmlDocument = XMLConfig.XmlReader("KTConfig.xml")
            'Get Root Element
            Dim root As XmlElement = doc.DocumentElement
            'Get element named "database_info", that include info about server setting
            Dim serverNode As XmlNode = root.SelectSingleNode("nam_ke_toan_info")
            'Write to file
            serverNode.SelectSingleNode("nam_kt").InnerText = nam_ke_toan

            'Save info
            doc.Save("KTConfig.xml")

            'Add Lock
            'AddLock()
        Catch
        End Try
    End Sub

    Private Sub ReadInfo()
        Try
            'Remove Lock
            'RemoveLock()

            'Get Document XML
            Dim doc As XmlDocument = XMLConfig.XmlReader("KTConfig.xml")
            'Get Root Element named "config"
            Dim root As XmlElement = doc.DocumentElement
            'Get element named "login_info"
            Dim serverNode As XmlNode = root.SelectSingleNode("nam_ke_toan_info")
            Dim nam_ke_toan As String = serverNode.SelectSingleNode("nam_kt").InnerText

            'Decrypt info
            nam_ke_toan = Crypto.DecryptString128Bit(nam_ke_toan, keyEncrypted)

            'Set info to control
            txtYear.Text = nam_ke_toan

            'Add Lock
            'AddLock()
        Catch
        End Try
    End Sub

    Private Sub AddLock()
        Crypto.AddLockFile("KTConfig.xml")
    End Sub

    Private Sub RemoveLock()
        Crypto.RemoveLockFile("KTConfig.xml")
    End Sub

    Private Sub DoLogOff()
        Try
            'Dim m_frmMain As Windows.Forms.Form = SystemHelper.GetFormAssemblyDirect("KTY.UI.frmMain", Nothing, False, "")
            'Dim method_UserLogOff As MethodInfo = GetMethodByName(m_frmMain, "UserLogOff")
            'Dim method_DoLogin As MethodInfo = GetMethodByName(m_frmMain, "DoLogin")
            'method_UserLogOff.Invoke(m_frmMain, Nothing)
            'method_DoLogin.Invoke(m_frmMain, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ChangeNamKeToan()
        'Dim m_frmMain As Windows.Forms.Form = SystemHelper.GetFormAssemblyDirect("KTY.UI.frmMain", Nothing, False, "")
        'Dim method_changeNamKT As MethodInfo = GetMethodByName(m_frmMain, "ChangeNamKT")
        'Dim arrParam() As Object = New Object() {Generals.Nam_Ke_Toan}
        'method_changeNamKT.Invoke(m_frmMain, arrParam)
        WriteInfo(Me.txtYear.Text)
    End Sub

    Private Function GetMethodByName(ByVal frmContainer As Windows.Forms.Form, ByVal methodName As String) As MethodInfo
        Try
            Dim type As Type = frmContainer.GetType()
            Dim methodReturn As MethodInfo = type.GetMethod(methodName)
            Return methodReturn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub frmNamKeToan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region


End Class