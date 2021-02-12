Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.BackColor = Color.FromArgb(209, 251, 241)
        btnAddCliente.BackColor = Color.FromArgb(242, 255, 252)
        btnAgendamento.BackColor = Color.FromArgb(242, 255, 252)
        btnQuadroHorario.BackColor = Color.FromArgb(242, 255, 252)
        btnVenda.BackColor = Color.FromArgb(242, 255, 252)
        lvlUsuario.Text = nomeUsuario
        lvlEsp.Text = esp

        If esp = "Gerente" Or esp = "gerente" Then
            menuFuncionario.Enabled = True
            menuProduto.Enabled = True

        End If

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuProduto.Click
        Dim form = New FrmCadProduto
        form.ShowDialog()
    End Sub

    Private Sub EsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsToolStripMenuItem.Click
        Dim form = New FrmCadEspecialidade
        form.ShowDialog()
    End Sub

    Private Sub btnAddCliente_Click(sender As Object, e As EventArgs) Handles btnAddCliente.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuFuncionario.Click
        Dim form = New FrmCadFuncionario
        form.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form = New frmLogin
        Me.Hide()
        form.ShowDialog()



    End Sub

    Private Sub lvlUsuario_Click(sender As Object, e As EventArgs) Handles lvlUsuario.Click

    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub TimerData_Tick(sender As Object, e As EventArgs) Handles TimerData.Tick
        lblData.Text = Now().ToShortDateString
        lblHora.Text = Now().ToLongTimeString
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim form = New FrmCadFornecedor
        form.ShowDialog()

    End Sub



    Private Sub ServiçosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem1.Click
        Dim form = New FrmCadServico
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim form = New RelProdutosFrm
        form.ShowDialog()

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim form = New RelClientesFrm
        form.ShowDialog()

    End Sub

    Private Sub QuadroDeHoráriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadroDeHoráriosToolStripMenuItem.Click
        Dim form = New FrmVendas
        form.ShowDialog()

    End Sub

    Private Sub EntradasESaídasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasESaídasToolStripMenuItem.Click
        Dim form = New frmMovimentacoes
        form.ShowDialog()
    End Sub
End Class