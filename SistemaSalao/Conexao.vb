Imports MySql.Data.MySqlClient

Module Conexao
    Public con As New MySqlConnection("server=localhost; userid=root; password=; database=salao; port=;")
    Sub Abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub
    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub
    'DECLARAÇÃO DE VARIAVEIS GLOBAIS
    Public nomeUsuario As String
    Public esp As String
    Public nomeCliente As String


End Module
