<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listar_membros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listar_membros))
        Me.dgv_lista_membros = New System.Windows.Forms.DataGridView()
        Me.num_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idade_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_membro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar_membro = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir_membro = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_redefinir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa = New System.Windows.Forms.ToolStripTextBox()
        Me.lbl_membro = New System.Windows.Forms.ToolStripLabel()
        Me.btn_add_membro = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgv_lista_membros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_lista_membros
        '
        Me.dgv_lista_membros.AllowUserToAddRows = False
        Me.dgv_lista_membros.AllowUserToDeleteRows = False
        Me.dgv_lista_membros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dgv_lista_membros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_membros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_membro, Me.id_membro, Me.nome_membro, Me.idade_membro, Me.genero_membro, Me.email_membro, Me.telefone_membro, Me.status_membro, Me.editar_membro, Me.excluir_membro})
        Me.dgv_lista_membros.Location = New System.Drawing.Point(6, 44)
        Me.dgv_lista_membros.Name = "dgv_lista_membros"
        Me.dgv_lista_membros.ReadOnly = True
        Me.dgv_lista_membros.Size = New System.Drawing.Size(1058, 420)
        Me.dgv_lista_membros.TabIndex = 0
        '
        'num_membro
        '
        Me.num_membro.HeaderText = "Nº"
        Me.num_membro.Name = "num_membro"
        Me.num_membro.ReadOnly = True
        Me.num_membro.Width = 25
        '
        'id_membro
        '
        Me.id_membro.HeaderText = "ID do Membro"
        Me.id_membro.Name = "id_membro"
        Me.id_membro.ReadOnly = True
        '
        'nome_membro
        '
        Me.nome_membro.HeaderText = "Nome Completo"
        Me.nome_membro.Name = "nome_membro"
        Me.nome_membro.ReadOnly = True
        Me.nome_membro.Width = 200
        '
        'idade_membro
        '
        Me.idade_membro.HeaderText = "Idade"
        Me.idade_membro.Name = "idade_membro"
        Me.idade_membro.ReadOnly = True
        Me.idade_membro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.idade_membro.Width = 40
        '
        'genero_membro
        '
        Me.genero_membro.HeaderText = "Gênero"
        Me.genero_membro.Name = "genero_membro"
        Me.genero_membro.ReadOnly = True
        Me.genero_membro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.genero_membro.Width = 50
        '
        'email_membro
        '
        Me.email_membro.HeaderText = "E-mail"
        Me.email_membro.Name = "email_membro"
        Me.email_membro.ReadOnly = True
        Me.email_membro.Width = 200
        '
        'telefone_membro
        '
        Me.telefone_membro.HeaderText = "Telefone"
        Me.telefone_membro.Name = "telefone_membro"
        Me.telefone_membro.ReadOnly = True
        Me.telefone_membro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'status_membro
        '
        Me.status_membro.HeaderText = "Status"
        Me.status_membro.Name = "status_membro"
        Me.status_membro.ReadOnly = True
        Me.status_membro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'editar_membro
        '
        Me.editar_membro.HeaderText = "Expandir Dados/Editar Membro"
        Me.editar_membro.Image = CType(resources.GetObject("editar_membro.Image"), System.Drawing.Image)
        Me.editar_membro.Name = "editar_membro"
        Me.editar_membro.ReadOnly = True
        Me.editar_membro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.editar_membro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'excluir_membro
        '
        Me.excluir_membro.HeaderText = "Excluir Membro"
        Me.excluir_membro.Image = CType(resources.GetObject("excluir_membro.Image"), System.Drawing.Image)
        Me.excluir_membro.Name = "excluir_membro"
        Me.excluir_membro.ReadOnly = True
        Me.excluir_membro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.excluir_membro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgv_lista_membros)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1069, 470)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE MEMBROS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_redefinir, Me.ToolStripLabel2, Me.cmb_filtro, Me.ToolStripLabel1, Me.txt_pesquisa, Me.lbl_membro, Me.btn_add_membro})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1063, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_redefinir
        '
        Me.btn_redefinir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_redefinir.Image = CType(resources.GetObject("btn_redefinir.Image"), System.Drawing.Image)
        Me.btn_redefinir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_redefinir.Name = "btn_redefinir"
        Me.btn_redefinir.Size = New System.Drawing.Size(23, 22)
        Me.btn_redefinir.Text = "Limpar Filtro"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel2.Text = "Filtro:"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel1.Text = "Pesquisar:"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(100, 25)
        '
        'lbl_membro
        '
        Me.lbl_membro.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_membro.Name = "lbl_membro"
        Me.lbl_membro.Size = New System.Drawing.Size(107, 22)
        Me.lbl_membro.Text = "Adcionar Membro"
        '
        'btn_add_membro
        '
        Me.btn_add_membro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_add_membro.Image = CType(resources.GetObject("btn_add_membro.Image"), System.Drawing.Image)
        Me.btn_add_membro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_add_membro.Name = "btn_add_membro"
        Me.btn_add_membro.Size = New System.Drawing.Size(23, 22)
        Me.btn_add_membro.Text = "ToolStripButton1"
        '
        'frm_listar_membros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_listar_membros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTAGEM DE MEMBROS"
        CType(Me.dgv_lista_membros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_lista_membros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisa As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents btn_add_membro As ToolStripButton
    Friend WithEvents lbl_membro As ToolStripLabel
    Friend WithEvents num_membro As DataGridViewTextBoxColumn
    Friend WithEvents id_membro As DataGridViewTextBoxColumn
    Friend WithEvents nome_membro As DataGridViewTextBoxColumn
    Friend WithEvents idade_membro As DataGridViewTextBoxColumn
    Friend WithEvents genero_membro As DataGridViewTextBoxColumn
    Friend WithEvents email_membro As DataGridViewTextBoxColumn
    Friend WithEvents telefone_membro As DataGridViewTextBoxColumn
    Friend WithEvents status_membro As DataGridViewTextBoxColumn
    Friend WithEvents editar_membro As DataGridViewImageColumn
    Friend WithEvents excluir_membro As DataGridViewImageColumn
    Friend WithEvents btn_redefinir As ToolStripButton
End Class
