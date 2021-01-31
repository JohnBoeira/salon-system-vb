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
            Dim sql As String = "SELECT * from tb_vendas order by data_venda desc"
            da = New MySqlDataAdapter(sql, con)

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
        grid.Columns(1).HeaderText = "Produto"
        grid.Columns(2).HeaderText = "Cliente"
        grid.Columns(3).HeaderText = "Quantidade"
        grid.Columns(4).HeaderText = "Valor venda"
        grid.Columns(5).HeaderText = "Data venda"
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
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
        'Dim IdProduto As Integer
        'IdProduto = Convert.ToInt32(cbProduto.SelectedValue.ToString())

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
        Dim total As Decimal
        total = txtValor.Text * txtQuantidade.Text
        txtTotal.Text = total
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        BuscarDadosProduto()
    End Sub

    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged


    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        CalcularTotal()
    End Sub
End Class