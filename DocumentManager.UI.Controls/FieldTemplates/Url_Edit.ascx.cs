using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;
using System.Linq;
using Newtonsoft.Json.Linq;
using DocumentManager.UI.Helpers;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class Url_EditField : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnDataBinding(EventArgs e)
        {

            var link = FieldValue as dynamic;

            if (link != null)
            {
                HyperLinkUrl.NavigateUrl = ProcessUrl(Convert.ToString(link["Value"]));
                HyperLinkUrl.Text = Convert.ToString(link["Text"]);
            }
        }

        private string ProcessUrl(string url)
        {
            if (url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                return Server.HtmlDecode(url);
            }

            return "http://" + Server.HtmlDecode(url); 
        }

        public override Control DataControl
        {
            get
            {
                return HyperLinkUrl;
            }
        }

    }
}