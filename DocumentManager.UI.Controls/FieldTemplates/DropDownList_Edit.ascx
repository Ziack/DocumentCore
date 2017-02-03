<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DropDownList_Edit.ascx.cs" Inherits="DocumentManager.UI.Controls.FieldTemplates.DropDownList_Edit" ViewStateMode="Enabled"%>


<div data-role="content">
    <div class="ui-grid-a">
        <div class="ui-block-a">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="DDDropDown" DataSource="<%# this.DataSource %>" DataValueField="<%# this.DataValueField %>" DataTextField="<%# this.DataTextField %>"/>
        </div>
    </div>
</div>
<div class="dnnClear"></div>
<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" />

