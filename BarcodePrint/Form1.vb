
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports BarcodeLib
Imports System.Drawing.Printing


Public Class Form1
    Dim products_list As DataTable
    Dim request As HttpWebRequest
    Dim response As HttpWebResponse = Nothing
    Dim reader As StreamReader

    Public barcode, prodname, rate As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        products_list = New DataTable
        Get_products(My.Settings.Baseurl, My.Settings.AuthCode)
        Load_To_list()
        CMDsearch.Enabled = True

    End Sub


    Private Sub Load_To_list()

        Dim r As DataRow
        Dim itm As ListViewItem

        Me.ListView1.Items.Clear()
        For Each r In products_list.Rows

            itm = Me.ListView1.Items.Add(r("id"))
            itm.SubItems.Add(r("upc"))
            itm.SubItems.Add(r("name"))
            itm.SubItems.Add(r("selling_price"))
            itm.SubItems.Add(r("sku"))
            '[{"stock_id":"1","quantity":"4","id":"1","type":"product","name":"Custom bouquet","sku":"LIVBQ01","upc":"LIVBQ0000001","selling_price":"150.00","purchase_price":"0.00","brand_id":"1","category_id":"1","sub_category_id":"4","product_group_id":"1","unit_type":"1"},{"stock_id":"2","quantity":"-217","id":"2","type":"product","name":"Flowers","sku":"LIVBQ02","upc":"FL0000000001","selling_price":"100.00","purchase_price":"50.00","brand_id":"1","category_id":"1","sub_category_id":"4","product_group_id":"1","unit_type":"1"}]
        Next


    End Sub
    Public Function Generate_Barcode(st As String, blw As Integer, blh As Integer) As Bitmap

        Dim img As Bitmap = Nothing
        Dim brc As New Barcode

        brc.Alignment = BarcodeLib.AlignmentPositions.CENTER


        Dim typ As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED
        typ = BarcodeLib.TYPE.CODE128
        brc.BarWidth = 1

        brc.LabelFont = New Font("arial", 14, FontStyle.Bold)
        img = brc.Encode(typ, st, Color.Black, Color.White, 300, 50)

        Return img

    End Function

    Private Sub Get_products(url As String, AuthCode As String)


        Try
            Me.RichTextBox1.Visible = False

            ' Create the web request  
            request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Headers.Add("X-Auth-Token", AuthCode)
            ' Get response  
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            ' Get the response stream into a reader  
            reader = New StreamReader(response.GetResponseStream())
            ' Console application output  
            Dim s As String
            s = reader.ReadToEnd()
            Me.RichTextBox1.Text = s
            products_list = JsonConvert.DeserializeObject(Of DataTable)(s)
            ' MsgBox(products_list.Columns.Count)

        Catch ex As Exception

            If Not response Is Nothing Then response.Close()
            MsgBox("Connection Issue : " & ex.Message)
            Me.RichTextBox1.Visible = True
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CMDsearch.Click
        Load_To_list_search(Me.Cmbsearch.Text, Me.TextBox1.Text)
    End Sub


    Private Sub Load_To_list_search(Searchin As String, Val As String)

        Dim r As DataRow
        Dim itm As ListViewItem

        Me.ListView1.Items.Clear()
        Dim nr As Integer
        nr = 0
        Select Case Searchin
            Case "Barcode"
                nr = 5
            Case "Product Name"
                nr = 2
            Case "Prduct Code"
                nr = 3
        End Select

        Dim tstr As String
        For Each r In products_list.Rows

            tstr = r(nr)

            If tstr.ToString.Contains(Val) Then

                itm = Me.ListView1.Items.Add(r("id"))
                itm.SubItems.Add(r("upc"))
                itm.SubItems.Add(r("name"))
                itm.SubItems.Add(r("selling_price"))
                itm.SubItems.Add(r("sku"))

            End If

        Next

    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If Me.ListView1.SelectedItems.Count = 1 Then
            Create_preview(Mid(Me.ListView1.FocusedItem.SubItems(1).Text, 1, CInt(My.Settings.PnameLimit)), Me.ListView1.FocusedItem.SubItems(3).Text, Me.ListView1.FocusedItem.SubItems(2).Text)
        End If
    End Sub
    Private Sub Create_preview(txt As String, rate As String, pname As String)

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
        img = Generate_Barcode(txt, bw, bh)

        Dim g As Graphics = Graphics.FromImage(flag)

        g.FillRectangle(Brushes.White, 1, 1, CInt(My.Settings.StickerWidth) + 5, CInt(My.Settings.StickerHeight) + 5)
        g.DrawString(pname, fnt, Brushes.Black, My.Settings.PnameLeft, My.Settings.PnameTop, Ali)
        g.DrawString(txt, fnt, Brushes.Black, My.Settings.BarcodeWidth / 2, My.Settings.BarcodeTop + My.Settings.BarcodeHeight + 3, Ali)
        g.DrawImage(img, CInt(My.Settings.BarcodeLeft), CInt(My.Settings.BarcodeTop), CInt(My.Settings.BarcodeWidth), CInt(My.Settings.BarcodeHeight))
        g.DrawString(My.Settings.RatePrefix & " " & Format(CDbl(rate), "#,##.00"), fnt, Brushes.Black, My.Settings.RateLeft, My.Settings.RateTop)

        PictureBox1.Image = flag

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If Me.CMDsearch.Enabled = True And Me.TextBox1.Text <> "" Then
            Load_To_list_search(Me.Cmbsearch.Text, Me.TextBox1.Text)
        End If
    End Sub

    Public Sub Printbarcode()
        If My.Settings.DPrinter = Nothing Then
            MsgBox("Set printer before print")
        Else
            PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", CInt(My.Settings.StickerWidth) + 5, CInt(My.Settings.StickerHeight) + 5)
            Me.PrintDocument1.PrinterSettings.PrinterName = My.Settings.DPrinter
            Me.PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim img As Bitmap = Nothing
        Dim bw, bh As Integer
        Dim Cali As New StringFormat

        Cali.Alignment = StringAlignment.Center


        bw = CInt(My.Settings.BarcodeWidth)
        bh = CInt(My.Settings.BarcodeHeight)
        img = Generate_Barcode(Barcode, bw, bh)
        Dim fnt As Font
        fnt = New Font("calibri", 9, FontStyle.Bold)
        Dim Ali As New StringFormat
        If My.Settings.PnameCenter = True Then
            Ali.Alignment = StringAlignment.Center
        Else
            Ali.Alignment = StringAlignment.Near
        End If

        e.Graphics.FillRectangle(Brushes.White, 1, 1, CInt(My.Settings.StickerWidth), CInt(My.Settings.StickerHeight))
        e.Graphics.DrawString(Mid(prodname, 1, CInt(My.Settings.PnameLimit)), fnt, Brushes.Black, My.Settings.PnameLeft, My.Settings.PnameTop, Ali)
        e.Graphics.DrawString(Mid(prodname, 1, CInt(My.Settings.PnameLimit)), fnt, Brushes.Black, My.Settings.PnameLeft, My.Settings.PnameTop, Ali)
        e.Graphics.DrawImage(img, CInt(My.Settings.BarcodeLeft), CInt(My.Settings.BarcodeTop), CInt(My.Settings.BarcodeWidth - 10), CInt(My.Settings.BarcodeHeight))
        e.Graphics.DrawString(barcode, fnt, Brushes.Black, My.Settings.BarcodeWidth / 2 + My.Settings.BarcodeLeft, My.Settings.BarcodeTop + My.Settings.BarcodeHeight + 3, Cali)
        If My.Settings.PrintRate = True Then
            e.Graphics.DrawString(My.Settings.RatePrefix & " " & Format(CDbl(rate), "#,##.00"), fnt, Brushes.Black, My.Settings.RateLeft, My.Settings.RateTop)
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        settings.Show()
        settings.Activate()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CSVprinter.Show()
        CSVprinter.Activate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim itm As ListViewItem
        Dim f As Integer

        For Each itm In Me.ListView1.SelectedItems

            For f = 1 To CInt(Me.TxtCopyCount.Value)
                barcode = itm.SubItems(1).Text
                prodname = itm.SubItems(2).Text
                rate = itm.SubItems(3).Text
                Printbarcode()

            Next
        Next

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        ManualBarcode.Show()
        ManualBarcode.Activate()
    End Sub
End Class
