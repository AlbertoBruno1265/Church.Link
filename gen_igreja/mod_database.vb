Module mod_database
    'Objetos do Banco de Dados
    Public db As New ADODB.Connection 'Variável global do banco
    Public rs As New ADODB.Recordset 'Variável da tabela do banco
    Public sql As String


    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")

            db.Open("Provider=SQLOLEDB;Data Source=SUA_FONTE_AQUI;Initial Catalog=gerenciador_igreja;trusted_connection=yes;")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Sub encerrar_conexao(data_base As ADODB.Connection)
        data_base.Close()
    End Sub

    Function get_id_geral(descricao As String)
        Dim id_geral As String
        id_geral = UCase(descricao.Substring(0, 2))
        Return id_geral
    End Function

End Module
