<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_nova_conta = New System.Windows.Forms.Label()
        Me.chk_mostrar_senha = New System.Windows.Forms.CheckBox()
        Me.btn_logar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nova_conta
        '
        Me.lbl_nova_conta.AutoSize = True
        Me.lbl_nova_conta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_nova_conta.Font = New System.Drawing.Font("Lucida Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nova_conta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_nova_conta.Location = New System.Drawing.Point(252, 435)
        Me.lbl_nova_conta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nova_conta.Name = "lbl_nova_conta"
        Me.lbl_nova_conta.Size = New System.Drawing.Size(98, 12)
        Me.lbl_nova_conta.TabIndex = 5
        Me.lbl_nova_conta.Text = "Criar nova conta"
        '
        'chk_mostrar_senha
        '
        Me.chk_mostrar_senha.AutoSize = True
        Me.chk_mostrar_senha.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_mostrar_senha.Location = New System.Drawing.Point(252, 345)
        Me.chk_mostrar_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_mostrar_senha.Name = "chk_mostrar_senha"
        Me.chk_mostrar_senha.Size = New System.Drawing.Size(116, 21)
        Me.chk_mostrar_senha.TabIndex = 4
        Me.chk_mostrar_senha.Text = "Mostrar Senha"
        Me.chk_mostrar_senha.UseVisualStyleBackColor = True
        '
        'btn_logar
        '
        Me.btn_logar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logar.Location = New System.Drawing.Point(239, 374)
        Me.btn_logar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.Size = New System.Drawing.Size(128, 51)
        Me.btn_logar.TabIndex = 3
        Me.btn_logar.Text = "ENTRAR"
        Me.btn_logar.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(213, 320)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(241, 22)
        Me.txt_senha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 320)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SENHA"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(213, 284)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(241, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DE USUÁRIO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(141, -26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 289)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 458)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_nova_conta)
        Me.Controls.Add(Me.chk_mostrar_senha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_logar)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_logar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nova_conta As Label
    Friend WithEvents chk_mostrar_senha As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
