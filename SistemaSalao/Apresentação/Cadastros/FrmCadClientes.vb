Imports MySql.Data.MySqlClient

Public Class FrmCadClientes

    Dim cpf As String

    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
        txtBuscaCPF.Visible = False
        Listar()
        txtCodigo.Enabled = False

        ' Me.ReportViewer1.RefreshReport()
    End Sub

    Sub Listar()
        Try
            Abrir()

            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_clientes order by nome asc"
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
        grid.Columns(3).Width = 200
        grid.Columns(1).Width = 200
        grid.Columns(2).Width = 150
        grid.Columns(4).Width = 117
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

    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtTelefone.Enabled = False
        txtEndereco.Enabled = False

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

                Dim data_cad As String
                data_cad = Now.ToString("yyyy-MM-dd")

                'Abrindo conexão
                Abrir()

                'verificação se há repetição de cpf
                Dim cmdCPF As MySqlCommand
                Dim readerCPF As MySqlDataReader
                Dim sqlCPF As String

                sqlCPF = "SELECT * FROM tb_clientes WHERE cpf = '" & txtCPF.Text & "'"
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader
                txtCPF.Focus()

                If readerCPF.Read = True Then
                    readerCPF.Close()
                    MsgBox("CPF já cadastrado! por favor verifique o CPF", MsgBoxStyle.Information, "CPF já cadastrado!")
                    Exit Sub
                Else

                End If
                'INSERT
                readerCPF.Close()
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO tb_clientes (nome, cpf, endereco, telefone, data) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "','" & txtEndereco.Text & "','" & txtTelefone.Text & "', '" & data_cad & "' )"
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
        txtCPF.Text = ""
        txtTelefone.Text = ""
        txtEndereco.Text = ""
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

        cpf = grid.CurrentRow.Cells(2).Value
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

                sqlCPF = "SELECT * FROM tb_clientes WHERE cpf = '" & txtCPF.Text & "'"
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader
                txtCPF.Focus()

                If readerCPF.Read = True And txtCPF.Text <> cpf Then
                    readerCPF.Close()
                    MsgBox("CPF já cadastrado! por favor verifique o CPF", MsgBoxStyle.Information, "CPF já cadastrado!")
                    Exit Sub



                End If
                '
                readerCPF.Close()
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE tb_clientes SET nome='" & txtNome.Text & "', cpf='" & txtCPF.Text & "', endereco='" & txtEndereco.Text & "', telefone='" & txtTelefone.Text & "' WHERE id = '" & txtCodigo.Text & "' "
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

                sql = "DELETE FROM tb_clientes WHERE id='" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Deletado", MsgBoxStyle.Information, "Cliente deletado!")
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
            Dim sql As String = "SELECT * FROM tb_clientes WHERE nome LIKE '" & txtBuscaNome.Text & "%' order by nome asc"
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
            Dim sql As String = "SELECT * FROM tb_clientes WHERE cpf = '" & txtBuscaCPF.Text & "' "
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

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        nomeCliente = grid.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class