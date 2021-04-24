<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportByStoreEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportByStoreEmployee))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Print_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CountEmployee_lbl = New System.Windows.Forms.Label()
        Me.EmployeeLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectStore_cmb = New System.Windows.Forms.ComboBox()
        Me.Remove_btn = New System.Windows.Forms.Button()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CheckActive = New System.Windows.Forms.RadioButton()
        Me.CheckInActive = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Print_btn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 45)
        Me.Panel1.TabIndex = 0
        '
        'Print_btn
        '
        Me.Print_btn.BackColor = System.Drawing.Color.Transparent
        Me.Print_btn.FlatAppearance.BorderSize = 0
        Me.Print_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Print_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Print_btn.ForeColor = System.Drawing.Color.Teal
        Me.Print_btn.Image = CType(resources.GetObject("Print_btn.Image"), System.Drawing.Image)
        Me.Print_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Print_btn.Location = New System.Drawing.Point(439, 3)
        Me.Print_btn.Name = "Print_btn"
        Me.Print_btn.Size = New System.Drawing.Size(149, 37)
        Me.Print_btn.TabIndex = 9
        Me.Print_btn.Text = "    Print Preview"
        Me.Print_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(11, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Employee Details Report"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.EmployeeLV)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(601, 548)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Exit_btn)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CountEmployee_lbl)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 493)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(581, 48)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.Exit_btn.FlatAppearance.BorderSize = 0
        Me.Exit_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.Black
        Me.Exit_btn.Image = CType(resources.GetObject("Exit_btn.Image"), System.Drawing.Image)
        Me.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Exit_btn.Location = New System.Drawing.Point(478, 13)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(95, 28)
        Me.Exit_btn.TabIndex = 9
        Me.Exit_btn.Text = "   &Back"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "No. of Employee:"
        '
        'CountEmployee_lbl
        '
        Me.CountEmployee_lbl.AutoSize = True
        Me.CountEmployee_lbl.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountEmployee_lbl.Location = New System.Drawing.Point(149, 16)
        Me.CountEmployee_lbl.Name = "CountEmployee_lbl"
        Me.CountEmployee_lbl.Size = New System.Drawing.Size(17, 17)
        Me.CountEmployee_lbl.TabIndex = 10
        Me.CountEmployee_lbl.Text = "0"
        '
        'EmployeeLV
        '
        Me.EmployeeLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.EmployeeLV.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.EmployeeLV.FullRowSelect = True
        Me.EmployeeLV.GridLines = True
        Me.EmployeeLV.HideSelection = False
        Me.EmployeeLV.Location = New System.Drawing.Point(12, 107)
        Me.EmployeeLV.Name = "EmployeeLV"
        Me.EmployeeLV.Size = New System.Drawing.Size(579, 380)
        Me.EmployeeLV.TabIndex = 1
        Me.EmployeeLV.UseCompatibleStateImageBehavior = False
        Me.EmployeeLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAME"
        Me.ColumnHeader2.Width = 207
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ADDRESS"
        Me.ColumnHeader3.Width = 217
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CONTACT"
        Me.ColumnHeader4.Width = 170
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Remove_btn)
        Me.GroupBox2.Controls.Add(Me.Refresh_btn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 94)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.SelectStore_cmb)
        Me.Panel3.Location = New System.Drawing.Point(6, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 72)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Store:"
        '
        'SelectStore_cmb
        '
        Me.SelectStore_cmb.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectStore_cmb.FormattingEnabled = True
        Me.SelectStore_cmb.Location = New System.Drawing.Point(109, 6)
        Me.SelectStore_cmb.Name = "SelectStore_cmb"
        Me.SelectStore_cmb.Size = New System.Drawing.Size(176, 24)
        Me.SelectStore_cmb.TabIndex = 6
        '
        'Remove_btn
        '
        Me.Remove_btn.BackColor = System.Drawing.Color.Transparent
        Me.Remove_btn.FlatAppearance.BorderSize = 0
        Me.Remove_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Remove_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remove_btn.ForeColor = System.Drawing.Color.Black
        Me.Remove_btn.Image = CType(resources.GetObject("Remove_btn.Image"), System.Drawing.Image)
        Me.Remove_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Remove_btn.Location = New System.Drawing.Point(440, 16)
        Me.Remove_btn.Name = "Remove_btn"
        Me.Remove_btn.Size = New System.Drawing.Size(129, 46)
        Me.Remove_btn.TabIndex = 8
        Me.Remove_btn.Text = " &Remove"
        Me.Remove_btn.UseVisualStyleBackColor = False
        '
        'Refresh_btn
        '
        Me.Refresh_btn.BackColor = System.Drawing.Color.Transparent
        Me.Refresh_btn.FlatAppearance.BorderSize = 0
        Me.Refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Refresh_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_btn.ForeColor = System.Drawing.Color.Black
        Me.Refresh_btn.Image = CType(resources.GetObject("Refresh_btn.Image"), System.Drawing.Image)
        Me.Refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Refresh_btn.Location = New System.Drawing.Point(305, 16)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(129, 46)
        Me.Refresh_btn.TabIndex = 5
        Me.Refresh_btn.Text = "  &Refresh"
        Me.Refresh_btn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckActive)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckInActive)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(109, 36)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(176, 25)
        Me.FlowLayoutPanel1.TabIndex = 12
        '
        'CheckActive
        '
        Me.CheckActive.AutoSize = True
        Me.CheckActive.Checked = True
        Me.CheckActive.Location = New System.Drawing.Point(3, 3)
        Me.CheckActive.Name = "CheckActive"
        Me.CheckActive.Size = New System.Drawing.Size(63, 17)
        Me.CheckActive.TabIndex = 8
        Me.CheckActive.TabStop = True
        Me.CheckActive.Text = "ACTIVE"
        Me.CheckActive.UseVisualStyleBackColor = True
        '
        'CheckInActive
        '
        Me.CheckInActive.AutoSize = True
        Me.CheckInActive.Location = New System.Drawing.Point(72, 3)
        Me.CheckInActive.Name = "CheckInActive"
        Me.CheckInActive.Size = New System.Drawing.Size(77, 17)
        Me.CheckInActive.TabIndex = 9
        Me.CheckInActive.Text = "IN-ACTIVE"
        Me.CheckInActive.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Status Type:"
        '
        'frmReportByStoreEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportByStoreEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Refresh_btn As Button
    Friend WithEvents EmployeeLV As ListView
    Friend WithEvents Remove_btn As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents CountEmployee_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Print_btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectStore_cmb As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CheckActive As RadioButton
    Friend WithEvents CheckInActive As RadioButton
    Friend WithEvents Label4 As Label
End Class
