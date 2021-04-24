Imports MySql.Data.MySqlClient
Public Class frmConfirm
    Private Sub OpenForm()
        Try
            con.Open()
            cmd = New MySqlCommand("Select * from user where `password`=@pass and role like'Administrator'", con)
            cmd.Parameters.AddWithValue("@Pass", PasswordTxt.Text)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                If OpenPosition = True Then
                    frmEmployeePosition.ShowDialog()
                ElseIf OpenSystemUser = True Then
                    frmUser.ShowDialog()
                End If
            End While
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

    Private Sub PasswordTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If PasswordTxt.Text = "" Then
                PasswordTxt.Focus()
            Else
                Try
                    con.Open()
                    cmd = New MySqlCommand("Select * from user where `password`=@pass and role like'Administrator'", con)
                    cmd.Parameters.AddWithValue("@Pass", PasswordTxt.Text)
                    DataRead = cmd.ExecuteReader
                    If DataRead.Read = True Then

                        If OpenPosition = True Then
                            frmEmployeePosition.ShowDialog()
                            Me.Dispose()
                        ElseIf OpenSystemUser = True Then
                            frmUser.ShowDialog()
                            Me.Dispose()
                        End If
                    Else
                        MessageBox.Show("Incorrect Password", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    DataRead.Close()
                    con.Close()
                End Try
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmConfirm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class