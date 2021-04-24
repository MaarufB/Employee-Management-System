<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogIn
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnterBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOG IN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(279, -1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(58, 43)
        Me.CloseButton.TabIndex = 78
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Username"
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.UsernameTxt.Location = New System.Drawing.Point(21, 40)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(264, 27)
        Me.UsernameTxt.TabIndex = 80
        Me.UsernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.PasswordTxt.Location = New System.Drawing.Point(21, 102)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(264, 27)
        Me.PasswordTxt.TabIndex = 82
        Me.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Password "
        '
        'EnterBtn
        '
        Me.EnterBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.EnterBtn.FlatAppearance.BorderSize = 0
        Me.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.EnterBtn.ForeColor = System.Drawing.Color.White
        Me.EnterBtn.Location = New System.Drawing.Point(37, 136)
        Me.EnterBtn.Name = "EnterBtn"
        Me.EnterBtn.Size = New System.Drawing.Size(102, 35)
        Me.EnterBtn.TabIndex = 84
        Me.EnterBtn.Text = "&ENTER"
        Me.EnterBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(166, 136)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(102, 35)
        Me.CancelBtn.TabIndex = 85
        Me.CancelBtn.Text = "&CANCEL"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.EnterBtn)
        Me.GroupBox1.Controls.Add(Me.UsernameTxt)
        Me.GroupBox1.Controls.Add(Me.PasswordTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 184)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 252)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogIn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EnterBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
