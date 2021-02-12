<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFuncionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProduto = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroDeHoráriosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutroUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddCliente = New System.Windows.Forms.Button()
        Me.btnAgendamento = New System.Windows.Forms.Button()
        Me.btnQuadroHorario = New System.Windows.Forms.Button()
        Me.btnVenda = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lvlUsuario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvlEsp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.TimerData = New System.Windows.Forms.Timer(Me.components)
        Me.EntradasESaídasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.MovimentaçõesToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(978, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.menuFuncionario, Me.ServiçosToolStripMenuItem1, Me.EsToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = Global.SistemaSalao.My.Resources.Resources.add
        Me.CadastrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'menuFuncionario
        '
        Me.menuFuncionario.Enabled = False
        Me.menuFuncionario.Name = "menuFuncionario"
        Me.menuFuncionario.Size = New System.Drawing.Size(145, 22)
        Me.menuFuncionario.Text = "Funcionários"
        '
        'ServiçosToolStripMenuItem1
        '
        Me.ServiçosToolStripMenuItem1.Name = "ServiçosToolStripMenuItem1"
        Me.ServiçosToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ServiçosToolStripMenuItem1.Text = "Serviços"
        '
        'EsToolStripMenuItem
        '
        Me.EsToolStripMenuItem.Name = "EsToolStripMenuItem"
        Me.EsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EsToolStripMenuItem.Text = "Especilidade"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuProduto, Me.EntradasToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Image = Global.SistemaSalao.My.Resources.Resources.produto
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'menuProduto
        '
        Me.menuProduto.Enabled = False
        Me.menuProduto.Name = "menuProduto"
        Me.menuProduto.Size = New System.Drawing.Size(121, 22)
        Me.menuProduto.Text = "Cadastro"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendamentoToolStripMenuItem, Me.QuadroDeHoráriosToolStripMenuItem1})
        Me.ServiçosToolStripMenuItem.Image = Global.SistemaSalao.My.Resources.Resources.servicos
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'AgendamentoToolStripMenuItem
        '
        Me.AgendamentoToolStripMenuItem.Name = "AgendamentoToolStripMenuItem"
        Me.AgendamentoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AgendamentoToolStripMenuItem.Text = "Agendamento"
        '
        'QuadroDeHoráriosToolStripMenuItem1
        '
        Me.QuadroDeHoráriosToolStripMenuItem1.Name = "QuadroDeHoráriosToolStripMenuItem1"
        Me.QuadroDeHoráriosToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.QuadroDeHoráriosToolStripMenuItem1.Text = "Quadro de horários"
        '
        'MovimentaçõesToolStripMenuItem
        '
        Me.MovimentaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuadroDeHoráriosToolStripMenuItem, Me.GastosToolStripMenuItem, Me.PagamentosToolStripMenuItem, Me.EntradasESaídasToolStripMenuItem})
        Me.MovimentaçõesToolStripMenuItem.Image = CType(resources.GetObject("MovimentaçõesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
        Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
        '
        'QuadroDeHoráriosToolStripMenuItem
        '
        Me.QuadroDeHoráriosToolStripMenuItem.Name = "QuadroDeHoráriosToolStripMenuItem"
        Me.QuadroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuadroDeHoráriosToolStripMenuItem.Text = "Vendas"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'PagamentosToolStripMenuItem
        '
        Me.PagamentosToolStripMenuItem.Name = "PagamentosToolStripMenuItem"
        Me.PagamentosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PagamentosToolStripMenuItem.Text = "Pagamentos"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem1, Me.ClientesToolStripMenuItem1})
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'ProdutosToolStripMenuItem1
        '
        Me.ProdutosToolStripMenuItem1.Name = "ProdutosToolStripMenuItem1"
        Me.ProdutosToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ProdutosToolStripMenuItem1.Text = "Produtos"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.OutroUsuárioToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout "
        '
        'OutroUsuárioToolStripMenuItem
        '
        Me.OutroUsuárioToolStripMenuItem.Name = "OutroUsuárioToolStripMenuItem"
        Me.OutroUsuárioToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OutroUsuárioToolStripMenuItem.Text = "Outro Usuário"
        '
        'btnAddCliente
        '
        Me.btnAddCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnAddCliente.FlatAppearance.BorderSize = 0
        Me.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream
        Me.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCliente.Image = CType(resources.GetObject("btnAddCliente.Image"), System.Drawing.Image)
        Me.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddCliente.Location = New System.Drawing.Point(12, 27)
        Me.btnAddCliente.Name = "btnAddCliente"
        Me.btnAddCliente.Size = New System.Drawing.Size(63, 70)
        Me.btnAddCliente.TabIndex = 2
        Me.btnAddCliente.UseVisualStyleBackColor = False
        '
        'btnAgendamento
        '
        Me.btnAgendamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnAgendamento.FlatAppearance.BorderSize = 0
        Me.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream
        Me.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendamento.Image = CType(resources.GetObject("btnAgendamento.Image"), System.Drawing.Image)
        Me.btnAgendamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgendamento.Location = New System.Drawing.Point(85, 27)
        Me.btnAgendamento.Name = "btnAgendamento"
        Me.btnAgendamento.Size = New System.Drawing.Size(63, 70)
        Me.btnAgendamento.TabIndex = 3
        Me.btnAgendamento.UseVisualStyleBackColor = False
        '
        'btnQuadroHorario
        '
        Me.btnQuadroHorario.BackColor = System.Drawing.Color.Transparent
        Me.btnQuadroHorario.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnQuadroHorario.FlatAppearance.BorderSize = 0
        Me.btnQuadroHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream
        Me.btnQuadroHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuadroHorario.Image = CType(resources.GetObject("btnQuadroHorario.Image"), System.Drawing.Image)
        Me.btnQuadroHorario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuadroHorario.Location = New System.Drawing.Point(159, 27)
        Me.btnQuadroHorario.Name = "btnQuadroHorario"
        Me.btnQuadroHorario.Size = New System.Drawing.Size(63, 70)
        Me.btnQuadroHorario.TabIndex = 4
        Me.btnQuadroHorario.UseVisualStyleBackColor = False
        '
        'btnVenda
        '
        Me.btnVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnVenda.FlatAppearance.BorderSize = 0
        Me.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream
        Me.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenda.Image = CType(resources.GetObject("btnVenda.Image"), System.Drawing.Image)
        Me.btnVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVenda.Location = New System.Drawing.Point(235, 27)
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(63, 70)
        Me.btnVenda.TabIndex = 5
        Me.btnVenda.UseVisualStyleBackColor = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(699, 38)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 31)
        Me.lblUsuario.TabIndex = 6
        '
        'lvlUsuario
        '
        Me.lvlUsuario.AutoSize = True
        Me.lvlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lvlUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lvlUsuario.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlUsuario.Location = New System.Drawing.Point(64, 32)
        Me.lvlUsuario.Name = "lvlUsuario"
        Me.lvlUsuario.Size = New System.Drawing.Size(51, 16)
        Me.lvlUsuario.TabIndex = 7
        Me.lvlUsuario.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lvlEsp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lvlUsuario)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(709, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 82)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do funcionário"
        '
        'lvlEsp
        '
        Me.lvlEsp.AutoSize = True
        Me.lvlEsp.BackColor = System.Drawing.Color.Transparent
        Me.lvlEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lvlEsp.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlEsp.Location = New System.Drawing.Point(102, 54)
        Me.lvlEsp.Name = "lvlEsp"
        Me.lvlEsp.Size = New System.Drawing.Size(51, 16)
        Me.lvlEsp.TabIndex = 10
        Me.lvlEsp.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Especialidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(702, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(702, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hora:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblData.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(750, 128)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(18, 16)
        Me.lblData.TabIndex = 11
        Me.lblData.Text = "D"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHora.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(750, 157)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(17, 16)
        Me.lblHora.TabIndex = 12
        Me.lblHora.Text = "H"
        '
        'TimerData
        '
        Me.TimerData.Enabled = True
        '
        'EntradasESaídasToolStripMenuItem
        '
        Me.EntradasESaídasToolStripMenuItem.Name = "EntradasESaídasToolStripMenuItem"
        Me.EntradasESaídasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntradasESaídasToolStripMenuItem.Text = "Entradas e Saídas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.menu_system
        Me.ClientSize = New System.Drawing.Size(978, 477)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnVenda)
        Me.Controls.Add(Me.btnQuadroHorario)
        Me.Controls.Add(Me.btnAgendamento)
        Me.Controls.Add(Me.btnAddCliente)
        Me.Controls.Add(Me.menuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuPrincipal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "Menu Principal"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuFuncionario As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuProduto As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadroDeHoráriosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutroUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAddCliente As Button
    Friend WithEvents btnAgendamento As Button
    Friend WithEvents btnQuadroHorario As Button
    Friend WithEvents btnVenda As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lvlUsuario As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lvlEsp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents TimerData As Timer
    Friend WithEvents ProdutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EntradasESaídasToolStripMenuItem As ToolStripMenuItem
End Class
