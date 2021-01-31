Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmCadProduto

    Public imgNome As String
    Public abriu As Boolean

    Private Sub FrmCadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        Listar()
        CarregarCombobox()

    End Sub

    Sub CarregarCombobox()
        Try
            Abrir()
            Dim sql As String = "SELECT * FROM tb_fornecedores order by nome asc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cbFornecedor.DataSource = dt
                cbFornecedor.ValueMember = "id"
                cbFornecedor.DisplayMember = "nome"
            Else
                cbFornecedor.Text = "Cadastre um primeiro"
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
            Dim sql As String = "SELECT p.id, p.nome, p.descricao, p.valor_compra, p.valor_venda, p.quantidade, p.fornecedor_id, p.imagem, f.nome FROM tb_produtos as p INNER JOIN tb_fornecedores as f on p.fornecedor_id = f.id order by p.nome asc"
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
        grid.Columns(1).HeaderText = "Nome"
        grid.Columns(2).HeaderText = "Descrição"
        grid.Columns(3).HeaderText = "Valor Compra"
        grid.Columns(4).HeaderText = "Valor Venda"
        grid.Columns(5).HeaderText = "Quantidade"
        grid.Columns(6).Visible = False
        grid.Columns(7).Visible = False
        grid.Columns(8).HeaderText = "Fornecedor"
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        btnEditar.Enabled = True
        btnEditar.BackgroundImage = My.Resources.btnEditar
        btnRemover.Enabled = True
        btnRemover.BackgroundImage = My.Resources.btnDeletarUser

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtCodigo.Visible = False
        txtNome.Text = grid.CurrentRow.Cells(1).Value
        txtDescricao.Text = grid.CurrentRow.Cells(2).Value
        txtValor.Text = grid.CurrentRow.Cells(3).Value
        txtValorVenda.Text = grid.CurrentRow.Cells(4).Value
        txtQuantidade.Text = grid.CurrentRow.Cells(5).Value
        cbFornecedor.SelectedValue = grid.CurrentRow.Cells(6).Value



        'CONVERTENDO BYTE EM OBJETO PIC BOX
        Dim imgByte As Byte() = grid.CurrentRow.Cells(7).Value
        Dim ms As MemoryStream = New MemoryStream(imgByte)
        img.Image = System.Drawing.Image.FromStream(ms)


    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        txtQuantidade.Enabled = True
        txtValor.Enabled = True
        txtValorVenda.Enabled = True
        cbFornecedor.Enabled = True
        btnAddImagem.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtValor.Enabled = False
        txtValorVenda.Enabled = False
        txtQuantidade.Enabled = False
        txtDescricao.Enabled = False
        cbFornecedor.Enabled = False
        btnAddImagem.Enabled = False
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.BackgroundImage = My.Resources.btnSalvar
        btnSalvar.Enabled = True
        HabilitarCampos()
        LimparCampos()
    End Sub

    Private Sub DesabilitarBtns()
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtNome.Text <> "" Then
            Try
                'TRATAMENTO PARA IMAGEM 
                Dim fs As FileStream
                fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
                Dim fotoByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(fotoByte, 0, System.Convert.ToInt32(fs.Length))

                'Abrindo conexão
                Abrir()

                'INSERT         
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO tb_produtos (nome, descricao, valor_compra, valor_venda, quantidade, fornecedor_id, imagem) VALUES ('" & txtNome.Text & "', '" & txtDescricao.Text & "','" & txtValor.Text.Replace(",", ".") & "', '" & txtValorVenda.Text.Replace(",", ".") & "','" & txtQuantidade.Text & "', '" & cbFornecedor.SelectedValue & "', @img)"
                'CRIANDO PARAMETRO
                Dim param As New MySqlParameter
                param.MySqlDbType = MySqlDbType.Binary
                param.ParameterName = "img"
                param.Value = fotoByte

                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.Add(param)
                cmd.ExecuteNonQuery()
                'Listagem da dataGrid
                Listar()


                MsgBox("Salvo com sucesso!!", MsgBoxStyle.Information, "Dados Salvos")
                DesabilitarCampos()
                DesabilitarBtns()
                LimparCampos()
            Catch ex As Exception
                MsgBox("Erro ao salvar" + ex.Message)
            End Try
        Else
            MsgBox("Preencha os campos!!", MsgBoxStyle.Information, "Erro")
            txtNome.Focus()
        End If

    End Sub

    Private Sub LimparCampos()
        txtNome.Text = ""
        txtValor.Text = ""
        txtDescricao.Text = ""
        txtQuantidade.Text = ""
        txtValorVenda.Text = ""

        img.Image = My.Resources.sem_foto
        imgNome = "sem-foto.jpg"
    End Sub

    Sub BuscarNome()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT p.id, p.nome, p.descricao, p.valor_compra, p.valor_venda, p.quantidade, p.fornecedor_id, p.imagem, f.nome FROM tb_produtos as p INNER JOIN tb_fornecedores as f on p.fornecedor_id = f.id WHERE p.nome LIKE '" & txtBuscaNome.Text & "%' order by p.nome asc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro no lista do grid" + ex.Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Then
            Try


                'Abrindo conexão
                Abrir()

                'comando         
                Dim cmd As MySqlCommand
                Dim sql As String

                If abriu Then
                    'TRATAMENTO PARA IMAGEM 
                    Dim fs As FileStream
                    fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
                    Dim fotoByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(fotoByte, 0, System.Convert.ToInt32(fs.Length))

                    sql = "UPDATE tb_produtos SET nome='" & txtNome.Text & "', descricao='" & txtDescricao.Text & "', valor_compra='" & txtValor.Text.Replace(",", ".") & "', valor_venda='" & txtValorVenda.Text.Replace(",", ".") & "', quantidade='" & txtQuantidade.Text & "', fornecedor_id='" & cbFornecedor.SelectedValue & "', imagem= @img WHERE id = '" & txtCodigo.Text & "' "

                    'CRIANDO PARAMETRO PARA IMAGEM
                    Dim param As New MySqlParameter
                    param.MySqlDbType = MySqlDbType.Binary
                    param.ParameterName = "img"
                    param.Value = fotoByte

                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()

                    MsgBox("Editado com sucesso!!", MsgBoxStyle.Information, "Dados editados")
                    DesabilitarCampos()
                Else
                    sql = "UPDATE tb_produtos SET nome='" & txtNome.Text & "', descricao='" & txtDescricao.Text & "', valor_compra='" & txtValor.Text.Replace(",", ".") & "', valor_venda='" & txtValorVenda.Text.Replace(",", ".") & "', quantidade='" & txtQuantidade.Text & "', fornecedor_id='" & cbFornecedor.SelectedValue & "' WHERE id = '" & txtCodigo.Text & "' "

                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Editado com sucesso!!", MsgBoxStyle.Information, "Dados editados")
                    DesabilitarCampos()
                End If

                'Listagem da dataGrid
                Listar()

                LimparCampos()

            Catch ex As Exception
                MsgBox("Error editar" + ex.Message)
            End Try
        Else
            MsgBox("Preencha os campos", MsgBoxStyle.Information, "Erro")
            txtNome.Focus()
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If MsgBox("Deseja excluir??", vbYesNo, "Escolha a opção") = vbYes Then
            Try
                Abrir()
                'Deletando 

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM tb_produtos WHERE id='" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Deletado")

                Listar()

                btnEditar.Enabled = False
                btnEditar.BackgroundImage = My.Resources.btnEditarInativo
                btnRemover.Enabled = False
                btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
                DesabilitarCampos()
            Catch ex As Exception
                MsgBox("Erro ao deletar")
            End Try


        End If

    End Sub

    Private Sub btnAddImagem_Click(sender As Object, e As EventArgs) Handles btnAddImagem.Click
        Dim dlgImagem As FileDialog = New OpenFileDialog
        dlgImagem.Filter = "Arquivo de Imagem(*.png; *.bmp; *.jpg)|*.png; *.bmp; *.jpg"
        If (dlgImagem.ShowDialog) = DialogResult.OK Then
            imgNome = dlgImagem.FileName
            abriu = True

            'CONVERTENDO A STRING NO CAMINHO PARA BITMAP
            Dim imgNova As New Bitmap(imgNome)
            img.Image = DirectCast(imgNova, Image)

        Else
            dlgImagem = Nothing
            MsgBox("Cancelado")
        End If
    End Sub

    Private Sub txtBuscaNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaNome.TextChanged
        BuscarNome()

    End Sub
End Class