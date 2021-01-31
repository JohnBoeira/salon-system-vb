Imports MySql.Data.MySqlClient

Public Class FrmCadFuncionario
    Dim cpf As String
    Dim usuario As String
    Private Sub FrmCadFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
        txtBuscaCPF.Visible = False
        Listar()
        txtCodigo.Enabled = False
        CarregarCombobox()
    End Sub

    Sub CarregarCombobox()
        Try
            Abrir()
            Dim sql As String = "SELECT * FROM tb_especialidade order by especialidade asc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cbEsp.DataSource = dt
                cbEsp.ValueMember = "id"
                cbEsp.DisplayMember = "especialidade"
            Else
                cbEsp.Text = "Cadastre uma especialidade primeiro"
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
            Dim sql As String = "SELECT * FROM tb_funcionarios order by nome asc"
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
        grid.Columns(2).HeaderText = "CPF"
        grid.Columns(3).HeaderText = "Endereço"
        grid.Columns(4).HeaderText = "Telefone"
        grid.Columns(5).HeaderText = "Especialidade"
        grid.Columns(6).HeaderText = "Usuário"
        grid.Columns(7).HeaderText = "Senha"
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.BackgroundImage = My.Resources.btnSalvar
        btnSalvar.Enabled = True
        HabilitarCampos()
        LimparCampos()
    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtTelefone.Enabled = True
        txtEndereco.Enabled = True
        cbEsp.Enabled = True
        txtUsuario.Enabled = True
        txtSenha.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtTelefone.Enabled = False
        txtEndereco.Enabled = False
        cbEsp.Enabled = False
        txtUsuario.Enabled = False
        txtSenha.Enabled = False
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

        If txtNome.Text <> "" And txtCPF.Text <> "   .   .   -" Then
            Try
                'Abrindo conexão
                Abrir()

                'verificação se há repetição de cpf
                Dim cmdCPF As MySqlCommand
                Dim readerCPF As MySqlDataReader
                Dim sqlCPF As String

                sqlCPF = "SELECT * FROM tb_funcionarios WHERE cpf = '" & txtCPF.Text & "'"
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader
                txtCPF.Focus()

                If readerCPF.Read = True Then
                    readerCPF.Close()
                    MsgBox("CPF já cadastrado! por favor verifique o CPF", MsgBoxStyle.Information, "CPF já cadastrado!")
                    Exit Sub


                End If
                readerCPF.Close()
                'VERIFICAÇÃO DE REPETIÇÃO DE USUÁRIO
                Dim cmdUsu As MySqlCommand
                Dim readerUsu As MySqlDataReader
                Dim sqlUsu As String

                sqlUsu = "SELECT * FROM tb_funcionarios WHERE usuario = '" & txtUsuario.Text & "'"
                cmdUsu = New MySqlCommand(sqlUsu, con)
                readerUsu = cmdUsu.ExecuteReader

                If readerUsu.Read = True Then
                    readerUsu.Close()
                    MsgBox("Usuário já cadastrado! por favor verifique o Usuário", MsgBoxStyle.Information, "Usuário já cadastrado!")
                    Exit Sub
                End If
                readerUsu.Close()
                'INSERT
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO tb_funcionarios (nome, cpf, endereco, telefone, especialidade, usuario, senha) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "','" & txtEndereco.Text & "','" & txtTelefone.Text & "','" & cbEsp.Text & "', '" & txtUsuario.Text & "', '" & txtSenha.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Listagem da dataGrid
                Listar()


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
        txtCPF.Text = ""
        txtTelefone.Text = ""
        txtEndereco.Text = ""
        cbEsp.Text = ""
        txtUsuario.Text = ""
        txtSenha.Text = ""
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
        txtCPF.Text = grid.CurrentRow.Cells(2).Value
        txtEndereco.Text = grid.CurrentRow.Cells(3).Value
        txtTelefone.Text = grid.CurrentRow.Cells(4).Value
        cbEsp.Text = grid.CurrentRow.Cells(5).Value
        txtUsuario.Text = grid.CurrentRow.Cells(6).Value
        txtSenha.Text = grid.CurrentRow.Cells(7).Value

        cpf = grid.CurrentRow.Cells(2).Value
        usuario = grid.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" And txtCPF.Text <> "   .   .   -" Then
            Try
                'Abrindo conexão
                Abrir()

                'verificação se há repetição de cpf
                Dim cmdCPF As MySqlCommand
                Dim readerCPF As MySqlDataReader
                Dim sqlCPF As String

                sqlCPF = "SELECT * FROM tb_funcionarios WHERE cpf = '" & txtCPF.Text & "'"
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader
                txtCPF.Focus()

                If readerCPF.Read = True And txtCPF.Text <> cpf Then
                    readerCPF.Close()
                    MsgBox("CPF já cadastrado! por favor verifique o CPF", MsgBoxStyle.Information, "CPF já cadastrado!")
                    Exit Sub

                End If
                readerCPF.Close()
                'VERIFICAÇÃO DE REPETIÇÃO DE USUÁRIO
                Dim cmdUsu As MySqlCommand
                Dim readerUsu As MySqlDataReader
                Dim sqlUsu As String

                sqlUsu = "SELECT * FROM tb_funcionarios WHERE usuario = '" & txtUsuario.Text & "'"
                cmdUsu = New MySqlCommand(sqlUsu, con)
                readerUsu = cmdUsu.ExecuteReader

                If readerUsu.Read = True And txtUsuario.Text <> usuario Then
                    readerUsu.Close()
                    MsgBox("Usuário " + txtUsuario.Text + "já cadastrado! por favor verifique o Usuário", MsgBoxStyle.Information, "Usuário já cadastrado!")
                    Exit Sub
                Else

                End If
                readerUsu.Close()

                'UPDATE
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE tb_funcionarios SET nome='" & txtNome.Text & "', cpf='" & txtCPF.Text & "', endereco='" & txtEndereco.Text & "', telefone='" & txtTelefone.Text & "', especialidade='" & cbEsp.Text & "', usuario='" & txtUsuario.Text & "', senha='" & txtSenha.Text & "' WHERE id = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Listagem da dataGrid
                Listar()

                MsgBox("Editado com sucesso!!", MsgBoxStyle.Information, "Dados editados")
                DesabilitarCampos()
                DesabilitarBtns()

            Catch ex As Exception
                MsgBox("ERRO DE EDIÇÃO: " + ex.Message)
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

                sql = "DELETE FROM tb_funcionarios WHERE id='" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Deletado", MsgBoxStyle.Information, "Funcionário deletado!")
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

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscaNome.Visible = True
        txtBuscaNome.Enabled = True
        txtBuscaCPF.Visible = False
        txtBuscaCPF.Enabled = False
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscaCPF.Visible = True
        txtBuscaCPF.Enabled = True
        txtBuscaNome.Visible = False
        txtBuscaNome.Enabled = False

    End Sub

    Private Sub txtBuscaNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaNome.TextChanged
        BuscarNome()
    End Sub

    Sub BuscarNome()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_funcionarios WHERE nome LIKE '" & txtBuscaNome.Text & "%' order by nome asc"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro no lista do grid" + ex.Message)
        End Try


    End Sub

    Sub BuscarCPF()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_funcionarios WHERE cpf = '" & txtBuscaCPF.Text & "' "
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            grid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro no lista do grid", ex.Message)

        End Try
    End Sub

    Private Sub txtBuscaCPF_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaCPF.TextChanged
        If txtBuscaCPF.Text <> "   .   .   -" Then
            BuscarCPF()
        Else
            Listar()

        End If
    End Sub

    Private Sub txtBuscaCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscaCPF.MaskInputRejected

    End Sub
End Class