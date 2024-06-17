Module mod_tesoureiro
    ' Variáveis Públicas
    Public tipo_financa As String

    ' Métodos

    Sub criar_financas()
        sql = insert_financas()

        'MsgBox(sql)
        db.Execute(sql)
    End Sub

    Function insert_financas()
        Dim insert As String
        Dim values As String

        Dim valor As Double
        Dim data As Date

        With frm_financas

            valor = CDbl(.txt_valor.Text)
            data = .cmb_data.Text

            insert = "INSERT INTO financas(categoria_financa, tipo_financa, valor, data"


            values = " VALUES('" & get_id_geral(.cmb_categoria.Text) & "'," &
                             "'" & tipo_financa & "'," &
                             "" & .txt_valor.Text & "," &
                             "'" & data & "'"

            If .txt_descricao.Text <> "" Then
                insert += ",descricao"
                values += ",'" & .txt_descricao.Text & "'"
            End If

            If .txt_id_membro.Text <> "" Then
                insert += ",id_membro"
                values += ",'" & .txt_id_membro.Text & "'"
            End If


        End With

        insert += ") "
        values += ")"

        Return insert & values
    End Function

    Function select_balanco()
        Dim sql_select As String
        Dim where As String
        Dim order_by As String

        sql_select = "SELECT c.descricao,
                      t.descricao,
                      f.valor,
                      FORMAT(f.data, 'dd/MM/yyyy'),
                      f.id_financa
               FROM financas f
               INNER JOIN categorias_financas c
               ON f.categoria_financa = c.id_categoria
               INNER JOIN tipos_financas t
               ON t.id_tipo = f.tipo_financa"

        where = " WHERE "

        order_by = " ORDER BY f.data DESC"

        'Pelo que eu entendi, ele tá concatenando a parte do ano, independente do ano estar selecionado ou não
        'A lógica aqui foi feita pra ser UM OU OUTRO.

        With frm_balanco_financeiro
            If .cmb_filtro.Text = "ANO" And .cmb_valor.Text <> "" Then
                where += "YEAR(f.data) = " & .cmb_valor.Text
            ElseIf .cmb_filtro.Text = "CATEGORIA" And .cmb_valor.Text <> "" Then
                where += "f.categoria_financa='" & get_id_geral(.cmb_valor.Text) & "'"
            Else
                where = ""
                Return sql_select & order_by
            End If
        End With

        Return sql_select & where & order_by

    End Function

    Function select_totais()
        Dim sql_select As String
        Dim where As String
        Dim pivot As String

        sql_select = "SELECT
	                      COALESCE(EN, 0) AS total_entradas,
	                      COALESCE(SA, 0) AS total_saidas,
	                      COALESCE(EN, 0) - COALESCE(SA, 0) AS subtotal
                      FROM "
        where = "(SELECT valor, tipo_financa FROM financas"

        pivot = ") AS f PIVOT(SUM(valor) FOR tipo_financa IN([EN],[SA])) AS p"

        With frm_balanco_financeiro

            If .cmb_valor.Text <> "" Then
                where += " WHERE"

                If .cmb_filtro.Text = "ANO" Then
                    where += " YEAR(data)=" & .cmb_valor.Text
                Else
                    where += " categoria_financa='" & get_id_geral(.cmb_valor.Text) & "'"
                End If
            End If

        End With

        Return sql_select & where & pivot
    End Function
End Module
