<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Me.Hosttxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Porttxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Usernametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Passwordtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Databasetxt = New System.Windows.Forms.TextBox()
        Me.Test_btn = New System.Windows.Forms.Button()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleTxt.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.Location = New System.Drawing.Point(0, 0)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(356, 38)
        Me.TitleTxt.TabIndex = 3
        Me.TitleTxt.Text = "DATABASE"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Close_btn)
        Me.GroupBox1.Controls.Add(Me.Save_btn)
        Me.GroupBox1.Controls.Add(Me.Test_btn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Databasetxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Passwordtxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Usernametxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Porttxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Hosttxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 249)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect To MySQL Server"
        '
        'Hosttxt
        '
        Me.Hosttxt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hosttxt.Location = New System.Drawing.Point(123, 35)
        Me.Hosttxt.Name = "Hosttxt"
        Me.Hosttxt.Size = New System.Drawing.Size(173, 23)
        Me.Hosttxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server Host :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port :"
        '
        'Porttxt
        '
        Me.Porttxt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Porttxt.Location = New System.Drawing.Point(123, 68)
        Me.Porttxt.Name = "Porttxt"
        Me.Porttxt.Size = New System.Drawing.Size(173, 23)
        Me.Porttxt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Username :"
        '
        'Usernametxt
        '
        Me.Usernametxt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernametxt.Location = New System.Drawing.Point(123, 102)
        Me.Usernametxt.Name = "Usernametxt"
        Me.Usernametxt.Size = New System.Drawing.Size(173, 23)
        Me.Usernametxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password :"
        '
        'Passwordtxt
        '
        Me.Passwordtxt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordtxt.Location = New System.Drawing.Point(123, 134)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.Size = New System.Drawing.Size(173, 23)
        Me.Passwordtxt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Database :"
        '
        'Databasetxt
        '
        Me.Databasetxt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Databasetxt.Location = New System.Drawing.Point(123, 167)
        Me.Databasetxt.Name = "Databasetxt"
        Me.Databasetxt.Size = New System.Drawing.Size(173, 23)
        Me.Databasetxt.TabIndex = 8
        '
        'Test_btn
        '
        Me.Test_btn.Location = New System.Drawing.Point(60, 205)
        Me.Test_btn.Name = "Test_btn"
        Me.Test_btn.Size = New System.Drawing.Size(75, 26)
        Me.Test_btn.TabIndex = 10
        Me.Test_btn.Text = "&Test"
        Me.Test_btn.UseVisualStyleBackColor = True
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(141, 205)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(75, 26)
        Me.Save_btn.TabIndex = 11
        Me.Save_btn.Text = "&Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Close_btn
        '
        Me.Close_btn.Location = New System.Drawing.Point(221, 205)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(75, 26)
        Me.Close_btn.TabIndex = 12
        Me.Close_btn.Text = "&Close"
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 322)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatabase"
        Me.Text = "frmDatabase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleTxt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Hosttxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Passwordtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Usernametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Porttxt As TextBox
    Friend WithEvents Close_btn As Button
    Friend WithEvents Save_btn As Button
    Friend WithEvents Test_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Databasetxt As TextBox
End Class
