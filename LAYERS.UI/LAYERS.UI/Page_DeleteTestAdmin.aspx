<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="Page_DeleteTestAdmin.aspx.cs" Inherits="LAYERS.UI.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
   <center> <h2> Test Administrator List</h2></center>
    </div>
    <form id ="form1" runat="server">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  DataKeyNames="TestAdminId" OnRowDeleting="GridView1_RowDeleting" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" Height="180px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="2" Width="600px" CellSpacing="2" ForeColor="Black">
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <Columns>
                <asp:TemplateField HeaderText="Emplyee Id">
                    <ItemTemplate>
                        <asp:Label ID="testadminid" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval("TestAdminId")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Name">
                   <ItemTemplate>
                        <asp:Label ID="name1" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval("emp.Name")%>' />
                    </ItemTemplate> 
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Location">
                    <ItemTemplate>
                        <asp:Label ID="loaction1" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval(" emp.Location")%>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Designation">
                    <ItemTemplate>
                        <asp:Label ID="designation1" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval(" emp.Designation")%>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Experience">
                    <ItemTemplate>
                        <asp:Label ID="exp" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval("Vcancy.Experience")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="Action" ShowDeleteButton="True" >
                <ControlStyle ForeColor="#FF3300" />
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView></center>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        </form>
</asp:Content>
