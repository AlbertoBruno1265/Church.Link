<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_novo_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_novo_usuario))
        Me.cmb_funcao = New System.Windows.Forms.ComboBox()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_mostrar_senha = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.PictureBox()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_funcao
        '
        Me.cmb_funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_funcao.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_funcao.FormattingEnabled = True
        Me.cmb_funcao.Location = New System.Drawing.Point(192, 228)
        Me.cmb_funcao.Name = "cmb_funcao"
        Me.cmb_funcao.Size = New System.Drawing.Size(237, 21)
        Me.cmb_funcao.TabIndex = 4
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(192, 169)
        Me.txt_confirmar_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(237, 22)
        Me.txt_confirmar_senha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CONFIRMAR SENHA"
        '
        'chk_mostrar_senha
        '
        Me.chk_mostrar_senha.AutoSize = True
        Me.chk_mostrar_senha.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_mostrar_senha.Location = New System.Drawing.Point(239, 198)
        Me.chk_mostrar_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_mostrar_senha.Name = "chk_mostrar_senha"
        Me.chk_mostrar_senha.Size = New System.Drawing.Size(116, 21)
        Me.chk_mostrar_senha.TabIndex = 9
        Me.chk_mostrar_senha.Text = "Mostrar Senha"
        Me.chk_mostrar_senha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 228)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FUNÇÃO"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(192, 128)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(237, 22)
        Me.txt_senha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SENHA"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(192, 91)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(237, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DE LOGIN"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.Location = New System.Drawing.Point(276, 294)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(128, 51)
        Me.btn_gravar.TabIndex = 13
        Me.btn_gravar.Text = "CRIAR USUÁRIO"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(133, 294)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(128, 51)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(192, 52)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(34, 34)
        Me.btn_limpar.TabIndex = 15
        Me.btn_limpar.TabStop = False
        '
        'frm_novo_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 387)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.cmb_funcao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_mostrar_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_novo_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE USUÁRIO"
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_mostrar_senha As CheckBox
    Friend WithEvents cmb_funcao As ComboBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_limpar As PictureBox
End Class
