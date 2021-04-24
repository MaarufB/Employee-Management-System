<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeeFile
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
        Me.FileLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Copy_btn = New System.Windows.Forms.Button()
        Me.Load_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.countFile = New System.Windows.Forms.Label()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(855, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE FILES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FileLV
        '
        Me.FileLV.BackColor = System.Drawing.Color.White
        Me.FileLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.FileLV.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileLV.FullRowSelect = True
        Me.FileLV.GridLines = True
        Me.FileLV.HideSelection = False
        Me.FileLV.Location = New System.Drawing.Point(17, 80)
        Me.FileLV.Name = "FileLV"
        Me.FileLV.Size = New System.Drawing.Size(786, 478)
        Me.FileLV.TabIndex = 2
        Me.FileLV.UseCompatibleStateImageBehavior = False
        Me.FileLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "FULL NAME"
        Me.ColumnHeader5.Width = 279
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FILE NAME"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DESCRIPTION"
        Me.ColumnHeader4.Width = 300
        '
        'Add_btn
        '
        Me.Add_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Add_btn.FlatAppearance.BorderSize = 0
        Me.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_btn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Add_btn.ForeColor = System.Drawing.Color.White
        Me.Add_btn.Location = New System.Drawing.Point(407, 11)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(116, 42)
        Me.Add_btn.TabIndex = 3
        Me.Add_btn.Text = "&ADD"
        Me.Add_btn.UseVisualStyleBackColor = False
        '
        'Copy_btn
        '
        Me.Copy_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Copy_btn.FlatAppearance.BorderSize = 0
        Me.Copy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Copy_btn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Copy_btn.ForeColor = System.Drawing.Color.White
        Me.Copy_btn.Location = New System.Drawing.Point(529, 11)
        Me.Copy_btn.Name = "Copy_btn"
        Me.Copy_btn.Size = New System.Drawing.Size(116, 42)
        Me.Copy_btn.TabIndex = 4
        Me.Copy_btn.Text = "&COPY"
        Me.Copy_btn.UseVisualStyleBackColor = False
        '
        'Load_btn
        '
        Me.Load_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Load_btn.FlatAppearance.BorderSize = 0
        Me.Load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Load_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_btn.ForeColor = System.Drawing.Color.White
        Me.Load_btn.Location = New System.Drawing.Point(271, 17)
        Me.Load_btn.Name = "Load_btn"
        Me.Load_btn.Size = New System.Drawing.Size(77, 28)
        Me.Load_btn.TabIndex = 5
        Me.Load_btn.Text = "&Refresh"
        Me.Load_btn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.countFile)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.FileLV)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 596)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 565)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TOTAL FILE/S"
        '
        'countFile
        '
        Me.countFile.AutoSize = True
        Me.countFile.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countFile.Location = New System.Drawing.Point(148, 565)
        Me.countFile.Name = "countFile"
        Me.countFile.Size = New System.Drawing.Size(17, 17)
        Me.countFile.TabIndex = 8
        Me.countFile.Text = "0"
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Delete_btn.FlatAppearance.BorderSize = 0
        Me.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_btn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Delete_btn.ForeColor = System.Drawing.Color.White
        Me.Delete_btn.Location = New System.Drawing.Point(651, 11)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(116, 42)
        Me.Delete_btn.TabIndex = 9
        Me.Delete_btn.Text = "&DELETE"
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Delete_btn)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Add_btn)
        Me.GroupBox2.Controls.Add(Me.Copy_btn)
        Me.GroupBox2.Controls.Add(Me.Load_btn)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(17, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 59)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(77, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 25)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Type here to search..."
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(827, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(27, 35)
        Me.CloseButton.TabIndex = 82
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'frmEmployeeFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(855, 668)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeeFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FileLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Add_btn As Button
    Friend WithEvents Copy_btn As Button
    Friend WithEvents Load_btn As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents countFile As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents Delete_btn As Button
End Class
