<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaBeli = New System.Windows.Forms.TextBox()
        Me.ComboBoxMerk = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSatuan = New System.Windows.Forms.ComboBox()
        Me.TextBoxHargaJual = New System.Windows.Forms.TextBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.RadioButtonNamaBarang = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMerk = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSatuan = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonKoreksiStock = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Barang"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(150, 12)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(150, 38)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNama.TabIndex = 2
        '
        'TextBoxHargaBeli
        '
        Me.TextBoxHargaBeli.Location = New System.Drawing.Point(150, 118)
        Me.TextBoxHargaBeli.Name = "TextBoxHargaBeli"
        Me.TextBoxHargaBeli.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHargaBeli.TabIndex = 3
        '
        'ComboBoxMerk
        '
        Me.ComboBoxMerk.FormattingEnabled = True
        Me.ComboBoxMerk.Location = New System.Drawing.Point(150, 64)
        Me.ComboBoxMerk.Name = "ComboBoxMerk"
        Me.ComboBoxMerk.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMerk.TabIndex = 4
        '
        'ComboBoxSatuan
        '
        Me.ComboBoxSatuan.FormattingEnabled = True
        Me.ComboBoxSatuan.Location = New System.Drawing.Point(150, 91)
        Me.ComboBoxSatuan.Name = "ComboBoxSatuan"
        Me.ComboBoxSatuan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSatuan.TabIndex = 5
        '
        'TextBoxHargaJual
        '
        Me.TextBoxHargaJual.Location = New System.Drawing.Point(150, 144)
        Me.TextBoxHargaJual.Name = "TextBoxHargaJual"
        Me.TextBoxHargaJual.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHargaJual.TabIndex = 6
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(150, 170)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxStock.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Merk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Harga Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Harga Jual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Stock"
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(12, 196)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.Size = New System.Drawing.Size(760, 224)
        Me.DataGridViewBarang.TabIndex = 14
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Location = New System.Drawing.Point(562, 170)
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxCari.TabIndex = 15
        '
        'RadioButtonNamaBarang
        '
        Me.RadioButtonNamaBarang.AutoSize = True
        Me.RadioButtonNamaBarang.Location = New System.Drawing.Point(562, 145)
        Me.RadioButtonNamaBarang.Name = "RadioButtonNamaBarang"
        Me.RadioButtonNamaBarang.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonNamaBarang.TabIndex = 16
        Me.RadioButtonNamaBarang.TabStop = True
        Me.RadioButtonNamaBarang.Text = "Nama Barang"
        Me.RadioButtonNamaBarang.UseVisualStyleBackColor = True
        '
        'RadioButtonMerk
        '
        Me.RadioButtonMerk.AutoSize = True
        Me.RadioButtonMerk.Location = New System.Drawing.Point(658, 145)
        Me.RadioButtonMerk.Name = "RadioButtonMerk"
        Me.RadioButtonMerk.Size = New System.Drawing.Size(49, 17)
        Me.RadioButtonMerk.TabIndex = 17
        Me.RadioButtonMerk.TabStop = True
        Me.RadioButtonMerk.Text = "Merk"
        Me.RadioButtonMerk.UseVisualStyleBackColor = True
        '
        'RadioButtonSatuan
        '
        Me.RadioButtonSatuan.AutoSize = True
        Me.RadioButtonSatuan.Location = New System.Drawing.Point(713, 145)
        Me.RadioButtonSatuan.Name = "RadioButtonSatuan"
        Me.RadioButtonSatuan.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonSatuan.TabIndex = 18
        Me.RadioButtonSatuan.TabStop = True
        Me.RadioButtonSatuan.Text = "Satuan"
        Me.RadioButtonSatuan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(531, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cari"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 426)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 20
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(93, 426)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 21
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(175, 426)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 22
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(256, 426)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 23
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonKoreksiStock
        '
        Me.ButtonKoreksiStock.Location = New System.Drawing.Point(690, 426)
        Me.ButtonKoreksiStock.Name = "ButtonKoreksiStock"
        Me.ButtonKoreksiStock.Size = New System.Drawing.Size(82, 23)
        Me.ButtonKoreksiStock.TabIndex = 24
        Me.ButtonKoreksiStock.Text = "Koreksi Stock"
        Me.ButtonKoreksiStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonKoreksiStock.UseVisualStyleBackColor = True
        '
        'DataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.ButtonKoreksiStock)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButtonSatuan)
        Me.Controls.Add(Me.RadioButtonMerk)
        Me.Controls.Add(Me.RadioButtonNamaBarang)
        Me.Controls.Add(Me.TextBoxCari)
        Me.Controls.Add(Me.DataGridViewBarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.TextBoxHargaJual)
        Me.Controls.Add(Me.ComboBoxSatuan)
        Me.Controls.Add(Me.ComboBoxMerk)
        Me.Controls.Add(Me.TextBoxHargaBeli)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataBarang"
        Me.Text = "Data Barang"
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxHargaBeli As TextBox
    Friend WithEvents ComboBoxMerk As ComboBox
    Friend WithEvents ComboBoxSatuan As ComboBox
    Friend WithEvents TextBoxHargaJual As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents RadioButtonNamaBarang As RadioButton
    Friend WithEvents RadioButtonMerk As RadioButton
    Friend WithEvents RadioButtonSatuan As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonKoreksiStock As Button
End Class
