<%@ Page Title="" Language="C#" MasterPageFile="~/Sites.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2 style="background-color : cornflowerblue " align="center">Sign In</h2>
            <table class="auto-style1" align ="center">
                <tr>  
                    <td>User ID :</td>  
                    <td>  
                        <asp:TextBox ID="userId" runat="server"></asp:TextBox>  
                    </td>
               </tr> 
                 <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="password" runat="server"></asp:TextBox>  
                    </td>
                </tr>
                 <tr>                      
                    <td>  
                        <asp:Button ID="Submit" runat="server" Text="Submit" style="height: 26px"  OnClick ="Submit_Clicked"/>
                    </td>  
                </tr>  
            </table>
</asp:Content>
