Public Class frm_financas

    Private Sub frm_ofertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_financas()
    End Sub


    Private Sub op_entrada_CheckedChanged(sender As Object, e As EventArgs) Handles op_entrada.CheckedChanged
        If Not is_visualizacao Then
            preencher_cmb_financas("descricao", "categorias_financas", "EN", cmb_categoria)
            tipo_financa = "EN"
            cmb_categoria.Enabled = True
            'btn_add_categoria.Visible = False
            'lbl_add_categoria.Visible = False
        End If
    End Sub

    Private Sub op_saida_CheckedChanged(sender As Object, e As EventArgs) Handles op_saida.CheckedChanged
        If Not is_visualizacao Then
            preencher_cmb_financas("descricao", "categorias_financas", "SA", cmb_categoria)
            tipo_financa = "SA"
            cmb_categoria.Enabled = True
            'btn_add_categoria.Visible = True
            'lbl_add_categoria.Visible = True
            zerar_dados_membro(cmb_nome, txt_id_membro, txt_email, txt_telefone)
        End If
    End Sub

    Private Sub cmb_nome_TextChanged(sender As Object, e As EventArgs) Handles cmb_nome.TextChanged
        If Not is_visualizacao Then
            'buscar_cmb_membro(cmb_nome, txt_email, txt_telefone, txt_id_membro)
        End If
    End Sub

    Private Sub cmb_nome_LostFocus(sender As Object, e As EventArgs) Handles cmb_nome.LostFocus
        If Not is_visualizacao Then
            preencher_cmb_dados_membro(cmb_nome, txt_email, txt_telefone, txt_id_membro)
        End If
        If cmb_nome.Text = "" Then
            zerar_dados_membro(cmb_nome, txt_id_membro, txt_email, txt_telefone)
        End If
    End Sub

    Private Sub btn_gravar_oferta_Click(sender As Object, e As EventArgs) Handles btn_gravar_oferta.Click
        verificar_campos_financas()
        zerar_frm_financas()
        carregar_dgv_balanco_financeiro()

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub btn_add_categoria_Click(sender As Object, e As EventArgs)
        categoria = "financas"
        frm_add_categoria.ShowDialog()
    End Sub

    Private Sub lbl_add_categoria_Click(sender As Object, e As EventArgs)

    End Sub
End Class