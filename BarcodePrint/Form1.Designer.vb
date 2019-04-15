<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.pSlno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pbarcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Prate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CMDsearch = New System.Windows.Forms.Button()
        Me.Cmbsearch = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtCopyCount = New System.Windows.Forms.NumericUpDown()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCopyCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sync"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pSlno, Me.Pbarcode, Me.Pname, Me.Prate, Me.Pcode})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(15, 116)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(802, 348)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'pSlno
        '
        Me.pSlno.Text = "Slno"
        Me.pSlno.Width = 80
        '
        'Pbarcode
        '
        Me.Pbarcode.Text = "Barcode"
        Me.Pbarcode.Width = 200
        '
        'Pname
        '
        Me.Pname.Text = "Product name"
        Me.Pname.Width = 250
        '
        'Prate
        '
        Me.Prate.Text = "Rate"
        Me.Prate.Width = 110
        '
        'Pcode
        '
        Me.Pcode.Text = "Pcode"
        Me.Pcode.Width = 160
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(62, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(458, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(15, 470)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 149)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'CMDsearch
        '
        Me.CMDsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMDsearch.Enabled = False
        Me.CMDsearch.Location = New System.Drawing.Point(715, 78)
        Me.CMDsearch.Name = "CMDsearch"
        Me.CMDsearch.Size = New System.Drawing.Size(102, 32)
        Me.CMDsearch.TabIndex = 6
        Me.CMDsearch.Text = "Search Now"
        Me.CMDsearch.UseVisualStyleBackColor = True
        '
        'Cmbsearch
        '
        Me.Cmbsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmbsearch.FormattingEnabled = True
        Me.Cmbsearch.Items.AddRange(New Object() {"Barcode", "Product Name", "Prduct Code"})
        Me.Cmbsearch.Location = New System.Drawing.Point(526, 84)
        Me.Cmbsearch.Name = "Cmbsearch"
        Me.Cmbsearch.Size = New System.Drawing.Size(183, 21)
        Me.Cmbsearch.TabIndex = 7
        Me.Cmbsearch.Text = "Barcode"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(375, 558)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 52)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(715, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 52)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Settings"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "No of Copy"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(497, 470)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(320, 149)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(599, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 52)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Manual Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtCopyCount
        '
        Me.TxtCopyCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtCopyCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCopyCount.Location = New System.Drawing.Point(388, 515)
        Me.TxtCopyCount.Name = "TxtCopyCount"
        Me.TxtCopyCount.Size = New System.Drawing.Size(80, 30)
        Me.TxtCopyCount.TabIndex = 14
        Me.TxtCopyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCopyCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(483, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 52)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "CSV"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(830, 631)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TxtCopyCount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Cmbsearch)
        Me.Controls.Add(Me.CMDsearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Print Barcode"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCopyCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Pbarcode As ColumnHeader
    Friend WithEvents Pname As ColumnHeader
    Friend WithEvents Prate As ColumnHeader
    Friend WithEvents Pcode As ColumnHeader
    Friend WithEvents pSlno As ColumnHeader
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CMDsearch As Button
    Friend WithEvents Cmbsearch As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtCopyCount As NumericUpDown
    Friend WithEvents Button5 As Button
End Class
