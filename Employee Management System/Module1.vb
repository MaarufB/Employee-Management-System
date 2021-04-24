Imports MySql.Data.MySqlClient

Module Module1

    'Private conn As New MySqlConnection("server=localhost; user=root; password=mazzarif; database=emloyeedb")
    Public con As New MySqlConnection("server=localhost; user=root; password=mazzarif; database=employeedatabase")

    'Public con As New MySqlConnection("server=192.168.88.71; user=root; password=mazzarif; database=employeedatabase")
    Public cmd As MySqlCommand
    Public DataRead As MySqlDataReader
    Public DataAdapter As MySqlDataAdapter
    Public dataTable As DataTable

    Public PersonID As Integer
    Public UserID As Integer
    Public sysmessage As String = "EMPLOYEE MANAGEMENT SYSTEM"


    Private Function Connect() As MySqlConnection
        Return New MySqlConnection("server=localhost; user=root; password=mazzarif; database=employeedatabase")
    End Function

    Public Sub ConnectDB()
        Try
            With con
                If .State = ConnectionState.Open Then
                    .Close()
                    .Open()
                    Connect()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public MyServer As String
    Public MyPort As String
    Public MyUserName As String
    Public MyPassword As String
    Public MyDatabaseName As String

    Sub getData()
        Dim AppName As String = Application.ProductName

        Try
            MyDatabaseName = GetSetting(AppName, "DBSection", "DB_Name", "temp")
            MyServer = MyDatabaseName = GetSetting(AppName, "DBSection", "DB_IP", "temp")
            MyPort = GetSetting(AppName, "DBSection", "DB_Port", "temp")
            MyUserName = GetSetting(AppName, "DBSection", "DB_User", "temp")
            MyPassword = GetSetting(AppName, "DBSection", "DB_Password", "temp")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub connDB()
        Try
            With con
                If .State = ConnectionState.Open Then
                    .Close()

                    .ConnectionString = "Server = '" & MyServer & "'; " _
                                      & "Port = '" & MyPort & "'; " _
                                      & "Database = '" & MyDatabaseName & "'; " _
                                      & "user id = '" & MyUserName & "'; " _
                                      & "Password = '" & MyPassword & "'"
                    .Open()
                End If
                MessageBox.Show("sUCCES")
            End With

        Catch ex As Exception
            MessageBox.Show("Failed")
        End Try

    End Sub
    Sub SaveData()
        Dim AppName As String = Application.ProductName

        SaveSetting(AppName, "DBSection", "DB_Name", MyDatabaseName)
        SaveSetting(AppName, "DBSection", "DB_IP", MyServer)
        SaveSetting(AppName, "DBSection", "DB_Port", MyPort)
        SaveSetting(AppName, "DBSection", "DB_User", MyUserName)
        SaveSetting(AppName, "DBSection", "DB_Password", MyPassword)

        MessageBox.Show("", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Module
