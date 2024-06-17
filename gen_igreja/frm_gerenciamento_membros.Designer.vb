<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciamento_membros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciamento_membros))
        Me.lbl_id_membro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_idade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_falecimento = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_status_membro = New System.Windows.Forms.ComboBox()
        Me.cmb_funcao = New System.Windows.Forms.ComboBox()
        Me.img_membro = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_data_nascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_id_membro = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_falecimento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_membramento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_batismo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_conversao = New System.Windows.Forms.MaskedTextBox()
        Me.btn_gravar_membro = New System.Windows.Forms.Button()
        Me.btn_editar_membro = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.PictureBox()
        CType(Me.img_membro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_id_membro
        '
        Me.lbl_id_membro.AutoSize = True
        Me.lbl_id_membro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_id_membro.Location = New System.Drawing.Point(69, 123)
        Me.lbl_id_membro.Name = "lbl_id_membro"
        Me.lbl_id_membro.Size = New System.Drawing.Size(105, 13)
        Me.lbl_id_membro.TabIndex = 1
        Me.lbl_id_membro.Text = "ID DO MEMBRO*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(116, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CPF*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOME COMPLETO*"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_nome.Location = New System.Drawing.Point(157, 25)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(362, 22)
        Me.txt_nome.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(5, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DATA DE NASCIMENTO*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(252, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "IDADE*"
        '
        'txt_idade
        '
        Me.txt_idade.BackColor = System.Drawing.SystemColors.Window
        Me.txt_idade.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_idade.Location = New System.Drawing.Point(308, 123)
        Me.txt_idade.Name = "txt_idade"
        Me.txt_idade.ReadOnly = True
        Me.txt_idade.Size = New System.Drawing.Size(41, 22)
        Me.txt_idade.TabIndex = 50
        Me.txt_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(103, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "E-MAIL"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_email.Location = New System.Drawing.Point(157, 89)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(362, 22)
        Me.txt_email.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(242, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CELULAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(407, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "GÊNERO*"
        '
        'lbl_cep
        '
        Me.lbl_cep.AutoSize = True
        Me.lbl_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_cep.Location = New System.Drawing.Point(115, 27)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(36, 13)
        Me.lbl_cep.TabIndex = 17
        Me.lbl_cep.Text = "CEP*"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_endereco.Location = New System.Drawing.Point(232, 27)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(80, 13)
        Me.lbl_endereco.TabIndex = 19
        Me.lbl_endereco.Text = "ENDEREÇO*"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_endereco.Location = New System.Drawing.Point(318, 24)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(366, 22)
        Me.txt_endereco.TabIndex = 8
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_cidade.Location = New System.Drawing.Point(98, 60)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(58, 13)
        Me.lbl_cidade.TabIndex = 21
        Me.lbl_cidade.Text = "CIDADE*"
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cidade.Location = New System.Drawing.Point(157, 54)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(231, 22)
        Me.txt_cidade.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(394, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "BAIRRO*"
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_bairro.Location = New System.Drawing.Point(459, 57)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(225, 22)
        Me.txt_bairro.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(90, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "NÚMERO"
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_numero.Location = New System.Drawing.Point(157, 88)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(62, 22)
        Me.txt_numero.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(232, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "COMPLEMENTO"
        '
        'txt_complemento
        '
        Me.txt_complemento.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_complemento.Location = New System.Drawing.Point(339, 88)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(128, 22)
        Me.txt_complemento.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(48, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "DATA DO BATISMO*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(33, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "DATA DA CONVERSÃO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(6, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "DATA DO MEMBRAMENTO*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(33, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "STATUS DO MEMBRO*"
        '
        'lbl_falecimento
        '
        Me.lbl_falecimento.AutoSize = True
        Me.lbl_falecimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_falecimento.Location = New System.Drawing.Point(21, 268)
        Me.lbl_falecimento.Name = "lbl_falecimento"
        Me.lbl_falecimento.Size = New System.Drawing.Size(151, 13)
        Me.lbl_falecimento.TabIndex = 37
        Me.lbl_falecimento.Text = "DATA DE FALECIMENTO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(110, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "FUNÇÃO*"
        '
        'cmb_status_membro
        '
        Me.cmb_status_membro.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cmb_status_membro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status_membro.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_status_membro.FormattingEnabled = True
        Me.cmb_status_membro.Location = New System.Drawing.Point(178, 83)
        Me.cmb_status_membro.Name = "cmb_status_membro"
        Me.cmb_status_membro.Size = New System.Drawing.Size(241, 21)
        Me.cmb_status_membro.TabIndex = 14
        Me.cmb_status_membro.UseWaitCursor = True
        '
        'cmb_funcao
        '
        Me.cmb_funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_funcao.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_funcao.FormattingEnabled = True
        Me.cmb_funcao.Location = New System.Drawing.Point(178, 27)
        Me.cmb_funcao.Name = "cmb_funcao"
        Me.cmb_funcao.Size = New System.Drawing.Size(241, 21)
        Me.cmb_funcao.TabIndex = 13
        '
        'img_membro
        '
        Me.img_membro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_membro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_membro.Image = CType(resources.GetObject("img_membro.Image"), System.Drawing.Image)
        Me.img_membro.Location = New System.Drawing.Point(538, 25)
        Me.img_membro.Name = "img_membro"
        Me.img_membro.Size = New System.Drawing.Size(117, 133)
        Me.img_membro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_membro.TabIndex = 43
        Me.img_membro.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cpf.Location = New System.Drawing.Point(157, 57)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(79, 22)
        Me.txt_cpf.TabIndex = 2
        '
        'cmb_genero
        '
        Me.cmb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_genero.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Location = New System.Drawing.Point(474, 58)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(45, 21)
        Me.cmb_genero.TabIndex = 4
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_telefone.Location = New System.Drawing.Point(311, 57)
        Me.txt_telefone.Mask = "(99) 99999-9999"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(89, 22)
        Me.txt_telefone.TabIndex = 3
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cep.Location = New System.Drawing.Point(157, 22)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(59, 22)
        Me.txt_cep.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_data_nascimento)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_idade)
        Me.GroupBox1.Controls.Add(Me.txt_telefone)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.img_membro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_genero)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 183)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS PESSOAIS"
        '
        'txt_data_nascimento
        '
        Me.txt_data_nascimento.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_data_nascimento.Location = New System.Drawing.Point(157, 123)
        Me.txt_data_nascimento.Mask = "00/00/0000"
        Me.txt_data_nascimento.Name = "txt_data_nascimento"
        Me.txt_data_nascimento.Size = New System.Drawing.Size(79, 22)
        Me.txt_data_nascimento.TabIndex = 6
        Me.txt_data_nascimento.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(535, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 14)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Foto 3x4"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_endereco)
        Me.GroupBox2.Controls.Add(Me.lbl_cep)
        Me.GroupBox2.Controls.Add(Me.txt_endereco)
        Me.GroupBox2.Controls.Add(Me.txt_cidade)
        Me.GroupBox2.Controls.Add(Me.lbl_cidade)
        Me.GroupBox2.Controls.Add(Me.txt_bairro)
        Me.GroupBox2.Controls.Add(Me.txt_cep)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_numero)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_complemento)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 140)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DADOS DE ENDEREÇO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_id_membro)
        Me.GroupBox3.Controls.Add(Me.txt_data_falecimento)
        Me.GroupBox3.Controls.Add(Me.lbl_id_membro)
        Me.GroupBox3.Controls.Add(Me.cmb_funcao)
        Me.GroupBox3.Controls.Add(Me.txt_data_membramento)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_data_batismo)
        Me.GroupBox3.Controls.Add(Me.cmb_status_membro)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_data_conversao)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lbl_falecimento)
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(718, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(431, 329)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DADOS DE MEMBRESIA"
        '
        'txt_id_membro
        '
        Me.txt_id_membro.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_id_membro.Location = New System.Drawing.Point(178, 116)
        Me.txt_id_membro.Mask = "999999999999999"
        Me.txt_id_membro.Name = "txt_id_membro"
        Me.txt_id_membro.Size = New System.Drawing.Size(103, 22)
        Me.txt_id_membro.TabIndex = 15
        '
        'txt_data_falecimento
        '
        Me.txt_data_falecimento.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_data_falecimento.Location = New System.Drawing.Point(178, 265)
        Me.txt_data_falecimento.Mask = "00/00/0000"
        Me.txt_data_falecimento.Name = "txt_data_falecimento"
        Me.txt_data_falecimento.Size = New System.Drawing.Size(72, 22)
        Me.txt_data_falecimento.TabIndex = 19
        Me.txt_data_falecimento.ValidatingType = GetType(Date)
        '
        'txt_data_membramento
        '
        Me.txt_data_membramento.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_data_membramento.Location = New System.Drawing.Point(178, 230)
        Me.txt_data_membramento.Mask = "00/00/0000"
        Me.txt_data_membramento.Name = "txt_data_membramento"
        Me.txt_data_membramento.Size = New System.Drawing.Size(72, 22)
        Me.txt_data_membramento.TabIndex = 18
        Me.txt_data_membramento.ValidatingType = GetType(Date)
        '
        'txt_data_batismo
        '
        Me.txt_data_batismo.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_data_batismo.Location = New System.Drawing.Point(178, 192)
        Me.txt_data_batismo.Mask = "00/00/0000"
        Me.txt_data_batismo.Name = "txt_data_batismo"
        Me.txt_data_batismo.Size = New System.Drawing.Size(72, 22)
        Me.txt_data_batismo.TabIndex = 17
        Me.txt_data_batismo.ValidatingType = GetType(Date)
        '
        'txt_data_conversao
        '
        Me.txt_data_conversao.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_data_conversao.Location = New System.Drawing.Point(178, 151)
        Me.txt_data_conversao.Mask = "00/00/0000"
        Me.txt_data_conversao.Name = "txt_data_conversao"
        Me.txt_data_conversao.Size = New System.Drawing.Size(72, 22)
        Me.txt_data_conversao.TabIndex = 16
        Me.txt_data_conversao.ValidatingType = GetType(Date)
        '
        'btn_gravar_membro
        '
        Me.btn_gravar_membro.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_gravar_membro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar_membro.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_membro.Location = New System.Drawing.Point(389, 389)
        Me.btn_gravar_membro.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar_membro.Name = "btn_gravar_membro"
        Me.btn_gravar_membro.Size = New System.Drawing.Size(128, 51)
        Me.btn_gravar_membro.TabIndex = 20
        Me.btn_gravar_membro.Text = "CADASTRAR MEMBRO"
        Me.btn_gravar_membro.UseVisualStyleBackColor = False
        '
        'btn_editar_membro
        '
        Me.btn_editar_membro.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_editar_membro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar_membro.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_membro.Location = New System.Drawing.Point(539, 389)
        Me.btn_editar_membro.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editar_membro.Name = "btn_editar_membro"
        Me.btn_editar_membro.Size = New System.Drawing.Size(128, 51)
        Me.btn_editar_membro.TabIndex = 21
        Me.btn_editar_membro.Text = "EDITAR MEMBRO"
        Me.btn_editar_membro.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(689, 389)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(128, 51)
        Me.btn_cancelar.TabIndex = 22
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(18, -1)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(34, 34)
        Me.btn_limpar.TabIndex = 62
        Me.btn_limpar.TabStop = False
        '
        'frm_gerenciamento_membros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 460)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_editar_membro)
        Me.Controls.Add(Me.btn_gravar_membro)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerenciamento_membros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENCIAMENTO DE MEMBROS"
        CType(Me.img_membro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_id_membro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_idade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_cep As Label
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents lbl_cidade As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_falecimento As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmb_status_membro As ComboBox
    Friend WithEvents cmb_funcao As ComboBox
    Friend WithEvents img_membro As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_genero As ComboBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_data_nascimento As MaskedTextBox
    Friend WithEvents txt_data_conversao As MaskedTextBox
    Friend WithEvents txt_data_batismo As MaskedTextBox
    Friend WithEvents txt_data_membramento As MaskedTextBox
    Friend WithEvents txt_data_falecimento As MaskedTextBox
    Friend WithEvents txt_id_membro As MaskedTextBox
    Friend WithEvents btn_gravar_membro As Button
    Friend WithEvents btn_editar_membro As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_limpar As PictureBox
End Class
