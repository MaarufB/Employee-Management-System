<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GenerateReport_btn = New System.Windows.Forms.Button()
        Me.SelectReport_cmb = New System.Windows.Forms.ComboBox()
        Me.SearchEmployeetxt = New System.Windows.Forms.TextBox()
        Me.EmployeeLV = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Store = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EditEmployeeBtn = New System.Windows.Forms.Button()
        Me.DeleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.AddEmployeeBtn = New System.Windows.Forms.Button()
        Me.ViewEmployeeBtn = New System.Windows.Forms.Button()
        Me.countEmployee = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TitleTxt = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.countEmployee)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 613)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.SearchEmployeetxt)
        Me.GroupBox4.Controls.Add(Me.EmployeeLV)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(820, 509)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GenerateReport_btn)
        Me.GroupBox2.Controls.Add(Me.SelectReport_cmb)
        Me.GroupBox2.Location = New System.Drawing.Point(436, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 43)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'GenerateReport_btn
        '
        Me.GenerateReport_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GenerateReport_btn.FlatAppearance.BorderSize = 0
        Me.GenerateReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateReport_btn.ForeColor = System.Drawing.Color.White
        Me.GenerateReport_btn.Location = New System.Drawing.Point(9, 11)
        Me.GenerateReport_btn.Name = "GenerateReport_btn"
        Me.GenerateReport_btn.Size = New System.Drawing.Size(173, 25)
        Me.GenerateReport_btn.TabIndex = 9
        Me.GenerateReport_btn.Text = "&GENERATE  REPORT FOR"
        Me.GenerateReport_btn.UseVisualStyleBackColor = False
        '
        'SelectReport_cmb
        '
        Me.SelectReport_cmb.FormattingEnabled = True
        Me.SelectReport_cmb.Items.AddRange(New Object() {"EMPLOYEE(S) STATUS", "EMPLOYEE(S) DETAILS"})
        Me.SelectReport_cmb.Location = New System.Drawing.Point(190, 14)
        Me.SelectReport_cmb.Name = "SelectReport_cmb"
        Me.SelectReport_cmb.Size = New System.Drawing.Size(162, 21)
        Me.SelectReport_cmb.TabIndex = 4
        '
        'SearchEmployeetxt
        '
        Me.SearchEmployeetxt.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEmployeetxt.ForeColor = System.Drawing.Color.Black
        Me.SearchEmployeetxt.Location = New System.Drawing.Point(69, 19)
        Me.SearchEmployeetxt.Name = "SearchEmployeetxt"
        Me.SearchEmployeetxt.Size = New System.Drawing.Size(258, 25)
        Me.SearchEmployeetxt.TabIndex = 1
        '
        'EmployeeLV
        '
        Me.EmployeeLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.IDNo, Me.FullName, Me.Gender, Me.Position, Me.Store, Me.DateStart, Me.Status, Me.Type, Me.Contact, Me.Address})
        Me.EmployeeLV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmployeeLV.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeLV.FullRowSelect = True
        Me.EmployeeLV.GridLines = True
        Me.EmployeeLV.HideSelection = False
        Me.EmployeeLV.Location = New System.Drawing.Point(3, 60)
        Me.EmployeeLV.Name = "EmployeeLV"
        Me.EmployeeLV.Size = New System.Drawing.Size(814, 446)
        Me.EmployeeLV.TabIndex = 0
        Me.EmployeeLV.UseCompatibleStateImageBehavior = False
        Me.EmployeeLV.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'IDNo
        '
        Me.IDNo.Text = "ID NUMBER"
        Me.IDNo.Width = 129
        '
        'FullName
        '
        Me.FullName.Text = "FULL NAME"
        Me.FullName.Width = 234
        '
        'Gender
        '
        Me.Gender.Text = "GENDER"
        Me.Gender.Width = 100
        '
        'Position
        '
        Me.Position.Text = "POSITION"
        Me.Position.Width = 180
        '
        'Store
        '
        Me.Store.Text = "STORE"
        Me.Store.Width = 160
        '
        'DateStart
        '
        Me.DateStart.Text = "DATE STARTED"
        Me.DateStart.Width = 150
        '
        'Status
        '
        Me.Status.Text = "STATUS"
        Me.Status.Width = 100
        '
        'Type
        '
        Me.Type.Text = "TYPE"
        Me.Type.Width = 100
        '
        'Contact
        '
        Me.Contact.Text = "CONTACT NUMBER"
        Me.Contact.Width = 150
        '
        'Address
        '
        Me.Address.Text = "ADDRESS"
        Me.Address.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(333, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EditEmployeeBtn)
        Me.GroupBox3.Controls.Add(Me.DeleteEmployeeBtn)
        Me.GroupBox3.Controls.Add(Me.AddEmployeeBtn)
        Me.GroupBox3.Controls.Add(Me.ViewEmployeeBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(821, 68)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'EditEmployeeBtn
        '
        Me.EditEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.EditEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.EditEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditEmployeeBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditEmployeeBtn.ForeColor = System.Drawing.Color.White
        Me.EditEmployeeBtn.Location = New System.Drawing.Point(216, 16)
        Me.EditEmployeeBtn.Name = "EditEmployeeBtn"
        Me.EditEmployeeBtn.Size = New System.Drawing.Size(181, 42)
        Me.EditEmployeeBtn.TabIndex = 8
        Me.EditEmployeeBtn.Text = "EDIT EMPLOYEE"
        Me.EditEmployeeBtn.UseVisualStyleBackColor = False
        '
        'DeleteEmployeeBtn
        '
        Me.DeleteEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DeleteEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.DeleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteEmployeeBtn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.DeleteEmployeeBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteEmployeeBtn.Location = New System.Drawing.Point(617, 16)
        Me.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn"
        Me.DeleteEmployeeBtn.Size = New System.Drawing.Size(181, 42)
        Me.DeleteEmployeeBtn.TabIndex = 7
        Me.DeleteEmployeeBtn.Text = "DELETE EMPLOYEE"
        Me.DeleteEmployeeBtn.UseVisualStyleBackColor = False
        '
        'AddEmployeeBtn
        '
        Me.AddEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.AddEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddEmployeeBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmployeeBtn.ForeColor = System.Drawing.Color.White
        Me.AddEmployeeBtn.Location = New System.Drawing.Point(15, 16)
        Me.AddEmployeeBtn.Name = "AddEmployeeBtn"
        Me.AddEmployeeBtn.Size = New System.Drawing.Size(181, 42)
        Me.AddEmployeeBtn.TabIndex = 4
        Me.AddEmployeeBtn.Text = "ADD EMPLOYEE"
        Me.AddEmployeeBtn.UseVisualStyleBackColor = False
        '
        'ViewEmployeeBtn
        '
        Me.ViewEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ViewEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.ViewEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewEmployeeBtn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.ViewEmployeeBtn.ForeColor = System.Drawing.Color.White
        Me.ViewEmployeeBtn.Location = New System.Drawing.Point(416, 16)
        Me.ViewEmployeeBtn.Name = "ViewEmployeeBtn"
        Me.ViewEmployeeBtn.Size = New System.Drawing.Size(181, 42)
        Me.ViewEmployeeBtn.TabIndex = 6
        Me.ViewEmployeeBtn.Text = "VIEW EMPLOYEE"
        Me.ViewEmployeeBtn.UseVisualStyleBackColor = False
        '
        'countEmployee
        '
        Me.countEmployee.AutoSize = True
        Me.countEmployee.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countEmployee.Location = New System.Drawing.Point(177, 587)
        Me.countEmployee.Name = "countEmployee"
        Me.countEmployee.Size = New System.Drawing.Size(17, 17)
        Me.countEmployee.TabIndex = 6
        Me.countEmployee.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 587)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TOTAL EMPLOYEE/S"
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTxt.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.ForeColor = System.Drawing.Color.White
        Me.TitleTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(855, 35)
        Me.TitleTxt.TabIndex = 2
        Me.TitleTxt.Text = "EMPLOYEE LIST"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 668)
        Me.Controls.Add(Me.TitleTxt)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmployeeLV As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchEmployeetxt As TextBox
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents FullName As ColumnHeader
    Friend WithEvents Position As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents TitleTxt As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AddEmployeeBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents countEmployee As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents IDNo As ColumnHeader
    Friend WithEvents ViewEmployeeBtn As Button
    Friend WithEvents DeleteEmployeeBtn As Button
    Friend WithEvents Store As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Contact As ColumnHeader
    Friend WithEvents Address As ColumnHeader
    Friend WithEvents Gender As ColumnHeader
    Friend WithEvents DateStart As ColumnHeader
    Friend WithEvents SelectReport_cmb As ComboBox
    Friend WithEvents EditEmployeeBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GenerateReport_btn As Button
End Class
