Imports System.Text.RegularExpressions
Imports System.Reflection

Public Module Globals

    Public CS_DISPLAY_DATE_FORMAT As String = "dd/MM/yyyy"
    Public CS_DISPLAY_NUMBER_FORMAT As String = "#,###"
    Public CS_DISPLAY_DATETIME_FORMAT As String = "dd/MM/yyyy HH:mm"
    Public CS_EDIT_DATE_FORMAT As String = "dd/MM/yyyy"
    Public CS_DECIMAL_SYMBOL As String = "."
    Public CS_DIGIT_GROUP_SYMBOL As String = ","
    Public HD_BQT_ID As String = "00000000000000000000000000000000"
    Public CS_ENTER_MOVE_NEXT_CONTROL As Boolean = True
    Private _LoginUserID As Guid
    Private _LoginUserName As String = String.Empty
    Private _LoginFullName As String = String.Empty
    Private _ActiveMenuName As String = String.Empty
    Private _ActiveMenuText As String = String.Empty
    Private _DonVi_ID As Decimal

#Region "Custom Menu and Data Cache"
    'Khong dung ten don vi o day
    'ID của đơn vị mà người dùng đăng nhập (DONVI_ID)
    'Public MADONVI As String = String.Empty

    'Khong dung ten don vi o day
    'Tên đơn vị của người dùng đăng nhập
    'Được sử dụng để hiển thị ở dưới thanh Status Bar của frmMain
    'Public TENDONVI As String = String.Empty

    'Danh sách chức năng
    'Danh sách các APP_FORMS
    Private _LIST_FORMS As List(Of Guid)

    'Danh sách nhóm chức năng cấp 2
    'Danh sách các APP_GROUP_FUNCTION là cha của LIST_FORMS
    Private _LIST_LEVEL2 As List(Of Guid)

    'Danh sách nhóm chức năng cấp 1
    'Danh sách các APP_GROUP_FUNCTION là cha của LIST_LEVEL2
    Private _LIST_LEVEL1 As List(Of Guid)

    'Danh sách nhóm của người dùng đang đăng nhập
    Private _LIST_USER_GROUP As List(Of Guid)

    'Xác định Admin cấp cao nhất
    Private _IS_ADMIN_TONG As Boolean
    'Xác đinh Admin cấp đơn vị
    Private _IS_ADMIN_DV As Boolean
    'Xác định nhân viên
    Private _IS_MEMBER As Boolean

    Public Property IS_ADMIN_TONG() As Boolean
        Get
            Return _IS_ADMIN_TONG
        End Get
        Set(ByVal value As Boolean)
            _IS_ADMIN_TONG = value
        End Set
    End Property

    Public Property IS_ADMIN_DV() As Boolean
        Get
            Return _IS_ADMIN_DV
        End Get
        Set(ByVal value As Boolean)
            _IS_ADMIN_DV = value
        End Set
    End Property

    Public Property IS_MEMBER() As Boolean
        Get
            Return _IS_MEMBER
        End Get
        Set(ByVal value As Boolean)
            _IS_MEMBER = value
        End Set
    End Property

    Public Property LIST_USER_GROUP() As List(Of Guid)
        Get
            Return _LIST_USER_GROUP
        End Get
        Set(ByVal value As List(Of Guid))
            _LIST_USER_GROUP = value
        End Set
    End Property

    Public Property LIST_FORMS() As List(Of Guid)
        Get
            Return _LIST_FORMS
        End Get
        Set(ByVal value As List(Of Guid))
            _LIST_FORMS = value
        End Set
    End Property

    Public Property LIST_LEVEL2() As List(Of Guid)
        Get
            Return _LIST_LEVEL2
        End Get
        Set(ByVal value As List(Of Guid))
            _LIST_LEVEL2 = value
        End Set
    End Property

    Public Property LIST_LEVEL1() As List(Of Guid)
        Get
            Return _LIST_LEVEL1
        End Get
        Set(ByVal value As List(Of Guid))
            _LIST_LEVEL1 = value
        End Set
    End Property
#End Region

    Public Property ActiveMenuName() As String
        Get
            Return _ActiveMenuName
        End Get
        Set(ByVal Value As String)
            _ActiveMenuName = Value
        End Set
    End Property

    Public Property ActiveMenuText() As String
        Get
            Return _ActiveMenuText
        End Get
        Set(ByVal Value As String)
            _ActiveMenuText = Value
        End Set
    End Property

#Region "User Logged in System"
    Public Property LoginUserID() As Guid
        Get
            Return _LoginUserID
        End Get
        Set(ByVal Value As Guid)
            _LoginUserID = Value
        End Set
    End Property

    Public Property LoginUserName() As String
        Get
            Return _LoginUserName
        End Get
        Set(ByVal Value As String)
            _LoginUserName = Value
        End Set
    End Property

    Public Property LoginFullName() As String
        Get
            Return _LoginFullName
        End Get
        Set(ByVal Value As String)
            _LoginFullName = Value
        End Set
    End Property
#End Region

    Public Property DonVi_ID() As String
        Get
            Return _DonVi_ID
        End Get
        Set(ByVal Value As String)
            _DonVi_ID = Value
        End Set
    End Property

    Public Function DB_GetNull(ByVal objField As Object) As Object
        Return Null.GetNull(objField, DBNull.Value)
    End Function

    Public Function DB_GetValue(ByVal objField As Object, Optional ByVal objDefault As Object = "") As Object
        If objField Is DBNull.Value OrElse objField Is Nothing Then
            Return objDefault
        Else
            Return objField
        End If
    End Function

    Public Function DB_CheckValue(ByVal objField As Object) As Boolean
        If objField Is DBNull.Value OrElse objField Is Nothing Then
            Return False
        Else
            If TypeOf objField Is String Then
                Return Not String.IsNullOrEmpty(objField)
            Else
                Return True
            End If
        End If
    End Function

    Public Function DB_GetString(ByVal objField As Object, Optional ByVal strDefault As String = "") As String
        If objField Is DBNull.Value Then
            Return strDefault
        Else
            If TypeOf objField Is Date Then
                Return DirectCast(objField, Date).ToString(CS_DISPLAY_DATE_FORMAT)
            ElseIf Not objField Is Nothing Then
                Return objField.ToString
            Else
                Return ""
            End If
        End If
    End Function

    Public Function ConnectString_BuildOracle(ByVal sServerName As String _
    , ByVal sDataName As String _
    , ByVal sUserID As String _
    , ByVal sPassword As String _
    , Optional ByVal iMaxPoolSize As Integer = 0 _
    ) As String
        Dim sCnn As String
        sCnn = "Data Source=(DESCRIPTION=" _
                   + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + sServerName + ")(PORT=1521)))" _
                   + "(CONNECT_DATA=(SERVICE_NAME=" + sDataName + ")));" _
                   + "User Id=" + sUserID + ";Password=" + sPassword + ";ENLIST=FALSE;Connection Lifetime=600;"
        If iMaxPoolSize = 0 Then
            sCnn += "Pooling=false;"
        Else
            sCnn += String.Format("Max Pool Size={0};Incr Pool Size=1;", iMaxPoolSize)
        End If

        Return sCnn
    End Function

    Public Sub ConnectString_SetValue(ByRef sConnect As String, ByVal sKeyName As String, ByVal sKeyValue As String)
        Dim sCnn As String
        Dim iPos As Integer = sConnect.IndexOf(sKeyName) + 1
        If iPos > 0 Then
            Dim iNextPos As Integer = sConnect.IndexOf(";", iPos)
            sCnn = sConnect.Substring(0, iPos + sKeyName.Length) + sKeyValue
            If iNextPos >= 0 Then
                sCnn += sConnect.Substring(iNextPos)
            End If
        Else
            sCnn = sConnect.Trim
            If Not sCnn.EndsWith(";") Then sCnn += ";"
            sCnn += sKeyName + "=" + sKeyValue
        End If
        sConnect = sCnn
    End Sub

    Public Function ConnectString_GetValue(ByVal sConnect As String, ByVal sKeyName As String) As String
        Dim sKeyValue As String = sConnect
        sKeyValue = sKeyValue.Substring(sKeyValue.IndexOf(sKeyName) + sKeyName.Length)
        sKeyValue = sKeyValue.Substring(sKeyValue.IndexOf("=") + "=".Length)
        If sKeyValue.IndexOf(";") > 0 Then
            sKeyValue = sKeyValue.Substring(0, sKeyValue.IndexOf(";"))
        End If
        sKeyValue = sKeyValue.Trim
        Return sKeyValue
    End Function

    Public Function String_IsMixPass(ByVal sPassword As String) As Boolean
        'Ham kiem tra password co bao gom ca chu va so hay khong
        'Return Regex.IsMatch(sPassword, "^\w*$")
        Return Regex.IsMatch(sPassword, "^(?=.*\d)(?=.*[a-zA-Z])")
    End Function

    ''' <summary>
    ''' method for determining is the user provided a valid email address
    ''' We use regular expressions in this check, as it is a more thorough
    ''' way of checking the address provided
    ''' </summary>
    ''' <param name="email">email address to validate</param>
    ''' <returns>true is valid, false if not valid</returns>
    Public Function String_IsValidEmail(ByVal email As String) As Boolean
        'regular expression pattern for valid email
        'addresses, allows for the following domains:
        'com,edu,info,gov,int,mil,net,org,biz,name,museum,coop,aero,pro,tv
        Dim pattern As String = "^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\." & _
        "(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$"
        'Regular expression object
        Dim check As New System.Text.RegularExpressions.Regex(pattern, RegexOptions.IgnorePatternWhitespace)
        'boolean variable to return to calling method
        Dim valid As Boolean = False

        'make sure an email address was provided
        If String.IsNullOrEmpty(email) Then
            valid = False
        Else
            'use IsMatch to validate the address
            valid = check.IsMatch(email)
        End If
        'return the value to the calling method
        Return valid
    End Function

    Public Function Reader2Table(ByVal objDataReader As IDataReader) As DataTable
        Dim dt As New DataTable
        dt.Load(objDataReader)
        objDataReader.Close()
        objDataReader.Dispose()
        Return dt
    End Function

    Public Sub DataTable_SetKey(ByRef dt As DataTable, ByVal sColName As String)
        dt.PrimaryKey = New DataColumn() {dt.Columns(sColName)}
        dt.AcceptChanges()
    End Sub

    Public Sub Reader_Close(ByVal obj As IDataReader)
        If obj Is Nothing Then Return
        obj.Close()
        obj.Dispose()
    End Sub

    '<LuanNH - Cac ham phuc vu viec fill tu Reader to Info nhanh hon dung CBO truyen thong>  
    'Notes: toc do nhanh hon khoang 5% :(
    Private m_cacheReaderIndex As Dictionary(Of String, List(Of Integer))

    Private Function FillObject_CacheKey(ByVal sType As String, ByVal iFieldCount As Integer) As String
        Return sType + String.Format("|{0}", iFieldCount)
    End Function

    Public Sub Reader_FillObject(ByVal rd As IDataReader, ByRef objObject As Object)
        Reader_FillObject(rd, objObject, True)
    End Sub

    Public Sub Reader_FillObject(ByVal rd As IDataReader, ByRef objObject As Object, ByVal bManageReader As Boolean)
        Try
            If bManageReader AndAlso rd.Read = False Then
                objObject = Nothing
                Return 'return when no data found
            End If
            '
            Dim objType As Type = objObject.GetType
            Dim objProperty As PropertyInfo
            Dim arrProperty As PropertyInfo() = objType.GetProperties()
            Dim sKey As String = FillObject_CacheKey(objType.Name, rd.FieldCount)
            Dim dicIndex As Generic.List(Of Integer)
            '----------------
            If Not m_cacheReaderIndex Is Nothing AndAlso m_cacheReaderIndex.ContainsKey(sKey) Then
                dicIndex = m_cacheReaderIndex(sKey)
                For iPro As Integer = 0 To dicIndex.Count - 1
                    Dim iField As Integer = dicIndex(iPro)
                    If iField = -1 Then Continue For
                    Object_SetPropertyValue(objObject, arrProperty(iPro), rd.Item(iField))
                Next
            Else
                dicIndex = New Generic.List(Of Integer)
                For iProIndex As Integer = 0 To arrProperty.Count - 1
                    objProperty = arrProperty(iProIndex)
                    Dim iIndex As Integer
                    If objProperty.CanWrite Then
                        iIndex = Reader_ColumnIndex(rd, objProperty.Name)
                        If iIndex > -1 Then
                            Object_SetPropertyValue(objObject, objProperty, rd.Item(iIndex))
                        End If
                    Else
                        iIndex = -1
                    End If
                    dicIndex.Add(iIndex)
                Next
                If m_cacheReaderIndex Is Nothing Then m_cacheReaderIndex = New Dictionary(Of String, List(Of Integer))
                m_cacheReaderIndex.Add(sKey, dicIndex)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If bManageReader Then
                Reader_Close(rd)
            End If
        End Try
    End Sub

    Public Function Reader_FillObject(ByVal dr As IDataReader, ByVal objType As Type, ByVal bManageReader As Boolean) As Object
        Dim objObject As Object = Activator.CreateInstance(objType)
        Reader_FillObject(dr, objObject, bManageReader)
        Return objObject
    End Function

    Public Function Reader_FillObject(ByVal dr As IDataReader, ByVal objType As Type) As Object
        Dim objObject As Object = Activator.CreateInstance(objType)
        Reader_FillObject(dr, objObject)
        Return objObject
    End Function

    Public Function Reader_FillCollection(ByVal dr As IDataReader, ByVal objType As Type) As ArrayList
        Try
            Dim arr As New ArrayList
            While dr.Read
                Dim objObject As Object = Activator.CreateInstance(objType)
                Reader_FillObject(dr, objObject, False)
                arr.Add(objObject)
            End While
            Return arr
        Catch ex As Exception
            Throw ex
        Finally
            Reader_Close(dr)
        End Try
    End Function

    Public Function Reader_GetValue(ByVal rd As IDataReader, ByVal sItemName As String) As Object
        Dim iIndex As Integer
        iIndex = Reader_ColumnIndex(rd, sItemName)
        If iIndex >= 0 Then
            Return rd.Item(iIndex)
        Else
            Return Nothing
        End If
    End Function

    Public Function Reader_GetValue(ByVal rd As IDataReader, ByVal sItemName As String, ByVal dicColumn As Generic.Dictionary(Of String, Integer)) As Object
        Dim iIndex As Integer
        If dicColumn.ContainsKey(sItemName) Then
            iIndex = dicColumn.Item(sItemName)
        Else
            iIndex = Reader_ColumnIndex(rd, sItemName)
            dicColumn.Add(sItemName, iIndex)
        End If
        If iIndex >= 0 Then
            Return rd.Item(iIndex)
        Else
            Return Nothing
        End If
    End Function

    Public Function Reader_ColumnList(ByVal rd As IDataReader) As Generic.Dictionary(Of String, Integer)
        Dim rt As New Generic.Dictionary(Of String, Integer)
        For i As Integer = 0 To rd.FieldCount - 1
            rt.Add(rd.GetName(i), i)
        Next
        Return rt
    End Function

    Public Function Reader_ColumnIndex(ByVal rd As IDataReader, ByVal sColumn As String) As Integer
        'For i As Integer = 0 To rd.FieldCount - 1
        '    If sColumn.Equals(rd.GetName(i), StringComparison.CurrentCultureIgnoreCase) Then
        '        Return i
        '    End If
        'Next
        'Return -1
        Try
            Return rd.GetOrdinal(sColumn)
        Catch
            Return -1
        End Try
    End Function
    '</LuanNH - Cac ham phuc vu viec fill tu Reader to Info nhanh hon dung CBO truyen thong>

    Public Sub Object_SetValue(ByVal objSource As Object, ByRef objDest As Object)
        'Purpose: 
        '   Sử dụng để gán giá trị từ kiểu dữ liệu này sang kiểu dữ liệu khác
        'Parameters: 
        '   objSource : dữ liệu nguồn
        '   objDest   : dữ liệu đích
        'Notes:
        '   

        Dim sValue As Object = Nothing
        If Not objSource Is Nothing Then
            If TypeName(objDest) = TypeName(objSource) Then
                objDest = objSource
                Exit Sub
            ElseIf objSource Is DBNull.Value Then
                objDest = Null.SetNull(DBNull.Value, objDest)
            Else
                sValue = objSource.ToString
            End If
        Else
            sValue = ""
        End If
        If objDest Is Nothing Then
            objDest = sValue
        Else
            objDest = Object_SetValueEx(sValue, objDest.GetType.Name)
        End If
    End Sub

    Public Function Object_SetValueEx(ByVal sValue As Object, ByVal sType As String, Optional ByVal bForDB As Boolean = False)
        Dim objDest As Object
        Select Case sType
            Case "DateTime", "Date"
                If IsDate(sValue) Then
                    If sValue Like "##:##" Or sValue Like "#:##" Then
                        objDest = DateTime.Parse(sValue)
                    Else
                        objDest = Date_ParseEx(sValue) '.ToString(CS_DISPLAY_DATE_FORMAT)
                    End If
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullDate
                    End If
                End If
            Case "Integer", "Int32"
                'xu ly truong hop gia tri truyen vao la dbnull.value
                If sValue Is DBNull.Value Then
                    sValue = ""
                End If
                '
                If IsNumeric(sValue) Then
                    objDest = Integer.Parse(sValue)
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullInteger
                    End If
                End If
            Case "Long", "Int64"
                'xu ly truong hop gia tri truyen vao la dbnull.value
                If sValue Is DBNull.Value Then
                    sValue = ""
                End If
                '
                If IsNumeric(sValue) Then
                    objDest = Long.Parse(sValue)
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullLong
                    End If
                End If
            Case "Short", "Int16"
                'xu ly truong hop gia tri truyen vao la dbnull.value
                If sValue Is DBNull.Value Then
                    sValue = ""
                End If
                '
                If IsNumeric(sValue) Then
                    objDest = Short.Parse(sValue)
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullShort
                    End If
                End If
            Case "Double"
                'xu ly truong hop gia tri truyen vao la dbnull.value
                If sValue Is DBNull.Value Then
                    sValue = ""
                End If
                '
                If IsNumeric(sValue) Then
                    objDest = Double.Parse(sValue)
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullDouble
                    End If
                End If
            Case "Single"
                'xu ly truong hop gia tri truyen vao la dbnull.value
                If sValue Is DBNull.Value Then
                    sValue = ""
                End If
                '
                If IsNumeric(sValue) Then
                    objDest = Single.Parse(sValue)
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullSingle
                    End If
                End If
            Case "Decimal"
                'xu ly truong hop gia tri truyen vao la dbnull.value
                If sValue Is DBNull.Value Then
                    sValue = ""
                End If
                '
                If IsNumeric(sValue) Then
                    objDest = Decimal.Parse(sValue)
                Else
                    If bForDB Then
                        objDest = DBNull.Value
                    Else
                        objDest = Null.NullDecimal
                    End If
                End If
            Case "String"
                If sValue Is DBNull.Value Then
                    objDest = ""
                Else
                    objDest = sValue
                End If
            Case "Boolean"
                If sValue Is DBNull.Value Then
                    objDest = False
                Else
                    Select Case (sValue.ToString().ToUpper())
                        Case "TRUE"
                            objDest = True
                        Case "FALSE"
                            objDest = False
                    End Select
                End If
            Case "Guid"
                If sValue Is DBNull.Value Then
                    objDest = Guid.Empty
                Else
                    If sValue.GetType Is GetType(Guid) Then
                        objDest = CType(sValue, Guid)
                    Else
                        'objDest = New Guid(CType(sValue, Byte()))
                        objDest = New Guid(CType(sValue, String))
                    End If
                End If

            Case Else
                If sValue Is DBNull.Value Then
                    objDest = Nothing
                Else
                    objDest = sValue
                End If
        End Select
        Return objDest
    End Function

    Public Function Object_GetDisplayValue(ByVal objSource As Object, Optional ByVal sNullValue As String = "", Optional ByVal Scale As Integer = -1) As String
        'Purpose: 
        '   Customize ToString 
        'Parameters: 
        '   objSource : dữ liệu nguồn
        'Notes:
        '   Đối với dữ liệu kiểu Date sẽ tự chuyển thành CS_DISPLAY_DATE_FORMAT
        '   Đối với dữ liệu kiểu Numeric sẽ tự format 0,000.00 và tự động bỏ các số 0 thừa

        If TypeOf objSource Is Boolean Then
            If CType(objSource, Boolean) = True Then
                Return "Yes"
            Else
                Return "No"
            End If
        Else
            If Null.IsNull(objSource) Then
                Return sNullValue
            Else
                If TypeOf objSource Is Date Then
                    'Return objSource.ToShortDateString
                    Return CType(objSource, Date).ToString(CS_DISPLAY_DATE_FORMAT)
                Else
                    If (Not TypeOf objSource Is String) AndAlso IsNumeric(objSource) Then
                        Dim s As String = FormatNumber(objSource, Scale, TriState.True)
                        Dim sDecChar As String
                        'If g_bIsLocal Then
                        sDecChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
                        'Else
                        ' sDecChar = Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
                        'End If

                        Dim iPos As Integer = s.ToString.LastIndexOf(sDecChar)
                        If iPos > -1 Then
                            Dim sDecNum As String = s.ToString.Substring(iPos)
                            Do Until sDecNum = ""
                                If sDecNum.Substring(sDecNum.Length - 1) <> "0" Then
                                    Exit Do
                                Else
                                    sDecNum = sDecNum.Substring(0, sDecNum.Length - 1)
                                End If
                            Loop
                            If sDecNum = sDecChar Then sDecNum = ""
                            s = s.Substring(0, iPos) + sDecNum
                            If s.Length = 0 Then s = "0"
                            objSource = s
                        End If
                    End If
                    Return objSource.ToString
                End If
            End If
        End If
    End Function

    Public Function Object_GetPropertyValue(ByVal objItem As Object, ByVal sPropertyName As String) As Object
        Dim objType As Type = objItem.GetType
        Dim objProperty As PropertyInfo = Object_GetProperty(objType, sPropertyName)
        If objProperty Is Nothing Then
            Return Nothing
        Else
            Return objProperty.GetValue(objItem, Nothing)
        End If
    End Function

    Public Function Object_GetProperty(ByVal objType As Type, ByRef sPropertyName As String) As PropertyInfo
        Dim objReturn As PropertyInfo = objType.GetProperty(sPropertyName)
        'Ignore Case
        If objReturn Is Nothing Then
            Dim arr() As PropertyInfo = objType.GetProperties
            For Each obj As PropertyInfo In arr
                If obj.Name.ToUpper = sPropertyName.ToUpper Then
                    sPropertyName = obj.Name
                    objReturn = obj
                    Exit For
                End If
            Next
        End If
        Return objReturn
    End Function

    Public Function Object_Compare(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        'Purpose: 
        '   Hỗ trợ cho phần SetComboValue
        '   So sánh 2 Object dựa trên Properties
        'Parameters: 
        '
        'Notes
        '   Chú ý nếu trong phần định nghĩa prototye của Object 
        '   có trường PK lưu tên của thuộc tính PK
        '   thì khi compare chỉ compare các thuộc tính PK này
        Dim mReturn As Boolean = True
        Dim objProperty As PropertyInfo

        objProperty = Object1.GetType.GetProperty("PK")

        If Not objProperty Is Nothing Then

            Dim arrPK() As String = CType(objProperty.GetValue(Object1, Nothing), String).Split(";")
            For i As Long = 0 To arrPK.GetUpperBound(0)
                objProperty = Object1.GetType.GetProperty(arrPK(i))
                If objProperty Is Nothing Then
                    mReturn = False
                    Exit For
                Else
                    If objProperty.GetValue(Object1, Nothing) <> objProperty.GetValue(Object2, Nothing) Then
                        mReturn = False
                        Exit For
                    End If
                End If
            Next
        End If
        If Not mReturn Then
            For Each objProperty In Object1.GetType.GetProperties
                If objProperty.GetValue(Object1, Nothing) <> objProperty.GetValue(Object2, Nothing) Then
                    mReturn = False
                    Exit For
                End If
            Next
        End If
        Return mReturn
    End Function
    'Private cache mapping table column index with object property
    Private m_cacheTableColumn As New Dictionary(Of String, List(Of Integer))

    Public Sub DataRow_FillObject(ByVal dtRow As DataRow, ByRef objObject As Object)
        '
        Dim objType As Type = objObject.GetType
        Dim objProperty As PropertyInfo
        Dim arrProperty As PropertyInfo() = objType.GetProperties()
        Dim sKey As String = FillObject_CacheKey(objType.Name, dtRow.Table.Columns.Count)
        Dim dicIndex As Generic.List(Of Integer)
        '----------------
        If Not m_cacheTableColumn Is Nothing AndAlso m_cacheTableColumn.ContainsKey(sKey) Then
            dicIndex = m_cacheTableColumn(sKey)
            For iPro As Integer = 0 To dicIndex.Count - 1
                Dim iField As Integer = dicIndex(iPro)
                If iField = -1 Then Continue For
                Object_SetPropertyValue(objObject, arrProperty(iPro), dtRow.Item(iField))
            Next
        Else
            dicIndex = New Generic.List(Of Integer)
            For iProIndex As Integer = 0 To arrProperty.Count - 1
                objProperty = arrProperty(iProIndex)
                Dim iIndex As Integer
                If objProperty.CanWrite Then
                    iIndex = dtRow.Table.Columns.IndexOf(objProperty.Name)
                    If iIndex > -1 Then
                        Object_SetPropertyValue(objObject, objProperty, dtRow.Item(iIndex))
                    End If
                Else
                    iIndex = -1
                End If
                dicIndex.Add(iIndex)
            Next
            If m_cacheTableColumn Is Nothing Then m_cacheTableColumn = New Dictionary(Of String, List(Of Integer))
            m_cacheTableColumn.Add(sKey, dicIndex)
        End If
    End Sub

    Public Sub Object_SetPropertyValue(ByRef objObject As Object, ByVal objPropertyInfo As PropertyInfo, ByVal objValue As Object)
        If IsDBNull(objValue) Then
            ' translate Null value
            objPropertyInfo.SetValue(objObject, Null.SetNull(objPropertyInfo), Nothing)
        Else
            Try
                ' try implicit conversion first
                objPropertyInfo.SetValue(objObject, objValue, Nothing)
            Catch
                Dim objPropertyType As Type
                ' business object info class member data type does not match datareader member data type
                objPropertyType = objPropertyInfo.PropertyType
                Try
                    'need to handle enumeration conversions differently than other base types
                    If objPropertyType.IsEnum Then
                        ' check if value is numeric and if not convert to integer ( supports databases like Oracle )
                        If IsNumeric(objValue) Then
                            objPropertyInfo.SetValue(objObject, System.Enum.ToObject(objPropertyType, Convert.ToInt32(objValue)), Nothing)
                        Else
                            objPropertyInfo.SetValue(objObject, System.Enum.ToObject(objPropertyType, objValue), Nothing)
                        End If
                    Else
                        ' try explicit conversion
                        objPropertyInfo.SetValue(objObject, Convert.ChangeType(objValue, objPropertyType), Nothing)
                    End If
                Catch
                    If objPropertyType.Name = "Boolean" Then
                        objPropertyInfo.SetValue(objObject, CType(objValue, Boolean), Nothing)
                    Else
                        objPropertyInfo.SetValue(objObject, Convert.ChangeType(objValue, objPropertyType), Nothing)
                    End If
                End Try
            End Try
        End If
    End Sub

    Public Function DataRow_FillObject(ByVal dtRow As DataRow, ByVal objType As Type) As Object
        Dim objObject As Object = Activator.CreateInstance(objType)
        DataRow_FillObject(dtRow, objObject)
        Return objObject
    End Function

    Public Function Date_ParseEx(ByVal sValue As String) As Date
        Dim mDate As Date
        'If Date.TryParseExact(sValue, CS_EDIT_DATE_FORMAT, Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.AdjustToUniversal, mDate) Then
        '    Return mDate
        'Else
        '    If Date.TryParse(sValue, mDate) Then
        '        Return mDate
        '    Else
        '        Return Null.NullDate
        '    End If
        'End If
        Date_TryParseEx(sValue, mDate)
        Return mDate
    End Function

    Public Function Date_TryParseEx(ByVal sValue As String, ByRef dReturn As Date) As Boolean
        'Dim mDate As Date
        If Date.TryParseExact(sValue, CS_EDIT_DATE_FORMAT, Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.AdjustToUniversal, dReturn) Then
            Return True
        Else
            If Date.TryParse(sValue, dReturn) Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Sub Date_FixString(ByRef sValue As String, Optional ByVal bShortDate As Boolean = False)
        If Not Date.TryParse(sValue, Nothing) OrElse sValue.Length > 4 Then
            sValue = sValue.Replace(" ", "/")
            sValue = sValue.Replace("-", "/")
            If sValue Like "######" Then
                sValue = sValue.Substring(0, 2) & "/" & sValue.Substring(2, 2) & "/" & sValue.Substring(4, 2)
            ElseIf sValue Like "####" Then
                sValue = sValue.Substring(0, 2) & "/" & sValue.Substring(2, 2)
                If Not bShortDate Then sValue = sValue & "/" & Today.Year
            ElseIf sValue Like "##/##" Then
                If Not bShortDate Then sValue = sValue & "/" & Today.Year
            ElseIf sValue Like "##" Then
                If Long.Parse(sValue) < 32 Then
                    sValue += "/" & Today.Month.ToString.PadLeft(2, "0")
                    If Not bShortDate Then sValue = sValue & "/" & Today.Year
                End If
            End If
        End If
    End Sub

    Public Function IsNumeric(ByVal s As String) As Boolean
        Return Microsoft.VisualBasic.Information.IsNumeric(s)
    End Function

    ''' <summary>
    ''' Convert datarowview sang object info
    ''' </summary>
    ''' <param name="objInfo">object info</param>
    ''' <param name="dr">Datarowview</param>
    ''' <remarks></remarks>
    Public Sub Object_GetDataRawView(ByVal objInfo As Object, ByVal dr As DataRowView)
        Dim objPropertyInfo As PropertyInfo
        Dim fieldName As String
        Dim objValue As Object
        '
        For i As Integer = 0 To dr.Row.Table.Columns.Count - 1
            fieldName = dr.Row.Table.Columns(i).ColumnName
            If (fieldName <> "") Then
                objPropertyInfo = Object_GetProperty(objInfo.GetType, fieldName)
                If objPropertyInfo Is Nothing Then
                    Continue For
                End If
                'Kiểu của Cell  ???
                objValue = dr.Row.Item(i)

                If Not objValue Is DBNull.Value Then
                    objValue = Object_SetValueEx(objValue, objPropertyInfo.PropertyType.Name)
                    objPropertyInfo.SetValue(objInfo, objValue, Nothing)
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objInfo"></param>
    ''' <param name="dr"></param>
    ''' <remarks></remarks>
    Public Function Object_GetDataRaw(ByVal objInfo As Object, ByVal dr As DataRow) As Object
        Dim objPropertyInfo As PropertyInfo
        Dim fieldName As String
        Dim objValue As Object = Nothing
        '
        For i As Integer = 0 To dr.Table.Columns.Count - 1
            fieldName = dr.Table.Columns(i).ColumnName
            If (fieldName <> "") Then
                objPropertyInfo = Object_GetProperty(objInfo.GetType, fieldName)
                If objPropertyInfo Is Nothing Then
                    Continue For
                End If
                'Kiểu của Cell  ???
                objValue = dr.Item(i)

                If Not objValue Is DBNull.Value Then
                    objValue = Object_SetValueEx(objValue, objPropertyInfo.PropertyType.Name)
                    Try
                        objPropertyInfo.SetValue(objInfo, objValue, Nothing)
                    Catch ex As Exception

                    End Try
                End If
            End If
        Next

        Return objInfo
    End Function
End Module


Public Module ConnectSettings
    Public SMTP_SERVER As String = ""
    Public SMTP_AUTHENTICATION As Boolean = True
    Public SMTP_PORT As String = "25"
    Public SMTP_USER As String = ""
    Public SMTP_PASS As String = ""
    Public SMTP_FORMEMAIL As String = ""
    Public TAX_THC As Boolean = False
End Module