using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Ca2
/// </summary>
public class Ca2
{
    SqlCommand cmd = new SqlCommand();
    Conexao conexao = new Conexao();
    public string mensagem;

    public Ca2(String nome, String cpf, String banco, String agencia, String conta, String numero)
    {
        // COMANDO SQL INSERT / DELETE / UPDATE - USAMOS SQLCommand.text -- ou comando na forma de texto
        cmd.CommandText = "insert into banco (nome, cpf, banco, agencia, conta, numero) values (@nome, @cpf ,@banco, @agencia, @conta, @numero)";



        // PARAMETROS -- PASSO DOIS VALORES QUE QUERO MUDAR NA TABELA
        cmd.Parameters.AddWithValue("@nome", nome);
        cmd.Parameters.AddWithValue("@cpf", cpf);
        cmd.Parameters.AddWithValue("@banco", banco);
        cmd.Parameters.AddWithValue("@agencia", agencia);
        cmd.Parameters.AddWithValue("@conta", conta);
        cmd.Parameters.AddWithValue("@numero", numero);



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
        catch (SqlException)
        {
            //USO A VARIAVEL e  ACIMA PARA GUARDAR O ERRO ESPECÍFICO
            this.mensagem = "Erro na conexão !";
            throw;
        }

    }
}