Module mod_pendencias

    Sub construir_setores_destino()
        setor_destino = ""

        With frm_pendencias

            If .rd_cima.Checked Then
                setor_destino = UCase(get_id_geral(.rd_cima.Text))
                'MsgBox(setor_destino)
            Else
                setor_destino = UCase(get_id_geral(.rd_baixo.Text))
                'MsgBox(setor_destino)
            End If

            'MsgBox(setor_destino)
        End With
    End Sub

    Sub alterar_nome_radios()
        With frm_pendencias

            Select Case setor_usuario
                Case "PA"
                    .rd_cima.Text = "Secretário"
                    .rd_baixo.Text = "Tesoureiro"

                Case "SE"
                    .rd_cima.Text = "Pastor"
                    .rd_baixo.Text = "Tesoureiro"

                Case "TE"
                    .rd_cima.Text = "Pastor"
                    .rd_baixo.Text = "Secretário"

            End Select

        End With
    End Sub

    Function select_preencher()
        Dim sql_select As String
        Dim where As String

        sql_select = "SELECT
	                        pe.titulo,
	                        COALESCE(pe.descricao, ''),
	                        ur.descricao,
	                        COALESCE(us.id_setor, 'SISTEMA'),
	                        COALESCE(me.nome, ''),
	                        COALESCE(me.id_membro, ''),
	                        COALESCE(me.fone, ''),
	                        COALESCE(me.email, ''),
                            pe.id_setor_destino
                       FROM
	                        pendencias pe
                       INNER JOIN
	                        urgencias ur
                       ON pe.id_urgencia = ur.id_urgencia
                       LEFT JOIN
	                        usuarios us
                       ON pe.nome_usuario = us.nome_usuario
                       LEFT JOIN
	                        membros me
                       ON pe.id_membro = me.id_membro
                       "

        With frm_menu.dgv_pendencias
            where = " WHERE id_pendencia=" & .CurrentRow.Cells(5).Value
        End With

        Return sql_select & where

    End Function

    Function select_pendencias()
        Dim sql_select As String
        Dim where As String
        Dim filtro As String

        sql_select = "SELECT
                            pe.titulo,
                            ur.descricao,
                            FORMAT(pe.data_criacao,'dd/MM/yyyy'),
                            sp.descricao,
                            pe.id_pendencia,
                            pe.id_urgencia,
                            COALESCE(pe.nome_usuario, '')
                       FROM pendencias pe
                       INNER JOIN urgencias ur
                       ON pe.id_urgencia = ur.id_urgencia
                       INNER JOIN status_pendencias sp
                       ON pe.status_pendencia = sp.id_status"

        where = " WHERE "

        filtro = " ORDER BY "

        With frm_menu

            If .cmb_filtro.Text = "URGÊNCIA" Then
                where += "pe.id_setor_destino = '" & setor_usuario & "' AND pe.status_pendencia = 'PE'"
                filtro += "id_urgencia"

            ElseIf .cmb_filtro.Text = "DATA" Then
                where += "pe.id_setor_destino = '" & setor_usuario & "' AND pe.status_pendencia = 'PE'"
                filtro += "pe.data_criacao"

            ElseIf .cmb_filtro.Text = "FECHADAS" Then
                where += "pe.id_setor_destino = '" & setor_usuario & "' AND pe.status_pendencia = 'FE'"
                filtro += "pe.data_resolucao"
            Else
                where += "pe.nome_usuario = '" & nome_usuario & "'"
                filtro += "pe.data_criacao"
            End If
        End With

        If inverter_ordem Then
            filtro += " ASC"
        Else
            filtro += " DESC"
        End If

        Return sql_select & where & filtro
    End Function

    Function insert_pendencia()
        Dim insert
        Dim values

        insert = "INSERT INTO pendencias(nome_usuario,
                                         id_setor_destino,
                                         titulo,
                                         data_criacao,
                                         status_pendencia,
                                         id_urgencia"

        With frm_pendencias
            values = " VALUES ('" & nome_usuario & "'," &
                          "'" & setor_destino & "'," &
                          "'" & .txt_titulo_pendencia.Text & "'," &
                          "'" & Date.Today & "'," &
                          "'PE'," &
                          (.cmb_urgencia.SelectedIndex + 1)

            If .txt_descricao_pendencia.Text <> "" Then
                insert += ",descricao"
                values += ",'" & .txt_descricao_pendencia.Text & "'"
            End If

            If .txt_id_membro.Text <> "" Then
                insert += ",id_membro"
                values += ",'" & .txt_id_membro.Text & "'"
            End If

        End With

        insert += ")"
        values += ")"

        Return insert & values
    End Function

    Function update_pendencia()
        Dim update As String
        Dim where As String

        update = "UPDATE pendencias SET "

        With frm_menu.dgv_pendencias
            where = " WHERE id_pendencia=" & .CurrentRow.Cells(5).Value
        End With

        With frm_pendencias
            update += "titulo='" & .txt_titulo_pendencia.Text & "'," &
                      "id_urgencia=" & (.cmb_urgencia.SelectedIndex + 1) & "," &
                      "id_setor_destino='" & setor_destino & "'"

            If .txt_descricao_pendencia.Text <> "" Then
                update += ",descricao='" & .txt_descricao_pendencia.Text & "'"
            End If

            If .txt_id_membro.Text <> "" Then
                update += ",id_membro='" & .txt_id_membro.Text & "'"
            End If
        End With

        Return update & where
    End Function

    Function update_resolucao()
        Dim status_pendencia As String

        With frm_pendencias
            If .txt_criador.Text = "SISTEMA" Then
                status_pendencia = "FE"
            Else
                status_pendencia = "RE"
            End If
        End With
        With frm_menu.dgv_pendencias
            Return "UPDATE pendencias SET status_pendencia='" & status_pendencia & "', data_resolucao='" & Date.Now & "' WHERE id_pendencia=" & .CurrentRow.Cells(5).Value
        End With
    End Function

    Function delete_pendencia()
        With frm_menu.dgv_pendencias
            Return "DELETE FROM pendencias WHERE id_pendencia=" & .CurrentRow.Cells(5).Value
        End With
    End Function

    Function select_resolvidas()
        Dim sql_select As String

        sql_select = "SELECT 
                        titulo,
                        FORMAT(data_resolucao, 'dd/MM/yyyy') 
                      FROM pendencias
                      WHERE nome_usuario='" & nome_usuario & "' AND status_pendencia='RE'"

        Return sql_select

    End Function

    Function update_fechadas()
        Dim update

        update = "UPDATE pendencias SET status_pendencia='FE' WHERE nome_usuario='" & nome_usuario & "' AND status_pendencia='RE'"

        Return update
    End Function

    Sub fechar_pendencias()

        sql = update_fechadas()
        db.Execute(sql)
    End Sub
    Sub msg_pendencias_resolvidas()
        Dim mensagem

        sql = select_resolvidas()

        rs = db.Execute(sql)

        If Not rs.EOF Then
            mensagem = "As seguintes pendências que você criou foram resolvidas:" & vbNewLine

            Do While Not rs.EOF
                mensagem += vbNewLine & "'" & rs.Fields(0).Value & "' - " & rs.Fields(1).Value
                rs.MoveNext()
            Loop

            mensagem += vbNewLine & vbNewLine & "Selecione 'OK' para fecha-las"

            MsgBox(mensagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PENDÊNCIAS RESOLVIDAS")

            fechar_pendencias()
        End If
    End Sub

    Function select_abertas()

        Dim sql_Select As String

        sql_Select = "SELECT titulo FROM pendencias WHERE id_setor_destino = '" & setor_usuario & "' AND status_pendencia='PE'"

        Return sql_Select
    End Function

    Sub msg_pendencias_abertas()

        sql = select_abertas()
        rs = db.Execute(sql)

        If Not rs.EOF Then
            MsgBox("Você tem pendências para resolver!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NOVAS PENDÊNCIAS")
        End If
    End Sub

End Module
