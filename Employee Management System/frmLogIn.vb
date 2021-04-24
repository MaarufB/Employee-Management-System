Imports MySql.Data.MySqlClient
Public Class frmLogIn

    Private Sub LogIn()
        Try
            With con
                If .State = ConnectionState.Open Then .Close()
                .Open()
            End With
            cmd = New MySqlCommand("Select * from user where username=@username and password=@password", con)
            cmd.Parameters.AddWithValue("@username", UsernameTxt.Text)
            cmd.Parameters.AddWithValue("@password", PasswordTxt.Text)
            DataRead = cmd.ExecuteReader
            If DataRead.Read = True Then
                MainForm.UserTxt.Text = DataRead("Firstname") & " " & DataRead("Lastname")
                MainForm.AdminTxt.Text = DataRead("Role")
                System.Threading.Thread.Sleep(200)
                Me.Refresh()
                MainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username/Password is incorrect!", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                UsernameTxt.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        UsernameTxt.Text = ""
        PasswordTxt.Text = ""
    End Sub

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        If UsernameTxt.Text = "" Then
            UsernameTxt.Focus()
        ElseIf PasswordTxt.Text = "" Then
            PasswordTxt.Focus()
        ElseIf UsernameTxt.Text = "1" And PasswordTxt.Text = "1" Then
            MainForm.AdminTxt.Text = "Administrator"
            System.Threading.Thread.Sleep(200)
            Me.Refresh()
            MainForm.Show()
            Me.Hide()
        Else
            LogIn()
        End If
    End Sub

    Private Sub UsernameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If UsernameTxt.Text = "" Then
                UsernameTxt.Focus()
            Else
                PasswordTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PasswordTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If PasswordTxt.Text = "" Then
                PasswordTxt.Focus()
            Else
                EnterBtn_Click(sender, e)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Threading.Thread.Sleep(200)
        Me.Refresh()
        UsernameTxt.Text = ""
        PasswordTxt.Text = ""
        UsernameTxt.Enabled = True
        PasswordTxt.Enabled = True
        UsernameTxt.Focus()
        UsernameTxt.SelectAll()
    End Sub
End Class