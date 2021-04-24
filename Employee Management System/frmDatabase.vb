Public Class frmDatabase

    Private TestServer, TestPort, TestUsername, TestPassword, TestDatabaseName As String

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

    Private Sub FrmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hosttxt.Text = TestServer
        Porttxt.Text = TestPort
        Usernametxt.Text = TestUsername
        Passwordtxt.Text = TestPassword
        Databasetxt.Text = TestDatabaseName
        getData()
    End Sub

    Private Sub Test_btn_Click(sender As Object, e As EventArgs) Handles Test_btn.Click
        With con
            If .State = ConnectionState.Open Then
                .Close()
                .Open()
            End If

        End With
        TestServer = Hosttxt.Text
        TestPort = Porttxt.Text
        TestUsername = Usernametxt.Text
        TestPassword = Passwordtxt.Text
        TestDatabaseName = Databasetxt.Text

        Try
            con.ConnectionString = "Server = '" & TestServer & "'; " _
                                 & "Port = '" & TestPort & "'; " _
                                 & "Database = '" & TestDatabaseName & "'; " _
                                 & "User id = '" & TestUsername & "'; " _
                                 & "Password = '" & TestPassword & "'; "

            con.Open()
            MessageBox.Show("Successfully Connected to the database.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Sytem failed to connect to the database.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class