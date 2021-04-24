Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports System.Linq
Imports System.Data

Public Class frmEmployeeFile

    Dim _FilePathName As String
    Dim _DirPathName As String
    Dim _FileName As String
    Dim _FileID As String

    Private Sub _SaveFileToDB(_filePath As String)
        Dim _file As Byte()
        Dim _stream As New FileStream(_filePath, FileMode.Open, FileAccess.Read)
        Dim _reader As New BinaryReader(_stream)
        _file = _reader.ReadBytes(Convert.ToInt32(_stream.Length))

        CheckConnectionState()
        cmd = New MySqlCommand("Insert into tbl_files(FileName, File, Description, FilePath) Values(@FileName, @File, @Description, @FilePath)", con)
        cmd.Parameters.Add("@FileName", MySqlDbType.VarChar).Value = _FileName
        cmd.Parameters.Add("@File", MySqlDbType.VarBinary).Value = _file.ToArray()
        cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = "Testing File"
        cmd.Parameters.Add("@FilePath", MySqlDbType.VarChar).Value = _FilePathName
        cmd.ExecuteNonQuery()
        MessageBox.Show("Successfully added.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()


        _LoadFile()
    End Sub

    Private Sub _CopyFiles(_NewFileLocation As String)
        Try
            CheckConnectionState()
            _NewFileLocation = _DirPathName

            Dim _id As Integer = Convert.ToInt32(FileLV.SelectedItems(0).Text.ToString())
            cmd = New MySqlCommand("Select * from employee_file where FileID=@ID", con)
            cmd.Parameters.AddWithValue("@ID", _id)
            DataRead = cmd.ExecuteReader

            While DataRead.Read = True
                Dim _filebyte As Byte() = DataRead("File")
                Dim _fs As New FileStream(_NewFileLocation & "\" & DataRead("FileName"), FileMode.Create, FileAccess.Write)
                _fs.Write(_filebyte, 0, _filebyte.Length)
                _fs.Close()
            End While

            MessageBox.Show("File Copied Successfully.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub _CopyFiles2(_NewFileLocation As String)
        Try
            _NewFileLocation = _DirPathName

            Dim _id As Integer = Convert.ToInt32(FileLV.SelectedItems(0).Text.ToString())
            cmd = New MySqlCommand("Select * from employee_files where FileID=@ID", con)
            cmd.Parameters.AddWithValue("@ID", _id)
            DataAdapter = New MySqlDataAdapter(cmd)
            dataTable = New DataTable("tbl_files")
            dataTable.Clear()
            DataAdapter.Fill(dataTable)
            For Each row As DataRow In dataTable.Rows
                Dim _filebyte As Byte() = row(2)
                Dim _fs As New FileStream(_NewFileLocation & "\" & row(1), FileMode.Create, FileAccess.Write)
                _fs.Write(_filebyte, 0, _filebyte.Length)
                _fs.Close()
            Next

            MessageBox.Show("File Copied Successfully.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub _LoadFile()
        Try
            FileLV.Items.Clear()
            CheckConnectionState()
            cmd = New MySqlCommand("Select FullName, FileID, FileName, FilePath, Description From employee_file, employee_info where employee_file.employee=employee_info.EmployeeID and FileStatus like'1'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lv As ListViewItem
                lv = FileLV.Items.Add(DataRead("FileID").ToString)
                lv.SubItems.Add(DataRead("FullName").ToString)
                lv.SubItems.Add(DataRead("FileName").ToString)
                lv.SubItems.Add(DataRead("Description").ToString)
            End While
            countFile.Text = FileLV.Items.Count.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        frmAddFile.ShowDialog()
    End Sub

    Private Sub Copy_btn_Click(sender As Object, e As EventArgs) Handles Copy_btn.Click
        If FileLV.SelectedItems.Count > 0 Then
            Dim FBD As New FolderBrowserDialog
            If FBD.ShowDialog() = DialogResult.OK Then
                _DirPathName = FBD.SelectedPath
                Try
                    CheckConnectionState()
                    cmd = New MySqlCommand("Update employee_file set `FilePath` = @FilePath Where FileID like'" & _FileID & "'", con)
                    'cmd.Parameters.AddWithValue("@FilePath", _DirPathName & "\" & _FileName)
                    cmd.Parameters.AddWithValue("@FilePath", _DirPathName & "\" & _FileName)
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                    Finally
                        con.Close()
                    End Try
                    _CopyFiles(_DirPathName)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Else
            MessageBox.Show("Please select file to copy.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Display_btn_Click(sender As Object, e As EventArgs) Handles Load_btn.Click
        _LoadFile()
    End Sub

    Private Sub Open_btn_Click(sender As Object, e As EventArgs)
        'If FileLV.SelectedItems.Count > 0 Then
        '    Try
        '        CheckConnectionState()
        '        cmd = New MySqlCommand("Select * from employee_file Where FileID like'" & _FileID & "'", con)
        '        DataRead = cmd.ExecuteReader
        '        If DataRead.Read = True Then
        '            _FilePathName = DataRead("FilePath").ToString
        '        End If
        '        con.Close()
        '        DataRead.Close()

        '        Process.Start(_FilePathName)
        '    Catch ex As Exception
        '        MessageBox.Show("The file cannot be found, click the Copy button to save it to make a temporary copy to your desktop computer.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Copy_btn.Focus()
        '    End Try
        'Else
        '    MessageBox.Show("Please select the file from the listview to open.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub FileLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileLV.SelectedIndexChanged
        If FileLV.SelectedItems.Count > 0 Then
            _FileID = FileLV.SelectedItems(0).Text
            _FileName = FileLV.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub Clear_btn_Click(sender As Object, e As EventArgs)
        FileLV.Items.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "Type here to search..." Then
            CheckConnectionState()
            FileLV.Items.Clear()
            'cmd = New MySqlCommand("Select FullName, FileID, FileName, FilePath, Description From employee_file, employee_info where employee_file.employee=employee_info.EmployeeID and FullName like'%" & TextBox1.Text.Replace("'", "") & "%' or Description like'%" & TextBox1.Text.Replace("'", "") & "%' and FileStatus like'1'", con)
            cmd = New MySqlCommand("Select * from employee_file inner Join employee_info on employee_file.Employee=employee_info.EmployeeID where FileStatus like'1' and FullName like '%" & TextBox1.Text.Replace("'", "") & "%' or Description like'%" & TextBox1.Text.Replace("'", "") & "%' ", con)
            'cmd = New MySqlCommand("Select FullName, FileID, FileName, FilePath, Description From employee_file, employee_info where employee_file.employee=employee_info.EmployeeID and FullName like '%" & TextBox1.Text & "%' or description like '%" & TextBox1.Text & "%' and FileStatus like'1'", con)
            DataRead = cmd.ExecuteReader
            Dim lv As ListViewItem
            While DataRead.Read = True

                lv = FileLV.Items.Add(DataRead("FileID").ToString)
                lv.SubItems.Add(DataRead("FullName").ToString)
                lv.SubItems.Add(DataRead("FileName").ToString)
                lv.SubItems.Add(DataRead("Description").ToString)

            End While
            countFile.Text = FileLV.Items.Count.ToString
            DataRead.Close()
            con.Close()
        End If


    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = "Type here to search..."
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub frmEmployeeFile_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MainForm.AdminTxt.Text = "Staff" Then
            Delete_btn.Enabled = False
        End If
        _LoadFile()
    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        If FileLV.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to delete the selected file?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    CheckConnectionState()
                    cmd = New MySqlCommand("update Employee_file set `FileStatus`=@status where FileID like '" & _FileID & "'", con)
                    cmd.Parameters.AddWithValue("@status", "0")
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully deleted.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    con.Close()
                    _LoadFile()
                End Try
            End If
        Else
            MessageBox.Show("Please select first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        frmEmployee.Close()
        frmUser.Close()
        Me.Close()
        frmEmployee.TopLevel = False
        MainForm.Panel4.Controls.Add(frmEmployee)
        frmEmployee.Show()
    End Sub
End Class
