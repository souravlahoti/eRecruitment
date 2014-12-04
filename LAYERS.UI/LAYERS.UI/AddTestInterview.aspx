<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddTestInterview.aspx.cs" Inherits="LAYERS.UI.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
       <center>  
    <div>
       
        <h1>Schedule Test and Interview Date</h1>
        <br />
        
        <asp:Table runat="server" ID="table" Width="1596px">
        <asp:TableRow>
        <asp:TableCell>
        <asp:Label ID="Label2" runat="server" Text="Vacancy ID" Height="22px" Width="133px" style="margin-left: 280px"></asp:Label>
       </asp:TableCell>
            <asp:TableCell>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" style="margin-left: 120px" Width="133px"  AppendDataBoundItems="True" Height="22px">           
        <asp:ListItem>Select</asp:ListItem>
        </asp:DropDownList>
            
            </asp:TableCell>
            <asp:TableCell>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select Vacancy Id" ForeColor="Red" InitialValue="Select" ValidationGroup="i" style="margin-left: 15px" Height="25px" Width="125px"></asp:RequiredFieldValidator>
           
       </asp:TableCell>
        </asp:TableRow>
           <asp:TableRow>
               <asp:TableCell>
        <asp:Label ID="Label3" runat="server" Text="Test Administrator ID" Width="133px" Height="22px" style="margin-left:280px"></asp:Label>
                   </asp:TableCell>
               <asp:TableCell>
             
        <asp:Label ID="Label1" runat="server" Enabled="False" style="margin-left: 123px" Width="133px" Height="22px" ></asp:Label>
              </asp:TableCell>
        </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
        <asp:Label ID="Label4" runat="server" Text="WrittenTestDate" Width="133px" Height="22px" style="margin-left:280px"></asp:Label>
                   </asp:TableCell>
                 <asp:TableCell> 
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged" style="margin-left: 123px" TextMode="Date" Width="133px" Height="22px"></asp:TextBox>
        </asp:TableCell>
         <asp:TableCell>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Select Date" ForeColor="Red" ValidationGroup="i" style="margin-left: 15px" Height="25px" Width="77px"></asp:RequiredFieldValidator>
            </asp:TableCell>
          <asp:TableCell>   
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Date should start from today's date" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="i" style="margin-left: 0px" Height="25px" Width="190px"></asp:CustomValidator>
     </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
        <asp:Label ID="Label5" runat="server" Text="TechinterviewDate"  Width="133px" Height="22px" style="margin-left:280px"></asp:Label>
</asp:TableCell>
            <asp:TableCell>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 123px" Width="133px" Height="22px"></asp:TextBox>
         </asp:TableCell>
                <asp:TableCell>
       
        <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="Date should be within the 2 days of WrittenTestDate" OnServerValidate="CustomValidator4_ServerValidate" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="i" style="margin-left: 0px" Height="25px" Width="190px"></asp:CustomValidator>
            </asp:TableCell>
        </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
        <asp:Label ID="Label6" runat="server" Text="HRInterviewDate" Width="133px" Height="22px" style="margin-left:280px"></asp:Label>
              </asp:TableCell>
                <asp:TableCell>      
       
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 123px" Width="133px" Height="22px"></asp:TextBox>
               </asp:TableCell>
                <asp:TableCell>
        <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Date should not be more than required by date" OnServerValidate="CustomValidator3_ServerValidate1" ForeColor="Red" style="margin-left: 0px" Height="25px" Width="230px"></asp:CustomValidator>
               </asp:TableCell>
                <asp:TableCell>
        <asp:CustomValidator ID="CustomValidator5" runat="server" ControlToValidate="TextBox3" ErrorMessage="Date should be within the 2 days of TechnicalTestDate" ForeColor="Red" OnServerValidate="CustomValidator5_ServerValidate" ValidationGroup="i" style="margin-left:35px" Height="25px" Width="190px" ></asp:CustomValidator>
                </asp:TableCell>
                <asp:TableCell>
   
        <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage= "Enter Date less than 1 week of RequiredByDate" OnServerValidate="CustomValidator2_ServerValidate" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="i"></asp:CustomValidator>
                        </asp:TableCell>
       </asp:TableRow>
            <asp:TableRow>
                
                  <asp:TableCell>
        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click"  style="margin-left: 430px" Text="Submit" Width="85px" Height="22px" ValidationGroup="i" />
              </asp:TableCell>
               <asp:TableCell>
        <asp:Label ID="Label7" runat="server" Font-Bold="true" Font-Size="Large" Text="Details Successfully Updated" ></asp:Label>
                  </asp:TableCell>
          </asp:TableRow> 
                 
     </asp:Table>  
            </div>
           
   
            
       </center>
            
    </form>
</asp:Content>
