<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_balanco_financeiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_balanco_financeiro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_redefinir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.lbl_valor = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_valor = New System.Windows.Forms.ToolStripComboBox()
        Me.lbl_lancamento = New System.Windows.Forms.ToolStripLabel()
        Me.btn_lancamento = New System.Windows.Forms.ToolStripButton()
        Me.dgv_balanco = New System.Windows.Forms.DataGridView()
        Me.id_financa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_funanca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria_financa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_financa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_financa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_financa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expandir_financa = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir_financa = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_total_saidas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total_entradas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_balanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgv_balanco)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(736, 524)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BALANÇO FINANCEIRO"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_redefinir, Me.ToolStripLabel2, Me.cmb_filtro, Me.lbl_valor, Me.cmb_valor, Me.lbl_lancamento, Me.btn_lancamento})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 20)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(728, 25)
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
        'lbl_valor
        '
        Me.lbl_valor.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(62, 22)
        Me.lbl_valor.Text = "Pesquisar:"
        '
        'cmb_valor
        '
        Me.cmb_valor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_valor.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_valor.Name = "cmb_valor"
        Me.cmb_valor.Size = New System.Drawing.Size(121, 25)
        '
        'lbl_lancamento
        '
        Me.lbl_lancamento.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lancamento.Name = "lbl_lancamento"
        Me.lbl_lancamento.Size = New System.Drawing.Size(127, 22)
        Me.lbl_lancamento.Text = "Adcionar Lançamento"
        '
        'btn_lancamento
        '
        Me.btn_lancamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_lancamento.Image = CType(resources.GetObject("btn_lancamento.Image"), System.Drawing.Image)
        Me.btn_lancamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_lancamento.Name = "btn_lancamento"
        Me.btn_lancamento.Size = New System.Drawing.Size(23, 22)
        '
        'dgv_balanco
        '
        Me.dgv_balanco.AllowUserToAddRows = False
        Me.dgv_balanco.AllowUserToDeleteRows = False
        Me.dgv_balanco.AllowUserToResizeColumns = False
        Me.dgv_balanco.AllowUserToResizeRows = False
        Me.dgv_balanco.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dgv_balanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_balanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_financa, Me.num_funanca, Me.categoria_financa, Me.tipo_financa, Me.valor_financa, Me.data_financa, Me.expandir_financa, Me.excluir_financa})
        Me.dgv_balanco.Location = New System.Drawing.Point(7, 54)
        Me.dgv_balanco.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_balanco.Name = "dgv_balanco"
        Me.dgv_balanco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_balanco.Size = New System.Drawing.Size(723, 463)
        Me.dgv_balanco.TabIndex = 0
        '
        'id_financa
        '
        Me.id_financa.HeaderText = "ID"
        Me.id_financa.Name = "id_financa"
        Me.id_financa.Visible = False
        Me.id_financa.Width = 35
        '
        'num_funanca
        '
        Me.num_funanca.HeaderText = "N°"
        Me.num_funanca.Name = "num_funanca"
        Me.num_funanca.Width = 40
        '
        'categoria_financa
        '
        Me.categoria_financa.HeaderText = "Categoria"
        Me.categoria_financa.Name = "categoria_financa"
        Me.categoria_financa.Width = 150
        '
        'tipo_financa
        '
        Me.tipo_financa.HeaderText = "Tipo"
        Me.tipo_financa.Name = "tipo_financa"
        Me.tipo_financa.Width = 150
        '
        'valor_financa
        '
        Me.valor_financa.HeaderText = "Valor"
        Me.valor_financa.Name = "valor_financa"
        Me.valor_financa.Width = 80
        '
        'data_financa
        '
        Me.data_financa.HeaderText = "Data"
        Me.data_financa.Name = "data_financa"
        '
        'expandir_financa
        '
        Me.expandir_financa.HeaderText = "Expandir"
        Me.expandir_financa.Image = CType(resources.GetObject("expandir_financa.Image"), System.Drawing.Image)
        Me.expandir_financa.Name = "expandir_financa"
        Me.expandir_financa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.expandir_financa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.expandir_financa.Width = 80
        '
        'excluir_financa
        '
        Me.excluir_financa.HeaderText = "Excluir"
        Me.excluir_financa.Image = CType(resources.GetObject("excluir_financa.Image"), System.Drawing.Image)
        Me.excluir_financa.Name = "excluir_financa"
        Me.excluir_financa.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_subtotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_total_saidas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_total_entradas)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 547)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(736, 73)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.Color.White
        Me.txt_subtotal.Location = New System.Drawing.Point(609, 32)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(116, 23)
        Me.txt_subtotal.TabIndex = 5
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SUBTOTAL:"
        '
        'txt_total_saidas
        '
        Me.txt_total_saidas.BackColor = System.Drawing.Color.White
        Me.txt_total_saidas.Location = New System.Drawing.Point(375, 32)
        Me.txt_total_saidas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_saidas.Name = "txt_total_saidas"
        Me.txt_total_saidas.ReadOnly = True
        Me.txt_total_saidas.Size = New System.Drawing.Size(116, 23)
        Me.txt_total_saidas.TabIndex = 3
        Me.txt_total_saidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TOTAL SAÍDAS:"
        '
        'txt_total_entradas
        '
        Me.txt_total_entradas.BackColor = System.Drawing.Color.White
        Me.txt_total_entradas.Location = New System.Drawing.Point(128, 32)
        Me.txt_total_entradas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_entradas.Name = "txt_total_entradas"
        Me.txt_total_entradas.ReadOnly = True
        Me.txt_total_entradas.Size = New System.Drawing.Size(116, 23)
        Me.txt_total_entradas.TabIndex = 1
        Me.txt_total_entradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL ENTRADAS:"
        '
        'frm_balanco_financeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 628)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_balanco_financeiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BALANÇO FINANCEIRO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_balanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_balanco As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_total_entradas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total_saidas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_lancamento As ToolStripButton
    Friend WithEvents lbl_valor As ToolStripLabel
    Friend WithEvents cmb_valor As ToolStripComboBox
    Friend WithEvents lbl_lancamento As ToolStripLabel
    Friend WithEvents id_financa As DataGridViewTextBoxColumn
    Friend WithEvents num_funanca As DataGridViewTextBoxColumn
    Friend WithEvents categoria_financa As DataGridViewTextBoxColumn
    Friend WithEvents tipo_financa As DataGridViewTextBoxColumn
    Friend WithEvents valor_financa As DataGridViewTextBoxColumn
    Friend WithEvents data_financa As DataGridViewTextBoxColumn
    Friend WithEvents expandir_financa As DataGridViewImageColumn
    Friend WithEvents excluir_financa As DataGridViewImageColumn
    Friend WithEvents btn_redefinir As ToolStripButton
End Class
