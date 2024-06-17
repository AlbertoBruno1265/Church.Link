Public Class frm_novo_usuario
    Private Sub frm_novo_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_novo_usuario()
    End Sub

    Private Sub chk_mostrar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar_senha.CheckedChanged
        alterar_view_senha_criacao(chk_mostrar_senha, txt_senha, txt_confirmar_senha)
    End Sub



    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        zerar_frm_novo_usuario()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        verificar_dados_usuario(txt_usuario, txt_senha, txt_confirmar_senha, cmb_funcao)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub
End Class