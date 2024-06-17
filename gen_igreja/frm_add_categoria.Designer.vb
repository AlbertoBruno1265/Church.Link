<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_categoria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add_categoria = New System.Windows.Forms.Button()
        Me.txt_nova_categoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CATEGORIAS EXISTENTES"
        '
        'btn_add_categoria
        '
        Me.btn_add_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_add_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_categoria.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_categoria.Location = New System.Drawing.Point(176, 163)
        Me.btn_add_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add_categoria.Name = "btn_add_categoria"
        Me.btn_add_categoria.Size = New System.Drawing.Size(128, 51)
        Me.btn_add_categoria.TabIndex = 7
        Me.btn_add_categoria.Text = "ADICIONAR CATEGORIA"
        Me.btn_add_categoria.UseVisualStyleBackColor = False
        '
        'txt_nova_categoria
        '
        Me.txt_nova_categoria.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nova_categoria.Location = New System.Drawing.Point(196, 99)
        Me.txt_nova_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nova_categoria.Name = "txt_nova_categoria"
        Me.txt_nova_categoria.Size = New System.Drawing.Size(241, 22)
        Me.txt_nova_categoria.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOVA CATEGORIA"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(196, 61)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(241, 21)
        Me.cmb_categoria.TabIndex = 8
        '
        'frm_add_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 235)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add_categoria)
        Me.Controls.Add(Me.txt_nova_categoria)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_add_categoria"
        Me.Text = "ADICIONAR CATEGORIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add_categoria As Button
    Friend WithEvents txt_nova_categoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_categoria As ComboBox
End Class
