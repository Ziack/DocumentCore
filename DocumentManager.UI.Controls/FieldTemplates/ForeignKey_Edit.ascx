<%@ Control Language="C#" Inherits="DocumentManager.UI.Controls.FieldTemplates.ForeignKey_EditField" CodeBehind="ForeignKey_Edit.ascx.cs" AutoEventWireup="True" %>

<asp:DropDownList ID="DropDownList1" runat="server" CssClass="DDDropDown">
</asp:DropDownList>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" />

