<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RichText_Edit.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.RichText_Edit" %>
<script src="<%= this.ResolveClientUrl( "~/Include/Scripts/jquery.facture.js")%>" type="text/javascript"></script>

<asp:TextBox ID="TextBox1" runat="server" Text='<%# FieldValueEditString %>' CssClass="DDTextBox" TextMode="MultiLine" onKeyUp="javascript:facture.ValidateMaxLength(this, 255);"></asp:TextBox>

