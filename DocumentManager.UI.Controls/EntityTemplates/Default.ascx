<%@ Control Language="C#" Inherits="DocumentManager.UI.Controls.EntityTemplates.DefaultEntityTemplate" %>

<asp:EntityTemplate runat="server" ID="EntityTemplate1">
	<ItemTemplate>
	   <div class="dnnFormItem grid-100">
			<div class="dnnLabel">
				<asp:Label ID="Label1" runat="server" OnInit="Label_Init" />
			</div>
			<asp:DynamicControl ID="DynamicControl1" runat="server" OnInit="DynamicControl_Init" Mode="ReadOnly" />
		</div>
	</ItemTemplate>
</asp:EntityTemplate>