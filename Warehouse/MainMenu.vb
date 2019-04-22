Public Class MainMenu
    Public Property SkinEngine1 As Object

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        SkinEngine1.SkinFile = "Skins\warm\warm.ssk"
        SkinEngine1.ApplyMainBuiltInSkin()
        SkinEngine1.Active = True
    End Sub

    Private Sub ButtonBarang_Click(sender As Object, e As EventArgs) Handles ButtonBarang.Click
        DataBarang.ShowDialog()
    End Sub

    Private Sub ButtonMerk_Click(sender As Object, e As EventArgs) Handles ButtonMerk.Click
        DataMerk.Text = "Data Merk"
        DataMerk.ShowDialog()
    End Sub

    Private Sub ButtonSatuan_Click(sender As Object, e As EventArgs) Handles ButtonSatuan.Click
        DataSatuan.Text = "Data Satuan"
        DataSatuan.ShowDialog()
    End Sub

    Private Sub ButtonPembelian_Click(sender As Object, e As EventArgs) Handles ButtonPembelian.Click
        TransaksiBeli.ShowDialog()
    End Sub

    Private Sub ButtonPenjualan_Click(sender As Object, e As EventArgs) Handles ButtonPenjualan.Click
        TransaksiJual.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Format(Now, "hh:mm:ss")
    End Sub
End Class
