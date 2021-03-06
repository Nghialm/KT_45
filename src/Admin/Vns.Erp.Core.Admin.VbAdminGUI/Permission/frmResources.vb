'*************************************************************************
'	created:	2011/08/17
'	created:	17:8:2011   10:52
'	filename: 	D:\TRINAM\KeToan\v38\KTY.Main\Form\frmResources.vb
'	file path:	D:\TRINAM\KeToan\v38\KTY.Main\Form
'	file base:	frmResources
'	file ext:	vb
'	author:		Nguyễn Quyết Tiến
'	
'	purpose:	
'*************************************************************************
Imports System.Windows.Forms.ImageList
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
'Add/Remove resources for Menu
Public Class frmResources

#Region "Event Handles"
    '//////////////////////////////////////////////////
    ' Method:    frmResources_Load
    ' FullName:  frmResources.frmResources_Load
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmResources_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindImageToListControl()
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnClose_Click
    ' FullName:  frmResources.btnClose_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSubmit_Click
    ' FullName:  frmResources.btnSubmit_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        frmProgress.Instance.Thread = AddressOf DoSubmit
        frmProgress.Instance.Show_Progress()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    frmResources_KeyDown
    ' FullName:  frmResources.frmResources_KeyDown
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.Windows.Forms.KeyEventArgs
    '//////////////////////////////////////////////////
    Private Sub frmResources_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then

            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    imgListBoxControl_SelectedIndexChanged
    ' FullName:  frmResources.imgListBoxControl_SelectedIndexChanged
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles imgListBoxControl.SelectedIndexChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub imgListBoxControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgListBoxControl.SelectedIndexChanged
        Try
            txtValue.Text = imgListBoxControl.SelectedValue.ToString
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnDelete_Click
    ' FullName:  frmResources.btnDelete_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        frmProgress.Instance.Thread = AddressOf DeleteResources
        frmProgress.Instance.Show_Progress()
    End Sub
#End Region

#Region "Common Functions"

    '//////////////////////////////////////////////////
    ' Method:    BindImageToListControl
    ' FullName:  frmResources.BindImageToListControl
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub BindImageToListControl()
        Try
            Dim imgCol As ImageCollection = listImage.Images
            Dim app_path As String = Application.StartupPath
            app_path = app_path.Substring(0, app_path.LastIndexOf("bin"))
            app_path = app_path + "Resources\IconMenu\"
            Dim dirInfo As DirectoryInfo = Directory.CreateDirectory(app_path)
            Dim listFile() As FileInfo = dirInfo.GetFiles()
            Dim img As Image
            For i As Integer = 0 To listFile.Length - 1
                'Đưa ảnh vào trong ImageList Control
                img = Image.FromFile(listFile(i).FullName)
                imgCol.Add(img)
                'Đưa ảnh vào trong ImageListBox Control
                Dim valueImg As String = listFile(i).FullName
                valueImg = valueImg.Substring(valueImg.LastIndexOf("Resources"))
                imgListBoxControl.Items.Add(valueImg, i)
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    DeleteResources
    ' FullName:  frmResources.DeleteResources
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub DeleteResources()
        Try
            Dim app_path As String = Application.StartupPath
            app_path = app_path.Substring(0, app_path.LastIndexOf("bin"))
            Dim resource_name As String = txtValue.Text
            Dim file_path As String = app_path + resource_name
            File.Delete(file_path)
            If File.Exists(file_path) = False Then
                BindImageToListControl()
            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    DoSubmit
    ' FullName:  frmResources.DoSubmit
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub DoSubmit()
        Try
            'GetActiveClass.resources_name = txtValue.Text 'Tam thoi bo qua
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch
        End Try
    End Sub

#End Region

End Class