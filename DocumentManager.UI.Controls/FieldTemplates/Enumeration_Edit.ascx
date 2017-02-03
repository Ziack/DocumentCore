<%@ Control Language="C#" CodeBehind="Enumeration_Edit.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.Enumeration_EditField" AutoEventWireup="True" %>

<asp:DropDownList ID="DropDownList1" runat="server" CssClass="DDDropDown" />
<div class="dnnClear"></div>
<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" />

