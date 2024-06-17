<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_financas
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_nome = New System.Windows.Forms.ComboBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_id_membro = New System.Windows.Forms.Label()
        Me.txt_id_membro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_gravar_oferta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_data = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.op_entrada = New System.Windows.Forms.RadioButton()
        Me.op_saida = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_nome)
        Me.GroupBox2.Controls.Add(Me.txt_telefone)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_id_membro)
        Me.GroupBox2.Controls.Add(Me.txt_id_membro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(491, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(474, 213)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MEMBRO OFERTANTE/DIZIMISTA"
        '
        'cmb_nome
        '
        Me.cmb_nome.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_nome.FormattingEnabled = True
        Me.cmb_nome.Location = New System.Drawing.Point(124, 73)
        Me.cmb_nome.Name = "cmb_nome"
        Me.cmb_nome.Size = New System.Drawing.Size(319, 21)
        Me.cmb_nome.TabIndex = 6
        '
        'txt_telefone
        '
        Me.txt_telefone.Enabled = False
        Me.txt_telefone.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_telefone.Location = New System.Drawing.Point(337, 117)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefone.Mask = "(99) 99999-9999"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(106, 22)
        Me.txt_telefone.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(8, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nome Completo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(283, 119)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Celular"
        '
        'lbl_id_membro
        '
        Me.lbl_id_membro.AutoSize = True
        Me.lbl_id_membro.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_id_membro.Location = New System.Drawing.Point(19, 119)
        Me.lbl_id_membro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_membro.Name = "lbl_id_membro"
        Me.lbl_id_membro.Size = New System.Drawing.Size(98, 17)
        Me.lbl_id_membro.TabIndex = 15
        Me.lbl_id_membro.Text = "ID do Membro"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(74, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_email.Location = New System.Drawing.Point(124, 162)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(319, 22)
        Me.txt_email.TabIndex = 17
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(742, 250)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(128, 51)
        Me.btn_cancelar.TabIndex = 24
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_gravar_oferta
        '
        Me.btn_gravar_oferta.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_gravar_oferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar_oferta.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_oferta.Location = New System.Drawing.Point(583, 250)
        Me.btn_gravar_oferta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar_oferta.Name = "btn_gravar_oferta"
        Me.btn_gravar_oferta.Size = New System.Drawing.Size(128, 51)
        Me.btn_gravar_oferta.TabIndex = 13
        Me.btn_gravar_oferta.Text = "REALIZAR LANÇAMENTO"
        Me.btn_gravar_oferta.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_descricao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_data)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_categoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.op_entrada)
        Me.GroupBox1.Controls.Add(Me.op_saida)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(469, 297)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CADASTRAR ENTRADAS E SAÍDAS"
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_valor.Location = New System.Drawing.Point(127, 171)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_valor.Size = New System.Drawing.Size(88, 22)
        Me.txt_valor.TabIndex = 4
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(36, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Descrição"
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_descricao.Location = New System.Drawing.Point(115, 210)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(313, 74)
        Me.txt_descricao.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(71, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Data"
        '
        'cmb_data
        '
        Me.cmb_data.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_data.Location = New System.Drawing.Point(115, 131)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(313, 22)
        Me.cmb_data.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(45, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Categoria"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(115, 77)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(313, 21)
        Me.cmb_categoria.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(71, 171)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Valor R$"
        '
        'op_entrada
        '
        Me.op_entrada.AutoSize = True
        Me.op_entrada.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.op_entrada.Location = New System.Drawing.Point(158, 36)
        Me.op_entrada.Margin = New System.Windows.Forms.Padding(4)
        Me.op_entrada.Name = "op_entrada"
        Me.op_entrada.Size = New System.Drawing.Size(73, 21)
        Me.op_entrada.TabIndex = 0
        Me.op_entrada.TabStop = True
        Me.op_entrada.Text = "Entrada"
        Me.op_entrada.UseVisualStyleBackColor = True
        '
        'op_saida
        '
        Me.op_saida.AutoSize = True
        Me.op_saida.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold)
        Me.op_saida.Location = New System.Drawing.Point(247, 36)
        Me.op_saida.Margin = New System.Windows.Forms.Padding(4)
        Me.op_saida.Name = "op_saida"
        Me.op_saida.Size = New System.Drawing.Size(59, 21)
        Me.op_saida.TabIndex = 1
        Me.op_saida.TabStop = True
        Me.op_saida.Text = "Saída"
        Me.op_saida.UseVisualStyleBackColor = True
        '
        'frm_financas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 319)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_gravar_oferta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_financas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO FINANCEIRO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_id_membro As Label
    Friend WithEvents txt_id_membro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents op_saida As RadioButton
    Friend WithEvents op_entrada As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_data As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents cmb_nome As ComboBox
    Friend WithEvents btn_gravar_oferta As Button
    Friend WithEvents btn_cancelar As Button
End Class
