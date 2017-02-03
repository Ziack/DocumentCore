using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DocumentManager.Core.Extensions;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Attributes
{
    public class SelectListStaticAttribute : Attribute
    {
        public string DataSource { get; private set; }
        public RepeatDirection RepeatDirection { get; private set; }

        public SelectListStaticAttribute(string dataSource, RepeatDirection repeatDirection)
        {
            this.DataSource = dataSource;
            this.RepeatDirection = repeatDirection;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (configuration.DataSource != null)
            {
                var repeatDirection = RepeatDirection.Vertical;

                if (!String.IsNullOrEmpty(configuration.RepeatDirection))
                {
                    repeatDirection = EnumsExtensions.FromString<RepeatDirection>(configuration.RepeatDirection);
                }

                //Convierte el xml en xml nodo
                foreach (XElement element in configuration.DataSource.DescendantsAndSelf())
                {
                    element.Name = XName.Get(element.Name.LocalName, String.Empty);
                }

                attributes.Add(new SelectListStaticAttribute(dataSource: configuration.DataSource.ToString(),
                                                                repeatDirection: repeatDirection));
            }
        }

    }
}