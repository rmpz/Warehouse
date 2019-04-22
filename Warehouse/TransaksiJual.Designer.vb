<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiJual
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNamaPembeli = New System.Windows.Forms.TextBox()
        Me.ButtonBarang = New System.Windows.Forms.Button()
        Me.ComboBoxID = New System.Windows.Forms.ComboBox()
        Me.TextBoxHargaJual = New System.Windows.Forms.TextBox()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.DataGridViewTransaksiJual = New System.Windows.Forms.DataGridView()
        Me.TextBoxSubTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxPelanggan = New System.Windows.Forms.TextBox()
        Me.TextBoxNoFaktur = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewTransaksiJual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(522, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "No Faktur"
        '
        'TextBoxNamaPembeli
        '
        Me.TextBoxNamaPembeli.Location = New System.Drawing.Point(203, 64)
        Me.TextBoxNamaPembeli.Name = "TextBoxNamaPembeli"
        Me.TextBoxNamaPembeli.Size = New System.Drawing.Size(251, 20)
        Me.TextBoxNamaPembeli.TabIndex = 27
        '
        'ButtonBarang
        '
        Me.ButtonBarang.Location = New System.Drawing.Point(174, 62)
        Me.ButtonBarang.Name = "ButtonBarang"
        Me.ButtonBarang.Size = New System.Drawing.Size(23, 23)
        Me.ButtonBarang.TabIndex = 26
        Me.ButtonBarang.UseVisualStyleBackColor = True
        '
        'ComboBoxID
        '
        Me.ComboBoxID.FormattingEnabled = True
        Me.ComboBoxID.Location = New System.Drawing.Point(47, 63)
        Me.ComboBoxID.Name = "ComboBoxID"
        Me.ComboBoxID.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxID.TabIndex = 25
        '
        'TextBoxHargaJual
        '
        Me.TextBoxHargaJual.Location = New System.Drawing.Point(460, 64)
        Me.TextBoxHargaJual.Name = "TextBoxHargaJual"
        Me.TextBoxHargaJual.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHargaJual.TabIndex = 24
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.Location = New System.Drawing.Point(566, 64)
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJumlah.TabIndex = 23
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(525, 400)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(247, 20)
        Me.TextBoxTotal.TabIndex = 22
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(93, 426)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 21
        Me.ButtonProses.Text = "Prosess"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(12, 426)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 20
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'DataGridViewTransaksiJual
        '
        Me.DataGridViewTransaksiJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTransaksiJual.Location = New System.Drawing.Point(12, 90)
        Me.DataGridViewTransaksiJual.Name = "DataGridViewTransaksiJual"
        Me.DataGridViewTransaksiJual.Size = New System.Drawing.Size(760, 304)
        Me.DataGridViewTransaksiJual.TabIndex = 19
        '
        'TextBoxSubTotal
        '
        Me.TextBoxSubTotal.Location = New System.Drawing.Point(672, 64)
        Me.TextBoxSubTotal.Name = "TextBoxSubTotal"
        Me.TextBoxSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSubTotal.TabIndex = 18
        '
        'TextBoxPelanggan
        '
        Me.TextBoxPelanggan.Location = New System.Drawing.Point(622, 38)
        Me.TextBoxPelanggan.Name = "TextBoxPelanggan"
        Me.TextBoxPelanggan.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxPelanggan.TabIndex = 17
        '
        'TextBoxNoFaktur
        '
        Me.TextBoxNoFaktur.Location = New System.Drawing.Point(622, 12)
        Me.TextBoxNoFaktur.Name = "TextBoxNoFaktur"
        Me.TextBoxNoFaktur.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNoFaktur.TabIndex = 16
        '
        'TransaksiJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNamaPembeli)
        Me.Controls.Add(Me.ButtonBarang)
        Me.Controls.Add(Me.ComboBoxID)
        Me.Controls.Add(Me.TextBoxHargaJual)
        Me.Controls.Add(Me.TextBoxJumlah)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.DataGridViewTransaksiJual)
        Me.Controls.Add(Me.TextBoxSubTotal)
        Me.Controls.Add(Me.TextBoxPelanggan)
        Me.Controls.Add(Me.TextBoxNoFaktur)
        Me.Name = "TransaksiJual"
        Me.Text = "Transaksi Penjualan"
        CType(Me.DataGridViewTransaksiJual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNamaPembeli As TextBox
    Friend WithEvents ButtonBarang As Button
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents TextBoxHargaJual As TextBox
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents ButtonProses As Button
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents DataGridViewTransaksiJual As DataGridView
    Friend WithEvents TextBoxSubTotal As TextBox
    Friend WithEvents TextBoxPelanggan As TextBox
    Friend WithEvents TextBoxNoFaktur As TextBox
End Class
