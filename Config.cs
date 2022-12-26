using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity_Radio
{
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config
    {
        [Description("Is Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;
    }
}
