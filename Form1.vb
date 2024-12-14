Public Class lblNetto
    Const PTKP = 54000000
    Const PTKP_TANGGUNGAN = 4500000
    Const TARIF_BIAYA_JABATAN = 0.05
    Const MAX_BIAYA_JABATAN = 6000000

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Width = 418
    End Sub

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim iPenghasilan As Integer
        Dim iIuran As Integer
        Dim boolIsKawin As Boolean
        Dim byteJumlahAnak As Tanggungan.JumlahTanggungan
        Dim iPenghasilanNetto As Integer
        Dim iTotalPTKP As Integer
        Dim iPenghasilanKenaPajak As Integer
        Dim iPajak As Integer

        ' Cek apakah status kawin/tidak kawin sudah dipilih
        If radioKawin.Checked = False And radioTidakKawin.Checked = False Then
            MessageBox.Show("Status harus dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek apakah jumlah tanggungan sudah dipilih (radio button)
        If radioTanggungan0.Checked = False And
            radioTanggungan1.Checked = False And
            radioTanggungan2.Checked = False And
            radioTanggungan3.Checked = False Then
            MessageBox.Show("Jumlah tanggungan harus dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Assign Penghasilan Bruto
        If Not Integer.TryParse(txtPenghasilan.Text, iPenghasilan) Then
            txtPenghasilan.Text = 0
            iPenghasilan = 0
        End If

        ' Assign Iuran Pensiun
        If Not Integer.TryParse(txtIuranPensiun.Text, iIuran) Then
            txtIuranPensiun.Text = 0
            iIuran = 0
        End If

        ' Assign boolIsKawin
        If radioKawin.Checked Then
            boolIsKawin = True
        Else
            boolIsKawin = False
        End If

        ' Assign Jumlah Tanggungan
        If radioTanggungan0.Checked Then
            byteJumlahAnak = Tanggungan.JumlahTanggungan.TidakAda
        ElseIf radioTanggungan1.Checked Then
            byteJumlahAnak = Tanggungan.JumlahTanggungan.Satu
        ElseIf radioTanggungan2.Checked Then
            byteJumlahAnak = Tanggungan.JumlahTanggungan.Dua
        ElseIf radioTanggungan3.Checked Then
            byteJumlahAnak = Tanggungan.JumlahTanggungan.Tiga
        End If

        iPenghasilanNetto = HitungPenghasilanNetto(iPenghasilan, iIuran)
        iTotalPTKP = HitungPTKP(boolIsKawin, byteJumlahAnak)
        iPenghasilanKenaPajak = roundDownToThousands(iPenghasilanNetto - iTotalPTKP)
        iPajak = HitungPajakPenghasilan(iPenghasilanKenaPajak)

        'MessageBox.Show("Nih Netto Lu " & iPenghasilanNetto.ToString("N0"))
        'MessageBox.Show("Nih PTKP Lu " & iTotalPTKP.ToString("N0"))
        'MessageBox.Show("Nih PKP Lu " & iPenghasilanKenaPajak.ToString("N0"))
        'MessageBox.Show("Nih Pajak Lu " & iPajak.ToString("N0"))

        ' Ubah width container
        MyBase.Width = 921
        lblPlaceholderNetto.Text = iPenghasilanNetto.ToString("N0")
        lblPlaceholderPTKP.Text = iTotalPTKP.ToString("N0")
        lblPlaceholderPkp.Text = iPenghasilanKenaPajak.ToString("N0")
        lblPlaceholderTerutang.Text = iPajak.ToString("N0")
        lblPlaceholderTerutangBulan.Text = (iPajak / 12).ToString("N0")
        lblPlaceholderTarifEfektif.Text = ((iPajak / 12) / iPenghasilan * 100).ToString("N2") & "%"

    End Sub

    Private Function HitungPenghasilanNetto(ByVal iPenghasilanBruto As Integer, ByVal iIuran As Integer) As Integer
        Dim iPenghasilanBrutoSetahun = iPenghasilanBruto * 12
        Dim iBiayaJabatan As Integer

        ' Hitung Biaya Jabatan
        If iPenghasilanBrutoSetahun * TARIF_BIAYA_JABATAN > MAX_BIAYA_JABATAN Then
            iBiayaJabatan = MAX_BIAYA_JABATAN
        Else
            iBiayaJabatan = iPenghasilanBrutoSetahun * TARIF_BIAYA_JABATAN
        End If

        Return iPenghasilanBrutoSetahun - iBiayaJabatan - iIuran

    End Function

    Private Function HitungPTKP(ByVal boolIsKawin As Boolean, ByVal byteJumlahAnak As Tanggungan.JumlahTanggungan) As Integer
        If boolIsKawin Then
            Return PTKP + PTKP_TANGGUNGAN * (byteJumlahAnak + 1)
        Else
            Return PTKP + PTKP_TANGGUNGAN * byteJumlahAnak
        End If
    End Function

    Private Function HitungPajakPenghasilan(ByVal iPenghasilanKenaPajak As Integer) As Integer
        Const LAYER_1 = 60_000_000
        Const LAYER_2 = 250_000_000
        Const LAYER_3 = 500_000_000
        Const LAYER_4 = 1_000_000_000
        Const TARIF_1 = 0.05
        Const TARIF_2 = 0.15
        Const TARIF_3 = 0.25
        Const TARIF_4 = 0.3
        Const TARIF_5 = 0.35

        Dim iPajak As Integer = 0
        Dim iRemainingPKP As Integer = 0

        If iPenghasilanKenaPajak <= 0 Then
            Return 0
        End If

        ' Calculate tax for the first layer
        If iPenghasilanKenaPajak > LAYER_1 Then
            iPajak += LAYER_1 * TARIF_1
            iRemainingPKP = iPenghasilanKenaPajak - LAYER_1
        Else
            iPajak += iPenghasilanKenaPajak * TARIF_1
            Return iPajak
        End If

        ' Calculate tax for second layer
        If iRemainingPKP > LAYER_2 Then
            iPajak += LAYER_2 * TARIF_2
            iRemainingPKP = iRemainingPKP - LAYER_2
        Else
            iPajak += iRemainingPKP * TARIF_2
            Return iPajak
        End If

        ' Calculate tax for third layer
        If iRemainingPKP > LAYER_3 Then
            iPajak += LAYER_3 * TARIF_3
            iRemainingPKP = iRemainingPKP - LAYER_3
        Else
            iPajak += iRemainingPKP * TARIF_3
            Return iPajak
        End If

        ' Calculate tax for fourth layer
        If iRemainingPKP > LAYER_4 Then
            iPajak += LAYER_4 * TARIF_4
            iRemainingPKP = iRemainingPKP - LAYER_4
        Else
            iPajak += iRemainingPKP * TARIF_4
            Return iPajak
        End If

        ' Calculate the rest (if remaining still present)
        If iRemainingPKP Then
            iPajak += TARIF_5 * iRemainingPKP
            Return iPajak
        End If

        Return iPajak
    End Function

    Private Function roundDownToThousands(ByVal iNumber As Integer) As Integer
        Return Math.Floor(iNumber / 1000) * 1000
    End Function

    Private Sub TxtPenghasilan_Changed(sender As Object, e As EventArgs) Handles txtPenghasilan.TextChanged
        ' Hanya menerima input angka
        If Not IsNumeric(txtPenghasilan.Text) Then
            MessageBox.Show("Hanya menerima angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPenghasilan.Text = 0
        End If
    End Sub

    Private Sub TxtIuran_Changed(sender As Object, e As EventArgs) Handles txtIuranPensiun.TextChanged
        ' Hanya menerima input angka
        If Not IsNumeric(txtIuranPensiun.Text) Then
            MessageBox.Show("Hanya menerima angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIuranPensiun.Text = 0
        End If
    End Sub
End Class

Public Class Tanggungan
    Enum JumlahTanggungan
        TidakAda = 0
        Satu = 1
        Dua = 2
        Tiga = 3
    End Enum
End Class