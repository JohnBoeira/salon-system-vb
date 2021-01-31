Public Class RelProdutosFrm
    Private Sub RelProdutosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'salaoDataSet.tb_produtosFornecedores'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_produtosFornecedoresTableAdapter.Fill(Me.salaoDataSet.tb_produtosFornecedores)
        'TODO: esta linha de código carrega dados na tabela 'salaoDataSet.tb_produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.tb_produtosTableAdapter.Fill(Me.salaoDataSet.tb_produtos)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class