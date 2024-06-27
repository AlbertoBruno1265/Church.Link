<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pendencias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_titulo_pendencia = New System.Windows.Forms.TextBox()
        Me.cmb_urgencia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_setor = New System.Windows.Forms.Label()
        Me.rd_baixo = New System.Windows.Forms.RadioButton()
        Me.rd_cima = New System.Windows.Forms.RadioButton()
        Me.txt_criador = New System.Windows.Forms.TextBox()
        Me.lbl_criador = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_resolvido = New System.Windows.Forms.Label()
        Me.cmb_nome = New System.Windows.Forms.ComboBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_id_membro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_descricao_pendencia = New System.Windows.Forms.TextBox()
        Me.btn_gravar_pendencia = New System.Windows.Forms.Button()
        Me.btn_editar_pendencia = New System.Windows.Forms.Button()
        Me.btn_excluir_pendencia = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(75, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Título"
        '
        'txt_titulo_pendencia
        '
        Me.txt_titulo_pendencia.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_titulo_pendencia.Location = New System.Drawing.Point(126, 90)
        Me.txt_titulo_pendencia.Name = "txt_titulo_pendencia"
        Me.txt_titulo_pendencia.Size = New System.Drawing.Size(365, 22)
        Me.txt_titulo_pendencia.TabIndex = 3
        '
        'cmb_urgencia
        '
        Me.cmb_urgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_urgencia.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_urgencia.FormattingEnabled = True
        Me.cmb_urgencia.ItemHeight = 13
        Me.cmb_urgencia.Location = New System.Drawing.Point(126, 130)
        Me.cmb_urgencia.Name = "cmb_urgencia"
        Me.cmb_urgencia.Size = New System.Drawing.Size(172, 21)
        Me.cmb_urgencia.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(3, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nível de Urgência"
        '
        'lbl_setor
        '
        Me.lbl_setor.AutoSize = True
        Me.lbl_setor.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_setor.Location = New System.Drawing.Point(232, 19)
        Me.lbl_setor.Name = "lbl_setor"
        Me.lbl_setor.Size = New System.Drawing.Size(92, 17)
        Me.lbl_setor.TabIndex = 13
        Me.lbl_setor.Text = "Setor Destino"
        '
        'rd_baixo
        '
        Me.rd_baixo.AutoSize = True
        Me.rd_baixo.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rd_baixo.Location = New System.Drawing.Point(295, 48)
        Me.rd_baixo.Name = "rd_baixo"
        Me.rd_baixo.Size = New System.Drawing.Size(87, 21)
        Me.rd_baixo.TabIndex = 2
        Me.rd_baixo.TabStop = True
        Me.rd_baixo.Text = "Secretário"
        Me.rd_baixo.UseVisualStyleBackColor = True
        '
        'rd_cima
        '
        Me.rd_cima.AutoSize = True
        Me.rd_cima.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rd_cima.Location = New System.Drawing.Point(186, 48)
        Me.rd_cima.Name = "rd_cima"
        Me.rd_cima.Size = New System.Drawing.Size(65, 21)
        Me.rd_cima.TabIndex = 1
        Me.rd_cima.TabStop = True
        Me.rd_cima.Text = "Pastor"
        Me.rd_cima.UseVisualStyleBackColor = True
        '
        'txt_criador
        '
        Me.txt_criador.Enabled = False
        Me.txt_criador.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_criador.Location = New System.Drawing.Point(383, 129)
        Me.txt_criador.Name = "txt_criador"
        Me.txt_criador.Size = New System.Drawing.Size(108, 22)
        Me.txt_criador.TabIndex = 10
        '
        'lbl_criador
        '
        Me.lbl_criador.AutoSize = True
        Me.lbl_criador.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_criador.Location = New System.Drawing.Point(304, 132)
        Me.lbl_criador.Name = "lbl_criador"
        Me.lbl_criador.Size = New System.Drawing.Size(77, 17)
        Me.lbl_criador.TabIndex = 9
        Me.lbl_criador.Text = "Criado por:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_resolvido)
        Me.GroupBox3.Controls.Add(Me.cmb_nome)
        Me.GroupBox3.Controls.Add(Me.txt_telefone)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_id_membro)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_email)
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(526, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(488, 213)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MEMBRO OFERTANTE/DIZIMISTA"
        '
        'lbl_resolvido
        '
        Me.lbl_resolvido.AutoSize = True
        Me.lbl_resolvido.Location = New System.Drawing.Point(325, 19)
        Me.lbl_resolvido.Name = "lbl_resolvido"
        Me.lbl_resolvido.Size = New System.Drawing.Size(0, 14)
        Me.lbl_resolvido.TabIndex = 24
        Me.lbl_resolvido.Visible = False
        '
        'cmb_nome
        '
        Me.cmb_nome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nome.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_nome.FormattingEnabled = True
        Me.cmb_nome.Location = New System.Drawing.Point(124, 73)
        Me.cmb_nome.Name = "cmb_nome"
        Me.cmb_nome.Size = New System.Drawing.Size(343, 21)
        Me.cmb_nome.TabIndex = 6
        '
        'txt_telefone
        '
        Me.txt_telefone.Enabled = False
        Me.txt_telefone.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_telefone.Location = New System.Drawing.Point(361, 117)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefone.Mask = "(99) 99999-9999"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(106, 22)
        Me.txt_telefone.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(8, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nome Completo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(307, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(19, 119)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ID do Membro"
        '
        'txt_id_membro
        '
        Me.txt_id_membro.Enabled = False
        Me.txt_id_membro.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_id_membro.Location = New System.Drawing.Point(124, 117)
        Me.txt_id_membro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id_membro.Name = "txt_id_membro"
        Me.txt_id_membro.Size = New System.Drawing.Size(131, 22)
        Me.txt_id_membro.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(74, 167)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_email.Location = New System.Drawing.Point(124, 162)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(343, 22)
        Me.txt_email.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_setor)
        Me.GroupBox1.Controls.Add(Me.txt_descricao_pendencia)
        Me.GroupBox1.Controls.Add(Me.rd_baixo)
        Me.GroupBox1.Controls.Add(Me.txt_criador)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_titulo_pendencia)
        Me.GroupBox1.Controls.Add(Me.lbl_criador)
        Me.GroupBox1.Controls.Add(Me.rd_cima)
        Me.GroupBox1.Controls.Add(Me.cmb_urgencia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(505, 314)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CADASTRAR ENTRADAS E SAÍDAS"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(44, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Descrição"
        '
        'txt_descricao_pendencia
        '
        Me.txt_descricao_pendencia.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_descricao_pendencia.Location = New System.Drawing.Point(126, 174)
        Me.txt_descricao_pendencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descricao_pendencia.Multiline = True
        Me.txt_descricao_pendencia.Name = "txt_descricao_pendencia"
        Me.txt_descricao_pendencia.Size = New System.Drawing.Size(365, 113)
        Me.txt_descricao_pendencia.TabIndex = 5
        '
        'btn_gravar_pendencia
        '
        Me.btn_gravar_pendencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_gravar_pendencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar_pendencia.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_pendencia.Location = New System.Drawing.Point(526, 244)
        Me.btn_gravar_pendencia.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar_pendencia.Name = "btn_gravar_pendencia"
        Me.btn_gravar_pendencia.Size = New System.Drawing.Size(116, 68)
        Me.btn_gravar_pendencia.TabIndex = 7
        Me.btn_gravar_pendencia.Text = "CADASTRAR PENDÊNCIA"
        Me.btn_gravar_pendencia.UseVisualStyleBackColor = False
        '
        'btn_editar_pendencia
        '
        Me.btn_editar_pendencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_editar_pendencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar_pendencia.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_pendencia.Location = New System.Drawing.Point(646, 244)
        Me.btn_editar_pendencia.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editar_pendencia.Name = "btn_editar_pendencia"
        Me.btn_editar_pendencia.Size = New System.Drawing.Size(119, 68)
        Me.btn_editar_pendencia.TabIndex = 8
        Me.btn_editar_pendencia.Text = "EDITAR PENDÊNCIA"
        Me.btn_editar_pendencia.UseVisualStyleBackColor = False
        '
        'btn_excluir_pendencia
        '
        Me.btn_excluir_pendencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_excluir_pendencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir_pendencia.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir_pendencia.Location = New System.Drawing.Point(769, 244)
        Me.btn_excluir_pendencia.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_excluir_pendencia.Name = "btn_excluir_pendencia"
        Me.btn_excluir_pendencia.Size = New System.Drawing.Size(122, 68)
        Me.btn_excluir_pendencia.TabIndex = 9
        Me.btn_excluir_pendencia.Text = "EXCLUIR PENDÊNCIA"
        Me.btn_excluir_pendencia.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(895, 244)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(119, 68)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frm_pendencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1022, 330)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_excluir_pendencia)
        Me.Controls.Add(Me.btn_editar_pendencia)
        Me.Controls.Add(Me.btn_gravar_pendencia)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frm_pendencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENDÊNCIAS"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_titulo_pendencia As TextBox
    Friend WithEvents cmb_urgencia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_criador As Label
    Friend WithEvents txt_criador As TextBox
    Friend WithEvents rd_baixo As RadioButton
    Friend WithEvents rd_cima As RadioButton
    Friend WithEvents lbl_setor As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmb_nome As ComboBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_id_membro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_descricao_pendencia As TextBox
    Friend WithEvents btn_gravar_pendencia As Button
    Friend WithEvents btn_editar_pendencia As Button
    Friend WithEvents btn_excluir_pendencia As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_resolvido As Label
End Class
