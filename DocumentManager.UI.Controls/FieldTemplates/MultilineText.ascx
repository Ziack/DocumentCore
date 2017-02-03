<%@ Control Language="C#" Inherits="DocumentManager.UI.Controls.FieldTemplates.MultilineText" CodeBehind="MultilineText.ascx.cs" AutoEventWireup="True" %>

<asp:TextBox ID="TextBox1" runat="server" CssClass="DDControl" TextMode="MultiLine" Text='<%# FieldValueString %>' Rows="5" Enabled="false" />
