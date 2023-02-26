

using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using System.Runtime.CompilerServices;

namespace ITBlog.Business.DTO.ViewDTOs
{

    public class PostCategoryViewDTO
    {

        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }

    }

}
