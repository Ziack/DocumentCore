<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RichText_Insert.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.RichText_Insert" %>

<script src="<%= this.ResolveClientUrl( "~/Include/Scripts/jquery.facture.js")%>" type="text/javascript"></script>

<asp:TextBox ID="TextBox1" runat="server" Text='<%# FieldValueEditString %>' CssClass="DDTextBox" TextMode="MultiLine" onKeyUp="javascript:facture.ValidateMaxLength(this, 255);"></asp:TextBox>

