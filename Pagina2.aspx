<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

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
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagem/imagem_logo.JPG" />
            <br />
            <br />
            <div>
                 <p class="lead">Basic Information / Informações Básicas</p>
             </div>
            <br />
             <div>
                  <asp:Label ID="Lbl_alert1" runat="server"   class="alert alert-success" role="alert" Visible="False"> .</asp:Label>
             </div> 
            <br />
            <div>
                <asp:Label ID="LblPortifolio" runat="server" class="col-sm-2 col-form-label" Text="Portifólio :"></asp:Label>
                <asp:TextBox ID="TxbPortifolio" class="form-control" Width="70%" placeholder="Portifólio" runat="server" BorderWidth="2px"></asp:TextBox>
                <hr class="my-4" />
            </div>


            <div>
                <p class="lead">
                    <asp:Label ID="LblDisponibilidade" runat="server" class="col-sm-2 col-form-label" Text=" What is your willingness to work today ? / Qual é sua disponibilidade para trabalhar hoje ?"></asp:Label></p>
            </div>

            <div>
                <asp:RadioButtonList ID="Radio_trabalho" runat="server">
                    <asp:ListItem>Up to 4 hours per day</asp:ListItem>
                    <asp:ListItem>4 to 6 hours per day</asp:ListItem>
                    <asp:ListItem>6 to 8 hours per day</asp:ListItem>
                </asp:RadioButtonList>
                <hr class="my-4" />
            </div>



            <br />



            <div>
                <p class="lead">
                <asp:Label ID="Lbltrabalho" runat="server" Text=" What´s the best time to work you ? Pra você qual é o melhor horário para trabalhar ?
 "></asp:Label></p>
            </div>

            <div>
                <asp:RadioButtonList ID="Radio_horario" runat="server">
                  <asp:ListItem>Morning  from 08:00 to 12:00   Manha  de 08:00 as 12:00 </asp:ListItem>
                    <asp:ListItem>Afternoon  from 1:00 p.m. Tarde  de 13:00 as 18:00 </asp:ListItem>
                    <asp:ListItem>Night 7:00 p.m. to 10:00 p.m. Noite  de 19:00 as 22:00 </asp:ListItem>  
                </asp:RadioButtonList>
            </div>

             <br />
            <hr class="my-4" />
            <br />





            <div>
                <p class="lead">
                <asp:Label ID="LblSalario" runat="server"  Text=" What is your hourly salary requirements ? / Qual sua pretensão salarial por hora ?"></asp:Label>
                </p>
            </div>
            <div>
                <asp:TextBox ID="TxbSalario"  Width="70%" runat="server" class="form-control" BorderWidth="2px"></asp:TextBox>
                
                <br />
                <hr class="my-4" />
            </div>
          <br />

             <div>

                 <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg btn-block" Text="Seguinte" ForeColor="White" OnClick="Button1_Click" />

             </div>
             <br />

             <div>
                 <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-lg btn-block" Text="Anterior" ForeColor="White" />
             </div>


            
        </div>
       
    </form>
</body>
</html>
