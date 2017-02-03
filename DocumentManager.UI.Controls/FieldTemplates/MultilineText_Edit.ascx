<%@ Control Language="C#" CodeBehind="MultilineText_Edit.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.MultilineText_EditField" AutoEventWireup="True" %>
<%@ Register Assembly="Bootstrap.Web.Controls" Namespace="Bootstrap.Web.Controls" TagPrefix="btc" %>

<asp:TextBox ID="TextBox1" runat="server" CssClass="DDControl" TextMode="MultiLine" Text='<%# FieldValueEditString %>' Rows="5"></asp:TextBox>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="None" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="None" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="None" />

