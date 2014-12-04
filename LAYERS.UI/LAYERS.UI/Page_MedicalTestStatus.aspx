<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="Page_MedicalTestStatus.aspx.cs" Inherits="LAYERS.UI.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
         <form id="form1" runat="server">
     <fieldset>
        <legend><h1>Edit Medical Test Status</h1></legend>
  
        <div style="background-color:lightgray">
        <asp:Label ID="vacancyName" runat="server">Vacancy ID:  </asp:Label><asp:DropDownList ID="VacancyDL" runat="server" AutoPostBack="true" OnSelectedIndexChanged="getCandidateDetails" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">Select</asp:ListItem>
            </asp:DropDownList>
        </div>
     <br />
     <br />
    <div>
        <asp:GridView ID="template" runat="server" Font-Bold="true" AutoGenerateColumns="False" Width="1200px" OnRowCancelingEdit="template_RowCancelingEdit" OnRowEditing="template_RowEditing" OnRowUpdating="template_RowUpdating" CellPadding="4" ForeColor="Black" AllowPaging="True" OnPageIndexChanging="template_PageIndexChanging" PageIndex="10" BorderColor="#999999" BackColor="#CCCCCC" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" OnRowDataBound="template_RowDataBound">
            <Columns >
                <asp:TemplateField HeaderText="Candidate ID">
                <ItemTemplate>
                 <asp:Label ID="candidateid" runat="server" Text='<%# Eval("StatusObj.CandidateId")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Medical Test Status ">
                    <ItemTemplate>
                        <asp:Label ID="medicalteststatus" runat="server" Text='<%#Enum.GetName(typeof(LAYERS.UI.WebForm2.Category),Convert.ToInt32(Eval("StatusObj.MedicalTestStatus")))%>'></asp:Label>
                    </ItemTemplate>
                <EditItemTemplate>
                 <asp:DropDownList ID="medicalteststatusDL" runat="server">
                    <%-- <asp:ListItem Value="0" Selected="True">Pending</asp:ListItem> --%>
                     <asp:ListItem Value="1">Approved</asp:ListItem>
                      <asp:ListItem Value="2">Rejected</asp:ListItem>
                 </asp:DropDownList>
                </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Upload">
                    <ItemTemplate>
                        <asp:Label ID="File" runat="server" Text='<%#Eval("StatusObj.Certificate")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:FileUpload ID="FileUpload1" runat="server" Enabled="true" />                       
                    </EditItemTemplate>
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Remarks">
                    <ItemTemplate>
                        <asp:Label ID="remarks" runat="server" Text='<%#Eval("StatusObj.Remarks") %>'></asp:Label>
                    </ItemTemplate>
                <EditItemTemplate>
                <asp:TextBox ID="remarks" TextMode="MultiLine" runat="server"></asp:TextBox>
                </EditItemTemplate>
                </asp:TemplateField>            
                <asp:CommandField HeaderText="ACTION" ShowEditButton="True" >
                <ControlStyle ForeColor="Red" />
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
