Imports vb = Microsoft.VisualBasic
Public Class DataBarang
    Dim SQL as String
    Dim Proses As New ConnectionClass
    Dim Barang As DataTable
    
    Private Sub DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       Call Atur()
    End Sub
    
    Private Sub RadioButtonMerk_Click(sender As Object, e As EventArgs) Handles RadioButtonMerk.Click
        DataMerk.Text = "Data Merk Barang"
        DataMerk.ShowDialog()
    End Sub
    
    Private Sub RadioButtonSatuan_Click(sender As Object, e As EventArgs) Handles RadioButtonSatuan.Click
        DataSatuan.Text = "Data Merk Satuan"
        DataSatuan.ShowDialog()
    End Sub
    
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        SQL = "INSERT INTO Barang VALUES ('" & TextBoxID.Text & "', '" & TextBoxNama.Text & "', '" & vb.Left(ComboBoxMerk.Text, 7) & "', '" & TextBoxHargaBeli.Text & "', '" & TextBoxHargaJual.Text & "', '" & TextBoxStock.Text & "')"
        
        Proses.ExecuteQuery(SQL)
        MessageBox.Show("Data Baru Telah Berhasil Disimpan!", "Penyimpanan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        Call Atur()
    End Sub



    Sub Data_Record()
        Barang = Proses.ExecuteQuery("SELECT * FROM Query_Barang")
        DataGridViewBarang.DataSource = Barang
        DataGridViewBarang.Columns(0).Width = 50
        DataGridViewBarang.Columns(1).Width = 195
        DataGridViewBarang.Columns(2).Width = 50
    End Sub
    
    Sub Data_Merk()
        Barang = Proses.ExecuteQuery("SELECT * FROM Merk")
        If Barang.Rows.Count = 0 Then
        Else 
            ComboBoxMerk.Items.Clear()
            With Barang.Columns(1)
                For a = 0 To Barang.Rows.Count - 1
                    ComboBoxMerk.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    
    Sub Data_Satuan()
        Barang = Proses.ExecuteQuery("SELECT * FROM Satuan")
        If Barang.Rows.Count = 0 Then
        Else 
            ComboBoxSatuan.Items.Clear()
            With Barang.Columns(1)
                For a = 0 To Barang.Rows.Count - 1
                    ComboBoxMerk.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a                
            End With
        End If
    End Sub

    Sub Atur()
        TextBoxID.ReadOnly = False
        TextBoxID.Text = ""
        TextBoxNama.Text = ""
        ComboBoxMerk.Text = ""
        ComboBoxSatuan.Text = ""
        TextBoxHargaBeli.Text = ""
        TextBoxHargaJual.Text = ""
        TextBoxStock.Text = 0
        ButtonTambah.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonKoreksiStock.Enabled = False
        Call Data_Merk()
        Call Data_Satuan()
        Call Data_Record()
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        SQL = "UPDATE Barang set Nama = '" & TextBoxNama.Text & "', Merk = '" & ComboBoxMerk.Text & "', Harga_Beli = '" & TextBoxHargaBeli.Text & "', Harga_Jual = '" & TextBoxHargaJual.Text & "', Stock = '" & TextBoxStock.Text & "' WHERE ID = '" & TextBoxID.Text & "' "

        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah DiPerbaharui!", "Perubahan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        SQL = "DELETE FROM Barang WHERE ID = '" & TextBoxID.Text & "' "

        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah DiHapus!", "Penghapusan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Call Atur()
    End Sub

    Private Sub ButtonKoreksiStock_Click(sender As Object, e As EventArgs) Handles ButtonKoreksiStock.Click
        Dim Jumlah = InputBox("Masukan Jumlah Barang", "Tambah Stock")
        On Error GoTo Pesan
        Dim Tambah_Stock = Val(TextBoxStock.Text) + Val(Jumlah)
        SQL = "UPDATE Barang SET Stock = '" & Tambah_Stock & "' WHERE ID = '" & TextBoxID.Text & "' "
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Stock Telah Ditambahkan!", "Penambahan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
        Exit Sub
Pesan:
        MsgBox("Masukan Angka")
    End Sub

    Private Sub TextBoxCari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCari.TextChanged

    End Sub

    Private Sub DataGridViewBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellContentClick

    End Sub
End Class