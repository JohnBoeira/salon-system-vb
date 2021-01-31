<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadFornecedor))
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.Transparent
        Me.btnRemover.BackgroundImage = CType(resources.GetObject("btnRemover.BackgroundImage"), System.Drawing.Image)
        Me.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemover.FlatAppearance.BorderSize = 0
        Me.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Location = New System.Drawing.Point(508, 340)
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
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(401, 340)
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
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(294, 340)
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
        Me.btnNovo.Location = New System.Drawing.Point(188, 340)
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
        Me.grid.Location = New System.Drawing.Point(20, 173)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(710, 153)
        Me.grid.TabIndex = 36
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(31, 17)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 35
        Me.txtCodigo.Visible = False
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(278, 79)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(226, 20)
        Me.txtEndereco.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(216, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Endereço:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(61, 79)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(135, 20)
        Me.txtNome.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nome:"
        '
        'txtBuscaCPF
        '
        Me.txtBuscaCPF.Location = New System.Drawing.Point(595, 17)
        Me.txtBuscaCPF.Mask = "000,000,000-00"
        Me.txtBuscaCPF.Name = "txtBuscaCPF"
        Me.txtBuscaCPF.Size = New System.Drawing.Size(135, 20)
        Me.txtBuscaCPF.TabIndex = 28
        '
        'txtBuscaNome
        '
        Me.txtBuscaNome.Location = New System.Drawing.Point(595, 17)
        Me.txtBuscaNome.Name = "txtBuscaNome"
        Me.txtBuscaNome.Size = New System.Drawing.Size(135, 20)
        Me.txtBuscaNome.TabIndex = 26
        Me.txtBuscaNome.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(535, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nome:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(582, 79)
        Me.txtTelefone.Mask = "(00)00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(148, 20)
        Me.txtTelefone.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(524, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Telefone:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(61, 120)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(192, 20)
        Me.txtEmail.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Email:"
        '
        'txtProduto
        '
        Me.txtProduto.Enabled = False
        Me.txtProduto.Location = New System.Drawing.Point(334, 120)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(170, 20)
        Me.txtProduto.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(280, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Produto:"
        '
        'FrmCadFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.fundo_sistemas_tamanho_maior
        Me.ClientSize = New System.Drawing.Size(747, 421)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaCPF)
        Me.Controls.Add(Me.txtBuscaNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCadFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadFornecedor"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemover As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaCPF As MaskedTextBox
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents Label6 As Label
End Class
