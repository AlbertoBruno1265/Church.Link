Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_login()
    End Sub

    Private Sub lbl_nova_conta_Click(sender As Object, e As EventArgs) Handles lbl_nova_conta.Click
        frm_novo_usuario.ShowDialog()
    End Sub

    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        realizar_login(txt_usuario, txt_senha)
    End Sub

    Private Sub chk_mostrar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar_senha.CheckedChanged
        alterar_view_senha_login(chk_mostrar_senha, txt_senha)
    End Sub

End Class