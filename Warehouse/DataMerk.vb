Public Class DataMerk
    Dim SQL as String
    Dim Proses As New ConnectionClass
    Dim Merk As DataTable
    
    Sub Data_Record()
        Merk = Proses.ExecuteQuery("SELECT * FROM Merk")
        DataGridViewMerk.DataSource = Merk
        DataGridViewMerk.Columns(0).Width = 50
        DataGridViewMerk.Columns(1).Width = 195
        DataGridViewMerk.Columns(2).Width = 50
    End Sub
    
    Sub Kode_Otomatis()
        Merk = Proses.ExecuteQuery("SELECT * FROM Merk ORDER BY ID DESC")
        If Merk.Rows.Count = 0 Then
            TextBoxID.Text = "MRK-001"
        Else 
            With Merk.Rows(0)
                TextBoxID.Text = .Item("ID")
            End With
            TextBoxID.Text = Val(Microsoft.VisualBasic.Mid(TextBoxID.Text, 5, 3)) + 1
            If Len(TextBoxID.Text) = 1 Then
                TextBoxID.Text = "MRK-00" & TextBoxID.Text & ""
            ElseIf Len(TextBoxID.Text) = 2 Then
                TextBoxID.Text = "MRK-0" & TextBoxID.Text & ""
            ElseIf Len(TextBoxID.Text) = 3 Then
                TextBoxID.Text = "MRK-" & TextBoxID.Text & "" 
            End If
        End If
    End Sub
    
    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonTambah.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxID.Enabled = False
        TextBoxMerk.Text = ""
        TextBoxMerk.Focus()
    End Sub
    
    Private Sub DataMerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If TextBoxMerk.Text = "" Then TextBoxMerk.Focus() : Exit Sub
        SQL = "INSERT INTO Merk VALUES ('" & TextBoxID.Text & "', '" & TextBoxMerk.Text & "')"
        
        Proses.ExecuteQuery(SQL)
        MessageBox.Show("Data Baru Telah Berhasil Disimpan!", "Penyimpanan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        Call Atur()
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        If TextBoxMerk.Text = "" Then TextBoxMerk.Focus() : Exit Sub
        SQL = "UPDATE Merk SET Merk = '" & TextBoxMerk.Text & "' WHERE ID = '" & TextBoxID.Text & "'"
        
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah DiPerbaharui!", "Perubahan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        SQL = "DELETE FROM Merk WHERE ID = '" & TextBoxID.Text & "' "

        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah DiHapus!", "Penghapusan Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Atur()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Call Atur()
    End Sub

    Private Sub DataGridViewMerk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMerk.CellContentClick
        Select Case Me.Text
            Case "Data Merk"
                TextBoxID.Text = DataGridViewMerk.SelectedCells(0).Value
                TextBoxMerk.Text = DataGridViewMerk.SelectedCells(1).Value
                ButtonUbah.Enabled = True
                ButtonHapus.Enabled = True
                ButtonTambah.Enabled = False
            Case "Data Merk Barang"
                DataBarang.ComboBoxMerk.Text = "" & DataGridViewMerk.SelectedCells(0).Value & ""
                Me.Close()
        End Select
    End Sub
End Class