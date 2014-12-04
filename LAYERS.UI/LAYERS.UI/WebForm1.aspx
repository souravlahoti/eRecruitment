<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LAYERS.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 68%;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 206px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 370px;
        }

        .auto-style5 {
            width: 206px;
            height: 58px;
        }
        .auto-style6 {
            height: 58px;
            width: 370px;
        }

        .auto-style7 {
            width: 370px;
        }

        </style>
    <script type="text/javascript">
        function validateDates() {
            var writtenTest = document.getElementById("<%=TextBox1.ClientID%>").value;
            var technicalDate = document.getElementById("<%=TextBox2.ClientID%>").value;
            var hrTest = document.getElementById("<%=TextBox3.ClientID%>").value;
            if (writtenTest == technicalDate || writtenTest == hrTest || technicalDate == hrTest) {
                alert("No two test can be conducted on same day");
                document.getElementById("<%=TextBox1.ClientID%>").focus;
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Vacancy ID"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text="Required By Date"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label10" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Written Test Date" ></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Technical Interview Date"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="HR Interview Date"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" Text="Update" OnClientClick="return validateDates()" OnClick="Button1_Click1" style="height: 26px"/>
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click"/>
                </td>
            </tr>
        </table>
            </center>
    </div>
    </form>
</body>
</html>
