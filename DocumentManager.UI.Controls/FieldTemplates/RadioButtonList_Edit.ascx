<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonList_Edit.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.Mobile.DynamicData.FieldTemplates.RadioButtonList_Edit" ViewStateMode="Enabled" %>


<div class="dnnForm">
    <div class="dnnFormItem grid-100">
        <asp:XmlDataSource ID="xmlDataSource" runat="server"></asp:XmlDataSource>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataValueField="Value" DataTextField="Text"  OnDataBound="RadioButtonList1_DataBound" />
    </div>
</div>
<div class="dnnClear"></div>
<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="RadioButtonList1" Display="None" Enabled="false"  />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="RadioButtonList1" Display="Static" />

