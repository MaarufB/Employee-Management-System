Imports MySql.Data.MySqlClient
Public Class frmPrintBiodata
    Private Sub BindText()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("SELECT * FROM employee_info WHERE EmployeeID like '" & PersonID & "' and EmployeeStatus like'1'", con)
            DataRead = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While DataRead.Read = True

                fullname.Text = DataRead("FullName").ToString
                gender.Text = DataRead("Gender").ToString
                birthdate.Text = DateTime.Parse(DataRead("DOB")).ToString("MMMM dd, yyyy").ToUpper
                birthplace.Text = DataRead("POB").ToString
                address.Text = DataRead("Address").ToString
                citizen.Text = DataRead("Citizenship").ToString
                religion.Text = DataRead("Religion").ToString
                civilstatus.Text = DataRead("CivilStatus").ToString
                contactno.Text = DataRead("ContactNo").ToString
                heightInFeet.Text = DataRead("Height") & " ft.".ToString
                weight.Text = DataRead("Weight") & " kg.".ToString
                elementary.Text = Trim(DataRead("NameOfSchool_Elem")).ToString
                elementarygrad.Text = DataRead("YearGrad_Elem").ToString
                highschool.Text = Trim(DataRead("NameOfSchool_HS")).ToString
                highschoolgrad.Text = DataRead("YearGrad_HS").ToString
                college.Text = Trim(DataRead("NameOfSchool_College")).ToString
                collegegrad.Text = DataRead("YearGrad_College").ToString
                sss.Text = DataRead("IDNo_SSS").ToString
                tin.Text = DataRead("IDNo_Philhealth").ToString
                pagibig.Text = DataRead("IDNo_Pagibig").ToString
                philhealth.Text = DataRead("IDNo_TIN").ToString

            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub LoadImage()
        Try
            Dim adapter As New MySqlDataAdapter
            Dim cmd As New MySqlCommand
            adapter.SelectCommand = cmd
            Dim data As DataTable
            Dim CommandBuild As MySqlCommandBuilder
            data = New DataTable

            adapter = New MySqlDataAdapter("Select Pic from employee_info where EmployeeID Like '" & PersonID & "'", con)
            CommandBuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(data)

            Dim lb() As Byte = data.Rows(0).Item("Pic")
            Dim lstr As New System.IO.MemoryStream(lb)

            PictureBox1.Image = Image.FromStream(lstr)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub LoadEmploymentHistory()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Select * from employee_history inner join employee_info on employee_history.Employee=employee_info.EmployeeIDNo where EmployeeID like '" & PersonID & "' order by remark like'PRESENT' desc LIMIT 4", con)
            dataRead = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dataRead.Read = True
                Dim lv As New ListViewItem
                Dim alterDate As String
                If dataRead("DateTo") = "PRESENT" Then
                    alterDate = "PRESENT"
                    dgw.Rows.Add(DateTime.Parse(dataRead("DateFrom")).Year & " - " & alterDate, dataRead("Company"), dataRead("Position"))
                Else
                    alterDate = DateTime.Parse(dataRead("DateTo")).Year
                    dgw.Rows.Add(DateTime.Parse(dataRead("DateFrom")).Year & " - " & alterDate, dataRead("Company"), dataRead("Position"))
                End If

            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            dataRead.Close()
            cmd.Dispose()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindText()
        'LoadImage()
        LoadEmploymentHistory()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog
        If (ButtonPressed = DialogResult.OK) Then
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 0)

        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            With PictureBox1
                .Image = Nothing
            End With
            RadioButton2.Checked = False
        ElseIf RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            LoadImage()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            LoadImage()
            RadioButton1.Checked = False
        ElseIf RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            With PictureBox1
                .Image = Nothing
            End With
        End If
    End Sub
End Class
