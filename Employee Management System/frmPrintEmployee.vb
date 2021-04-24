Imports MySql.Data.MySqlClient
Imports System
Public Class frmPrintEmployee
    Dim YearLenght, MonthLength As Integer
    Dim ReportFor, Status As String
    Private Sub LoadCombobox()
        Try
            CheckConnectionState()
            SelectStore_cmb.Items.Clear()
            cmd = New MySqlCommand("select * from employee_store", con)
            DataRead = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While DataRead.Read = True
                SelectStore_cmb.Items.Add(DataRead("StoreName"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Public Sub Difference(ByVal StartDate As DateTime)
        If StartDate <> Date.Now Then
            If StartDate.Year > Date.Now.Year Then
                YearLenght = Date.Now.AddYears(-StartDate.Year).Year
            End If
            MonthLength = Date.Now.AddMonths(-StartDate.Month).Month
            If Date.Now.Month <= StartDate.Month Then
                If YearLenght > 0 Then YearLenght -= 1
            End If
        End If
    End Sub

    Private Sub LoadEmployeeStatus()
        Try
            CheckConnectionState()
            EmployeeLV.Items.Clear()
            cmd = New MySqlCommand("SELECT * FROM employee_info inner join employee_position on employee_info.position=employee_position.PositionID WHERE IsActive like '" & Status & "' and EmployeeStatus like'1' ORDER BY Lastname asc", con)
            DataRead = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim lv As New ListViewItem
            Dim lengthOfyear As String
            Dim LengthMonth As String
            While DataRead.Read = True
                With EmployeeLV

                    lengthOfyear = GetLengthOfYear(DataRead("DateStarted").ToString)
                    LengthMonth = GetLengthOfMonth(DataRead("DateStarted").ToString)

                    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    lv.SubItems.Add(DataRead("FullName").ToString)
                    lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    lv.SubItems.Add(lengthOfyear & " Year(s) and " & LengthMonth & " Month(s)")

                    'If LengthMonth <= 0 And lengthOfyear <= 0 Then
                    '    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '    lv.SubItems.Add(DataRead("FullName").ToString)
                    '    lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '    lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '    lv.SubItems.Add("LESS THAN A MONTH.")

                    'ElseIf lengthOfyear <= 0 Then
                    '    If LengthMonth = 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(LengthMonth & " MONTH.")

                    '    Else
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(LengthMonth & " MONTHS.")

                    '    End If
                    'ElseIf lengthOfyear >= 1 And LengthMonth >= 1 Then

                    '    If lengthOfyear = 1 And LengthMonth = 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEAR AND " & LengthMonth & " MONTH.")

                    '    ElseIf lengthOfyear > 1 And LengthMonth <= 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEARS AND " & LengthMonth & " MONTH.")

                    '    Else
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEARS AND " & LengthMonth & " MONTHS.")

                    '    End If
                    'End If

                End With
            End While
            CountEmployee_lbl.Text = EmployeeLV.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub
    Private Sub LoadInActiveEmployee()
        Try
            CheckConnectionState()
            EmployeeLV.Items.Clear()
            cmd = New MySqlCommand("SELECT * FROM employee_info inner join employee_position on employee_info.position=employee_position.PositionID WHERE IsActive like 'INACTIVE' and EmployeeStatus like'1' ORDER BY Lastname asc", con)
            DataRead = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim lv As New ListViewItem
            Dim lengthOfyear As String
            Dim LengthMonth As String
            While DataRead.Read = True
                With EmployeeLV

                    lengthOfyear = GetLengthOfYear(DataRead("DateStarted").ToString)
                    LengthMonth = GetLengthOfMonth(DataRead("DateStarted").ToString)

                    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    lv.SubItems.Add(DataRead("FullName").ToString)
                    lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    lv.SubItems.Add(lengthOfyear & " Year(s) and " & LengthMonth & " Month(s)")

                    'If LengthMonth <= 0 And lengthOfyear <= 0 Then
                    '    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '    lv.SubItems.Add(DataRead("FullName").ToString)
                    '    lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '    lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '    lv.SubItems.Add("LESS THAN A MONTH.")

                    'ElseIf lengthOfyear <= 0 Then
                    '    If LengthMonth = 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(LengthMonth & " MONTH.")

                    '    Else
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(LengthMonth & " MONTHS.")

                    '    End If
                    'ElseIf lengthOfyear >= 1 And LengthMonth >= 1 Then

                    '    If lengthOfyear = 1 And LengthMonth = 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEAR AND " & LengthMonth & " MONTH.")

                    '    ElseIf lengthOfyear > 1 And LengthMonth <= 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEARS AND " & LengthMonth & " MONTH.")

                    '    Else
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEARS AND " & LengthMonth & " MONTHS.")

                    '    End If
                    'End If

                End With
            End While
            CountEmployee_lbl.Text = EmployeeLV.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub SearchStore()
        Try
            CheckConnectionState()
            EmployeeLV.Items.Clear()
            cmd = New MySqlCommand("SELECT * FROM employee_info inner join employee_position on employee_info.position=employee_position.PositionID WHERE IsActive like'" & Status & "' and EmployeeStatus like'1' and store like'" & SelectStore_cmb.Text & "' ORDER BY Lastname asc", con)
            DataRead = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim lv As New ListViewItem
            Dim lengthOfyear As String
            Dim LengthMonth As String
            While DataRead.Read = True
                With EmployeeLV

                    lengthOfyear = GetLengthOfYear(DataRead("DateStarted").ToString)
                    LengthMonth = GetLengthOfMonth(DataRead("DateStarted").ToString)

                    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    lv.SubItems.Add(DataRead("FullName").ToString)
                    lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    lv.SubItems.Add(lengthOfyear & " Year(s) and " & LengthMonth & " Month(s)")


                    'If LengthMonth <= 0 And lengthOfyear <= 0 Then
                    '    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '    lv.SubItems.Add(DataRead("FullName").ToString)
                    '    lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '    lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '    lv.SubItems.Add("LESS THAN A MONTH.")

                    'ElseIf lengthOfyear <= 0 Then
                    '    If LengthMonth = 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(LengthMonth & " MONTH.")

                    '    Else
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(LengthMonth & " MONTHS.")

                    '    End If
                    'ElseIf lengthOfyear >= 1 And LengthMonth >= 1 Then

                    '    If lengthOfyear = 1 And LengthMonth = 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEAR AND " & LengthMonth & " MONTH.")

                    '    ElseIf lengthOfyear > 1 And LengthMonth <= 1 Then
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEARS AND " & LengthMonth & " MONTH.")

                    '    Else
                    '        lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    '        lv.SubItems.Add(DataRead("FullName").ToString)
                    '        lv.SubItems.Add(DataRead("EmployeePosition").ToString)
                    '        lv.SubItems.Add("₱" & FormatNumber(DataRead("EmployeeSalary")).ToString)
                    '        lv.SubItems.Add(lengthOfyear & " YEARS AND " & LengthMonth & " MONTHS.")

                    '    End If
                    'End If

                End With
            End While
            CountEmployee_lbl.Text = EmployeeLV.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        LoadEmployeeStatus()
        SelectStore_cmb.Text = ""
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Me.Dispose()
    End Sub

    Private Sub Remove_btn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Print_btn_Click(sender As Object, e As EventArgs) Handles Print_btn.Click
        If SelectStore_cmb.Text <> "" Then
            Try
                Dim dt As New DataTable
                With dt
                    .Columns.Add("NAME")
                    .Columns.Add("POSITION")
                    .Columns.Add("SALARY RATE")
                    .Columns.Add("LENGTH OF WORK")
                End With

                For Each item As ListViewItem In Me.EmployeeLV.Items
                    dt.Rows.Add(item.SubItems.Item(1).Text, item.SubItems.Item(2).Text, item.SubItems.Item(3).Text, item.SubItems.Item(4).Text)
                Next

                Dim reportDoc As New CrystalReport1
                Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
                reportDocument = New CrystalReport2
                reportDocument.SetDataSource(dt)

                reportDocument.SetParameterValue("pStoreName", SelectStore_cmb.Text)
                reportDocument.SetParameterValue("pCountEmployee", CountEmployee_lbl.Text)
                reportDocument.SetParameterValue("pStatus", ReportFor)

                frmDocument2.CrystalReportViewer1.ReportSource = reportDocument
                frmDocument2.CrystalReportViewer1.Refresh()
                frmDocument2.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        Else
            MessageBox.Show("Please Select store from combobox.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SelectStore_cmb.Focus()
        End If

    End Sub

    Private Sub FrmPrintEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombobox()
    End Sub

    Private Sub SelectStore_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SelectStore_cmb.KeyPress
        Select Case Asc(e.KeyChar)
            Case Asc("a") To Asc("z")
            Case Asc("A") To Asc("Z")
            Case Asc("0") To Asc("9")
            Case Asc(".")
            Case Asc("_")
            Case Asc("-")
            Case Asc(",")
            Case Keys.Back
            Case Keys.Left
            Case Keys.Right
            Case Keys.Up
            Case Keys.Down
            Case Keys.LControlKey
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click
        If EmployeeLV.SelectedItems.Count > 0 Then
            EmployeeLV.SelectedItems(0).Remove()
            CountEmployee_lbl.Text = EmployeeLV.Items.Count.ToString
        Else
            MessageBox.Show("Please select from the list to remove employee.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SelectStore_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectStore_cmb.SelectedIndexChanged
        SearchStore()
    End Sub

    Private Sub CheckInActive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckInActive.CheckedChanged
        If CheckInActive.Checked = True Then
            CheckActive.Checked = False
            Status = "IN-ACTIVE"
            ReportFor = "STATUS REPORT FOR IN-ACTIVE EMPLOYEES"
            LoadEmployeeStatus()
        ElseIf CheckInActive.Checked = False Then
            CheckActive.Checked = True
            Status = "ACTIVE"
            ReportFor = "STATUS REPORT FOR ACTIVE EMPLOYEES"
            LoadEmployeeStatus()
        End If
    End Sub

    Private Sub CheckActive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckActive.CheckedChanged
        If CheckActive.Checked = True Then
            CheckInActive.Checked = False
            Status = "ACTIVE"
            ReportFor = "STATUS REPORT FOR ACTIVE EMPLOYEES"
            LoadEmployeeStatus()
        ElseIf CheckActive.Checked = False Then
            CheckInActive.Checked = True
            Status = "IN-ACTIVE"
            ReportFor = "STATUS REPORT FOR IN-ACTIVE EMPLOYEES"
            LoadEmployeeStatus()
        End If
    End Sub

    Private Sub SelectStore_cmb_TextChanged(sender As Object, e As EventArgs) Handles SelectStore_cmb.TextChanged
        SearchStore()
    End Sub
End Class