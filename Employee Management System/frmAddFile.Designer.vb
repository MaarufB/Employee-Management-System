<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddFile
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeCmb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileNameTxt = New System.Windows.Forms.TextBox()
        Me.linkBrowse = New System.Windows.Forms.LinkLabel()
        Me.FilePathTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FileDescriptionTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Save File in Database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(25, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee Name"
        '
        'EmployeeCmb
        '
        Me.EmployeeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.EmployeeCmb.Enabled = False
        Me.EmployeeCmb.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.EmployeeCmb.FormattingEnabled = True
        Me.EmployeeCmb.Location = New System.Drawing.Point(28, 83)
        Me.EmployeeCmb.Name = "EmployeeCmb"
        Me.EmployeeCmb.Size = New System.Drawing.Size(294, 26)
        Me.EmployeeCmb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "File Name"
        '
        'FileNameTxt
        '
        Me.FileNameTxt.Enabled = False
        Me.FileNameTxt.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.FileNameTxt.Location = New System.Drawing.Point(28, 141)
        Me.FileNameTxt.Name = "FileNameTxt"
        Me.FileNameTxt.Size = New System.Drawing.Size(294, 25)
        Me.FileNameTxt.TabIndex = 7
        '
        'linkBrowse
        '
        Me.linkBrowse.AutoSize = True
        Me.linkBrowse.Location = New System.Drawing.Point(255, 124)
        Me.linkBrowse.Name = "linkBrowse"
        Me.linkBrowse.Size = New System.Drawing.Size(67, 13)
        Me.linkBrowse.TabIndex = 8
        Me.linkBrowse.TabStop = True
        Me.linkBrowse.Text = "[Browse File]"
        '
        'FilePathTxt
        '
        Me.FilePathTxt.Enabled = False
        Me.FilePathTxt.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.FilePathTxt.Location = New System.Drawing.Point(28, 200)
        Me.FilePathTxt.Name = "FilePathTxt"
        Me.FilePathTxt.Size = New System.Drawing.Size(294, 25)
        Me.FilePathTxt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "File Path"
        '
        'FileDescriptionTxt
        '
        Me.FileDescriptionTxt.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.FileDescriptionTxt.Location = New System.Drawing.Point(28, 262)
        Me.FileDescriptionTxt.Name = "FileDescriptionTxt"
        Me.FileDescriptionTxt.Size = New System.Drawing.Size(294, 25)
        Me.FileDescriptionTxt.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "File Description"
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(28, 302)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(138, 29)
        Me.SaveBtn.TabIndex = 13
        Me.SaveBtn.Text = "&Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(183, 302)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(139, 29)
        Me.CancelBtn.TabIndex = 14
        Me.CancelBtn.Text = "&Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(230, 67)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[Select Employee]"
        '
        'frmAddFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 373)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.FileDescriptionTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FilePathTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.linkBrowse)
        Me.Controls.Add(Me.FileNameTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmployeeCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddFile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeCmb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FileNameTxt As TextBox
    Friend WithEvents linkBrowse As LinkLabel
    Friend WithEvents FilePathTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FileDescriptionTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
