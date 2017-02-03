<%@ Control Language="C#" CodeBehind="ShortText_Edit.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.ShortText_Edit" AutoEventWireup="True" %>
<%@ Register Assembly="Bootstrap.Web.Controls" Namespace="Bootstrap.Web.Controls" TagPrefix="btc" %>

<asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="None" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="None" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="None" />

