<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnStore = New System.Windows.Forms.Button()
        Me.UserTxt = New System.Windows.Forms.Label()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.SystemUserBtn = New System.Windows.Forms.Button()
        Me.EmployeePositionBtn = New System.Windows.Forms.Button()
        Me.EmployeeFileBtn = New System.Windows.Forms.Button()
        Me.EmployeeBtn = New System.Windows.Forms.Button()
        Me.AdminTxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinimizeBtn = New System.Windows.Forms.PictureBox()
        Me.DateTxt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimeTxt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MinimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(317, 702)
        Me.Panel3.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(315, 34)
        Me.Panel5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnStore)
        Me.GroupBox1.Controls.Add(Me.UserTxt)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LogOutBtn)
        Me.GroupBox1.Controls.Add(Me.SystemUserBtn)
        Me.GroupBox1.Controls.Add(Me.EmployeePositionBtn)
        Me.GroupBox1.Controls.Add(Me.EmployeeFileBtn)
        Me.GroupBox1.Controls.Add(Me.EmployeeBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 596)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnStore
        '
        Me.BtnStore.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BtnStore.FlatAppearance.BorderSize = 0
        Me.BtnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BtnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStore.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStore.ForeColor = System.Drawing.Color.White
        Me.BtnStore.Location = New System.Drawing.Point(21, 412)
        Me.BtnStore.Name = "BtnStore"
        Me.BtnStore.Size = New System.Drawing.Size(258, 50)
        Me.BtnStore.TabIndex = 13
        Me.BtnStore.Text = "STORE"
        Me.BtnStore.UseVisualStyleBackColor = False
        '
        'UserTxt
        '
        Me.UserTxt.AutoSize = True
        Me.UserTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserTxt.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UserTxt.ForeColor = System.Drawing.Color.White
        Me.UserTxt.Location = New System.Drawing.Point(73, 210)
        Me.UserTxt.Name = "UserTxt"
        Me.UserTxt.Size = New System.Drawing.Size(142, 19)
        Me.UserTxt.TabIndex = 6
        Me.UserTxt.Text = "MA-ARUF M. BURAD"
        Me.UserTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogOutBtn
        '
        Me.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.LogOutBtn.FlatAppearance.BorderSize = 0
        Me.LogOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutBtn.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBtn.ForeColor = System.Drawing.Color.White
        Me.LogOutBtn.Location = New System.Drawing.Point(21, 524)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Size = New System.Drawing.Size(258, 50)
        Me.LogOutBtn.TabIndex = 11
        Me.LogOutBtn.Text = "LOG OUT"
        Me.LogOutBtn.UseVisualStyleBackColor = False
        '
        'SystemUserBtn
        '
        Me.SystemUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.SystemUserBtn.FlatAppearance.BorderSize = 0
        Me.SystemUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.SystemUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SystemUserBtn.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemUserBtn.ForeColor = System.Drawing.Color.White
        Me.SystemUserBtn.Location = New System.Drawing.Point(21, 468)
        Me.SystemUserBtn.Name = "SystemUserBtn"
        Me.SystemUserBtn.Size = New System.Drawing.Size(258, 50)
        Me.SystemUserBtn.TabIndex = 10
        Me.SystemUserBtn.Text = "SYSTEM USER"
        Me.SystemUserBtn.UseVisualStyleBackColor = False
        '
        'EmployeePositionBtn
        '
        Me.EmployeePositionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.EmployeePositionBtn.FlatAppearance.BorderSize = 0
        Me.EmployeePositionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.EmployeePositionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeePositionBtn.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeePositionBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeePositionBtn.Location = New System.Drawing.Point(21, 357)
        Me.EmployeePositionBtn.Name = "EmployeePositionBtn"
        Me.EmployeePositionBtn.Size = New System.Drawing.Size(258, 50)
        Me.EmployeePositionBtn.TabIndex = 9
        Me.EmployeePositionBtn.Text = "EMPLOYEE POSITION"
        Me.EmployeePositionBtn.UseVisualStyleBackColor = False
        '
        'EmployeeFileBtn
        '
        Me.EmployeeFileBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.EmployeeFileBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.EmployeeFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeFileBtn.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeFileBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeFileBtn.Location = New System.Drawing.Point(21, 302)
        Me.EmployeeFileBtn.Name = "EmployeeFileBtn"
        Me.EmployeeFileBtn.Size = New System.Drawing.Size(258, 50)
        Me.EmployeeFileBtn.TabIndex = 8
        Me.EmployeeFileBtn.Text = "ATTACHMENT FILE"
        Me.EmployeeFileBtn.UseVisualStyleBackColor = False
        '
        'EmployeeBtn
        '
        Me.EmployeeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.EmployeeBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeBtn.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeBtn.Location = New System.Drawing.Point(21, 248)
        Me.EmployeeBtn.Name = "EmployeeBtn"
        Me.EmployeeBtn.Size = New System.Drawing.Size(258, 50)
        Me.EmployeeBtn.TabIndex = 7
        Me.EmployeeBtn.Text = "EMPLOYEE"
        Me.EmployeeBtn.UseVisualStyleBackColor = False
        '
        'AdminTxt
        '
        Me.AdminTxt.AutoSize = True
        Me.AdminTxt.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AdminTxt.ForeColor = System.Drawing.Color.Black
        Me.AdminTxt.Location = New System.Drawing.Point(95, 8)
        Me.AdminTxt.Name = "AdminTxt"
        Me.AdminTxt.Size = New System.Drawing.Size(99, 17)
        Me.AdminTxt.TabIndex = 12
        Me.AdminTxt.Text = "Administrator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Log In as:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AdminTxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MinimizeBtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TimeTxt)
        Me.Panel1.Controls.Add(Me.DateTxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(317, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 34)
        Me.Panel1.TabIndex = 0
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.Image = CType(resources.GetObject("MinimizeBtn.Image"), System.Drawing.Image)
        Me.MinimizeBtn.Location = New System.Drawing.Point(820, 2)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(31, 27)
        Me.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizeBtn.TabIndex = 0
        Me.MinimizeBtn.TabStop = False
        '
        'DateTxt
        '
        Me.DateTxt.AutoSize = True
        Me.DateTxt.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DateTxt.ForeColor = System.Drawing.Color.Black
        Me.DateTxt.Location = New System.Drawing.Point(456, 8)
        Me.DateTxt.Name = "DateTxt"
        Me.DateTxt.Size = New System.Drawing.Size(135, 17)
        Me.DateTxt.TabIndex = 4
        Me.DateTxt.Text = "December 31, 1997"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(405, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date:"
        '
        'TimeTxt
        '
        Me.TimeTxt.AutoSize = True
        Me.TimeTxt.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TimeTxt.ForeColor = System.Drawing.Color.Black
        Me.TimeTxt.Location = New System.Drawing.Point(660, 8)
        Me.TimeTxt.Name = "TimeTxt"
        Me.TimeTxt.Size = New System.Drawing.Size(71, 17)
        Me.TimeTxt.TabIndex = 2
        Me.TimeTxt.Text = "12:00 AM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(609, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Time:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(317, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(855, 668)
        Me.Panel4.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 654)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(853, 12)
        Me.Panel2.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 702)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MinimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents EmployeePositionBtn As Button
    Friend WithEvents EmployeeFileBtn As Button
    Friend WithEvents EmployeeBtn As Button
    Friend WithEvents SystemUserBtn As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DateTxt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeTxt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserTxt As Label
    Friend WithEvents MinimizeBtn As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AdminTxt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnStore As Button
    Friend WithEvents Panel2 As Panel
End Class
