<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina_controle.aspx.cs" Inherits="_Default" %>

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
             <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagem/imagem_logo.JPG" />
              </div>
            <br />
            <br />
            <div>
                 <p class="lead">  INSERT / SELECT / UPDATE / DELETE  </p>
             </div>
            <br />

        <div>
            <asp:GridView ID="gvcadastroeasy" runat="server" AutoGenerateColumns="False" ShowFooter="true" DataKeyNames="id" 
                ShowHeaderWhenEmpty="true" 
                OnRowCommand="gvPhoneBook_RowCommand" 
                OnRowEditing="gvPhoneBook_RowEditing" OnRowCancelingEdit="gvPhoneBook_RowCancelingEdit" OnRowUpdating="gvPhoneBook_RowUpdating" OnRowDeleting="gvPhoneBook_RowDeleting"

                BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="815px">
                <%-- Theme Properties --%>                
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />

                <Columns>
                       <asp:TemplateField HeaderText="NOME">
                         <ItemTemplate>
                             <asp:Label Text='<%#Eval("nome") %>' runat="server" />
                         </ItemTemplate>
                         <ItemTemplate >
                             <asp:TextBox runat="server" ID="txtnome" Text='<%#Eval("nome") %>'/>
                         </ItemTemplate>
                         <FooterTemplate>
                             <asp:TextBox runat="server" ID="txtnomeFooter" />
                         </FooterTemplate>
                     </asp:TemplateField>

                    <asp:TemplateField HeaderText="TELEFONE">
                         <ItemTemplate>
                             <asp:Label Text='<%#Eval("telefone") %>' runat="server" />
                         </ItemTemplate>
                         <ItemTemplate >
                             <asp:TextBox runat="server" ID="txttelefone" Text='<%#Eval("telefone") %>'/>
                         </ItemTemplate>
                         <FooterTemplate>
                             <asp:TextBox runat="server" ID="txttelefoneFooter" />
                         </FooterTemplate>
                         </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="CIDADE">
                         <ItemTemplate>
                             <asp:Label Text='<%#Eval("cidade") %>' runat="server" />
                         </ItemTemplate>
                         <ItemTemplate >
                             <asp:TextBox runat="server" ID="txtcidade" Text='<%#Eval("cidade") %>'/>
                         </ItemTemplate>
                         <FooterTemplate>
                             <asp:TextBox runat="server" ID="txtcidadeFooter" />
                         </FooterTemplate>
                     </asp:TemplateField>
                   
                                  
                     <asp:TemplateField HeaderText="ESTADO">
                         <ItemTemplate>
                             <asp:Label Text='<%#Eval("estado") %>' runat="server" />
                         </ItemTemplate>
                         <ItemTemplate >
                             <asp:TextBox runat="server" ID="txtestado" Text='<%#Eval("estado") %>'/>
                         </ItemTemplate>
                         <FooterTemplate>
                             <asp:TextBox runat="server" ID="txtestadoFooter" />
                         </FooterTemplate>
                     </asp:TemplateField>

                        
                     <asp:TemplateField>
                        <Itemtemplate>
                            <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Editar" Width="20px" Height="20px" />
                            <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Deletar" Width="20px" Height="20px" />
                        </Itemtemplate>
                        <EditItemTemplate>
                           <asp:ImageButton ImageUrl="~/Images/save.jpg" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                            <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Deletar" Width="20px" Height="20px" />
                        </EditItemTemplate>
                        <FooterTemplate>
                         <asp:ImageButton ImageUrl="~/Images/addnew.png" runat="server" CommandName="AddNew" ToolTip="Add New" Width="20px" Height="20px" />
                       </FooterTemplate>
                    </asp:TemplateField>
                </Columns>    
            </asp:GridView>
        </div>
        <br />

        <div>
            <asp:Label ID="lblSucessMessage" runat="server"  Forecolor="Green"></asp:Label>
        </div>


      
        
        <div>
            <asp:Label ID="lblErrorMessage" runat="server" Forecolor="Red"></asp:Label>
       </div>
   </div>     
 </form>
</body>
</html>
