Imports MySql.Data.MySqlClient
Public Class frmEmployee
    Private Sub LoadEmployee()
        Try
            EmployeeLV.Items.Clear()
            CheckConnectionState()
            cmd = New MySqlCommand("Select * from employee_info inner join employee_position on employee_info.Position=employee_position.PositionID where EmployeeStatus like'1' order by fullname asc", con)
            DataRead = cmd.ExecuteReader

            Dim x As ListViewItem

            While DataRead.Read = True

                x = EmployeeLV.Items.Add(DataRead("EmployeeID").ToString)
                x.SubItems.Add(DataRead("EmployeeIDNo")).ToString()
                x.SubItems.Add(DataRead("FullName")).ToString()
                x.SubItems.Add(DataRead("Gender")).ToString()
                x.SubItems.Add(DataRead("EmployeePosition")).ToString()
                x.SubItems.Add(DataRead("Store").ToString())
                x.SubItems.Add(DateTime.Parse(DataRead("DateStarted")).ToString(Format("MMM/dd/yyy")))
                x.SubItems.Add(DataRead("IsActive")).ToString()
                x.SubItems.Add(DataRead("Type")).ToString()
                x.SubItems.Add(DataRead("ContactNo")).ToString()
                x.SubItems.Add(DataRead("Address")).ToString()

            End While

            countEmployee.Text = EmployeeLV.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub


    Private Sub FilterSearch()

        Try
            EmployeeLV.Items.Clear()

            CheckConnectionState()
            cmd = New MySqlCommand("Select * from employee_info inner join employee_position on employee_info.Position=employee_position.PositionID where (FullName like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or Gender like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or Store like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or EmployeeIDNo like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or Address like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or IsActive like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or Type like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%' or Address like '%" & SearchEmployeetxt.Text.Replace("'", "") & "%') and EmployeeStatus like'1'", con)
            DataRead = cmd.ExecuteReader

            Dim x As ListViewItem

            While DataRead.Read = True

                x = EmployeeLV.Items.Add(DataRead("EmployeeID").ToString)
                x.SubItems.Add(DataRead("EmployeeIDNo")).ToString()
                x.SubItems.Add(DataRead("FullName")).ToString()
                x.SubItems.Add(DataRead("Gender")).ToString()
                x.SubItems.Add(DataRead("EmployeePosition")).ToString()
                x.SubItems.Add(DataRead("Store").ToString())
                x.SubItems.Add(DateTime.Parse(DataRead("DateStarted")).ToString(Format("MMM/dd/yyy")))
                x.SubItems.Add(DataRead("IsActive")).ToString()
                x.SubItems.Add(DataRead("Type")).ToString()
                x.SubItems.Add(DataRead("ContactNo")).ToString()
                x.SubItems.Add(DataRead("Address")).ToString()


            End While
            countEmployee.Text = EmployeeLV.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub
    Private Sub SearchEmployeetxt_TextChanged(sender As Object, e As EventArgs) Handles SearchEmployeetxt.TextChanged
        FilterSearch()
    End Sub
    Private Sub EmployeeLV_DoubleClick(sender As Object, e As EventArgs) Handles EmployeeLV.DoubleClick
        If EmployeeLV.SelectedItems.Count > 0 Then
            With EmployeeLV.SelectedItems(0)
                isUpdate = True
                PersonID = Trim(.Text)
                AddEmployeeForm.EmployeeIDNo.Text = Trim(.SubItems(1).Text).ToString
                AddEmployeeForm.Positiontxt.Text = Trim(.SubItems(4).Text).ToString
                AddEmployeeForm.ButtonAdd.Text = "&UPDATE"
                AddEmployeeForm.TitleTxt.Text = "UPDATE EMPLOYEE"
                isUpdate = True
                AddEmployeeForm.ShowDialog()
            End With
        End If
    End Sub

    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        isUpdate = False
        AddEmployeeForm.ButtonAdd.Text = "&SAVE"
        AddEmployeeForm.EmployeeIDNo.Text = ""
        AddEmployeeForm.Positiontxt.Text = ""
        AddEmployeeForm.EmployeeIDNo.Focus()
        AddEmployeeForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadEmployee()
        SearchEmployeetxt.Text = ""
        SelectReport_cmb.SelectedIndex = -1
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs)
        EmployeeLV.Items.Clear()

    End Sub

    Private Sub EmployeeLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmployeeLV.SelectedIndexChanged
        If EmployeeLV.SelectedItems.Count > 0 Then
            With EmployeeLV.SelectedItems(0)
                PersonID = Trim(.Text)
                AddEmployeeForm.EmployeeIDNo.Text = Trim(.SubItems(1).Text).ToString
                AddEmployeeForm.Positiontxt.Text = Trim(.SubItems(4).Text).ToString
            End With
        End If
    End Sub

    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(100)
        Me.Refresh()
        LoadEmployee()
        If MainForm.AdminTxt.Text = "Staff" Then
            DeleteEmployeeBtn.Enabled = False
        End If
    End Sub

    Private Sub ViewEmployeeBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        If EmployeeLV.SelectedItems.Count > 0 Then
            With EmployeeLV.SelectedItems(0)
                PersonID = Trim(.Text)
                frmPrintBiodata.ShowDialog()
            End With
        Else
            MessageBox.Show("Please select employee first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub DeleteEmployeeBtn_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If EmployeeLV.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to delete the selected employee?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    con.Open()
                    cmd = New MySqlCommand("Delete from employee_info  where EmployeeID like'" & PersonID & "'", con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully deleted.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    con.Close()
                    LoadEmployee()
                End Try
            End If
        Else
            MessageBox.Show("Please select first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub EditEmployeeBtn_Click_1(sender As Object, e As EventArgs) Handles EditEmployeeBtn.Click
        If EmployeeLV.SelectedItems.Count > 0 Then
            With EmployeeLV.SelectedItems(0)
                isUpdate = True
                PersonID = Trim(.Text)
                AddEmployeeForm.EmployeeIDNo.Text = Trim(.SubItems(1).Text).ToString
                AddEmployeeForm.Positiontxt.Text = Trim(.SubItems(4).Text).ToString
                AddEmployeeForm.ButtonAdd.Text = "&UPDATE"
                AddEmployeeForm.TitleTxt.Text = "UPDATE EMPLOYEE"
                isUpdate = True
                AddEmployeeForm.ShowDialog()
            End With
        Else
            MessageBox.Show("Please select first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SearchEmployeetxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchEmployeetxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SearchEmployeetxt.Text <> "" Then
                SelectReport_cmb.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GenerateReport_btn_Click(sender As Object, e As EventArgs) Handles GenerateReport_btn.Click
        If SelectReport_cmb.SelectedIndex = 0 Then
            frmPrintEmployee.Show()
        ElseIf SelectReport_cmb.SelectedIndex = 1 Then
            'This portion here is for generating a report for employees filtered by the store they are working in
            frmReportByStoreEmployee.Show()
        Else
            MessageBox.Show("Please select from the combo box to generate report.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SelectReport_cmb.Focus()
        End If
    End Sub

    Private Sub SelectReport_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SelectReport_cmb.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Up
            Case Keys.Down
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class