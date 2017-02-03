using System;
using System.Web.DynamicData;
using System.Xml.Linq;

namespace DocumentManager.Core.Helpers.DynamicData
{
    public class DynamicMetaModel : MetaModel
    {
        private readonly XDocument form;
        private readonly XDocument additionalInfo;

        public DynamicMetaModel(XDocument form, string dataFolderVirtualPath = "~/Controls/", XDocument additionalInfo = null)
            : base(registerGlobally: false)
        {
            this.DynamicDataFolderVirtualPath = dataFolderVirtualPath;            
            this.additionalInfo = additionalInfo;
            this.form = form;
        }        

        public void RegisterContext()
        {
            try
            {
                this.RegisterContext(new DynamicModelProvider(form, additionalInfo));
            }
            catch (Exception)
            {

            }
        }
    }
}