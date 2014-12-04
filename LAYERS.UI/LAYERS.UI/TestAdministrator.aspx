<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="TestAdministrator.aspx.cs" Inherits="LAYERS.UI.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
         <form id="form1" runat="server">
          <fieldset>
              <legend><h1>Test Administrator</h1></legend>
<br />
             <asp:Table ID="Table1" runat="server"> 
        <asp:TableRow>       
        <asp:TableCell>  <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Select VacancyId:"></asp:Label></asp:TableCell>
        <asp:TableCell> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ValidationGroup="i"></asp:DropDownList></asp:TableCell>
        <asp:TableCell> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select VacancyId" Font-Bold="False" ForeColor="Red" ValidationGroup="i" InitialValue="Select"></asp:RequiredFieldValidator>  </asp:TableCell>
        </asp:TableRow>

       <asp:TableRow>
       <asp:TableCell> <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="SkillSet:"></asp:Label></asp:TableCell>
       <asp:TableCell> <asp:TextBox ID="TextBox1" runat="server" Width="62px"  ReadOnly="True"></asp:TextBox></asp:TableCell> 
       </asp:TableRow>
          
       <asp:TableRow>
       <asp:TableCell> <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Select Employee:"></asp:Label> </asp:TableCell>
       </asp:TableRow>

       <asp:TableRow>  
       <asp:TableCell><asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Text="Employee with SkillSet is not available" ValidationGroup="i" Visible="False"></asp:Label></asp:TableCell>
       </asp:TableRow>
           
       <asp:TableRow>
       <asp:TableCell><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:TemplateField HeaderText="EmployeeId">
                     <ItemTemplate>
                        <asp:Label ID="id" runat="server" Text='<%#Eval("EmployeeId")%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                     <ItemTemplate>
                        <asp:Label ID="id" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="SkillSet">
                    <ItemTemplate>
                        <asp:Label ID="id" runat="server" Text='<%#Eval("SkillSet") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Experience">
                     <ItemTemplate>
                        <asp:Label ID="id" runat="server" Text='<%#Eval("Experience") %>' />
                    </ItemTemplate>

                </asp:TemplateField>
                <asp:CommandField HeaderText="Select" ShowSelectButton="True" />
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
        </asp:GridView>
        </asp:TableCell></asp:TableRow>
            
        <asp:TableRow>
        <asp:TableCell> <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Selected EmployeeId"></asp:Label> </asp:TableCell>
        <asp:TableCell> <asp:TextBox ID="TextBox2" runat="server" Width="62px"  ReadOnly="True"></asp:TextBox></asp:TableCell>
        <asp:TableCell>   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Select an Employee" Font-Bold="False" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator></asp:TableCell> 
       </asp:TableRow>
             
       <asp:TableRow>
       <asp:TableCell>  <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Submit" OnClick="Button1_Click" ValidationGroup="i" /> </asp:TableCell>  
       <asp:TableCell>  <asp:Button ID="Button2" runat="server" style="margin-top: 0px" Text="Refresh" Font-Bold="True" OnClick="Button2_Click" /></asp:TableCell>  
       <asp:TableCell>   <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#3366FF" Text="Test administrator created" Visible="False"></asp:Label></asp:TableCell>  
       </asp:TableRow>
       </asp:Table>
              </fieldset> 
             </form>
        </center>
           
       
</asp:Content>
