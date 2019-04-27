Imports Microsoft.SqlServer.Server
Imports vb = Microsoft.VisualBasic
Public Class TransaksiBeli
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
    
    Sub Data_Record_Pembelian()
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Transaksi_Beli_Rinci WHERE No_Faktur = '" & TextBoxNoFaktur.Text & "'")
        
        DataGridViewTransaksiBeli.DataSource = Transaksi
        DataGridViewTransaksiBeli.Columns(0).Visible = False
        DataGridViewTransaksiBeli.Columns(2).Width = 295
    End Sub
    
    Sub Faktur_Otomatis()
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Transaksi_Beli ORDER BY No_faktur DESC")
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
        Call Data_Record_Pembelian()
        Call Faktur_Otomatis()
    End Sub
    
    
    
    Private Sub TransaksiBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonBarang_Click(sender As Object, e As EventArgs) Handles ButtonBarang.Click
        DataBarang.Text = "Data Barang Pembelian"
        DataBarang.ShowDialog()
    End Sub

    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        SQL = "INSERT INTO Transaksi_Beli VALUES ('" & TextBoxNoFaktur.Text & "', " & Format(Now, "dd/MM/yyyy") & "', '" & TextBoxPemasok.Text & "', '" & TextBoxTotal.Text & "')"
        
        Proses.ExecuteQuery(SQL)
        Call Faktur_Otomatis()
        Call Atur()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
      
    End Sub

    Private Sub ComboBoxID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxID.TextChanged
        Transaksi = Proses.ExecuteQuery("SELECT * FROM Barang WHERE ID = '" & vb.Left(ComboBoxID.Text, 3) & "'")
        If Transaksi.Rows.Count = 0 Then
        Else 
            TextBoxNamaBarang.Text = Transaksi.Rows(0).Item("Nama")
            TextBoxHargaJual.Text = Transaksi.Rows(0).Item("Harga_Beli")
            TextBoxStock.Text = Transaksi.Rows(0).Item("stock")
            TextBoxJumlah.Focus()
        End If
    End Sub

    Private Sub TextBoxJumlah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TextBoxJumlah.Focus()
                Case Chr(8)
                    e.KeyChar = Chr(8)
                    Case Chr(13)
                        If TextBoxPemasok.Text = "" Then TextBoxPemasok.Focus() : Exit Sub
                   
        Dim Total_Harga = Val(TextBoxJumlah.Text) * Val(TextBoxHargaJual.Text)
        SQL = "INSERT INTO Transaksi_Beli_Rinci VALUES ('" & TextBoxNoFaktur.Text & "', '" & vb.Left(ComboBoxID.Text, 3) & "', '" & TextBoxNamaBarang.Text & "', '" & TextBoxHargaJual.Text & "', '" & TextBoxJumlah.Text & "', '" & TextBoxTotal.Text & "') "
        
        Proses.ExecuteNonQuery(SQL)
        ComboBoxID.Text = ""
        TextBoxNamaBarang.Text = ""
        TextBoxHargaJual.Text = ""
        TextBoxStock.Text = ""
        TextBoxJumlah.Text = ""
        ComboBoxID.Focus()
        Call Data_Barang()
        Call Data_Record_Pembelian()
        TextBoxTotal.Text = ""
        
        Dim i As Integer
        For i = 0 To DataGridViewTransaksiBeli.Rows.Count - 1
            TextBoxTotal.Text = DataFormats.Format(Val(Replace(TextBoxTotal.Text, ".", "")) + Val(DataGridViewTransaksiBeli.Item(5, i).Value), "#,#")
        Next
        
        Case Else
        e.KeyChar = Chr(0)
        
        End Select
    End Sub
End Class