using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO.ViewDTOs
{
    public class ApiResultModel
    {
        public int Result { get; set; }
        public string? Error { get; set; }
    }
}
