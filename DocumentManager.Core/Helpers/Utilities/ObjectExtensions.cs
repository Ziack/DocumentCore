using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Helpers.Utilities
{
    public static class ObjectExtensions
    {
        public static dynamic ToDynamic(this object obj) 
        {
            return ((obj as DocumentManager.Core.Helpers.XmlToDynamic.DynamicElement) as dynamic);
        }
    }
}
