<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStore
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.StoreNameTxt = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.countStore = New System.Windows.Forms.Label()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Search_txt = New System.Windows.Forms.TextBox()
        Me.StoreLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.TitleTxt.Size = New System.Drawing.Size(402, 46)
        Me.TitleTxt.TabIndex = 82
        Me.TitleTxt.Text = "STORE"
        Me.TitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.StoreNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 132)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DeleteBtn)
        Me.GroupBox3.Controls.Add(Me.Edit)
        Me.GroupBox3.Controls.Add(Me.CancelBtn)
        Me.GroupBox3.Controls.Add(Me.SaveBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 71)
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
        'StoreNameTxt
        '
        Me.StoreNameTxt.Enabled = False
        Me.StoreNameTxt.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.StoreNameTxt.ForeColor = System.Drawing.Color.Black
        Me.StoreNameTxt.Location = New System.Drawing.Point(16, 41)
        Me.StoreNameTxt.Name = "StoreNameTxt"
        Me.StoreNameTxt.Size = New System.Drawing.Size(348, 25)
        Me.StoreNameTxt.TabIndex = 80
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(12, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 18)
        Me.Label29.TabIndex = 79
        Me.Label29.Text = "Store Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.countStore)
        Me.GroupBox2.Controls.Add(Me.LoadBtn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Search_txt)
        Me.GroupBox2.Controls.Add(Me.StoreLV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 250)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "STORE :"
        '
        'countStore
        '
        Me.countStore.AutoSize = True
        Me.countStore.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countStore.Location = New System.Drawing.Point(105, 226)
        Me.countStore.Name = "countStore"
        Me.countStore.Size = New System.Drawing.Size(17, 17)
        Me.countStore.TabIndex = 94
        Me.countStore.Text = "0"
        '
        'LoadBtn
        '
        Me.LoadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.LoadBtn.FlatAppearance.BorderSize = 0
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.LoadBtn.ForeColor = System.Drawing.Color.White
        Me.LoadBtn.Location = New System.Drawing.Point(248, 13)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(81, 23)
        Me.LoadBtn.TabIndex = 93
        Me.LoadBtn.Text = "&Refresh"
        Me.LoadBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(45, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Search"
        '
        'Search_txt
        '
        Me.Search_txt.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Search_txt.ForeColor = System.Drawing.Color.DimGray
        Me.Search_txt.Location = New System.Drawing.Point(102, 16)
        Me.Search_txt.Name = "Search_txt"
        Me.Search_txt.Size = New System.Drawing.Size(133, 20)
        Me.Search_txt.TabIndex = 84
        '
        'StoreLV
        '
        Me.StoreLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.StoreLV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreLV.FullRowSelect = True
        Me.StoreLV.GridLines = True
        Me.StoreLV.HideSelection = False
        Me.StoreLV.Location = New System.Drawing.Point(24, 41)
        Me.StoreLV.Name = "StoreLV"
        Me.StoreLV.Size = New System.Drawing.Size(324, 182)
        Me.StoreLV.TabIndex = 84
        Me.StoreLV.UseCompatibleStateImageBehavior = False
        Me.StoreLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAME OF STORE"
        Me.ColumnHeader2.Width = 360
        '
        'frmStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 447)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleTxt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Edit As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents StoreNameTxt As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LoadBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Search_txt As TextBox
    Friend WithEvents StoreLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents countStore As Label
End Class
