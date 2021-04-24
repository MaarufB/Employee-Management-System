Imports MySql.Data.MySqlClient
Public Class frmEmploymentHistory
    Dim Remark As String
    Private Sub EnableTextboxes(ByVal isTrue As Boolean)
        Dim textB As Control() = {YearStart_dtp, YearEnd_dtp, Remark_cmb, CompanyCmd, Position_txt, WorkDescription_txt}
        If isTrue = True Then
            For Each txtB In textB
                With txtB
                    .Enabled = True
                    .Text = ""
                End With
            Next
        ElseIf isTrue = False Then

            For Each txtB In textB
                With txtB
                    .Enabled = False
                    .Text = ""
                End With
            Next
        End If

    End Sub


    Private Sub LoadHistory()
        Try
            Dim myDate As String = Date.Now.ToString(Format("MM/dd/yyyy"))
            CheckConnectionState()
            cmd = New MySqlCommand("Select * from employee_history where HistoryID like'" & HistoryID & "'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim AlterDate As String
                If DataRead("DateTo") = "PRESENT" Then
                    AlterDate = Date.Now.ToString
                Else
                    AlterDate = DataRead("DateTo").ToString
                End If
                YearStart_dtp.Text = DataRead("DateFrom").ToString
                YearEnd_dtp.Text = AlterDate
                Remark_cmb.Text = DataRead("Remark").ToString
                Position_txt.Text = DataRead("Position").ToString
                CompanyCmd.Text = DataRead("Company").ToString
                WorkDescription_txt.Text = DataRead("WorkDescription").ToString
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub
    Private Sub LoadComboBox()
        Try
            CheckConnectionState()
            CompanyCmd.Items.Clear()
            cmd = New MySqlCommand("Select * from employee_store", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                CompanyCmd.Items.Add(DataRead("StoreName"))
            End While

            DataRead.Close()

            Position_txt.Items.Clear()
            cmd = New MySqlCommand("Select * from employee_position", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Position_txt.Items.Add(DataRead("EmployeePosition"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub AddHistory()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("insert into employee_history(Employee, Position, DateFrom, DateTo, Company, WorkDescription, Remark) " _
                                                         & "values(@Employee, @Position, @From, @To, @Company, @WorkDescription, @Remark)", con)

            cmd.Parameters.AddWithValue("@Employee", EmployeeId_txt.Text)
            cmd.Parameters.AddWithValue("@Position", Position_txt.Text)
            cmd.Parameters.AddWithValue("@From", YearStart_dtp.Value.ToString(Format("MM/dd/yyyy")))
            cmd.Parameters.AddWithValue("@To", Remark)
            cmd.Parameters.AddWithValue("@Company", CompanyCmd.Text)
            cmd.Parameters.AddWithValue("@WorkDescription", WorkDescription_txt.Text)
            cmd.Parameters.AddWithValue("@Remark", Remark_cmb.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee history is successfully saved to the database.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub UpdateHistory()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Update employee_history set `Position`=@Position, `DateFrom`=@From, `DateTo`=@To, `Company`=@Company, `WorkDescription`=@WorkDescription, `Remark`=@Remark where HistoryID like'" & HistoryID & "'", con)
            cmd.Parameters.AddWithValue("@Position", Position_txt.Text)
            cmd.Parameters.AddWithValue("@From", YearStart_dtp.Value.ToString(Format("MM/dd/yyyy")))
            cmd.Parameters.AddWithValue("@To", Remark)
            cmd.Parameters.AddWithValue("@Company", CompanyCmd.Text)
            cmd.Parameters.AddWithValue("@WorkDescription", WorkDescription_txt.Text)
            cmd.Parameters.AddWithValue("@Remark", Remark_cmb.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employment history is successfully updated.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If AddBtn.Text = "&ADD" Then
            EnableTextboxes(True)
            LoadComboBox()
            AddBtn.Text = "&SAVE"
            EmployeeId_txt.Focus()
        ElseIf AddBtn.Text = "&SAVE" Then
            If EmployeeId_txt.Text = "" Then
                EmployeeId_txt.Focus()
                EmployeeId_txt.Enabled = True
            ElseIf Remark_cmb.Text = "" Then
                Remark_cmb.Focus()
            ElseIf CompanyCmd.Text = "" Then
                CompanyCmd.Focus()
            ElseIf Position_txt.Text = "" Then
                Position_txt.Focus()
            ElseIf WorkDescription_txt.Text = "" Then
                WorkDescription_txt.Text = "N/A"
                WorkDescription_txt.Focus()
            Else
                AddHistory()
                EnableTextboxes(False)
                AddBtn.Text = "&ADD"
                AddEmployeeForm.LoadEmploymentHistory()
                Me.Dispose()
            End If
        ElseIf AddBtn.Text = "&EDIT" Then
            YearStart_dtp.Focus()
            AddBtn.Text = "&UPDATE"
        ElseIf AddBtn.Text = "&UPDATE" Then
            If EmployeeId_txt.Text = "" Then
                EmployeeId_txt.Focus()
                EmployeeId_txt.Enabled = True
            ElseIf Remark_cmb.Text = "" Then
                Remark_cmb.Focus()
            ElseIf CompanyCmd.Text = "" Then
                CompanyCmd.Focus()
            ElseIf Position_txt.Text = "" Then
                Position_txt.Focus()
            ElseIf WorkDescription_txt.Text = "" Then
                WorkDescription_txt.Text = "N/A"
                WorkDescription_txt.Focus()
            Else
                UpdateHistory()
                AddBtn.Text = "&ADD"
                AddEmployeeForm.LoadEmploymentHistory()
                Me.Dispose()
            End If
        ElseIf AddBtn.Text = "&DELETE" Then
            If MessageBox.Show("Are you sure to delete this employment history?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeleteHistory()
                AddEmployeeForm.LoadEmploymentHistory()
                AddBtn.Text = "&ADD"
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub DeleteHistory()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Delete from employee_history where HistoryID like'" & HistoryID & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully deleted.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub WorkDescription_txt_TextChanged(sender As Object, e As EventArgs) Handles WorkDescription_txt.TextChanged
        Dim max As Integer = 250
        MaxText_lbl.Text = (Val(max) - Val(WorkDescription_txt.Text.Length))
        If MaxText_lbl.Text = 0 Then
            MaxText_lbl.ForeColor = Color.Red
        Else
            MaxText_lbl.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Remark_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Remark_cmb.SelectedIndexChanged
        If Remark_cmb.Text = "PRESENT" Then
            Remark = "PRESENT"
        ElseIf Remark_cmb.Text = "PAST" Then
            Remark = YearEnd_dtp.Value.ToString((Format("MM/dd/yyyy")))
        End If
    End Sub

    Private Sub Remark_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Remark_cmb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Remark_cmb.Text = "" Then
                Remark_cmb.Focus()
            Else
                Remark_cmb.Text = StrConv(Remark_cmb.Text, vbUpperCase)
                CompanyCmd.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CompanyCmd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompanyCmd.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If CompanyCmd.Text = "" Then
                CompanyCmd.Focus()
            Else
                CompanyCmd.Text = StrConv(CompanyCmd.Text, vbUpperCase)
                Position_txt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Position_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Position_txt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Position_txt.Text = "" Then
                Position_txt.Focus()
            Else
                Position_txt.Text = StrConv(Position_txt.Text, vbUpperCase)
                WorkDescription_txt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub WorkDescription_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WorkDescription_txt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If WorkDescription_txt.Text = "" Then
                WorkDescription_txt.Focus()
            Else
                WorkDescription_txt.Text = StrConv(WorkDescription_txt.Text, vbUpperCase)
                AddBtn.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EmployeeId_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeId_txt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If EmployeeId_txt.Text = "" Then
                MessageBox.Show("Please input the Employee ID.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeId_txt.Focus()
            Else
                Remark_cmb.Text = "PAST"
                Remark_cmb.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FrmEmploymentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AddBtn.Text = "&SAVE" Then
            LoadComboBox()
            AddBtn.Text = "&SAVE"
            EmployeeId_txt.Focus()
        ElseIf AddBtn.Text = "&EDIT" Then
            LoadComboBox()
            LoadHistory()
        ElseIf AddBtn.Text = "&UPDATE" Then
            LoadComboBox()
            LoadHistory()
        ElseIf AddBtn.Text = "&DELETE" Then
            LoadHistory()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        EnableTextboxes(False)
        EmployeeId_txt.Text = ""
        EmployeeId_txt.Enabled = False
        AddBtn.Text = "&ADD"
        Me.Dispose()
    End Sub
End Class