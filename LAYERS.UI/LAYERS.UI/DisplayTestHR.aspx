<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="DisplayTestHR.aspx.cs" Inherits="LAYERS.UI.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form ID="ID" runat="server">
     <center>
     <div>
        
               <asp:Label ID="Label1" runat="server" Text="Vacancy Id" Font-Bold="true" Font-Size="Large"  BorderStyle="NotSet" ></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" Font-Bold="true" BackColor="Silver" style="height: 22px">
            <asp:ListItem>Select</asp:ListItem>
        </asp:DropDownList>
               <br />
               <br />
               <br />
        </div>
    <div style="overflow:scroll;">
        <asp:GridView ID="GridViewItems" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" AllowPaging="True" OnPageIndexChanging="GridViewItems_PageIndexChanging" PageSize="5">
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <Columns>
                <asp:TemplateField HeaderText="Candidate ID" >
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Eval("StatusObj.CandidateId")%>' />
                    </ItemTemplate>

                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Written Test Date">
                    <ItemTemplate>
                        <asp:Label ID="Label" runat="server" Font-Bold="true" Text='<%#Eval("WrittenTestDate","{0:dd/MM/yyyy}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Written Test Status">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Convert.ToInt32(Eval("StatusObj.TestStatus"))>0?"Approved":"Pending"%>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Technical Interview Date">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Eval("TechnicalTestDate","{0:dd/MM/yyyy}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Technical Interview Status">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Convert.ToInt32(Eval("StatusObj.TestStatus"))>1?"Approved":"Pending"%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="HR Interview Date">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Eval("HrInterviewDate","{0:dd/MM/yyyy}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HR Interview Status">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Convert.ToInt32(Eval("StatusObj.TestStatus"))>2?"Approved":"Pending"%>' />
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
        </asp:GridView>
       
    </div>
          </center>
        </form>

</asp:Content>
