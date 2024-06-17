Imports Org.BouncyCastle.Crypto.Macs


Public Class frm_gerenciamento_usuarios

    Dim resposta As String

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        With dgv_usuarios
            If .CurrentRow.Cells(5).Selected Then

                txt_usuario.Text = .CurrentRow.Cells(1).Value
                cmb_setor.Text = .CurrentRow.Cells(2).Value
                cmb_status.Text = .CurrentRow.Cells(3).Value

                If setor_usuario = "PA" Then
                    btn_gravar.Enabled = False
                    cmb_setor.Enabled = False
                    cmb_status.Enabled = False

                Else
                    cmb_status.Enabled = True
                End If

            ElseIf .CurrentRow.Cells(6).Selected Then
                If setor_usuario <> "PA" Then
                    resposta = MsgBox("Deseja mesmo excluir este usuário?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")

                    If resposta = vbYes Then
                        sql = "DELETE FROM usuarios WHERE nome_usuario='" & .CurrentRow.Cells(1).Value & "'"
                        db.Execute(sql)
                        carregar_dgv_gerenciamento_usuario(nome_usuario)
                    End If
                Else
                    MsgBox("Você não tem permissão de excluir usuários", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PERMISSÃO NEGADA")
                End If
            End If
        End With
    End Sub

    Private Sub frm_gerenciamento_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_gerenciamento_usuario()
    End Sub


    Private Sub btn_limpar_Click(sender As Object, e As EventArgs)
        zerar_frm_gerenciamento_usuarios()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click

        Try
            Dim status_usuario_selecionado = get_id_geral(cmb_status.Text)
            Dim setor_usuario_selecionado = get_id_geral(cmb_setor.Text)
            sql = "UPDATE usuarios 
               SET id_setor='" & setor_usuario_selecionado & "',status_usuario='" & status_usuario_selecionado &
               "' WHERE nome_usuario='" & txt_usuario.Text & "'"

            db.Execute(sql)
            carregar_dgv_gerenciamento_usuario(nome_usuario)
            MsgBox("Usuário atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_limpar_Click_1(sender As Object, e As EventArgs) Handles btn_limpar.Click
        zerar_frm_gerenciamento_usuarios()
    End Sub
End Class