using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
    public class SubscriberDTO : BaseDTO
    {
        public string? SubscriberEmail { get; set; }

        public bool IsActivedTheEmail { get; set; }
    }
}
