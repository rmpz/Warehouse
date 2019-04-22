<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiBeli
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
        Me.TextBoxNoFaktur = New System.Windows.Forms.TextBox()
        Me.TextBoxPemasok = New System.Windows.Forms.TextBox()
        Me.TextBoxSubTotal = New System.Windows.Forms.TextBox()
        Me.DataGridViewTransaksiBeli = New System.Windows.Forms.DataGridView()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaJual = New System.Windows.Forms.TextBox()
        Me.ComboBoxID = New System.Windows.Forms.ComboBox()
        Me.ButtonBarang = New System.Windows.Forms.Button()
        Me.TextBoxNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewTransaksiBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNoFaktur
        '
        Me.TextBoxNoFaktur.Location = New System.Drawing.Point(622, 12)
        Me.TextBoxNoFaktur.Name = "TextBoxNoFaktur"
        Me.TextBoxNoFaktur.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNoFaktur.TabIndex = 0
        '
        'TextBoxPemasok
        '
        Me.TextBoxPemasok.Location = New System.Drawing.Point(622, 38)
        Me.TextBoxPemasok.Name = "TextBoxPemasok"
        Me.TextBoxPemasok.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxPemasok.TabIndex = 1
        '
        'TextBoxSubTotal
        '
        Me.TextBoxSubTotal.Location = New System.Drawing.Point(672, 64)
        Me.TextBoxSubTotal.Name = "TextBoxSubTotal"
        Me.TextBoxSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSubTotal.TabIndex = 2
        '
        'DataGridViewTransaksiBeli
        '
        Me.DataGridViewTransaksiBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTransaksiBeli.Location = New System.Drawing.Point(12, 90)
        Me.DataGridViewTransaksiBeli.Name = "DataGridViewTransaksiBeli"
        Me.DataGridViewTransaksiBeli.Size = New System.Drawing.Size(760, 304)
        Me.DataGridViewTransaksiBeli.TabIndex = 3
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(12, 426)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 4
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(93, 426)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 5
        Me.ButtonProses.Text = "Prosess"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(525, 400)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(247, 20)
        Me.TextBoxTotal.TabIndex = 6
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.Location = New System.Drawing.Point(566, 64)
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJumlah.TabIndex = 7
        '
        'TextBoxHargaJual
        '
        Me.TextBoxHargaJual.Location = New System.Drawing.Point(460, 64)
        Me.TextBoxHargaJual.Name = "TextBoxHargaJual"
        Me.TextBoxHargaJual.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHargaJual.TabIndex = 8
        '
        'ComboBoxID
        '
        Me.ComboBoxID.FormattingEnabled = True
        Me.ComboBoxID.Location = New System.Drawing.Point(47, 63)
        Me.ComboBoxID.Name = "ComboBoxID"
        Me.ComboBoxID.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxID.TabIndex = 9
        '
        'ButtonBarang
        '
        Me.ButtonBarang.Location = New System.Drawing.Point(174, 62)
        Me.ButtonBarang.Name = "ButtonBarang"
        Me.ButtonBarang.Size = New System.Drawing.Size(23, 23)
        Me.ButtonBarang.TabIndex = 10
        Me.ButtonBarang.UseVisualStyleBackColor = True
        '
        'TextBoxNamaBarang
        '
        Me.TextBoxNamaBarang.Location = New System.Drawing.Point(203, 64)
        Me.TextBoxNamaBarang.Name = "TextBoxNamaBarang"
        Me.TextBoxNamaBarang.Size = New System.Drawing.Size(251, 20)
        Me.TextBoxNamaBarang.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(522, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Pemasok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total"
        '
        'TransaksiBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNamaBarang)
        Me.Controls.Add(Me.ButtonBarang)
        Me.Controls.Add(Me.ComboBoxID)
        Me.Controls.Add(Me.TextBoxHargaJual)
        Me.Controls.Add(Me.TextBoxJumlah)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.DataGridViewTransaksiBeli)
        Me.Controls.Add(Me.TextBoxSubTotal)
        Me.Controls.Add(Me.TextBoxPemasok)
        Me.Controls.Add(Me.TextBoxNoFaktur)
        Me.Name = "TransaksiBeli"
        Me.Text = "Transaksi Pembelian"
        CType(Me.DataGridViewTransaksiBeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNoFaktur As TextBox
    Friend WithEvents TextBoxPemasok As TextBox
    Friend WithEvents TextBoxSubTotal As TextBox
    Friend WithEvents DataGridViewTransaksiBeli As DataGridView
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonProses As Button
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxHargaJual As TextBox
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents ButtonBarang As Button
    Friend WithEvents TextBoxNamaBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
