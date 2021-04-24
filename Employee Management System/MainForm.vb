Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Threading
Public Class MainForm
    Dim employeeThread As System.Threading.Thread

    Private Sub MinimizedBtn_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub EmployeeBtn_Click(sender As Object, e As EventArgs) Handles EmployeeBtn.Click
        frmEmployee.Close()
        frmUser.Close()
        frmEmployeeFile.Close()
        frmEmployee.TopLevel = False
        Panel4.Controls.Add(frmEmployee)
        frmEmployee.Show()
        'employeeThread = New System.Threading.Thread(AddressOf LoadEmployee)
        'employeeThread.Start()
    End Sub

    Private Sub SystemUserBtn_Click(sender As Object, e As EventArgs) Handles SystemUserBtn.Click
        'If AdminTxt.Text = "Staff" Then
        '    If MessageBox.Show("You are not authorized to perform this task, are you sure you want to continue?", sysmessage, MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '        OpenSystemUser = True
        '        OpenPosition = False
        '        frmConfirm.ShowDialog()
        '    End If
        'Else
        '    frmEmployee.Close()
        '    frmUser.Close()
        '    frmEmployeeFile.Close()
        '    frmUser.TopLevel = False
        '    Panel4.Controls.Add(frmUser)
        '    frmUser.Show()
        'End If
        frmEmployee.Close()
        frmUser.Close()
        frmEmployeeFile.Close()
        frmUser.TopLevel = False
        Panel4.Controls.Add(frmUser)
        frmUser.Show()
    End Sub

    Private Sub EmployeeFileBtn_Click(sender As Object, e As EventArgs) Handles EmployeeFileBtn.Click
        frmEmployee.Close()
        frmUser.Close()
        frmEmployeeFile.Close()
        frmEmployeeFile.TopLevel = False
        Panel4.Controls.Add(frmEmployeeFile)
        frmEmployeeFile.Show()
    End Sub

    Private Sub EmployeePositionBtn_Click(sender As Object, e As EventArgs) Handles EmployeePositionBtn.Click
        'If AdminTxt.Text = "Staff" Then
        '    If MessageBox.Show("You are not authorized to perform this task, are you sure you want to continue?", sysmessage, MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '        OpenPosition = True
        '        OpenSystemUser = False
        '        frmConfirm.ShowDialog()
        '    End If
        'Else
        '    frmEmployeePosition.ShowDialog()
        'End If
        frmEmployeePosition.ShowDialog()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        If MessageBox.Show("Are you sure to log out?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLogIn.PasswordTxt.Text = ""
            frmLogIn.UsernameTxt.Text = ""
            frmLogIn.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTxt.Text = Format(Date.Now, "MMMM dd, yyyy").ToString
        System.Threading.Thread.Sleep(300)
        Me.Refresh()
        LoadEmployee()

    End Sub

    Private Sub LoadEmployee()
        Try
            frmEmployee.Close()
            frmUser.Close()
            frmEmployeeFile.Close()
            frmEmployee.TopLevel = False
            Panel4.Controls.Add(frmEmployee)
            frmEmployee.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeTxt.Text = Format(Date.Now, "Long Time")
    End Sub

    Private Sub MainForm_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked

    End Sub

    Private Sub BtnStore_Click(sender As Object, e As EventArgs) Handles BtnStore.Click
        frmStore.ShowDialog()
    End Sub
End Class