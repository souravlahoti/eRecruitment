<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="DisplayCandidate_HR.aspx.cs" Inherits="LAYERS.UI.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
        <center>
    <div>
     <center>
             <div>
       <asp:Label ID="Label13" runat="server" Text="Candidate Profiles" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black" ></asp:Label> 
            </div>
          <div><table></table></div>
            <div><table></table></div>
            <div><table></table></div>
        <asp:Label ID="Label1" runat="server" Text="Vacancy Id"> </asp:Label>&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;
       
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>select</asp:ListItem>
        </asp:DropDownList>
         <div>
<asp:Label ID="Label12" runat="server" Text="Please select a Vacancy ID to proceed" Font-Size="Larger" ForeColor="Red"></asp:Label>
             <br />
    <asp:Label ID="Label11" runat="server" Text="No candidates available" Visible="False"  Font-Bold="False" Font-Size="X-Large" ForeColor="Red" ></asp:Label>
    </div>
         <div style="overflow:scroll;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" CellSpacing="2" AllowPaging="True" HorizontalAlign="Center" PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging" Font-Bold="true">
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <Columns>
                <asp:TemplateField HeaderText="Candidate ID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" text='<%#Eval("CandidateId")%>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label id="Label2" runat="server" text='<%#Eval("CandidateName")%>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("CandidateName")%>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Date of Birth">
                    <ItemTemplate>
                        <asp:Label id="Label3" runat="server" text='<%#Eval("Dob","{0:MM/dd/yyyy}")%>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%#Eval("Dob","{0:MM/dd/yyyy}")%>' TextMode="Date" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Location">
                    <ItemTemplate>
                        <asp:Label id="Label4" runat="server" text='<%#Eval("Loc")%>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%#Eval("Loc")%>'></asp:TextBox>
                    </EditItemTemplate>
                      </asp:TemplateField>

                    <asp:TemplateField HeaderText="Gender">
                    <ItemTemplate>
                        <asp:Label id="Label5" runat="server" text='<%#Eval("Gend")%>' />
                    </ItemTemplate>
                        <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%#Eval("Gend")%>'></asp:TextBox>
                    </EditItemTemplate>

                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Percentage in 10th">
                    <ItemTemplate>
                        <asp:Label id="Label6" runat="server" text='<%#Eval("Per10")%>' />
                    </ItemTemplate>
                        <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%#Eval("Per10")%>'></asp:TextBox>
                    </EditItemTemplate>

                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Percentage in 12th">
                    <ItemTemplate>
                        <asp:Label id="Label7" runat="server" text='<%#Eval("Per12")%>'/>
                    </ItemTemplate>
                          <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%#Eval("Per12")%>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gap in Education">
                    <ItemTemplate>
                        <asp:Label id="Label8" runat="server" text='<%#Eval("GapInEdu")%>'/>
                    </ItemTemplate>
                          <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%#Eval("GapInEdu")%>'></asp:TextBox>
                    </EditItemTemplate>
                 </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gap in Experience">
                    <ItemTemplate>
                        <asp:Label id="Label9" runat="server" text='<%#Eval("GapInExp")%>'/>
                    </ItemTemplate>
                          <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%#Eval("GapInExp")%>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                 
                    <asp:TemplateField HeaderText="Resume">
                    <ItemTemplate>
                        <asp:label id="Label10" runat="server" text='<%#Eval("Resume")%>' />
                    </ItemTemplate>
                         <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%#Eval("Resume")%>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
              
                <asp:TemplateField HeaderText="Test Schedule ID" ItemStyle-Width="200" >
                    <ItemTemplate>
                        <asp:Label id="Label10" runat="server" text='<%#Eval("scheduleobj.TestScheduleId")%>'/>
                    </ItemTemplate>

<ItemStyle Width="200px"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Status" ItemStyle-Width="200" >
                    <ItemTemplate>
                   <asp:Label id="Label10" runat="server" text='<%#Enum.GetName(typeof(LAYERS.UI.WebForm11.Category),Convert.ToInt32(Eval("scheduleobj.statusobj.TestStatus")))%>'/>
                    </ItemTemplate>

<ItemStyle Width="200px"></ItemStyle>
                </asp:TemplateField>
              
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" VerticalAlign="Middle" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
             </div>
        </div>
            </center>
    </form>
</asp:Content>
