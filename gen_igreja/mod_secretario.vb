Imports Google.Protobuf.WellKnownTypes

Module mod_secretario

    'Declaração de variáveis

    'Funções com retorno



    'Funções sem retorno



    '================================='
    'C.R.U.D

    'usuarios

    'READ:
    Function sec_ler_usuario()
        sql = "select nome_usuario,id_setor,status_usuario,ultimo_acesso FROM usuarios"
        rs = db.Execute(sql)
        Return rs
    End Function
    Sub sec_preencher_frm_usuario(dgv_usuarios As DataGridView)
        dgv_usuarios = sec_ler_usuario()
    End Sub

    'UPTADE:
    Sub sec_atualizar_status_usuario(cmb_status_usuario As ComboBox)
        sql = "Update usuarios set status_usuario = '" & cmb_status_usuario.Text & "'"
    End Sub

    'DELETE:
    Sub sec_apagar_usuario(nome_usuario As TextBox)
        sql = "Delete from usuarios where nome_usuario = '" & nome_usuario.Text & "'"
    End Sub


    'membros

    'CREATE:
    Sub sec_criar_membro()
        sql = insert_membros()
        'MsgBox(sql)
        Try
            db.Execute(sql)
            MsgBox("Membro cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
            zerar_frm_novo_membro()
        Catch pk As System.Runtime.InteropServices.COMException
            MsgBox("ERRO!" & vbNewLine & vbNewLine &
            "Este ID de Membro já foi cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            'MsgBox(pk)

            With frm_gerenciamento_membros
                .txt_id_membro.Focus()
            End With

        Catch e As Exception
            MsgBox("ERRO: " & e.Message)
        End Try
    End Sub

    Sub editar_membro()
        conectar_banco()

        sql = update_membros()
        db.Execute(sql)

        MsgBox("Dados do membro alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
        'zerar_frm_novo_membro()
        carregar_dgv_lista_membros()

    End Sub

    Function insert_membros()
        Dim insert As String
        Dim values As String

        Dim status_membro As String
        Dim data_nascimento, data_membramento, data_batismo, data_conversao, data_falecimento As Date
        Dim idade, funcao, numero As Integer

        With frm_gerenciamento_membros

            status_membro = get_id_geral(.cmb_status_membro.Text)
            data_membramento = .txt_data_membramento.Text
            data_nascimento = .txt_data_nascimento.Text
            data_batismo = .txt_data_batismo.Text
            idade = CInt(.txt_idade.Text)
            funcao = CInt(.cmb_funcao.SelectedIndex + 1)


            insert = "INSERT INTO membros(id_membro, 
                                      cpf, 
                                      nome,
                                      data_nascimento,
                                      idade,
                                      genero,
                                      cep,
                                      endereco,
                                      cidade, 
                                      bairro,
                                      data_membramento, 
                                      data_batismo,
                                      status_membro, 
                                      id_funcao,
                                      caminho_foto"




            values = " VALUES('" & .txt_id_membro.Text & "'," &
                                  "'" & .txt_cpf.Text & "'," &
                                  "'" & .txt_nome.Text & "'," &
                                  "'" & data_nascimento & "'," &
                                  "'" & idade & "'," &
                                  "'" & .cmb_genero.Text & "'," &
                                  "'" & .txt_cep.Text & "'," &
                                  "'" & .txt_endereco.Text & "'," &
                                  "'" & .txt_cidade.Text & "'," &
                                  "'" & .txt_bairro.Text & "'," &
                                  "'" & data_membramento & "'," &
                                  "'" & data_batismo & "'," &
                                  "'" & status_membro & "'," &
                                  "'" & funcao & "'," &
                                  "'" & caminho_foto_membro_destino & "'"

            If .txt_email.Text <> "" Then
                insert += ",email"
                values += ",'" & .txt_email.Text & "'"
            End If

            If .txt_telefone.Text <> "(  )      -" Then
                insert += ",fone"
                values += ",'" & .txt_telefone.Text & "'"
            End If

            If .txt_numero.Text <> "" Then
                numero = CInt(.txt_numero.Text)
                insert += ",numero"
                values += "," & numero & ""
            End If

            If .txt_complemento.Text <> "" Then
                insert += ",complemento"
                values += ",'" & .txt_complemento.Text & "'"
            End If

            If .txt_data_conversao.Text <> "  /  /" Then
                data_conversao = .txt_data_conversao.Text
                insert += ",data_conversao"
                values += ",'" & data_conversao & "'"
            End If

            If .txt_data_falecimento.Text <> "  /  /" Then
                data_falecimento = .txt_data_falecimento.Text
                insert += ",data_falecimento"
                values += ",'" & data_falecimento & "'"
            End If
        End With

        insert += ") "
        values += ")"

        Return insert & values

    End Function

    Function update_membros()
        Dim update As String
        Dim where As String

        Dim status_membro As String
        Dim data_nascimento, data_membramento, data_batismo, data_conversao, data_falecimento As Date
        Dim idade, funcao, numero As Integer

        With frm_gerenciamento_membros

            status_membro = get_id_geral(.cmb_status_membro.Text)
            data_membramento = .txt_data_membramento.Text
            data_nascimento = .txt_data_nascimento.Text
            data_batismo = .txt_data_batismo.Text
            idade = CInt(.txt_idade.Text)
            funcao = CInt(.cmb_funcao.SelectedIndex + 1)

            update = "UPDATE membros SET cpf='" & .txt_cpf.Text & "'," &
                                        "nome='" & .txt_nome.Text & "'," &
                                        "data_nascimento='" & .txt_data_nascimento.Text & "'," &
                                        "idade=" & idade & "," &
                                        "genero='" & .cmb_genero.Text & "'," &
                                        "cep='" & .txt_cep.Text & "'," &
                                        "endereco='" & .txt_endereco.Text & "'," &
                                        "cidade='" & .txt_cidade.Text & "'," &
                                        "bairro='" & .txt_bairro.Text & "'," &
                                        "data_membramento='" & data_membramento & "'," &
                                        "data_batismo='" & data_batismo & "'," &
                                        "status_membro='" & status_membro & "'," &
                                        "id_funcao='" & funcao & "'," &
                                        "caminho_foto='" & caminho_foto_membro_destino & "'"

            If .txt_email.Text = "" Then
                update += ",email=NULL"
            Else
                update += ",email='" & .txt_email.Text & "'"
            End If

            If .txt_telefone.Text = "(  )      -" Then
                update += ",fone=NULL"
            Else
                update += ",fone='" & .txt_telefone.Text & "'"
            End If

            If .txt_numero.Text = "" Then
                update += ",numero=NULL"
            Else
                numero = CInt(.txt_numero.Text)
                update += ",numero=" & numero
            End If

            If .txt_complemento.Text = "" Then
                update += ",complemento=NULL"
            Else
                update += ",complemento='" & .txt_complemento.Text & "'"
            End If

            If .txt_data_conversao.Text = "  /  /" Then
                update += ",data_conversao=NULL"
            Else
                data_conversao = .txt_data_conversao.Text
                update += ",data_conversao='" & data_conversao & "'"

            End If

            If .txt_data_falecimento.Text = "  /  /" Then
                update += ",data_falecimento=NULL"
            Else
                data_falecimento = .txt_data_falecimento.Text
                update += ",data_falecimento='" & data_falecimento & "'"
            End If

            where = " WHERE id_membro='" & .txt_id_membro.Text & "'"

        End With

        Return update & where

    End Function
End Module
