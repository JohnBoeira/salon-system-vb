Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.BackColor = Color.FromArgb(117, 207, 182)
        txtSenha.BackColor = Color.FromArgb(117, 207, 182)


    End Sub
    Public Class Limpar

    End Class

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String
        Dim senha As String
        usuario = txtUsuario.Text
        senha = txtSenha.Text

        If usuario <> "" And senha <> "" Then
            Try
                Abrir()
                Dim cmd As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql As String

                sql = "SELECT * FROM tb_funcionarios WHERE usuario = '" & txtUsuario.Text & "' and senha='" & txtSenha.Text & "'"
                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader



                If reader.Read = True Then
                    'RECUPERANDO DADOS DO USUARIO
                    Dim nome As String
                    Dim especialidade As String

                    nome = reader(1)
                    especialidade = reader(5)
                    esp = especialidade

                    nomeUsuario = nome
                    reader.Close()
                    Dim form = New frmPrincipal
                    'MsgBox("Bem Vindo " + nome)
                    Me.Hide()

                    frmPrincipal.ShowDialog()

                Else
                    MsgBox("login incorreto!", MsgBoxStyle.Information, "erro ao logar")
                    txtUsuario.Focus()
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox("Rrro no login" + ex.Message)
            End Try


        Else
            MsgBox("Preencha os campos!!", MsgBoxStyle.Information, "Login")
            txtUsuario.Focus()
        End If

    End Sub
End Class
