<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirm
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
        Me.TitlelblTxt = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitlelblTxt
        '
        Me.TitlelblTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TitlelblTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlelblTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlelblTxt.ForeColor = System.Drawing.Color.White
        Me.TitlelblTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitlelblTxt.Name = "TitlelblTxt"
        Me.TitlelblTxt.Size = New System.Drawing.Size(319, 39)
        Me.TitlelblTxt.TabIndex = 3
        Me.TitlelblTxt.Text = "Administrator Password"
        Me.TitlelblTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.PasswordTxt.Location = New System.Drawing.Point(22, 46)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(272, 40)
        Me.PasswordTxt.TabIndex = 83
        Me.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(286, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(33, 26)
        Me.CloseButton.TabIndex = 84
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'frmConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 100)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.TitlelblTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitlelblTxt As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents CloseButton As Button
End Class
