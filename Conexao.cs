using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Conexao
/// </summary>
public class Conexao
{
    //PARA CONECTAR O BANCO PRECISO DESSA CONEXAO DECLARADA
    SqlConnection con = new SqlConnection();



    // CONSTRUTOR
    public Conexao()
    {
        //@" aqui vai a connection string do banco de dados - TENHO QUE COLOCAR O @ NA FRENTE DAS ASPAS PARA ELE RECONHECER AS BARRAS CONTRARIAS ";
        //con.ConnectionString = @"Data Source = AGUINALDO\SQL_EXPRESS; Initial Catalog = easy02; Integrated Security = True";

        

        con.ConnectionString = @"Data Source=AGUINALDO\SQL_EXPRESS;Initial Catalog=easy;Integrated Security=True";
        //@"Data Source = AGUINALDO\SQL_EXPRESS; Initial Catalog = testeasy; Integrated Security = True";

        //con.ConnectionString = @"Data Source=AGUINALDO\SQL_EXPRESS;Initial Catalog=Exemplo;Integrated Security=True";

    }



    // METODO PARA CONECTAR AO BANCO
    public SqlConnection conectar()
    {
        // PARA CONECTAR AO BANCO FAÇO A PERGUNTA SE ESTA CONECTADO OU NÃO
        if (con.State == System.Data.ConnectionState.Closed)
        {
            con.Open();
        }
        return con;
    }



    // METODO PARA DESCONECTAR DO BANCO

    public void desconectar()
    {
        if (con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
        }


    }
}