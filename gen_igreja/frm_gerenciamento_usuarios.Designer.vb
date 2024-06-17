<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciamento_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciamento_usuarios))
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.setor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimo_acesso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_setor = New System.Windows.Forms.ComboBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_limpar = New System.Windows.Forms.PictureBox()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.AllowUserToResizeColumns = False
        Me.dgv_usuarios.AllowUserToResizeRows = False
        Me.dgv_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.nome, Me.setor, Me.status, Me.ultimo_acesso, Me.btn_editar, Me.btn_excluir})
        Me.dgv_usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_usuarios.Location = New System.Drawing.Point(5, 20)
        Me.dgv_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        Me.dgv_usuarios.RowHeadersWidth = 51
        Me.dgv_usuarios.RowTemplate.Height = 24
        Me.dgv_usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_usuarios.Size = New System.Drawing.Size(638, 202)
        Me.dgv_usuarios.TabIndex = 3
        '
        'num
        '
        Me.num.FillWeight = 159.7444!
        Me.num.HeaderText = "N°"
        Me.num.MinimumWidth = 6
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Width = 25
        '
        'nome
        '
        Me.nome.FillWeight = 101.4872!
        Me.nome.HeaderText = "Usuário"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 85
        '
        'setor
        '
        Me.setor.FillWeight = 75.81924!
        Me.setor.HeaderText = "Setor"
        Me.setor.MinimumWidth = 6
        Me.setor.Name = "setor"
        Me.setor.ReadOnly = True
        Me.setor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.setor.Width = 85
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.status.Width = 85
        '
        'ultimo_acesso
        '
        Me.ultimo_acesso.FillWeight = 62.9492!
        Me.ultimo_acesso.HeaderText = "Último acesso"
        Me.ultimo_acesso.MinimumWidth = 6
        Me.ultimo_acesso.Name = "ultimo_acesso"
        Me.ultimo_acesso.ReadOnly = True
        Me.ultimo_acesso.Width = 125
        '
        'btn_editar
        '
        Me.btn_editar.HeaderText = "Editar/Exibir Usuário"
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.ReadOnly = True
        Me.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btn_editar.Width = 90
        '
        'btn_excluir
        '
        Me.btn_excluir.HeaderText = "Excluir"
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.ReadOnly = True
        Me.btn_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btn_excluir.Width = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(188, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "STATUS:"
        '
        'cmb_status
        '
        Me.cmb_status.Enabled = False
        Me.cmb_status.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(252, 186)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(241, 21)
        Me.cmb_status.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(196, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SETOR:"
        '
        'cmb_setor
        '
        Me.cmb_setor.Enabled = False
        Me.cmb_setor.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_setor.FormattingEnabled = True
        Me.cmb_setor.Location = New System.Drawing.Point(252, 141)
        Me.cmb_setor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_setor.Name = "cmb_setor"
        Me.cmb_setor.Size = New System.Drawing.Size(241, 21)
        Me.cmb_setor.TabIndex = 2
        '
        'txt_usuario
        '
        Me.txt_usuario.Enabled = False
        Me.txt_usuario.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_usuario.Location = New System.Drawing.Point(252, 97)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(241, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(116, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DE USUÁRIO:"
        '
        'btn_limpar
        '
        Me.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(252, 58)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(34, 34)
        Me.btn_limpar.TabIndex = 16
        Me.btn_limpar.TabStop = False
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.Location = New System.Drawing.Point(278, 231)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(128, 51)
        Me.btn_gravar.TabIndex = 17
        Me.btn_gravar.Text = "ALTERAR DADOS"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_usuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 226)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE USUÁRIOS"
        '
        'frm_gerenciamento_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_setor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_gerenciamento_usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENCIAMENTO DE USUARIOS"
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_setor As ComboBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents btn_limpar As PictureBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents setor As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ultimo_acesso As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir As DataGridViewImageColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
