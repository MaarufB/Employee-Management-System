Imports MySql.Data.MySqlClient
Public Class frmUser
    Dim userID As Integer
    Private Sub DisplayUsers()
        Try
            UserList.Items.Clear()
            CheckConnectionState()
            cmd = New MySqlCommand("Select * from user where userstatus like'1'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lv As New ListViewItem
                lv = UserList.Items.Add(DataRead("UserID"))
                lv.SubItems.Add(DataRead("Lastname"))
                lv.SubItems.Add(DataRead("Firstname"))
                lv.SubItems.Add(DataRead("Middlename"))
                lv.SubItems.Add(DataRead("Username"))
            End While
            countUser.Text = UserList.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub
    Private Sub AddUser()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Insert into user(FirstName, LastName, MiddleName, UserName, Password, Role, UserStatus) Values(@First, @Last, @Middle, @User, @Pass, @Role, @Status)", con)
            cmd.Parameters.AddWithValue("@First", FirstnameTxt.Text)
            cmd.Parameters.AddWithValue("@Last", LastnameTxt.Text)
            cmd.Parameters.AddWithValue("@Middle", MiddleName.Text)
            cmd.Parameters.AddWithValue("@User", UsernameTxt.Text)
            cmd.Parameters.AddWithValue("@Pass", PasswordTxt.Text)
            cmd.Parameters.AddWithValue("@Role", RoleCmb.Text)
            cmd.Parameters.AddWithValue("@Status", "1")
            cmd.ExecuteNonQuery()

            MessageBox.Show("System User Is Successfully added.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateUser()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Update user set `FirstName`=@First, `LastName`=@Last, `MiddleName`=@Middle, `UserName`=@User, `Password`=@Pass, `Role`=@Role  Where UserID like'" & userID & "'", con)
            cmd.Parameters.AddWithValue("@First", FirstnameTxt.Text)
            cmd.Parameters.AddWithValue("@Last", LastnameTxt.Text)
            cmd.Parameters.AddWithValue("@Middle", MiddleName.Text)
            cmd.Parameters.AddWithValue("@User", UsernameTxt.Text)
            cmd.Parameters.AddWithValue("@Pass", PasswordTxt.Text)
            cmd.Parameters.AddWithValue("@Role", RoleCmb.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("System User Is Successfully updated.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub CallTextboxes(ByVal enable As Boolean, ByVal clear As Boolean)
        If enable = True Then
            FirstnameTxt.Enabled = True
            LastnameTxt.Enabled = True
            MiddleName.Enabled = True
            UsernameTxt.Enabled = True
            PasswordTxt.Enabled = True
            RoleCmb.Enabled = True
        ElseIf enable = False Then
            FirstnameTxt.Enabled = False
            LastnameTxt.Enabled = False
            MiddleName.Enabled = False
            UsernameTxt.Enabled = False
            PasswordTxt.Enabled = False
            RoleCmb.Enabled = False
        End If
        If clear = True Then
            FirstnameTxt.Text = ""
            LastnameTxt.Text = ""
            MiddleName.Text = ""
            UsernameTxt.Text = ""
            PasswordTxt.Text = ""
            RoleCmb.Text = ""
        End If

    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If SaveBtn.Text = "&ADD" Then
            CallTextboxes(True, True)
            LastnameTxt.Focus()
            SaveBtn.Text = "&SAVE"
        ElseIf SaveBtn.Text = "&SAVE" Then

            If FirstnameTxt.Text = "" Then
                FirstnameTxt.Focus()
            ElseIf LastnameTxt.Text = "" Then
                LastnameTxt.Focus()
            ElseIf MiddleName.Text = "" Then
                MiddleName.Focus()
            ElseIf UsernameTxt.Text = "" Then
                UsernameTxt.Focus()
            ElseIf PasswordTxt.Text = "" Then
                PasswordTxt.Focus()
            Else
                AddUser()
                DisplayUsers()
                CallTextboxes(False, True)
                SaveBtn.Text = "&ADD"
            End If

        ElseIf SaveBtn.Text = "&UPDATE" Then
            If FirstnameTxt.Text = "" Then
                FirstnameTxt.Focus()
            ElseIf LastnameTxt.Text = "" Then
                LastnameTxt.Focus()
            ElseIf MiddleName.Text = "" Then
                MiddleName.Focus()
            ElseIf UsernameTxt.Text = "" Then
                UsernameTxt.Focus()
            ElseIf PasswordTxt.Text = "" Then
                PasswordTxt.Focus()
            Else
                UpdateUser()
                DisplayUsers()
                CallTextboxes(False, True)
                SaveBtn.Text = "&ADD"
            End If

        End If
    End Sub

    Private Sub FirstnameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstnameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FirstnameTxt.Text = "" Then
                FirstnameTxt.Focus()
            Else
                FirstnameTxt.Text = StrConv(FirstnameTxt.Text, vbUpperCase)
                MiddleName.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LastnameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastnameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If LastnameTxt.Text = "" Then
                LastnameTxt.Focus()
            Else
                LastnameTxt.Text = StrConv(LastnameTxt.Text, vbUpperCase)
                FirstnameTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiddleName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MiddleName.Text = "" Then
                MiddleName.Focus()
            Else
                MiddleName.Text = StrConv(MiddleName.Text, vbUpperCase)
                UsernameTxt.Focus()
                e.Handled = True
            End If
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
                RoleCmb.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        DisplayUsers()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs)
        UserList.Items.Clear()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        frmEmployee.Close()
        frmEmployeeFile.Close()
        Me.Close()
        frmEmployee.TopLevel = False
        MainForm.Panel4.Controls.Add(frmEmployee)
        frmEmployee.Show()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If UserList.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to update the selected system user?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CallTextboxes(True, False)
                SaveBtn.Text = "&UPDATE"
            End If
        End If
    End Sub

    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserList.SelectedIndexChanged
        If UserList.SelectedItems.Count > 0 Then
            With UserList.SelectedItems(0)
                userID = .Text
                LastnameTxt.Text = .SubItems(1).Text
                FirstnameTxt.Text = .SubItems(2).Text
                MiddleName.Text = .SubItems(3).Text
                UsernameTxt.Text = .SubItems(4).Text
            End With

            Try
                CheckConnectionState()
                cmd = New MySqlCommand("Select * from user where UserID like '" & userID & "'", con)
                DataRead = cmd.ExecuteReader
                While DataRead.Read = True
                    PasswordTxt.Text = DataRead("Password")
                    RoleCmb.Text = DataRead("Role")
                End While

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()
                DataRead.Close()
            End Try
        End If
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MainForm.AdminTxt.Text = "Staff" Then
            DeleteBtn.Enabled = False
            CheckBox1.Visible = False
        End If
        CallTextboxes(False, True)
        DisplayUsers()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        CallTextboxes(False, True)
        SaveBtn.Text = "&ADD"
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If UserList.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to update the selected system user?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    CheckConnectionState()
                    cmd = New MySqlCommand("Update user set `UserStatus`=@status where UserID like'" & userID & "'", con)
                    cmd.Parameters.AddWithValue("@status", "0")
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Selected system user is successfully deleted.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    con.Close()
                    DataRead.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTxt.UseSystemPasswordChar = False
        Else
            PasswordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub RoleCmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RoleCmb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If RoleCmb.Text = "" Then
                RoleCmb.Focus()
            Else
                RoleCmb.Focus()
                e.Handled = True
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub SearchEmployeetxt_TextChanged(sender As Object, e As EventArgs) Handles SearchEmployeetxt.TextChanged
        If SearchEmployeetxt.Text <> "Type here to search..." Then
            Try
                UserList.Items.Clear()
                CheckConnectionState()
                cmd = New MySqlCommand("Select * from user where (lastname like'%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or firstname like'%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or middlename like'%" & SearchEmployeetxt.Text.Replace("'", "") & "%') and userstatus like'1'", con)
                DataRead = cmd.ExecuteReader
                While DataRead.Read = True
                    Dim lv As New ListViewItem
                    lv = UserList.Items.Add(DataRead("UserID"))
                    lv.SubItems.Add(DataRead("Lastname"))
                    lv.SubItems.Add(DataRead("Firstname"))
                    lv.SubItems.Add(DataRead("Middlename"))
                    lv.SubItems.Add(DataRead("Username"))
                End While
                countUser.Text = UserList.Items.Count.ToString
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                DataRead.Close()
                con.Close()
            End Try
        End If
    End Sub

    Private Sub SearchEmployeetxt_GotFocus(sender As Object, e As EventArgs) Handles SearchEmployeetxt.GotFocus
        SearchEmployeetxt.Text = ""
        SearchEmployeetxt.ForeColor = Color.Black
    End Sub

    Private Sub SearchEmployeetxt_LostFocus(sender As Object, e As EventArgs) Handles SearchEmployeetxt.LostFocus
        SearchEmployeetxt.Text = "Type here to search..."
        SearchEmployeetxt.ForeColor = Color.DimGray
    End Sub

    Private Sub RoleCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleCmb.SelectedIndexChanged

    End Sub
End Class