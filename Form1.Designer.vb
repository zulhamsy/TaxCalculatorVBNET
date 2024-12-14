<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lblNetto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblPenghasilan = New Label()
        txtPenghasilan = New TextBox()
        txtIuranPensiun = New TextBox()
        lblIuranPensiun = New Label()
        gboxStatus = New GroupBox()
        radioTidakKawin = New RadioButton()
        radioKawin = New RadioButton()
        gboxTanggungan = New GroupBox()
        radioTanggungan1 = New RadioButton()
        radioTanggungan3 = New RadioButton()
        radioTanggungan2 = New RadioButton()
        radioTanggungan0 = New RadioButton()
        btnHitung = New Button()
        lblBruto = New Label()
        lblOpsional = New Label()
        lblVersion = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblPlaceholderNetto = New Label()
        lblPTKP = New Label()
        lblPlaceholderPTKP = New Label()
        lblPKP = New Label()
        lblPlaceholderPkp = New Label()
        Label5 = New Label()
        lblPlaceholderTerutang = New Label()
        Label6 = New Label()
        lblPlaceholderTerutangBulan = New Label()
        Label7 = New Label()
        lblPlaceholderTarifEfektif = New Label()
        Label8 = New Label()
        Label9 = New Label()
        gboxStatus.SuspendLayout()
        gboxTanggungan.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPenghasilan
        ' 
        lblPenghasilan.AutoSize = True
        lblPenghasilan.Location = New Point(12, 25)
        lblPenghasilan.Name = "lblPenghasilan"
        lblPenghasilan.Size = New Size(124, 15)
        lblPenghasilan.TabIndex = 0
        lblPenghasilan.Text = "Penghasilan per Bulan"
        ' 
        ' txtPenghasilan
        ' 
        txtPenghasilan.Location = New Point(12, 43)
        txtPenghasilan.MaxLength = 20
        txtPenghasilan.Name = "txtPenghasilan"
        txtPenghasilan.PlaceholderText = "diisi dalam Rupiah"
        txtPenghasilan.RightToLeft = RightToLeft.No
        txtPenghasilan.Size = New Size(300, 23)
        txtPenghasilan.TabIndex = 1
        txtPenghasilan.TextAlign = HorizontalAlignment.Right
        txtPenghasilan.WordWrap = False
        ' 
        ' txtIuranPensiun
        ' 
        txtIuranPensiun.Location = New Point(12, 107)
        txtIuranPensiun.MaxLength = 20
        txtIuranPensiun.Name = "txtIuranPensiun"
        txtIuranPensiun.PlaceholderText = "diisi dalam Rupiah"
        txtIuranPensiun.Size = New Size(300, 23)
        txtIuranPensiun.TabIndex = 3
        txtIuranPensiun.TextAlign = HorizontalAlignment.Right
        txtIuranPensiun.WordWrap = False
        ' 
        ' lblIuranPensiun
        ' 
        lblIuranPensiun.AutoSize = True
        lblIuranPensiun.Location = New Point(12, 89)
        lblIuranPensiun.Name = "lblIuranPensiun"
        lblIuranPensiun.Size = New Size(132, 15)
        lblIuranPensiun.TabIndex = 2
        lblIuranPensiun.Text = "Iuran Pensiun per Bulan"
        ' 
        ' gboxStatus
        ' 
        gboxStatus.Controls.Add(radioTidakKawin)
        gboxStatus.Controls.Add(radioKawin)
        gboxStatus.Location = New Point(12, 156)
        gboxStatus.Name = "gboxStatus"
        gboxStatus.Size = New Size(210, 80)
        gboxStatus.TabIndex = 11
        gboxStatus.TabStop = False
        gboxStatus.Text = "Status"
        ' 
        ' radioTidakKawin
        ' 
        radioTidakKawin.AutoSize = True
        radioTidakKawin.Location = New Point(95, 38)
        radioTidakKawin.Name = "radioTidakKawin"
        radioTidakKawin.Size = New Size(88, 19)
        radioTidakKawin.TabIndex = 8
        radioTidakKawin.TabStop = True
        radioTidakKawin.Text = "Tidak Kawin"
        radioTidakKawin.UseVisualStyleBackColor = True
        ' 
        ' radioKawin
        ' 
        radioKawin.AutoSize = True
        radioKawin.Location = New Point(20, 38)
        radioKawin.Name = "radioKawin"
        radioKawin.Size = New Size(57, 19)
        radioKawin.TabIndex = 7
        radioKawin.TabStop = True
        radioKawin.Text = "Kawin"
        radioKawin.UseVisualStyleBackColor = True
        ' 
        ' gboxTanggungan
        ' 
        gboxTanggungan.Controls.Add(radioTanggungan1)
        gboxTanggungan.Controls.Add(radioTanggungan3)
        gboxTanggungan.Controls.Add(radioTanggungan2)
        gboxTanggungan.Controls.Add(radioTanggungan0)
        gboxTanggungan.Location = New Point(12, 255)
        gboxTanggungan.Name = "gboxTanggungan"
        gboxTanggungan.Size = New Size(300, 80)
        gboxTanggungan.TabIndex = 12
        gboxTanggungan.TabStop = False
        gboxTanggungan.Text = "Jumlah Tanggungan"
        ' 
        ' radioTanggungan1
        ' 
        radioTanggungan1.AutoSize = True
        radioTanggungan1.Location = New Point(95, 38)
        radioTanggungan1.Name = "radioTanggungan1"
        radioTanggungan1.Size = New Size(31, 19)
        radioTanggungan1.TabIndex = 10
        radioTanggungan1.TabStop = True
        radioTanggungan1.Text = "1"
        radioTanggungan1.UseVisualStyleBackColor = True
        ' 
        ' radioTanggungan3
        ' 
        radioTanggungan3.AutoSize = True
        radioTanggungan3.Location = New Point(246, 38)
        radioTanggungan3.Name = "radioTanggungan3"
        radioTanggungan3.Size = New Size(31, 19)
        radioTanggungan3.TabIndex = 9
        radioTanggungan3.TabStop = True
        radioTanggungan3.Text = "3"
        radioTanggungan3.UseVisualStyleBackColor = True
        ' 
        ' radioTanggungan2
        ' 
        radioTanggungan2.AutoSize = True
        radioTanggungan2.Location = New Point(170, 38)
        radioTanggungan2.Name = "radioTanggungan2"
        radioTanggungan2.Size = New Size(31, 19)
        radioTanggungan2.TabIndex = 8
        radioTanggungan2.TabStop = True
        radioTanggungan2.Text = "2"
        radioTanggungan2.UseVisualStyleBackColor = True
        ' 
        ' radioTanggungan0
        ' 
        radioTanggungan0.AutoSize = True
        radioTanggungan0.Location = New Point(20, 38)
        radioTanggungan0.Name = "radioTanggungan0"
        radioTanggungan0.Size = New Size(31, 19)
        radioTanggungan0.TabIndex = 7
        radioTanggungan0.TabStop = True
        radioTanggungan0.Text = "0"
        radioTanggungan0.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.BackColor = Color.LightBlue
        btnHitung.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHitung.ForeColor = Color.DarkSlateGray
        btnHitung.Location = New Point(12, 371)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(158, 47)
        btnHitung.TabIndex = 13
        btnHitung.Text = "Hitung Pajak"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' lblBruto
        ' 
        lblBruto.AutoSize = True
        lblBruto.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblBruto.ForeColor = SystemColors.ControlDark
        lblBruto.Location = New Point(134, 25)
        lblBruto.Name = "lblBruto"
        lblBruto.Size = New Size(43, 15)
        lblBruto.TabIndex = 14
        lblBruto.Text = "(bruto)"
        ' 
        ' lblOpsional
        ' 
        lblOpsional.AutoSize = True
        lblOpsional.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblOpsional.ForeColor = SystemColors.ControlDark
        lblOpsional.Location = New Point(141, 89)
        lblOpsional.Name = "lblOpsional"
        lblOpsional.Size = New Size(59, 15)
        lblOpsional.TabIndex = 15
        lblOpsional.Text = "(opsional)"
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblVersion.ForeColor = SystemColors.ControlDark
        lblVersion.Location = New Point(12, 449)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(88, 15)
        lblVersion.TabIndex = 16
        lblVersion.Text = "v.1.0.14.12.2024"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(12, 464)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 15)
        Label1.TabIndex = 17
        Label1.Text = "Property of UNSIA Visual Programming - Internal Use Only"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(12, 479)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 15)
        Label2.TabIndex = 18
        Label2.Text = "Developed by Akbari, Avira, Zulham"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(467, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 15)
        Label3.TabIndex = 19
        Label3.Text = "Perhitungan Pajak Penghasilan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(467, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 20
        Label4.Text = "Penghasilan Netto"
        ' 
        ' lblPlaceholderNetto
        ' 
        lblPlaceholderNetto.AutoSize = True
        lblPlaceholderNetto.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaceholderNetto.ForeColor = SystemColors.ControlText
        lblPlaceholderNetto.ImageAlign = ContentAlignment.MiddleRight
        lblPlaceholderNetto.Location = New Point(780, 60)
        lblPlaceholderNetto.Name = "lblPlaceholderNetto"
        lblPlaceholderNetto.Size = New Size(102, 15)
        lblPlaceholderNetto.TabIndex = 21
        lblPlaceholderNetto.Text = "Placeholder Netto"
        lblPlaceholderNetto.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPTKP
        ' 
        lblPTKP.AutoSize = True
        lblPTKP.ForeColor = SystemColors.ControlDarkDark
        lblPTKP.Location = New Point(467, 89)
        lblPTKP.Name = "lblPTKP"
        lblPTKP.Size = New Size(162, 15)
        lblPTKP.TabIndex = 22
        lblPTKP.Text = "Penghasilan Tidak Kena Pajak"
        ' 
        ' lblPlaceholderPTKP
        ' 
        lblPlaceholderPTKP.AutoSize = True
        lblPlaceholderPTKP.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaceholderPTKP.ForeColor = SystemColors.ControlText
        lblPlaceholderPTKP.Location = New Point(780, 89)
        lblPlaceholderPTKP.Name = "lblPlaceholderPTKP"
        lblPlaceholderPTKP.Size = New Size(100, 15)
        lblPlaceholderPTKP.TabIndex = 23
        lblPlaceholderPTKP.Text = "Placeholder PTKP"
        lblPlaceholderPTKP.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPKP
        ' 
        lblPKP.AutoSize = True
        lblPKP.ForeColor = SystemColors.ControlDarkDark
        lblPKP.Location = New Point(467, 119)
        lblPKP.Name = "lblPKP"
        lblPKP.Size = New Size(198, 15)
        lblPKP.TabIndex = 24
        lblPKP.Text = "Penghasilan Kena Pajak (dibulatkan)"
        ' 
        ' lblPlaceholderPkp
        ' 
        lblPlaceholderPkp.AutoSize = True
        lblPlaceholderPkp.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaceholderPkp.ForeColor = SystemColors.ControlText
        lblPlaceholderPkp.Location = New Point(780, 119)
        lblPlaceholderPkp.Name = "lblPlaceholderPkp"
        lblPlaceholderPkp.Size = New Size(93, 15)
        lblPlaceholderPkp.TabIndex = 25
        lblPlaceholderPkp.Text = "Placeholder PKP"
        lblPlaceholderPkp.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(467, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 15)
        Label5.TabIndex = 26
        Label5.Text = "Pajak Terutang (setahun)"
        ' 
        ' lblPlaceholderTerutang
        ' 
        lblPlaceholderTerutang.AutoSize = True
        lblPlaceholderTerutang.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaceholderTerutang.ForeColor = SystemColors.ControlText
        lblPlaceholderTerutang.Location = New Point(780, 194)
        lblPlaceholderTerutang.Name = "lblPlaceholderTerutang"
        lblPlaceholderTerutang.Size = New Size(119, 15)
        lblPlaceholderTerutang.TabIndex = 27
        lblPlaceholderTerutang.Text = "Placeholder Terutang"
        lblPlaceholderTerutang.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.ControlDarkDark
        Label6.Location = New Point(467, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 15)
        Label6.TabIndex = 28
        Label6.Text = "Pajak Terutang (per bulan)"
        ' 
        ' lblPlaceholderTerutangBulan
        ' 
        lblPlaceholderTerutangBulan.AutoSize = True
        lblPlaceholderTerutangBulan.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaceholderTerutangBulan.ForeColor = SystemColors.ControlText
        lblPlaceholderTerutangBulan.Location = New Point(780, 221)
        lblPlaceholderTerutangBulan.Name = "lblPlaceholderTerutangBulan"
        lblPlaceholderTerutangBulan.Size = New Size(119, 15)
        lblPlaceholderTerutangBulan.TabIndex = 29
        lblPlaceholderTerutangBulan.Text = "Placeholder Terutang"
        lblPlaceholderTerutangBulan.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlDarkDark
        Label7.Location = New Point(467, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 15)
        Label7.TabIndex = 30
        Label7.Text = "Tarif Efektif"
        ' 
        ' lblPlaceholderTarifEfektif
        ' 
        lblPlaceholderTarifEfektif.AutoSize = True
        lblPlaceholderTarifEfektif.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaceholderTarifEfektif.ForeColor = SystemColors.ControlText
        lblPlaceholderTarifEfektif.Location = New Point(780, 249)
        lblPlaceholderTarifEfektif.Name = "lblPlaceholderTarifEfektif"
        lblPlaceholderTarifEfektif.Size = New Size(119, 15)
        lblPlaceholderTarifEfektif.TabIndex = 31
        lblPlaceholderTarifEfektif.Text = "Placeholder Terutang"
        lblPlaceholderTarifEfektif.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        Label8.ForeColor = SystemColors.ControlDark
        Label8.Location = New Point(467, 371)
        Label8.Name = "Label8"
        Label8.Size = New Size(368, 15)
        Label8.TabIndex = 32
        Label8.Text = "Untuk ketentuan dan peraturan lebih lengkap. Dapat merujuk pada"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        Label9.ForeColor = SystemColors.ControlDark
        Label9.Location = New Point(467, 391)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 15)
        Label9.TabIndex = 33
        Label9.Text = "PMK 168/PMK.03/2023"
        ' 
        ' lblNetto
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(911, 506)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(lblPlaceholderTarifEfektif)
        Controls.Add(Label7)
        Controls.Add(lblPlaceholderTerutangBulan)
        Controls.Add(Label6)
        Controls.Add(lblPlaceholderTerutang)
        Controls.Add(Label5)
        Controls.Add(lblPlaceholderPkp)
        Controls.Add(lblPKP)
        Controls.Add(lblPlaceholderPTKP)
        Controls.Add(lblPTKP)
        Controls.Add(lblPlaceholderNetto)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblVersion)
        Controls.Add(lblOpsional)
        Controls.Add(lblBruto)
        Controls.Add(btnHitung)
        Controls.Add(gboxTanggungan)
        Controls.Add(gboxStatus)
        Controls.Add(txtIuranPensiun)
        Controls.Add(lblIuranPensiun)
        Controls.Add(txtPenghasilan)
        Controls.Add(lblPenghasilan)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "lblNetto"
        Text = "Kalkulator Pajak Penghasilan Pegawai Tetap"
        gboxStatus.ResumeLayout(False)
        gboxStatus.PerformLayout()
        gboxTanggungan.ResumeLayout(False)
        gboxTanggungan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnShitty As Button
    Friend WithEvents lblPenghasilan As Label
    Friend WithEvents txtPenghasilan As TextBox
    Friend WithEvents txtIuranPensiun As TextBox
    Friend WithEvents lblIuranPensiun As Label
    Friend WithEvents gboxStatus As GroupBox
    Friend WithEvents radioTidakKawin As RadioButton
    Friend WithEvents radioKawin As RadioButton
    Friend WithEvents gboxTanggungan As GroupBox
    Friend WithEvents radioTanggungan2 As RadioButton
    Friend WithEvents radioTanggungan0 As RadioButton
    Friend WithEvents radioTanggungan3 As RadioButton
    Friend WithEvents radioTanggungan1 As RadioButton
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblBruto As Label
    Friend WithEvents lblOpsional As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPlaceholderNetto As Label
    Friend WithEvents lblPTKP As Label
    Friend WithEvents lblPlaceholderPTKP As Label
    Friend WithEvents lblPKP As Label
    Friend WithEvents lblPlaceholderPkp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPlaceholderTerutang As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPlaceholderTerutangBulan As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPlaceholderTarifEfektif As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class
