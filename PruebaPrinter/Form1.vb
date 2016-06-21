Imports Microsoft.Office.Interop.Excel
Imports ExcelWrapper
Public Class Form1
    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click
        Dim Printer, DatosImprimir As String
        Dim Bold As String = Chr(27) & Chr(69), unBold As String = Chr(27) & Chr(70)
        Dim Condensed As String = Chr(15), unCondensed As String = Chr(18)

        'Chr(14), double size

        DatosImprimir = IIf(EscCheckBox.Checked, Chr(29) & "!" & Chr(CharNumericUpDown.Value), "") & TextBox1.Text & vbCr & vbCr & vbCr

        'DatosImprimir = IIf(EscCheckBox.Checked, Chr(27) & "!" & CharNumericUpDown.Value, "") & TextBox1.Text & vbCr & vbCr & vbCr




        PrintDirect.Print(ImpresoraTextBox.Text, DatosImprimir)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim prm As New PrintDialog
        prm.ShowDialog()
        ImpresoraTextBox.Text = prm.PrinterSettings.PrinterName

        Dim excel As New Application()

        Dim w As New Workbook()
        Dim formato As Integer = 39 ' w.FileFormat.xlExcel5
        w.Sheets.Add()

        w.SaveAs("hola.xls", formato)
    End Sub
End Class
