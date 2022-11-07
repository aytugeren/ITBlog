using ITBlog.Entities.Concrete.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.SubscriberFolder
{
    public class Subscriber : BaseEntity
    {
        public string? SubscriberEmail { get; set; }

        public bool IsActivedTheEmail { get; set; }
    }
}
