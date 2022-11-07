using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.SubscriberServiceFolder
{
    public interface ISubscriberService
    {
        string AddOrUpdateTheSubscriber(string email);
    }
}
