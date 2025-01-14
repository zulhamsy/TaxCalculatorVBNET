<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakDokumen
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
        lblTanggalDokumen = New Label()
        dateTanggalDokumen = New DateTimePicker()
        cmbMasaPajak = New ComboBox()
        lblMasaPajak = New Label()
        Button1 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        lblNamaWP = New Label()
        txtNamaWP = New TextBox()
        SuspendLayout()
        ' 
        ' lblTanggalDokumen
        ' 
        lblTanggalDokumen.AutoSize = True
        lblTanggalDokumen.Location = New Point(12, 28)
        lblTanggalDokumen.Name = "lblTanggalDokumen"
        lblTanggalDokumen.Size = New Size(130, 15)
        lblTanggalDokumen.TabIndex = 0
        lblTanggalDokumen.Text = "Pilih Tanggal Dokumen"
        ' 
        ' dateTanggalDokumen
        ' 
        dateTanggalDokumen.Location = New Point(12, 46)
        dateTanggalDokumen.Name = "dateTanggalDokumen"
        dateTanggalDokumen.Size = New Size(213, 23)
        dateTanggalDokumen.TabIndex = 1
        dateTanggalDokumen.Value = New Date(2025, 1, 14, 9, 26, 13, 0)
        ' 
        ' cmbMasaPajak
        ' 
        cmbMasaPajak.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMasaPajak.FormattingEnabled = True
        cmbMasaPajak.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember", "ALL"})
        cmbMasaPajak.Location = New Point(12, 185)
        cmbMasaPajak.Name = "cmbMasaPajak"
        cmbMasaPajak.Size = New Size(213, 23)
        cmbMasaPajak.TabIndex = 2
        ' 
        ' lblMasaPajak
        ' 
        lblMasaPajak.AutoSize = True
        lblMasaPajak.Location = New Point(12, 167)
        lblMasaPajak.Name = "lblMasaPajak"
        lblMasaPajak.Size = New Size(66, 15)
        lblMasaPajak.TabIndex = 3
        lblMasaPajak.Text = "Masa Pajak"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 35)
        Button1.TabIndex = 4
        Button1.Text = "Cetak"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblNamaWP
        ' 
        lblNamaWP.AutoSize = True
        lblNamaWP.Location = New Point(12, 96)
        lblNamaWP.Name = "lblNamaWP"
        lblNamaWP.Size = New Size(103, 15)
        lblNamaWP.TabIndex = 5
        lblNamaWP.Text = "Nama Wajib Pajak"
        ' 
        ' txtNamaWP
        ' 
        txtNamaWP.Location = New Point(12, 114)
        txtNamaWP.Name = "txtNamaWP"
        txtNamaWP.Size = New Size(213, 23)
        txtNamaWP.TabIndex = 6
        ' 
        ' FormCetakDokumen
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 336)
        Controls.Add(txtNamaWP)
        Controls.Add(lblNamaWP)
        Controls.Add(Button1)
        Controls.Add(lblMasaPajak)
        Controls.Add(cmbMasaPajak)
        Controls.Add(dateTanggalDokumen)
        Controls.Add(lblTanggalDokumen)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Location = New Point(20000, 20000)
        MaximizeBox = False
        Name = "FormCetakDokumen"
        Text = "Konfirmasi Cetak Dokumen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTanggalDokumen As Label
    Friend WithEvents dateTanggalDokumen As DateTimePicker
    Friend WithEvents cmbMasaPajak As ComboBox
    Friend WithEvents lblMasaPajak As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lblNamaWP As Label
    Friend WithEvents txtNamaWP As TextBox
End Class
