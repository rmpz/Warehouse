Public Class DataSatuan
    Dim SQL as String
    Dim Proses As New ConnectionClass
    Dim Satuan As DataTable
    
    Sub Data_Record()
        Satuan = Proses.ExecuteQuery("SELECT * FROM Satuan")
        DataGridViewSatuan.DataSource = Satuan
        DataGridViewSatuan.Columns(0).Width = 50
        DataGridViewSatuan.Columns(1).Width = 195
        DataGridViewSatuan.Columns(2).Width = 50
    End Sub
    
    Sub Kode_Otomatis()
        Satuan = Proses.ExecuteQuery("SELECT * FROM Satuan ORDER BY ID DESC")
        If Satuan.Rows.Count = 0 Then
            TextBox1.Text = "STN-001"
        Else 
            With Satuan.Rows(0)
                TextBox1.Text = .Item("ID")
            End With
            TextBox1.Text = Val(Microsoft.VisualBasic.Mid(TextBox1.Text, 5, 3)) + 1
            If Len(TextBox1.Text) = 1 Then
                TextBox1.Text = "STN-00" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 2 Then
                TextBox1.Text = "STN-0" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 3 Then
                TextBox1.Text = "STN-" & TextBox1.Text & "" 
            End If
        End If
    End Sub
    
    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonTambah.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Text = ""
        TextBox2.Focus()
    End Sub

    Private Sub DataSatuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        SQL = "INSERT INTO Satuan VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
        
        Proses.ExecuteQuery(SQL)
        MessageBox.Show("Data Baru Telah Berhasil Disimpan!", "Penyimpanan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        Call Atur()
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        SQL = "UPDATE Satuan SET Satuan = '" & TextBox2.Text & "' WHERE ID = '" & TextBox1.Text & "'"
        
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah DiPerbaharui!", "Perubahan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        SQL = "DELETE FROM Satuan WHERE ID = '" & TextBox1.Text & "' "

        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah DiHapus!", "Penghapusan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Call Atur()
    End Sub

    Private Sub DataGridViewSatuan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSatuan.CellContentClick
        Select Case Me.Text
            Case "Data Satuan"
                TextBox1.Text = DataGridViewSatuan.SelectedCells(0).Value
                TextBox2.Text = DataGridViewSatuan.SelectedCells(1).Value
                ButtonUbah.Enabled = True
                ButtonHapus.Enabled = True
                ButtonTambah.Enabled = False
            Case "Data Satuan Barang"
                DataBarang.ComboBoxSatuan.Text = "" & DataGridViewSatuan.SelectedCells(0).Value & ""
                Me.Close()
        End Select
    End Sub
    End Sub
End Class