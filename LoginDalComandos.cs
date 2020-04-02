using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de LoginDalComandos
/// </summary>
public class LoginDalComandos
{
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;



    public LoginDalComandos(String nome, String skype, String telefone, String linkedin, String cidade, String estado)
    {
        // COMANDO SQL INSERT / DELETE / UPDATE - USAMOS SQLCommand.text -- ou comando na forma de texto
        cmd.CommandText = "insert into cadastro (nome , skype, telefone, linkedin, cidade, estado) values (@nome, @skype ,@telefone, @linkedin, @cidade, @estado)"; // NECESSÁRIO COLOCAR ARROBA NOS CAMPOS POR CAUSA DAS ASPAS

        // cmd.CommandText = "insert into cadastro (nome , telefone) values (@nome, @telefone)";



        // PARAMETROS -- PASSO DOIS VALORES QUE QUERO MUDAR NA TABELA
        cmd.Parameters.AddWithValue("@nome", nome);
        cmd.Parameters.AddWithValue("@skype", skype);
        cmd.Parameters.AddWithValue("@telefone", telefone);
        cmd.Parameters.AddWithValue("@linkedin", linkedin);
        cmd.Parameters.AddWithValue("@cidade", cidade);
        cmd.Parameters.AddWithValue("@estado", estado);


        // CONECTAR COM  O BANCO DE DADOS
        //USO O TRY PORQUE CASO OCORRA ERRO CAI NESSE TRATAMENTO
        try
        {
            cmd.Connection = conexao.conectar();
            // EXECUTAR O COMANDO SE FOR INSERT || DELETE || UPDATE
            //ExecuteNonRead TRAS OS DADOS PARA  A APLICAÇÃO -- COMO EU VOU SOMENTE ENVIAR OS DADOS ENTÃO USO ExecuteNonQuery
            cmd.ExecuteNonQuery();

            // DESCONECTAR COM O BANCO
            conexao.desconectar();

            // MESAGEM DE ERRO OU SUCESSO -- string mensagem
            this.mensagem = "Dados confirmados com sucesso !";

        }
        catch (SqlException e)
        {
            //USO A VARIAVEL e  ACIMA PARA GUARDAR O ERRO ESPECÍFICO
            this.mensagem = "Erro na conexão !";
            throw;
        }

    }


}
