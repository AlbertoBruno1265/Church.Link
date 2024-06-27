Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles
Imports K4os.Compression.LZ4.Encoders
Imports ZstdSharp.Unsafe

Module mod_form
    'Declaração de Variáveis
    Public nome_usuario As String
    Public setor_usuario As String
    Public status_usuario As String
    Public setor_destino As String
    Public setor_origem As String
    Public categoria As String

    Public caminho_foto_membro_origem As String
    Public caminho_foto_membro_destino As String

    'Public status_pendencia As New DataGridViewTextBoxColumn

    Public is_novo_membro As Boolean
    Public is_visualizacao As Boolean
    Public is_criador As Boolean
    Public nova_pendencia As Boolean
    Public inverter_ordem As Boolean




    'Funções com Retorno


    'Funções sem Retorno



    '====Métodos Gerais====
    Sub fazer_logoff()
        Dim resp

        resp = MsgBox("Deseja mesmo encerrar a seção?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")

        If resp = vbYes Then
            frm_login.Show()
            frm_menu.Close()
        End If
    End Sub
    Sub zerar_cmb(combo_box As ComboBox)
        combo_box.Text = ""

    End Sub
    Sub preencher_cmb(coluna As String, tabela As String, combo_box As ComboBox)
        combo_box.Items.Clear()
        sql = "SELECT " & coluna & " FROM " & tabela & ""
        rs = db.Execute(UCase(sql))
        Do While Not rs.EOF
            combo_box.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub preencher_cmb_financas(coluna As String, tabela As String, tipo As String, combo_box As ComboBox)
        If tipo = "EN" Then
            visibilidade_dados_membro(True)
        Else
            visibilidade_dados_membro(False)
        End If

        zerar_cmb(combo_box)
        combo_box.Items.Clear()
        sql = "SELECT " & coluna & " FROM " & tabela & " WHERE id_tipo= '" & tipo & "'"
        rs = db.Execute(UCase(sql))
        Do While Not rs.EOF
            combo_box.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Sub buscar_cmb_membro(cmb_nome As ComboBox, txt_email As TextBox, txt_telefone As MaskedTextBox, txt_id_membro As TextBox)

        If cmb_nome.Text = "" Then
            cmb_nome.Items.Clear()
            txt_email.Text = ""
            txt_id_membro.Text = ""
            txt_telefone.Text = ""
        End If
        sql = "SELECT id_membro,nome,fone,email FROM membros
              WHERE nome LIKE '" & cmb_nome.Text & "%'"
        rs = db.Execute(sql)

        Do While Not rs.EOF
            If Not cmb_nome.Items.Contains(rs.Fields(1).Value) Then
                cmb_nome.Items.Add(rs.Fields(1).Value)
            End If
            rs.MoveNext()
        Loop
        cmb_nome.DroppedDown = True
    End Sub

    Sub preencher_cmb_dados_membro(cmb_nome As ComboBox, txt_email As TextBox, txt_telefone As MaskedTextBox, txt_id_membro As TextBox)

        sql = "SELECT 
               id_membro,
               nome,
               COALESCE(fone, ''),
               COALESCE(email, '') FROM membros
               WHERE nome = '" & cmb_nome.Text & "'"

        rs = db.Execute(sql)
        If Not rs.EOF Then
            txt_id_membro.Text = rs.Fields(0).Value
            cmb_nome.Text = rs.Fields(1).Value
            txt_telefone.Text = rs.Fields(2).Value
            txt_email.Text = rs.Fields(3).Value
        ElseIf cmb_nome.Text <> "" Then
            MsgBox("Membro não cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            zerar_dados_membro(cmb_nome, txt_id_membro, txt_email, txt_telefone)
        End If
        cmb_nome.DroppedDown = False

    End Sub

    'Function verificar_mes(data As String)
    'Dim mes_errado = False
    'Dim mes As Integer
    'mes = CInt(data.Substring(3, 2))
    'If mes > 12 Then
    '   MsgBox("TÁ ERRADO")
    'Else
    'Return mes = True
    'Exit Function
    'End If
    'Return mes_errado

    'End Function

    'Sub validar_datas_membros()
    '   With frm_gerenciamento_membros
    '      Try
    '         verificar_mes(.txt_data_batismo.Text)
    '        verificar_mes(.txt_data_conversao.Text)
    '       verificar_mes(.txt_data_falecimento.Text)
    '      verificar_mes(.txt_data_membramento.Text)
    '     verificar_mes(.txt_data_nascimento.Text)
    'Catch ex As Exception
    '
    'End Try

    'End With
    'End Sub

    Sub verificar_campo(campo As Object)

    End Sub

    '====frm_novo_usuario====
    Sub inicializar_frm_novo_usuario()
        conectar_banco()
        'Preciso inicializar os campos de senha
        With frm_novo_usuario
            .txt_senha.PasswordChar = "*"
            .txt_confirmar_senha.PasswordChar = "*"

            .txt_usuario.Text = ""
            .txt_senha.Text = ""
            .txt_confirmar_senha.Text = ""
            .cmb_funcao.Items.Clear()
            .cmb_funcao.Items.Add("PASTOR")
            .cmb_funcao.Items.Add("SECRETÁRIO")
            .cmb_funcao.Items.Add("TESOUREIRO")
            .txt_usuario.Focus()
        End With
    End Sub



    Sub alterar_view_senha_criacao(chk_senha As CheckBox, txt_senha As TextBox, txt_confirmar_senha As TextBox)

        If chk_senha.Checked Then

            txt_senha.PasswordChar = ""
            txt_confirmar_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
            txt_confirmar_senha.PasswordChar = "*"
        End If
    End Sub
    Sub zerar_frm_novo_usuario()
        With frm_novo_usuario
            .txt_usuario.Text = ""
            .txt_senha.Text = ""
            .txt_confirmar_senha.Text = ""
            .chk_mostrar_senha.Checked = False
            .cmb_funcao.Items.Clear()
            .cmb_funcao.Items.Add("PASTOR")
            .cmb_funcao.Items.Add("SECRETÁRIO")
            .cmb_funcao.Items.Add("TESOUREIRO")
        End With

    End Sub





    'Os próximos dois métodos, lidam com a verificação do primeiro login criado.
    'O primeiro usuário deve ser um secretário. Caso o contrário, o usuário não será criado.
    'O primeiro método confere se o usuário criado não é o primeiro. Caso não seja, o método
    'será chamado para passar a mensagem de usuário pendente para contatar o secretário.


    '====frm_login====
    Sub inicializar_frm_login()
        conectar_banco()
        With frm_login
            .txt_usuario.Text = ""
            .txt_senha.Text = ""
        End With
    End Sub

    Sub alterar_view_senha_login(chk_senha As CheckBox, txt_senha As TextBox)
        If chk_senha.Checked Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Sub zerar_frm_login()
        With frm_login
            .txt_usuario.Text = ""
            .txt_senha.Text = ""
            .chk_mostrar_senha.Checked = False
        End With
    End Sub


    '====frm_novo_membro====


    Sub gerar_idade()
        Dim idade As Integer
        Dim data_nascimento As DateTime


        With frm_gerenciamento_membros
            Try
                data_nascimento = .txt_data_nascimento.Text
                idade = Math.Floor(CInt(DateDiff(DateInterval.Month, data_nascimento, Date.Today)) / 12)
                .txt_idade.Text = idade
            Catch ex As Exception
                MsgBox("Não foi possível calcular a idade automaticamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End With
    End Sub


    ' GERENCIAMENTO DE USUARIO
    Sub inicializar_frm_gerenciamento_usuario()
        conectar_banco()
        zerar_frm_gerenciamento_usuarios()

        With frm_gerenciamento_usuarios
            .cmb_setor.Items.Clear()
            .cmb_status.Items.Clear()
            preencher_cmb("descricao", "setores", .cmb_setor)
            preencher_cmb("descricao", "status_usuarios", .cmb_status)
            carregar_dgv_gerenciamento_usuario(nome_usuario)

            If setor_usuario = "PA" Then
                .btn_gravar.Enabled = False
                .cmb_setor.Enabled = False
                .cmb_status.Enabled = False
            End If

        End With
    End Sub

    Sub carregar_dgv_gerenciamento_usuario(usuario_ativo As String)
        Dim cont As Integer

        sql = "SELECT u.nome_usuario, ss.descricao as setor, su.descricao as status, u.ultimo_acesso
               FROM usuarios u 
               INNER JOIN setores ss 
               ON u.id_setor = ss.id_setor
               INNER JOIN status_usuarios su
               ON u.status_usuario = su.id_status
               WHERE u.nome_usuario<>'" & usuario_ativo & "'"

        rs = db.Execute(sql)

        With frm_gerenciamento_usuarios.dgv_usuarios
            'If setor_usuario = "PA" Then
            '    .Columns.Remove("btn_excluir")
            'End If
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                cont += 1
                rs.MoveNext()
            Loop

        End With
    End Sub

    Sub zerar_frm_gerenciamento_usuarios()
        With frm_gerenciamento_usuarios
            .txt_usuario.Text = ""
            .cmb_setor.Text = ""
            .cmb_status.Text = ""
            .cmb_setor.Enabled = False
            .cmb_status.Enabled = False
        End With
    End Sub

    ' MEMBROS

    Sub inicializar_frm_listar_membros()
        conectar_banco()
        carregar_dgv_lista_membros()
        With frm_listar_membros
            .txt_pesquisa.Enabled = False
        End With
    End Sub

    Sub carregar_dgv_lista_membros()
        Dim cont As Integer


        sql = "SELECT m.id_membro,m.nome,m.idade,m.genero,m.email,m.fone,s.descricao As status_membro
               FROM membros m
               INNER JOIN status_membros s
               ON m.status_membro = s.id_status"
        rs = db.Execute(sql)
        With frm_listar_membros.dgv_lista_membros
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing, Nothing)
                cont += 1
                rs.MoveNext()
            Loop

        End With
    End Sub

    Sub desbilita_frm_membro()
        With frm_gerenciamento_membros
            .txt_nome.Enabled = False
            .txt_cpf.Enabled = False
            .txt_telefone.Enabled = False
            .txt_email.Enabled = False
            .txt_data_nascimento.Enabled = False
            .txt_idade.Enabled = False
            .txt_cep.Enabled = False
            .txt_endereco.Enabled = False
            .txt_cidade.Enabled = False
            .txt_bairro.Enabled = False
            .txt_numero.Enabled = False
            .txt_complemento.Enabled = False
            .txt_id_membro.Enabled = False
            .txt_data_falecimento.Enabled = False
            .txt_data_conversao.Enabled = False
            .txt_data_batismo.Enabled = False
            .txt_data_membramento.Enabled = False
            .cmb_funcao.Enabled = False
            .cmb_status_membro.Enabled = False
            .cmb_genero.Enabled = False
            .img_membro.Enabled = False

            '.btn_add_categoria.Visible = False
            '.lbl_add_categoria.Visible = False

            .btn_gravar_membro.Enabled = False
            .btn_editar_membro.Enabled = False
            .btn_limpar.Enabled = False
        End With
    End Sub

    Sub preencher_frm_novo_membro(id_membro As String)
        frm_gerenciamento_membros.Show()

        sql = "SELECT me.id_membro,
              me.cpf,
              me.nome,
              FORMAT(me.data_nascimento, 'dd/MM/yyyy'),
              me.idade,
              me.genero,
              COALESCE(me.email, ''),
              COALESCE(me.fone, ''),
              me.cep,
              me.endereco,
              me.cidade,
              me.bairro,
              me.numero,
              COALESCE(me.complemento, ''),
              FORMAT(me.data_membramento, 'dd/MM/yyyy'),
              FORMAT(me.data_batismo, 'dd/MM/yyyy'),
              COALESCE(FORMAT(me.data_conversao, 'dd/MM/yyyy'), ''),
              sm.descricao as status,
              COALESCE(FORMAT(me.data_falecimento, 'dd/MM/yyyy'), ''),
              fu.descricao as funcao,
              me.caminho_foto
              FROM membros me
              INNER JOIN funcoes fu
              ON me.id_funcao=fu.id_funcao
              INNER JOIN status_membros sm
              ON me.status_membro = sm.id_status
              WHERE id_membro ='" & id_membro & "'"

        rs = db.Execute(sql)

        With frm_gerenciamento_membros
            .txt_id_membro.Text = rs.Fields(0).Value
            .txt_cpf.Text = rs.Fields(1).Value
            .txt_nome.Text = rs.Fields(2).Value
            .txt_data_nascimento.Text = rs.Fields(3).Value
            .txt_idade.Text = rs.Fields(4).Value
            .cmb_genero.Text = rs.Fields(5).Value
            .txt_email.Text = rs.Fields(6).Value
            .txt_telefone.Text = rs.Fields(7).Value
            .txt_cep.Text = rs.Fields(8).Value
            .txt_endereco.Text = rs.Fields(9).Value
            .txt_cidade.Text = rs.Fields(10).Value
            .txt_bairro.Text = rs.Fields(11).Value
            .txt_complemento.Text = rs.Fields(13).Value
            .txt_data_membramento.Text = rs.Fields(14).Value
            .txt_data_batismo.Text = rs.Fields(15).Value
            .txt_data_conversao.Text = rs.Fields(16).Value
            .cmb_status_membro.Text = rs.Fields(17).Value
            .txt_data_falecimento.Text = rs.Fields(18).Value
            .cmb_funcao.Text = rs.Fields(19).Value
            .img_membro.Load(rs.Fields(20).Value)
            caminho_foto_membro_destino = rs.Fields(20).Value

            Try
                .txt_numero.Text = rs.Fields(12).Value
            Catch
                .txt_numero.Text = ""
            End Try


        End With
    End Sub


    'FORMULÁRIO DE MENU
    Sub inicializar_frm_menu()

        ' POR FAOVR, NÃO ESQUEÇA DE APAGAR ESSA ATROCIDADE EM FORMA DE CÓDIGO
        '=======================================================================================

        'setor_usuario = "PA"
        'nome_usuario = "SecreTeste"
        '=======================================================================================
        ' POR FAOVR, NÃO ESQUEÇA DE APAGAR ESSA ATROCIDADE EM FORMA DE CÓDIGO

        dados_usuario_online()

        conectar_banco()
        inverter_ordem = False
        carregar_cmbs()

        msg_pendencias_resolvidas()
        msg_pendencias_abertas()
    End Sub

    Sub carregar_cmbs()
        With frm_menu
            .cmb_filtro.Items.Add("URGÊNCIA")
            .cmb_filtro.Items.Add("DATA")
            .cmb_filtro.Items.Add("FECHADAS")
            .cmb_filtro.Items.Add("CRIADAS POR MIM")

            .cmb_filtro.SelectedIndex = 0
        End With
    End Sub

    Sub carregar_dgv_pendencias()
        sql = select_pendencias()
        'MsgBox(sql)
        'MsgBox("cheguei aqui")
        rs = db.Execute(sql)

        With frm_menu.dgv_pendencias
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value,
                                     Nothing, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                rs.MoveNext()
            Loop

            For Each row As DataGridViewRow In .Rows


                Select Case row.Cells(6).Value
                    Case 1
                        row.DefaultCellStyle.BackColor = Color.DarkGreen
                    Case 2
                        row.DefaultCellStyle.BackColor = Color.Green
                    Case 3
                        row.DefaultCellStyle.BackColor = Color.Yellow
                    Case 4
                        row.DefaultCellStyle.BackColor = Color.Orange
                    Case 5
                        row.DefaultCellStyle.BackColor = Color.Red
                End Select
            Next
        End With
    End Sub

    Sub preencher_frm_pendencias()
        sql = select_preencher()

        'MsgBox(sql)

        rs = db.Execute(sql)

        With frm_pendencias
            .txt_titulo_pendencia.Text = rs.Fields(0).Value
            .txt_descricao_pendencia.Text = rs.Fields(1).Value
            .cmb_urgencia.Text = rs.Fields(2).Value

            Select Case rs.Fields(3).Value
                Case "PA"
                    .txt_criador.Text = "PASTORAL"
                Case "SE"
                    .txt_criador.Text = "SECRETARIA"
                Case "TE"
                    .txt_criador.Text = "TESOURARIA"
                Case Else
                    .txt_criador.Text = "SISTEMA"
            End Select



            'setor_origem = rs.Fields(3).Value
            Try
                .cmb_nome.Text = rs.Fields(4).Value
                .txt_id_membro.Text = rs.Fields(5).Value
                .txt_telefone.Text = rs.Fields(6).Value
                .txt_email.Text = rs.Fields(7).Value
                setor_destino = rs.Fields(8).Value
            Catch ex As Exception

            End Try


        End With
    End Sub

    ' FORMULÁRIO DE PENDÊNCIAS
    Sub inicializar_frm_pendencias()
        conectar_banco()


        With frm_pendencias
            preencher_cmb("descricao", "urgencias", .cmb_urgencia)
            preencher_cmb("nome", "membros", .cmb_nome)
            alterar_visualizacao_pendencias()


        End With


    End Sub

    Sub alterar_visualizacao_pendencias()
        With frm_pendencias

            alterar_nome_radios()

            If nova_pendencia = False Then
                preencher_frm_pendencias()

                .btn_gravar_pendencia.Text = "RESOLVER PENDÊNCIA"

                If is_criador And frm_menu.dgv_pendencias.CurrentRow.Cells(3).Value = "PENDENTE" Then

                    .btn_gravar_pendencia.Enabled = False
                    .btn_editar_pendencia.Enabled = True
                    .btn_excluir_pendencia.Enabled = True

                    .cmb_nome.Enabled = True
                    .txt_titulo_pendencia.Enabled = True

                    .cmb_urgencia.Enabled = True
                    .txt_descricao_pendencia.Enabled = True

                    .lbl_setor.Visible = True
                    .rd_cima.Visible = True
                    .rd_baixo.Visible = True

                    .rd_cima.Enabled = True
                    .rd_baixo.Enabled = True

                    .lbl_criador.Visible = False
                    .txt_criador.Visible = False

                    If setor_destino = get_id_geral(.rd_cima.Text) Then
                        .rd_cima.Checked = True
                    Else
                        .rd_baixo.Checked = True
                    End If

                Else
                    With frm_menu.dgv_pendencias.CurrentRow
                        If Not .Cells(3).Value = "FECHADO" Then
                            frm_pendencias.btn_gravar_pendencia.Enabled = True
                        Else
                            frm_pendencias.btn_gravar_pendencia.Enabled = False
                        End If
                    End With

                    .btn_editar_pendencia.Enabled = False

                    .btn_excluir_pendencia.Enabled = False

                    .cmb_nome.Enabled = False
                    .txt_titulo_pendencia.Enabled = False

                    .cmb_urgencia.Enabled = False
                    .txt_descricao_pendencia.Enabled = False

                    If is_criador Then
                        .lbl_setor.Visible = True
                        .rd_cima.Visible = True
                        .rd_baixo.Visible = True

                        .rd_cima.Enabled = False
                        .rd_baixo.Enabled = False

                        If setor_destino = get_id_geral(.rd_cima.Text) Then
                            .rd_cima.Checked = True
                        Else
                            .rd_baixo.Checked = True
                    End If

                    Else
                        .lbl_setor.Visible = False
                        .rd_cima.Visible = False
                        .rd_baixo.Visible = False

                    End If

                    .lbl_criador.Visible = True
                    .txt_criador.Visible = True

                End If
            Else
                zerar_frm_pendencias()
                .txt_titulo_pendencia.Enabled = True
                .cmb_urgencia.Enabled = True
                .txt_descricao_pendencia.Enabled = True
                .cmb_nome.Enabled = True
                .btn_editar_pendencia.Enabled = False
                .btn_excluir_pendencia.Enabled = False
                .btn_gravar_pendencia.Text = "CADASTRAR PENDÊNCIA"
                .btn_gravar_pendencia.Enabled = True


                .lbl_setor.Visible = True
                .rd_cima.Visible = True
                .rd_baixo.Visible = True

                .rd_cima.Enabled = True
                .rd_baixo.Enabled = True

                .lbl_criador.Visible = False
                .txt_criador.Visible = False

                .txt_titulo_pendencia.Focus()
            End If



        End With

    End Sub

    Sub cadastrar_pendencia()
        construir_setores_destino()
        sql = insert_pendencia()

        'MsgBox(sql)

        db.Execute(sql)
        MsgBox("Pedencia cadastrada com sucesso!", MsgBoxStyle.Information + vbOKOnly, "SUCESSO")
        carregar_dgv_pendencias()
    End Sub

    Sub editar_pendencia()

        construir_setores_destino()
        sql = update_pendencia()

        'MsgBox(sql)

        db.Execute(sql)
        MsgBox("Pedencia atualizada com sucesso!", MsgBoxStyle.Information + vbOKOnly, "SUCESSO")
        carregar_dgv_pendencias()
    End Sub

    Sub excluir_pendencia()
        Dim resp

        resp = MsgBox("Tem certeza que deseja excluir esta pendência?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")

        If resp = vbYes Then
            sql = delete_pendencia()

            'MsgBox(sql)

            db.Execute(sql)

            MsgBox("Pedencia deletada com sucesso!", MsgBoxStyle.Information + vbOKOnly, "SUCESSO")
            carregar_dgv_pendencias()
        End If
    End Sub

    Sub resolver_pendencia()
        Dim resp

        resp = MsgBox("Tem certeza que deseja finalizar esta pendência?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")

        If resp = vbYes Then
            sql = update_resolucao()

            'MsgBox(sql)

            db.Execute(sql)

            MsgBox("Pedencia resolvida com sucesso!", MsgBoxStyle.Information + vbOKOnly, "SUCESSO")
            carregar_dgv_pendencias()

            With frm_pendencias
                .btn_gravar_pendencia.Enabled = False
            End With

        End If
    End Sub

    Sub zerar_frm_pendencias()
        With frm_pendencias
            .txt_titulo_pendencia.Text = ""
            .txt_descricao_pendencia.Text = ""
            preencher_cmb("descricao", "urgencias", .cmb_urgencia)

            .rd_cima.Checked = False
            .rd_baixo.Checked = False
            zerar_dados_membro(.cmb_nome, .txt_id_membro, .txt_email, .txt_telefone)
        End With
    End Sub

    Function verificar_campos_pendencias()
        Dim dados_completos As Boolean
        With frm_pendencias
            If (.rd_cima.Checked = False And
                .rd_baixo.Checked = False) Or
                .txt_titulo_pendencia.Text = "" Or
                .cmb_urgencia.Text = "" Then
                dados_completos = False
            Else
                dados_completos = True
            End If
        End With
        Return dados_completos
    End Function

    ' FORMULÁRIO CADASTRO DE OFERTAS E DÍZIMOS
    Sub inicializar_frm_financas()
        With frm_financas

            Try
                preencher_cmb("nome", "membros", .cmb_nome)
            Catch ex As Exception

            End Try

            If Not is_visualizacao Then
                conectar_banco()
                zerar_frm_financas()
                visibilidade_dados_membro(False)
                .cmb_categoria.Enabled = False
                .op_entrada.Checked = False
                .op_saida.Checked = False
                .btn_gravar_oferta.Enabled = True
            Else
                .op_entrada.Enabled = False
                .op_saida.Enabled = False
                .cmb_categoria.Enabled = False
                .cmb_data.Enabled = False
                .txt_descricao.Enabled = False
                .txt_valor.Enabled = False
                .cmb_nome.Enabled = False
                .txt_id_membro.Enabled = False
                .txt_telefone.Enabled = False
                .txt_email.Enabled = False
                .btn_gravar_oferta.Enabled = False
            End If
        End With
    End Sub

    Sub zerar_frm_financas()
        With frm_financas
            .cmb_categoria.Text = ""
            .txt_valor.Text = ""
            .txt_descricao.Text = ""
            .op_entrada.Focus()
            zerar_dados_membro(.cmb_nome, .txt_id_membro, .txt_email, .txt_telefone)
        End With

    End Sub

    Sub visibilidade_dados_membro(visivel As Boolean)
        With frm_financas
            .cmb_nome.Enabled = visivel
        End With
    End Sub

    Sub zerar_dados_membro(cmb_nome As ComboBox, id_membro As TextBox, email As TextBox, telefone As MaskedTextBox)

        cmb_nome.Text = ""
        id_membro.Text = ""
        email.Text = ""
        telefone.Text = ""
        cmb_nome.Items.Clear()
        preencher_cmb("nome", "membros", cmb_nome)
        'cmb_nome.DroppedDown = False
    End Sub
    Sub verificar_tipo_financas()

        With frm_financas
            If .op_entrada.Checked Then
                visibilidade_dados_membro(True)
            ElseIf .op_saida.Checked Then
                visibilidade_dados_membro(False)
            End If
        End With
    End Sub

    Sub verificar_campos_financas()
        With frm_financas
            If .cmb_categoria.Text = "" Or
                .txt_valor.Text = "" Then
                MsgBox("Por favor, preencher todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Else
                criar_financas()
                MsgBox("Lançamento realizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            End If
        End With
    End Sub



    ' FORM BALANÇO DE FINANÇAS

    Sub inicializar_frm_balanco()
        conectar_banco()

        With frm_balanco_financeiro
            .cmb_filtro.Items.Clear()
            .cmb_valor.Items.Clear()

            .cmb_filtro.Items.Add("ANO")
            .cmb_filtro.Items.Add("CATEGORIA")

            If setor_usuario = "PA" Then
                .btn_lancamento.Visible = False
                .lbl_lancamento.Visible = False
            Else
                .btn_lancamento.Visible = True
                .lbl_lancamento.Visible = True
            End If


            'Assim como o comentário abaixo, não faz sentido pré-selecionar o ano por padrão na inicialização.
            '.cmb_filtro.SelectedIndex = 0
        End With
        'Acho que não faz sentido preencher o ano no ato da inicialização do formulário.
        'Eu acho que faz mais sentido que o formulário inicie com todos os dados, sem filtro.

        'preencher_cmb_ano()
        carregar_dgv_balanco_financeiro()
    End Sub
    Sub carregar_dgv_balanco_financeiro()
        Dim cont As Integer

        sql = select_balanco()
        'MsgBox(sql)
        rs = db.Execute(sql)

        With frm_balanco_financeiro.dgv_balanco

            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                cont += 1
                rs.MoveNext()
            Loop

        End With
        preencher_totais()
    End Sub

    Sub preencher_cmb_ano()

        sql = "SELECT DISTINCT YEAR(data) FROM financas ORDER BY YEAR(data) DESC"

        rs = db.Execute(sql)


        With frm_balanco_financeiro
            Do While Not rs.EOF
                .cmb_valor.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            Loop
        End With

    End Sub

    Sub preencher_cmb_categoria()

        sql = "SELECT descricao FROM categorias_financas"

        rs = db.Execute(sql)

        With frm_balanco_financeiro
            Do While Not rs.EOF
                .cmb_valor.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            Loop

        End With

    End Sub

    Sub preencher_totais()
        sql = select_totais()
        'MsgBox(sql)
        rs = db.Execute(sql)

        With frm_balanco_financeiro

            If Not rs.EOF Then
                .txt_total_entradas.Text = "R$ " & rs.Fields(0).Value
                .txt_total_saidas.Text = "R$ " & rs.Fields(1).Value
                .txt_subtotal.Text = "R$ " & rs.Fields(2).Value
            Else
                .txt_total_entradas.Text = ""
                .txt_total_saidas.Text = ""
                .txt_subtotal.Text = ""
            End If
        End With
    End Sub

    Sub preencher_frm_financas(id_financa As Integer)

        sql = "SELECT 
              fi.tipo_financa,
              cf.descricao,
              FORMAT(fi.data, 'dd/MM/yyyy'),
              COALESCE(fi.descricao, ''),
              fi.valor,
              COALESCE(me.nome, ''),
              COALESCE(me.id_membro, ''),
              COALESCE(me.fone, ''),
              COALESCE(me.email, '')
              FROM financas fi
              LEFT JOIN membros me
              ON fi.id_membro = me.id_membro
              INNER JOIN categorias_financas cf
              ON fi.categoria_financa = cf.id_categoria
              WHERE id_financa = " & id_financa

        'MsgBox(sql)
        rs = db.Execute(sql)

        With frm_financas
            If rs.Fields(0).Value = "EN" Then
                .op_entrada.Checked = True
            ElseIf rs.Fields(0).Value = "SA" Then
                .op_saida.Checked = True
            End If
            .cmb_categoria.Text = rs.Fields(1).Value
            .cmb_data.Text = rs.Fields(2).Value
            'MsgBox(rs.Fields(3).Value)
            .txt_descricao.Text = rs.Fields(3).Value
            .txt_valor.Text = rs.Fields(4).Value
            .cmb_nome.Text = rs.Fields(5).Value
            'MsgBox(rs.Fields(6).Value)
            .txt_id_membro.Text = rs.Fields(6).Value
            .txt_telefone.Text = rs.Fields(7).Value
            .txt_email.Text = rs.Fields(8).Value
        End With
    End Sub
End Module
