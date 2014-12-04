<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.Master" AutoEventWireup="true" CodeBehind="DisplayCandidate.aspx.cs" Inherits="LAYERS.UI.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
     <form id="form1" runat="server">
    <div>
    
        <br />

        <center>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Font-Underline="False" ForeColor="Black" Text="Display Candidate Profile"></asp:Label></center>
    
    </div>

        <center>
&nbsp;&nbsp;
<asp:Label ID="Label3" runat="server" Text="Vacancy Id" Font-Bold="True" ForeColor="Black"></asp:Label>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="28px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 0px" AutoPostBack="True" AppendDataBoundItems="True">
           <asp:ListItem Value="-1">select</asp:ListItem>
        </asp:DropDownList>
&nbsp;
       <div style="overflow:scroll;">
            
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-top: 41px" Width="323px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" Font-Bold="true">
            <RowStyle BackColor="White" />
             <Columns>
                 <asp:TemplateField HeaderText="Candidate ID">
                     <ItemTemplate>
                         <asp:Label ID="candidateId" runat="server" Text='<%# Bind("CandidateId") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Vacancy ID">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("VacancyId") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label3" runat="server" Text='<%# Bind("VacancyId") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Candidate Name">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("CandidateName") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server" Text='<%# Bind("CandidateName") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Date of Birth (mm/dd/yyyy)">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Dob") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%# Bind("Dob", "{0:dd-M-yyyy}") %>' Width="100" > </asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Location">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Loc") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label5" runat="server" Text='<%# Bind("Loc") %>'></asp:Label>
                     </ItemTemplate>
                 <ItemStyle Width="4000%" />
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Gender">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Gend") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label6" runat="server" Text='<%# Bind("Gend") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Marks in 10th(%)">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Per10") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label7" runat="server" Text='<%# Bind("Per10") %>'></asp:Label>
                     </ItemTemplate>
                     <ControlStyle Width="100px" />
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Marks in 12th(%)">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("per12") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label8" runat="server" Text='<%# Bind("Per12") %>'></asp:Label>
                     </ItemTemplate>
                     <ControlStyle Width="100px" />
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Gap in Education">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("GapInEdu") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label9" runat="server" Text='<%# Bind("GapInEdu") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Gap in Experience">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("GapInExp") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label10" runat="server" Text='<%# Bind("GapInExp") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Resume">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("Resume") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label11" runat="server" Text='<%# Bind("Resume") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
             <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
           </div>
    </form>
        </center>
</asp:Content>
