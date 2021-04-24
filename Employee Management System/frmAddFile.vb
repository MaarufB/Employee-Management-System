Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Public Class frmAddFile

    Dim _FilePathName As String
    Dim _DirPathName As String
    Dim _FileName As String
    Dim _FileID As String

    Private Sub _SaveFileToDB(_filePath As String)
        Try
            Dim _file As Byte()
            Dim _stream As New FileStream(_filePath, FileMode.Open, FileAccess.Read)
            Dim _reader As New BinaryReader(_stream)
            _file = _reader.ReadBytes(Convert.ToInt32(_stream.Length))

            con.Open()
            cmd = New MySqlCommand("Insert into employee_file(Employee, FileName, File, FilePath, Description, FileStatus) Values(@Employee, @FileName, @File, @FilePath, @Description, @status)", con)
            cmd.Parameters.AddWithValue("@Employee", PersonID)
            cmd.Parameters.AddWithValue("@FileName", _FileName)
            cmd.Parameters.Add("@File", MySqlDbType.VarBinary).Value = _file.ToArray()
            cmd.Parameters.AddWithValue("@FilePath", FilePathTxt.Text)
            cmd.Parameters.AddWithValue("@Description", FileDescriptionTxt.Text)
            cmd.Parameters.AddWithValue("@status", "1")
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully added.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub _updateFileToDB(_filePath As String)
        Dim _file As Byte()
        Dim _stream As New FileStream(_filePath, FileMode.Open, FileAccess.Read)
        Dim _reader As New BinaryReader(_stream)
        _file = _reader.ReadBytes(Convert.ToInt32(_stream.Length))

        con.Open()
        cmd = New MySqlCommand("Update employee_file set `FileName` = @FileName, `File`=@File, `FilePath` = @FilePath, `Description` = @Description Where FileID like", con)
        cmd.Parameters.AddWithValue("@FileName", _FileName)
        cmd.Parameters.Add("@File", MySqlDbType.VarBinary).Value = _file.ToArray()
    End Sub
    Private Sub LoadEmployee()
        Try
            con.Open()
            EmployeeCmb.Items.Clear()
            cmd = New MySqlCommand("Select * from employee_info", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                EmployeeCmb.Items.Add(DataRead("FirstName") & " " & DataRead("LastName") & " " & DataRead("MiddleName"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If SaveBtn.Text = "&Save" Then
            If EmployeeCmb.Text = "" Then
                MessageBox.Show("Please select Employee.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf FileNameTxt.Text = "" Then
                MessageBox.Show("Please click the browse link to find the file.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                linkBrowse.Focus()
            ElseIf FilePathTxt.Text = "" Then
                MessageBox.Show("Please click the browse link to find the file.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf FileDescriptionTxt.Text = "" Then
                MessageBox.Show("Please type the file description.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FileDescriptionTxt.Focus()
            Else
                _SaveFileToDB(FilePathTxt.Text)
                frmEmployeeFile.Load_btn.PerformClick()
                Me.Close()
            End If
        ElseIf SaveBtn.Text = "&Update" Then
            If EmployeeCmb.SelectedIndex = -1 Then
                MessageBox.Show("Please select Employee.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf FileNameTxt.Text = "" Then
                MessageBox.Show("Please click the browse link to find the file.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                linkBrowse.Focus()
            ElseIf FilePathTxt.Text = "" Then
                MessageBox.Show("Please click the browse link to find the file.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf FileDescriptionTxt.Text = "" Then
                MessageBox.Show("Please type the file description.", "Employee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FileDescriptionTxt.Focus()
            Else
                _SaveFileToDB(FilePathTxt.Text)
            End If
        End If
    End Sub

    Private Sub EmployeeCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmployeeCmb.SelectedIndexChanged
        con.Open()
        cmd = New MySqlCommand("Select * from employee_info where FullName like'" & EmployeeCmb.Text & "'", con)
        DataRead = cmd.ExecuteReader
        While DataRead.Read = True
            PersonID = DataRead("EmployeeID")
        End While
        DataRead.Close()
        con.Close()
    End Sub

    Private Sub frmAddFile_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadEmployee()
    End Sub

    Private Sub LinkEmployee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBrowse.LinkClicked
        Dim _OFD As New OpenFileDialog
        If _OFD.ShowDialog() = DialogResult.OK Then
            _FilePathName = _OFD.FileName
            FilePathTxt.Text = _FilePathName
            _FileName = Path.GetFileName(_FilePathName)
            FileNameTxt.Text = _FileName
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        EmployeeCmb.Text = ""
        FileNameTxt.Text = ""
        FilePathTxt.Text = ""
        FileDescriptionTxt.Text = ""
        Me.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSelectEmployee.ShowDialog()
    End Sub

    Private Sub FileDescriptionTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FileDescriptionTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FileDescriptionTxt.Text <> "" Then
                FileDescriptionTxt.Text = StrConv(FileDescriptionTxt.Text, vbUpperCase)
                SaveBtn_Click(sender, e)
                e.Handled = True
            Else
                FileDescriptionTxt.Focus()
            End If
        End If
    End Sub

End Class