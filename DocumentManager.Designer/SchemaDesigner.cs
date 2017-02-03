using DocumentManager.Core;
using DocumentManager.Core.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Linq;

[assembly: WebResource("DocumentManager.Designer.Scripts.Designer.js", "text/javascript")]
[assembly: WebResource("DocumentManager.Designer.Scripts.Alpaca.dotnetnuke.js", "text/javascript")]
[assembly: WebResource("DocumentManager.Designer.Styles.Common.css", "text/css", PerformSubstitution = true)]
[assembly: WebResource("DocumentManager.Designer.Styles.Designer.css", "text/css", PerformSubstitution = true)]
[assembly: WebResource("DocumentManager.Designer.Styles.Glyphicons.css", "text/css", PerformSubstitution = true)]
[assembly: WebResource("DocumentManager.Designer.Styles.Fonts.glyphicons-halflings-regular.eot", "application/vnd.ms-fontobject")]
[assembly: WebResource("DocumentManager.Designer.Styles.Fonts.glyphicons-halflings-regular.svg", "image/svg+xml")]
[assembly: WebResource("DocumentManager.Designer.Styles.Fonts.glyphicons-halflings-regular.woff", "application/font-woff")]
[assembly: WebResource("DocumentManager.Designer.Styles.Fonts.glyphicons-halflings-regular.ttf", "application/octet-stream")]
namespace DocumentManager.Designer
{
    [ToolboxData("<{0}:SchemaDesigner runat=server></{0}:SchemaDesigner>")]
    [ParseChildren(ChildrenAsProperties = true)]
    [PersistChildren(false)]
    public class SchemaDesigner : WebControl, INamingContainer, IScriptControl, IPostBackDataHandler
    {
        private const String SUBMIT_CONTENT_TYPE_EVENT_ARGS = "submit";

        private HiddenField _schemaHF;

        protected HiddenField SchemaHF
        {
            get
            {
                if (this._schemaHF == null)
                {
                    this._schemaHF = new HiddenField()
                    {
                        ID = "SchemaHF"
                    };
                }
                return this._schemaHF;
            }
        }

        private HiddenField _optionHF;

        protected HiddenField OptionHF
        {
            get
            {
                if (this._optionHF == null)
                {
                    this._optionHF = new HiddenField()
                    {
                        ID = "OptionHF"
                    };
                }
                return this._optionHF;
            }
        }


        /// <summary>
        /// Gets or sets the Content Type.
        /// </summary>
        /// <value>
        /// ContentType.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Gets or sets the Content Type.
        /// </summary>
        /// <value>
        /// ContentType.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public IEnumerable<Assembly> ControlsAssemblies
        {
            get { return (IEnumerable<Assembly>)ViewState["ControlsAssemblies"]; }
            set { ViewState["ControlsAssemblies"] = value; }
        }

        /// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection" /> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        /// <returns>
        /// The collection of child controls for the specified server control.
        ///   </returns>
        public override ControlCollection Controls
        {
            get
            {
                this.EnsureChildControls();
                return base.Controls;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnInit(EventArgs e)
        {
            Page.RegisterRequiresPostBack(this);

            RegisterStyleSheet("DocumentManager.Designer.Styles.Glyphicons.css");
            RegisterStyleSheet("DocumentManager.Designer.Styles.Common.css");
            RegisterStyleSheet("DocumentManager.Designer.Styles.Designer.css");

            base.OnInit(e);
            this.EnsureChildControls();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            ScriptManager.GetCurrent(Page).RegisterScriptControl(this);

            base.OnPreRender(e);
        }

         /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            ScriptManager.GetCurrent(Page).RegisterScriptDescriptors(this);

            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "designer");
            writer.AddAttribute(HtmlTextWriterAttribute.Id, ClientID);
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {

            writer.RenderEndTag();
        }

         /// <summary>
        /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create 
        /// any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            var tabMenuContainer = new HtmlGenericControl("div");
            var tabMenu = new HtmlGenericControl("ul");
            tabMenu.Attributes.Add("class", "nav nav-tabs");

            var designerMenuOption = new HtmlGenericControl("li");
            designerMenuOption.Attributes.Add("class", "active");

            var designerMenuLink = new HtmlGenericControl("a");
            
            designerMenuLink.InnerText = "Designer";
            designerMenuLink.Attributes.Add("href", "#designer");
            designerMenuLink.Attributes.Add("class", "tab-item tab-item-designer");
            designerMenuLink.Attributes.Add("data-toggle", "tab");

            designerMenuOption.Controls.Add(designerMenuLink);

            var viewMenuOption = new HtmlGenericControl("li");

            var viewMenuLink = new HtmlGenericControl("a");

            viewMenuLink.InnerText = "View";
            viewMenuLink.Attributes.Add("href", "#view");
            viewMenuLink.Attributes.Add("class", "tab-item tab-item-view");
            viewMenuLink.Attributes.Add("data-toggle", "tab");

            viewMenuOption.Controls.Add(viewMenuLink);

            tabMenu.Controls.Add(designerMenuOption);
            tabMenu.Controls.Add(viewMenuOption);
            tabMenuContainer.Controls.Add(tabMenu);

            var tabContainer = new HtmlGenericControl("div");
            tabContainer.Attributes.Add("class", "tab-content");

            var designerTabContainer = new HtmlGenericControl("div");
            designerTabContainer.Attributes.Add("id", "designer");
            designerTabContainer.Attributes.Add("class", "tab-pane active");

            var designerContainer = new HtmlGenericControl("div");
            designerContainer.Attributes.Add("id", "designerDiv");
            designerTabContainer.Controls.Add(designerContainer);

            var controlsContainer = new HtmlGenericControl("div");
            controlsContainer.Attributes.Add("id", "types");
            designerTabContainer.Controls.Add(controlsContainer);

            var viewTabContainer = new HtmlGenericControl("div");
            viewTabContainer.Attributes.Add("id", "view");
            viewTabContainer.Attributes.Add("class", "tab-pane");

            var viewContainer = new HtmlGenericControl("div");
            viewContainer.Attributes.Add("id", "viewDiv");
            viewTabContainer.Controls.Add(viewContainer);

            tabContainer.Controls.Add(designerTabContainer);
            tabContainer.Controls.Add(viewTabContainer);

            this.Controls.Clear();
            this.Controls.Add(tabMenuContainer);
            this.Controls.Add(tabContainer);
            this.Controls.Add(this.OptionHF);
            this.Controls.Add(this.SchemaHF);

            base.CreateChildControls();
        }

        public IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            //var JSONControls = GetJSONControls(this.ControlsAssemblies);
            var JSONControls = @"[{""type"":""DateTimePicker"",""title"":""DateTimePicker"",""description"":""Propiedad DateTimePicker"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""},{""title"":""Hidden"",""description"":""Propiedad Hidden"",""type"":""Hidden"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""},{""description"":""Propiedad Number"",""title"":""Number"",""type"":""Number"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""},{""type"":""BooleanField"",""title"":""BooleanField"",""description"":""Propiedad Boolean"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""},{""type"":""DatePicker"",""title"":""DatePicker"",""description"":""Propiedad DatePicker"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""},{""title"":""MultilineText"",""type"":""MultilineText"",""description"":""MultilineText"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""},{""type"":""RadComboBox"",""title"":""RadComboBox"",""description"":""Propiedad RadComboBox"",""ExportTypeIdentity"":""DocumentManager.UI.Controls.FieldTemplates.Mobile.Helpers.TemplatesUserControl.ListFieldTemplateUserControl""},{""description"":""Propiedad ShortText"",""type"":""ShortText"",""title"":""ShortText"",""ExportTypeIdentity"":""DocumentManager.Core.FieldUserControl""}]";
            var JSONSchema = GetJSONSchema(contentType: this.ContentType);
            var JSONOptions = GetJSONOptions(contentType: this.ContentType);

            OptionHF.Value = JSONOptions;
            SchemaHF.Value = JSONSchema;

            var descriptor = new ScriptControlDescriptor("DocumentManager.Designer.Scripts.Designer", this.ClientID);
            descriptor.AddProperty("_optionHF", OptionHF.ClientID);
            descriptor.AddProperty("_schemaHF", SchemaHF.ClientID);
            descriptor.AddProperty("_types", JSONControls);
            descriptor.AddProperty("_schema", JSONSchema);
            descriptor.AddProperty("_options", JSONOptions);

            yield return descriptor;
        }

        public IEnumerable<ScriptReference> GetScriptReferences()
        {
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Knockout.js", this.GetType().Assembly.FullName);
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Localization.Globalize.min.js", this.GetType().Assembly.FullName);
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Localization.Alpaca.es.js", this.GetType().Assembly.FullName);
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Libs.jquery.tmpl.js", this.GetType().Assembly.FullName);
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Components.Alpaca.alpaca.js", this.GetType().Assembly.FullName);
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Alpaca.dotnetnuke.js", this.GetType().Assembly.FullName);
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Libs.dotnetnuke.js", this.GetType().Assembly.FullName);            
            yield return new ScriptReference("DocumentManager.Designer.Scripts.Designer.js", this.GetType().Assembly.FullName);
        }

        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            if (String.IsNullOrEmpty(SchemaHF.Value))
                throw new ArgumentNullException("SchemaHF");

            if (String.IsNullOrEmpty(OptionHF.Value))
                throw new ArgumentNullException("OptionHF");

            var JSONSchema = JObject.Parse(SchemaHF.Value);
            var JSONOptions = JObject.Parse(OptionHF.Value);

            if (!JSONSchema.HasValues)
                return true;

            this.ContentType = Assemble(schema: JSONSchema, options: JSONOptions);

            return true;
        }

        public void RaisePostDataChangedEvent() { }

        private String GetJSONControls(IEnumerable<Assembly> controlsAssemblies)
        {
            var controls = new List<IDictionary<String, Object>>();
            var catalog = new AggregateCatalog();

            controlsAssemblies.ToList().ForEach((assembly) =>
            {
                catalog.Catalogs.Add(new AssemblyCatalog(assembly));
            });

            var _container = new CompositionContainer(catalog);
            _container.GetExportedValueOrDefault<FieldUserControl>();
            var catalogControls = _container.Catalog;

            catalogControls.ToList().ForEach((control) =>
            {
                control.ExportDefinitions.ToList().ForEach(delegate(ExportDefinition value)
                {
                    controls.Add(value.Metadata);
                });
            });

            return JsonConvert.SerializeObject(controls);
        }

        private String GetJSONSchema(ContentType contentType)
        {
            var result = new JObject();

            if (contentType != null)
            {

                var jObject = new JObject();
                contentType.Fields.ForEach((field) =>
                {
                    var jField = JObject.FromObject(new { type = field.Type, required = field.Configuration.Required, title = field.DisplayName });

                    if (field.Configuration.MaxLength.HasValue)
                        jField["maxLength"] = field.Configuration.MaxLength;

                    jObject[field.Name] = jField;
                });


                result["properties"] = jObject;
                result["type"] = "object";
            }

            return result.ToString();
        }

        private String GetJSONOptions(ContentType contentType)
        {
            var result = new JObject();

            if (contentType != null)
            {
                var jObject = new JObject();
                contentType.Fields.ForEach((field) =>
                {
                    var jField = JObject.FromObject(new { label = field.DisplayName });

                    if (field.Configuration.MaxLength.HasValue)
                    {
                        jField["size"] = field.Configuration.MaxLength;
                        jField["DisplayName"] = field.DisplayName;
                    }


                    jObject[field.Name] = jField;
                });
                
                result["fields"] = jObject;

            }

            return result.ToString();
        }

        private ContentType Assemble(JObject schema, JObject options)
        {
            var contentType = this.ContentType ?? new ContentType { DisplayName = String.Empty, Handler = String.Empty, Name = String.Empty, ParentType = String.Empty };
            contentType.Fields = new FieldCollection();

            foreach (var property in schema["properties"])
            {                
                var jProperty = property.Value<JProperty>();
                var fieldOptions = options["fields"][jProperty.Name].Value<JObject>();

                var field = new Field()
                {
                    Type = jProperty.Value["type"].Value<String>(),                    
                    Name = jProperty.Name,
                    DisplayName = fieldOptions["label"].Value<String>(),
                    Description = fieldOptions["label"].Value<String>()
                };

                var configuration = new Configuration()
                {
                    Required = jProperty.Value["required"].Value<Boolean>()
                };                           

                field.Configuration = configuration;

                contentType.Fields.Add(field);
            }

            return contentType;
        }

        private void RegisterStyleSheet(string stylesheetResourceName)
        {
            if (this.Page.Header == null)
                throw new NotSupportedException(@"No <head runat=\""server\"" control found in page.");

            // Get the stylesheet resource URL
            var styleSheetUrl = this.Page.ClientScript.GetWebResourceUrl(
                                this.GetType(), stylesheetResourceName);

            // Check if this stylesheer is already registered
            var alreadyRegistered = this.Page.Header.Controls.OfType<HtmlLink>().Any(
                                    x => x.Href.Equals(styleSheetUrl));
            if (alreadyRegistered) return; // no work here

            // If not, register it
            var link = new HtmlLink();
            link.Attributes["rel"] = "stylesheet";
            link.Attributes["type"] = "text/css";
            link.Attributes["href"] = styleSheetUrl;


            this.Page.Header.Controls.Add(link);
        }

    }
}
