<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimentacoes
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
        Me.lblTotalDia = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataBuscarIni = New System.Windows.Forms.DateTimePicker()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.DataBuscarFin = New System.Windows.Forms.DateTimePicker()
        Me.lvlTotalEn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvlTotalSai = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalDia
        '
        Me.lblTotalDia.AutoSize = True
        Me.lblTotalDia.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalDia.Location = New System.Drawing.Point(540, 315)
        Me.lblTotalDia.Name = "lblTotalDia"
        Me.lblTotalDia.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalDia.TabIndex = 81
        Me.lblTotalDia.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(481, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Total Dia:"
        '
        'DataBuscarIni
        '
        Me.DataBuscarIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataBuscarIni.Location = New System.Drawing.Point(465, 29)
        Me.DataBuscarIni.Name = "DataBuscarIni"
        Me.DataBuscarIni.Size = New System.Drawing.Size(99, 20)
        Me.DataBuscarIni.TabIndex = 79
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.Honeydew
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(44, 100)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(520, 203)
        Me.grid.TabIndex = 78
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(44, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 77
        Me.txtCodigo.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Location = New System.Drawing.Point(263, 32)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 76
        Me.lblBuscar.Text = "Buscar"
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entradas ", "Saídas"})
        Me.cbEntrada.Location = New System.Drawing.Point(323, 53)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(121, 21)
        Me.cbEntrada.TabIndex = 82
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.BackColor = System.Drawing.Color.Transparent
        Me.rbCPF.Location = New System.Drawing.Point(358, 30)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(101, 17)
        Me.rbCPF.TabIndex = 84
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "Entrada e saída"
        Me.rbCPF.UseVisualStyleBackColor = False
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.BackColor = System.Drawing.Color.Transparent
        Me.rbData.Checked = True
        Me.rbData.Location = New System.Drawing.Point(306, 30)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(51, 17)
        Me.rbData.TabIndex = 83
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data:"
        Me.rbData.UseVisualStyleBackColor = False
        '
        'DataBuscarFin
        '
        Me.DataBuscarFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataBuscarFin.Location = New System.Drawing.Point(465, 55)
        Me.DataBuscarFin.Name = "DataBuscarFin"
        Me.DataBuscarFin.Size = New System.Drawing.Size(99, 20)
        Me.DataBuscarFin.TabIndex = 85
        '
        'lvlTotalEn
        '
        Me.lvlTotalEn.AutoSize = True
        Me.lvlTotalEn.BackColor = System.Drawing.Color.Transparent
        Me.lvlTotalEn.Location = New System.Drawing.Point(126, 315)
        Me.lvlTotalEn.Name = "lvlTotalEn"
        Me.lvlTotalEn.Size = New System.Drawing.Size(10, 13)
        Me.lvlTotalEn.TabIndex = 87
        Me.lvlTotalEn.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(41, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Total Entradas:"
        '
        'lvlTotalSai
        '
        Me.lvlTotalSai.AutoSize = True
        Me.lvlTotalSai.BackColor = System.Drawing.Color.Transparent
        Me.lvlTotalSai.Location = New System.Drawing.Point(227, 315)
        Me.lvlTotalSai.Name = "lvlTotalSai"
        Me.lvlTotalSai.Size = New System.Drawing.Size(10, 13)
        Me.lvlTotalSai.TabIndex = 89
        Me.lvlTotalSai.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(142, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Total Saídas:"
        '
        'frmMovimentacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.fundo_sistemas_tamanho_maior
        Me.ClientSize = New System.Drawing.Size(580, 352)
        Me.Controls.Add(Me.lvlTotalSai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvlTotalEn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataBuscarFin)
        Me.Controls.Add(Me.rbCPF)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.cbEntrada)
        Me.Controls.Add(Me.lblTotalDia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataBuscarIni)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMovimentacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradas e Saídas"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalDia As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataBuscarIni As DateTimePicker
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbData As RadioButton
    Friend WithEvents DataBuscarFin As DateTimePicker
    Friend WithEvents lvlTotalEn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvlTotalSai As Label
    Friend WithEvents Label4 As Label
End Class
