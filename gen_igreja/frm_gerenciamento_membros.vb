Public Class frm_gerenciamento_membros
    Private Sub frm_novo_membro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_novo_membro()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles img_membro.Click
        carregar_foto()
    End Sub
    Private Sub cmb_status_membro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_status_membro.SelectedIndexChanged

        If cmb_status_membro.SelectedIndex = 2 Then
            lbl_falecimento.Enabled = True
            txt_data_falecimento.Enabled = True
        Else
            lbl_falecimento.Enabled = False
            txt_data_falecimento.Enabled = False
            txt_data_falecimento.Text = ""
        End If
    End Sub
    Private Sub txt_data_nascimento_LostFocus(sender As Object, e As EventArgs) Handles txt_data_nascimento.LostFocus
        gerar_idade()
    End Sub


    Private Sub btn_gravar_membro_Click(sender As Object, e As EventArgs) Handles btn_gravar_membro.Click
        If verificar_campos_membro() = False Then
            MsgBox("Por favor, preencher todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        Else
            sec_criar_membro()
            carregar_dgv_lista_membros()
            'zerar_frm_novo_membro()
        End If
    End Sub

    Private Sub btn_editar_membro_Click(sender As Object, e As EventArgs) Handles btn_editar_membro.Click
        If verificar_campos_membro() = False Then
            MsgBox("Por favor, preencher todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        Else
            editar_membro()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        zerar_frm_novo_membro()
    End Sub

    Private Sub btn_add_categoria_Click(sender As Object, e As EventArgs)
        categoria = "funcoes"
        frm_add_categoria.ShowDialog()
    End Sub
End Class