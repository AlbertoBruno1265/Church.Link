Imports System.ComponentModel

Public Class frm_menu


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendencias.CellContentClick


        With dgv_pendencias
            If .CurrentRow.Cells(4).Selected Then

                nova_pendencia = False

                ' LÓGICA ATUAL
                If nome_usuario = .CurrentRow.Cells(7).Value Then
                    is_criador = True
                Else
                    is_criador = False
                End If

                frm_pendencias.ShowDialog()

            End If
        End With
    End Sub

    Private Sub btn_add_membro_Click(sender As Object, e As EventArgs) Handles btn_add_pendencia.Click
        nova_pendencia = True
        frm_pendencias.ShowDialog()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar_frm_menu()
    End Sub

    Private Sub btn_inverter_fluxo_Click(sender As Object, e As EventArgs) Handles btn_inverter_fluxo.Click
        inverter_ordem = Not inverter_ordem
        carregar_dgv_pendencias()
    End Sub

    Private Sub cmb_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtro.SelectedIndexChanged
        inverter_ordem = False
        carregar_dgv_pendencias()
    End Sub

    Private Sub btn_membros_Click(sender As Object, e As EventArgs) Handles btn_membros.Click
        If setor_usuario <> "TE" Then
            frm_listar_membros.ShowDialog()
        Else
            MsgBox("Você não tem permissão para acessar esse setor!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PREMISSÃO NEGADA")
        End If
    End Sub

    Private Sub btn_financas_Click(sender As Object, e As EventArgs) Handles btn_financas.Click
        If setor_usuario <> "SE" Then
            frm_balanco_financeiro.ShowDialog()
        Else
            MsgBox("Você não tem permissão para acessar esse setor!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PREMISSÃO NEGADA")
        End If
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        If setor_usuario <> "TE" Then
            frm_gerenciamento_usuarios.ShowDialog()
        Else
            MsgBox("Você não tem permissão para acessar esse setor!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PREMISSÃO NEGADA")
        End If

    End Sub

    Private Sub btn_logoff_Click(sender As Object, e As EventArgs) Handles btn_logoff.Click
        fazer_logoff()
    End Sub

    'Private Sub frm_menu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Application.Exit()
    'End Sub
End Class
