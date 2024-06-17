Imports System.Runtime.InteropServices

Module mod_usuarios
    Dim secretario As Boolean
    Dim primeiro_acesso = False

    Sub realizar_login(txt_usuario As TextBox, txt_senha As TextBox) 'Argumentos variáveis


        sql = "SELECT status_usuario, id_setor, nome_usuario FROM usuarios WHERE nome_usuario='" & txt_usuario.Text & "' AND senha='" & txt_senha.Text & "'"
        'MsgBox(sql)
        rs = db.Execute(sql)


        If txt_usuario.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Por favor, preencha todos os campos.", MsgBoxStyle.Critical, "DADOS INCOMPLETOS")

        ElseIf rs.EOF Then

            MsgBox("Nome de usuário ou senha inválidos." & vbNewLine & vbNewLine &
                "Por favor, tente novamente.", MsgBoxStyle.Critical, "DADOS INCORRETOS")
            txt_usuario.Focus()
            Exit Sub

        ElseIf Not txt_usuario.Text.Equals(rs.Fields(2).Value) Then

            MsgBox("Nome de usuário ou senha inválidos." & vbNewLine & vbNewLine &
                "Por favor, tente novamente.", MsgBoxStyle.Critical, "DADOS INCORRETOS")
            txt_usuario.Focus()
            Exit Sub

        ElseIf rs.Fields(0).Value = "AT" And txt_usuario.Text.Equals(rs.Fields(2).Value) Then
            nome_usuario = txt_usuario.Text
            setor_usuario = rs.Fields(1).Value
            MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM-VINDO")
            sql = "UPDATE usuarios SET ultimo_acesso='" & DateTime.Now & "' WHERE nome_usuario='" & txt_usuario.Text & "'"
            db.Execute(UCase(sql))
            zerar_frm_login()
            If primeiro_acesso = True Then
                frm_apresentacao.ShowDialog()
                primeiro_acesso = False
            End If
            frm_menu.Show()

            'ISSO AQUI FUNCIONA
            frm_login.Hide()

        Else
            MsgBox("Não foi possível realizar o login!" & vbNewLine & vbNewLine &
                   "Contate o secretário responsável.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Sub insert_novo_usuario(usuario As String, senha As String, funcao As String, status As String)
        'MsgBox(funcao)
        funcao = UCase(funcao.Substring(0, 2))
        sql = "INSERT INTO usuarios(nome_usuario, senha, id_setor, status_usuario) VALUES ('" & usuario & "'," &
                                                                                   "'" & senha & "', " &
                                                                                   "'" & funcao & "', " &
                                                                                   "'" & status & "')"
        Try
            db.Execute(sql)
            'zerar_frm_novo_membro()
        Catch pk As System.Runtime.InteropServices.COMException
            'MsgBox("ERRO!" & vbNewLine & vbNewLine &
            '      "Este Nome de Usuário já foi cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

        'zerar_frm_novo_usuario()
    End Sub

    Sub verificar_dados_usuario(txt_usuario As TextBox, txt_senha As TextBox, txt_confirmar_senha As TextBox, cmb_funcao As ComboBox)

        If verificar_campos_vazios_novo_usuario(txt_usuario, txt_senha, txt_confirmar_senha, cmb_funcao) = True Then
            'MsgBox("Estou aqui1")
            If verificar_senhas_novo_usuario(txt_senha, txt_confirmar_senha) = True Then
                'MsgBox("Estou aqui2")
                If verificar_primeiro_usuario() Then

                    If cmb_funcao.Text <> "SECRETÁRIO" Then
                        MsgBox("O primeiro usuário a ser criado, deve ser o Secretário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Exit Sub
                    Else
                        primeiro_acesso = True
                        insert_novo_usuario(txt_usuario.Text, txt_senha.Text, cmb_funcao.Text, "AT")
                        gerar_pendencia_primeiro_usuario()
                        MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
                        frm_novo_usuario.Close()
                    End If

                Else
                    'MsgBox("estou é o certo")
                    If verificar_nome_usuario(txt_usuario) = True Then

                        insert_novo_usuario(txt_usuario.Text, txt_senha.Text, cmb_funcao.Text, "PE")
                        gerar_pendencia_novo_usuario()
                        MsgBox("Usuário criado. Aguarde a aprovação do secretário!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        frm_novo_usuario.Close()
                    End If
                End If

            End If
        End If
    End Sub
    Sub criar_usuario(txt_usuario As TextBox, txt_senha As TextBox, txt_confirmar_senha As TextBox, cmb_funcao As ComboBox)

    End Sub

    Function verificar_campos_vazios_novo_usuario(txt_usuario As TextBox, txt_senha As TextBox, txt_confirmar_senha As TextBox, cmb_funcao As ComboBox)
        If txt_usuario.Text = "" Or
           txt_senha.Text = "" Or
           txt_confirmar_senha.Text = "" Or
           cmb_funcao.Text = "" Then
            MsgBox("Por favor, preencher todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Return False
        End If
        Return True
    End Function

    Function verificar_senhas_novo_usuario(txt_senha As TextBox, txt_confirmar_senha As TextBox)

        If txt_senha.Text <> txt_confirmar_senha.Text Then
            MsgBox("As senhas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Return False
        End If
        Return True
    End Function

    'Function verificar_primeiro_usuario(funcao As String)

    '    sql = "SELECT * FROM usuarios"
    '    rs = db.Execute(sql)

    '    If rs.EOF Then
    '        If funcao <> "SECRETÁRIO" Then
    '            MsgBox("O primeiro usuário a ser criado, deve ser o Secretário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '            zerar_frm_novo_usuario()
    '            secretario = False
    '            Return False
    '        ElseIf funcao = "SECRETÁRIO" Then
    '            MsgBox("Secretário criado com sucesso!" & vbNewLine & vbNewLine &
    '                  "Agora, atualize seus dados como membro!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    '            Return True
    '        End If
    '    Else
    '        Return False
    '    End If

    'End Function

    Function verificar_primeiro_usuario()

        sql = "SELECT nome_usuario FROM usuarios"
        rs = db.Execute(sql)

        Return rs.EOF
    End Function

    Function verficar_setor_primeiro_usuario()
        Dim usuario_secretario As Boolean
        usuario_secretario = False
        sql = "SELECT * FROM usuarios where id_setor = 'SE'"
        rs = db.Execute(sql)

        If rs.EOF Then
            With frm_novo_usuario.cmb_funcao
                If UCase(.Text) = "SECRETÁRIO" Then
                    usuario_secretario = True
                End If
            End With
        End If
        Return usuario_secretario
    End Function

    Function verificar_nome_usuario(txt_usuario As TextBox)

        sql = "SELECT * FROM usuarios WHERE nome_usuario = '" & txt_usuario.Text & "'"
        rs = db.Execute(sql)

        If Not rs.EOF Then
            MsgBox("ERRO!" & vbNewLine & vbNewLine &
                  "Este Nome de Usuário já foi cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            zerar_frm_novo_usuario()
            'O cmb não é zerado nesse caso. Preciso observar como é feito no caso do frm de cadastro de membros
            Return False
        Else
            Return True
        End If
    End Function

    Sub gerar_pendencia_novo_usuario()
        With frm_novo_usuario
            sql = "INSERT INTO pendencias(id_setor_destino,
                                      titulo,
                                      descricao,
                                      data_criacao,
                                      status_pendencia,
                                      id_urgencia) 
                                      VALUES ('SE','NOVO USUÁRIO AGUARDANDO APROVAÇÃO'," & "'O usuário: " & .txt_usuario.Text & " foi cadastrado com sucesso!" & vbNewLine & vbNewLine &
                                     "Ele está aguardando a ativação.'," &
                                     "'" & DateTime.Now & "'," &
                                     "'PE'," &
                                     "5)"
        End With
        'MsgBox(sql)
        'Try
        db.Execute(sql)
        'Catch pk As System.Runtime.InteropServices.COMException
        'MsgBox("ERRO!" & vbNewLine & vbNewLine &
        '        '      "Este Nome de Usuário já foi cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        'Catch ex As Exception
        'MsgBox("Erro: " & ex.Message)
        'End Try
    End Sub

    Sub gerar_pendencia_primeiro_usuario()
        With frm_novo_usuario
            Dim descricao

            descricao = "'Obrigado por instalar o Church.Link!" & vbNewLine & vbNewLine &
                        "Recomendamos que você já crie seu perfil de membro, bem como, o do pastor e o do tesoureiro." & vbNewLine & vbNewLine &
                        "Atenciosamente," & vbNewLine & "Equipe Church.Link!'"

            sql = "INSERT INTO pendencias(id_setor_destino,
                                      titulo,
                                      descricao,
                                      data_criacao,
                                      status_pendencia,
                                      id_urgencia) 
                                      VALUES ('SE','BOAS VINDAS AO CHRUCH.LINK!'," &
                                      descricao & "," &
                                     "'" & DateTime.Now & "'," &
                                     "'PE'," &
                                     "3)"
        End With
        'MsgBox(sql)
        'Try
        db.Execute(sql)
        'Catch pk As System.Runtime.InteropServices.COMException
        'MsgBox("ERRO!" & vbNewLine & vbNewLine &
        '        '      "Este Nome de Usuário já foi cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        'Catch ex As Exception
        'MsgBox("Erro: " & ex.Message)
        'End Try
    End Sub

    Sub dados_usuario_online()
        With frm_menu
            .lbl_nome_usuario.Text = "USUÁRIO: " + nome_usuario
            If setor_usuario = "SE" Then
                .lbl_setor.Text = "SETOR: SECRETARIA"
            ElseIf setor_usuario = "TE" Then
                .lbl_setor.Text = "SETOR: TESOURARIA"
            Else
                .lbl_setor.Text = "SETOR: PASTORAL"
            End If
        End With
    End Sub
End Module