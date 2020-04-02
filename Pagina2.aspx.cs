using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String horas = Radio_trabalho.SelectedValue;
        String horario = Radio_horario.SelectedValue;
        Lbl_alert1.Visible = false;

        
        //COLOCO UMA CONDIÇÃO DE SOLICITAR PRENECHER TODOS OS CAMPOS OBRIGATÓRIOS
        if (!TxbPortifolio.Text.Equals("") && (!Radio_trabalho.SelectedValue.Equals("") && (!Radio_horario.SelectedValue.Equals("") && (!TxbSalario.Text.Equals("")))))

        {

            Ca cad2 = new Ca(TxbPortifolio.Text, horas, horario, TxbSalario.Text);


            // AQUI CHAMA A PÁGINA 
            Response.Redirect("Pagina3.aspx");

            
        }
        else
        {
            Lbl_alert1.Visible = true;
            Lbl_alert1.Text = " NECESSÁRIO PREENCHER TODOS OS CAMPOS ";
          
        }
    }
}