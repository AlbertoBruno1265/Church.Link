Imports Org.BouncyCastle.Ocsp

Public Class frm_balanco_financeiro

    Private Sub frm_balanco_financeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_balanco()
    End Sub

    Private Sub btn_lancamento_Click(sender As Object, e As EventArgs) Handles btn_lancamento.Click
        is_visualizacao = False
        frm_financas.Show()
    End Sub


    Private Sub cmb_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtro.SelectedIndexChanged

        cmb_valor.Text = ""
        cmb_valor.Items.Clear()

        If cmb_filtro.SelectedIndex = 0 Then

            'lbl_valor.Visible = False
            'cmb_valor.Visible = False
            Try
                preencher_cmb_ano()
            Catch ex As System.Runtime.InteropServices.COMException
                cmb_filtro.Text = ""
                MsgBox("Nenhum dado financeiro cadastrado")

            End Try

        Else
            'lbl_valor.Visible = True
            'cmb_valor.Visible = True
            preencher_cmb_categoria()
        End If
    End Sub

    Private Sub cmb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs)
        carregar_dgv_balanco_financeiro()
    End Sub

    Private Sub dgv_balanco_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_balanco.CellContentClick
        Dim resposta As String
        With dgv_balanco
            If .CurrentRow.Cells(6).Selected Then
                is_visualizacao = True
                frm_financas.Show()
                preencher_frm_financas(.CurrentRow.Cells(0).Value)

            ElseIf .CurrentRow.Cells(7).Selected Then
                If setor_usuario <> "PA" Then
                    resposta = MsgBox("Deseja mesmo excluir este registro?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")

                    If resposta = vbYes Then
                        sql = "DELETE FROM financas WHERE id_financa='" & .CurrentRow.Cells(0).Value & "'"
                        MsgBox(sql)

                        db.Execute(sql)
                        MsgBox("Registro excluído!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_dgv_balanco_financeiro()
                    End If
                Else
                    MsgBox("Você não pode excluir um lançamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PERMISSÃO NEGADA")
                End If
            End If
        End With

    End Sub

    Private Sub cmb_valor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_valor.SelectedIndexChanged
        carregar_dgv_balanco_financeiro()

    End Sub

    Private Sub btn_redefinir_Click(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        cmb_filtro.Items.Clear()
        cmb_valor.Items.Clear()

        cmb_filtro.Items.Add("ANO")
        cmb_filtro.Items.Add("CATEGORIA")

        carregar_dgv_balanco_financeiro()
    End Sub

End Class