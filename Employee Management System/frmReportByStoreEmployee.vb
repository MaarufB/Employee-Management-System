Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class frmReportByStoreEmployee
    Dim ReportFor, Status As String
    Private Sub LoadEmployeeByStore()
        Try
            CheckConnectionState()
            EmployeeLV.Items.Clear()
            'cmd = New MySqlCommand("SELECT * FROM employee_info inner join employee_store on employee_info.Position=employee_store.StoreID WHERE StoreName like'%" & SelectStore_cmb.Text & "%' and IsActive like'ACTIVE' and EmployeeStatus like'1'", con)
            cmd = New MySqlCommand("SELECT * FROM employee_info WHERE Store like'%" & SelectStore_cmb.Text & "%' and IsActive like'" & Status & "' and EmployeeStatus like'1' ORDER BY Lastname asc", con)
            DataRead = cmd.ExecuteReader
            Dim lv As New ListViewItem
            While DataRead.Read = True
                With EmployeeLV
                    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    lv.SubItems.Add(DataRead("Fullname")).ToString()
                    lv.SubItems.Add(DataRead("Address")).ToString()
                    lv.SubItems.Add(DataRead("ContactNo")).ToString()
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

    Private Sub LoadEmployee()
        Try
            CheckConnectionState()
            EmployeeLV.Items.Clear()
            'cmd = New MySqlCommand("SELECT * FROM employee_info inner join employee_store on employee_info.Position=employee_store.StoreID WHERE IsActive like'ACTIVE' and EmployeeStatus like'1' ORDER BY StoreName desc", con)
            cmd = New MySqlCommand("SELECT * FROM employee_info WHERE IsActive like'" & Status & "' and EmployeeStatus like'1' ORDER BY Lastname asc", con)
            DataRead = cmd.ExecuteReader
            Dim lv As New ListViewItem
            While DataRead.Read = True
                With EmployeeLV
                    lv = EmployeeLV.Items.Add(DataRead("EmployeeIDNo").ToString)
                    lv.SubItems.Add(DataRead("Fullname")).ToString()
                    lv.SubItems.Add(DataRead("Address")).ToString()
                    lv.SubItems.Add(DataRead("ContactNo")).ToString()
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
        LoadEmployee()
        SelectStore_cmb.Text = ""
    End Sub

    Private Sub SelectStor_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SelectStore_cmb.KeyPress
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

    Private Sub Remove_btn_Click(sender As Object, e As EventArgs) Handles Remove_btn.Click
        If EmployeeLV.SelectedItems.Count > 0 Then
            EmployeeLV.SelectedItems(0).Remove()
            CountEmployee_lbl.Text = EmployeeLV.Items.Count.ToString
        Else
            MessageBox.Show("Please select from list to remove.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Me.Dispose()
    End Sub

    Private Sub frmReportByStoreEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCombobox()
    End Sub

    Private Sub SelectStor_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectStore_cmb.SelectedIndexChanged
        LoadEmployeeByStore()
    End Sub

    Private Sub Print_btn_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Print_btn_Click_1(sender As Object, e As EventArgs) Handles Print_btn.Click
        If SelectStore_cmb.Text <> "" Then
            Try
                Dim dt As New DataTable
                With dt
                    .Columns.Add("NAME")
                    .Columns.Add("ADDRESS")
                    .Columns.Add("CONTACT")
                End With

                For Each item As ListViewItem In Me.EmployeeLV.Items
                    dt.Rows.Add(item.SubItems.Item(1).Text, item.SubItems.Item(2).Text, item.SubItems.Item(3).Text)
                Next
                Dim reportDoc As New CrystalReport1
                Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
                reportDocument = New CrystalReport1
                reportDocument.SetDataSource(dt)
                'If SelectStore_cmb.Text = "" Then
                '    reportDocument.SetParameterValue("pStoreName", PrintFor)
                'Else
                '    reportDocument.SetParameterValue("pStoreName", SelectStore_cmb.Text)
                'End If
                reportDocument.SetParameterValue("pStoreName", SelectStore_cmb.Text)
                reportDocument.SetParameterValue("pCountEmployee", CountEmployee_lbl.Text)
                reportDocument.SetParameterValue("pStatus", Status)
                frmDocumentReport1.CrystalReportViewer1.ReportSource = reportDocument
                frmDocumentReport1.CrystalReportViewer1.Refresh()
                frmDocumentReport1.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MessageBox.Show("Select store from combobox.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SelectStore_cmb.Focus()
        End If

    End Sub

    Private Sub SelectStore_cmb_TextChanged(sender As Object, e As EventArgs) Handles SelectStore_cmb.TextChanged
        LoadEmployeeByStore()
    End Sub

    Private Sub CheckActive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckActive.CheckedChanged
        If CheckActive.Checked = True Then
            CheckInActive.Checked = False
            Status = "ACTIVE"
            ReportFor = "ACTIVE EMPLOYEES"
            LoadEmployee()
        ElseIf CheckActive.Checked = False Then
            CheckInActive.Checked = True
            Status = "IN-ACTIVE"
            ReportFor = "IN-ACTIVE EMPLOYEES"
            LoadEmployee()
        End If
    End Sub

    Private Sub CheckInActive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckInActive.CheckedChanged
        If CheckInActive.Checked = True Then
            CheckActive.Checked = False
            Status = "IN-ACTIVE"
            ReportFor = "IN-ACTIVE EMPLOYEES"
            LoadEmployee()
        ElseIf CheckInActive.Checked = False Then
            CheckActive.Checked = True
            Status = "ACTIVE"
            ReportFor = "ACTIVE EMPLOYEES"
            LoadEmployee()
        End If
    End Sub
End Class