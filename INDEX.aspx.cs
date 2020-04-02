using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class INDEX : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //COLOCO UMA CONDIÇÃO DE SOLICITAR PRENECHER TODOS OS CAMPOS OBRIGATÓRIOS
        if (!TxbNome.Text.Equals("") && (!TxbSkype.Text.Equals("") && (!TxbTelefone.Text.Equals("") && (!TxbLinkedin.Text.Equals("") && (!TxbCidade.Text.Equals("") && (!TxbEstado.Text.Equals("")))))))

        {
            LoginDalComandos cad = new LoginDalComandos(TxbNome.Text, TxbSkype.Text, TxbTelefone.Text, TxbLinkedin.Text, TxbCidade.Text, TxbEstado.Text);


            // AQUI CHAMA A PÁGINA 
            Response.Redirect("Pagina2.aspx");
        }
        else
        {
            Lbl_alert1.Visible = true;
            Lbl_alert1.Text = " NECESSÁRIO PREENCHER OS CAMPOS COM  * ";
            TxbNome.Text = " * ";
            TxbSkype.Text = " * ";
            TxbTelefone.Text = " * ";
            TxbLinkedin.Text = " * ";
            TxbCidade.Text = " * ";
            TxbEstado.Text = " * ";


        }
    }
}