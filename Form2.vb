Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Printing

Public Class FormCetakDokumen
    Public Property PenghasilanBruto As Integer
    Public Property IuranPensiun As Integer
    Public Property BiayaJabatan As Integer
    Public Property StatusKawin As Boolean
    Public Property JumlahTanggungan As Integer
    Public Property PenghasilanNetto As String
    Public Property TotalPTKP As String
    Public Property PenghasilanKenaPajak As String
    Public Property PajakTerutang As String
    Public Property PajakTerutangSebulan As String

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMasaPajak.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f7 As New Font("Helvetica", 7, FontStyle.Regular)
        Dim f10 As New Font("Helvetica", 10, FontStyle.Regular)
        Dim f10b As New Font("Helvetica", 10, FontStyle.Bold)
        Dim f12b As New Font("Helvetica", 12, FontStyle.Bold)

        Dim leftMargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centerMargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightMargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String = "-------------------------------------------------------------------------------------------"
        Dim garisPendek As String = "---------------------------------------------------------------"
        Dim namaWajibPajak As String = If(String.IsNullOrEmpty(txtNamaWP.Text), "Universitas Siber Asia", txtNamaWP.Text)
        Dim tanggalDokumen As String = dateTanggalDokumen.Value.ToString("dd MMMM yyyy")
        Dim masaPajak As String = If(cmbMasaPajak.SelectedItem = "ALL", "Januari - Desember", cmbMasaPajak.SelectedItem)
        Dim stringStatus As String

        If (StatusKawin) Then
            stringStatus = "K"
        Else
            stringStatus = "TK"
        End If

        ' Template Cetakan
        e.Graphics.DrawString("Nota Perhitungan Pajak", f10b, Brushes.Black, centerMargin, 5, tengah)
        e.Graphics.DrawString(namaWajibPajak, f10, Brushes.Black, centerMargin, 25, tengah)
        e.Graphics.DrawString("Masa Pajak: " & masaPajak, f7, Brushes.Black, centerMargin, 45, tengah)
        e.Graphics.DrawString(garis, f7, Brushes.Black, centerMargin, 65, tengah)

        e.Graphics.DrawString("Penghasilan Bruto", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString("Rp. " & PenghasilanBruto.ToString("N0"), f10, Brushes.Black, rightMargin, 100, kanan)

        e.Graphics.DrawString("Biaya Jabatan", f10, Brushes.Black, 0, 125)
        e.Graphics.DrawString("Rp. " & BiayaJabatan.ToString("N0"), f10, Brushes.Red, rightMargin, 125, kanan)

        e.Graphics.DrawString("Iuran Pensiun", f10, Brushes.Black, 0, 150)
        e.Graphics.DrawString("Rp. " & IuranPensiun.ToString("N0"), f10, Brushes.Red, rightMargin, 150, kanan)

        e.Graphics.DrawString("Penghasilan Netto", f10, Brushes.Black, 0, 190)
        e.Graphics.DrawString("Rp. " & PenghasilanNetto, f10b, Brushes.Black, rightMargin, 190, kanan)

        e.Graphics.DrawString("PTKP (" & stringStatus & "/" & JumlahTanggungan.ToString() & ")", f10, Brushes.Black, 0, 215)
        e.Graphics.DrawString("Rp. " & TotalPTKP, f10, Brushes.Red, rightMargin, 215, kanan)

        e.Graphics.DrawString("PKP", f10, Brushes.Black, 0, 240)
        e.Graphics.DrawString("Rp. " & PenghasilanKenaPajak, f10b, Brushes.Black, rightMargin, 240, kanan)

        e.Graphics.DrawString("Pajak Terutang", f10, Brushes.Black, 0, 280)
        e.Graphics.DrawString("Rp. " & PajakTerutang, f10b, Brushes.Blue, rightMargin, 280, kanan)

        If (cmbMasaPajak.SelectedItem <> "ALL") Then
            e.Graphics.DrawString(garisPendek, f7, Brushes.Black, centerMargin, 305, tengah)
            e.Graphics.DrawString("Bulan: " & cmbMasaPajak.SelectedItem, f10, Brushes.Black, 0, 330)
            e.Graphics.DrawString("Rp. " & PajakTerutangSebulan, f10b, Brushes.Blue, rightMargin, 330, kanan)
        End If

        e.Graphics.DrawString("Dicetak pada: " & tanggalDokumen, f10, Brushes.Gray, rightMargin, 400, kanan)

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim PageSetup As New PageSettings With {
            .PaperSize = New PaperSize("Custom", 250, 500)
        }
        PD.DefaultPageSettings = PageSetup
    End Sub
End Class