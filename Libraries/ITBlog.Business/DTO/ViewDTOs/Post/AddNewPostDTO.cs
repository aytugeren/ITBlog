

using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using System.Runtime.CompilerServices;

namespace ITBlog.Business.DTO.ViewDTOs
{

    public class AddNewPostDTO : BaseDTO
    {

        public string Title { get; set; }

        public string ShortText { get; set; }

        public string Content { get; set; }

        public List<Guid> CategoryList { get; set; }


    }

}
