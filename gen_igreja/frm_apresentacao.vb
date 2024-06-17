Public Class frm_apresentacao
    Dim cont As Integer
    Private Sub frm_apresentacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cont = 1
        btn_anterior.Enabled = False
        Dim caminho_foto = ".\Apresentacao\Foto1.PNG"

        img_apresentacao.Load(caminho_foto)
    End Sub

    Private Sub btn_proximo_Click(sender As Object, e As EventArgs) Handles btn_proximo.Click
        cont += 1

        If cont = 2 Then
            btn_anterior.Enabled = True
        End If

        If cont = 4 Then
            frm_menu.Show()
            Close()
            Exit Sub
        End If

        Dim nome_arquivo = "Foto" + CStr(cont) + ".PNG"
        Dim caminho_foto = ".\Apresentacao\" & nome_arquivo

        img_apresentacao.Load(caminho_foto)
    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        cont -= 1

        If cont = 1 Then
            btn_anterior.Enabled = False
        End If
        'MsgBox(cont)
        'If cont = 1 Then
        '    btn_anterior.Enabled = False
        '    Exit Sub
        'End If

        'If cont < 2 Then
        '    btn_proximo.Enabled = True
        '    btn_anterior.Enabled = True
        '    'cont -= 1
        'ElseIf cont = 2 Then
        '    'cont -= 1
        '    btn_anterior.Enabled = True
        'End If



        Dim nome_arquivo = "Foto" + CStr(cont) + ".PNG"
        Dim caminho_foto = ".\Apresentacao\" & nome_arquivo

        img_apresentacao.Load(caminho_foto)
    End Sub
End Class