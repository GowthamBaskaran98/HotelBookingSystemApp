<%@ Page Title="" Language="C#" MasterPageFile="~/Sites.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication2.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">
        <h2 style="background-color : cornflowerblue ">Sign Up</h2>
        <table align ="center">
                <tr>  
                    <td>First Name :</td>  
                    <td>  
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>  
                    </td>  
                     <td>
                        <asp:RequiredFieldValidator runat="server" ID="requiredName" ControlToValidate="txtFirstName" ErrorMessage="First Name Required" Style="color :royalblue "></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
               </tr> 
                <tr>  
                    <td>Last Name :</td>  
                    <td>  
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>  
                    </td>  
                     <td>
                        <asp:RequiredFieldValidator runat="server" ID="requiredLastName" ControlToValidate="txtLastName" ErrorMessage="Last Name Required" Style="color :royalblue "></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="rgvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>  
                     </td>
               </tr> 
                <tr>  
                    <td>Mobile Number :</td>  
                    <td>  
                        <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>  
                    </td> 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="requiredNumber" ControlToValidate="txtMobileNumber" ErrorMessage="Phone Number Required" Style="color: palevioletred"></asp:RequiredFieldValidator>                            
                    <asp:RegularExpressionValidator ID="rgvMobileNumber" runat="server" ControlToValidate="txtMobileNumber" ErrorMessage="Enter valid mobile number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                        </td>
               </tr> 
                 <tr>  
                    <td>Gmail :</td>  
                    <td>  
                        <asp:TextBox ID="txtGmail" runat="server"></asp:TextBox>  
                    </td>  
 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldGmail" ControlToValidate="txtGmail" ErrorMessage="Password Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rgvMailId" runat="server" ControlToValidate="txtGmail" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>  
                    </td>  
 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="RequiredField" ControlToValidate="txtPassword" ErrorMessage="Password Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>User Type</td>  
                    <td>  
                        <asp:RadioButtonList ID="rdButton" runat="server">  
                        <asp:ListItem>Customer</asp:ListItem>
                        <asp:ListItem>HotelOwner</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>  
                    <td>
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator" ControlToValidate="rdButton" ErrorMessage="User Type Required" Style="color :royalblue "></asp:RequiredFieldValidator>
                    </td>             
                    <td>  
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="height: 26px"  OnClick ="Submit_Click"/>
                    </td>  
                </tr>  
            </table>
        </div>
</asp:Content>
