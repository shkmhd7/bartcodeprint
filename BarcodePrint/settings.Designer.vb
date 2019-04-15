<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.TxtTocken = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBBarcodePrinter = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtStickerHeight = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtStickerWidth = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtBarcodeTop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBarcodeLeft = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBarcodeHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBarcodeWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkCenter = New System.Windows.Forms.CheckBox()
        Me.TxtPnameLimit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPnameTop = New System.Windows.Forms.TextBox()
        Me.ChkPrintName = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPnameLeft = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtRatePrefix = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtRateTop = New System.Windows.Forms.TextBox()
        Me.ChkprintRate = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtRateLeft = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtSampleText = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RDseq = New System.Windows.Forms.RadioButton()
        Me.RDrand = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtStartNumber = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtBarPrefix = New System.Windows.Forms.TextBox()
        Me.TxtBarSufix = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtCharCount = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URL"
        '
        'TxtURL
        '
        Me.TxtURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtURL.Location = New System.Drawing.Point(85, 19)
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(708, 26)
        Me.TxtURL.TabIndex = 1
        '
        'TxtTocken
        '
        Me.TxtTocken.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTocken.Location = New System.Drawing.Point(85, 48)
        Me.TxtTocken.Name = "TxtTocken"
        Me.TxtTocken.Size = New System.Drawing.Size(327, 26)
        Me.TxtTocken.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Auth Tocken"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTocken)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtURL)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(802, 86)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Link Settings"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(684, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Barcode Printer"
        '
        'CMBBarcodePrinter
        '
        Me.CMBBarcodePrinter.FormattingEnabled = True
        Me.CMBBarcodePrinter.Location = New System.Drawing.Point(93, 19)
        Me.CMBBarcodePrinter.Name = "CMBBarcodePrinter"
        Me.CMBBarcodePrinter.Size = New System.Drawing.Size(319, 21)
        Me.CMBBarcodePrinter.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtStickerHeight)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TxtStickerWidth)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtBarcodeTop)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtBarcodeLeft)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtBarcodeHeight)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtBarcodeWidth)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CMBBarcodePrinter)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 166)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barcode"
        '
        'TxtStickerHeight
        '
        Me.TxtStickerHeight.Location = New System.Drawing.Point(239, 65)
        Me.TxtStickerHeight.Name = "TxtStickerHeight"
        Me.TxtStickerHeight.Size = New System.Drawing.Size(83, 20)
        Me.TxtStickerHeight.TabIndex = 17
        Me.TxtStickerHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(183, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Height"
        '
        'TxtStickerWidth
        '
        Me.TxtStickerWidth.Location = New System.Drawing.Point(94, 65)
        Me.TxtStickerWidth.Name = "TxtStickerWidth"
        Me.TxtStickerWidth.Size = New System.Drawing.Size(83, 20)
        Me.TxtStickerWidth.TabIndex = 14
        Me.TxtStickerWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Sticker Width"
        '
        'TxtBarcodeTop
        '
        Me.TxtBarcodeTop.Location = New System.Drawing.Point(239, 135)
        Me.TxtBarcodeTop.Name = "TxtBarcodeTop"
        Me.TxtBarcodeTop.Size = New System.Drawing.Size(83, 20)
        Me.TxtBarcodeTop.TabIndex = 13
        Me.TxtBarcodeTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Top"
        '
        'TxtBarcodeLeft
        '
        Me.TxtBarcodeLeft.Location = New System.Drawing.Point(94, 135)
        Me.TxtBarcodeLeft.Name = "TxtBarcodeLeft"
        Me.TxtBarcodeLeft.Size = New System.Drawing.Size(83, 20)
        Me.TxtBarcodeLeft.TabIndex = 10
        Me.TxtBarcodeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Barcode Left"
        '
        'TxtBarcodeHeight
        '
        Me.TxtBarcodeHeight.Location = New System.Drawing.Point(239, 111)
        Me.TxtBarcodeHeight.Name = "TxtBarcodeHeight"
        Me.TxtBarcodeHeight.Size = New System.Drawing.Size(83, 20)
        Me.TxtBarcodeHeight.TabIndex = 9
        Me.TxtBarcodeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Height"
        '
        'TxtBarcodeWidth
        '
        Me.TxtBarcodeWidth.Location = New System.Drawing.Point(94, 111)
        Me.TxtBarcodeWidth.Name = "TxtBarcodeWidth"
        Me.TxtBarcodeWidth.Size = New System.Drawing.Size(83, 20)
        Me.TxtBarcodeWidth.TabIndex = 4
        Me.TxtBarcodeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Barcode width"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkCenter)
        Me.GroupBox3.Controls.Add(Me.TxtPnameLimit)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtPnameTop)
        Me.GroupBox3.Controls.Add(Me.ChkPrintName)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtPnameLeft)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 123)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Print Name"
        '
        'ChkCenter
        '
        Me.ChkCenter.AutoSize = True
        Me.ChkCenter.Location = New System.Drawing.Point(110, 19)
        Me.ChkCenter.Name = "ChkCenter"
        Me.ChkCenter.Size = New System.Drawing.Size(57, 17)
        Me.ChkCenter.TabIndex = 20
        Me.ChkCenter.Text = "Center"
        Me.ChkCenter.UseVisualStyleBackColor = True
        '
        'TxtPnameLimit
        '
        Me.TxtPnameLimit.Location = New System.Drawing.Point(110, 100)
        Me.TxtPnameLimit.Name = "TxtPnameLimit"
        Me.TxtPnameLimit.Size = New System.Drawing.Size(83, 20)
        Me.TxtPnameLimit.TabIndex = 19
        Me.TxtPnameLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Product name Top"
        '
        'TxtPnameTop
        '
        Me.TxtPnameTop.Location = New System.Drawing.Point(110, 74)
        Me.TxtPnameTop.Name = "TxtPnameTop"
        Me.TxtPnameTop.Size = New System.Drawing.Size(83, 20)
        Me.TxtPnameTop.TabIndex = 17
        Me.TxtPnameTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkPrintName
        '
        Me.ChkPrintName.AutoSize = True
        Me.ChkPrintName.Checked = True
        Me.ChkPrintName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPrintName.Location = New System.Drawing.Point(10, 20)
        Me.ChkPrintName.Name = "ChkPrintName"
        Me.ChkPrintName.Size = New System.Drawing.Size(78, 17)
        Me.ChkPrintName.TabIndex = 0
        Me.ChkPrintName.Text = "Print Name"
        Me.ChkPrintName.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Charactor Limit"
        '
        'TxtPnameLeft
        '
        Me.TxtPnameLeft.Location = New System.Drawing.Point(110, 48)
        Me.TxtPnameLeft.Name = "TxtPnameLeft"
        Me.TxtPnameLeft.Size = New System.Drawing.Size(83, 20)
        Me.TxtPnameLeft.TabIndex = 14
        Me.TxtPnameLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Product name Left"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtRatePrefix)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TxtRateTop)
        Me.GroupBox4.Controls.Add(Me.ChkprintRate)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TxtRateLeft)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(224, 286)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 123)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Print Rate"
        '
        'TxtRatePrefix
        '
        Me.TxtRatePrefix.Location = New System.Drawing.Point(110, 100)
        Me.TxtRatePrefix.Name = "TxtRatePrefix"
        Me.TxtRatePrefix.Size = New System.Drawing.Size(83, 20)
        Me.TxtRatePrefix.TabIndex = 19
        Me.TxtRatePrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Rate Top"
        '
        'TxtRateTop
        '
        Me.TxtRateTop.Location = New System.Drawing.Point(110, 74)
        Me.TxtRateTop.Name = "TxtRateTop"
        Me.TxtRateTop.Size = New System.Drawing.Size(83, 20)
        Me.TxtRateTop.TabIndex = 17
        Me.TxtRateTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkprintRate
        '
        Me.ChkprintRate.AutoSize = True
        Me.ChkprintRate.Checked = True
        Me.ChkprintRate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkprintRate.Location = New System.Drawing.Point(10, 20)
        Me.ChkprintRate.Name = "ChkprintRate"
        Me.ChkprintRate.Size = New System.Drawing.Size(68, 17)
        Me.ChkprintRate.TabIndex = 0
        Me.ChkprintRate.Text = "Print rate"
        Me.ChkprintRate.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Print prefix"
        '
        'TxtRateLeft
        '
        Me.TxtRateLeft.Location = New System.Drawing.Point(110, 48)
        Me.TxtRateLeft.Name = "TxtRateLeft"
        Me.TxtRateLeft.Size = New System.Drawing.Size(83, 20)
        Me.TxtRateLeft.TabIndex = 14
        Me.TxtRateLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Rate Left"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(464, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 183)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'TxtSampleText
        '
        Me.TxtSampleText.Location = New System.Drawing.Point(478, 327)
        Me.TxtSampleText.Name = "TxtSampleText"
        Me.TxtSampleText.Size = New System.Drawing.Size(327, 20)
        Me.TxtSampleText.TabIndex = 4
        Me.TxtSampleText.Text = "SAMPLE123456"
        Me.TxtSampleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(478, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 34)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(675, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 34)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Print Sample"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.TxtCharCount)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TxtBarSufix)
        Me.GroupBox5.Controls.Add(Me.TxtBarPrefix)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.TxtStartNumber)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.RDrand)
        Me.GroupBox5.Controls.Add(Me.RDseq)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 415)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(418, 199)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Barcode Generator"
        '
        'RDseq
        '
        Me.RDseq.AutoSize = True
        Me.RDseq.Location = New System.Drawing.Point(16, 47)
        Me.RDseq.Name = "RDseq"
        Me.RDseq.Size = New System.Drawing.Size(74, 17)
        Me.RDseq.TabIndex = 0
        Me.RDseq.TabStop = True
        Me.RDseq.Text = "Sequance"
        Me.RDseq.UseVisualStyleBackColor = True
        '
        'RDrand
        '
        Me.RDrand.AutoSize = True
        Me.RDrand.Location = New System.Drawing.Point(96, 47)
        Me.RDrand.Name = "RDrand"
        Me.RDrand.Size = New System.Drawing.Size(65, 17)
        Me.RDrand.TabIndex = 1
        Me.RDrand.TabStop = True
        Me.RDrand.Text = "Random"
        Me.RDrand.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Barcode Number Generate Mode"
        '
        'TxtStartNumber
        '
        Me.TxtStartNumber.Location = New System.Drawing.Point(163, 108)
        Me.TxtStartNumber.Name = "TxtStartNumber"
        Me.TxtStartNumber.Size = New System.Drawing.Size(110, 20)
        Me.TxtStartNumber.TabIndex = 19
        Me.TxtStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Number Start From"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Barcode Prefix"
        '
        'TxtBarPrefix
        '
        Me.TxtBarPrefix.Location = New System.Drawing.Point(163, 135)
        Me.TxtBarPrefix.Name = "TxtBarPrefix"
        Me.TxtBarPrefix.Size = New System.Drawing.Size(110, 20)
        Me.TxtBarPrefix.TabIndex = 22
        Me.TxtBarPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBarSufix
        '
        Me.TxtBarSufix.Location = New System.Drawing.Point(163, 162)
        Me.TxtBarSufix.Name = "TxtBarSufix"
        Me.TxtBarSufix.Size = New System.Drawing.Size(110, 20)
        Me.TxtBarSufix.TabIndex = 24
        Me.TxtBarSufix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 165)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Barcode Sufix"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Character Count"
        '
        'TxtCharCount
        '
        Me.TxtCharCount.Location = New System.Drawing.Point(163, 81)
        Me.TxtCharCount.Name = "TxtCharCount"
        Me.TxtCharCount.Size = New System.Drawing.Size(61, 20)
        Me.TxtCharCount.TabIndex = 26
        Me.TxtCharCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 630)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtSampleText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents TxtTocken As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBBarcodePrinter As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtBarcodeTop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBarcodeLeft As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBarcodeHeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBarcodeWidth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtPnameLimit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPnameTop As TextBox
    Friend WithEvents ChkPrintName As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPnameLeft As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtRatePrefix As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtRateTop As TextBox
    Friend WithEvents ChkprintRate As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtRateLeft As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtSampleText As TextBox
    Friend WithEvents ChkCenter As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtStickerHeight As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtStickerWidth As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtCharCount As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtBarSufix As TextBox
    Friend WithEvents TxtBarPrefix As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtStartNumber As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents RDrand As RadioButton
    Friend WithEvents RDseq As RadioButton
End Class
