Module mod_membros

    Sub carregar_foto()
        Dim indice_ultima_barra, tamanho_cadeia As Integer
        Dim nome_arquivo As String
        '
        With frm_gerenciamento_membros
            Dim foto = .OpenFileDialog1
            foto.Title = "SELECIONE UMA FOTO"
            foto.InitialDirectory = (Application.StartupPath & "\Fotos")
            foto.DefaultExt = "PNG"
            foto.Filter = "todos arquivos|*.PNG; *.JPG"
            foto.FileName = ""
            foto.ShowDialog()
            caminho_foto_membro_origem = foto.FileName

            If caminho_foto_membro_origem = "" Then
                MsgBox("Você não selecionou nenhuma foto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If

            indice_ultima_barra = caminho_foto_membro_origem.LastIndexOf("\")
            tamanho_cadeia = Len(caminho_foto_membro_origem) - indice_ultima_barra - 1

            nome_arquivo = caminho_foto_membro_origem.Substring(indice_ultima_barra + 1, tamanho_cadeia)

            caminho_foto_membro_destino = ".\Fotos\" & nome_arquivo


            My.Computer.FileSystem.CopyFile(caminho_foto_membro_origem,
                                            caminho_foto_membro_destino,
                                            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

            .img_membro.Load(caminho_foto_membro_destino)
        End With
    End Sub

    Sub inicializar_frm_novo_membro()
        conectar_banco()
        With frm_gerenciamento_membros

            preencher_cmb("descricao", "status_membros", .cmb_status_membro)
            preencher_cmb("descricao", "funcoes", .cmb_funcao)
            .cmb_genero.Items.Add("M")
            .cmb_genero.Items.Add("F")

            .txt_data_falecimento.Enabled = False
            alterar_btn_membro()

            If setor_usuario = "PA" Then
                desbilita_frm_membro()

            End If



        End With
    End Sub

    Sub alterar_btn_membro()
        With frm_gerenciamento_membros
            If is_novo_membro Then
                zerar_frm_novo_membro()

                .btn_editar_membro.Enabled = False
                .btn_gravar_membro.Enabled = True

                .txt_id_membro.Enabled = True
            Else
                .btn_editar_membro.Enabled = True
                .btn_gravar_membro.Enabled = False

                .txt_id_membro.Enabled = False
            End If
        End With
    End Sub
    Sub zerar_frm_novo_membro()
        caminho_foto_membro_destino = ".\Icones\nova_foto.png"
        With frm_gerenciamento_membros
            .txt_id_membro.Text = ""
            .txt_cpf.Text = ""
            .txt_nome.Text = ""
            .txt_data_nascimento.Text = ""
            .txt_idade.Text = ""
            .cmb_genero.Items.Clear()
            .txt_email.Text = ""
            .txt_telefone.Text = ""
            .txt_cep.Text = ""
            .txt_endereco.Text = ""
            .txt_cidade.Text = ""
            .txt_bairro.Text = ""
            .txt_numero.Text = ""
            .txt_complemento.Text = ""
            .txt_data_membramento.Text = ""
            .txt_data_batismo.Text = ""
            .txt_data_conversao.Text = ""
            .cmb_status_membro.Items.Clear()
            .txt_data_falecimento.Text = ""
            .cmb_funcao.Items.Clear()
            .img_membro.Load(caminho_foto_membro_destino)

            preencher_cmb("descricao", "status_membros", .cmb_status_membro)
            preencher_cmb("descricao", "funcoes", .cmb_funcao)
            .cmb_genero.Items.Add("M")
            .cmb_genero.Items.Add("F")
        End With
    End Sub

    Function verificar_campos_membro()
        Dim dados_completos As Boolean
        dados_completos = True

        With frm_gerenciamento_membros
            If .txt_id_membro.Text = "" Or
                    .txt_cpf.Text = "" Or
                    .txt_nome.Text = "" Or
                    .txt_data_nascimento.Text = "" Or
                    .txt_idade.Text = "" Or
                    .cmb_genero.Text = "" Or
                    .txt_cep.Text = "" Or
                    .txt_endereco.Text = "" Or
                    .txt_cidade.Text = "" Or
                    .txt_bairro.Text = "" Or
                    .txt_data_membramento.Text = "" Or
                    .txt_data_batismo.Text = "" Or
                    .cmb_status_membro.Text = "" Or
                    .cmb_funcao.Text = "" Then
                dados_completos = False
            End If
        End With
        Return dados_completos
    End Function
End Module
