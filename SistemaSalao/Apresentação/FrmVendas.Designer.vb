<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendas))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnBuscarClientes = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.DataBuscar = New System.Windows.Forms.DateTimePicker()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(234, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Quantidade:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(88, 120)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(92, 20)
        Me.txtCliente.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(44, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Cliente:"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.Honeydew
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(31, 176)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(562, 145)
        Me.grid.TabIndex = 57
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(63, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 56
        Me.txtCodigo.Visible = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Enabled = False
        Me.txtQuantidade.Location = New System.Drawing.Point(310, 88)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(103, 20)
        Me.txtQuantidade.TabIndex = 50
        Me.txtQuantidade.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(44, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Produto: "
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Location = New System.Drawing.Point(407, 21)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 54
        Me.lblBuscar.Text = "Buscar"
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.Honeydew
        Me.img.Location = New System.Drawing.Point(443, 50)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(120, 110)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 64
        Me.img.TabStop = False
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
        Me.btnRemover.Location = New System.Drawing.Point(431, 345)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(65, 65)
        Me.btnRemover.TabIndex = 61
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
        Me.btnEditar.Location = New System.Drawing.Point(324, 345)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 60
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
        Me.btnSalvar.Location = New System.Drawing.Point(217, 345)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
        Me.btnSalvar.TabIndex = 59
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
        Me.btnNovo.Location = New System.Drawing.Point(111, 345)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(65, 65)
        Me.btnNovo.TabIndex = 58
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnBuscarClientes
        '
        Me.btnBuscarClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarClientes.Enabled = False
        Me.btnBuscarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnBuscarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarClientes.Location = New System.Drawing.Point(186, 118)
        Me.btnBuscarClientes.Name = "btnBuscarClientes"
        Me.btnBuscarClientes.Size = New System.Drawing.Size(37, 23)
        Me.btnBuscarClientes.TabIndex = 65
        Me.btnBuscarClientes.Text = "Ir"
        Me.btnBuscarClientes.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(44, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Valor: "
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(88, 147)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(135, 20)
        Me.txtValor.TabIndex = 66
        Me.txtValor.Text = "00"
        '
        'DataBuscar
        '
        Me.DataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataBuscar.Location = New System.Drawing.Point(464, 17)
        Me.DataBuscar.Name = "DataBuscar"
        Me.DataBuscar.Size = New System.Drawing.Size(99, 20)
        Me.DataBuscar.TabIndex = 68
        '
        'cbProduto
        '
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(88, 87)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(135, 21)
        Me.cbProduto.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(265, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(310, 150)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtTotal.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(258, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Estoque:"
        '
        'txtEstoque
        '
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Location = New System.Drawing.Point(310, 117)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(103, 20)
        Me.txtEstoque.TabIndex = 72
        '
        'FrmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.fundo_sistemas_tamanho_maior
        Me.ClientSize = New System.Drawing.Size(605, 428)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cbProduto)
        Me.Controls.Add(Me.DataBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnBuscarClientes)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBuscar)
        Me.MaximizeBox = False
        Me.Name = "FrmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVendas"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnBuscarClientes As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents DataBuscar As DateTimePicker
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEstoque As TextBox
End Class
