using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Attributes
{
    public class DataPickerRadComboBoxAttribute : Attribute
    {
        public string Programado { get; private set; }

        public string ControlStartDate { get; private set; }

        public DataPickerRadComboBoxAttribute(string programado, string controlStartDate)
        {
            this.Programado = programado;
            this.ControlStartDate = controlStartDate;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            attributes.Add(new DataPickerRadComboBoxAttribute(configuration.Programado, configuration.ControlStartDate));
            return;
        }
    }
}
