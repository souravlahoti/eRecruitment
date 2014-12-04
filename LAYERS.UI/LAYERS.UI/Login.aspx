<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LAYERS.UI.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script>
         function Validate() {
             var uname = document.getElementById('<%=username.Text%>').value;
             var pass = document.getElementById('<%=password.Text%>').value;
             var flag = 1;
             if (uname == '' || uname == ' ') {
                 alert("Username Required");
                 flag = 0;
             }
             else {
                 if (pass == '' || pass == ' ') {
                     alert("Password Required");
                     flag = 0;
                 }
                }
                       if (flag == 0)
                 return false;
             else
                 return true;
         }
    </script>

    <script>
        history.forward();
    </script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="height:250px;">  
    <center>
    <fieldset style="width:80%;">
        <legend>Login Details</legend>
        <form id="form1" runat="server">
            <asp:Table runat="server" ID="login" style="background-color:lightcyan;">
           <asp:TableRow>
                    <asp:TableCell>Username</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="username" runat="server"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>Password</asp:TableCell><asp:TableCell><asp:TextBox ID="password" TextMode="Password" runat="server"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow> 
                     <asp:TableCell></asp:TableCell><asp:TableCell>
                     <asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click" ></asp:Button><input type="reset" value="Reset" />
                    </asp:TableCell></asp:TableRow></asp:Table></form></fieldset> </center></div><br />

</asp:Content>
