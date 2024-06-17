<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.btn_membros = New System.Windows.Forms.Button()
        Me.dgv_pendencias = New System.Windows.Forms.DataGridView()
        Me.titulo_pendencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.urgencia_pendencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_pendencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_pendencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expandir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.id_pendencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_urgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_criador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_inverter_fluxo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_add_pendencia = New System.Windows.Forms.ToolStripButton()
        Me.btn_financas = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_nome_usuario = New System.Windows.Forms.Label()
        Me.lbl_setor = New System.Windows.Forms.Label()
        Me.btn_logoff = New System.Windows.Forms.Button()
        CType(Me.dgv_pendencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_membros
        '
        Me.btn_membros.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_membros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_membros.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_membros.Image = CType(resources.GetObject("btn_membros.Image"), System.Drawing.Image)
        Me.btn_membros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_membros.Location = New System.Drawing.Point(0, 256)
        Me.btn_membros.Name = "btn_membros"
        Me.btn_membros.Size = New System.Drawing.Size(237, 73)
        Me.btn_membros.TabIndex = 1
        Me.btn_membros.Text = "MEMBROS"
        Me.btn_membros.UseVisualStyleBackColor = False
        '
        'dgv_pendencias
        '
        Me.dgv_pendencias.AllowUserToAddRows = False
        Me.dgv_pendencias.AllowUserToDeleteRows = False
        Me.dgv_pendencias.AllowUserToResizeColumns = False
        Me.dgv_pendencias.AllowUserToResizeRows = False
        Me.dgv_pendencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dgv_pendencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.titulo_pendencia, Me.urgencia_pendencia, Me.data_pendencia, Me.status_pendencia, Me.expandir, Me.id_pendencia, Me.id_urgencia, Me.nome_criador})
        Me.dgv_pendencias.Location = New System.Drawing.Point(0, 48)
        Me.dgv_pendencias.Name = "dgv_pendencias"
        Me.dgv_pendencias.ReadOnly = True
        Me.dgv_pendencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_pendencias.Size = New System.Drawing.Size(655, 400)
        Me.dgv_pendencias.TabIndex = 2
        '
        'titulo_pendencia
        '
        Me.titulo_pendencia.HeaderText = "Título"
        Me.titulo_pendencia.Name = "titulo_pendencia"
        Me.titulo_pendencia.ReadOnly = True
        Me.titulo_pendencia.Width = 200
        '
        'urgencia_pendencia
        '
        Me.urgencia_pendencia.HeaderText = "Nível de Urgência"
        Me.urgencia_pendencia.Name = "urgencia_pendencia"
        Me.urgencia_pendencia.ReadOnly = True
        Me.urgencia_pendencia.Width = 150
        '
        'data_pendencia
        '
        Me.data_pendencia.HeaderText = "Data"
        Me.data_pendencia.Name = "data_pendencia"
        Me.data_pendencia.ReadOnly = True
        '
        'status_pendencia
        '
        Me.status_pendencia.HeaderText = "Status"
        Me.status_pendencia.Name = "status_pendencia"
        Me.status_pendencia.ReadOnly = True
        '
        'expandir
        '
        Me.expandir.HeaderText = "Expandir"
        Me.expandir.Image = CType(resources.GetObject("expandir.Image"), System.Drawing.Image)
        Me.expandir.Name = "expandir"
        Me.expandir.ReadOnly = True
        Me.expandir.Width = 80
        '
        'id_pendencia
        '
        Me.id_pendencia.HeaderText = "id_pendencia"
        Me.id_pendencia.Name = "id_pendencia"
        Me.id_pendencia.ReadOnly = True
        Me.id_pendencia.Visible = False
        Me.id_pendencia.Width = 5
        '
        'id_urgencia
        '
        Me.id_urgencia.HeaderText = "id_urgencia"
        Me.id_urgencia.Name = "id_urgencia"
        Me.id_urgencia.ReadOnly = True
        Me.id_urgencia.Visible = False
        '
        'nome_criador
        '
        Me.nome_criador.HeaderText = "nome_criador"
        Me.nome_criador.Name = "nome_criador"
        Me.nome_criador.ReadOnly = True
        Me.nome_criador.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgv_pendencias)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(243, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 447)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE PENDÊNCIAS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.cmb_filtro, Me.btn_inverter_fluxo, Me.ToolStripLabel3, Me.btn_add_pendencia})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(652, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel2.Text = "Filtro:"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.AutoSize = False
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(135, 25)
        '
        'btn_inverter_fluxo
        '
        Me.btn_inverter_fluxo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_inverter_fluxo.Image = CType(resources.GetObject("btn_inverter_fluxo.Image"), System.Drawing.Image)
        Me.btn_inverter_fluxo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_inverter_fluxo.Name = "btn_inverter_fluxo"
        Me.btn_inverter_fluxo.Size = New System.Drawing.Size(23, 22)
        Me.btn_inverter_fluxo.Text = "ToolStripButton2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripLabel3.Text = "Adcionar Pendência"
        '
        'btn_add_pendencia
        '
        Me.btn_add_pendencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_add_pendencia.Image = CType(resources.GetObject("btn_add_pendencia.Image"), System.Drawing.Image)
        Me.btn_add_pendencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_add_pendencia.Name = "btn_add_pendencia"
        Me.btn_add_pendencia.Size = New System.Drawing.Size(23, 22)
        Me.btn_add_pendencia.Text = "ToolStripButton1"
        '
        'btn_financas
        '
        Me.btn_financas.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_financas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_financas.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_financas.Image = CType(resources.GetObject("btn_financas.Image"), System.Drawing.Image)
        Me.btn_financas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_financas.Location = New System.Drawing.Point(0, 330)
        Me.btn_financas.Name = "btn_financas"
        Me.btn_financas.Size = New System.Drawing.Size(237, 73)
        Me.btn_financas.TabIndex = 4
        Me.btn_financas.Text = "FINANÇAS"
        Me.btn_financas.UseVisualStyleBackColor = False
        '
        'btn_usuarios
        '
        Me.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_usuarios.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Image = CType(resources.GetObject("btn_usuarios.Image"), System.Drawing.Image)
        Me.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuarios.Location = New System.Drawing.Point(0, 404)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(237, 73)
        Me.btn_usuarios.TabIndex = 5
        Me.btn_usuarios.Text = "USUÁRIOS"
        Me.btn_usuarios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-31, -27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 283)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lbl_nome_usuario
        '
        Me.lbl_nome_usuario.AutoSize = True
        Me.lbl_nome_usuario.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_nome_usuario.Location = New System.Drawing.Point(206, 491)
        Me.lbl_nome_usuario.Name = "lbl_nome_usuario"
        Me.lbl_nome_usuario.Size = New System.Drawing.Size(50, 18)
        Me.lbl_nome_usuario.TabIndex = 8
        Me.lbl_nome_usuario.Text = "Label1"
        '
        'lbl_setor
        '
        Me.lbl_setor.AutoSize = True
        Me.lbl_setor.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_setor.Location = New System.Drawing.Point(12, 491)
        Me.lbl_setor.Name = "lbl_setor"
        Me.lbl_setor.Size = New System.Drawing.Size(53, 18)
        Me.lbl_setor.TabIndex = 9
        Me.lbl_setor.Text = "Label2"
        '
        'btn_logoff
        '
        Me.btn_logoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logoff.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logoff.Image = CType(resources.GetObject("btn_logoff.Image"), System.Drawing.Image)
        Me.btn_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logoff.Location = New System.Drawing.Point(738, 478)
        Me.btn_logoff.Name = "btn_logoff"
        Me.btn_logoff.Size = New System.Drawing.Size(160, 38)
        Me.btn_logoff.TabIndex = 10
        Me.btn_logoff.Text = "ENCERRAR SESSÃO"
        Me.btn_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_logoff.UseVisualStyleBackColor = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(904, 518)
        Me.Controls.Add(Me.btn_logoff)
        Me.Controls.Add(Me.lbl_setor)
        Me.Controls.Add(Me.lbl_nome_usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_financas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_membros)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(920, 557)
        Me.MinimumSize = New System.Drawing.Size(920, 557)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPAL"
        CType(Me.dgv_pendencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_membros As Button
    Friend WithEvents dgv_pendencias As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents btn_add_pendencia As ToolStripButton
    Friend WithEvents btn_financas As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_inverter_fluxo As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_nome_usuario As Label
    Friend WithEvents lbl_setor As Label
    Friend WithEvents btn_logoff As Button
    Friend WithEvents titulo_pendencia As DataGridViewTextBoxColumn
    Friend WithEvents urgencia_pendencia As DataGridViewTextBoxColumn
    Friend WithEvents data_pendencia As DataGridViewTextBoxColumn
    Friend WithEvents status_pendencia As DataGridViewTextBoxColumn
    Friend WithEvents expandir As DataGridViewImageColumn
    Friend WithEvents id_pendencia As DataGridViewTextBoxColumn
    Friend WithEvents id_urgencia As DataGridViewTextBoxColumn
    Friend WithEvents nome_criador As DataGridViewTextBoxColumn
End Class
