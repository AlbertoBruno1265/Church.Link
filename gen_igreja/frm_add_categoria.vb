Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_add_categoria
    Dim tabela
    Private Sub frm_add_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

        'sql = "SELECT descricao from '" & categoria & "'"
        'rs = db.Execute(sql)

        'MsgBox(categoria)

        If categoria = "financas" Then
            sql = "SELECT descricao FROM categorias_financas WHERE id_tipo = 'SA'"
            rs = db.Execute(UCase(sql))
            Do While Not rs.EOF
                cmb_categoria.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            Loop
        ElseIf categoria = "funcoes" Then
            sql = "SELECT descricao FROM funcoes"
            rs = db.Execute(UCase(sql))
            Do While Not rs.EOF
                cmb_categoria.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            Loop
        End If


    End Sub

    Private Sub btn_add_categoria_Click(sender As Object, e As EventArgs) Handles btn_add_categoria.Click

        If categoria = "financas" Then
            sql = "INSERT INTO categorias_financas VALUES ('" & get_id_geral(txt_nova_categoria.Text) & "', 'SA', '" & txt_nova_categoria.Text & "')"
            'MsgBox(sql)
            rs = db.Execute(UCase(sql))
        ElseIf categoria = "funcoes" Then
            sql = "INSERT into funcoes (descricao) VALUES " & txt_nova_categoria.Text & ""
            'MsgBox(sql)
            rs = db.Execute(UCase(sql))
        End If
    End Sub
End Class