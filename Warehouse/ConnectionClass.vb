Imports System.Data
Imports System.Data.OleDb

Public Class ConnectionClass
    Protected sql As String
    Protected connect As OleDb.OleDbConnection
    Protected command As OleDb.OleDbCommand
    Protected dataAdapter As OleDb.OleDbDataAdapter
    Protected dataSet As DataSet
    Protected dataTable As DataTable

    Public Function OpenConnection() As Boolean
        connect = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Warehouse.accdb")
        connect.Open()
        If connect.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConnection()
        If Not IsNothing(connect) Then
            connect.Close()
            connect = Nothing
        End If
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConnection() Then
            MsgBox("Koneksi Gagal!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If
        command = New OleDb.OleDbCommand(Query, connect)
        dataAdapter = New OleDb.OleDbDataAdapter
        dataAdapter.SelectCommand = command
        dataSet = New Data.DataSet
        dataAdapter.Fill(dataSet)
        dataTable = dataSet.Tables(0)
        Return dataTable
        dataTable = Nothing
        dataSet = Nothing
        dataAdapter = Nothing
        command = Nothing
        CloseConnection()
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConnection() Then
            MsgBox("Koneksi Gagal!", MsgBoxStyle.Critical, "Access Failed!")
            Exit Sub
        End If
        command = New OleDb.OleDbCommand
        command.Connection = connect
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()
        command = Nothing
        CloseConnection()
    End Sub
End Class
