Imports System.Runtime.InteropServices

Public Class PrintDirect
    Private Declare Function ClosePrinter Lib "winspool.drv" (ByVal hPrinter As Integer) As Integer
    Private Declare Function EndDocPrinter Lib "winspool.drv" (ByVal hPrinter As Integer) As Integer
    Private Declare Function EndPagePrinter Lib "winspool.drv" (ByVal hPrinter As Integer) As Integer
    Private Declare Function OpenPrinter Lib "winspool.drv" Alias "OpenPrinterA" (ByVal pPrinterName As String, ByRef phPrinter As Integer, ByVal pDefault As Integer) As Integer
    <Security.SecurityCritical>
    Private Declare Function StartDocPrinter Lib "winspool.drv" Alias "StartDocPrinterA" (ByVal hPrinter As Integer, ByVal Level As Integer, ByRef pDocInfo As DocInformation) As Integer
    Private Declare Function StartPagePrinter Lib "winspool.drv" (ByVal hPrinter As Integer) As Integer

    Private Declare Function WritePrinter Lib "winspool.drv" (ByVal hPrinter As Integer, ByVal pBuffer As String, ByVal cdBuffer As Integer, ByRef pcWritten As Integer) As Integer

    Private Structure DocInformation
        Dim DocName As String
        Dim OutputFile As String
        Dim Datatype As String
    End Structure


    Public Shared Sub Print(ByVal pPrinter As String, ByVal DatosImprimir As String)
        Dim DocInf As New DocInformation
        Dim lpcWritten As Integer
        Dim lhPrinter As Integer
        DocInf.DocName = "Impresion Desde AsVentas"
        DocInf.Datatype = "RAW"

        Try
            OpenPrinter(pPrinter, lhPrinter, 0)
            StartDocPrinter(lhPrinter, 1, DocInf)
            StartPagePrinter(lhPrinter)

            'If Debugger.IsAttached Then
            '    MsgBox(DatosImprimir)
            'Else
            WritePrinter(lhPrinter, DatosImprimir, DatosImprimir.Length, lpcWritten)
            'End If


        Catch ex As Exception
            MsgBox("Error en Impresion Directa " & ex.Message)
        Finally
            EndPagePrinter(lhPrinter)
            EndDocPrinter(lhPrinter)
            ClosePrinter(lhPrinter)
        End Try
    End Sub


End Class
