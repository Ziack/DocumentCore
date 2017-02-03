# DocumentCore

```json

protected void Page_Load(object sender, EventArgs e)
{
  var form = DocumentManager.Core.DocumentController.LoadFromAssembly(string.Format("{0}.{1}", contentType, "xml"));
  MetaTable formTable;
  var metaModel = new DynamicMetaModel(XmlSerializerHelper.Serialize(form));
  
  metaModel.RegisterContext();
  metaModel.TryGetTable(form.Name, out formTable);
  FormViewControls.SetMetaTable(formTable);
}    

/// <summary>
/// El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
/// o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
/// </summary>
/// <param name="id">Id del tipo de la autorizacio</param>
/// <returns>Object</returns>
public object FormViewControls_GetItem(int? id)
{
  var xmlData = SomeMethodToGetPreviousSavedXML();
  dynamic initialData = xmlData.ToDynamic();

  return new DynamicTypeDescriptor(initialData);

}

/// <summary>
/// Meotodo que ejecuta el Send (Workflow)
/// </summary>
/// <param name="sender">Objeto que genera el evento</param>
/// <param name="e">Evento generado</param>
protected void FormViewControls_ItemUpdating(object sender, FormViewUpdateEventArgs e)
{
  if (!Page.IsValid)
    return;

  var document = e.NewValues.OfType<DictionaryEntry>().ParseDocument(this.Model.ContentType);
  
  //Do something cool with document

}

public void FormViewControls_UpdateItem(String id)
{
  // Intencionally left blank. FormView need it.
}


 ```
 
 ```asp
 
 <asp:FormView ID="FormViewControls" runat="server" Width="100%" DefaultMode="Edit"
    OnItemUpdating="FormViewControls_ItemUpdating" SelectMethod="FormViewControls_GetItem" UpdateMethod="FormViewControls_UpdateItem" >
    <EditItemTemplate>        
        <asp:DynamicEntity ID="DynamicEntity1" runat="server" Mode="Edit" />
    </EditItemTemplate>    
    <FooterTemplate>
        <ul>
            <li><asp:LinkButton ID="SaveButton" runat="server" Text="Save" CommandName="Update"  /></li>
            <li><asp:HyperLink id="CancelLink" runat="server" Text="Cancel" CausesValidation="false" /></li>
        </ul>        
    </FooterTemplate>
</asp:FormView>

 ```
