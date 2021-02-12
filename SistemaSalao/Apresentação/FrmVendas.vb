Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmVendas
    Private Sub FrmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        Listar()
        CarregarCombobox()
        nomeCliente = ""

    End Sub

    Sub CarregarCombobox()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tb_produtos order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbProduto.ValueMember = "id"
                cbProduto.DisplayMember = "nome"

                cbProduto.DataSource = dt

            Else
                cbProduto.Text = "Cadastre um primeiro"
                btnNovo.Enabled = False
                btnNovo.BackgroundImage = My.Resources.btnNovoInativo
            End If

        Catch ex As Exception
            MsgBox("Erro no Carregar do combobox" + ex.Message)
        End Try

    End Sub

    Sub Listar()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim sql As String = "SELECT v.id, p.nome, v.cliente, v.quantidade, v.valor_total, v.data_venda, v.funcionario FROM tb_vendas as v INNER JOIN tb_produtos as p on v.produto = p.id order by v.data_venda desc"
            da = New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt

            If grid.Rows.Count > 0 Then
                FormatarGrid()
                CalcularTotalDia()
            Else
                lblTotalDia.Text = "0"
            End If
            CarregarCombobox()

        Catch ex As Exception
            MsgBox("Erro ao listar---" + ex.Message)
        End Try


    End Sub

    Sub FormatarGrid()
        grid.Columns(0).Visible = False
        'grid.Columns(6).Visible = False

        grid.Columns(1).HeaderText = "Produto"
        grid.Columns(2).HeaderText = "Cliente"
        grid.Columns(3).HeaderText = "Quantidade"
        grid.Columns(4).HeaderText = "Valor venda"
        grid.Columns(5).HeaderText = "Data venda"
        grid.Columns(6).HeaderText = "Funcionario"

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnEditar.Enabled = False
        btnRemover.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.btnSalvar
        btnSalvar.Enabled = True



        HabilitarCampos()
        LimparCampos()
    End Sub

    Private Sub HabilitarCampos()
        txtQuantidade.Enabled = True
        cbProduto.Enabled = True
        btnBuscarClientes.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        txtQuantidade.Enabled = False
        cbProduto.Enabled = False
        btnBuscarClientes.Enabled = False
    End Sub

    Private Sub DesabilitarBtns()
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
    End Sub

    Private Sub LimparCampos()
        txtQuantidade.Text = "0"
        txtCliente.Text = ""
        img.Image = My.Resources.sem_foto
        nomeCliente = ""
        BuscarDadosProduto()
        cbProduto.SelectedIndex() = 0

    End Sub

    Private Sub btnBuscarClientes_Click(sender As Object, e As EventArgs) Handles btnBuscarClientes.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub FrmVendas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtCliente.Text = nomeCliente

    End Sub

    Private Sub BuscarDadosProduto()

        Dim IdProduto As Integer
        IdProduto = cbProduto.SelectedValue()

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "select * from tb_produtos where id = '" & IdProduto & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                'recuperando dados 
                Dim valor As Decimal
                Dim imagem As Byte()
                Dim quantEstoque As Integer

                valor = reader(4)
                quantEstoque = reader(5)

                imagem = reader(7)
                txtValor.Text = valor
                txtEstoque.Text = quantEstoque

                Dim ms As MemoryStream = New MemoryStream(imagem)
                img.Image = System.Drawing.Image.FromStream(ms)
                CalcularTotal()

                reader.Close()

            Else
                MsgBox("não foi possível trazer produto", MsgBoxStyle.Information, "erro")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("não foi possível trazer produto" + ex.Message)
        End Try

    End Sub

    Private Sub CalcularTotal()
        If txtQuantidade.Text <> "" Then
            Dim total As Decimal
            total = txtValor.Text * txtQuantidade.Text
            txtTotal.Text = total
        End If

    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        BuscarDadosProduto()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        CalcularTotal()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim id_mov As Integer

        If txtQuantidade.Text > "0" Then

            If txtQuantidade.Text <= txtEstoque.Text Then
                Try
                    'Abrindo conexão
                    Abrir()

                    'INSERT           
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    'formatação de data
                    Dim data_venda As String
                    data_venda = Now.ToString("yyyy-MM-dd")

                    CalcularTotal()

                    sql = "INSERT INTO tb_vendas (produto, cliente, quantidade, valor_total, data_venda, funcionario) VALUES ('" & cbProduto.SelectedValue & "', '" & txtCliente.Text & "', '" & txtQuantidade.Text & "', '" & txtTotal.Text & "', '" & data_venda & "', '" & nomeUsuario & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    'Listagem da dataGrid
                    Listar()

                    'ABATENDO ESTOQUE 
                    Dim cmdEstoque As MySqlCommand
                    Dim sqlEstoque As String

                    Dim total As Integer
                    total = txtEstoque.Text - txtQuantidade.Text
                    sqlEstoque = "UPDATE tb_produtos SET quantidade = '" & total & "' WHERE id = '" & cbProduto.SelectedValue & "' "

                    cmdEstoque = New MySqlCommand(sqlEstoque, con)
                    cmdEstoque.ExecuteNonQuery()

                    'READER para pegar ultimo id de venda e add em mov
                    Dim cmdR As MySqlCommand
                    Dim reader As MySqlDataReader
                    Dim sqlR As String

                    sqlR = "SELECT MAX(id) FROM tb_vendas "
                    cmdR = New MySqlCommand(sqlR, con)
                    reader = cmdR.ExecuteReader

                    If reader.Read = True Then
                        'RECUPERANDO DADOS 
                        Dim id As Integer

                        id = reader(0)
                        id_mov = id
                        MsgBox(id_mov)
                        reader.Close()

                    Else
                        MsgBox("dados não encontrados", MsgBoxStyle.Information, "id")
                    End If
                    reader.Close()

                    'INSERT DAS MOVES NA TB_MOVIMENTAÇÕES
                    Dim cmdMov As MySqlCommand
                    Dim sqlMov As String

                    sqlMov = "INSERT INTO tb_movimentacoes (tipo, movimento, valor, funcionario, data, id_movimento) VALUES ('Entrada', 'Venda', '" & txtTotal.Text & "', '" & nomeUsuario & "', '" & data_venda & "', '" & id_mov & "')"
                    cmdMov = New MySqlCommand(sqlMov, con)
                    cmdMov.ExecuteNonQuery()

                    MsgBox("Salvo com sucesso!!", MsgBoxStyle.Information, "Dados Salvos")
                    DesabilitarCampos()
                    DesabilitarBtns()
                    LimparCampos()

                Catch ex As Exception
                    MsgBox("Erro no salvar" + ex.Message)
                End Try
            Else
                MsgBox("Quantidade não valida no estoque", MsgBoxStyle.Information, "Erro")
                txtQuantidade.Focus()
            End If

        Else
            MsgBox("Preencha os campos", MsgBoxStyle.Information, "Erro")
            txtQuantidade.Focus()
        End If
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        DesabilitarBtns()
        DesabilitarCampos()
        btnBuscarClientes.Enabled = True
        btnEditar.Enabled = True
        btnEditar.BackgroundImage = My.Resources.btnEditar
        btnRemover.Enabled = True
        btnRemover.BackgroundImage = My.Resources.btnDeletarUser

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtCodigo.Visible = False

        cbProduto.Text = grid.CurrentRow.Cells(1).Value
        txtCliente.Text = grid.CurrentRow.Cells(2).Value
        txtQuantidade.Text = grid.CurrentRow.Cells(3).Value
        txtTotal.Text = grid.CurrentRow.Cells(4).Value


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtQuantidade.Text > "0" Then
            Try
                'Abrindo conexão
                Abrir()

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE tb_vendas SET cliente='" & txtCliente.Text & "' where id=  '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Listagem da dataGrid
                Listar()

                MsgBox("Editado com sucesso!!", MsgBoxStyle.Information, "Dados editados")
                DesabilitarCampos()
                DesabilitarBtns()

            Catch ex As Exception
                MsgBox("Error" + ex.Message)
            End Try
        Else
            MsgBox("Preencha o campo", MsgBoxStyle.Information, "Erro")

        End If
    End Sub

    Private Sub txtQuantidade_MouseLeave(sender As Object, e As EventArgs) Handles txtQuantidade.MouseLeave
        CalcularTotal()
    End Sub

    Sub CalcularTotalDia()
        Dim totalVendas As Decimal
        Dim linha As DataGridViewRow

        For Each linha In grid.Rows
            totalVendas = totalVendas + linha.Cells(4).Value
        Next
        lblTotalDia.Text = totalVendas


    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click

        Try
            Abrir()
            'Deletando 

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM tb_vendas WHERE id='" & txtCodigo.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            'DELETANDO DA TB MOVI
            Dim cmdM As MySqlCommand
            Dim sqlM As String

            sqlM = "DELETE FROM tb_movimentacoes WHERE id_movimento='" & txtCodigo.Text & "' and movimento = 'Venda'"
            cmdM = New MySqlCommand(sqlM, con)
            cmdM.ExecuteNonQuery()

            'ABATENDO ESTOQUE 
            Dim cmdEstoque As MySqlCommand
            Dim sqlEstoque As String

            Dim total As Integer
            total = CInt(txtEstoque.Text) + CInt(txtQuantidade.Text)
            sqlEstoque = "UPDATE tb_produtos SET quantidade = '" & total & "' WHERE id = '" & cbProduto.SelectedValue & "' "

            cmdEstoque = New MySqlCommand(sqlEstoque, con)
            cmdEstoque.ExecuteNonQuery()

            MsgBox("Deletado", MsgBoxStyle.Information, "Cliente deletado!")
            DesabilitarBtns()
            DesabilitarCampos()
            LimparCampos()
            Listar()

        Catch ex As Exception
            MsgBox("Erro ao deletar")
        End Try

    End Sub

    Private Sub DataBuscar_ValueChanged(sender As Object, e As EventArgs) Handles DataBuscar.ValueChanged
        BuscarData()
    End Sub

    Sub BuscarData()
        Try
            Abrir()

            'FORMATAÇÃO DA DATA
            Dim data As String
            data = DataBuscar.Value.ToString("yyyy-MM-dd")

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT v.id, p.nome, v.cliente, v.quantidade, v.valor_total, v.data_venda, v.funcionario FROM tb_vendas as v INNER JOIN tb_produtos as p on v.produto = p.id WHERE v.data_venda = '" & data & "' order by v.data_venda desc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt

            FormatarGrid()
            CalcularTotalDia()

        Catch ex As Exception
            MsgBox("Erro no lista do grid" + ex.Message)
        End Try

    End Sub

End Class