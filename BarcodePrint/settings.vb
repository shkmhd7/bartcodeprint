Imports System.Drawing.Printing

Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_all_printers()
        GetSettings()
    End Sub

    Private Sub GetSettings()

        Me.TxtStickerWidth.Text = My.Settings.StickerWidth
        Me.TxtStickerHeight.Text = My.Settings.StickerHeight

        Me.TxtBarcodeLeft.Text = My.Settings.BarcodeLeft
        Me.TxtBarcodeTop.Text = My.Settings.BarcodeTop
        Me.TxtBarcodeWidth.Text = My.Settings.BarcodeWidth
        Me.TxtBarcodeHeight.Text = My.Settings.BarcodeHeight

        Me.TxtPnameLeft.Text = My.Settings.PnameLeft
        Me.TxtPnameTop.Text = My.Settings.PnameTop
        Me.TxtPnameLimit.Text = My.Settings.PnameLimit

        Me.TxtRateLeft.Text = My.Settings.RateLeft
        Me.TxtRateTop.Text = My.Settings.RateTop
        Me.TxtRatePrefix.Text = My.Settings.RatePrefix

        Me.CMBBarcodePrinter.Text = My.Settings.DPrinter
        Me.TxtURL.Text = My.Settings.Baseurl
        Me.TxtTocken.Text = My.Settings.AuthCode

        If My.Settings.PrintName = True Then
            Me.ChkPrintName.Checked = True
        Else
            Me.ChkPrintName.Checked = False
        End If

        If My.Settings.PrintRate = True Then
            Me.ChkprintRate.Checked = True
        Else
            Me.ChkprintRate.Checked = False
        End If


        If My.Settings.PnameCenter = True Then
            Me.ChkCenter.Checked = True
        Else
            Me.ChkCenter.Checked = False
        End If



        If My.Settings.BarcodeGenrateMode = "S" Then
            Me.RDseq.Checked = True
        Else
            Me.RDrand.Checked = True
        End If
        Me.TxtCharCount.Text = My.Settings.BarcodeNCount
        Me.TxtStartNumber.Text = My.Settings.LastBarcode
        Me.TxtBarPrefix.Text = My.Settings.BarcodePrefix
        Me.TxtBarSufix.Text = My.Settings.BarcodeSuffix


    End Sub



    Private Sub SaveSettings()


        My.Settings.StickerWidth = Me.TxtStickerWidth.Text
        My.Settings.StickerHeight = Me.TxtStickerHeight.Text

        My.Settings.BarcodeLeft = Me.TxtBarcodeLeft.Text
        My.Settings.BarcodeTop = Me.TxtBarcodeTop.Text
        My.Settings.BarcodeWidth = Me.TxtBarcodeWidth.Text
        My.Settings.BarcodeHeight = Me.TxtBarcodeHeight.Text

        My.Settings.PnameLeft = Me.TxtPnameLeft.Text
        My.Settings.PnameTop = Me.TxtPnameTop.Text
        My.Settings.PnameLimit = Me.TxtPnameLimit.Text

        My.Settings.RateLeft = Me.TxtRateLeft.Text
        My.Settings.RateTop = Me.TxtRateTop.Text
        My.Settings.RatePrefix = Me.TxtRatePrefix.Text

        My.Settings.DPrinter = Me.CMBBarcodePrinter.Text
        My.Settings.Baseurl = Me.TxtURL.Text
        My.Settings.AuthCode = Me.TxtTocken.Text

        If Me.ChkPrintName.Checked = True Then

            My.Settings.PrintName = True
        Else
            My.Settings.PrintName = False
        End If

        If Me.ChkprintRate.Checked = True Then

            My.Settings.PrintRate = True
        Else
            My.Settings.PrintRate = False
        End If

        If Me.ChkCenter.Checked = True Then

            My.Settings.PnameCenter = True
        Else
            My.Settings.PnameCenter = False
        End If

        If Me.RDseq.Checked = True Then
            My.Settings.BarcodeGenrateMode = "S"
        Else
            My.Settings.BarcodeGenrateMode = "R"
        End If
        My.Settings.BarcodeNCount = CInt(Me.TxtCharCount.Text)
        My.Settings.LastBarcode = CInt(Me.TxtStartNumber.Text)
        My.Settings.BarcodePrefix = Me.TxtBarPrefix.Text
        My.Settings.BarcodeSuffix = Me.TxtBarSufix.Text


        My.Settings.Save()
        Me.Close()

        MsgBox("Setting Saved")

    End Sub

    Private Sub Get_all_printers()

        Me.CMBBarcodePrinter.Items.Clear()


        Dim iprinter As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1

            iprinter = PrinterSettings.InstalledPrinters.Item(i)
            Me.CMBBarcodePrinter.Items.Add(iprinter)

        Next
    End Sub
    Private Sub Create_preview()

        Dim fnt As Font
        fnt = New Font("calibri", 9, FontStyle.Bold)
        Dim Ali As New StringFormat
        Dim cali As New StringFormat
        cali.Alignment = StringAlignment.Center
        Dim flag As New Bitmap(CInt(Me.TxtStickerWidth.Text) + 5, CInt(Me.TxtStickerHeight.Text) + 5)

        If Me.ChkCenter.Checked = True Then
            Ali.Alignment = StringAlignment.Center
        Else
            Ali.Alignment = StringAlignment.Near
        End If

        Dim img As Bitmap = Nothing
        Dim bw, bh As Integer
        bw = CInt(My.Settings.BarcodeWidth)
        bh = CInt(My.Settings.BarcodeHeight)
        img = Form1.Generate_Barcode(Me.TxtSampleText.Text, bw, bh)

        Dim g As Graphics = Graphics.FromImage(flag)

        g.FillRectangle(Brushes.White, 1, 1, CInt(Me.TxtStickerWidth.Text) + 5, CInt(Me.TxtStickerHeight.Text) + 5)
        g.DrawString(Me.TxtSampleText.Text, fnt, Brushes.Black, Me.TxtPnameLeft.Text, Me.TxtPnameTop.Text, Ali)
        g.DrawImage(img, CInt(Me.TxtBarcodeLeft.Text), CInt(Me.TxtBarcodeTop.Text), CInt(Me.TxtBarcodeWidth.Text), CInt(Me.TxtBarcodeHeight.Text))
        g.DrawString(Me.TxtSampleText.Text, fnt, Brushes.Black, (TxtBarcodeWidth.Text / 2) + TxtBarcodeLeft.Text, (TxtBarcodeTop.Text + TxtBarcodeHeight.Text + 3), cali)
        g.DrawString(Me.TxtRatePrefix.Text & " " & "1,234.00", fnt, Brushes.Black, Me.TxtRateLeft.Text, Me.TxtRateTop.Text)

        PictureBox1.Image = flag

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSettings()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Create_preview()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim Cali As New StringFormat
        Cali.Alignment = StringAlignment.Center
        Dim fnt As Font
        fnt = New Font("calibri", 9, FontStyle.Bold)
        Dim Ali As New StringFormat
        If Me.ChkCenter.Checked = True Then
            Ali.Alignment = StringAlignment.Center
        Else
            Ali.Alignment = StringAlignment.Near
        End If

        Dim img As Bitmap = Nothing
        Dim bw, bh As Integer
        bw = CInt(My.Settings.BarcodeWidth)
        bh = CInt(My.Settings.BarcodeHeight)
        img = Form1.Generate_Barcode(Me.TxtSampleText.Text, bw, bh)

        e.Graphics.FillRectangle(Brushes.White, 1, 1, CInt(Me.TxtStickerWidth.Text) + 5, CInt(Me.TxtStickerHeight.Text) + 5)
        e.Graphics.DrawString(Me.TxtSampleText.Text, fnt, Brushes.Black, Me.TxtPnameLeft.Text, Me.TxtPnameTop.Text, Ali)
        e.Graphics.DrawImage(img, CInt(Me.TxtBarcodeLeft.Text), CInt(Me.TxtBarcodeTop.Text), CInt(Me.TxtBarcodeWidth.Text), CInt(Me.TxtBarcodeHeight.Text))
        e.Graphics.DrawString(Me.TxtSampleText.Text, fnt, Brushes.Black, CInt(Me.TxtBarcodeWidth.Text) / 2 + CInt(TxtBarcodeLeft.Text), CInt(TxtBarcodeTop.Text) + CInt(TxtBarcodeHeight.Text) + 3, Cali)
        e.Graphics.DrawString(Me.TxtRatePrefix.Text & " " & "1,234.00", fnt, Brushes.Black, Me.TxtRateLeft.Text, Me.TxtRateTop.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.CMBBarcodePrinter.Text = Nothing Then
            MsgBox("Set printer before print")
        Else
            PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", CInt(Me.TxtStickerWidth.Text) + 5, CInt(Me.TxtStickerHeight.Text) + 5)
            Me.PrintDocument1.PrinterSettings.PrinterName = Me.CMBBarcodePrinter.Text
            Me.PrintDocument1.Print()

        End If
    End Sub
End Class