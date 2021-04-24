<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateEmployeePosition
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.TitleTxt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.Positionlbl = New System.Windows.Forms.Label()
        Me.PositionCmb = New System.Windows.Forms.ComboBox()
        Me.FullNameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(332, 1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(49, 43)
        Me.CloseButton.TabIndex = 84
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTxt.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.ForeColor = System.Drawing.Color.White
        Me.TitleTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(380, 49)
        Me.TitleTxt.TabIndex = 83
        Me.TitleTxt.Text = "UPDATE POSITION"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Positionlbl)
        Me.GroupBox1.Controls.Add(Me.PositionCmb)
        Me.GroupBox1.Controls.Add(Me.FullNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IDtxt)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 280)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CancelBtn)
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 53)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(140, 15)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(116, 29)
        Me.CancelBtn.TabIndex = 92
        Me.CancelBtn.Text = "&Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.UpdateBtn.FlatAppearance.BorderSize = 0
        Me.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBtn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(18, 15)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(116, 29)
        Me.UpdateBtn.TabIndex = 91
        Me.UpdateBtn.Text = "&Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'Positionlbl
        '
        Me.Positionlbl.AutoSize = True
        Me.Positionlbl.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Positionlbl.Location = New System.Drawing.Point(21, 148)
        Me.Positionlbl.Name = "Positionlbl"
        Me.Positionlbl.Size = New System.Drawing.Size(66, 18)
        Me.Positionlbl.TabIndex = 86
        Me.Positionlbl.Text = "Position"
        '
        'PositionCmb
        '
        Me.PositionCmb.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PositionCmb.FormattingEnabled = True
        Me.PositionCmb.Location = New System.Drawing.Point(24, 169)
        Me.PositionCmb.Name = "PositionCmb"
        Me.PositionCmb.Size = New System.Drawing.Size(269, 24)
        Me.PositionCmb.TabIndex = 85
        '
        'FullNameTxt
        '
        Me.FullNameTxt.Enabled = False
        Me.FullNameTxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FullNameTxt.ForeColor = System.Drawing.Color.Black
        Me.FullNameTxt.Location = New System.Drawing.Point(23, 106)
        Me.FullNameTxt.Name = "FullNameTxt"
        Me.FullNameTxt.Size = New System.Drawing.Size(270, 24)
        Me.FullNameTxt.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Full Name"
        '
        'IDtxt
        '
        Me.IDtxt.Enabled = False
        Me.IDtxt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IDtxt.ForeColor = System.Drawing.Color.Black
        Me.IDtxt.Location = New System.Drawing.Point(23, 38)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(270, 24)
        Me.IDtxt.TabIndex = 82
        Me.IDtxt.Text = "2"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(21, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(102, 18)
        Me.Label29.TabIndex = 81
        Me.Label29.Text = "Employee ID"
        '
        'frmUpdateEmployeePosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 367)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateEmployeePosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdateEmployeePosition"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents TitleTxt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Positionlbl As Label
    Friend WithEvents PositionCmb As ComboBox
    Friend WithEvents FullNameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDtxt As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents UpdateBtn As Button
End Class
