using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Schema.Behavior
{
    public interface ISupportProcess : IContentHandlerBehavior
    {
        bool Process(int? Id);
    }
}
