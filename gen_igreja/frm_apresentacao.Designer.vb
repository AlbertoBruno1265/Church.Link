<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apresentacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_apresentacao))
        Me.img_apresentacao = New System.Windows.Forms.PictureBox()
        Me.btn_proximo = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        CType(Me.img_apresentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_apresentacao
        '
        Me.img_apresentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_apresentacao.Location = New System.Drawing.Point(13, 13)
        Me.img_apresentacao.Name = "img_apresentacao"
        Me.img_apresentacao.Size = New System.Drawing.Size(815, 492)
        Me.img_apresentacao.TabIndex = 0
        Me.img_apresentacao.TabStop = False
        '
        'btn_proximo
        '
        Me.btn_proximo.Image = CType(resources.GetObject("btn_proximo.Image"), System.Drawing.Image)
        Me.btn_proximo.Location = New System.Drawing.Point(789, 510)
        Me.btn_proximo.Name = "btn_proximo"
        Me.btn_proximo.Size = New System.Drawing.Size(42, 38)
        Me.btn_proximo.TabIndex = 1
        Me.btn_proximo.UseVisualStyleBackColor = True
        '
        'btn_anterior
        '
        Me.btn_anterior.Image = CType(resources.GetObject("btn_anterior.Image"), System.Drawing.Image)
        Me.btn_anterior.Location = New System.Drawing.Point(741, 510)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(42, 38)
        Me.btn_anterior.TabIndex = 2
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'frm_apresentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(845, 556)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.btn_proximo)
        Me.Controls.Add(Me.img_apresentacao)
        Me.Name = "frm_apresentacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOAS-VINDAS"
        CType(Me.img_apresentacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents img_apresentacao As PictureBox
    Friend WithEvents btn_proximo As Button
    Friend WithEvents btn_anterior As Button
End Class
