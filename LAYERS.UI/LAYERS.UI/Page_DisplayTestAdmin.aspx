<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="Page_DisplayTestAdmin.aspx.cs" Inherits="LAYERS.UI.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <p align="center" />
            &nbsp;</p> 
    <div>
     
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
     <center> <asp:Label ID="Label3" runat="server" Text="Test Administrator List" Font-Bold="true" Font-Size="Large"  ></asp:Label> </center>
        &nbsp;<br />
        <br />
&nbsp;<center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="190px" BackColor="#CCCCCC" Width="644px" BorderStyle="Solid" BorderWidth="3px" BorderColor="#999999" Font-Size="Large" AllowPaging="True" CellPadding="4" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="3" HorizontalAlign="Center" CellSpacing="2" ForeColor="Black">
            <Columns>
                 
                
                <asp:TemplateField HeaderText="Name" >
                    <ItemTemplate>
                     <asp:Label ID="label1" runat="server" Font-Italic="false" Font-Bold="true"  Text='<%#Eval("emp.Name")%>' />
                   </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location">
                <ItemTemplate>
                        <asp:Label ID="location" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval("emp.Location")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Designation">
                    <ItemTemplate>
                        <asp:Label ID="designation" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval("emp.Designation")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Experience">
                      <ItemTemplate>
                        <asp:Label ID="experience" runat="server" Font-Italic="false" Font-Bold="true" Text='<%#Eval("Vcancy.Experience ")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
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
    
    &nbsp;</div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="No Test Administrator available" Visible="False"></asp:Label>
        </p>
    </form>
</asp:Content>
