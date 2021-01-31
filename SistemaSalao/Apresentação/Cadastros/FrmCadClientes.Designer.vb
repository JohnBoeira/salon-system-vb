<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.txtBuscaCPF = New System.Windows.Forms.MaskedTextBox()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(425, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'txtBuscaNome
        '
        Me.txtBuscaNome.Location = New System.Drawing.Point(594, 21)
        Me.txtBuscaNome.Name = "txtBuscaNome"
        Me.txtBuscaNome.Size = New System.Drawing.Size(135, 20)
        Me.txtBuscaNome.TabIndex = 3
        Me.txtBuscaNome.Visible = False
        '
        'txtBuscaCPF
        '
        Me.txtBuscaCPF.Location = New System.Drawing.Point(594, 21)
        Me.txtBuscaCPF.Mask = "000,000,000-00"
        Me.txtBuscaCPF.Name = "txtBuscaCPF"
        Me.txtBuscaCPF.Size = New System.Drawing.Size(135, 20)
        Me.txtBuscaCPF.TabIndex = 5
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.BackColor = System.Drawing.Color.Transparent
        Me.rbNome.Checked = True
        Me.rbNome.Location = New System.Drawing.Point(471, 19)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(56, 17)
        Me.rbNome.TabIndex = 5
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome:"
        Me.rbNome.UseVisualStyleBackColor = False
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.BackColor = System.Drawing.Color.Transparent
        Me.rbCPF.Location = New System.Drawing.Point(533, 19)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(48, 17)
        Me.rbCPF.TabIndex = 6
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF:"
        Me.rbCPF.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(60, 83)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(135, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(222, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CPF:"
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(258, 83)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(86, 20)
        Me.txtCPF.TabIndex = 2
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(442, 84)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(111, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(380, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Endereço:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(643, 83)
        Me.txtTelefone.Mask = "(00)00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(86, 20)
        Me.txtTelefone.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(585, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telefone:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(30, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 16
        Me.txtCodigo.Visible = False
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.Honeydew
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(19, 137)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(710, 193)
        Me.grid.TabIndex = 17
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
        Me.btnNovo.Location = New System.Drawing.Point(187, 344)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(65, 65)
        Me.btnNovo.TabIndex = 18
        Me.btnNovo.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(293, 344)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
        Me.btnSalvar.TabIndex = 19
        Me.btnSalvar.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(400, 344)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 20
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnRemover.Location = New System.Drawing.Point(507, 344)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(65, 65)
        Me.btnRemover.TabIndex = 21
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'FrmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(747, 421)
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
        Me.Name = "FrmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de cliente"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents txtBuscaCPF As MaskedTextBox
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents grid As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnRemover As Button
End Class
