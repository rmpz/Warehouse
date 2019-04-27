Imports vb = Microsoft.VisualBasic

Public Class TransaksiJual
    Dim SQL as String
    Dim Proses As New ConnectionClass
    Dim Transaksi As DataTable
    Dim Data As DataSet
    
    Sub Data_Barang()
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Barang")
        If Transaksi.Rows.Count = 0 Then
        Else 
            ComboBoxID.Items.Clear()
            With Transaksi.Columns(1)
                For a = 0 To Transaksi.Rows.Count - 1
                    ComboBoxID.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    
    Sub Data_Record_Penjualan()
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Transaksi_Jual_Rinci WHERE No_Faktur = '" & TextBoxNoFaktur.Text & "'")
        
        DataGridViewTransaksiJual.DataSource = Transaksi
        DataGridViewTransaksiJual.Columns(0).Visible = False
        DataGridViewTransaksiJual.Columns(2).Width = 295
    End Sub
    
    Sub Faktur_Otomatis()
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Transaksi_Jual ORDER BY No_faktur DESC")
        If Transaksi.Rows.Count = 0 Then
            TextBoxNoFaktur.Text = "" + Format(Now, "dd/MM/yyyy") + "-001"
        Else 
            With Transaksi.Rows(0)
                TextBoxNoFaktur.Text = .Item("No_Faktur")
            End With
            TextBoxNoFaktur.Text = Val(Microsoft.VisualBasic.Mid(TextBoxNoFaktur.Text, 12, 3)) + 1
            If Len(TextBoxNoFaktur.Text) = 1 Then
                TextBoxNoFaktur.Text = "" + Format(Now, "dd/MM/yyyy") + "-00" & TextBoxNoFaktur.Text & ""
            ElseIf Len(TextBoxNoFaktur.Text) = 2 Then
                TextBoxNoFaktur.Text = "" + Format(Now, "dd/MM/yyyy") + "-0" & TextBoxNoFaktur.Text & ""
            ElseIf Len(TextBoxNoFaktur.Text) = 3 Then
                TextBoxNoFaktur.Text = "" + Format(Now, "dd/MM/yyyy") + "" & TextBoxNoFaktur.Text & ""
            End If
        End If
    End Sub
    
    Sub Atur()
        ComboBoxID.Text = ""
        TextBoxNamaBarang.Text = ""
        TextBoxHargaJual.Text = ""
        TextBoxStock.Text = ""
        TextBoxJumlah.Text = ""
        ComboBoxID.Focus()
        Call Data_Barang()
        Call Data_Record_Penjualan()
        Call Faktur_Otomatis()
    End Sub
    
    Private Sub TransaksiJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonBarang_Click(sender As Object, e As EventArgs) Handles ButtonBarang.Click
        DataBarang.Text = "Data Barang Penjualan"
        DataBarang.ShowDialog()
    End Sub

    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        SQL = "INSERT INTO Transaksi_Jual VALUES ('" & TextBoxNoFaktur.Text & "', " & Format(Now, "dd/MM/yyyy") & "', '" & TextBoxNamaPembeli.Text & "', '" & TextBoxTotal.Text & "')"
        
        Proses.ExecuteQuery(SQL)
        Call Faktur_Otomatis()
        Call Atur()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        On Error Goto Keluar
        Dim i As Integer
        i = DataGridViewTransaksiJual.CurrentRow.Index
        
        For i = 0 To DataGridViewTransaksiJual.Rows.Count - 1
            Transaksi = Proses.ExecuteQuery("SELECT * FROM Barang WHERE ID = '" & DataGridViewTransaksiJual.Item(3, i).Value & "' ")
            If Transaksi.Rows.Count = 0 Then
            Else 
                Dim Jumlah = Val(Transaksi.Rows(0).Item("STOCK")) + Val(DataGridViewTransaksiJual.Item(4, i).Value)
                Proses.ExecuteQuery(SQL)
            End If
        Next
        
        SQL = "DELETE FROM Transaksi_Jual_Rinci WHERE No_Faktur = '" & TextBoxNoFaktur.Text & "' "
        Proses.ExecuteQuery(SQL)
        
        MessageBox.Show("Transaksi sudah dibatalkan!", "Pembatalan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
        Call Faktur_Otomatis()
        Call Data_Record_Penjualan()
        Keluar:
    End Sub

    Private Sub ComboBoxID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxID.TextChanged
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Barang WHERE ID = '" & vb.Left(ComboBoxID.Text, 3) & "'")
        If Transaksi.Rows.Count = 0 Then
        Else 
            TextBoxNamaBarang.Text = Transaksi.Rows(0).Item("Nama")
            TextBoxHargaJual.Text = Transaksi.Rows(0).Item("Harga_Jual")
            TextBoxStock.Text = Transaksi.Rows(0).Item("stock")
            TextBoxJumlah.Focus()
        End If
    End Sub

    Private Sub TextBoxJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TextBoxJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                If TextBoxNamaPembeli.Text = "" Then TextBoxNamaPembeli.Focus() : Exit Sub
                If Val(TextBoxStock.Text) < Val(TextBoxJumlah.Text) Then
                    MsgBox("Maaf, stock tidak mencukupi") : Exit Sub
                End If
                
                Dim Total_Harga = Val(TextBoxJumlah.Text) * Val(TextBoxHargaJual.Text)
                SQL = "INSERT INTO Transaksi_Jual_Rinci VALUES ('" & TextBoxNoFaktur.Text & "', '" & vb.Left(ComboBoxID.Text, 3) & "', '" & TextBoxNamaBarang.Text & "', '" & TextBoxHargaJual.Text & "', '" & TextBoxJumlah.Text & "', '" & TextBoxTotal.Text & "') "
        
                Proses.ExecuteNonQuery(SQL)
                ComboBoxID.Text = ""
                TextBoxNamaBarang.Text = ""
                TextBoxHargaJual.Text = ""
                TextBoxStock.Text = ""
                TextBoxJumlah.Text = ""
                ComboBoxID.Focus()
                Call Data_Barang()
                Call Data_Record_Penjualan()
                TextBoxTotal.Text = ""
        
                Dim i As Integer
                For i = 0 To DataGridViewTransaksiJual.Rows.Count - 1
                    TextBoxTotal.Text = DataFormats.Format(Val(Replace(TextBoxTotal.Text, ".", "")) + Val(DataGridViewTransaksiJual.Item(5, i).Value), "#,#")
                Next
        
            Case Else
                e.KeyChar = Chr(0)
        
        End Select
    End Sub
End Class