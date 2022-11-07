using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.Enums
{
    public enum DbStatuEnums
    {
        EntityStillCreated = 1,
        EntityCreated = 2,
        EntityDeleted = 3,
        EntityUpdated = 4,
        EntityError = 99
    }
}
