<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DisplayTS.aspx.cs" Inherits="LAYERS.UI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div>
               <asp:Label ID="Label1" runat="server" Text="Vacancy Id" Font-Bold="true" Font-Size="Large"  BorderStyle="NotSet" ></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" Font-Bold="true" BackColor="Silver" style="height: 22px">
            <asp:ListItem>Select</asp:ListItem>
        </asp:DropDownList>
               <br />
               <br />
               <br />
        </div>
    <div>
        <asp:GridView ID="GridViewItems" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Candidate ID" >
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Eval("StatusObj.CandidateId")%>' />
                    </ItemTemplate>

<%--<HeaderStyle ForeColor="YellowGreen"></HeaderStyle>--%>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Written Test Date">
                    <ItemTemplate>
                        <asp:Label ID="Label" runat="server" Font-Bold="true" Text='<%#Eval("WrittenTestDate","{0:dd/MM/yyyy}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Written Test Status">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Convert.ToInt32(Eval("StatusObj.TestStatus"))>0?"Accepted":"Pending"%>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Technical Interview Date">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Eval("TechnicalTestDate","{0:dd/MM/yyyy}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Technical Interview Status">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Convert.ToInt32(Eval("StatusObj.TestStatus"))>1?"Accepted":"Pending"%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="HR Interview Date">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Eval("HrInterviewDate","{0:dd/MM/yyyy}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HR Interview Status">
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server"  Font-Bold="true" Text='<%#Convert.ToInt32(Eval("StatusObj.TestStatus"))>2?"Accepted":"Pending"%>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>

</asp:Content>


