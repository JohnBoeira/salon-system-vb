Imports MySql.Data.MySqlClient

Public Class frmMovimentacoes
    Private Sub frmMovimentacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub
    Sub Listar()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_movimentacoes order by data desc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt
            If grid.Rows.Count > 0 Then
                Formatar()
            End If

        Catch ex As Exception
            MsgBox("Erro ao listar---" + ex.Message)
        End Try


    End Sub

    Sub Formatar()
        grid.Columns(0).Visible = False
        grid.Columns(6).Visible = False


        grid.Columns(0).HeaderText = "id"
        grid.Columns(1).HeaderText = "Tipo"
        grid.Columns(2).HeaderText = "Movimento"
        grid.Columns(3).HeaderText = "Valor"
        grid.Columns(4).HeaderText = "Funcionário"
        grid.Columns(5).HeaderText = "Data"
        grid.Columns(6).HeaderText = "id do movimento"

        'grid.Columns(1).Width = 200

    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbEntrada.Visible = False
        DataBuscarFin.Visible = True
        DataBuscarIni.Visible = True
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        cbEntrada.Visible = True
        DataBuscarFin.Visible = False
        DataBuscarIni.Visible = False
    End Sub
End Class