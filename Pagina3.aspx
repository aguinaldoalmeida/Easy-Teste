<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina3.aspx.cs" Inherits="Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="jumbotron">
           <div>
            
              <nav class="navbar navbar-expand-lg navbar navbar-light" style="background-color: #386FA4">
  
 
  <div class="collapse navbar-collapse" id="navbarNav">
      <br />
      <br />
     <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/Pagina_controle.aspx" ForeColor="#ffffff" Font-Size="X-Large" Visible="False">Ir para a página de controle de dados - Alterar / Deletar </asp:HyperLink>
  </div>
</nav>
        </div>
           <br />
           <div>
               <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagem/imagem_logo.JPG" />
           </div>
            
            <br />
            <br />
            <div>
                 <p class="lead">Bank Information / Informação Bancária</p>
             </div>
           <br />
             <div>
             <asp:Label ID="Lbl_alert77" runat="server"   class="alert alert-success" role="alert" Visible="False"> .</asp:Label>
             <asp:Label ID="Lbl_final" runat="server"   class="alert alert-success" role="alert" Visible="False"> .</asp:Label>
        
                 </div>
           <br />
             <div>
                <asp:Label ID="LblNome" runat="server" class="col-sm-2 col-form-label" Text="Nome :"></asp:Label>
                <asp:TextBox ID="TxbNome" class="form-control" Width="70%" placeholder="Escreva seu Nome" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>

             <div>
                <asp:Label ID="Lbl_CPF" runat="server" class="col-sm-2 col-form-label" Text="Only for Brazilians / CPF :"></asp:Label>
                <asp:TextBox ID="Txb_CPF" class="form-control" Width="70%" placeholder="Digite seu CPF" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>

             <div>
                <asp:Label ID="Lbl_banco" runat="server" class="col-sm-2 col-form-label" Text="Bank / Banco ( Itaú - Santander - Bradesco )"></asp:Label>
                <asp:TextBox ID="Txb_Banco" class="form-control" Width="70%" placeholder="Banco" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>

             <div>
                <asp:Label ID="Lbl_agencia" runat="server" class="col-sm-2 col-form-label" Text="Agency / Agencia"></asp:Label>
                <asp:TextBox ID="Txb_agencia" class="form-control" Width="70%" placeholder="Agência" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>

            <div>
                <p class="lead">
                    <asp:Label ID="Lbl_Conta_tipo" runat="server" class="col-sm-2 col-form-label" Text=" Account Type / Tipo de Conta :"></asp:Label></p>
            </div>

            <div>
                <asp:RadioButtonList ID="Radio_Tipo_conta" runat="server">
                    <asp:ListItem>Chain / Corrente</asp:ListItem>
                    <asp:ListItem>Savings / Poupança</asp:ListItem>
                    </asp:RadioButtonList>
                <hr class="my-4" />
            </div>

             <div>
                 <p class="lead">
                <asp:Label ID="Lbl_numero_conta" runat="server" class="col-sm-2 col-form-label" Text="Account Number / Numero da Conta"></asp:Label></p>
                <asp:TextBox ID="Txb_conta" class="form-control" Width="70%" placeholder="Número da Conta Bancária :" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>

             <br />

            <div>
                <asp:Button ID="Btn_pagina_seguinte" runat="server" class="btn btn-primary btn-lg btn-block" Text="Finalizar Cadastro" ForeColor="White" OnClick="Btn_pagina_seguinte_Click" />
            </div>

          

      </div>
    </form>
</body>
</html>
