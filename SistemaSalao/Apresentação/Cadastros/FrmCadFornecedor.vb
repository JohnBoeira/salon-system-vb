Imports MySql.Data.MySqlClient

Public Class FrmCadFornecedor

    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
        Listar()
        txtCodigo.Enabled = False

    End Sub

    Sub Listar()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_fornecedores order by nome asc"
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
        grid.Columns(1).HeaderText = "Nome"
        grid.Columns(2).HeaderText = "Endereco"
        grid.Columns(3).HeaderText = "Telefone"
        grid.Columns(4).HeaderText = "Email"
        grid.Columns(5).HeaderText = "Produto"
        'grid.Columns(3).Width = 200
        grid.Columns(1).Width = 70
        grid.Columns(2).Width = 150
        grid.Columns(4).Width = 200
        grid.Columns(5).Width = 167
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.BackgroundImage = My.Resources.btnSalvar
        btnSalvar.Enabled = True
        HabilitarCampos()
        LimparCampos()
    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtEmail.Enabled = True
        txtTelefone.Enabled = True
        txtEndereco.Enabled = True
        txtProduto.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtProduto.Enabled = False
        txtTelefone.Enabled = False
        txtEndereco.Enabled = False
        txtEmail.Enabled = False
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
                'Abrindo conexão
                Abrir()




                'INSERT

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO tb_fornecedores (nome, endereco, telefone, email, produto) VALUES ('" & txtNome.Text & "', '" & txtEndereco.Text & "','" & txtTelefone.Text & "', '" & txtEmail.Text & "', '" & txtProduto.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Listagem da dataGrid
                Listar()

                '
                MsgBox("Salvo com sucesso!!", MsgBoxStyle.Information, "Dados Salvos")
                DesabilitarCampos()
                DesabilitarBtns()
                LimparCampos()

            Catch ex As Exception
                MsgBox("Error" + ex.Message)
            End Try
        Else
            MsgBox("Preencha os campos", MsgBoxStyle.Information, "Erro")
            txtNome.Focus()
        End If

    End Sub

    Private Sub LimparCampos()
        txtNome.Text = ""
        txtEmail.Text = ""
        txtTelefone.Text = ""
        txtEndereco.Text = ""
        txtProduto.Text = ""
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
        txtEndereco.Text = grid.CurrentRow.Cells(2).Value
        txtTelefone.Text = grid.CurrentRow.Cells(3).Value
        txtEmail.Text = grid.CurrentRow.Cells(4).Value
        txtProduto.Text = grid.CurrentRow.Cells(5).Value

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Then
            Try
                'Abrindo conexão
                Abrir()


                '

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE tb_fornecedores SET nome='" & txtNome.Text & "',  endereco='" & txtEndereco.Text & "', telefone='" & txtTelefone.Text & "', email='" & txtEmail.Text & "', produto='" & txtProduto.Text & "' WHERE id = '" & txtCodigo.Text & "' "
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

                sql = "DELETE FROM tb_fornecedores WHERE id='" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Deletado", MsgBoxStyle.Information, " deletado!")
                btnEditar.Enabled = False
                btnEditar.BackgroundImage = My.Resources.btnEditarInativo
                btnRemover.Enabled = False
                btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
                DesabilitarCampos()
                Listar()
            Catch ex As Exception
                MsgBox("Erro ao deletar")
            End Try
        End If

    End Sub


    Private Sub txtBuscaNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaNome.TextChanged
        BuscarNome()

    End Sub

    Sub BuscarNome()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_fornecedores WHERE nome LIKE '" & txtBuscaNome.Text & "%' order by nome asc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro no lista do grid" + ex.Message)
        End Try


    End Sub

End Class