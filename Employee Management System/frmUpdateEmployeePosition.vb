Imports MySql.Data.MySqlClient
Public Class frmUpdateEmployeePosition
    Dim EmployeeID, EmployeePositionID As Integer
    Private Sub BindText()
        Try
            con.Open()
            cmd = New MySqlCommand("select * from employee_info inner join employee_position on employee_info.Position=employee_position.PositionID where employeeid like'" & IDtxt.Text & "'", con)
            DataRead = cmd.ExecuteReader

            While DataRead.Read = True
                FullNameTxt.Text = DataRead("FullName")
                PositionCmb.Text = DataRead("EmployeePosition")
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub LoadPosition()
        Try
            con.Open()
            PositionCmb.Items.Clear()
            cmd = New MySqlCommand("select * from employee_position where AvailablePosition like'Yes'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                PositionCmb.Items.Add(DataRead("EmployeePosition"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub UpdateEmployeePosition()
        Try
            con.Open()
            'Set the position status to old before inserting the new position
            cmd = New MySqlCommand("update employee_history set `PositionStatus`=@status where Employee like'" & IDtxt.Text & "'", con)
            cmd.Parameters.AddWithValue("@status", "Old")
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'Update the employee info and set the position into the new or present position of the employee
            cmd = New MySqlCommand("update employee_info set `position`=@position where employeeid like '" & IDtxt.Text & "'", con)
            cmd.Parameters.AddWithValue("@position", EmployeePositionID)
            cmd.ExecuteNonQuery()

            'inserting new history record of the employee
            cmd = New MySqlCommand("Insert into employee_history(Employee, Position, Year, PositionStatus) Values(@employee, @position, @year, @status)", con)
            cmd.Parameters.AddWithValue("@employee", IDtxt.Text)
            cmd.Parameters.AddWithValue("@position", EmployeePositionID)
            cmd.Parameters.AddWithValue("@year", Date.Now.ToString("yyyy"))
            cmd.Parameters.AddWithValue("@status", "Present")
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Position Is Succefully Updated.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If MessageBox.Show("Are you sure to update the position of the selected employee?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If PositionCmb.Text = "" Then
                MessageBox.Show("Please select position from the combo box.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                UpdateEmployeePosition()
            End If
        End If
    End Sub

    Private Sub frmUpdateEmployeePosition_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindText()
        LoadPosition()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub PositionCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionCmb.SelectedIndexChanged
        Try
            con.Open()
            cmd = New MySqlCommand("select * from employee_position where EmployeePosition like'" & PositionCmb.Text & "'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                EmployeePositionID = DataRead("PositionID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub
End Class