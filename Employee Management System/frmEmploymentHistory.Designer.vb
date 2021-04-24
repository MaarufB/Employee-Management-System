<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmploymentHistory
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CompanyCmd = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaxText_lbl = New System.Windows.Forms.Label()
        Me.WorkDescription_txt = New System.Windows.Forms.TextBox()
        Me.YearEnd_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.YearStart_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Position_txt = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Remark_cmb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.EmployeeId_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitleTxt.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.ForeColor = System.Drawing.Color.White
        Me.TitleTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(431, 38)
        Me.TitleTxt.TabIndex = 87
        Me.TitleTxt.Text = "EMPLOYMENT HISTORY"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 428)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CancelBtn)
        Me.GroupBox5.Controls.Add(Me.AddBtn)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 351)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(383, 58)
        Me.GroupBox5.TabIndex = 96
        Me.GroupBox5.TabStop = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(250, 14)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(120, 31)
        Me.CancelBtn.TabIndex = 98
        Me.CancelBtn.Text = "&CANCEL"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(7, 14)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(128, 31)
        Me.AddBtn.TabIndex = 95
        Me.AddBtn.Text = "&ADD"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CompanyCmd)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.MaxText_lbl)
        Me.GroupBox3.Controls.Add(Me.WorkDescription_txt)
        Me.GroupBox3.Controls.Add(Me.YearEnd_dtp)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.YearStart_dtp)
        Me.GroupBox3.Controls.Add(Me.Position_txt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Remark_cmb)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(383, 290)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        '
        'CompanyCmd
        '
        Me.CompanyCmd.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyCmd.FormattingEnabled = True
        Me.CompanyCmd.Location = New System.Drawing.Point(90, 89)
        Me.CompanyCmd.Name = "CompanyCmd"
        Me.CompanyCmd.Size = New System.Drawing.Size(275, 24)
        Me.CompanyCmd.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Company"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(247, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Remaining:"
        '
        'MaxText_lbl
        '
        Me.MaxText_lbl.AutoSize = True
        Me.MaxText_lbl.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MaxText_lbl.Location = New System.Drawing.Point(330, 160)
        Me.MaxText_lbl.Name = "MaxText_lbl"
        Me.MaxText_lbl.Size = New System.Drawing.Size(35, 17)
        Me.MaxText_lbl.TabIndex = 101
        Me.MaxText_lbl.Text = "250"
        '
        'WorkDescription_txt
        '
        Me.WorkDescription_txt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.WorkDescription_txt.ForeColor = System.Drawing.Color.Black
        Me.WorkDescription_txt.Location = New System.Drawing.Point(9, 180)
        Me.WorkDescription_txt.MaxLength = 250
        Me.WorkDescription_txt.Multiline = True
        Me.WorkDescription_txt.Name = "WorkDescription_txt"
        Me.WorkDescription_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WorkDescription_txt.Size = New System.Drawing.Size(356, 87)
        Me.WorkDescription_txt.TabIndex = 97
        '
        'YearEnd_dtp
        '
        Me.YearEnd_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.YearEnd_dtp.Location = New System.Drawing.Point(243, 19)
        Me.YearEnd_dtp.Name = "YearEnd_dtp"
        Me.YearEnd_dtp.Size = New System.Drawing.Size(122, 20)
        Me.YearEnd_dtp.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Work Description"
        '
        'YearStart_dtp
        '
        Me.YearStart_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.YearStart_dtp.Location = New System.Drawing.Point(91, 19)
        Me.YearStart_dtp.Name = "YearStart_dtp"
        Me.YearStart_dtp.Size = New System.Drawing.Size(134, 20)
        Me.YearStart_dtp.TabIndex = 99
        '
        'Position_txt
        '
        Me.Position_txt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Position_txt.FormattingEnabled = True
        Me.Position_txt.Location = New System.Drawing.Point(90, 122)
        Me.Position_txt.Name = "Position_txt"
        Me.Position_txt.Size = New System.Drawing.Size(275, 24)
        Me.Position_txt.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Position"
        '
        'Remark_cmb
        '
        Me.Remark_cmb.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Remark_cmb.FormattingEnabled = True
        Me.Remark_cmb.Items.AddRange(New Object() {"PRESENT", "PAST"})
        Me.Remark_cmb.Location = New System.Drawing.Point(90, 51)
        Me.Remark_cmb.Name = "Remark_cmb"
        Me.Remark_cmb.Size = New System.Drawing.Size(147, 24)
        Me.Remark_cmb.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Remark"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Date Start:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 25)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.EmployeeId_txt)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 43)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label33.Location = New System.Drawing.Point(6, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(125, 17)
        Me.Label33.TabIndex = 90
        Me.Label33.Text = "Employee ID No."
        '
        'EmployeeId_txt
        '
        Me.EmployeeId_txt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeId_txt.ForeColor = System.Drawing.Color.Black
        Me.EmployeeId_txt.Location = New System.Drawing.Point(134, 13)
        Me.EmployeeId_txt.Name = "EmployeeId_txt"
        Me.EmployeeId_txt.Size = New System.Drawing.Size(231, 24)
        Me.EmployeeId_txt.TabIndex = 89
        Me.EmployeeId_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmEmploymentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmploymentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployementHistory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleTxt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents EmployeeId_txt As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Position_txt As ComboBox
    Friend WithEvents WorkDescription_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents YearEnd_dtp As DateTimePicker
    Friend WithEvents YearStart_dtp As DateTimePicker
    Friend WithEvents Remark_cmb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MaxText_lbl As Label
    Friend WithEvents CompanyCmd As ComboBox
    Friend WithEvents Label6 As Label
End Class
