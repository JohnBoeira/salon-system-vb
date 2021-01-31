Imports Microsoft.Reporting.WinForms

Public Class RelClientesFrm
    Private Sub RelClientesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DSClientes.clientesPorData'. Você pode movê-la ou removê-la conforme necessário.
        dataInicial.Value = Now.ToShortDateString
        dataFinal.Value = Now.ToShortDateString
        Carregar()
    End Sub

    Sub Carregar()
        'Recuperando parametros no corpo do rel
        Dim paramDataIni As ReportParameter
        Dim paramDataFin As ReportParameter

        paramDataIni = New ReportParameter("dataInicial", dataInicial.Text)
        paramDataFin = New ReportParameter("dataFinal", dataFinal.Text)

        Me.ReportViewer1.LocalReport.SetParameters(paramDataIni)
        Me.ReportViewer1.LocalReport.SetParameters(paramDataFin)

        Me.clientesPorDataTableAdapter.Fill(Me.DSClientes.clientesPorData, dataInicial.Text, dataFinal.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub dataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dataInicial.ValueChanged, dataFinal.ValueChanged
        Carregar()

    End Sub
End Class