<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelProdutosFrm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.salaoDataSet = New SistemaSalao.salaoDataSet()
        Me.tb_produtosTableAdapter = New SistemaSalao.salaoDataSetTableAdapters.tb_produtosTableAdapter()
        Me.TbprodutosFornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_produtosFornecedoresTableAdapter = New SistemaSalao.salaoDataSetTableAdapters.tb_produtosFornecedoresTableAdapter()
        CType(Me.tb_produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salaoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbprodutosFornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetProdutos"
        ReportDataSource1.Value = Me.TbprodutosFornecedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelProdutos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(617, 477)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_produtosBindingSource
        '
        Me.tb_produtosBindingSource.DataMember = "tb_produtos"
        Me.tb_produtosBindingSource.DataSource = Me.salaoDataSet
        '
        'salaoDataSet
        '
        Me.salaoDataSet.DataSetName = "salaoDataSet"
        Me.salaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_produtosTableAdapter
        '
        Me.tb_produtosTableAdapter.ClearBeforeFill = True
        '
        'TbprodutosFornecedoresBindingSource
        '
        Me.TbprodutosFornecedoresBindingSource.DataMember = "tb_produtosFornecedores"
        Me.TbprodutosFornecedoresBindingSource.DataSource = Me.salaoDataSet
        '
        'Tb_produtosFornecedoresTableAdapter
        '
        Me.Tb_produtosFornecedoresTableAdapter.ClearBeforeFill = True
        '
        'RelProdutosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 477)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelProdutosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de produtos"
        CType(Me.tb_produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salaoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbprodutosFornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_produtosBindingSource As BindingSource
    Friend WithEvents salaoDataSet As salaoDataSet
    Friend WithEvents tb_produtosTableAdapter As salaoDataSetTableAdapters.tb_produtosTableAdapter
    Friend WithEvents TbprodutosFornecedoresBindingSource As BindingSource
    Friend WithEvents Tb_produtosFornecedoresTableAdapter As salaoDataSetTableAdapters.tb_produtosFornecedoresTableAdapter
End Class
