<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.Master" AutoEventWireup="true" CodeBehind="EditCandidateProfile_PC.aspx.cs" Inherits="LAYERS.UI.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function dob(i)
        {
            var temp = document.getElementById('TextBox2');
            var d = i.value;
            var dob = new Date(d);
            var dateNow = new Date();

            var years = dateNow.getFullYear() - dob.getFullYear();
            if (dob.getFullYear() >= dateNow.getFullYear()) {
                alert("Invalid Date");
                return false;
            }
            else if (years < 21) {
                alert("Age must be greater 21 years");
                return false;
            }
            return true;
        }

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <center>

             <div>
       <asp:Label ID="Label13" runat="server" Text="Edit Candidate Profile" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black" ></asp:Label> 
            </div>
            <div><table></table></div>
            <div><table></table></div>
            <div><table></table></div>
    <table>
        <tr><td><asp:Label ID="Label25" runat="server" Text="Vacancy Id" Font-Bold="True"></asp:Label></td>
            <td>&nbsp;&nbsp;&nbsp; : &nbsp;&nbsp;&nbsp;</td>
        <td><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
            <asp:ListItem>select</asp:ListItem>
        </asp:DropDownList></td>
           </tr>
        
    </table>
            <asp:Label ID="Label14" runat="server" Text="Please select a Vacancy ID to proceed" ForeColor="Red" Font-Bold="false" Font-Size="Larger"></asp:Label>
    <asp:Label ID="Label12" runat="server" Text="No Candidates available" Visible="false"  Font-Bold="false" Font-Size="Larger" ForeColor="Red" ></asp:Label> 
        <asp:GridView ID="GridView1" runat="server" Font-Bold="true" AutoGenerateColumns="False" Height="76px" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="4" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="2" AllowSorting="True" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellSpacing="2">
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <columns>
                <asp:TemplateField HeaderText="Candidate ID">
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("CandidateId") %>' Width="100"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label id="Label2" runat="server" text='<%#Eval("CandidateName")%>' Width="100"/>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("CandidateName")%>' TextMode="SingleLine" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFname" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Name" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REname" runat="server" ErrorMessage="Please enter alphabets only" ControlToValidate="TextBox1"  ValidationExpression="([a-zA-Z]{3,30}\s*)+" ValidationGroup="chand" ForeColor="Red">       
                        </asp:RegularExpressionValidator>  
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Date of Birth">
                    <ItemTemplate>
                        <asp:Label id="Label3" runat="server" text='<%#Eval("Dob","{0:MM/dd/yyyy}")%>' Width="100"/>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%#Eval("Dob","{0:MM/dd/yyyy}")%>' TextMode="Date" onchange="return dob(this);" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFdate" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Date of Birth" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Location">
                    <ItemTemplate>
                        <asp:Label id="Label4" runat="server" text='<%#Eval("Loc")%>' Width="100" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%#Eval("Loc")%>' TextMode="SingleLine" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFloc" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Enter Location" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                      </asp:TemplateField>

                    <asp:TemplateField HeaderText="Gender">
                    <ItemTemplate>
                        <asp:Label id="Label5" runat="server" text='<%#Eval("Gend")%>' Width="100"/>
                    </ItemTemplate>
                        <EditItemTemplate>
                           <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="false" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
                           <asp:ListItem>Male</asp:ListItem>
                           <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
                        
                        
                     <asp:RequiredFieldValidator ID="RFgen" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Please Select Gender" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                        </EditItemTemplate>

                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Percentage in 10th">
                    <ItemTemplate>
                        <asp:Label id="Label6" runat="server" text='<%#Eval("Per10")%>' Width="100"/>
                          
                    </ItemTemplate>
                        <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%#Eval("Per10")%>' onchange ="return percent10(this);"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RF10" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please Enter Percentage" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="re10" runat="server" ErrorMessage="Invalid entry" ForeColor="Red" ControlToValidate="TextBox5"  ValidationExpression="^[0-9]+$" Display="Dynamic">       
                        </asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="rv10" runat="server" 
    ErrorMessage="Minimum qualifying percentage is 60%" ControlToValidate="TextBox5" MaximumValue="100" MinimumValue="60" 
    Display="Dynamic" ClientIDMode="Predictable" Type="Double" ForeColor="red" />
                    </EditItemTemplate>

                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Percentage in 12th">
                    <ItemTemplate>
                        <asp:Label id="Label7" runat="server" text='<%#Eval("Per12")%>' Width="100"/>
                    </ItemTemplate>
                          <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%#Eval("Per12")%>' onchange ="return percent12(this);"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RF12" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please Enter Percentage" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RE12" runat="server" ErrorMessage="Invalid entry" ForeColor="Red" ControlToValidate="TextBox6" ValidationExpression="^[0-9]+$" Display="Dynamic">      
                              </asp:RegularExpressionValidator>  
                               <asp:RangeValidator ID="rv12" runat="server" 
    ErrorMessage="Minimum qualifying percentage is 65%" ControlToValidate="TextBox6" MaximumValue="100" MinimumValue="65" 
    Display="Dynamic" ClientIDMode="Predictable" Type="Double" ForeColor="red" />
                    </EditItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gap in Education">
                    <ItemTemplate>
                        <asp:Label id="Label8" runat="server" text='<%#Eval("GapInEdu")%>' Width="100"/>
                    </ItemTemplate>
                          <EditItemTemplate>
                             <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" ValidationGroup="chan" AppendDataBoundItems="true" >
                                 <asp:ListItem Text="--select--" />
                                 <asp:ListItem Text="Yes" />
                                 <asp:ListItem Text="No" />
                             </asp:DropDownList>
                              <asp:TextBox ID="TextBox7" runat="server" Text='<%#Eval("GapInEdu")%>'></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RFedu" runat="server" ControlToValidate="TextBox7" ErrorMessage="This field is Mandatory" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                 </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gap in Experience">
                    <ItemTemplate> 
                        <asp:Label id="Label9" runat="server" text='<%#Eval("GapInExp")%>' Width="100"/>
                    </ItemTemplate>
                          <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" ValidationGroup="chan" AppendDataBoundItems="true" >
                                <asp:ListItem Text="--select--" />
                                 <asp:ListItem Text="Yes" />
                                 <asp:ListItem Text="No" />
                            </asp:DropDownList>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%#Eval("GapInExp")%>'></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RFexp" runat="server" ControlToValidate="TextBox8" ErrorMessage="This field is Mandatory" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                </asp:TemplateField>

                 
                    <asp:TemplateField HeaderText="Resume">
                    <ItemTemplate>
                        <asp:label id="Label10" runat="server" text='<%#Eval("Resume")%>' />
                    </ItemTemplate>
                        
                         <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%#Eval("Resume")%>' onchange="resume(this);" ></asp:TextBox>
                             
                        <asp:FileUpload id="Button1" runat="server" Text="Browse"/>
                             <asp:RequiredFieldValidator ID="RFres" runat="server" ControlToValidate="Button1" ErrorMessage="Please choose a file" ValidationGroup="chan" ForeColor="Red" >
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                </asp:TemplateField>
              
                <asp:CommandField HeaderText="Edit/Update" ShowEditButton="True" ValidationGroup="chan" ControlStyle-ForeColor="#ff3300">
              
<ControlStyle ForeColor="#FF3300"></ControlStyle>
                </asp:CommandField>
              
            </columns>
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
            <asp:Label ID="Label1" runat="server" Text="Details Successfully Updated" Font-Bold="True" Font-Size="Large" ForeColor="Blue" Visible="False"></asp:Label>
            </center>
        </div>
                </form>
</asp:Content>
   