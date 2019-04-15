Public Class ManualBarcode

    Private Sub ManualBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Create_preview(Me.Txtpname.Text, Me.TxtBarcode.Text, Me.TxtRate.Text)
    End Sub

    Private Sub Create_preview(PN As String, txt As String, rate As String)

        If txt = Nothing Then
            txt = "SAMPLE12345"
        End If

        If rate = Nothing Then
            rate = 0
        End If

        Dim fnt As Font
        fnt = New Font("calibri", 9, FontStyle.Bold)
        Dim Ali As New StringFormat

        Dim flag As New Bitmap(CInt(My.Settings.StickerWidth) + 5, CInt(My.Settings.StickerWidth) + 5)

        If My.Settings.PnameCenter = True Then
            Ali.Alignment = StringAlignment.Center
        Else
            Ali.Alignment = StringAlignment.Near
        End If

        Dim img As Bitmap = Nothing
        Dim bw, bh As Integer
        bw = CInt(My.Settings.BarcodeWidth)
        bh = CInt(My.Settings.BarcodeHeight)
        img = Form1.Generate_Barcode(txt, bw, bh)

        Dim g As Graphics = Graphics.FromImage(flag)

        g.FillRectangle(Brushes.White, 1, 1, CInt(My.Settings.StickerWidth) + 5, CInt(My.Settings.StickerHeight) + 5)
        g.DrawString(PN, fnt, Brushes.Black, My.Settings.PnameLeft, My.Settings.PnameTop, Ali)
        g.DrawImage(img, CInt(My.Settings.BarcodeLeft), CInt(My.Settings.BarcodeTop), CInt(My.Settings.BarcodeWidth), CInt(My.Settings.BarcodeHeight))
        g.DrawString(My.Settings.RatePrefix & " " & Format(CDbl(rate), "#,##.00"), fnt, Brushes.Black, My.Settings.RateLeft, My.Settings.RateTop)

        PictureBox1.Image = flag

    End Sub

    Private Sub TxtSampleText_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged

    End Sub

    Private Sub TxtSampleText_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtBarcode.KeyUp
        If IsNumeric(Me.TxtRate.Text) Then
            Create_preview(Me.Txtpname.Text, Me.TxtBarcode.Text, Me.TxtRate.Text)
        Else
            MsgBox("Text not allowed in rate")

        End If

    End Sub

    Private Sub TxtRate_TextChanged(sender As Object, e As EventArgs) Handles TxtRate.TextChanged

    End Sub

    Private Sub TxtRate_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtRate.KeyUp
        If IsNumeric(Me.TxtRate.Text) Then
            Create_preview(Me.Txtpname.Text, Me.TxtBarcode.Text, Me.TxtRate.Text)
        Else
            MsgBox("Text not allowed in rate")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(Me.TxtRate.Text) Then

            Form1.barcode = Me.TxtBarcode.Text
            Form1.prodname = Me.Txtpname.Text
            Form1.rate = Me.TxtRate.Text
            Dim n As Integer

            For n = 1 To CInt(Me.NumericUpDown1.Value)
                Form1.Printbarcode()
            Next

        Else
            MsgBox("Please enter valid value")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim br, c As Integer
        Dim RandGen As New Random
        c = My.Settings.BarcodeNCount

        If My.Settings.BarcodeGenrateMode = "S" Then

            br = My.Settings.LastBarcode
            br = br + 1
            My.Settings.LastBarcode = br
            My.Settings.Save()

            Me.TxtBarcode.Text = My.Settings.BarcodePrefix & br & My.Settings.BarcodeSuffix
        Else
            Me.TxtBarcode.Text = My.Settings.BarcodePrefix & RandGen.Next(10000, 100000).ToString() & My.Settings.BarcodeSuffix

        End If
        Create_preview(Me.Txtpname.Text, Me.TxtBarcode.Text, Me.TxtRate.Text)
    End Sub

    Private Sub Txtpname_TextChanged(sender As Object, e As EventArgs) Handles Txtpname.TextChanged
        If IsNumeric(Me.TxtRate.Text) Then
            Create_preview(Me.Txtpname.Text, Me.TxtBarcode.Text, Me.TxtRate.Text)
        Else
            MsgBox("Text not allowed in rate")

        End If
    End Sub
End Class