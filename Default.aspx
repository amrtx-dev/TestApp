<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label runat="server" ID="lblCategory" Text="Category:"></asp:Label>

        <asp:DropDownList runat="server" ID="selCategory">
            <asp:ListItem Text="Category1" Value="1"></asp:ListItem>
            <asp:ListItem Text="Category2" Value="2"></asp:ListItem>
        </asp:DropDownList>

        <asp:Button runat="server" ID="btnSave" UseSubmitBehavior="false" 
            Text="Click Me!" onclick="btnSave_Click" />
    </div>



    <asp:ScriptManager runat="server" ID="ScriptManager1">
    </asp:ScriptManager>

    <h2>List of Stuff</h2>
    <hr />

    <asp:UpdatePanel runat="server" ID="UpdatePanel1">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSave" EventName="Click" />
        </Triggers>
        <ContentTemplate>
    
            <asp:ListBox runat="server" ID="lstStuff">
            </asp:ListBox>
    
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
