<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleTxt = New System.Windows.Forms.Label()
        Me.FirstnameTxt = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.countUser = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SearchEmployeetxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.UserList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RoleCmb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LastnameTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MiddleName = New System.Windows.Forms.TextBox()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTxt.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TitleTxt.ForeColor = System.Drawing.Color.White
        Me.TitleTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(855, 35)
        Me.TitleTxt.TabIndex = 3
        Me.TitleTxt.Text = "SYSTEM USER"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FirstnameTxt
        '
        Me.FirstnameTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FirstnameTxt.ForeColor = System.Drawing.Color.Black
        Me.FirstnameTxt.Location = New System.Drawing.Point(21, 102)
        Me.FirstnameTxt.Name = "FirstnameTxt"
        Me.FirstnameTxt.Size = New System.Drawing.Size(285, 24)
        Me.FirstnameTxt.TabIndex = 78
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(18, 81)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(89, 18)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "First Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 596)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.countUser)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.UserList)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 230)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(786, 349)
        Me.GroupBox4.TabIndex = 96
        Me.GroupBox4.TabStop = False
        '
        'countUser
        '
        Me.countUser.AutoSize = True
        Me.countUser.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countUser.Location = New System.Drawing.Point(192, 324)
        Me.countUser.Name = "countUser"
        Me.countUser.Size = New System.Drawing.Size(17, 17)
        Me.countUser.TabIndex = 97
        Me.countUser.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 17)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "TOTAL SYSTEM USER"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SearchEmployeetxt)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.RefreshBtn)
        Me.GroupBox5.Location = New System.Drawing.Point(25, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(739, 59)
        Me.GroupBox5.TabIndex = 96
        Me.GroupBox5.TabStop = False
        '
        'SearchEmployeetxt
        '
        Me.SearchEmployeetxt.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEmployeetxt.ForeColor = System.Drawing.Color.DimGray
        Me.SearchEmployeetxt.Location = New System.Drawing.Point(71, 19)
        Me.SearchEmployeetxt.Name = "SearchEmployeetxt"
        Me.SearchEmployeetxt.Size = New System.Drawing.Size(308, 25)
        Me.SearchEmployeetxt.TabIndex = 1
        Me.SearchEmployeetxt.Text = "Type here to search..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Search"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.RefreshBtn.FlatAppearance.BorderSize = 0
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.ForeColor = System.Drawing.Color.White
        Me.RefreshBtn.Location = New System.Drawing.Point(400, 17)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(80, 27)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "&REFRESH"
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'UserList
        '
        Me.UserList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader3})
        Me.UserList.FullRowSelect = True
        Me.UserList.GridLines = True
        Me.UserList.HideSelection = False
        Me.UserList.Location = New System.Drawing.Point(22, 76)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(742, 238)
        Me.UserList.TabIndex = 95
        Me.UserList.UseCompatibleStateImageBehavior = False
        Me.UserList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Last Name"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "First Name"
        Me.ColumnHeader4.Width = 168
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Middle Name"
        Me.ColumnHeader5.Width = 136
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Username"
        Me.ColumnHeader3.Width = 205
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DeleteBtn)
        Me.GroupBox3.Controls.Add(Me.CancelBtn)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.RoleCmb)
        Me.GroupBox3.Controls.Add(Me.EditBtn)
        Me.GroupBox3.Controls.Add(Me.SaveBtn)
        Me.GroupBox3.Controls.Add(Me.FirstnameTxt)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.LastnameTxt)
        Me.GroupBox3.Controls.Add(Me.PasswordTxt)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.MiddleName)
        Me.GroupBox3.Controls.Add(Me.UsernameTxt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(786, 197)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "USER DETAILS"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(475, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox1.TabIndex = 91
        Me.CheckBox1.Text = "[Show Password]"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RoleCmb
        '
        Me.RoleCmb.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RoleCmb.FormattingEnabled = True
        Me.RoleCmb.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.RoleCmb.Location = New System.Drawing.Point(343, 155)
        Me.RoleCmb.Name = "RoleCmb"
        Me.RoleCmb.Size = New System.Drawing.Size(285, 24)
        Me.RoleCmb.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(340, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 18)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Role"
        '
        'LastnameTxt
        '
        Me.LastnameTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.LastnameTxt.ForeColor = System.Drawing.Color.Black
        Me.LastnameTxt.Location = New System.Drawing.Point(22, 46)
        Me.LastnameTxt.Name = "LastnameTxt"
        Me.LastnameTxt.Size = New System.Drawing.Size(285, 24)
        Me.LastnameTxt.TabIndex = 80
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.PasswordTxt.Location = New System.Drawing.Point(343, 102)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(285, 24)
        Me.PasswordTxt.TabIndex = 86
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(343, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Password"
        '
        'MiddleName
        '
        Me.MiddleName.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MiddleName.ForeColor = System.Drawing.Color.Black
        Me.MiddleName.Location = New System.Drawing.Point(21, 155)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(285, 24)
        Me.MiddleName.TabIndex = 82
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UsernameTxt.ForeColor = System.Drawing.Color.Black
        Me.UsernameTxt.Location = New System.Drawing.Point(340, 46)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(285, 24)
        Me.UsernameTxt.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(340, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Username"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(671, 105)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(93, 34)
        Me.DeleteBtn.TabIndex = 92
        Me.DeleteBtn.Text = "&DELETE"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(671, 25)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(93, 34)
        Me.SaveBtn.TabIndex = 87
        Me.SaveBtn.Text = "&ADD"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.EditBtn.FlatAppearance.BorderSize = 0
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(671, 65)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(93, 34)
        Me.EditBtn.TabIndex = 91
        Me.EditBtn.Text = "&EDIT"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(671, 145)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(93, 34)
        Me.CancelBtn.TabIndex = 88
        Me.CancelBtn.Text = "&CANCEL"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(822, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(27, 35)
        Me.CloseButton.TabIndex = 80
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(855, 668)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleTxt As Label
    Friend WithEvents FirstnameTxt As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MiddleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LastnameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents UserList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents SearchEmployeetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents RoleCmb As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents countUser As Label
    Friend WithEvents Label7 As Label
End Class
