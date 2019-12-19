using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.Model.Base
{
    public abstract class BaseEntityWithTimestamp : EntityWithTimestamp
    {
        public int ID { get; set; }
    }
}
