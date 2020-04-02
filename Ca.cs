using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Ca
/// </summary>
public class Ca
{
    SqlCommand cmd = new SqlCommand();
    Conexao conexao = new Conexao();
    public string mensagem;

    public Ca(String portifolio, String horas, String horario, String salario)
    {
        // COMANDO SQL INSERT / DELETE / UPDATE - USAMOS SQLCommand.text -- ou comando na forma de texto
        cmd.CommandText = "insert into trabalho (portifolio, horas, horario, salario) values (@portifolio, @horas ,@horario, @salario)"; // NECESSÁRIO COLOCAR ARROBA NOS CAMPOS POR CAUSA DAS ASPAS

        // cmd.CommandText = "insert into cadastro (nome , telefone) values (@nome, @telefone)";



        // PARAMETROS -- PASSO DOIS VALORES QUE QUERO MUDAR NA TABELA
        cmd.Parameters.AddWithValue("@portifolio", portifolio);
        cmd.Parameters.AddWithValue("@horas", horas);
        cmd.Parameters.AddWithValue("@horario", horario);
        cmd.Parameters.AddWithValue("@salario", salario);



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
        catch (SqlException )
        {
            //USO A VARIAVEL e  ACIMA PARA GUARDAR O ERRO ESPECÍFICO
            this.mensagem = "Erro na conexão !";
            throw;
        }

    }
}