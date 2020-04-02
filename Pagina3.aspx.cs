using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Lbl_alert77.Visible = false;
        Lbl_final.Visible = false;
    }

    protected void Btn_pagina_seguinte_Click(object sender, EventArgs e)
    {
        String conta = Radio_Tipo_conta.SelectedValue;
       


        //COLOCO UMA CONDIÇÃO DE SOLICITAR PRENECHER TODOS OS CAMPOS OBRIGATÓRIOS
        if (!TxbNome.Text.Equals("") && (!Txb_CPF.Text.Equals("") && (!Txb_Banco.Text.Equals("") && (!Txb_agencia.Text.Equals("") && (! Radio_Tipo_conta.SelectedValue.Equals("") && (!Txb_conta.Text.Equals("")))))))

        {
            //OS DADOS DA PÁGINA SEGUINTE 
            HyperLink1.Visible = true;
            Lbl_final.Visible = true;
            Lbl_final.Text = "Dados enviados com sucesso ! Faremos contato, Obrigado !";
            Ca2 cad2 = new Ca2(TxbNome.Text, Txb_CPF.Text, Txb_Banco.Text, Txb_agencia.Text,conta, Txb_conta.Text);
        }
        else
        {
            Lbl_alert77.Visible = true;
            Lbl_alert77.Text = " NECESSÁRIO PREENCHER TODOS OS CAMPOS ";
            TxbNome.Text = "Necessário preencher esse campo";
            Txb_CPF.Text = "Necessário preencher esse campo";
            Txb_Banco.Text = "Necessário preencher esse campo";
            Txb_agencia.Text = "Necessário preencher esse campo";
            Txb_conta.Text = "Necessário preencher esse campo";
            TxbNome.Text = "Necessário preencher esse campo";

        }
    }
}