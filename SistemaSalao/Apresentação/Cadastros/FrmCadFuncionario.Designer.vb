<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadFuncionario))
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtBuscaCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvlEspecialidade = New System.Windows.Forms.Label()
        Me.cbEsp = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
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
        Me.grid.Location = New System.Drawing.Point(20, 135)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(710, 191)
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
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(615, 58)
        Me.txtTelefone.Mask = "(00)00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(102, 20)
        Me.txtTelefone.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(557, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Telefone:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(429, 59)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(111, 20)
        Me.txtEndereco.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(367, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Endereço:"
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(259, 58)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(86, 20)
        Me.txtCPF.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(223, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CPF:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(61, 58)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(135, 20)
        Me.txtNome.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nome:"
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.BackColor = System.Drawing.Color.Transparent
        Me.rbCPF.Location = New System.Drawing.Point(534, 15)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(48, 17)
        Me.rbCPF.TabIndex = 30
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF:"
        Me.rbCPF.UseVisualStyleBackColor = False
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.BackColor = System.Drawing.Color.Transparent
        Me.rbNome.Checked = True
        Me.rbNome.Location = New System.Drawing.Point(472, 15)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(56, 17)
        Me.rbNome.TabIndex = 29
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome:"
        Me.rbNome.UseVisualStyleBackColor = False
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
        Me.Label1.Location = New System.Drawing.Point(426, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Buscar"
        '
        'lvlEspecialidade
        '
        Me.lvlEspecialidade.AutoSize = True
        Me.lvlEspecialidade.BackColor = System.Drawing.Color.Transparent
        Me.lvlEspecialidade.Location = New System.Drawing.Point(17, 97)
        Me.lvlEspecialidade.Name = "lvlEspecialidade"
        Me.lvlEspecialidade.Size = New System.Drawing.Size(76, 13)
        Me.lvlEspecialidade.TabIndex = 41
        Me.lvlEspecialidade.Text = "Especialidade:"
        '
        'cbEsp
        '
        Me.cbEsp.Enabled = False
        Me.cbEsp.FormattingEnabled = True
        Me.cbEsp.Location = New System.Drawing.Point(99, 94)
        Me.cbEsp.Name = "cbEsp"
        Me.cbEsp.Size = New System.Drawing.Size(246, 21)
        Me.cbEsp.TabIndex = 42
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(429, 94)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(111, 20)
        Me.txtUsuario.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(367, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Usuário:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(568, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Enabled = False
        Me.txtSenha.Location = New System.Drawing.Point(615, 94)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(102, 20)
        Me.txtSenha.TabIndex = 46
        '
        'FrmCadFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.fundo_sistemas_tamanho_maior
        Me.ClientSize = New System.Drawing.Size(747, 421)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cbEsp)
        Me.Controls.Add(Me.lvlEspecialidade)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbCPF)
        Me.Controls.Add(Me.rbNome)
        Me.Controls.Add(Me.txtBuscaCPF)
        Me.Controls.Add(Me.txtBuscaNome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCadFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de funcionários"
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
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtBuscaCPF As MaskedTextBox
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lvlEspecialidade As Label
    Friend WithEvents cbEsp As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSenha As TextBox
End Class
