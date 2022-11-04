using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO.MappingDTOs
{
    public class PostPictureDTO : BaseDTO
    {
        public Guid PostId { get; set; }

        public Guid PictureId { get; set; }

        public PostDTO Post { get; set; }

        public PictureDTO Picture { get; set; }
    }
}
