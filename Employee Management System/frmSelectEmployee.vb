Imports MySql.Data.MySqlClient
Public Class frmSelectEmployee

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        If SearchTxt.Text <> "Search employee..." Then
            Try
                ListView1.Items.Clear()
                CheckConnectionState()
                cmd = New MySqlCommand("select * from employee_info where fullname like'%" & SearchTxt.Text.Replace("'", "") & "%' and employeestatus like'1'", con)
                DataRead = cmd.ExecuteReader
                While DataRead.Read = True
                    Dim lvv As ListViewItem
                    lvv = ListView1.Items.Add(DataRead("EmployeeID"))
                    lvv.SubItems.Add(DataRead("Fullname"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                DataRead.Close()
                con.Close()
            End Try
        End If
    End Sub

    Private Sub SearchTxt_GotFocus(sender As Object, e As EventArgs) Handles SearchTxt.GotFocus
        SearchTxt.Text = ""
        SearchTxt.ForeColor = Color.Black
    End Sub

    Private Sub SearchTxt_LostFocus(sender As Object, e As EventArgs) Handles SearchTxt.LostFocus
        SearchTxt.Text = "Search employee..."
        SearchTxt.ForeColor = Color.DimGray
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            With ListView1.SelectedItems(0)
                PersonID = .Text
                frmAddFile.EmployeeCmb.Text = .SubItems(1).Text
                Me.Close()
            End With
        End If
    End Sub

    Private Sub frmSelectEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ListView1.Items.Clear()
            CheckConnectionState()
            cmd = New MySqlCommand("select * from employee_info where employeestatus like'1'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lvv As ListViewItem
                lvv = ListView1.Items.Add(DataRead("EmployeeID"))
                lvv.SubItems.Add(DataRead("Fullname"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class