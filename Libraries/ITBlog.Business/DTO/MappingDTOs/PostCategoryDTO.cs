using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO.MappingDTOs
{
    public class PostCategoryDTO : BaseDTO
    {
        public Guid PostId { get; set; }

        public Guid CategoryId { get; set; }

        public PostDTO Post { get; set; }

        public CategoryDTO Category { get; set; }
    }
}
