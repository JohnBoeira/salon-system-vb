Imports MySql.Data.MySqlClient

Public Class FrmCadEspecialidade

    Private Sub LimparCampos()
        txtEsp.Text = ""
    End Sub

    Private Sub HabilitarCampos()
        txtEsp.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        txtEsp.Enabled = False
    End Sub

    Private Sub DesabilitarBtns()
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.BackgroundImage = My.Resources.btnSalvar
        btnSalvar.Enabled = True
        HabilitarCampos()
        LimparCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtEsp.Text <> "" Then
            Try
                'Abrindo conexão
                Abrir()

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE tb_especialidade SET especialidade='" & txtEsp.Text & "' where id=  '" & txtCodigo.Text & "' "
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
            txtEsp.Focus()
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If MsgBox("Deseja excluir??", vbYesNo, "Escolha a opção") = vbYes Then
            Try
                Abrir()
                'Deletando 

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM tb_especialidade WHERE id='" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Deletado", MsgBoxStyle.Information, "Cliente deletado!")
                btnEditar.Enabled = False
                btnEditar.BackgroundImage = My.Resources.btnEditarInativo
                btnRemover.Enabled = False
                btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
                DesabilitarCampos()
                LimparCampos()
                Listar()
            Catch ex As Exception
                MsgBox("Erro ao deletar")
            End Try
        End If

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtEsp.Text <> "" Then
            Try
                'Abrindo conexão
                Abrir()

                'INSERT           
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO tb_especialidade (especialidade) VALUES ('" & txtEsp.Text & "')"
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
            txtEsp.Focus()
        End If

    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        btnEditar.Enabled = True
        btnEditar.BackgroundImage = My.Resources.btnEditar

        btnRemover.Enabled = True
        btnRemover.BackgroundImage = My.Resources.btnDeletarUser

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtCodigo.Visible = False
        txtEsp.Text = grid.CurrentRow.Cells(1).Value
    End Sub

    Sub Listar()
        Try
            Abrir()
            'listagem dos banco para o DataGrid
            Dim sql As String = "SELECT * FROM tb_especialidade order by especialidade asc"
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
        grid.Columns(1).HeaderText = "Especialidade"
        grid.Columns(1).Width = 235.3
    End Sub

    Private Sub FrmCadEspecialidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnRemover.BackgroundImage = My.Resources.btnDeletarUserInativo
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnRemover.Enabled = False
        Formatar()
    End Sub

    Private Sub FrmCadEspecialidade_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        LimparCampos()
        DesabilitarBtns()
        DesabilitarCampos()

    End Sub
End Class