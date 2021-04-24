Imports MySql.Data.MySqlClient
Public Class frmEmployeePosition
    Dim PositionID As Integer

    Private Sub AddPosition()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Insert into employee_position(EmployeePosition, Salary, AvailablePosition) Values(@Position, @Salary, @Status)", con)
            cmd.Parameters.AddWithValue("@Position", PositionTxt.Text)
            cmd.Parameters.AddWithValue("@Salary", SalaryTxt.Text)
            cmd.Parameters.AddWithValue("@Status", "Yes")
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Position is Successfully saved.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            LoadPositionOnListview()
        End Try
    End Sub

    Private Sub UpdatePosition()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Update employee_position set `EmployeePosition`=@Position, `Salary`=@Salary Where PositionID like'" & PositionID & "'", con)
            cmd.Parameters.AddWithValue("@Position", PositionTxt.Text)
            cmd.Parameters.AddWithValue("@Salary", SalaryTxt.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Position is Successfully updated.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            LoadPositionOnListview()
            con.Close()
        End Try
    End Sub

    Private Sub DeletePosition()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Update employee_position set `AvailablePosition`=@Status Where PositionID like'" & PositionID & "'", con)
            cmd.Parameters.AddWithValue("@Status", "No")
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Position is Successfully deleted.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            LoadPositionOnListview()
            con.Close()
        End Try
    End Sub

    Private Sub LoadPositionOnListview()
        Try
            CheckConnectionState()
            PositionLV.Items.Clear()
            cmd = New MySqlCommand("Select * from Employee_position Where AvailablePosition like'Yes'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lv As ListViewItem
                With PositionLV
                    lv = .Items.Add(DataRead("PositionID"))
                    lv.SubItems.Add(DataRead("EmployeePosition"))
                    'lv.SubItems.Add(DataRead("Salary"))
                    lv.SubItems.Add(FormatNumber(DataRead("Salary"), 2, TriState.True))
                End With
            End While
            countPosition.Text = PositionLV.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub PositionTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PositionTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If PositionTxt.Text = "Type Position here..." Then
                PositionTxt.Focus()
            Else
                PositionTxt.Text = StrConv(PositionTxt.Text, vbUpperCase)
                SalaryTxt.Text = ""
                SalaryTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalaryTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SalaryTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SalaryTxt.Text = "Type Salary here..." Then
                PositionTxt.Focus()
            Else
                SaveBtn.Focus()
                e.Handled = True
            End If
        End If

        Select Case Asc(e.KeyChar)
            Case Asc("0") To Asc("9")
            Case Asc(".")
            Case Asc(",")
            Case Keys.Back
            Case Else
                e.Handled = True
        End Select
    End Sub


    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If SaveBtn.Text = "&Add" Then
            PositionTxt.Enabled = True
            PositionTxt.Text = ""
            SalaryTxt.Text = ""
            SalaryTxt.Enabled = True
            PositionTxt.Focus()
            SaveBtn.Text = "&Save"
        ElseIf SaveBtn.Text = "&Save" Then
            If PositionTxt.Text = "" Then
                MessageBox.Show("Please type Employee Position.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PositionTxt.Focus()
            ElseIf SalaryTxt.Text = "" Then
                If IsNumeric(SalaryTxt.Text) = False Then
                    SalaryTxt.Focus()
                End If
                MessageBox.Show("Please type Employee Salary.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                SalaryTxt.Focus()
            Else
                AddPosition()
                PositionTxt.Text = ""
                SalaryTxt.Text = ""
                PositionTxt.Enabled = False
                SalaryTxt.Enabled = False
                SaveBtn.Text = "&Add"
                PositionTxt.Focus()
            End If
        ElseIf SaveBtn.Text = "&Update" Then
            If PositionTxt.Text = "" Then
                MessageBox.Show("Please type Employee Position here.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PositionTxt.Focus()
            ElseIf SalaryTxt.Text = "" Then
                MessageBox.Show("Please type Employee Salary here.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                SalaryTxt.Focus()
            Else
                UpdatePosition()
                PositionTxt.Text = ""
                SalaryTxt.Text = ""
                PositionTxt.Enabled = False
                SalaryTxt.Enabled = False
                SaveBtn.Text = "&Add"
            End If
        End If
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        LoadPositionOnListview()
        Search_txt.Text = "Search here..."
    End Sub

    Private Sub Search_txt_TextChanged(sender As Object, e As EventArgs) Handles Search_txt.TextChanged
        If Search_txt.Text <> "Search here..." Then

            Try
                CheckConnectionState()
                PositionLV.Items.Clear()
                cmd = New MySqlCommand("Select * from Employee_position Where EmployeePosition like'%" & Search_txt.Text & "%' and AvailablePosition like'Yes'", con)
                DataRead = cmd.ExecuteReader
                While DataRead.Read = True
                    Dim lv As ListViewItem
                    With PositionLV
                        lv = .Items.Add(DataRead("PositionID"))
                        lv.SubItems.Add(DataRead("EmployeePosition"))
                        lv.SubItems.Add(DataRead("Salary"))
                    End With
                End While
                countPosition.Text = PositionLV.Items.Count.ToString
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                DataRead.Close()
                con.Close()
            End Try

        End If

    End Sub

    Private Sub Search_txt_LostFocus(sender As Object, e As EventArgs) Handles Search_txt.LostFocus
        Search_txt.Text = "Search here..."
        Search_txt.ForeColor = Color.DimGray
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If PositionLV.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to update Employee Position?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                PositionTxt.Enabled = True
                SalaryTxt.Enabled = True
                SaveBtn.Text = "&Update"
                PositionTxt.Focus()
            End If
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If PositionLV.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to delete the selected Employee Position?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeletePosition()
            Else
                PositionTxt.Text = "Type Position here..."
                SalaryTxt.Text = "Type Salary here..."
            End If
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        PositionTxt.Text = "Type Position here..."
        SalaryTxt.Text = "Type Salary here..."
        PositionTxt.Enabled = False
        SalaryTxt.Enabled = False
        SaveBtn.Text = "&Add"
        Me.Dispose()
    End Sub

    Private Sub PositionLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionLV.SelectedIndexChanged
        If PositionLV.SelectedItems.Count > 0 Then
            With PositionLV.SelectedItems(0)
                PositionID = .Text
                PositionTxt.Text = .SubItems(1).Text
                SalaryTxt.Text = .SubItems(2).Text
            End With
        End If
    End Sub

    Private Sub frmEmployeePosition_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MainForm.AdminTxt.Text = "Staff" Then
            DeleteBtn.Enabled = False
        End If
        LoadPositionOnListview()
    End Sub

    Private Sub Search_txt_GotFocus(sender As Object, e As EventArgs) Handles Search_txt.GotFocus
        GotFocusText(Search_txt, "Search here...")
    End Sub
End Class