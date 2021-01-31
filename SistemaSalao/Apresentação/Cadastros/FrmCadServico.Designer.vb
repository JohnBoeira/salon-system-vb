<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadServico))
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtServico = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnRemover.Location = New System.Drawing.Point(275, 311)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(65, 65)
        Me.btnRemover.TabIndex = 37
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
        Me.btnEditar.Location = New System.Drawing.Point(191, 311)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 36
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
        Me.btnSalvar.Location = New System.Drawing.Point(108, 311)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
        Me.btnSalvar.TabIndex = 35
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
        Me.btnNovo.Location = New System.Drawing.Point(27, 311)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(65, 65)
        Me.btnNovo.TabIndex = 34
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.Honeydew
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(27, 83)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(313, 206)
        Me.grid.TabIndex = 33
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 32
        Me.txtCodigo.Visible = False
        '
        'txtServico
        '
        Me.txtServico.Enabled = False
        Me.txtServico.Location = New System.Drawing.Point(63, 47)
        Me.txtServico.Name = "txtServico"
        Me.txtServico.Size = New System.Drawing.Size(141, 20)
        Me.txtServico.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Serviço:"
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(253, 48)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(87, 20)
        Me.txtValor.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(210, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Valor:"
        '
        'FrmCadServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.fundo_sistemas
        Me.ClientSize = New System.Drawing.Size(369, 401)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtServico)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCadServico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadServico"
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
    Friend WithEvents txtServico As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
End Class
