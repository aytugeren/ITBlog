using ITBlog.Entities.Concrete.PlaceFolder;
using ITBlog.Entities.Concrete.PostFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO.MappingDTOs
{
    public class PostPlaceDTO : BaseDTO
    {
        public Guid PostId { get; set; }

        public Guid PlaceId { get; set; }

        public PostDTO Post { get; set; }

        public PlaceDTO Place { get; set; }
    }
}
