Imports System.Drawing.Printing
Public Class CSVprinter
    Dim barcode, prodname, rate, psize As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Try

                Using reader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog1.FileName)
                    reader.TextFieldType = FileIO.FieldType.Delimited
                    reader.SetDelimiters(",")
                    While Not reader.EndOfData
                        Dim Fields() As String = reader.ReadFields
                        Dim item As New ListViewItem
                        item.Text = Fields(0)
                        For x = 1 To UBound(Fields)
                            item.SubItems.Add(Fields(x))
                        Next
                        ListView1.Items.Add(item)
                    End While
                End Using


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim c, f As Integer
        c = CInt(Me.TxtCopyCount.Value)
        Dim itm As ListViewItem

        If Me.CMBBarcodePrinter.Text = Nothing Then
            MsgBox("Please select printer")
        Else

            For Each itm In Me.ListView1.SelectedItems

                barcode = itm.SubItems(1).Text
                prodname = itm.SubItems(0).Text
                rate = itm.SubItems(3).Text
                psize = itm.SubItems(2).Text

                PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 236, 157)

                Me.PrintDocument1.PrinterSettings.PrinterName = CMBBarcodePrinter.Text
                For f = 1 To c
                    Me.PrintDocument1.Print()
                Next
                'Me.PrintPreviewDialog1.ShowDialog()



            Next


        End If


    End Sub

    Private Sub CMBBarcodePrinter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBarcodePrinter.SelectedIndexChanged
        My.Settings.CsvPrinter = Me.CMBBarcodePrinter.Text
        My.Settings.Save()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim img As Bitmap = Nothing
        Dim bw, bh As Integer
        Dim Cali As New StringFormat

        Cali.Alignment = StringAlignment.Center

        bw = 460
        bh = 300

        img = Form1.Generate_Barcode(barcode, bw, bh)

        Dim fnt As Font
        fnt = New Font("calibri", 10, FontStyle.Bold)
        Dim Ali As New StringFormat
        If My.Settings.PnameCenter = True Then
            Ali.Alignment = StringAlignment.Center
        Else
            Ali.Alignment = StringAlignment.Near
        End If

        e.Graphics.FillRectangle(Brushes.White, 1, 1, 236, 157)
        e.Graphics.DrawString(prodname, fnt, Brushes.Black, 118, 10, Cali)
        e.Graphics.DrawImage(img, 10, 35, 210, 50)
        e.Graphics.DrawString(barcode, fnt, Brushes.Black, 118, 90, Cali)
        e.Graphics.DrawString("Size : " & psize, fnt, Brushes.Black, 118, 110, Cali)
        If My.Settings.PrintRate = True Then
            e.Graphics.DrawString("AED" & " " & Format(CDbl(rate), "#,##.00"), fnt, Brushes.Black, 118, 130, Cali)
        End If


    End Sub

    Private Sub CSVprinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_all_printers()
        Me.CMBBarcodePrinter.Text = My.Settings.CsvPrinter
    End Sub

    Private Sub Get_all_printers()

        Me.CMBBarcodePrinter.Items.Clear()


        Dim iprinter As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1

            iprinter = PrinterSettings.InstalledPrinters.Item(i)
            Me.CMBBarcodePrinter.Items.Add(iprinter)

        Next
    End Sub
End Class