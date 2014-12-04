<%@ Page Title="" Language="C#" MasterPageFile="~/TestAdmin.Master" AutoEventWireup="true" CodeBehind="Page_EditTestStatus.aspx.cs" Inherits="LAYERS.UI.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <form id="form1" runat="server">
    <fieldset>
    <legend>
   <h1>Edit Test Status</h1>
   </legend>
        <div style="background-color:lightgray">
        <asp:Label ID="vacancyName" runat="server"><b>Vacancy ID&nbsp:</b></asp:Label><asp:DropDownList ID="VacancyDL" runat="server" AutoPostBack="true" OnSelectedIndexChanged="getCandidateDetails" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">--select--</asp:ListItem>
            </asp:DropDownList>
        </div>
     <br />
     <br />
    <div>
        <asp:GridView ID="template" runat="server" Font-Bold="true" AutoGenerateColumns="False" Width="1200px" OnRowEditing="template_RowEditing" OnRowCancelingEdit="template_RowCancelingEdit" OnRowUpdated="template_RowUpdated" OnRowUpdating="template_RowUpdating" AllowPaging="True" OnPageIndexChanging="template_PageIndexChanging" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
            <Columns >
                <asp:TemplateField HeaderText="Candidate ID">
                <ItemTemplate>
                 <asp:Label ID="candidateId" runat="server" Text='<%# Eval("StatusObj.CandidateID")%>'></asp:Label>                
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Written Test Date (mm/dd/yyyy) ">
                <ItemTemplate>
                   <asp:Label ID="writtendate" runat="server"  Text ='<%#string.Format("{0:MM/dd/yyyy}",Eval("WrittenTestDate"))%>'></asp:Label>
                   <asp:Label ID="hwrittendate" runat="server" Text='<%#Eval("WrittenTestDate")%>' Visible="false"></asp:Label>                   
                </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Written Test Status ">
                <ItemTemplate>
              <%--<asp:DropDownList ID="writtenteststatusD" runat="server" Enabled="false">
                     <asp:ListItem Value="0">Pending</asp:ListItem>
                     <asp:ListItem Value="1">Approved</asp:ListItem>
                 </asp:DropDownList> --%>
                    <asp:Label ID="writtenteststatusDL" Font-Bold="true" runat="server" Text='<%# Convert.ToInt32(Eval("StatusObj.TestStatus"))>0?"Approved":"Pending" %>'> </asp:Label>
                </ItemTemplate>
                     <EditItemTemplate>
                        <asp:DropDownList ID="editwrittenteststatusDL" runat="server">
                        <asp:ListItem Value="0">Pending</asp:ListItem>
                        <asp:ListItem Value="1">Approved</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Technical Test Date (mm/dd/yyyy) ">
                <ItemTemplate>
                    <asp:Label ID="techdate" runat="server" Text='<%#string.Format("{0:MM/dd/yyyy}",Eval("TechnicalTestDate"))%>' ></asp:Label>
                    <asp:Label ID="htechdate" runat="server" Text='<%#Eval("TechnicalTestDate")%>' Visible="false"></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>              
                 <asp:TemplateField HeaderText="Technical Interview Status ">
                <ItemTemplate>
                <%-- <asp:DropDownList ID="techinterviewstatusD" runat="server" Enabled="false">
                     <asp:ListItem Value="1">Pending</asp:ListItem>
                     <asp:ListItem Value="2">Approved</asp:ListItem> 
                     </asp:DropDownList> --%>
                    <asp:Label ID="techinterviewstatusDL" Font-Bold="true" runat="server" Text='<%# Convert.ToInt32(Eval("StatusObj.TestStatus"))>1?"Approved":"Pending" %>'> </asp:Label>
                 
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="edittechinterviewstatusDL" runat="server">
                     <asp:ListItem Value="1">Pending</asp:ListItem>
                     <asp:ListItem Value="2">Approved</asp:ListItem>
                 </asp:DropDownList>
                </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HR Interview Date (mm/dd/yyyy) ">
                <ItemTemplate>
                    <asp:Label ID="hrdate" runat="server" Text='<%#string.Format("{0:MM/dd/yyyy}",Eval("HrInterviewDate"))%>'></asp:Label>
                     <asp:Label ID="hhrdate" runat="server" Text='<%#Eval("HrInterviewDate")%>' Visible="false"></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HR Interview Status ">
                <ItemTemplate>                  
                <%--<asp:DropDownList ID="hrinterviewstatusD" runat="server" Enabled="false">
                     <asp:ListItem Value="2">Pending</asp:ListItem>
                     <asp:ListItem Value="3">Approved</asp:ListItem>
                 </asp:DropDownList> --%>
                   <asp:Label ID="hrinterviewstatusDL" Font-Bold="true" runat="server" Text='<%# Convert.ToInt32(Eval("StatusObj.TestStatus"))>2?"Approved":"Pending" %>'> </asp:Label> 
                 
                </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="edithrinterviewstatusDL" runat="server">
                     <asp:ListItem Value="2">Pending</asp:ListItem>
                     <asp:ListItem Value="3">Approved</asp:ListItem>
                 </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>              
                <asp:CommandField HeaderText="ACTION" ShowEditButton="True" >
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
        </asp:GridView>
    </div>
        </fieldset>
        </form>
    </center>
</asp:Content>
