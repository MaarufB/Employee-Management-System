<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeePosition
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
        Me.TitleTxt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SalaryTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PositionTxt = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PositionLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.countPosition = New System.Windows.Forms.Label()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Search_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTxt.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.ForeColor = System.Drawing.Color.White
        Me.TitleTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(438, 49)
        Me.TitleTxt.TabIndex = 81
        Me.TitleTxt.Text = "EMPLOYEE POSITION"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.SalaryTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PositionTxt)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 184)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DeleteBtn)
        Me.GroupBox3.Controls.Add(Me.Edit)
        Me.GroupBox3.Controls.Add(Me.CancelBtn)
        Me.GroupBox3.Controls.Add(Me.SaveBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 45)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(180, 10)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(81, 29)
        Me.DeleteBtn.TabIndex = 92
        Me.DeleteBtn.Text = "&Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Edit.FlatAppearance.BorderSize = 0
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(93, 10)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(81, 29)
        Me.Edit.TabIndex = 91
        Me.Edit.Text = "&Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(273, 10)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(81, 29)
        Me.CancelBtn.TabIndex = 90
        Me.CancelBtn.Text = "&Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(6, 10)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(81, 29)
        Me.SaveBtn.TabIndex = 89
        Me.SaveBtn.Text = "&Add"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'SalaryTxt
        '
        Me.SalaryTxt.Enabled = False
        Me.SalaryTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SalaryTxt.ForeColor = System.Drawing.Color.DimGray
        Me.SalaryTxt.Location = New System.Drawing.Point(14, 98)
        Me.SalaryTxt.Name = "SalaryTxt"
        Me.SalaryTxt.Size = New System.Drawing.Size(361, 24)
        Me.SalaryTxt.TabIndex = 82
        Me.SalaryTxt.Text = "Type Salary here..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Employee Salary"
        '
        'PositionTxt
        '
        Me.PositionTxt.Enabled = False
        Me.PositionTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PositionTxt.ForeColor = System.Drawing.Color.DimGray
        Me.PositionTxt.Location = New System.Drawing.Point(14, 40)
        Me.PositionTxt.Name = "PositionTxt"
        Me.PositionTxt.Size = New System.Drawing.Size(361, 24)
        Me.PositionTxt.TabIndex = 80
        Me.PositionTxt.Text = "Type Position here..."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(12, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(144, 18)
        Me.Label29.TabIndex = 79
        Me.Label29.Text = "Employee Position"
        '
        'PositionLV
        '
        Me.PositionLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.PositionLV.FullRowSelect = True
        Me.PositionLV.GridLines = True
        Me.PositionLV.HideSelection = False
        Me.PositionLV.Location = New System.Drawing.Point(15, 45)
        Me.PositionLV.Name = "PositionLV"
        Me.PositionLV.Size = New System.Drawing.Size(360, 195)
        Me.PositionLV.TabIndex = 84
        Me.PositionLV.UseCompatibleStateImageBehavior = False
        Me.PositionLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 37
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Position"
        Me.ColumnHeader2.Width = 237
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Salary"
        Me.ColumnHeader3.Width = 83
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.countPosition)
        Me.GroupBox2.Controls.Add(Me.LoadBtn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Search_txt)
        Me.GroupBox2.Controls.Add(Me.PositionLV)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 266)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "TOTAL POSITION :"
        '
        'countPosition
        '
        Me.countPosition.AutoSize = True
        Me.countPosition.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countPosition.Location = New System.Drawing.Point(159, 244)
        Me.countPosition.Name = "countPosition"
        Me.countPosition.Size = New System.Drawing.Size(17, 17)
        Me.countPosition.TabIndex = 96
        Me.countPosition.Text = "0"
        '
        'LoadBtn
        '
        Me.LoadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.LoadBtn.FlatAppearance.BorderSize = 0
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.LoadBtn.ForeColor = System.Drawing.Color.White
        Me.LoadBtn.Location = New System.Drawing.Point(217, 14)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(75, 25)
        Me.LoadBtn.TabIndex = 93
        Me.LoadBtn.Text = "&Load"
        Me.LoadBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Search"
        '
        'Search_txt
        '
        Me.Search_txt.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Search_txt.ForeColor = System.Drawing.Color.DimGray
        Me.Search_txt.Location = New System.Drawing.Point(78, 17)
        Me.Search_txt.Name = "Search_txt"
        Me.Search_txt.Size = New System.Drawing.Size(133, 20)
        Me.Search_txt.TabIndex = 84
        Me.Search_txt.Text = "Search here..."
        '
        'frmEmployeePosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 518)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeePosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeePosition"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleTxt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SalaryTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PositionTxt As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents PositionLV As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Edit As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents LoadBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Search_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents countPosition As Label
End Class
