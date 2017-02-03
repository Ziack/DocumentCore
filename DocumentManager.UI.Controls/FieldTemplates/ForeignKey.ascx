<%@ Control Language="C#" Inherits="DocumentManager.UI.Controls.FieldTemplates.ForeignKeyField" CodeBehind="ForeignKey.ascx.cs" AutoEventWireup="True" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

