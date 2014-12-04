<%@ Page Title="" Language="C#" MasterPageFile="~/TestAdmin.Master" AutoEventWireup="true" CodeBehind="DisplayScheduleTestAdmin.aspx.cs" Inherits="LAYERS.UI.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <form ID="ID" runat="server">
         <div>
               <asp:Label ID="Label1" runat="server" Text="Vacancy Id" Font-Bold="true" Font-Size="Large"  BorderStyle="NotSet" ></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

               
               <br />
             <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
                 <asp:TableRow>
                      <asp:TableCell>  </asp:TableCell>
                     <asp:TableCell>
               <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="No Data Available" Visible="False"></asp:Label>
               </asp:TableCell>
            </asp:TableRow>
                 <asp:TableRow>
                     <asp:TableCell></asp:TableCell>
                     </asp:TableRow>
               <asp:TableRow HorizontalAlign="Justify">
                   
                   <asp:TableCell>
               <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                       </asp:TableCell>
              
                  <asp:TableCell>  </asp:TableCell>
                   <asp:TableCell>               
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Refresh" />
                       </asp:TableCell>

              
                  </asp:TableRow>
               </asp:Table>
               <br />
               <br />
              
        </div>
    <div>
        <asp:GridView ID="GridViewItems" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" AllowPaging="True" OnPageIndexChanging="GridViewItems_PageIndexChanging" PageSize="5" Font-Bold="true">
           <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
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
           </form>
        </center>
 
    </div>
</asp:Content>
