# DocumentCore

```xml

<?xml version="1.0" encoding="utf-8" ?>
<ContentType name="OrdenesServicio" type="PuertoBahia.Documents.OrdenesServicio.OrdenesServicio" parentType="DocumentManager.Core.Base.Content" xmlns="http://schemas.facturecolombia.com/ContentRepository/ContentTypeDefinition">
  <DisplayName>OrdenesServicio</DisplayName>
  <Description></Description>
  <Fields>
    <Field name="WorkOrderId" type="Hidden">
      <DisplayName>Id Orden Servicio</DisplayName>
      <Description>Id Orden Servicio</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>        
      </Configuration>
    </Field>
    <Field name="WorkOrderStatus" type="Hidden">
      <DisplayName>Estado Orden Servicio</DisplayName>
      <Description>Estado Orden Servicio</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>        
      </Configuration>
    </Field>     
    <Field name="WorkOrderType" type="Request">
      <DisplayName>Orden de Servicio</DisplayName>
      <Description>Orden de Servicio</Description>
      <Configuration>
        <Required>true</Required>
        <Parameters>
          <Parameter>
            <Key>Request</Key>
            <Value>WorkOrderType</Value>
          </Parameter>
        </Parameters>
      </Configuration>
    </Field>    
    <Field name="CargoDocument" type="DocumentoCargaEmitidos">
      <DisplayName>recalada/BL</DisplayName>
      <Description>recalada/BL</Description>
      <Configuration>
        <Required>true</Required>
        <F4XmlConfiguration>~/Include/F4Config/F4NumeroBL.xml</F4XmlConfiguration>
      </Configuration>
    </Field>
    <Field name="AgenciaAduanas" type="AgenciaDeAduanaByDocumentoCarga">
      <DisplayName>Agencia de aduanas</DisplayName>
      <Description>Agencia de aduanas</Description>
      <Configuration>
        <F4XmlConfiguration>~/Include/F4Config/F4AgenciasByConsignatario.xml</F4XmlConfiguration>
        <Parameters>
          <Parameter>
            <Key>iVch_Acciones</Key>
            <Value>GOSR</Value>
          </Parameter>
        </Parameters>
        <Required>false</Required>
      </Configuration>
    </Field>
    <Field name="Solicitante" type="FuncionariosByAgenciaDocumentoCarga">
      <DisplayName>solicitante</DisplayName>
      <Description>solicitante</Description>
      <Configuration>
        <F4XmlConfiguration>~/Include/F4Config/F4FuncionariosByAgenciaDocumentoCarga.xml</F4XmlConfiguration>        
        <Required>true</Required>
      </Configuration>
    </Field>
    <Field name="PortOperator" type="F4Terceros">
      <DisplayName>Operador Porturario</DisplayName>
      <Description>Operador Porturario</Description>
      <Configuration>
        <Required>true</Required>
        <F4XmlConfiguration>~/Include/F4Config/F4Terceros3.xml</F4XmlConfiguration>
        <Parameters>
          <Parameter>
            <Key>iVch_TipoTercero</Key>
            <Value>OP</Value>
          </Parameter>
        </Parameters>
      </Configuration>
    </Field>
    <Field name="Comments" type="RichText">
      <DisplayName>Observaciones</DisplayName>
      <Description>Observaciones</Description>
      <Configuration>
        <Required>false</Required>
      </Configuration>
    </Field>
    <Field name="HumanResources" type="HR">
      <DisplayName>Human Resources</DisplayName>
      <Description>Human Resources</Description>
      <Configuration>
        <Required>false</Required>
      </Configuration>
    </Field>
    <Field name="StockItem" type="WorkOrderItem">
      <DisplayName>Items</DisplayName>
      <Description>items</Description>
      <Configuration>
        <Required>true</Required>
        <F4XmlConfiguration>~/Include/F4Config/F4Blsconsignatario.xml</F4XmlConfiguration>        
      </Configuration>
    </Field>
    <Field name="CreationDate" type="Hidden">
      <DisplayName>Creation Date</DisplayName>
      <Description>Creation Date</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>        
      </Configuration>
    </Field>
    <Field name="ValidFrom" type="Hidden">
      <DisplayName>Valid From</DisplayName>
      <Description>Valid From</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name="ValidTill" type="Hidden">
      <DisplayName>Valid Until</DisplayName>
      <Description>Valid Until</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <Required>true</Required>
      </Configuration>
    </Field>
  </Fields>
</ContentType>

```

```csharp

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
