<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadProduto))
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbFornecedor = New System.Windows.Forms.ComboBox()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.btnAddImagem = New System.Windows.Forms.Button()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.Transparent
        Me.btnRemover.BackgroundImage = CType(resources.GetObject("btnRemover.BackgroundImage"), System.Drawing.Image)
        Me.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemover.Enabled = False
        Me.btnRemover.FlatAppearance.BorderSize = 0
        Me.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Location = New System.Drawing.Point(510, 370)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(65, 65)
        Me.btnRemover.TabIndex = 40
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(403, 370)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 39
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(296, 370)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
        Me.btnSalvar.TabIndex = 38
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.BackgroundImage = CType(resources.GetObject("btnNovo.BackgroundImage"), System.Drawing.Image)
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Location = New System.Drawing.Point(190, 370)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(65, 65)
        Me.btnNovo.TabIndex = 37
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.Honeydew
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(22, 211)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(710, 145)
        Me.grid.TabIndex = 36
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(38, 27)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 35
        Me.txtCodigo.Visible = False
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(279, 97)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(259, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(205, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Descrição:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(63, 97)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(135, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nome:"
        '
        'txtBuscaNome
        '
        Me.txtBuscaNome.Location = New System.Drawing.Point(588, 27)
        Me.txtBuscaNome.Name = "txtBuscaNome"
        Me.txtBuscaNome.Size = New System.Drawing.Size(135, 20)
        Me.txtBuscaNome.TabIndex = 6
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Location = New System.Drawing.Point(486, 27)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 22
        Me.lblBuscar.Text = "Buscar"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Location = New System.Drawing.Point(542, 27)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 41
        Me.lblNome.Text = "Nome:"
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(63, 144)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(135, 20)
        Me.txtValor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(19, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Valor:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Enabled = False
        Me.txtQuantidade.Location = New System.Drawing.Point(90, 184)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(68, 20)
        Me.txtQuantidade.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(28, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Quantidade:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(209, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Fornecedor:"
        '
        'cbFornecedor
        '
        Me.cbFornecedor.Enabled = False
        Me.cbFornecedor.FormattingEnabled = True
        Me.cbFornecedor.Location = New System.Drawing.Point(279, 183)
        Me.cbFornecedor.Name = "cbFornecedor"
        Me.cbFornecedor.Size = New System.Drawing.Size(125, 21)
        Me.cbFornecedor.TabIndex = 5
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.Honeydew
        Me.img.Location = New System.Drawing.Point(588, 68)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(120, 120)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 49
        Me.img.TabStop = False
        '
        'btnAddImagem
        '
        Me.btnAddImagem.BackColor = System.Drawing.Color.Transparent
        Me.btnAddImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddImagem.Enabled = False
        Me.btnAddImagem.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAddImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.btnAddImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream
        Me.btnAddImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddImagem.Location = New System.Drawing.Point(717, 168)
        Me.btnAddImagem.Name = "btnAddImagem"
        Me.btnAddImagem.Size = New System.Drawing.Size(20, 20)
        Me.btnAddImagem.TabIndex = 50
        Me.btnAddImagem.Text = "+"
        Me.btnAddImagem.UseVisualStyleBackColor = False
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Enabled = False
        Me.txtValorVenda.Location = New System.Drawing.Point(279, 141)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(123, 20)
        Me.txtValorVenda.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(205, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Valor Venda:"
        '
        'FrmCadProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(751, 473)
        Me.Controls.Add(Me.txtValorVenda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAddImagem)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.cbFornecedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaNome)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCadProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produto"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemover As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbFornecedor As ComboBox
    Friend WithEvents img As PictureBox
    Friend WithEvents btnAddImagem As Button
    Friend WithEvents txtValorVenda As TextBox
    Friend WithEvents Label6 As Label
End Class
