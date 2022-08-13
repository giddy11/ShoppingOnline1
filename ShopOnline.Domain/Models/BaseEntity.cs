using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Domain.Models
{
    public class BaseEntity
    {
        public virtual Guid ID { get; protected set; }
    }
}
