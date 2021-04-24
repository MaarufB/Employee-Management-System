Imports MySql.Data.MySqlClient
Public Class frmStore
    Dim StoreID As Integer

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If SaveBtn.Text = "&Add" Then
            StoreNameTxt.Enabled = True
            StoreNameTxt.Text = ""
            SaveBtn.Text = "&Save"
            StoreNameTxt.Focus()
        ElseIf SaveBtn.Text = "&Save" Then
            If StoreNameTxt.Text <> "" Then
                CheckConnectionState()

                cmd = New MySqlCommand("insert into employee_store(StoreName) values(@store)", con)
                cmd.Parameters.AddWithValue("@store", StoreNameTxt.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Store successfully added.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                DisplayStore()
                SaveBtn.Text = "&Add"
                StoreNameTxt.Text = ""
                StoreNameTxt.Enabled = False
            Else
                StoreNameTxt.Focus()
            End If
        ElseIf SaveBtn.Text = "&Update" Then
            If StoreNameTxt.Text <> "" Then
                CheckConnectionState()
                cmd = New MySqlCommand("Update employee_store set `StoreName`=@store where StoreID like'" & StoreID & "'", con)
                cmd.Parameters.AddWithValue("@store", StoreNameTxt.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully updated", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                DisplayStore()
                SaveBtn.Text = "&Add"
                StoreNameTxt.Text = ""
                StoreNameTxt.Enabled = False
            Else
                StoreNameTxt.Focus()
            End If
        End If
    End Sub

    Private Sub DisplayStore()
        Try
            CheckConnectionState()
            StoreLV.Items.Clear()
            cmd = New MySqlCommand("select * from employee_store", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lv As ListViewItem
                lv = StoreLV.Items.Add(DataRead("StoreID").ToString)
                lv.SubItems.Add(DataRead("StoreName")).ToString()
            End While
            countStore.Text = StoreLV.Items.Count.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
            AddEmployeeForm.LoadStore()
        End Try
    End Sub

    Private Sub StoreLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StoreLV.SelectedIndexChanged
        If StoreLV.SelectedItems.Count > 0 Then
            With StoreLV.SelectedItems(0)
                StoreID = .Text
                StoreNameTxt.Text = .SubItems(1).Text
            End With
            SaveBtn.Text = "&Add"
            StoreNameTxt.Enabled = False
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If StoreLV.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to delete selected store?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CheckConnectionState()
                cmd = New MySqlCommand("delete from employee_store where storeid like'" & StoreID & "'", con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully deleted.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                DisplayStore()
                With StoreNameTxt
                    .Text = ""
                    .Enabled = False
                End With
            End If
        Else
            MessageBox.Show("Please select first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If StoreLV.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure to update selected store?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                StoreNameTxt.Enabled = True
                SaveBtn.Text = "&Update"
                StoreNameTxt.Focus()
            End If
        Else
            MessageBox.Show("Please select first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        With StoreNameTxt
            .Text = ""
            .Enabled = False
        End With
        SaveBtn.Text = "&Add"
        Me.Dispose()
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        Search_txt.Text = ""
        DisplayStore()
    End Sub

    Private Sub Search_txt_TextChanged(sender As Object, e As EventArgs) Handles Search_txt.TextChanged
        StoreLV.Items.Clear()
        CheckConnectionState()
        cmd = New MySqlCommand("select * from employee_store where storename like'%" & Search_txt.Text.Replace("'", "") & "%'", con)
        DataRead = cmd.ExecuteReader
        While DataRead.Read = True
            Dim lv As ListViewItem
            lv = StoreLV.Items.Add(DataRead("StoreID").ToString)
            lv.SubItems.Add(DataRead("StoreName")).ToString()
        End While
        countStore.Text = StoreLV.Items.Count.ToString
        DataRead.Close()
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MainForm.AdminTxt.Text = "Staff" Then
            DeleteBtn.Enabled = False
        End If
        DisplayStore()
    End Sub

    Private Sub StoreNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StoreNameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If StoreNameTxt.Text = "" Then
                StoreNameTxt.Focus()
            Else
                StoreNameTxt.Text = StrConv(StoreNameTxt.Text, vbUpperCase)
                e.Handled = True
            End If
        End If
    End Sub
End Class