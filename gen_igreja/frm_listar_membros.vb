Imports Org.BouncyCastle.Ocsp

Public Class frm_listar_membros

    Dim resposta As String
    Private Sub frm_listar_membros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_listar_membros()

        cmb_filtro.Items.Clear()
        txt_pesquisa.Text = ""

        cmb_filtro.Items.Add("ID")
        cmb_filtro.Items.Add("Nome")
        If setor_usuario = "PA" Then
            btn_add_membro.Visible = False
            lbl_membro.Visible = False
        Else
            btn_add_membro.Visible = True
            lbl_membro.Visible = True
        End If
    End Sub

    Private Sub dgv_lista_membros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista_membros.CellContentClick
        Dim id_membro As String

        Try
            With dgv_lista_membros
                'Se eu clico com ele vazio dá pau
                If .CurrentRow.Cells(8).Selected Then
                    is_novo_membro = False
                    id_membro = .CurrentRow.Cells(1).Value
                    frm_gerenciamento_membros.Show()
                    preencher_frm_novo_membro(id_membro)

                ElseIf .CurrentRow.Cells(9).Selected Then
                    If setor_usuario <> "PA" Then
                        resposta = MsgBox("Deseja mesmo excluir este membro?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")

                        If resposta = vbYes Then

                            sql = "SELECT COALESCE(caminho_foto, '') FROM membros WHERE id_membro='" & .CurrentRow.Cells(1).Value & "'"
                            rs = db.Execute(UCase(sql))
                            'MsgBox()
                            caminho_foto_membro_destino = rs.Fields(0).Value

                            If caminho_foto_membro_destino <> ".\Icones\nova_foto.png" Then
                                My.Computer.FileSystem.DeleteFile(caminho_foto_membro_destino)
                            End If

                            sql = "DELETE FROM membros WHERE id_membro='" & .CurrentRow.Cells(1).Value & "'"
                            db.Execute(sql)

                            MsgBox("Membro excluído com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            carregar_dgv_lista_membros()
                        End If
                    Else
                        MsgBox("Você não pode excluir um membro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PERMISSÃO NEGADA")
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_novo_membro_Click(sender As Object, e As EventArgs)
        is_novo_membro = True
        frm_gerenciamento_membros.Show()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Dim cont
        Dim coluna As String
        If cmb_filtro.Text = "ID" Then
            coluna = "id_membro"
        Else
            coluna = cmb_filtro.Text
        End If


        sql = "SELECT m.id_membro,m.nome,m.idade,m.genero,m.email,m.fone,s.descricao As status_membro
               FROM membros m
               INNER JOIN status_membros s
               ON m.status_membro = s.id_status
               WHERE " & coluna & " LIKE '" & txt_pesquisa.Text & "%'"
        rs = db.Execute(sql)

        With dgv_lista_membros
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing, Nothing)
                cont += 1
                rs.MoveNext()
            Loop

        End With
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_add_membro.Click
        is_novo_membro = True
        frm_gerenciamento_membros.Show()
    End Sub

    Private Sub btn_redefinir_Click(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        carregar_dgv_lista_membros()
        cmb_filtro.Items.Clear()
        cmb_filtro.Items.Add("ID")
        cmb_filtro.Items.Add("Nome")
        txt_pesquisa.Text = ""
    End Sub

    Private Sub cmb_filtro_LostFocus(sender As Object, e As EventArgs) Handles cmb_filtro.LostFocus
        If cmb_filtro.Text <> "" Then
            txt_pesquisa.Enabled = True
        End If
    End Sub
End Class