<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSVprinter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSVprinter))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Itm_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItmCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.CMBBarcodePrinter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCopyCount = New System.Windows.Forms.NumericUpDown()
        CType(Me.TxtCopyCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Itm_Name, Me.ItmCode, Me.Size, Me.Price})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(13, 42)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(921, 539)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Print Selected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Csv Files (*.csv)|*.csv"
        '
        'Itm_Name
        '
        Me.Itm_Name.Text = "Item Name"
        Me.Itm_Name.Width = 250
        '
        'ItmCode
        '
        Me.ItmCode.Text = "Barcode"
        Me.ItmCode.Width = 250
        '
        'Size
        '
        Me.Size.Text = "P Size"
        Me.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Size.Width = 100
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Price.Width = 100
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'CMBBarcodePrinter
        '
        Me.CMBBarcodePrinter.FormattingEnabled = True
        Me.CMBBarcodePrinter.Location = New System.Drawing.Point(374, 15)
        Me.CMBBarcodePrinter.Name = "CMBBarcodePrinter"
        Me.CMBBarcodePrinter.Size = New System.Drawing.Size(319, 21)
        Me.CMBBarcodePrinter.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Barcode Printer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(715, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Count"
        '
        'TxtCopyCount
        '
        Me.TxtCopyCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtCopyCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCopyCount.Location = New System.Drawing.Point(765, 7)
        Me.TxtCopyCount.Name = "TxtCopyCount"
        Me.TxtCopyCount.Size = New System.Drawing.Size(80, 30)
        Me.TxtCopyCount.TabIndex = 15
        Me.TxtCopyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCopyCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CSVprinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 616)
        Me.Controls.Add(Me.TxtCopyCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMBBarcodePrinter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CSVprinter"
        Me.Text = "Print From CSv"
        CType(Me.TxtCopyCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Itm_Name As ColumnHeader
    Friend WithEvents ItmCode As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents CMBBarcodePrinter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCopyCount As NumericUpDown
End Class
