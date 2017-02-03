<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PackingList_Insert.ascx.cs" Inherits="DocumentManager.UI.Controls.EntityTemplates.PackingList_Insert" %>

<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>

<asp:EntityTemplate runat="server" ID="EntityTemplate1">
    <ItemTemplate>
       <div class="grid-100 dnnFormItem">
            <div class="dnnLabel">
				<asp:Label ID="Label1" runat="server" OnInit="Label_Init" OnPreRender="Label_PreRender" />
			</div>
            <asp:DynamicControl runat="server" ID="DynamicControl" Mode="Insert" OnInit="DynamicControl_Init" />
        </div>
    </ItemTemplate>
</asp:EntityTemplate>