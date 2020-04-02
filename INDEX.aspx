<%@ Page Language="C#" AutoEventWireup="true" CodeFile="INDEX.aspx.cs" Inherits="INDEX" %>

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
               <asp:Image ID="Image1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Imagem/imagem_logo.JPG" Width="500px"/>
           </div>
           <br />
           <div>
                <asp:Label ID="Label1" runat="server" BackColor="#990000" Font-Size="X-Large" ForeColor="White" Text="C R U D   T E S T E" BorderWidth="5px"></asp:Label>
                <hr class="my-4" />
            </div>
           <br />
                <div>
                 <p class="lead">Basic Information / Informações Básicas</p>
             </div>
            
              <div>
                  <asp:Label ID="Lbl_alert1" runat="server"   class="alert alert-danger" role="alert" Visible="False"> .</asp:Label>
             </div>
           
             <br />
            <div>
                <asp:Label ID="Label2" runat="server" class="col-sm-2 col-form-label" Text="Nome / Name"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TxbNome" class="form-control" Width="70%" placeholder="Nome" runat="server" BorderWidth="2px"></asp:TextBox>

            </div>
            <hr class="my-4" />


            <div>
                <asp:Label ID="LblSkype" runat="server" class="col-sm-2 col-form-label" Text="Skype: ( please create an account if you dont´t have yet / bom criar caso não tenha )"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TxbSkype" class="form-control" Width="70%" placeholder="Preencha o Skype" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>

            <div>
                <asp:Label ID="LblTelefone" runat="server" class="col-sm-2 col-form-label" Text="Telefone / Phone ( Whatsapp )"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TxbTelefone" class="form-control" Width="70%" placeholder="Preencha o Telefone / Whatsapp" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>



            <div>
                <asp:Label ID="LblLinkedin" runat="server" class="col-sm-2 col-form-label" Text="Linkedin :"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TxbLinkedin" class="form-control" Width="70%" placeholder="Linkedin :" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>
            
           <div>
                <asp:Label ID="LblCidade" runat="server" class="col-sm-2 col-form-label" Text="Cidade / City :"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TxbCidade" class="form-control" Width="70%" placeholder="Cidade" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>


            <div>
                <asp:Label ID="LblEstado" runat="server" class="col-sm-2 col-form-label" Text="Estado / State :"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TxbEstado" class="form-control" Width="70%" placeholder="Estado" runat="server" BorderWidth="2px"></asp:TextBox>

            </div>

            <br />
           <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg btn-block" Text="Seguinte" ForeColor="White" OnClick="Button1_Click" />




            
        </div>
    </form>
</body>
</html>
