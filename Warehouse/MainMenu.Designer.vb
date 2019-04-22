<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSatuan = New System.Windows.Forms.Button()
        Me.ButtonBarang = New System.Windows.Forms.Button()
        Me.ButtonPenjualan = New System.Windows.Forms.Button()
        Me.ButtonMerk = New System.Windows.Forms.Button()
        Me.ButtonPembelian = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonSatuan
        '
        Me.ButtonSatuan.Location = New System.Drawing.Point(12, 118)
        Me.ButtonSatuan.Name = "ButtonSatuan"
        Me.ButtonSatuan.Size = New System.Drawing.Size(75, 75)
        Me.ButtonSatuan.TabIndex = 1
        Me.ButtonSatuan.Text = "Satuan"
        Me.ButtonSatuan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSatuan.UseVisualStyleBackColor = True
        '
        'ButtonBarang
        '
        Me.ButtonBarang.Location = New System.Drawing.Point(93, 118)
        Me.ButtonBarang.Name = "ButtonBarang"
        Me.ButtonBarang.Size = New System.Drawing.Size(75, 75)
        Me.ButtonBarang.TabIndex = 2
        Me.ButtonBarang.Text = "Barang"
        Me.ButtonBarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonBarang.UseVisualStyleBackColor = True
        '
        'ButtonPenjualan
        '
        Me.ButtonPenjualan.Location = New System.Drawing.Point(174, 118)
        Me.ButtonPenjualan.Name = "ButtonPenjualan"
        Me.ButtonPenjualan.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPenjualan.TabIndex = 3
        Me.ButtonPenjualan.Text = "Penjualan"
        Me.ButtonPenjualan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonPenjualan.UseVisualStyleBackColor = True
        '
        'ButtonMerk
        '
        Me.ButtonMerk.Location = New System.Drawing.Point(12, 199)
        Me.ButtonMerk.Name = "ButtonMerk"
        Me.ButtonMerk.Size = New System.Drawing.Size(75, 75)
        Me.ButtonMerk.TabIndex = 4
        Me.ButtonMerk.Text = "Merk"
        Me.ButtonMerk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonMerk.UseVisualStyleBackColor = True
        '
        'ButtonPembelian
        '
        Me.ButtonPembelian.Location = New System.Drawing.Point(174, 199)
        Me.ButtonPembelian.Name = "ButtonPembelian"
        Me.ButtonPembelian.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPembelian.TabIndex = 5
        Me.ButtonPembelian.Text = "Pembelian"
        Me.ButtonPembelian.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonPembelian.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(422, 224)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(50, 50)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "X"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 339)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonPembelian)
        Me.Controls.Add(Me.ButtonMerk)
        Me.Controls.Add(Me.ButtonPenjualan)
        Me.Controls.Add(Me.ButtonBarang)
        Me.Controls.Add(Me.ButtonSatuan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Text = "Warehouse System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonSatuan As Button
    Friend WithEvents ButtonBarang As Button
    Friend WithEvents ButtonPenjualan As Button
    Friend WithEvents ButtonMerk As Button
    Friend WithEvents ButtonPembelian As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
