using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Attributes
{
    public class F4ConfigurationAttribute : Attribute
    {
        public String XmlConfiguration { get; private set; }

        public XElement Configuration { get; private set; }

        public Boolean AutoPostBack { get; set; }

        public F4ConfigurationAttribute(String XmlConfiguration, Boolean autoPostBack = false)
        {
            this.XmlConfiguration = XmlConfiguration;
            this.AutoPostBack = autoPostBack;
        }

        public F4ConfigurationAttribute(XElement configuration, Boolean autoPostBack = false)
        {
            this.Configuration = configuration;
            this.AutoPostBack = autoPostBack;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (!String.IsNullOrEmpty(configuration.F4XmlConfiguration))
            {
                attributes.Add(new F4ConfigurationAttribute(configuration.F4XmlConfiguration, autoPostBack: configuration.AutoPostBack ?? false));
                return;
            }

            if (configuration.F4Configuration != null)
            {
                attributes.Add(new F4ConfigurationAttribute(configuration.F4Configuration, autoPostBack: configuration.AutoPostBack ?? false));
                return;
            }

        }
    }
}
