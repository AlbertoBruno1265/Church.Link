Public Class frm_pendencias
    Private Sub frm_pendencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_pendencias()

    End Sub


    Private Sub cmb_nome_LostFocus(sender As Object, e As EventArgs)
        preencher_cmb_dados_membro(cmb_nome, txt_email, txt_telefone, txt_id_membro)
        If cmb_nome.Text = "" Then
            zerar_dados_membro(cmb_nome, txt_id_membro, txt_email, txt_telefone)
        End If
    End Sub


    Private Sub btn_excluir_pendencia_Click(sender As Object, e As EventArgs) Handles btn_excluir_pendencia.Click
        excluir_pendencia()
        Close()
    End Sub

    Private Sub btn_editar_pendencia_Click(sender As Object, e As EventArgs) Handles btn_editar_pendencia.Click
        editar_pendencia()
    End Sub

    Private Sub btn_gravar_pendencia_Click(sender As Object, e As EventArgs) Handles btn_gravar_pendencia.Click
        If btn_gravar_pendencia.Text = "CADASTRAR PENDÊNCIA" Then
            If verificar_campos_pendencias() = False Then
                MsgBox("Por favor, preencher todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")

            Else
                cadastrar_pendencia()
                zerar_frm_pendencias()

            End If

        Else
            resolver_pendencia()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub cmb_nome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nome.SelectedIndexChanged

    End Sub

    Private Sub cmb_nome_TextChanged(sender As Object, e As EventArgs) Handles cmb_nome.TextChanged
        If Not is_visualizacao Then
            preencher_cmb_dados_membro(cmb_nome, txt_email, txt_telefone, txt_id_membro)
        End If
        If cmb_nome.Text = "" Then
            zerar_dados_membro(cmb_nome, txt_id_membro, txt_email, txt_telefone)
        End If
    End Sub
End Class