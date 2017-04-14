Imports System
Imports log4net

Public Class Log

#Region "ENUM declaration"
    ''' <summary>
    ''' Log level for writing file
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LogLevel
        INFO    ' Log information such as start/stop app/form
        DEBUG   ' Log for debug applicate
        WARN    ' Log for any warning message to user
        ERR     ' Log error occur when execute application, such as lost db connection
        FATAL   ' Log for un-catched exceptions,
    End Enum
#End Region

#Region "Class variables"
    ' Declare log object
    Private Shared ReadOnly logger As ILog = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

#End Region

#Region "File logging methods"
    ''' <summary>
    ''' Method write log object to file
    ''' </summary>
    ''' <param name="logLevel">Level of logging</param>
    ''' <param name="objEx">Object to write</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteLog(ByVal logLevel As LogLevel, ByVal objEx As Object)
        '' Config log4net using application configuration
        'log4net.Config.XmlConfigurator.Configure()

        ' Check write log object
        If objEx Is Nothing Then
            ' Write log about null parameter to file
            WriteLog(logLevel, "Write log parameter: Exception object, is null.")
        Else
            ' Write log file
            WriteLog(logLevel, objEx.ToString())
        End If

    End Sub

    ''' <summary>
    ''' Method write log message to file
    ''' </summary>
    ''' <param name="logLevel">Level of logging</param>
    ''' <param name="logMessage">Message string to write</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteLog(ByVal logLevel As LogLevel, ByVal logMessage As String)
        ' Check log type
        Select Case logLevel
            Case logLevel.DEBUG
                logger.Debug(logMessage)

            Case logLevel.ERR
                logger.Error(logMessage)

            Case logLevel.FATAL
                logger.Fatal(logMessage)

            Case logLevel.INFO
                logger.Info(logMessage)

            Case logLevel.WARN
                logger.Warn(logMessage)
        End Select
    End Sub
#End Region

End Class
