<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.Master" AutoEventWireup="true" CodeBehind="CreateCandidate.aspx.cs" Inherits="LAYERS.UI.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            width: 359px;
        }
        .auto-style3 {
            height: 29px;
            width: 359px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style5 {
            width: 359px;
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
     <form id="id" runat="server">
           <center>
           <table border="0" style="width:74%; padding:1px;word-spacing:1px; text-align:left;" >
               <tr>
                   <td colspan="2">
                     <center><asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="X-Large"
                         Text="Add Candidate Profile"></asp:Label></center>    
                   </td>
               </tr>
               <tr>
                   <td style="text-align:right">
                       <asp:Label ID="Label1" runat="server" Text="Vacancy Id" Font-Bold="True"></asp:Label>                       
                   </td>
                   <td  style="text-align:left" class="auto-style2" >                     
                           <asp:DropDownList ID="DropDownList1"  AutoPostBack="true" runat="server"   OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="22px">
     </asp:DropDownList></td>
                 </tr>
               <tr>
                   <td style="text-align:right" aria-required="true"><asp:Label ID="Label2" runat="server" Text="CandidateName" Font-Bold="True"></asp:Label>
                   </td> 
                   <td style="text-align:left; margin-left: 40px;" class="auto-style2">
                       <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style=" margin-bottom: 0px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter name" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                       </td>
                   </tr>
               <tr>
                   <td style="text-align:right" class="auto-style1"> <asp:Label ID="Label3" runat="server" Text="Date of Birth" Font-Bold="True"></asp:Label></td>
                   <td style="text-align:left" class="auto-style3"> <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Date"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter date of birth" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
                  </tr>
              <tr><td></td><td style="text-align:left" class="auto-style2"><asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter valid age" OnServerValidate="CustomValidator1_ServerValidate" Font-Bold="True" ForeColor="Red"></asp:CustomValidator>
                   </td></tr>
               <tr><td style="text-align:right" > <asp:Label ID="Label4" runat="server" Text="Location" Font-Bold="True"></asp:Label></td>
                   <td style="text-align:left" class="auto-style2" ><asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter location" ValidationGroup="i" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator></td>
               <td> &nbsp;</td>
                </tr>
               <tr><td style="text-align:right" class="auto-style1"><asp:Label ID="Label11" runat="server" Text="Gender" Font-Bold="True"></asp:Label>
                                      </td>
                   <td style="text-align:left" class="auto-style2">
                       <asp:RadioButton ID="RadioButton2" runat="server" Text="Male" GroupName="gender" Checked="True" />
    <asp:RadioButton ID="RadioButton3" runat="server" Text="Female" GroupName="gender" />  
                   </td></tr>
               <tr><td style="text-align:right"><asp:Label ID="Label6" runat="server" Text="Percentage10" Font-Bold="True"></asp:Label> </td>
                   <td style="text-align:left; font-weight: 700;" class="auto-style2">
                           <asp:TextBox ID="TextBox5" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" width="125px"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please enter your percentage" ValidationGroup="i" ForeColor="Red"></asp:RequiredFieldValidator>
                      
                                     
                   </td></tr>
               <tr><td style="text-align:right"></td>
                   <td style="text-align:left; font-weight: 700;" class="auto-style2">
                                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Percentage should  between 60 and 99" MaximumValue="99" MinimumValue="60" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RangeValidator>

                                       
                   </tr>
               <tr><td style="text-align:right"> <asp:Label ID="Label7" runat="server" Text="Percentage12" Font-Bold="True"></asp:Label></td>
                   <td style="text-align:left" class="auto-style2"><asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox1_TextChanged" Width="131px"></asp:TextBox>  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please enter  your percentage" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
               <tr><td style="text-align:right"></td>
                   <td style="text-align:left" class="auto-style2">  <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="Percentage should  between 65 and 99" MaximumValue="99" MinimumValue="65" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RangeValidator></td></tr>
               <tr><td style="text-align:right" class="auto-style4"> <asp:Label ID="Label12" runat="server" Text="GapInEducation" Font-Bold="True"></asp:Label> </td>
                   <td style="text-align:left" class="auto-style5"><asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="True">       
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem></asp:ListItem> 
                        </asp:DropDownList> <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList4" ErrorMessage="Please select GapIn Education" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator> </td></tr>
               <tr><td style="text-align:right"></td>
                   <td style="text-align:left" class="auto-style2">
                       <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox1_TextChanged" Visible="False" Width="118px"></asp:TextBox>
                        </td></tr>
               <tr><td style="text-align:right"><asp:Label ID="Label9" runat="server" Text="GapInExperience" Font-Bold="True"></asp:Label></td>
                   <td style="text-align:left" class="auto-style2"><asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Please select GapInExperience" ValidationGroup="i" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
               <tr><td style="text-align:right">

                   </td><td style="text-align:left" class="auto-style2">
                       <asp:TextBox ID="TextBox8" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 0px; margin-bottom: 0px" Visible="False"></asp:TextBox>  </td></tr>
               <tr><td style="text-align:right"><asp:Label ID="Label10" runat="server" Text="Resume" Font-Bold="True"></asp:Label> </td><td style="text-align:left" class="auto-style2"><asp:FileUpload ID="FileUpload1" runat="server" /></td></tr>
               <tr><td style="text-align:right"></td>
                   <td style="text-align:left" class="auto-style2"><asp:Label ID="LabelMessage" runat="server" Visible="False" Font-Bold="True" ForeColor="#0033CC" Font-Size="Small"></asp:Label></td></tr>
                                                  
               <tr><td style="text-align:right"></td><td style="text-align:left" class="auto-style2">                  
                       <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" ValidationGroup="i" />                          
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" OnClick="Button2_Click" Text="Cancel" Visible="False" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Complete" Visible="False" />
                   </td></tr>
                </table>
                </center>   
           </form>  
    
</asp:Content>
